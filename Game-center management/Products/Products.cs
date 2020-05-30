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
using Telerik.WinControls.UI;
using Product = Game_center_management.BO.Product;

namespace Game_center_management.Products
{
	public partial class Products : Form
	{
		private readonly ProductBLL productBll;
		

		public Products()

		{

			
			InitializeComponent();
			ProductsGRID.AutoGenerateColumns = false;
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
				if (index < 0) return;
				BO.Product product = (BO.Product)ProductsGRID.Rows[index].DataBoundItem;
				if (product != null)
				{
					productBll.Remove(product.ProductID);
				}

			}
			else if (dialogResult == DialogResult.No)
			{
				
				
				this.Hide();
				Products  products = new Products();
				products.ShowDialog();
			}
		

		}

		private void btnRefresh_Click(object sender, EventArgs e)
		{
			this.Hide();
			Products products = new Products();
			products.ShowDialog();
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			int index = ProductsGRID.SelectedCells[0].RowIndex;
			if (index < 0) return;
			BO.Product product = (BO.Product)ProductsGRID.Rows[index].DataBoundItem;
			if (product != null)
			{
				ProductEdit edit = new ProductEdit();
				edit.txtProductName.Text = this.ProductsGRID.CurrentRow.Cells[1].Value.ToString();
				edit.txtPrice.Text = this.ProductsGRID.CurrentRow.Cells[2].Value.ToString();
				edit.txtQuantity.Text = this.ProductsGRID.CurrentRow.Cells[3].Value.ToString();
				edit.ShowDialog();
			}
		}

		private void ProductsGRID_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void ProductsGRID_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			
		}
	}
}
