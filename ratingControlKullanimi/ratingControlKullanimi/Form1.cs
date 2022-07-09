using DevExpress.Skins;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ratingControlKullanimi
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
        }
        Db_FilmArsivEntities dataBase = new Db_FilmArsivEntities();
        private void Form1_Load(object sender, EventArgs e)
        {
            /*NOT:
             *YILDIZLARI FARKLI BİR SİMGE İLE DEĞİŞTİRME KONUSUNU ARAŞTIR
             *YILDIZLARIN RENGİNİ DEĞİŞTİRME İLE İLGİLİ KONUYU ARAŞTIR
             */

            gridView1.OptionsBehavior.ReadOnly = true;
            gridView1.OptionsBehavior.Editable = false;
            gridControl1.DataSource = dataBase.Tbl_Filmler.ToList();

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
           double deger=(Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle,gridView1.Columns[3])));
            if (deger>0 && deger<=2)
                ratingControl1.EditValue = 1;
            else if (deger > 2 && deger <= 4)
                ratingControl1.EditValue = 2;
            else if (deger > 4 && deger <= 6)
                ratingControl1.EditValue = 3;
            else if (deger > 6 && deger <= 8)
                ratingControl1.EditValue = 4;
            else if (deger > 8 && deger <= 10)
                ratingControl1.EditValue = 5;
        }
    }
}
