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
using Telerik.Charting;
using Product = Game_center_management.BO.Product;

namespace Game_center_management.Products
{
	public partial class Products : Form
	{
		private readonly ProductBLL productBll;
		
		
		public Products()
		{
			InitializeComponent();
			productBll = new ProductBLL();
		}

		public void InitData()
		{
			var result = productBll.GetAll();
			ProductsGRID.DataSource = result;


		}
		private void Products_Load(object sender, EventArgs e)
		{
			InitData();

		}

		private void btnADD_Click(object sender, EventArgs e)
		{
			RegisterProduct registerProduct = new RegisterProduct();
			registerProduct.ShowDialog();
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			DialogResult dialogResult = MessageBox.Show("Are you sure you wanna delete this?", "Delete Product",
				MessageBoxButtons.YesNo);

			if (dialogResult == DialogResult.Yes)
			{
				int index = ProductsGRID.SelectedCells[0].RowIndex;
				if (index > 0) return;
				Product product = (Product)ProductsGRID.Rows[index].DataBoundItem;
				if (product != null)
				{
					productBll.Remove(product.ProductID);


				}

			}
			else if (dialogResult == DialogResult.No)
			{

				//....
			}
		

		}

		private void btnRefresh_Click(object sender, EventArgs e)
		{
			this.Hide();
			Products products = new Products();
			products.ShowDialog();
		}
	}
}
