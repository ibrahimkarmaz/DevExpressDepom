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
    public class CustomerCommonValidationControl
    {
        public bool CustomerValidatorAndMessage(Customer customer)
        {
            CustomerValidator blandValidator = new CustomerValidator(customer.CustomerTC);
            ValidationResult result = blandValidator.Validate(customer);//BURAYA DİKKAT KÜTÜPHANE OLARAK:using FluentValidation.Results;
            return (new AAAValidatorCommonArea().CheckAndRotate(result));

        }
    }
}
