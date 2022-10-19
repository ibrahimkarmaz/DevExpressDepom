using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.WinFormList
{
    public partial class ProductTypeList : DevExpress.XtraEditors.XtraForm
    {
        public ProductTypeList()
        {
            InitializeComponent();
        }
        BlandManager _blandManager = new BlandManager(new EFBlandDAL());

        private void BlandGridControlSettings()
        {
            GViewBland.OptionsBehavior.Editable = false;
            GViewBland.OptionsBehavior.ReadOnly = true;
        }
        private void BlandGetAllList()
        {
            GControlBland.DataSource = _blandManager.GetAllList();
        }

        private void ProductTypeList_Load(object sender, EventArgs e)
        {
            BlandGridControlSettings();
            BlandGetAllList();
        }
    }
}