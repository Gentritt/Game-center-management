using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_center_management.Products
{
	public partial class RegisterProduct : Form
	{
		public RegisterProduct()
		{
			InitializeComponent();
		}

		private bool ValidateFields()
		{
			var controls = new[] {txtProductName, txtPrice,};
			bool isValid = true;
			foreach (var control in controls.Where(e=>string.IsNullOrEmpty(e.Text)))
			{
				MessageBox.Show("Please fill all your required Fields!!");
				isValid = false;

			}

			return isValid;

		}
		private void RegisterProduct_Load(object sender, EventArgs e)
		{

		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			ValidateFields();
		}
	}
}
