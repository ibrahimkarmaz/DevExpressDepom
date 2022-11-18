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
    public class EFInvoiceDAL : GenericRepository<Invoice>, IInvoiceDAL
    {
        Context _context = new Context();
        public List<CompanyMovementInvoiceDTO> GetAllCompanyMovementInvoice(Expression<Func<CompanyMovementInvoiceDTO, bool>> filter = null)
        {
             return (from invoice in _context.Invoices
                  join companyMovement in _context.CompanyMovements
                  on invoice.CompanyMovementID equals companyMovement.CompanyMovementID
                  join employee in _context.Employees
                  on companyMovement.EmployeeID equals employee.EmployeeID
                  join company in _context.Companies
                  on companyMovement.CompanyID equals company.CompanyID
                  select new CompanyMovementInvoiceDTO
                  {
                      InvoiceID=invoice.InvoiceID,
                      InvoiceSeries=invoice.InvoiceSeries,
                      CompanyName=company.CompanyName,
                      EmployeeNameSurName = employee.EmployeeName+" "+ employee.EmployeeSurName,
                      CompanyMovementDate=companyMovement.CompanyMovementDate,
                      CompanyMovemenNote=companyMovement.CompanyMovemenNote,
                      CompanyMovemenArchive=companyMovement.CompanyMovemenArchive
                  }
                  ).Where(filter).ToList();
        }
    }
}
