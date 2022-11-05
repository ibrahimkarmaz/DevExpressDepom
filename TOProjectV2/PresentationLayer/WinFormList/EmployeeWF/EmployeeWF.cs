using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using DevExpress.Internal;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.Data;
using System.IO;
using EntityLayer.Concrete;

namespace PresentationLayer.WinFormList.EmployeeWF
{
    public partial class EmployeeWF : DevExpress.XtraEditors.XtraForm
    {
        public EmployeeWF()
        {
            InitializeComponent();
        }
        EmployeeManager _employeeManager = new EmployeeManager(new EFEmployeeDAL());
        private void accordionControlNewEmployee_Click(object sender, EventArgs e)
        {
            EmployeeAddWF employeeAdd = new EmployeeAddWF();
            employeeAdd.ShowDialog();
            EmployeeGetAllList();
        }

        void AddUnboundColumn(GridView view)
        {
            //İLİŞKİSİZ ALAN OLUŞTURUR.
            GridColumn colImage = new GridColumn();
            colImage.FieldName = "Image";
            colImage.Caption = "Fotoğraf";
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
            colImage.Caption = "Fotoğraf";
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
            GControlEmployee.RepositoryItems.Add(riPictureEdit);

            // IMAGE ALANA EKLE
            column.ColumnEdit = riPictureEdit;
        }

        void AssignPictureEdittoImageColumnArchive(GridColumn column)
        {
            //PİCTURE EDİT OLUŞTURUR VE SİZE MODE AYARLA
            RepositoryItemPictureEdit riPictureEdit = new RepositoryItemPictureEdit();
            riPictureEdit.SizeMode = PictureSizeMode.Stretch;

            //PİCTURE EDİT'İ REPOSİTORY KISMINA EKLE(GRİD CONTROL İÇİNDE Kİ)
            GControlEmployeeArchive.RepositoryItems.Add(riPictureEdit);

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
                img = Image.FromFile(@"Image\Common\QuestionFace48.png");
            return img;
        }

