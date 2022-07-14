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

        private void PersonelIstatistiklerAltMenu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Pencereler.FrmPersonelistatistikler istatistikler = new Pencereler.FrmPersonelistatistikler();
            istatistikler.MdiParent = this;
            istatistikler.Show();
        }

        private void IsTakipPencere_Load(object sender, EventArgs e)
        {

        }

        private void GorevListesiAltMenu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Pencereler.FrmGorevListesi GorevListesi = new Pencereler.FrmGorevListesi();
            GorevListesi.MdiParent = this;
            GorevListesi.Show();
        }

        private void YeniGorevTanimlaAltMenu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Pencereler.FrmGorev YeniGorev = new Pencereler.FrmGorev();
            YeniGorev.ShowDialog();
        }

        private void GorevDetaylariAltMenu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Pencereler.FrmGorevDetay GDetay = new Pencereler.FrmGorevDetay();
            GDetay.ShowDialog();
        }
    }
}
