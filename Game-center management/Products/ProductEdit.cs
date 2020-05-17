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

namespace Game_center_management.Products
{
	public partial class ProductEdit : Form
	{
		BO.Product product = new BO.Product();
		private readonly ProductBLL bll;
		//private List<Product> products = null;
		

		public ProductEdit()
		{
			InitializeComponent();
			bll = new ProductBLL();
		}

		private void ProductEdit_Load(object sender, EventArgs e)
		{
			Product products = new Product();

			bll.GetByID( product.ProductID);

			product.ProductName = txtProductName.Text;
			product.ProductID = int.Parse(txtProductID.Text);
			product.Price = decimal.Parse(txtPrice.Text);
			product.Quantity = int.Parse(txtQuantity.Text);

		}

		private void btnSave_Click(object sender, EventArgs e)
		{

		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
		}
	}
}
