using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using DevExpress.XtraEditors;
using PresentationLayer.WinFormList.ProductWF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.WinFormList.ProductStockWF
{
	public partial class ProductStocksWF : DevExpress.XtraEditors.XtraForm
	{
		public ProductStocksWF()
		{
			InitializeComponent();
		}
		ProductManager _productManager = new ProductManager(new EFProductDAL());
		private void ProductGetAndStoctLimitsDTO()
		{
			GControlProductStock.DataSource = _productManager.ProductGetList(x => x.ProductArchive == true && x.ProductPiece <= 20);
		}
		private void ProductStocksWF_Load(object sender, EventArgs e)
		{
			ProductGetAndStoctLimitsDTO();
		}
	
		private void GViewProductStock_DoubleClick(object sender, EventArgs e)
		{
			try
			{
			    ProductWF.ProductWF.ProductID = (int)GViewProductStock.GetRowCellValue(GViewProductStock.FocusedRowHandle, GViewProductStock.Columns[0]);
				ProductStockUpdateWF productStockUpdate = new ProductStockUpdateWF();
				productStockUpdate.ShowDialog();
				ProductGetAndStoctLimitsDTO();
			}
			catch (Exception)
			{
				ProductWF.ProductWF.ProductID = -1;
				XtraMessageBox.Show("ÜRÜN SEÇİNİZ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);

			}
		}
	}
}