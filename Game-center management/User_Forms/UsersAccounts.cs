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
using Telerik.WinControls.UI;

namespace Game_center_management.Forms
{
	public partial class UserAccounts : Form
	{
		private readonly ClientsBLL clientsBll;
		public UserAccounts()
		{

			InitializeComponent();
			clientsBll = new ClientsBLL();
		}


		public void InitData()
		{
			
			var result = clientsBll.GetAll();
			gridUsers.DataSource = result;



		}

		

		private void Create_User_Load(object sender, EventArgs e)
		{
			InitData();

		}

		private void btnCreateAccount_Click(object sender, EventArgs e)
		{
			CreateUserAccounts createUser = new CreateUserAccounts();
			createUser.ShowDialog();
		}


		private void btnDeleteAccount_Click(object sender, EventArgs e)
		{
			DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this client?","Title", MessageBoxButtons.YesNo);

			if (dialogResult==DialogResult.Yes)
			{

				int index = this.gridUsers.Rows.IndexOf((GridViewRowInfo) this.gridUsers.CurrentRow);
				if (index < 0) return;
				Clients clients = (Clients)gridUsers.Rows[index].DataBoundItem;

				if (clients != null)
				{

					clientsBll.Remove(clients.ID);

				}


			}
			else if (dialogResult == DialogResult.No)
			{

				this.Hide();
				UserAccounts user = new UserAccounts();
				user.ShowDialog();


			}





		}


		private void btnRefresh_Click(object sender, EventArgs e)
		{

			this.Hide();
			UserAccounts user = new UserAccounts();
			user.ShowDialog();
		}
	}
}
