using DataAccessLayer.DTO;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
	public interface ICustomerMovementDetailService:IGenericService<CustomerMovementDetail>
	{
		List<CustomerMovementDetailDTO> GetAllCustomerMovementDetail(Expression<Func<CustomerMovementDetailDTO, bool>> filter = null);
	}
}
