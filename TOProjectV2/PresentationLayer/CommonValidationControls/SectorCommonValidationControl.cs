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
    public class SectorCommonValidationControl
    {
        public bool SectorValidatorAndMessage(Sector sector)
        {
            SectorValidator sectorValidator = new SectorValidator();
            ValidationResult result = sectorValidator.Validate(sector);//BURAYA DİKKAT KÜTÜPHANE OLARAK:using FluentValidation.Results;
            return (new AAAValidatorCommonArea().CheckAndRotate(result));
        }
    }
}
