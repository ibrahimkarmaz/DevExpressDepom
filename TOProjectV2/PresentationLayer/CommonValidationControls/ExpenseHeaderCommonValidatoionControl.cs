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
    public class ExpenseHeaderCommonValidatoionControl
    {
        public bool ExpenseHeaderalidatorAndMessage(ExpenseHeader expenseHeader)
        {
            ExpenseHeaderValidator expenseHeaderValidator = new ExpenseHeaderValidator(expenseHeader.ExprenseHeaderStartDate.ToString(),expenseHeader.ExprenseHeaderStopDate.ToString());
            ValidationResult result = expenseHeaderValidator.Validate(expenseHeader);//BURAYA DİKKAT KÜTÜPHANE OLARAK:using FluentValidation.Results;
            return (new AAAValidatorCommonArea().CheckAndRotate(result));

        }
    }
}
