using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.DTO;
using DataAccessLayer.Migrations;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EFCompanyMovementDetailDAL : GenericRepository<CompanyMovementDetail>, ICompanyMovementDetailDAL
    {   Context _context = new Context();
        public List<CompanyMovementDetailDTO> GetAllCompanyMovementDetail(Expression<Func<CompanyMovementDetailDTO, bool>> filter = null)
        {
            return (from companyMovementDetail in _context.CompanyMovementDetails
                    join companyMovement in _context.CompanyMovements
                    on companyMovementDetail.CompanyMovementID equals companyMovement.CompanyMovementID
                    join product in _context.Products
                    on companyMovementDetail.ProductID equals product.ProductID
                    join bland in _context.Blands
                    on product.BlandID equals bland.BlandID
                    join model in _context.Models
                    on product.ModelID equals model.ModelID
                    select new CompanyMovementDetailDTO
                    {
                        CompanyMovementDetailID = companyMovementDetail.CompanyMovementDetailID,
                        ProductID = product.ProductID,
                        ProductName = product.ProductName,
                        BlandName = bland.BlandName,
                        ModelName = model.ModelName,
                        CompanyMovementDetailPiece = companyMovementDetail.CompanyMovementDetailPiece,
                        CompanyMovementDetailPrice = companyMovementDetail.CompanyMovementDetailPrice,
                        CompanyMovementDetailTotalPrice = companyMovementDetail.CompanyMovementDetailTotalPrice,
                        CompanyMovementID = companyMovement.CompanyMovementID
                    }
                    ).Where(filter).ToList();
        }
    }
}
