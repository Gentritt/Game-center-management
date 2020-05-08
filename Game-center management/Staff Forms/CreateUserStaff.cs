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

		//private bool ValidateFields()
		//{


		//	var controls = new[]
		//	{
		//		txtNameStaff, txtBirthday, txtPhoneNumber, txtPersonalID, txtLastNameStaff, txtPasswordStaff,
		//		txtUsernameStaff, txtPersonalID, txtEmail
		//	};

		//	bool isValid = true;
		//	foreach (var control in controls.Where(e => string.IsNullOrEmpty(e.Text)));
		//	{
		//		MessageBox.Show("Please fill all your required fields!!");

		//		isValid = false;

		//	}

		//	return isValid;
		//}
		private void EmailValidator()
		{
			string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
			if (Regex.IsMatch(txtEmail.Text, pattern))
			{

				txtAddress.Focus();
			}
			else 
			{
				DialogResult dialogResult = MessageBox.Show("Email is not Valid!!");
				if (dialogResult ==DialogResult.OK)
				{
					txtEmail.Focus();

				}
			}


		}
		private void ValidateNotNULL()
		{

			if (txtNameStaff.Text != "")
			{
				erpName.Dispose();
			}

			if (txtLastNameStaff.Text != "")
			{
				erpLastName.Dispose();

			}

			if (rdDatetimepicker.Text != "")
			{
				erpBirthday.Dispose();
				//BirthdayValidator();
			}

			if (txtEmail.Text != "")
			{
				//EmailValidator();
				erpMail.Dispose();
				
			}

			if (txtAddress.Text != "")
			{
				erpAdress.Dispose();
			}

			if (txtUsernameStaff.Text != "")
			{
				erpUsername.Dispose();
			}

			if (txtPasswordStaff.Text != "")
			{
				erpPassword.Dispose();
			}

			if (txtPersonalID.Text != "")
			{
				erpPersonalID.Dispose();
			}

			if (txtSalary.Text != "")
			{
				erpSalary.Dispose();
			}

			if (txtInsertBy.Text != "")
			{
				erpInsertby.Dispose();
			}

			if (txtInsertDate.Text != "")
			{
				erpInsertDate.Dispose();
			}

			if (txtPhoneNumber.Text != "")
			{
				erpPhone.Dispose();
			}


		}
		private bool ValidateNullFields()
		{
			if (txtSalary.Text != "" && txtPersonalID.Text != "" && txtAddress.Text != "" &&
			    txtPhoneNumber.Text != "" &&
			    txtLastNameStaff.Text != "" && txtNameStaff.Text != "" && txtPasswordStaff.Text != "" &&
			    txtUsernameStaff.Text != "" && txtEmail.Text != "")
				return true;
			else
			{
				return false;
			}



		}
		private void ValidateFields()
		{
			if (txtUsernameStaff.Text == "")
			{

				erpUsername.SetError(txtUsernameStaff, "This cannot be blank");
			}
			if (txtPasswordStaff.Text == "")
			{

				erpPassword.SetError(txtPasswordStaff, "This cannot be blank");
			}
			if (txtNameStaff.Text == "")
			{

				erpName.SetError(txtNameStaff, "This cannot be blank");
			}
			if (txtLastNameStaff.Text == "")
			{

				erpLastName.SetError(txtLastNameStaff, "This cannot be blank");
			}
			if (rdDatetimepicker.Text == "")
			{

				erpBirthday.SetError(rdDatetimepicker, "This cannot be blank");
			}
			if (txtPhoneNumber.Text == "")
			{
				erpPhone.SetError(txtPhoneNumber, "This cannot be blank");
			}
			if (txtEmail.Text == "")
			{

				erpMail.SetError(txtEmail, "This cannot be blank");
			}
			if (txtInsertBy.Text == "")
			{
				erpInsertby.SetError(txtInsertBy, "This cannot be blank");
			}
			if (txtInsertDate.Text == "")
			{
				erpInsertDate.SetError(txtInsertDate, "This cannot be blank");
			}
			if (txtAddress.Text == "")
			{
				erpAdress.SetError(txtAddress, "This cannot be blank");
			}
			if (txtSalary.Text == "")
			{
				erpSalary.SetError(txtSalary, "This cannot be blank");
			}
			if (txtPersonalID.Text == "")
			{
				erpPersonalID.SetError(txtPersonalID, "This cannot be Blank");
			}
			else if(ValidateNullFields()==true)
			{
				Employess employess = new Employess();

				employess.Name = txtNameStaff.Text;
				employess.LastName = txtLastNameStaff.Text;
				employess.Username = txtUsernameStaff.Text;
				employess.Password = txtPasswordStaff.Text;
				employess.PersonalID = txtPersonalID.Text;
				employess.Adress = txtAddress.Text;
				employess.Birthday = DateTime.Parse(rdDatetimepicker.Text);
				employess.Email = txtEmail.Text;
				employess.PhoneNumber = txtPhoneNumber.Text;
				employess.Salary = double.Parse(txtSalary.Text);
				employess.Insertby = txtInsertBy.Text;
				employess.InserDate = DateTime.Parse(txtInsertDate.Text);

				employessbll.ADD(employess);
				StaffForm sf = new StaffForm();
				sf.FillGrid();
				this.Close();
				
			
				
				

			}

		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			EmailValidator();
			ValidateFields();
			ValidateNotNULL();
		
			

		}

		private void CreateUserStaff_Load(object sender, EventArgs e)
		{
			txtInsertBy.Text += UserSession.LoggedUser.Username;
			txtInsertBy.ReadOnly = true;
			txtInsertDate.Text += DateTime.Now.ToShortDateString();
			txtInsertDate.ReadOnly = true;
		}
		private void txtPersonalID_TextChanged(object sender, EventArgs e)
		{
			if (Regex.IsMatch(txtPersonalID.Text, "[^0-9]"))
			{
				MessageBox.Show("Please enter only numbers");
				txtPersonalID.Text = txtPersonalID.Text.Remove(txtPersonalID.Text.Length - 1);

			}


		}

		private void txtSalary_TextChanged(object sender, EventArgs e)
		{
			if (Regex.IsMatch(txtSalary.Text, "[^0-9.-]"))
			{
				MessageBox.Show("Please enter only numbers");
				txtSalary.Text = txtSalary.Text.Remove(txtSalary.Text.Length - 1);

			}
		}

		private void btnCancelStaff_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void radGroupBox1_Click(object sender, EventArgs e)
		{

		}
	}
}
