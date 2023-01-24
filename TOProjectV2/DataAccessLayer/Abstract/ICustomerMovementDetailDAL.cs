using DataAccessLayer.DTO;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
	public interface ICustomerMovementDetailDAL : IGenericDAL<CustomerMovementDetail>
	{
		List<CustomerMovementDetailDTO> GetAllCustomerMovementDetail(Expression<Func<CustomerMovementDetailDTO, bool>> filter = null);
		List<CustomerMovementDetail> GetByFilter(Expression<Func<CustomerMovementDetail, bool>> filter = null);
	}
}
