using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Game_center_management.Computer_Forms;
using Game_center_management.Forms;

namespace Game_center_management
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			
			//this.Shown += MainForm_Shown;
		

		}

		private void radMenuItem17_Click(object sender, EventArgs e)
		{
			StaffForm staffForm = new StaffForm();
			staffForm.ShowDialog();

		}

		private void MainForm_Shown(object sender, EventArgs e)
		{
			LoginForm loginForm = new LoginForm();
			loginForm.ShowDialog();

			if (UserSession.LoggedUser != null)
			{
				lblLoggedUser.Text += UserSession.LoggedUser.Username;
				lblUserAdministrator.Text = UserSession.LoggedUser.Username;
				lblDatetime.Text += DateTime.Now.ToString();
				timer1.Start();
			}
			else
			{
				this.Close();

			}
			
			

		}


		private void radMenuItem16_Click(object sender, EventArgs e)
		{
			UserAccounts useracc = new UserAccounts();
			useracc.ShowDialog();

		}

		private void radMenuItem18_Click(object sender, EventArgs e)
		{
			ManageComputers manageComputers = new ManageComputers();
			manageComputers.ShowDialog();
		}

		private void menuRegjistrimiProduktev_Click(object sender, EventArgs e)
		{
			Products.Product products = new Products.Product();
			products.ShowDialog();

		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			lblDatetime.Text = DateTime.Now.ToString();
			timer1.Start();
		}

		private void radMenuItem17_Click_1(object sender, EventArgs e)
		{
			Application.Restart();
		}

		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{

				DialogResult dialog = MessageBox.Show("Are you sure you want to Exit ?", "Exit",MessageBoxButtons.YesNo);

				if (dialog == DialogResult.Yes)
				{
					Application.Exit(); 

				}
				else if (dialog == DialogResult.No)
				{

					e.Cancel = true;
					
					
				}
		}
	}
}
