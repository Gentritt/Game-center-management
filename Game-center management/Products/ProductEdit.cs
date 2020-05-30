using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using game_center_management.BLL;
using game_center_management;
using Game_center_management.Products;

namespace Game_center_management.Products
{
	public partial class ProductEdit : Form
	{
		BO.Product product = new BO.Product();
		private readonly ProductBLL bll;
		//private List<Product> products = null;
		Products products = new Products();
		public ProductEdit()
		{
			InitializeComponent();
			bll = new ProductBLL();
		}
		public void LoadData()
		{
			
			//product.ProductName = txtProductName.Text;
			//if (product.Price.Equals(null))
			//	product.Price = decimal.Parse(txtPrice.Text);
			//if (product.Quantity.Equals(null))
			//	product.Quantity = int.Parse(txtQuantity.Text);
			//txtProductName.Text = this.products.ProductsGRID.CurrentRow.Cells[2].Value.ToString();
			//txtPrice.Text = product.Price.ToString();
			//txtQuantity.Text = product.Quantity.ToString();
		}
		private void ProductEdit_Load(object sender, EventArgs e)
		{
	      LoadData();
		}
		private void btnSave_Click(object sender, EventArgs e)
		{

		}

		private void btnCancel_Click(object sender, EventArgs e)
		{

		}
	}
}
