using AutoMapper;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.DTO
{//VERSİYON 10.0 AutoMapper
    public class AutoMapperProfiles:Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Product, ProductINBlandAndModelDTO>()
                .ForMember(productX => productX.ProductID, productDTO => productDTO.MapFrom(x => x.ProductID));
        }
    }
}
