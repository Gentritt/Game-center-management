using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using game_center_management.BLL;
using Telerik.Charting;
using Product = Game_center_management.BO.Product;

namespace Game_center_management.Products
{
	public partial class RegisterProduct : Form
	{
		private readonly ProductBLL _productBll;
		
		public RegisterProduct()
		{
			InitializeComponent();
			_productBll = new ProductBLL();
		}

		private void RegisterProduct_Load(object sender, EventArgs e)
		{
			txtInserBy.Text += UserSession.LoggedUser.Username;
			txtInserBy.ReadOnly = true;
			txtInserDate.Text += DateTime.Now.ToShortDateString();
			txtInserDate.ReadOnly = true;

		}

		private void ValidateNotNULL()
		{

			if (txtProductName.Text != "")
			{
				
				erpProductName.Dispose();
			}

			if (txtPrice.Text != "")
			{
				erpProductPrice.Dispose();

			}

			if (txtQuantity.Text != "")
			{

				erpQuantity.Dispose();
			}

			if (txtInserBy.Text != "")
			{

				erpInsertBy.Dispose();
			}

			if (txtInserDate.Text != "")
			{
				erpInsertDate.Dispose();
			}
		}

		private void ValidateFields()
		{
			if (txtProductName.Text == "")
			{

				erpProductName.SetError(txtProductName, "This cannot be blank");
			}
			if (txtPrice.Text == "")
			{
				erpProductPrice.SetError(txtPrice, "This cannot be blank");

			}
			if (txtQuantity.Text == "")
			{


				erpQuantity.SetError(txtQuantity, "This cannot be blank");
			}
			if (txtInserBy.Text == "")
			{

				erpInsertBy.SetError(txtInserBy, "This cannot be blank");
			}
			if (txtInserDate.Text == "")
			{

				erpInsertDate.SetError(txtInserDate, "This cannot be blank");
			}

		
			else
			{
				BO.Product product = new BO.Product();
				product.ProductName = txtProductName.Text;
				product.Price = decimal.Parse(txtPrice.Text);
				product.Quantity = int.Parse(txtQuantity.Text);
				product.Insertby = txtInserBy.Text;
				product.InserDate = DateTime.Parse(txtInserDate.Text);

				var result = _productBll.ADD(product);

				if (result != 0)
				{
					MessageBox.Show("Data inserted succesfully!!!");
					Products products = new Products();
					products.InitData();
					this.Close();

				}
				else
				{
					MessageBox.Show("Insert / FAil");
				}


				//products.Refresh();
				//products.Update();

			}


		}

		private void btnSave_Click(object sender, EventArgs e)
		{

			ValidateFields();
			ValidateNotNULL();
		}

		private void txtQuantity_TextChanged(object sender, EventArgs e)
		{
			if (Regex.IsMatch(txtQuantity.Text, "[^0-9]"))
			{
				MessageBox.Show("Please enter only numbers");
				txtQuantity.Text = txtQuantity.Text.Remove(txtQuantity.Text.Length - 1);

			}
		}

		private void txtPrice_TextChanged(object sender, EventArgs e)
		{
			if (Regex.IsMatch(txtPrice.Text, "[^0-9.-]"))
			{
				MessageBox.Show("Please enter only numbers");
				txtPrice.Text = txtPrice.Text.Remove(txtPrice.Text.Length - 1);

			}
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void bnEdit_Click(object sender, EventArgs e)
		{

			//Product product = new Product();
			//product.ProductName = txtProductName.Text;
			//product.Price = decimal.Parse(txtPrice.Text);
			//product.Quantity = int.Parse(txtQuantity.Text);
			//product.UpdatedBy = txtUpdateBy.Text;
			//product.UpdateDate = DateTime.Parse(txtUpdateDate.Text);
			//product.LastUpdate = int.Parse(txtUpdateNO.Text);
			////product.Insertby = txtInserBy.Text;
			////product.InserDate = DateTime.Parse(txtInserDate.Text);

			//var result = _productBll.Modify(product);
		}
	}
}
