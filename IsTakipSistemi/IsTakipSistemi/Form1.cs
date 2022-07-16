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
        Pencereler.FrmPersoneller PersonelListesi;
        Pencereler.DepartmanlarFrm DepartmanAc;
        Pencereler.FrmPersonelistatistikler istatistikler;
        Pencereler.FrmGorevListesi GorevListesi;
        Pencereler.FrmGorev YeniGorev;
        Pencereler.FrmGorevDetay GDetay;
        Pencereler.FrmAnaForm AnaSayfa;
        private void DepartmanListesiAltMenu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (DepartmanAc==null || DepartmanAc.IsDisposed)
            {
                DepartmanAc = new Pencereler.DepartmanlarFrm();
                DepartmanAc.MdiParent = this;
                DepartmanAc.Show();
            }
        }

        private void PersonelListesiAltMenu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (PersonelListesi==null || PersonelListesi.IsDisposed)
            {
                PersonelListesi = new Pencereler.FrmPersoneller();
                PersonelListesi.MdiParent = this;
                PersonelListesi.Show();
            }
         
        }

        private void PersonelIstatistiklerAltMenu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (istatistikler == null || istatistikler.IsDisposed)
            {
                istatistikler = new Pencereler.FrmPersonelistatistikler();
                istatistikler.MdiParent = this;
                istatistikler.Show();
            }
        }

        private void IsTakipPencere_Load(object sender, EventArgs e)
        {

        }

        private void GorevListesiAltMenu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (GorevListesi==null || GorevListesi.IsDisposed)
            {
                GorevListesi = new Pencereler.FrmGorevListesi();
                GorevListesi.MdiParent = this;
                GorevListesi.Show();
            }
        }

        private void YeniGorevTanimlaAltMenu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            YeniGorev = new Pencereler.FrmGorev();
            YeniGorev.ShowDialog();
        }

        private void GorevDetaylariAltMenu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GDetay = new Pencereler.FrmGorevDetay();
            GDetay.ShowDialog();
        }

        private void AnasayfaAltMenu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (AnaSayfa==null || AnaSayfa.IsDisposed)
            {
                AnaSayfa = new Pencereler.FrmAnaForm();
                AnaSayfa.MdiParent=this;
                AnaSayfa.Show();
            }
           
        }
    }
}
