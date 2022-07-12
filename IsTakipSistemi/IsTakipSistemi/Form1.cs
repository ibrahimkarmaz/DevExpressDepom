using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IsTakipSistemi
{
    public partial class IsTakipPencere : DevExpress.XtraEditors.XtraForm
    {
        public IsTakipPencere()
        {
            InitializeComponent();
        }

        private void DepartmanListesiAltMenu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Pencereler.DepartmanlarFrm DepartmanAc = new Pencereler.DepartmanlarFrm();
            DepartmanAc.MdiParent = this;
            DepartmanAc.Show();
        }

        private void PersonelListesiAltMenu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Pencereler.FrmPersoneller PersonelListesi = new Pencereler.FrmPersoneller();
            PersonelListesi.MdiParent = this;
            PersonelListesi.Show();
        }
    }
}
