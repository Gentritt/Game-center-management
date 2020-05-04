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



namespace Game_center_management
{
	public partial class LoginForm : Form
	{
		public LoginForm()
		{
			InitializeComponent();
		}



		private void btnCancel_Click_1(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			string username = txtUsername.Text;
			string password = txtPassword.Text;
			if(username.Trim() =="")
			{
				txtUsername.BackColor = Color.Red;
				txtUsername.Focus();
				return;
				

			}

			if (password.Trim() == "")
			{
				txtPassword.BackColor = Color.Red;
				txtPassword.Focus();
				return;
			}

			

			LoginBLL login = new LoginBLL();
			Employess employess = login.Login(username, password);	

			if (employess == null)
			{

				MessageBox.Show("Kontrolloni Username / Password");
			}

			else
			{
				UserSession.LoggedUser = employess;
				this.Close();
				
			}


		}

		private void LoginForm_Load(object sender, EventArgs e)
		{

		}
	}
}
