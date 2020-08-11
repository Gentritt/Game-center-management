using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
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
			this.Close();
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

        private void rbAlbanian_CheckedChanged(object sender, EventArgs e)
        {
			if (rbAlbanian.Checked) LangChanged(langCode: "sq");
            
        }

        private void rbEnglish_CheckedChanged(object sender, EventArgs e)
        {
			if (rbEnglish.Checked) LangChanged(langCode: "en-US");
        }
		public void LangChanged(string langCode	)
        {
			CultureInfo c1 = new CultureInfo(langCode);
			Thread.CurrentThread.CurrentCulture = c1;
			Thread.CurrentThread.CurrentUICulture = c1;
			this.Controls.Clear();
			this.InitializeComponent();
		}
    }
}
