using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Game_center_management.BO;

namespace Game_center_management.Computer_Forms
{
	public partial class RegisterComputers : Form
	{
		public RegisterComputers()
		{
			InitializeComponent();
		}

		private void ValidateFields()
		{
			if (txtPricePerHour.Text == "")
			{

				erpPricePerhour.SetError(txtPricePerHour,"This cannot be blank");
			}

			if (txtPartID.Text == "")
			{

				erpPartID.SetError(txtPartID,"This cannot be blank");

			}
			else
			{
				Computer computer = new Computer();
				computer.PartID = int.Parse(txtPartID.Text);
				computer.PricePerHour = double.Parse(txtPricePerHour.Text);




			}

		}

		private void RegisterComputers_Load(object sender, EventArgs e)
		{


		}

	}
}
