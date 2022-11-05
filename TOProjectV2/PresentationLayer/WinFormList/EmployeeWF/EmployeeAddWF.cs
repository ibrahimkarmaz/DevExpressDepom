using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using DevExpress.Pdf.Native.BouncyCastle.Ocsp;
using DevExpress.XtraEditors;
using DevExpress.XtraPrinting;
using EntityLayer.Concrete;
using PresentationLayer.CommonValidationControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.WinFormList.EmployeeWF
{
    public partial class EmployeeAddWF : DevExpress.XtraEditors.XtraForm
    {
        public EmployeeAddWF()
        {
            InitializeComponent();
        }
        DragDropProvider Move;
        OpenFileDialog ImageSelect = new OpenFileDialog();
        CountyManager _countyManager = new CountyManager(new EFCountyDAL());
        DistrictManager _districtManager = new DistrictManager(new EFDistrictDAL());
        DepartmentManager _departmentManager = new DepartmentManager(new EFDepartmentDAL());
        EmployeeManager _employeeManager = new EmployeeManager(new EFEmployeeDAL());
        private void GetAllCounty()
        {
            LUECounty.Properties.DataSource = _countyManager.GetAllList();
        }
        private void GetAllDistrict()
        {
            LUEDistrict.Properties.DataSource = _districtManager.GetAllList(x => x.CountyID == (int)LUECounty.EditValue);
        }
        private void GetAllDepartment()
        {
            LUEDepartment.Properties.DataSource = _departmentManager.GetAllList(x=>x.DepartmentArchive==true);
        }
        private void EmployeeAddWF_Load(object sender, EventArgs e)
        {
            ImageSelectOptions();
            CBEGender.Properties.Items.Add("BAYAN");
            CBEGender.Properties.Items.Add("BAY");
            GetAllDepartment();
            GetAllCounty();
        }

        string NewImageNameInfo, ImageNewAddress;
        private void NewImageName()
        {
            NewImageNameInfo = @"image\" + Guid.NewGuid() + ".jpg";
            ImageNewAddress = Application.StartupPath + "\\" + NewImageNameInfo;
        }
         bool ImageTransleError = true;
        private void ImageCopy()
        {
            try
            {
                if (PEEmployee.GetLoadedImageLocation() == "")
                {
                    File.Copy(ImageSelect.FileName, ImageNewAddress);
                }
                else
                {
                    File.Copy(PEEmployee.GetLoadedImageLocation(), ImageNewAddress);
                }
                ImageTransleError = true;
            }
            catch (Exception)
            {
                ImageTransleError = false;
               // XtraMessageBox.Show("FOTOĞRAF SEÇİLMELİ","HATA",MessageBoxButtons.OK,MessageBoxIcon.Hand);
            }
        }

        private void BtnImageSelect_Click(object sender, EventArgs e)
        {
            if (ImageSelect.ShowDialog()==DialogResult.OK)
            {
                PEEmployee.Image = Image.FromFile(ImageSelect.FileName);
            }
        }

        private void PEEmployee_DragDrop(object sender, DragEventArgs e)
        {
            // SÜRÜKLE BIRAK SONRASINDA RESMİN ADRESİNİ ALINMASI GEREKİYOR.
            ImageSelect.FileName = Move.FileLocation;
        }

        private void SBCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SBtnSave_Click(object sender, EventArgs e)
        {
            ////BURADA KENDİ ADRESİMİZ İÇİNDE Kİ AD İLE GENEL ADRESİ AYIRIYORUZ.(KENDİ ADRESİMİZLE DİREK ULAŞABİLİRİZ.)
            NewImageName();//YENİ RESİM DOSYA YOLU
            ImageCopy();//YENİ ADRESE KOPYALAMA
            EmployeeInfomationReadyANDSave();//PERSONEL BİLGİLERİNİ HAZIRLAMA VE KAYIT

            //RESİMDE SORUN VARSA ImageTransleError İLE BELİRT. AMA İLK NORMAL KONTROLLER.

        }
        Employee employee;
        private void EmployeeInfomationReadyANDSave()
        {
            try
            {
                employee = new Employee();
                if (ImageTransleError)
                {
                    employee.EmployeeImage = NewImageNameInfo;
                }
                else
                {
                    employee.EmployeeImage = null;
                }

                if (LUEDepartment.EditValue!=null)
                {
                    employee.DepartmentID=(int)LUEDepartment.EditValue;
                }
                else
                {
                    employee.DepartmentID = null;
                }

                employee.EmployeeTC = TETC.Text;
                employee.EmployeeName = TEFirstName.Text;
                employee.EmployeeSurName = TELasName.Text;
                if (CBEGender.SelectedIndex == 1 || CBEGender.SelectedIndex == 0)//2 CİNSİYET İÇİN KONTROL
                {
                    employee.EmployeeGender = Convert.ToBoolean(CBEGender.SelectedIndex);
                }
                else
                {
                    employee.EmployeeGender = null;
                }

                if (TEBirthOfDate.Text != "")//TE DATETİMEPİCKER SEÇİLDİĞİNDE NULL GELMEZ.
                {
                    employee.EmployeeDateOfBirth = Convert.ToDateTime(TEBirthOfDate.Text);
                }
                else
                {
                    employee.EmployeeDateOfBirth = null;
                }

                employee.EmployeePhone = TEMobilePhone.Text;
                employee.EmployeeMail = TEMail.Text;

                if (LUECounty.EditValue != null)//İL SEÇİLMEMESİ DURUMUNDA ÇALIŞIR
                {
                    employee.CountyID = (int)LUECounty.EditValue;
                }
                else
                {
                    employee.CountyID = null;
                }

                if (LUEDistrict.EditValue != null)//İLÇE SEÇİLMEMESİ DURUMUNDA ÇALIŞIR
                {
                    employee.DistrictID = (int)LUEDistrict.EditValue;
                }
                else
                {
                    employee.DistrictID = null;
                }
                employee.EmployeeHomeAddress = MMEHomeAddress.Text;
                employee.EmployeeArchive = true;

                if (new EmployeeCommonValidatorControl().EmployeeValidatorAndMessage(employee))
                {
                    _employeeManager.TAdd(employee);
                    XtraMessageBox.Show("YENİ PERSONEL KAYDEDİLDİ.", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception)
            {
                XtraMessageBox.Show("PERSONEL BİLGİLERİNİ DOLDURUNUZ.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LUECounty_EditValueChanged(object sender, EventArgs e)
        {
            GetAllDistrict();
        }

        private void SBtnApploval_Click(object sender, EventArgs e)
        {
            //REFERANSA EKLENEN ADRES https://tckimlik.nvi.gov.tr/Service/KPSPublic.asmx?WSDL
            if (XtraMessageBox.Show("T.C KİMLİK KONTROL SİSTEMİ İÇİN;\n-T.C\n-AD\n-SOYAD\n-DOĞUM TARİHİ\nBİLGİLERİ DOĞRU GİRİLDİĞİNDEN EMİN OLUNUZ.\n\n\nT.C KİMLİK NUMARASINI KONTROL EDİLSİN Mİ ?", "T.C KİMLİK NUMARASI KONTROL", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                TCInformationControl.KPSPublicSoapClient TCCOntrol = new TCInformationControl.KPSPublicSoapClient();
                DateTime Year = Convert.ToDateTime(TEBirthOfDate.Text);
                if (TCCOntrol.TCKimlikNoDogrula(long.Parse(TETC.Text), TEFirstName.Text, TELasName.Text, int.Parse(Year.Year.ToString())))
                {
                    XtraMessageBox.Show("T.C KİMLİK NUMARASI DOĞRULANDI.", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    XtraMessageBox.Show("T.C KİMLİK NUMARASI BULUNAMADI.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        void ImageSelectOptions()
        {
            ImageSelect.Title = "Resim Seç";
            ImageSelect.Filter = "RESİM SEÇ | *jpg;*png;";
            ImageSelect.Multiselect = false;
            ImageSelect.RestoreDirectory = true;

            //Ektralar:Sağtık menu kapatıldı. NullText özelliğine bilgi eklendi. 
            Move = new DragDropProvider(PEEmployee);
            Move.EnableDragDrop();
        }
    }
}