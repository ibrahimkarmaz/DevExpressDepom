using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using DevExpress.XtraEditors;
using EntityLayer.Concrete;
using PresentationLayer.CommonValidationControls;
using PresentationLayer.JointTransactions;
using PresentationLayer.WinFormList.EmployeeWF;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace PresentationLayer.WinFormList.ExpenseWF.ExpenseContentWF
{
    public partial class ExpenseContentUpdateWF : DevExpress.XtraEditors.XtraForm
    {
        public ExpenseContentUpdateWF()
        {
            InitializeComponent();
        }
        DragDropProvider DragDropMove;
        OpenFileDialog ImageSelect = new OpenFileDialog();
        ExpenseHeaderManager _expenseHeaderManager = new ExpenseHeaderManager(new EFExpenseHeaderDAL());
        ExpenseContentManager _expenseContentManager = new ExpenseContentManager(new EFExpenseContentDAL());

        public static int ExpenseContentID;
        ExpenseContent expenseContent;

        private void ExpenseContentInformationsGetById()
        {
            expenseContent = _expenseContentManager.GetById(ExpenseContentID);
        }
        private void GetAllExpenseContentWithExpenseContendID()
        {
            ExpenseContentInformationsGetById();
            LUEExpenseHeader.EditValue = expenseContent.ExprenseHeaderID;
            TETitle.Text = expenseContent.ExpenseContentTitle;
            CBEType.Text = expenseContent.ExpenseContentType;
            TEPeceiptNumber.Text = expenseContent.ExpenseContentPeceiptNumber;
            TEPeceiptPrice.Text = expenseContent.ExpenseContentPeceiptPrice.ToString();
            MMExpenseNote.Text = expenseContent.ExpenseContentNote;
            CheckControl.Checked = expenseContent.ExpenseContentArchive ? false : true;
            Console.WriteLine(expenseContent.ExpenseContentPeceiptImage);
            if (expenseContent.ExpenseContentPeceiptImage!=null)
            {
                PEExpense.Image = Image.FromFile(expenseContent.ExpenseContentPeceiptImage);
                ImageSelect.FileName = expenseContent.ExpenseContentPeceiptImage;
            }
            else
            {
                PEExpense.Image = null;
                ImageSelect.FileName = null;
            }
            LUEExpenseHeader.Enabled = false;
        }
        private void GetAllExpenseHeader()//TÜM ARŞİVİ ÇEKER.
        {
            LUEExpenseHeader.Properties.DataSource = _expenseHeaderManager.GetAllList();
        }
        private void GetAllExpenseHeaderArchiveTrue()
        {
            LUEExpenseHeader.Properties.DataSource = _expenseHeaderManager.GetAllList(x => x.ExpenseHeaderArchive == true);
        }
        private void GetAllExpenseType()//VERİTABANINDAN GELMİYOR.---***
        {
            CBEType.Properties.Items.AddRange((new ExpenseType().GetAllTypeList()));
        }
        private void ExpenseContentUpdateWF_Load(object sender, EventArgs e)
        {
            ImageSelectOptions();
            GetAllExpenseHeader();
            GetAllExpenseType();
            GetAllExpenseContentWithExpenseContendID();
           
        }
        string NewImageNameInfo, ImageNewAddress;
        private void NewImageName()
        {
            NewImageNameInfo = @"Image\Expense\ExpenseImageUpdate\" + Guid.NewGuid() + ".jpg";
            ImageNewAddress = Application.StartupPath + "\\" + NewImageNameInfo;
        }
        bool ImageTransleError = true;
       
        private void ImageCopy()
        {
            try
            {
                if (PEExpense.GetLoadedImageLocation() == "")
                {
                    File.Copy(ImageSelect.FileName, ImageNewAddress);
                }
                else
                {
                    File.Copy(PEExpense.GetLoadedImageLocation(), ImageNewAddress);
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
            if (ImageSelect.ShowDialog() == DialogResult.OK)
            {
                PEExpense.Image = Image.FromFile(ImageSelect.FileName);
            }
        }

        private void PEExpense_DragDrop(object sender, DragEventArgs e)
        {
            // SÜRÜKLE BIRAK SONRASINDA RESMİN ADRESİNİ ALINMASI GEREKİYOR.
            ImageSelect.FileName = DragDropMove.FileLocation;
        }

        private void SBtnUpdate_Click(object sender, EventArgs e)
        {
            ExpenseContentInfomationReadyANDUpdate();
        }
        private void ExpenseContentInfomationReadyANDUpdate()
        {
            try
            {
                ExpenseContentInformationsGetById();
                if (ImageSelect.FileName != expenseContent.ExpenseContentPeceiptImage)
                {
                    NewImageName();//YENİ RESİM DOSYA YOLU
                    ImageCopy();//YENİ ADRESE KOPYALAMA
                    if (ImageTransleError)
                    {
                        expenseContent.ExpenseContentPeceiptImage = NewImageNameInfo;
                    }
                    else
                    {
                        expenseContent.ExpenseContentPeceiptImage= null;
                    }
                }

                if (SBtnExpenseHeaderSet.Enabled!=false)//EĞER DEĞİŞİKLİK İSTEYİ VERİLMEDİYSE KODLAR ÇAŞIŞIR 
                {//DEĞİŞİKLİK İSTEĞİ VERMESE BİLE ESKİ BİLGİLER BURADADIR. (GetById İçe çekilme durumu)
                    if (LUEExpenseHeader.EditValue != null)
                    {
                        expenseContent.ExprenseHeaderID = (int)LUEExpenseHeader.EditValue;
                    }
                    else
                    {
                        expenseContent.ExprenseHeaderID = null;
                    }
                }
                
                expenseContent.ExpenseContentTitle = TETitle.Text;
                expenseContent.ExpenseContentType = (new ExpenseType().TypeControl(CBEType.Text)) ? CBEType.Text : null;
                expenseContent.ExpenseContentPeceiptNumber = TEPeceiptNumber.Text;
                expenseContent.ExpenseContentPeceiptPrice = Convert.ToDecimal(TEPeceiptPrice.Text.ToString().Replace(".", ","));
                expenseContent.ExpenseContentNote = MMExpenseNote.Text;
                expenseContent.ExpenseContentArchive =CheckControl.Checked ? false:true;
                if (new ExpenseContentCommonValidationControl().DepartmentValidatorAndMessage(expenseContent))
                {
                    _expenseContentManager.TUpdate(expenseContent);
                    XtraMessageBox.Show("GİDER BİLGİLERİ DÜZENLENDİ.", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }

            }
            catch (Exception)
            {
                XtraMessageBox.Show("GİDER BİLGİLERİNİ DOLDURUNUZ.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExpenseContentInfomationReadyANDSave()
        {
            try
            {
                expenseContent = new ExpenseContent();
                if (ImageTransleError)//EĞER RESİM ALINMIŞ VE DOĞRU VE YENİ ADRESİ VAR İSE;
                {
                    expenseContent.ExpenseContentPeceiptImage = NewImageNameInfo;
                }
                else
                {
                    expenseContent.ExpenseContentPeceiptImage = null;
                }

                if (LUEExpenseHeader.EditValue != null)
                {
                    expenseContent.ExprenseHeaderID = (int)LUEExpenseHeader.EditValue;
                }
                else
                {
                    expenseContent.ExprenseHeaderID = null;
                }
                expenseContent.ExpenseContentTitle = TETitle.Text;
                expenseContent.ExpenseContentType = (new ExpenseType().TypeControl(CBEType.Text)) ? CBEType.Text : null;
                expenseContent.ExpenseContentPeceiptNumber = TEPeceiptNumber.Text;
                expenseContent.ExpenseContentPeceiptPrice = Convert.ToDecimal(TEPeceiptPrice.Text.ToString().Replace(".", ","));
                expenseContent.ExpenseContentNote = MMExpenseNote.Text;
                expenseContent.ExpenseContentArchive = true;
                if (new ExpenseContentCommonValidationControl().DepartmentValidatorAndMessage(expenseContent))
                {
                    _expenseContentManager.TAdd(expenseContent);
                    XtraMessageBox.Show("YENİ GİDER KAYDEDİLDİ.", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception)
            {
                XtraMessageBox.Show("GİDER BİLGİLERİNİ DOLDURUNUZ.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SBCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SBtnExpenseHeaderSet_Click(object sender, EventArgs e)
        {
            LUEExpenseHeader.Enabled = true;
            GetAllExpenseHeaderArchiveTrue();
        }

        private void SBtnExpenseBack_Click(object sender, EventArgs e)
        {
            GetAllExpenseContentWithExpenseContendID();
        }

        void ImageSelectOptions()
        {
            ImageSelect.Title = "Resim Seç";
            ImageSelect.Filter = "RESİM SEÇ | *jpg;*png;";
            ImageSelect.Multiselect = false;
            ImageSelect.RestoreDirectory = true;

            //Ektralar:Sağtık menu kapatıldı. NullText özelliğine bilgi eklendi. 
            DragDropMove = new DragDropProvider(PEExpense);
            DragDropMove.EnableDragDrop();
        }
    }
}