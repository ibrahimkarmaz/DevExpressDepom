using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.DTO;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EFProductDAL : GenericRepository<Product>, IProductDAL
    {
        Context _context = new Context();

        public List<ProductINBlandAndModelDTO> ProductGetList(Expression<Func<ProductINBlandAndModelDTO, bool>> filter = null)
        {
            return (from p in _context.Products
                    join b in _context.Blands
                    on p.BlandID equals b.BlandID
                    join m in _context.Models
                    on p.ModelID equals m.ModelID
                    select new ProductINBlandAndModelDTO
                    {
                        ProductID = p.ProductID,
                        ProductName = p.ProductName,
                        ProductPiece = p.ProductPiece,
                        ProductPurchasePrice =p.ProductPurchasePrice,
                        ProductSalePrice =p.ProductSalePrice,
                        ProductDetails = p.ProductDetails,
                        BlandID = b.BlandID,
                        BlandName = b.BlandName,
                        ModelID = m.ModelID,
                        ModelName = m.ModelName,
                        ModelYear = m.ModelYear,
                        ProductArchive = p.ProductArchive
                    }).Where(filter).ToList();
        }
    }
}