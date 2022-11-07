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
    public class ExpenseContentCommonValidationControl
    {
        public bool DepartmentValidatorAndMessage(ExpenseContent expenseContent)
        {
            ExpenseContentValidator expenseContentValidator = new ExpenseContentValidator();
            ValidationResult result = expenseContentValidator.Validate(expenseContent);//BURAYA DİKKAT KÜTÜPHANE OLARAK:using FluentValidation.Results;
            return (new AAAValidatorCommonArea().CheckAndRotate(result));
        }
    }
}
