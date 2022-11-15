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
    public class CompanyMovementCommonValidatorControl
    {
        public bool CompanyMovementValidatorAndMessage(CompanyMovement companyMovement)
        {
            CompanyMovementValidator companyMovementValidator = new CompanyMovementValidator();
            ValidationResult result = companyMovementValidator.Validate(companyMovement);//BURAYA DİKKAT KÜTÜPHANE OLARAK:using FluentValidation.Results;
            return (new AAAValidatorCommonArea().CheckAndRotate(result));
        }
    }
}
