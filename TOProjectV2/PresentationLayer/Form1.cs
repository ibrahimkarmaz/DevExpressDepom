﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Xml.Linq;
using PresentationLayer.WinFormList;
using PresentationLayer.WinFormList.CustomerWF;
using PresentationLayer.WinFormList.ProductWF;
using DevExpress.XtraBars.Helpers;
using DevExpress.LookAndFeel;
using PresentationLayer.WinFormList.SectorWF;

namespace PresentationLayer
{
    public partial class CommercialAutomation : Form
    {
        public CommercialAutomation()
        {
            InitializeComponent();
        }
        public void WeatherForecast()//HAVA DURUMU İŞLEMLERİ
        {//DÜZENLEME YAPIALCAK
         //KİŞİYE ÖZEL OLACAK EĞER SORUNLU OLURSA İSTANBUL İÇİN YAPILACAK.(HAVA DURUMU İŞLEMLERİ)
            string Api = "a8d116083405acfe2910de979a4d36c6";
            string Connection = "http://api.openweathermap.org/data/2.5/weather?q=istanbul&mode=xml&lang=tr&units=metric&appid=" + Api;
            XDocument Weather = XDocument.Load(Connection);
            var Heat = Weather.Descendants("temperature").ElementAt(0).Attribute("value").Value;
            var icon = Weather.Descendants("weather").ElementAt(0).Attribute("icon").Value;
            var Status = Weather.Descendants("weather").ElementAt(0).Attribute("value").Value;
            BarWeather.Caption ="İSTANBUL\n"+ Heat + " ºC";
            Console.WriteLine(Status.ToString());
            if (Status.ToUpper()=="AÇIK")
            {
                BarWeather.ImageOptions.Image = Image.FromFile(@"image\Common\Sumer32.png");
            }
            else
            {
                BarWeather.ImageOptions.Image = Image.FromFile(@"image\Common\Clound32.png");
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("WXI", "Freshneess");

            WeatherForecast();
            SkinHelper.InitSkinPopupMenu(barSubItem2);
        }
        ProductWF productWF;
        private void barProducts_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (productWF==null || productWF.IsDisposed)
            {
                productWF = new ProductWF();
                productWF.MdiParent = this;
                productWF.Show();
            }
           
        }
        BlandTypeList productTypeList;
        private void barProductTypeList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (productTypeList==null || productTypeList.IsDisposed)
            {
                productTypeList = new BlandTypeList();
                productTypeList.MdiParent = this;
                productTypeList.Show();
            }
        }
        CustomerWF customerWF;
        private void barCustomers_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (customerWF==null || customerWF.IsDisposed)
            {
                customerWF = new CustomerWF();
                customerWF.MdiParent = this;
                customerWF.Show();
            }
        }

        private void BarWeather_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            WeatherForecast();
        }

        private void ribbonControlAutomation_Click(object sender, EventArgs e)
        {

        }

        private void barDarkTheme_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("WXI", "Sharpness");
        }

        private void barDefaultTheme_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("WXI", "Freshneess");
        }
        SectorWF sectorWF;
        private void BarSector_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (sectorWF==null || sectorWF.IsDisposed)
            {
                sectorWF = new SectorWF();
                sectorWF.MdiParent = this;
                sectorWF.Show();
            }

        }
    }
}
/*KAYNAK KOD
 https://www.cgtytpl.com/openweathermap-ile-hava-durumu-cekme

Kişiye Özel Api Adresi: (Siteye üye olunarak alınıyor.)
https://home.openweathermap.org/api_keys

APİYLE İLGİLİ DETAYLA BİLGİ
https://openweathermap.org/current#builtin


TEMALARLA İLGİLİ KAYNAK;
https://www.youtube.com/watch?v=SUXvAHw6osw

 */