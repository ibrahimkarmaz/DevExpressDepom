using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.DTO;
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
	public class EFCustomerMovementDetailDAL : GenericRepository<CustomerMovementDetail>, ICustomerMovementDetailDAL
	{
		Context _context = new Context();

		public List<CustomerMovementDetailDTO> GetAllCustomerMovementDetail(Expression<Func<CustomerMovementDetailDTO, bool>> filter = null)
		{
			return (from customerMovementDetail in _context.CustomerMovementDetails
					join customeryMovement in _context.CustomerMovements
					on customerMovementDetail.CustomerMovementID equals customeryMovement.CustomerMovementID
					join product in _context.Products
					on customerMovementDetail.ProductID equals product.ProductID
					join bland in _context.Blands
					on product.BlandID equals bland.BlandID
					join model in _context.Models
					on product.ModelID equals model.ModelID
					select new CustomerMovementDetailDTO
					{
						CustomerMovementDetailID = customerMovementDetail.CustomerMovementDetailID,
						ProductID = product.ProductID,
						ProductName = product.ProductName,
						BlandName = bland.BlandName,
						ModelName = model.ModelName,
						CustomerMovementDetailPiece = customerMovementDetail.CustomerMovementDetailPiece,
						CustomerMovementDetailPrice = customerMovementDetail.CustomerMovementDetailPrice,
						CustomerMovementDetailTotalPrice = customerMovementDetail.CustomerMovementDetailTotalPrice,
						CustomerMovementID = customeryMovement.CustomerMovementID
					}
				   ).Where(filter).ToList();
		}

		public List<CustomerMovementDetail> GetByFilter(Expression<Func<CustomerMovementDetail, bool>> filter = null)
		{
			return _context.CustomerMovementDetails.Where(filter).ToList();
		}
	}
}
