using DevExpress.XtraEditors;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.CommonValidationControls
{
    public class AAAValidatorCommonArea
    {
        public bool CheckAndRotate(ValidationResult result)
        {
            if (result.IsValid)//EĞER TRUE İSE HATA YOK DEMEKTİR.
                return true;
            else
                XtraMessageBox.Show(result.Errors[0].ToString(), "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }
    }
}
