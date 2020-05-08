using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using game_center_management.BLL;
using Game_center_management.BO;

namespace Game_center_management.Forms
{
	public partial class CreateUserAccounts : Form
	{
		private readonly ClientsBLL clientsBll;
		public CreateUserAccounts()
		{
			InitializeComponent();
			clientsBll = new ClientsBLL();
			//rdDatetime.Format = DateTimePickerFormat.Custom;
			//rdDatetime.CustomFormat = "dd/MM/yyyy";
			////rdDatetime.ShowUpDown = true;

		}

		private void EmailValidator()
		{
			string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
			if (Regex.IsMatch(txtEmail.Text, pattern))
			{


			}
			else
			{
				DialogResult dialogResult = MessageBox.Show("This email is not Valid");
				if (dialogResult == DialogResult.OK)
				{
					txtEmail.Focus();

				}
			}


		}
		

		//private void BirthdayValidator()
		//{

		//	Regex pattern = new Regex(@"(((0|1)[0-9]|2[0-9]|3[0-1])\/(0[1-9]|1[0-2])\/((19|20)\d\d))$");
		//	bool isValid = pattern.IsMatch(date.Text.Trim());
		//	DateTime dt;
		//	isValid = DateTime.TryParseExact(rdDatetime.Text, "dd/MM/yyyy" , new CultureInfo("en-GB"),
		//		DateTimeStyles.None, out dt);
		//	if (!isValid)
		//	{

		//		MessageBox.Show("Ivalid Birthday!!");
		//	}
		//	else
		//	{
		//		//MessageBox.Show("email is valid");
		//		return;
		//	}
		//}

		private bool ValidateNullFields()
		{
			if(txtName.Text != "" && txtLastname.Text != "" && txtAdress.Text != "" && txtEmail.Text != "" &&
				txtUsername.Text != "" && txtPasswordUserAcc.Text != "" && txtPhone.Text != "" &&
				txtPersonalID.Text != "" && txtBalance.Text != ""
			)
			 return false;


			else
			{
				return true;
			}

		}
		private void ValidateNotNULL()
		{

			if (txtName.Text != "")
			{
				erpName.Dispose();
			}

			if (txtLastname.Text != "")
			{
				erpLastname.Dispose();

			}

			if (rdDatetime.Text != "")
			{
				erpBirthday.Dispose();
			}

			if (txtEmail.Text != "")
			{
				erpMail.Dispose();
				//EmailValidator();
			}

			if (txtAdress.Text != "")
			{
				erpAdress.Dispose();
			}

			if (txtUsername.Text != "")
			{
				erpUsername.Dispose();
			}

			if (txtPasswordUserAcc.Text != "")
			{

				erpPassword.Dispose();
			}

			if (txtPersonalID.Text != "")
			{
				erpPersonalID.Dispose();
			}

			if (txtBalance.Text != "")
			{
				erpBalance.Dispose();
			}

			if (txtInsertBy.Text != "")
			{
				erpInsertbY.Dispose();
			}

			if (txtInsertDate.Text != "")
			{
				erpInsertDate.Dispose();
			}

			if (txtPhone.Text != "")
			{
				erpPhone.Dispose();
			}


		}
		private void ValidateFields()
		{

			if (txtUsername.Text == "")
			{

				erpUsername.SetError(txtUsername, "This cannot be blank");
			}

			if (txtPasswordUserAcc.Text == "")
			{

				erpPassword.SetError(txtPasswordUserAcc, "This cannot be blank");
			}

			if (txtName.Text == "")
			{

				erpName.SetError(txtName, "This cannot be blank");
			}

			if (txtLastname.Text == "")
			{

				erpLastname.SetError(txtLastname, "This cannot be blank");
			}

			if (rdDatetime.Text == "")
			{

				erpBirthday.SetError(rdDatetime, "This cannot be blank");
			}

			if (txtPhone.Text == "")
			{
				erpPhone.SetError(txtPhone, "This cannot be blank");
			}

			if (txtEmail.Text == "")
			{

				erpMail.SetError(txtEmail, "This cannot be blank");
			}

			if (txtInsertBy.Text == "")
			{
				erpInsertbY.SetError(txtInsertBy, "This cannot be blank");
			}

			if (txtInsertDate.Text == "")
			{
				erpInsertDate.SetError(txtInsertDate, "This cannot be blank");
			}

			if (txtAdress.Text=="")
			{
				erpAdress.SetError(txtAdress,"This cannot be blank");
			}

			if (txtBalance.Text == "")
			{
				erpBalance.SetError(txtBalance,"This cannot be blank");
			}

			if (txtPersonalID.Text == "")
			{
				erpPersonalID.SetError(txtPersonalID,"This cannot be Blank");
			}
			else if(ValidateNullFields()==true )
			{
		

				Clients clients = new Clients();
				clients.Name = txtName.Text;
				clients.LastName = txtLastname.Text;
				clients.Address = txtAdress.Text;
				clients.Birthday =DateTime.Parse(rdDatePicker.Text);
				clients.Email = txtEmail.Text;
				clients.UserName = txtUsername.Text;
				clients.Password = txtPasswordUserAcc.Text;
				clients.PhoneNumber = txtPhone.Text;
				clients.PersonalID = txtPersonalID.Text;
				clients.Balance = decimal.Parse(txtBalance.Text);
				clients.Insertby = txtInsertBy.Text;
				clients.InserDate = DateTime.Parse(txtInsertDate.Text);
				clientsBll.ADD(clients);
				UserAccounts userAccounts = new UserAccounts();
				userAccounts.InitData();
				this.Close();

				



			}

		}
		
		private void btnSave_Click(object sender, EventArgs e)
		{
			EmailValidator();
			ValidateFields();
			ValidateNotNULL();
		}

		private void CreateUserAccounts_Load(object sender, EventArgs e)
		{

			//rdDatetime.Format = DateTimePickerFormat.Custom;
			//rdDatetime.CustomFormat = "dd-MM-yyyy";
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

		private void txtBalance_TextChanged(object sender, EventArgs e)
		{
			if (Regex.IsMatch(txtBalance.Text, "[^0-9.-]"))
			{
				MessageBox.Show("Please enter only numbers");
				txtBalance.Text = txtBalance.Text.Remove(txtBalance.Text.Length - 1);

			}
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
