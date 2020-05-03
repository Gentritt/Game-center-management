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

			if (txtBirthday.Text != "")
			{
				erpBirthday.Dispose();
			}

			if (txtEmail.Text != "")
			{
				erpMail.Dispose();
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

			if (txtBirthday.Text == "")
			{

				erpBirthday.SetError(txtBirthday, "This cannot be blank");
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
			else
			{
				Clients clients = new Clients();
				clients.Name = txtName.Text;
				clients.LastName = txtLastname.Text;
				clients.Address = txtAdress.Text;
				clients.Birthday = DateTime.Parse(txtBirthday.Text);
				clients.Email = txtEmail.Text;
				clients.UserName = txtUsername.Text;
				clients.Password = txtPasswordUserAcc.Text;
				clients.PhoneNumber = txtPhone.Text;
				clients.PersonalID = txtPersonalID.Text;
				clients.Balance = decimal.Parse(txtBalance.Text);
				clients.Insertby = txtInsertBy.Text;
				clients.InserDate = DateTime.Parse(txtInsertDate.Text);
				clientsBll.ADD(clients);

				//Employess employess = new Employess();

				//employess.Name = txtName.Text;
				//employess.LastName = txtLastname.Text;
				//employess.Username = txtUsername.Text;
				//employess.Password = txtPasswordUserAcc.Text;
				//employess.PersonalID = txtPersonalID.Text;
				//employess.Adress = txtAdress.Text;
				//employess.Birthday = DateTime.Parse(txtBirthday.Text);
				//employess.Email = txtEmail.Text;
				//employessBll.ADD(employess);

				UserAccounts userAccounts = new UserAccounts();
				userAccounts.InitData();
				this.Close();


			}

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
			ValidateNotNULL();

		}
	}
}
