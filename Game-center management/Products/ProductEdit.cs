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
using Game_center_management.BO;
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

		private static int count = 0;
		private void ProductEdit_Load(object sender, EventArgs e)
		{
			txtUpdateBy.Text += UserSession.LoggedUser.Username;
			txtUpdateBy.ReadOnly = true;
			txtUpdateDate.Text += DateTime.Now.ToShortDateString();
			txtUpdateDate.ReadOnly = true;
			txtProductID.Visible = false;
			txtProductID.ReadOnly = false;
			txtUpdateNo.ReadOnly = true;
			count++;
			txtUpdateNo.Text = count.ToString();



		}
		private void btnSave_Click(object sender, EventArgs e)
		{
			Product product = new Product();
			product.ProductID = int.Parse(txtProductID.Text);
			product.ProductName = txtProductName.Text;
			product.Price = decimal.Parse(txtPrice.Text);
			product.Quantity = int.Parse(txtQuantity.Text);
			product.UpdatedBy = txtUpdateBy.Text;
			product.UpdateDate = DateTime.Parse(txtUpdateDate.Text);
			product.LastUpdate = int.Parse(txtUpdateNo.Text);
		  var result  = bll.Modify(product);
		  if (result != null)
		  {

			  Products products = new Products();
			  products.InitData();
			  MessageBox.Show("Data Updated Successfully");
			  this.Close();

		  }

		}
		private void btnCancel_Click(object sender, EventArgs e)
		{
            this.Close();
		}
	}
}
