using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using DevExpress.Utils.Extensions;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraEditors;
using DevExpress.XtraTab;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.WinFormList.CustomerWF
{
    public partial class CustomerWF : DevExpress.XtraEditors.XtraForm
    {
        public CustomerWF()
        {
            InitializeComponent();
        }
        CustomerManager _customerManager = new CustomerManager(new EFCustomerDAL());
        private void accordionControlNewCustomer_Click(object sender, EventArgs e)
        {
            CustomerAddWF customerAddWF = new CustomerAddWF();
            customerAddWF.ShowDialog();
        }
        private void CustomertGetAllList()
        {
            _customerManager = new CustomerManager(new EFCustomerDAL());//LİSTEYİ YENİLEMİYORDU.
            GControlCustomer.DataSource = _customerManager.CustomerGetList(x => x.CustomerArchive == true);
        }
        private void CustomertGetAllListArchive()
        {
            _customerManager = new CustomerManager(new EFCustomerDAL());//LİSTEYİ YENİLEMİYORDU.
            GControlCustomerArchive.DataSource = _customerManager.CustomerGetList(x => x.CustomerArchive == false);
        }
        private void CustomerWF_Load(object sender, EventArgs e)
        {
            CustomertGetAllList();
            CustomertGetAllListArchive();
        }
        private void accordionControlCustomerList_Click(object sender, EventArgs e)
        {
            CustomertGetAllList();
        }
        Customer customer;
        private void accordionControlCustomerArchive_Click(object sender, EventArgs e)
        {
            try
            {
                customer = _customerManager.GetById(int.Parse(GViewCustomer.GetRowCellValue(GViewCustomer.FocusedRowHandle, GViewCustomer.Columns[0]).ToString()));
                customer.CustomerArchive = false;
                _customerManager.TUpdate(customer);
                XtraMessageBox.Show("MÜŞTERİ ARŞİVLENDI.", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                XtraMessageBox.Show("MÜŞTERİ SEÇİNİZ.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void accordionControlCustomerDelete_Click(object sender, EventArgs e)
        {//NOT:MÜŞTERİ BİLGİLERİNİN SİLİNMESİ İÇİN ÜRÜN ALIP ALMADI VEYA FARKLI BİR YERDE OLUP OLMADIĞINI KONTROL ET
            try
            {
                customer = _customerManager.GetById(int.Parse(GViewCustomer.GetRowCellValue(GViewCustomer.FocusedRowHandle, GViewCustomer.Columns[0]).ToString()));
                _customerManager.TRemove(customer);
            }
            catch (Exception)
            {
                XtraMessageBox.Show("MÜŞTERİ SEÇİNİZ.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        CustomerUpdateWF customerUpdateWF;
        public static int CustomerID=-1;
        private void accordionControlCustomerUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                CustomerID= (int)GViewCustomer.GetRowCellValue(GViewCustomer.FocusedRowHandle, GViewCustomer.Columns[0]);
                customerUpdateWF = new CustomerUpdateWF();
                customerUpdateWF.ShowDialog();
                CustomertGetAllList();
            }
            catch (Exception)
            {
                CustomerID = -1;
                XtraMessageBox.Show("MÜŞTERİ SEÇİNİZ.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void accordionControlCustomerArchiveQuit_Click(object sender, EventArgs e)
        {
            try
            {
                customer = _customerManager.GetById(int.Parse(GViewCustomerArchive.GetRowCellValue(GViewCustomerArchive.FocusedRowHandle, GViewCustomerArchive.Columns[0]).ToString()));
                customer.CustomerArchive = true;
                _customerManager.TUpdate(customer);
                XtraMessageBox.Show("MÜŞTERİ ARŞİVDEN ÇIKARILDI.", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CustomertGetAllListArchive();
            }
            catch (Exception)
            {
                XtraMessageBox.Show("ARŞİV LİSTESİNDEN MÜŞTERİ SEÇİNİZ.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void accordionControlCustomerArchiveList_Click(object sender, EventArgs e)
        {
            CustomertGetAllListArchive();

        }
        private void accordionControlCustomerProcess_Click(object sender, EventArgs e)
        {
            xtraTabCustomerControl.SelectedTabPage = TabPageCustomer;
        }

        private void accordionControlArchive_Click(object sender, EventArgs e)
        {
            xtraTabCustomerControl.SelectedTabPage = TabPageCustomerArchive;
        }

        private void xtraTabCustomerControl_Click(object sender, EventArgs e)
        {
            if (xtraTabCustomerControl.SelectedTabPage== TabPageCustomerArchive)
            {
                accordionControl1.ActiveGroup = accordionControlArchive;

            }
            else
            {
                accordionControl1.ActiveGroup = accordionControlCustomerProcess;
            }
        }
    }
}

/*TAB CONTROL VE ELEMENT CONTROL KAYNAK BİLGİSİ
 https://docs.devexpress.com/WindowsForms/DevExpress.XtraTab.XtraTabControl.SelectedTabPage
https://supportcenter.devexpress.com/ticket/details/t844744/how-to-select-accordioncontrolelement-via-code
 */