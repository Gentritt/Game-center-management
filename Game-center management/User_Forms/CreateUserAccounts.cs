using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_center_management.Forms
{
	public partial class CreateUserAccounts : Form
	{
		public CreateUserAccounts()
		{
			InitializeComponent();
		}


		private bool ValidateFields()
		{

			var controls = new[]
				{txtName, txtBirthday, txtEmail, txtPasswordUserAcc, txtPhone, txtUsername, txtLastname};

			bool isValid = true;
			foreach (var control in controls.Where(e => string.IsNullOrEmpty(e.Text)))
			{
				MessageBox.Show("Please fill all required fieldss !!");
				isValid = false;

			}

			return isValid;



		}
		private void CreateUserAccounts_Load(object sender, EventArgs e)
		{

		}

		private void grLoginInformation_Click(object sender, EventArgs e)
		{

		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			ValidateFields();
		}
	}
}
