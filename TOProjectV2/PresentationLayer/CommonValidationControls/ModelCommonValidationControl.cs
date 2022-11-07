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
    public class ModelCommonValidationControl
    {
        public bool ModelValidatorAndMessage(Model model)
        {
            ModelValidator modelValidator = new ModelValidator();
            ValidationResult result = modelValidator.Validate(model);//BURAYA DİKKAT KÜTÜPHANE OLARAK:using FluentValidation.Results;
            return (new AAAValidatorCommonArea().CheckAndRotate(result));
        }
    }
}
