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

		private void InitData()
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
	}
}
