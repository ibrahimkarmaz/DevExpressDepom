using BusinessLayer.FluentValidation;
using EntityLayer.Concrete;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer.CommonValidationControls
{
    public class CompanyMovementDetailCommonValidatorControl
    {
        public bool CompanyMovementDetailValidatorAndMessage(CompanyMovementDetail companyMovementDetail)
        {
            CompanyMovementDetailValidator companyMovementDetailValidator = new CompanyMovementDetailValidator();
            ValidationResult result = companyMovementDetailValidator.Validate(companyMovementDetail);//BURAYA DİKKAT KÜTÜPHANE OLARAK:using FluentValidation.Results;
            return (new AAAValidatorCommonArea().CheckAndRotate(result));

        }
    }
}
