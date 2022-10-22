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
    public class BlandCommonValidationControl
    {
        public bool BlandValidatorAndMessage(Bland bland,string BlandName)
        {
            BlandValidator blandValidator = new BlandValidator(BlandName);
            ValidationResult result = blandValidator.Validate(bland);//BURAYA DİKKAT KÜTÜPHANE OLARAK:using FluentValidation.Results;
            if (result.IsValid)//EĞER TRUE İSE HATA YOK DEMEKTİR.
                return true;
            else
                XtraMessageBox.Show(result.Errors[0].ToString(), "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;

        }
    }
}
