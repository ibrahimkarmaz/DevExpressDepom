﻿using DataAccessLayer.DTO;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IInvoiceService:IGenericService<Invoice>
    {
        List<CompanyMovementInvoiceDTO> GetAllCompanyMovementInvoice(Expression<Func<CompanyMovementInvoiceDTO, bool>> filter = null);
    }
}
