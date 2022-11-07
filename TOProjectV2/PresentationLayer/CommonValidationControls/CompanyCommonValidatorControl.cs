using BusinessLayer.FluentValidation;
using DevExpress.XtraEditors;
using EntityLayer.Concrete;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.CommonValidationControls
{
    public class CompanyCommonValidatorControl
    {
        public bool CompanyValidatorAndMessage(Company company)
        {
            CompanyValidator companyValidator = new CompanyValidator();
            ValidationResult result = companyValidator.Validate(company);//BURAYA DİKKAT KÜTÜPHANE OLARAK:using FluentValidation.Results;
            return(new AAAValidatorCommonArea().CheckAndRotate(result));

        }
    }
}
