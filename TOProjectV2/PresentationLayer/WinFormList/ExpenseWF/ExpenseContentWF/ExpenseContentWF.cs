using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using DevExpress.ClipboardSource.SpreadsheetML;
using DevExpress.Data;
using DevExpress.Office.Model;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using EntityLayer.Concrete;
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

namespace PresentationLayer.WinFormList.ExpenseWF.ExpenseContentWF
{
    public partial class ExpenseContentWF : DevExpress.XtraEditors.XtraForm
    {
        public ExpenseContentWF()
        {
            InitializeComponent();
        }
        ExpenseHeaderManager _expenseHeaderManager = new ExpenseHeaderManager(new EFExpenseHeaderDAL());
        ExpenseContentManager _expenseContentManager = new ExpenseContentManager(new EFExpenseContentDAL());
        private void ExpenseContentWF_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Start();
        }
        private void GetAllExpenseHeader()
        {
            _expenseHeaderManager = new ExpenseHeaderManager(new EFExpenseHeaderDAL());
            GControlExpenseHeader.DataSource = _expenseHeaderManager.GetAllList(x => x.ExpenseHeaderArchive == true);
        }
        private void GetAllExpenseHeaderArcihve()
        {
            _expenseHeaderManager = new ExpenseHeaderManager(new EFExpenseHeaderDAL());
            GControlExpenseHeaderArchive.DataSource = _expenseHeaderManager.GetAllList(x => x.ExpenseHeaderArchive == false);
        }

