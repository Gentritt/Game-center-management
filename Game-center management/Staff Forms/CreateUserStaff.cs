using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using game_center_management.BLL;
using Game_center_management.BO;
using Game_center_management.Forms;

namespace Game_center_management.Staff_Forms
{
	public partial class CreateUserStaff : Form
	{
		private readonly EmployessBLL employessbll;
	
		public CreateUserStaff()
		{
			InitializeComponent();
			employessbll = new EmployessBLL();
			
		}

		private void InitData()
		{
			var result = employessbll.GetAll();
			

		}

		private bool ValidateFields()
		{


			var controls = new[]
			{
				txtNameStaff, txtBirthday, txtPhoneNumber, txtPersonalID, txtLastNameStaff, txtPasswordStaff,
				txtUsernameStaff, txtPersonalID, txtEmail
			};

			bool isValid = true;
			foreach (var control in controls.Where(e => string.IsNullOrEmpty(e.Text)));
			{
				MessageBox.Show("Please fill all your required fields!!");

				isValid = false;

			}

			return isValid;
		}
		private void EmailValidator()
		{
			string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
			if (Regex.IsMatch(txtEmail.Text, pattern))
			{

				return;
			}
			else
			{
				MessageBox.Show("Email is not Valid!!");
			}


		}

		private void BirthdayValidator()
		{

			Regex pattern = new Regex(@"(((0|1)[0-9]|2[0-9]|3[0-1])\/(0[1-9]|1[0-2])\/((19|20)\d\d))$");
			bool isValid = pattern.IsMatch(txtBirthday.Text.Trim());
			DateTime dt;
			isValid = DateTime.TryParseExact(txtBirthday.Text, "dd/MM/yyyy", new CultureInfo("en-GB"),
				DateTimeStyles.None, out dt);
			if (!isValid)
			{

				MessageBox.Show("Invalid Birthday!!");
			}
			else
			{
				//MessageBox.Show("email is valid");
				return;
			}
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			
			ValidateFields();
			EmailValidator();
			BirthdayValidator();

		}

	

		
	}
}
