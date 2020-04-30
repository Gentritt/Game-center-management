using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_center_management.Computer_Forms
{
	public partial class RegisterComputers : Form
	{
		public RegisterComputers()
		{
			InitializeComponent();
		}

		private bool ValidateFields()
		{

			var controls = new[]
			{
				txtCooler, txtGrahpicCard, txtHDD, txtHeadSets, txtKeyboard, txtMonitor, txtMotherBoard, txtMouse,
				txtMousePad, txtProcessor, txtPsu, txtRam, txtCooler, txtHDD, txtSsd,
			};

			bool isValid = true;
			foreach (var control in controls.Where(e =>string.IsNullOrEmpty(e.Text)))
			{
				MessageBox.Show("Please Fill All Required Fieldss !");
				isValid = false;

			}

			return isValid;


		}
		private void RegisterComputers_Load(object sender, EventArgs e)
		{

		}

		private void btnsave_Click(object sender, EventArgs e)
		{
			ValidateFields();
		}
	}
}
