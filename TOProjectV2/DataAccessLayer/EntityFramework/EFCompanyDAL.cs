using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.DTO;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EFCompanyDAL : GenericRepository<Company>, ICompanyDAL
    {
        Context _context = new Context();
        public List<CompanyINCountyDistrintAndSectorDTO> CompanyGetList(Expression<Func<CompanyINCountyDistrintAndSectorDTO, bool>> filter = null)
        {
            return (from company in _context.Companies
                    join county in _context.Countys
                    on company.CountyID equals county.CountyID
                    join district in _context.Districts
                    on company.DistrictID equals district.DistrictID
                    join sector in _context.Sectors
                    on company.SectorID equals sector.SectorID
                    select new CompanyINCountyDistrintAndSectorDTO
                    {
                        CompanyID=company.CompanyID,
                        CompanyName=company.CompanyName,
                        SectorName=sector.SectorName,
                        CompanyOfficialTC=company.CompanyOfficialTC,
                        CompanyOfficialNameSurName=company.CompanyOfficialNameSurName,
                        CompanyOfficialStatus=company.CompanyOfficialStatus,
                        CompanyPhone1=company.CompanyPhone1,
                        CompanyPhone2=company.CompanyPhone2,
                        CompanyPhone3=company.CompanyPhone3,
                        CompanyMail=company.CompanyMail,
                        CompanyFax=company.CompanyFax,
                        CompanyTaxOffice=company.CompanyTaxOffice,
                        CountyName=county.CountyName,
                        DistrictName=district.DistrictName,
                        CompanyAddress=company.CompanyAddress,
                        CompanyArchive=company.CompanyArchive
                    }).Where(filter).ToList();
        }
    }
}
