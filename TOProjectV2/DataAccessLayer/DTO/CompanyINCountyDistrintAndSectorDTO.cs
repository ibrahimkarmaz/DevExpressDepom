using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.DTO
{
    public class CompanyINCountyDistrintAndSectorDTO
    {
        public int CompanyID { get; set; }
        public string CompanyName { get; set; }
        public string SectorName { get; set; }
        public string CompanyOfficialTC { get; set; }
        public string CompanyOfficialNameSurName { get; set; }
        public string CompanyOfficialStatus { get; set; }
        public string CompanyPhone1 { get; set; }
        public string CompanyPhone2 { get; set; }
        public string CompanyPhone3 { get; set; }
        public string CompanyMail { get; set; }
        public string CompanyFax { get; set; }
        public string CompanyTaxOffice { get; set; }
        public string CountyName { get; set; }
        public string DistrictName { get; set; }
        public string CompanyAddress { get; set; }
        public bool CompanyArchive { get; set; }

    }
}
