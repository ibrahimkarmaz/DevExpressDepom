using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.DTO;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EFCustomerDAL : GenericRepository<Customer>, ICustomerDAL
    {
        Context _context = new Context();
        public List<CustomerINCountyAndDistrintDTO> CustomerGetList(Expression<Func<CustomerINCountyAndDistrintDTO, bool>> filter = null)
        {
            return (from customer in _context.Customers
                    join county in _context.Countys
                    on customer.CountyID equals county.CountyID
                    join district in _context.Districts
                    on customer.DistrictID equals district.DistrictID
                    select new CustomerINCountyAndDistrintDTO
                    {
                        CustomerID = customer.CustomerID,
                        CustomerTC = customer.CustomerTC,
                        CustomerName=customer.CustomerName,
                        CustomerSurName=customer.CustomerSurName,
                        CustomerGender=(customer.CustomerGender==true ? "BAY":"BAYAN"),
                        CustomerDateOfBirth=customer.CustomerDateOfBirth,
                        CustomerMobilePhone=customer.CustomerMobilePhone,
                        CustomerOfficePhone=customer.CustomerOfficePhone,
                        CustomerMail=customer.CustomerMail,
                        CustomerHomeAddress=customer.CustomerHomeAddress,
                        CustomerTaxNumber=customer.CustomerTaxNumber,
                        CountyName=county.CountyName,
                        DistrictName=district.DistrictName,
                        CustomerArchive=customer.CustomerArchive
                    }).Where(filter).ToList();
        }

        public bool GetByTC(Expression<Func<Customer, bool>> filter = null)
        {
            if (_context.Customers.Where(filter).ToList().Count() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

		public List<Customer> GetListWhoIsBirthday(Expression<Func<Customer, bool>> filter = null)
		{
            if (filter==null)
            {
				return _context.Customers.ToList();
			}
            return _context.Customers.Where(filter).ToList();
		}
	}
}
