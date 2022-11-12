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
    public class EFBankDAL : GenericRepository<Bank>, IBankDAL
    {
        Context _context = new Context();
        public List<BankINCountyDistrintAndCompanyDTO> GetAllBank(Expression<Func<BankINCountyDistrintAndCompanyDTO, bool>> filter = null)
        {
            return (from bank in _context.Banks
                    join county in _context.Countys
                    on bank.CountyID equals county.CountyID
                    join distinct in _context.Districts
                    on bank.DistrictID equals distinct.DistrictID
                    join company in _context.Companies
                    on bank.CompanyID equals company.CompanyID
                    select new BankINCountyDistrintAndCompanyDTO
                    {
                        BankID=bank.BankID,
                        BankName=bank.BankName,
                        CountyName=county.CountyName,
                        DistrictName=distinct.DistrictName,
                        BankBranch=bank.BankBranch,
                        IBAN=bank.IBAN,
                        BankAccountNo=bank.BankAccountNo,
                        BankOfficial=bank.BankOfficial,
                        BankPhone=bank.BankPhone,
                        BankDate=bank.BankDate,
                        BankAccountType=bank.BankAccountType,
                        CompanyName=company.CompanyName,
                        BankArchive=bank.BankArchive
                    }).Where(filter).ToList();
        }
    }
}
