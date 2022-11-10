using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using DevExpress.Data;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
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

namespace PresentationLayer.WinFormList.ExpenseWF
{
    public partial class ExpenseHeaderArchiveINExpenseContentWF : DevExpress.XtraEditors.XtraForm
    {
        public ExpenseHeaderArchiveINExpenseContentWF()
        {
            InitializeComponent();
        }
        public static int ExpenseHeaderID;
        ExpenseContentManager _expenseContentManager = new ExpenseContentManager(new EFExpenseContentDAL());
        private void ExpenseHeaderArchiveINExpenseContentWF_Load(object sender, EventArgs e)
        {
            tileControl1.SelectedItem = tileItem1;
            GetAllExpenseContentWithExpenseHeaderID();
            AddUnboundColumn(GViewExpenseContent);
            AssignPictureEdittoImageColumn(GViewExpenseContent.Columns["Image"]);
            GViewExpenseContent.RowHeight = 75;
        }
        private void GetAllExpenseContentWithExpenseHeaderID()
        {
            try
            {
                _expenseContentManager = new ExpenseContentManager(new EFExpenseContentDAL());
                GControlExpenseContent.DataSource = _expenseContentManager.GetAllList(x => x.ExprenseHeaderID == ExpenseHeaderID && x.ExpenseContentArchive == true);
            }
            catch (Exception)
            {
            }
        }
        private void GetAllExpenseContentWithExpenseHeaderIDArchive()
        {
            try
            {
                _expenseContentManager = new ExpenseContentManager(new EFExpenseContentDAL());
                GControlExpenseContent.DataSource = _expenseContentManager.GetAllList(x => x.ExprenseHeaderID == ExpenseHeaderID && x.ExpenseContentArchive == false);
            }
            catch (Exception)
            {
            }
        }
        private void tileItem1_ItemClick(object sender, TileItemEventArgs e)
        {
            GetAllExpenseContentWithExpenseHeaderID();
        }

        private void tileItem2_ItemClick(object sender, TileItemEventArgs e)
        {
            GetAllExpenseContentWithExpenseHeaderIDArchive();
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
    }
}
/*KAYNAKÇA:TİLE NAV PANE
 https://docs.devexpress.com/WindowsForms/114557/controls-and-libraries/navigation-controls/tilenav-pane
 */