        private void CommonExpenseContentInvoke()
        {
             GetAllExpenseContentWithExpenseHeaderID();
            GetAllExpenseContentWithExpenseHeaderIDArchive();
        }
        private void GetAllExpenseContentWithExpenseHeaderID()
        {
            try
            {
                ExpenseHeaderIDInfo = (int)GViewExpenseHeader.GetRowCellValue(GViewExpenseHeader.FocusedRowHandle, GViewExpenseHeader.Columns[0]);
                _expenseContentManager = new ExpenseContentManager(new EFExpenseContentDAL());
                GControlExpenseContent.DataSource = _expenseContentManager.GetAllList(x => x.ExprenseHeaderID == ExpenseHeaderIDInfo && x.ExpenseContentArchive == true);
            }
            catch (Exception)
            {
            }
        }
        private void GetAllExpenseContentWithExpenseHeaderIDArchive()
        {
            try
            {
                ExpenseHeaderIDInfo = (int)GViewExpenseHeader.GetRowCellValue(GViewExpenseHeader.FocusedRowHandle, GViewExpenseHeader.Columns[0]);
                _expenseContentManager = new ExpenseContentManager(new EFExpenseContentDAL());
                GControlExpenseContentArchive.DataSource = _expenseContentManager.GetAllList(x => x.ExprenseHeaderID == ExpenseHeaderIDInfo && x.ExpenseContentArchive == false);
            }
            catch (Exception)
            {
            }
        }
        private void accordionControlNewExpenseContent_Click(object sender, EventArgs e)
        {
            ExpenseContentAddWF expenseContentAddWF = new ExpenseContentAddWF();
            expenseContentAddWF.ShowDialog();
        }
        int ExpenseHeaderIDInfo = -1;
        private void GViewExpenseHeader_Click(object sender, EventArgs e)
        {
            CommonExpenseContentInvoke();
        }
        byte StopTimer = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            StopTimer++;
            if (StopTimer <= 2)
            {
                if (StopTimer == 1)
                {
                    GetAllExpenseHeader(); 
                    GetAllExpenseHeaderArcihve();
                    AddUnboundColumn(GViewExpenseContent);
                    AddUnboundColumnArchive(GViewExpenseContentArchive);
                    AssignPictureEdittoImageColumn(GViewExpenseContent.Columns["Image"]);
                    AssignPictureEdittoImageColumnArchive(GViewExpenseContentArchive.Columns["Image"]);
                    GViewExpenseContent.RowHeight = GViewExpenseContentArchive.RowHeight = 75;
                }
                else if (StopTimer == 2)
                {
                   CommonExpenseContentInvoke();
                    timer1.Stop();
                }
            }
        }
        void AddUnboundColumn(GridView view)
        {
            //İLİŞKİSİZ ALAN OLUŞTURUR.
            GridColumn colImage = new GridColumn();
            colImage.FieldName = "Image";
            colImage.Caption = "FİŞ FOTOĞRAFI";
            colImage.ImageOptions.Image = DevExpress.Images.ImageResourceCache.Default.GetImage("images/" + "miscellaneous/publish_16x16.png");
            colImage.UnboundType = UnboundColumnType.Object;
            colImage.Width = 100;
            colImage.OptionsColumn.AllowEdit = false;
            colImage.Visible = true;

            //ALANI EKLE
            view.Columns.Add(colImage);
        }
        void AddUnboundColumnArchive(GridView view)
        {
            //İLİŞKİSİZ ALAN OLUŞTURUR.
            GridColumn colImage = new GridColumn();
            colImage.FieldName = "Image";
            colImage.Caption = "FİŞ FOTOĞRAFI";
            colImage.ImageOptions.Image = DevExpress.Images.ImageResourceCache.Default.GetImage("images/" + "miscellaneous/publish_16x16.png");
            colImage.UnboundType = UnboundColumnType.Object;
            colImage.Width = 100;
            colImage.OptionsColumn.AllowEdit = false;
            colImage.Visible = true;

            //ALANI EKLE
            view.Columns.Add(colImage);
        }
        void AssignPictureEdittoImageColumn(GridColumn column)
        {
            //PİCTURE EDİT OLUŞTURUR VE SİZE MODE AYARLA
            RepositoryItemPictureEdit riPictureEdit = new RepositoryItemPictureEdit();
            riPictureEdit.SizeMode = PictureSizeMode.Stretch;

            //PİCTURE EDİT'İ REPOSİTORY KISMINA EKLE(GRİD CONTROL İÇİNDE Kİ)
            GControlExpenseContent.RepositoryItems.Add(riPictureEdit);

            // IMAGE ALANA EKLE
            column.ColumnEdit = riPictureEdit;
        }

        void AssignPictureEdittoImageColumnArchive(GridColumn column)
        {
            //PİCTURE EDİT OLUŞTURUR VE SİZE MODE AYARLA
            RepositoryItemPictureEdit riPictureEdit = new RepositoryItemPictureEdit();
            riPictureEdit.SizeMode = PictureSizeMode.Stretch;

            //PİCTURE EDİT'İ REPOSİTORY KISMINA EKLE(GRİD CONTROL İÇİNDE Kİ)
            GControlExpenseContentArchive.RepositoryItems.Add(riPictureEdit);

            // IMAGE ALANA EKLE
            column.ColumnEdit = riPictureEdit;
        }

        Dictionary<string, Image> imageCache = new Dictionary<string, Image>(StringComparer.OrdinalIgnoreCase);
        private Image GetImagePath(string path)
        {
            //DÜZENLEME YAPILDI IMG RETURN OLARAK DÖNDÜ.
            // DOSYA İÇİNDE URL YÜKLE
            Image img = null;
            if (File.Exists(path))
                img = Image.FromFile(path);

            else
                img = Image.FromFile(@"Image\Expense\ExpenseImageNone\NoneImage96.png");
            return img;
        }
        private void GViewExpenseContent_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            if (e.Column.FieldName == "Image" && e.IsGetData)
            {
                GridView view = sender as GridView;
                string fileNamea = view.GetRowCellValue(view.GetRowHandle(e.ListSourceRowIndex), GViewExpenseContent.Columns[6]) as string ?? string.Empty;
                if (!imageCache.ContainsKey(fileNamea))
                {
                    Image imgInfo = GetImagePath(fileNamea);
                    imageCache.Add(fileNamea, imgInfo);
                }
                e.Value = imageCache[fileNamea];
            }
        }

        private void accordionControlExpenseContentUpdate_Click(object sender, EventArgs e)
        {
            ExpenseContentUpdateWF.ExpenseContentID = (int)GViewExpenseContent.GetRowCellValue(GViewExpenseContent.FocusedRowHandle, GViewExpenseContent.Columns[0]);
            ExpenseContentUpdateWF expenseContentUpdateWF = new ExpenseContentUpdateWF();
            expenseContentUpdateWF.ShowDialog();
            CommonExpenseContentInvoke();
        }
        ExpenseContent DATA;
        private void accordionControlExpenseContentDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DATA = _expenseContentManager.GetById((int)GViewExpenseContent.GetRowCellValue(GViewExpenseContent.FocusedRowHandle, GViewExpenseContent.Columns[0]));
                _expenseContentManager.TRemove(DATA);
                GetAllExpenseContentWithExpenseHeaderID();
                XtraMessageBox.Show("GİDER BİLGİLERİ SİLİNDİ.", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                XtraMessageBox.Show("GİDER SEÇİNİZ.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void accordionControlExpenseContentArchive_Click(object sender, EventArgs e)
        {
            try
            {
                DATA = _expenseContentManager.GetById((int)GViewExpenseContent.GetRowCellValue(GViewExpenseContent.FocusedRowHandle, GViewExpenseContent.Columns[0]));
                DATA.ExpenseContentArchive = false;
                _expenseContentManager.TUpdate(DATA);
                CommonExpenseContentInvoke();
                XtraMessageBox.Show("GİDER BİLGİLERİ ARŞİVLENDİ.", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                XtraMessageBox.Show("GİDER SEÇİNİZ.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void accordionControlExpenseContentList_Click(object sender, EventArgs e)
        {
            GetAllExpenseContentWithExpenseHeaderID();
        }

        private void accordionControlArchiveQuit_Click(object sender, EventArgs e)
        {
            try
            {
                DATA = _expenseContentManager.GetById((int)GViewExpenseContentArchive.GetRowCellValue(GViewExpenseContentArchive.FocusedRowHandle, GViewExpenseContentArchive.Columns[0]));
                DATA.ExpenseContentArchive = true;
                _expenseContentManager.TUpdate(DATA);
                CommonExpenseContentInvoke();
                XtraMessageBox.Show("GİDER BİLGİLERİ ARŞİVDEN ÇIKARILDI.", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                XtraMessageBox.Show("ARŞİV LİSTESİNDEN GİDER SEÇİNİZ.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GViewExpenseContentArchive_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            if (e.Column.FieldName == "Image" && e.IsGetData)
            {
                GridView view = sender as GridView;
                string fileNamea = view.GetRowCellValue(view.GetRowHandle(e.ListSourceRowIndex), GViewExpenseContent.Columns[6]) as string ?? string.Empty;
                if (!imageCache.ContainsKey(fileNamea))
                {
                    Image imgInfo = GetImagePath(fileNamea);
                    imageCache.Add(fileNamea, imgInfo);
                }
                e.Value = imageCache[fileNamea];
            }
        }

        private void accordionControlExpenseContentArchiveList_Click(object sender, EventArgs e)
        {
            GetAllExpenseContentWithExpenseHeaderIDArchive();
        }

        private void repositoryItemButtonEdit2_Click(object sender, EventArgs e)
        {
            ExpenseHeaderArchiveINExpenseContentWF.ExpenseHeaderID = (int)GViewExpenseHeaderArchive.GetRowCellValue(GViewExpenseHeaderArchive.FocusedRowHandle, GViewExpenseHeaderArchive.Columns[0]);
            ExpenseHeaderArchiveINExpenseContentWF expenseHeaderArchiveINExpenseContentWF = new ExpenseHeaderArchiveINExpenseContentWF();
            expenseHeaderArchiveINExpenseContentWF.ShowDialog();
        }

        private void xtraTabControlExpenseContent_Click(object sender, EventArgs e)
        {
            if (xtraTabControlExpenseContent.SelectedTabPage == xtraTabPageExpenseHeader)
            {
                accordionControl1.ActiveGroup = accordionControlExpenseContentProcess;
            }
            else
            {
                accordionControl1.ActiveGroup = accordionControlArchive;
            }
        }

        private void accordionControlExpenseContentProcess_Click(object sender, EventArgs e)
        {
            xtraTabControlExpenseContent.SelectedTabPage = xtraTabPageExpenseHeader;
        }

        private void accordionControlArchive_Click(object sender, EventArgs e)
        {
            xtraTabControlExpenseContent.SelectedTabPage = xtraTabPageExpenseHeaderArchive;
        }
    }
}