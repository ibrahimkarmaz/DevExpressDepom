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
	public class EFCustomerMovementInvoiceDAL : GenericRepository<CustomerMovementInvoice>, ICustomerMovementInvoiceDAL
	{
		Context _context = new Context();
		public List<CustomerMovementInvoiceDTO> GetAllCustomerMovementInvoice(Expression<Func<CustomerMovementInvoiceDTO, bool>> filter = null)
		{
			if (filter != null)
			{
				return (from invoice in _context.CustomerMovementInvoices
						join customerMovement in _context.CustomerMovements
						on invoice.CustomerMovementID equals customerMovement.CustomerMovementID
						join employee in _context.Employees
						on customerMovement.EmployeeID equals employee.EmployeeID
						join customer in _context.Customers
						on customerMovement.CustomerID equals customer.CustomerID
						select new CustomerMovementInvoiceDTO
						{
							InvoiceID = invoice.CustomerMovementInvoiceID,
							InvoiceSeries = invoice.CustomerMovementInvoiceSeries,
							CustomerName = customer.CustomerName,
							EmployeeNameSurName = employee.EmployeeName + " " + employee.EmployeeSurName,
							CustomerMovementDate = customerMovement.CustomerMovementDate,
							CustomerMovemenNote = customerMovement.CustomerMovemenNote,
							CustomerMovemenArchive = customerMovement.CustomerMovemenArchive
						}
								 ).Where(filter).ToList();
			}
			return (from invoice in _context.CustomerMovementInvoices
					join customerMovement in _context.CustomerMovements
					on invoice.CustomerMovementID equals customerMovement.CustomerMovementID
					join employee in _context.Employees
					on customerMovement.EmployeeID equals employee.EmployeeID
					join customer in _context.Customers
					on customerMovement.CustomerID equals customer.CustomerID
					select new CustomerMovementInvoiceDTO
					{
						InvoiceID = invoice.CustomerMovementInvoiceID,
						InvoiceSeries = invoice.CustomerMovementInvoiceSeries,
						CustomerName = customer.CustomerName,
						EmployeeNameSurName = employee.EmployeeName + " " + employee.EmployeeSurName,
						CustomerMovementDate = customerMovement.CustomerMovementDate,
						CustomerMovemenNote = customerMovement.CustomerMovemenNote,
						CustomerMovemenArchive = customerMovement.CustomerMovemenArchive
					}
								 ).ToList();


		}
	}
}
