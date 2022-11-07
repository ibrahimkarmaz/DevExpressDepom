using BusinessLayer.FluentValidation;
using DevExpress.XtraEditors;
using EntityLayer.Concrete;
using FluentValidation;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.CommonValidationControls
{
    public class EmployeeCommonValidatorControl
    {
        public bool EmployeeValidatorAndMessage(Employee employee)
        {
            EmployeeValidator employeeValidator = new EmployeeValidator(employee.EmployeeTC);
            ValidationResult result = employeeValidator.Validate(employee);//BURAYA DİKKAT KÜTÜPHANE OLARAK:using FluentValidation.Results;
            return (new AAAValidatorCommonArea().CheckAndRotate(result));

        }
    }
}
