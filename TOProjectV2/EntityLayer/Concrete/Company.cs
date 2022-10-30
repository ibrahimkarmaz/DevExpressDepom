﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Company
    {
        public int CompanyID { get; set; }
        public string CompanyName { get; set; }
        public string CompanyOfficialNameSurName { get; set; }
        public string CompanyOfficialStatus { get; set; }
        public string CompanyPhone1 { get; set; }
        public string CompanyPhone2 { get; set; }
        public string CompanyPhone3 { get; set; }
        public string CompanyMail { get; set; }
        public string CompanyFax { get; set; }
        public string CompanyTown { get; set; }
        public string CompanyCounty { get; set; }
        public string CompanyTaxOffice { get; set; }
        public string CompanyAddress { get; set; }
        public bool CompanyArchive { get; set; }
    }
}