        private void GViewEmployee_CustomUnboundColumnData(object sender, CustomColumnDataEventArgs e)
        {

            if (e.Column.FieldName == "Image" && e.IsGetData)
            {
                GridView view = sender as GridView;
                string fileNamea = view.GetRowCellValue(view.GetRowHandle(e.ListSourceRowIndex), GViewEmployee.Columns[7]) as string ?? string.Empty;
                if (!imageCache.ContainsKey(fileNamea))
                {
                    Image imgInfo = GetImagePath(fileNamea);
                    imageCache.Add(fileNamea, imgInfo);
                }
                e.Value = imageCache[fileNamea];
            }
        }
        public static int EmployeeID = -1;
        private void accordionControlEmployeeUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                EmployeeID = (int)GViewEmployee.GetRowCellValue(GViewEmployee.FocusedRowHandle, GViewEmployee.Columns[0]);
                EmployeeUpdateWF employeeUpdateWF = new EmployeeUpdateWF();
                employeeUpdateWF.ShowDialog();
                EmployeeGetAllList();
                EmployeeGetAllListArchive();
            }
            catch (Exception)
            {
                EmployeeID = -1;
                XtraMessageBox.Show("PERSONEL SEÇİNİZ.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void EmployeeGetAllList()
        {
            _employeeManager = new EmployeeManager(new EFEmployeeDAL());
            GControlEmployee.DataSource = _employeeManager.GetAllEmployee(x => x.EmployeeArchive == true);
        }
        private void EmployeeGetAllListArchive()
        {
            _employeeManager = new EmployeeManager(new EFEmployeeDAL());
            GControlEmployeeArchive.DataSource = _employeeManager.GetAllEmployee(x => x.EmployeeArchive == false);
        }
        private void EmployeeWF_Load(object sender, EventArgs e)
        {
            EmployeeGetAllList();
            EmployeeGetAllListArchive();
            AddUnboundColumn(GViewEmployee);
            AddUnboundColumnArchive(GViewEmployeeArchive);
            AssignPictureEdittoImageColumn(GViewEmployee.Columns["Image"]);
            AssignPictureEdittoImageColumnArchive(GViewEmployeeArchive.Columns["Image"]);
            GViewEmployee.RowHeight =GViewEmployeeArchive.RowHeight= 75;
        }

        private void accordionControlEmployeeyList_Click(object sender, EventArgs e)
        {
            EmployeeGetAllList();
        }
        public static bool Archive = true;
        private void accordionControlEmployeeExpand_Click(object sender, EventArgs e)
        {
            Archive = true;
            EmployeeExpandWF employeeExpandWF = new EmployeeExpandWF();
            employeeExpandWF.ShowDialog();
        }

        private void accordionControlEmployeeExpandArchive_Click(object sender, EventArgs e)
        {
            Archive = false;
            EmployeeExpandWF employeeExpandWF = new EmployeeExpandWF();
            employeeExpandWF.ShowDialog();
        }
        Employee DATA;

        private void accordionControlEmployeeDelete_Click(object sender, EventArgs e)
        {

            try
            {
                DATA = _employeeManager.GetById((int)GViewEmployee.GetRowCellValue(GViewEmployee.FocusedRowHandle, GViewEmployee.Columns[0]));
                _employeeManager.TRemove(DATA);
                EmployeeGetAllList();
                XtraMessageBox.Show("PERSONEL BİLGİLERİ SİLİNDİ.", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                XtraMessageBox.Show("PERSONEL SEÇİNİZ.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void accordionControlEmployeeArchive_Click(object sender, EventArgs e)
        {
            try
            {
                DATA = _employeeManager.GetById((int)GViewEmployee.GetRowCellValue(GViewEmployee.FocusedRowHandle, GViewEmployee.Columns[0]));
                DATA.EmployeeArchive = false;
                _employeeManager.TUpdate(DATA);
                EmployeeGetAllListArchive();
                EmployeeGetAllList();
                XtraMessageBox.Show("PERSONEL BİLGİLERİ ARŞİVLENDİ.", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                XtraMessageBox.Show("PERSONEL SEÇİNİZ.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void accordionControlEmployeeArchiveQuit_Click(object sender, EventArgs e)
        {
            try
            {
                DATA = _employeeManager.GetById((int)GViewEmployeeArchive.GetRowCellValue(GViewEmployeeArchive.FocusedRowHandle, GViewEmployeeArchive.Columns[0]));
                DATA.EmployeeArchive = true;
                _employeeManager.TUpdate(DATA);
                EmployeeGetAllListArchive();
                EmployeeGetAllList();
                XtraMessageBox.Show("PERSONEL BİLGİLERİ ARŞİVDEN ÇIKARILDI.", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                XtraMessageBox.Show("ARŞİV LİSTESİNDEN PERSONEL SEÇİNİZ.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GViewEmployeeArchive_CustomUnboundColumnData(object sender, CustomColumnDataEventArgs e)
        {

            if (e.Column.FieldName == "Image" && e.IsGetData)
            {
                GridView view = sender as GridView;
                string fileNamea = view.GetRowCellValue(view.GetRowHandle(e.ListSourceRowIndex), GViewEmployeeArchive.Columns[7]) as string ?? string.Empty;
                if (!imageCache.ContainsKey(fileNamea))
                {
                    Image imgInfo = GetImagePath(fileNamea);
                    imageCache.Add(fileNamea, imgInfo);
                }
                e.Value = imageCache[fileNamea];
            }
        }

        private void accordionControlEmployeeArchiveList_Click(object sender, EventArgs e)
        {
            EmployeeGetAllListArchive();
        }

        private void accordionControlEmployeeProcess_Click(object sender, EventArgs e)
        {
            xtraTabEmployeeControl.SelectedTabPage = TabPageEmployee;
        }

        private void accordionControlArchive_Click(object sender, EventArgs e)
        {
            xtraTabEmployeeControl.SelectedTabPage = TabPageEmployeeArchive;
        }


        private void xtraTabEmployeeControl_Click(object sender, EventArgs e)
        {
            if (xtraTabEmployeeControl.SelectedTabPage==TabPageEmployee)
            {
                accordionControl1.ActiveGroup = accordionControlEmployeeProcess;
            }
            else
            {
                accordionControl1.ActiveGroup = accordionControlArchive;
            }
        }
    }
}