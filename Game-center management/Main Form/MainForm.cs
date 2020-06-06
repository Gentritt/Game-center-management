using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using game_center_management.BLL;
using Game_center_management.Computer_Forms;
using Game_center_management.Forms;
using Microsoft.VisualBasic.Devices;
using Telerik.WinControls.UI;
using Computer = Game_center_management.BO.Computer;

namespace Game_center_management
{
	public partial class MainForm : Form
	{
		private ComputersBLL computers;

		public MainForm()
		{
			InitializeComponent();
			computers = new ComputersBLL();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			foreach (Computer computer in computers.GetAll())
			{
				listviewitem.Items.Add( new ListViewItem (computer.ComputerID.ToString(),0));
			}
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
			Products.Products products = new Products.Products();
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
        
        private void startToolStripMenuItem_Click(object sender, EventArgs e)
		{
           

			ManageComputers mg = new ManageComputers();
			mg.ShowDialog();
		}

		private void listviewitem_MouseClick(object sender, MouseEventArgs e)
		{
			
		}

		private void listviewitem_MouseClick_1(object sender, MouseEventArgs e)
		{
			//if (e.Button == MouseButtons.Right)
			//{

			//	if (listviewitem.FocusedItem.Bounds.Contains(e.Location))
			//	{
			//		contextMenuStrip1.Show(Cursor.Position);
			//	}
			//	else
			//	{
			//		contextMenuStrip1.Hide();

			//	}
			//}

			//ListView listView = sender as ListView;
			//if (e.Button == MouseButtons.Right)
			//{
			//	ListViewItem item = listviewitem.GetItemAt(e.X, e.Y);
			//	if (item != null)
			//	{
			//		item.Selected = true;
			//		contextMenuStrip1.Show(listView, e.Location);
			//	}
			//}

		}


		private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
		{


			if (listviewitem.SelectedItems.Count  <= 0)
			{

				e.Cancel = true;
			}
		}
	}
}
