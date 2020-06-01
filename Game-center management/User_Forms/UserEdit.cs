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
using Game_center_management.Forms;

namespace Game_center_management.User_Forms
{
	public partial class UserEdit : Form
	{
		private ClientsBLL clientsBll;
		public UserEdit()
		{
			InitializeComponent();
			clientsBll = new ClientsBLL();
		}

		private void UserEdit_Load(object sender, EventArgs e)
		{


			txtUpdateDate.Text = DateTime.Now.ToShortDateString();
			txtUpdateDate.ReadOnly = true;
			txtUpdateBy.Text = UserSession.LoggedUser.Username;
			txtUpdateBy.ReadOnly = true;
			txtClientID.ReadOnly = true;
			txtClientID.Visible = false;


		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			Clients clients = new Clients();
			clients.ID = int.Parse(txtClientID.Text);
			clients.Name = txtName.Text;
			clients.LastName = txtLastname.Text;
			clients.UserName = txtUsername.Text;
			clients.Password = txtPasswordUserAcc.Text;
			clients.PersonalID = txtPersonalID.Text;
			clients.Address = txtAdress.Text;
			clients.Birthday = DateTime.Parse(rdDatePicker.Text);
			clients.Email = txtEmail.Text;
			clients.PhoneNumber = txtPhone.Text;
			clients.Balance = decimal.Parse(txtBalance.Text);
			clients.UpdatedBy = txtUpdateBy.Text;
			clients.UpdateDate = DateTime.Parse(txtUpdateDate.Text);
			clients.LastUpdate = int.Parse(txtUpdateNo.Text);

			var result = clientsBll.Modify(clients);
			if (result != null)
			{
				UserAccounts sf = new UserAccounts();
				sf.InitData();
				this.Close();
			}
		}
	}
}
