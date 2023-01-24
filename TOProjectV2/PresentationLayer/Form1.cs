using DevExpress.XtraBars.Helpers;
using EntityLayer.Concrete;
using PresentationLayer.WinFormList;
using PresentationLayer.WinFormList.BankWF;
using PresentationLayer.WinFormList.CompanyMovement;
using PresentationLayer.WinFormList.CompanyWF;
using PresentationLayer.WinFormList.CustomerMovementInvoice;
using PresentationLayer.WinFormList.CustomerMovementWF;
using PresentationLayer.WinFormList.CustomerWF;
using PresentationLayer.WinFormList.DepartmentWF;
using PresentationLayer.WinFormList.EmployeeWF;
using PresentationLayer.WinFormList.ExpenseWF;
using PresentationLayer.WinFormList.ExpenseWF.ExpenseContentWF;
using PresentationLayer.WinFormList.GuidesWF;
using PresentationLayer.WinFormList.InvoiceWF;
using PresentationLayer.WinFormList.ProductWF;
using PresentationLayer.WinFormList.SectorWF;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

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
            BarWeather.Caption = "İSTANBUL\n" + Heat + " ºC";
            Console.WriteLine(Status.ToString());
            if (Status.ToUpper() == "AÇIK")
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
            if (productWF == null || productWF.IsDisposed)
            {
                productWF = new ProductWF();
                productWF.MdiParent = this;
                productWF.Show();
            }

        }
        BlandTypeList productTypeList;
        private void barProductTypeList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (productTypeList == null || productTypeList.IsDisposed)
            {
                productTypeList = new BlandTypeList();
                productTypeList.MdiParent = this;
                productTypeList.Show();
            }
        }
        CustomerWF customerWF;
        private void barCustomers_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (customerWF == null || customerWF.IsDisposed)
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
            if (sectorWF == null || sectorWF.IsDisposed)
            {
                sectorWF = new SectorWF();
                sectorWF.MdiParent = this;
                sectorWF.Show();
            }

        }
        CompanyWF companyWF;
        private void barCompanys_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (companyWF == null || companyWF.IsDisposed)
            {
                companyWF = new CompanyWF();
                companyWF.MdiParent = this;
                companyWF.Show();
            }
        }
        DepartmentWF departmentWF;
        private void barButtonDepartment_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (departmentWF == null || departmentWF.IsDisposed)
            {
                departmentWF = new DepartmentWF();
                departmentWF.MdiParent = this;
                departmentWF.Show();
            }

        }
        EmployeeWF employeeWF;
        private void barEmployees_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (employeeWF == null || employeeWF.IsDisposed)
            {
                employeeWF = new EmployeeWF();
                employeeWF.MdiParent = this;
                employeeWF.Show();
            }
        }
        EmployeeGuideWF employeeGuideWF;
        private void barEmployeeDirectory_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (employeeGuideWF == null || employeeGuideWF.IsDisposed)
            {
                employeeGuideWF = new EmployeeGuideWF();
                employeeGuideWF.MdiParent = this;
                employeeGuideWF.Show();
            }
        }

        private void barButtonTranslate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            TranslateWF translateWF = new TranslateWF();
            translateWF.ShowDialog();
        }
        CustomerGuideWF customerGuideWF;
        private void barCustomerDirectory_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (customerGuideWF == null || customerGuideWF.IsDisposed)
            {
                customerGuideWF = new CustomerGuideWF();
                customerGuideWF.MdiParent = this;
                customerGuideWF.Show();
            }
        }
        CompanyGuideWF companyGuideWF;
        private void barCompanyDirectory_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (companyGuideWF == null || companyGuideWF.IsDisposed)
            {
                companyGuideWF = new CompanyGuideWF();
                companyGuideWF.MdiParent = this;
                companyGuideWF.Show();
            }
        }
        ExpenseWF expenseWF;
        private void barExpenses_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (expenseWF == null || expenseWF.IsDisposed)
            {
                expenseWF = new ExpenseWF();
                expenseWF.MdiParent = this;
                expenseWF.Show();
            }
        }
        ExpenseContentWF expenseContentWF;
        private void barButtonItemExpenseContent_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (expenseContentWF == null || expenseContentWF.IsDisposed)
            {
                expenseContentWF = new ExpenseContentWF();
                expenseContentWF.MdiParent = this;
                expenseContentWF.Show();
            }
        }
        BankWF bankWF;
        private void barBanks_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bankWF == null || bankWF.IsDisposed)
            {
                bankWF = new BankWF();
                bankWF.MdiParent = this;
                bankWF.Show();
            }

        }
        CompanyMovementWF companyMovementWF;
        private void barCompanyMovements_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (companyMovementWF==null || companyMovementWF.IsDisposed)
            {
                companyMovementWF = new CompanyMovementWF();
                companyMovementWF.MdiParent = this;
                companyMovementWF.Show();
            }
        }

        CompanyMovementInvoiceWF companyMovementInvoiceWF;
        private void barCompanyMovementInvoice_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
            if (companyMovementInvoiceWF==null || companyMovementInvoiceWF.IsDisposed)
            {
                companyMovementInvoiceWF = new CompanyMovementInvoiceWF();
                companyMovementInvoiceWF.MdiParent = this;
                companyMovementInvoiceWF.Show();
            }
        }
        CustomerMovementWF customerMovementWF;
        private void barCustomerMovement_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (customerMovementWF==null || customerMovementWF.IsDisposed)
            {
                customerMovementWF = new CustomerMovementWF();
                customerMovementWF.MdiParent = this;
                customerMovementWF.Show();
            }
        }

        private void barDirectory_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (customerGuideWF == null || customerGuideWF.IsDisposed)
            {
                customerGuideWF = new CustomerGuideWF();
                customerGuideWF.MdiParent = this;
                customerGuideWF.Show();
            }
        }

        private void BarEmployeePhone_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (employeeGuideWF == null || employeeGuideWF.IsDisposed)
            {
                employeeGuideWF = new EmployeeGuideWF();
                employeeGuideWF.MdiParent = this;
                employeeGuideWF.Show();
            }
        }

        CustomerMovementInvoiceWF customerMovementInvoiceWF;
		private void barCustomerInvoice_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
            if (customerMovementInvoiceWF==null || customerMovementInvoiceWF.IsDisposed)
            {
                customerMovementInvoiceWF = new CustomerMovementInvoiceWF();
                customerMovementInvoiceWF.MdiParent = this;
                customerMovementInvoiceWF.Show();
            }
		}
	}
}
/*KAYNAKLAR VE KOD
 https://www.cgtytpl.com/openweathermap-ile-hava-durumu-cekme

Kişiye Özel Api Adresi: (Siteye üye olunarak alınıyor.)
https://home.openweathermap.org/api_keys

APİYLE İLGİLİ DETAYLA BİLGİ
https://openweathermap.org/current#builtin


TEMALARLA İLGİLİ KAYNAK;
https://www.youtube.com/watch?v=SUXvAHw6osw

 */