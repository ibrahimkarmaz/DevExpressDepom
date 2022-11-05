using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using DevExpress.XtraEditors;
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
    public partial class EmployeeUpdateWF : DevExpress.XtraEditors.XtraForm
    {
        public EmployeeUpdateWF()
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
        {//TÜM DEPARTMAN BİLGİSİ (ARŞİVLİ+ARŞİVSİZ=TÜMÜ)
            LUEDepartment.Properties.DataSource = _departmentManager.GetAllList();
        }
        private void GetAllDepartmentNotArchive()
        {//SADECE ARŞİVSİZ :)
            LUEDepartment.Properties.DataSource = _departmentManager.GetAllList(x => x.DepartmentArchive == true);
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

        Employee employee;
        private void EmployeeInformationsGetById()
        {//2'DEN FAZLA TEKRARLANIYOR.
            employee = _employeeManager.GetById(EmployeeWF.EmployeeID);
        }
        private void GetAllEmployeeWithEmployeeID()
        {//TÜM BİLGİLERİ NESNELERE YERLEŞTİRİR.
            EmployeeInformationsGetById();
            GetAllDepartment();
            LUEDepartment.EditValue = employee.DepartmentID;
            LUEDepartment.Enabled = false;
            PEEmployee.Image = Image.FromFile(employee.EmployeeImage);
            ImageSelect.FileName = employee.EmployeeImage;
            TETC.Text = employee.EmployeeTC;
            TEFirstName.Text = employee.EmployeeName;
            TELasName.Text = employee.EmployeeSurName;
            CBEGender.SelectedIndex = employee.EmployeeGender == true ? 1 : 0;//CİNSİYET BELİRLEME
            TEBirthOfDate.Text = employee.EmployeeDateOfBirth.ToString(); //?
            TEMobilePhone.Text = employee.EmployeePhone;
            TEMail.Text = employee.EmployeeMail;
            LUECounty.EditValue = employee.CountyID;
            LUEDistrict.EditValue = employee.DistrictID;
            MMEHomeAddress.Text = employee.EmployeeHomeAddress;
            CheckControl.Checked = (employee.EmployeeArchive == true ? false : true);

        }
        private void EmployeeUpdateWF_Load(object sender, EventArgs e)
        {
            ImageSelectOptions();
            CBEGender.Properties.Items.Add("BAYAN");
            CBEGender.Properties.Items.Add("BAY");
            GetAllDepartment();
            GetAllCounty();
            GetAllEmployeeWithEmployeeID();
        }
        string NewImageNameInfo, ImageNewAddress;
        private void NewImageName()
        {
            NewImageNameInfo = @"image\" + Guid.NewGuid() + ".jpg";
            ImageNewAddress = Application.StartupPath + "\\" + NewImageNameInfo;
        }
        bool ImageTransleError = true;

        private void SBCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SBtnEmployeeBack_Click(object sender, EventArgs e)
        {
            GetAllEmployeeWithEmployeeID();
        }

        private void EmployeeInfomationReadyANDUpdate()
        {
            try
            {
                EmployeeInformationsGetById();
                if (ImageSelect.FileName!= employee.EmployeeImage)
                {
                    NewImageName();//YENİ RESİM DOSYA YOLU
                    ImageCopy();//YENİ ADRESE KOPYALAMA
                    if (ImageTransleError)
                    {
                        employee.EmployeeImage = NewImageNameInfo;
                    }
                    else
                    {
                        employee.EmployeeImage = null;
                    }
                }
                

                if (LUEDepartment.EditValue != null)
                {
                    employee.DepartmentID = (int)LUEDepartment.EditValue;
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
                employee.EmployeeArchive = CheckControl.Checked ? false:true;

                if (new EmployeeCommonValidatorControl().EmployeeValidatorAndMessage(employee))
                {
                    _employeeManager.TUpdate(employee);
                    XtraMessageBox.Show("PERSONEL BİLGİLERİ DÜZENLENDİ.", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception)
            {
                XtraMessageBox.Show("PERSONEL BİLGİLERİNİ DOLDURUNUZ.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SBtnUpdate_Click(object sender, EventArgs e)
        {
            EmployeeInfomationReadyANDUpdate();
        }

        private void SBtnDepartmentSet_Click(object sender, EventArgs e)
        {
            LUEDepartment.Enabled = true;
            GetAllDepartmentNotArchive();
        }

        private void BtnImageSelect_Click(object sender, EventArgs e)
        {
            if (ImageSelect.ShowDialog()==DialogResult.OK)
            {
                PEEmployee.Image = Image.FromFile(ImageSelect.FileName);
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
    }
}
/*EK BİLGİ
 *1- TEXTEDİT'İN BÜYÜK HARFLE YAZMASI İÇİN; PROPERTİES'İN CharacterCasing UPPER YAP.
 *1 EK- TEXTEDİT MASKE YAPILABİLİR FAKAT BOŞLUK BİRAKILAMAZ.
 */