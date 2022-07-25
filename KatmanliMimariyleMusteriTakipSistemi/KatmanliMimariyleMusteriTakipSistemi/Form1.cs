using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BusinessLayer;
using EntitiyLayer.Entities;
using BusinessLayer.ValidationRules;
using FluentValidation.Results;

namespace KatmanliMimariyleMusteriTakipSistemi
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
        }
        MusteriManager MusteriIslemleriSunum = new MusteriManager();
        MusteriValidator MusteriKisitlamalari = new MusteriValidator();
        private void Form1_Load(object sender, EventArgs e)
        {
            MusteriTumunuListe();
            CINSIYET.Properties.Items.Add("ERKEK");
            CINSIYET.Properties.Items.Add("KADIN");
        }
        private void MusteriTumunuListe()
        {
            gridControl1.DataSource = MusteriIslemleriSunum.TumunuListele();
        }
        private void MusteriEkle()
        {//ValidationResult Kütüphanesi gelimiyor ise ValidatorFluent Yükle
            
            Musteri Kayit = new Musteri();
            Kayit.Ad = TEAD.Text;
            Kayit.Soyad = TESOYAD.Text;
            Kayit.Telefon = TETELEFON.Text;
            Kayit.Mail = TEMAIL.Text;
            Kayit.KayitTarih = Convert.ToDateTime(DETARIH.Text);
            if (CINSIYET.SelectedText=="ERKEK")
            {
                Kayit.Cinsiyet = true;
            }
            else
            {
                Kayit.Cinsiyet = false;
            }
            ValidationResult sonuc = MusteriKisitlamalari.Validate(Kayit);//Entity neden yazdık tamda bunun için sorun var mi diye kontrol ediyor.
            if (sonuc.IsValid)//Eğer hata yok ise;
            {
                MusteriIslemleriSunum.MusteriKayit(Kayit);
            }
            else//varsa;
            {
                Console.WriteLine(sonuc.Errors[0].ToString());
            }
            
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            MusteriTumunuListe();
        }

        private void BTNKAYDET_Click(object sender, EventArgs e)
        {
            MusteriEkle();
        }

        private void BTNSIL_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle,gridView1.Columns[0]));
            MusteriIslemleriSunum.Sil(ID);
        }

        private void BTNGUNCELLE_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[0]));
            Musteri GuncellemeIslemleri = new Musteri();
            GuncellemeIslemleri.ID = ID;
            GuncellemeIslemleri.Ad = TEAD.Text;
            GuncellemeIslemleri.Soyad = TESOYAD.Text;
            MusteriIslemleriSunum.MusteriGuncelle(GuncellemeIslemleri);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            gridControl1.DataSource = MusteriIslemleriSunum.AramaYap(TEAD.Text);
        }
    }
}
