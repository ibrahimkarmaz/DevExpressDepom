using BusinessLayer.Concrete;
using DataAccessLayer.DTO;
using DataAccessLayer.EntityFramework;
using DevExpress.XtraEditors;
using EntityLayer.Concrete;
using PresentationLayer.CommonValidationControls;
using PresentationLayer.WinFormList.CompanyWF;
using PresentationLayer.WinFormList.EmployeeWF;
using PresentationLayer.WinFormList.ProductWF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace PresentationLayer.WinFormList.CompanyMovement
{
    public partial class CompanyMovementWF : DevExpress.XtraEditors.XtraForm
    {
        public CompanyMovementWF()
        {
            InitializeComponent();
        }
        CompanyMovementManager _companyMovementManager = new CompanyMovementManager(new EFCompanyMovementDAL());
        CompanySelectDTO companySelect=new CompanySelectDTO();
        private void BECompany_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

            CompanySelectWF.companySelectStatus = false;
            CompanySelectWF.companySelect = null;
            CompanySelectWF companySelectWF = new CompanySelectWF();
            companySelectWF.ShowDialog();
            companySelect = CompanySelectWF.companySelect;
            if (CompanySelectWF.companySelectStatus)
            {

                //Console.WriteLine(companySelect.CompanyID);
                BECompany.Text = companySelect.CompanyName;
            }
        }
        EmployeeSelectDTO employeeSelect=new EmployeeSelectDTO();
        private void BEEmployee_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            EmployeeSelectWF.EmployeeSelectStatus = false;
            employeeSelect = null;
            EmployeeSelectWF employeeSelectWF = new EmployeeSelectWF();
            employeeSelectWF.ShowDialog();
            employeeSelect = EmployeeSelectWF.employeeSelect;
            if (EmployeeSelectWF.EmployeeSelectStatus)
            {
                BEEmployee.Text = employeeSelect.EmployeeNameSurName;
            }
        }

        private void CompanyMovementWF_Load(object sender, EventArgs e)
        {
        }
        
        private void SBtnCompanyMovement_Click(object sender, EventArgs e)
        {/*CompanyMovement Bu dosya ismi olduğu için direk kullanamadık.*/
            
            try
            {
                EntityLayer.Concrete.CompanyMovement companyMovement = new EntityLayer.Concrete.CompanyMovement();
                if (employeeSelect.EmployeeID!=null)
                {
                    companyMovement.EmployeeID = employeeSelect.EmployeeID;
                }
                else
                {
                    companyMovement.EmployeeID = null;
                }

                if (companySelect.CompanyID!=null)
                {
                    companyMovement.CompanyID = companySelect.CompanyID;
                }
                else
                {
                    companyMovement.CompanyID = null;
                }
                if (TECreateDate.Text!="")
                {
                    companyMovement.CompanyMovementDate = Convert.ToDateTime(TECreateDate.Text);
                }
                else
                {
                    companyMovement.CompanyMovementDate = null;
                }
               
               
                companyMovement.CompanyMovemenNote = MMENote.Text;
                companyMovement.CompanyMovemenArchive = true;
                if (new CompanyMovementCommonValidatorControl().CompanyMovementValidatorAndMessage(companyMovement))
                {
                    _companyMovementManager.TAdd(companyMovement);
                    XtraMessageBox.Show("YENİ FİRMA HAREKETİ OLUŞTURULDU.\nÜRÜN BİLGİSİ İŞLEMLERİNİ UYGULAYABİLİRSİNİZ.\nVE RAPOR OLUŞTURABİLİRSİNİZ.", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    accordionControlProduct.Enabled = true;
                    GControlCompanyMovement.Enabled = true;
                    GroupControlFin.Enabled = true;
                    SBtnCompanyMovement.Text = "Firma Hareketini Bilgisini Düzenle";
                }
            }
            catch (Exception)
            {
                XtraMessageBox.Show("FİRMA HAREKETİ BİLGİLERİNİ DOLDURUNUZ.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}