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
    public class BankCommonValidatorControl
    {
        public bool BankValidatorAndMessage(Bank bank)
        {
            BankValidator bankValidator = new BankValidator();
            ValidationResult result = bankValidator.Validate(bank);//BURAYA DİKKAT KÜTÜPHANE OLARAK:using FluentValidation.Results;
            return (new AAAValidatorCommonArea().CheckAndRotate(result));

        }
    }
}
