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
using Telerik.WinControls.UI;

namespace Game_center_management.Computer_Forms
{
	public partial class ManageComputers : Form
	{
		private readonly ComputersBLL _computersBll;
		public ManageComputers()
		{
			InitializeComponent();
			_computersBll = new ComputersBLL();

			gridManageComputers.AutoGenerateColumns = false;
		}

		public void InitData()
		{
			var result = _computersBll.GetAll();
			gridManageComputers.DataSource = result;

		}
		private void radButton1_Click(object sender, EventArgs e)
		{
			ComputerParts computerParts = new ComputerParts();
			computerParts.ShowDialog();
		}

		private void ManageComputers_Load(object sender, EventArgs e)
		{
			InitData();

		}

		private void radPanel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void btnADD_Click(object sender, EventArgs e)
		{

			RegisterComputers rg = new RegisterComputers();
			rg.ShowDialog();

		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			DialogResult dialogResult = MessageBox.Show("Are you sure you wanna delete this? ", "Computer Parts",
				MessageBoxButtons.YesNo);
			if (dialogResult == DialogResult.Yes)
			{
				int index = this.gridManageComputers.Rows.IndexOf((GridViewDataRowInfo)this.gridManageComputers.CurrentRow);
				if (index < 0) return;
				BO.Computer computer = (BO.Computer)gridManageComputers.Rows[index].DataBoundItem;
				if (index != null)
				{

					_computersBll.Remove(computer.ComputerID);


				}

			}
			else if (dialogResult == DialogResult.No)
			{
				this.Hide();
				ManageComputers mg = new ManageComputers();
				mg.ShowDialog();
			}
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{

			int index = this.gridManageComputers.Rows.IndexOf((GridViewDataRowInfo)this.gridManageComputers.CurrentRow);
			if (index < 0) return;
			BO.Computer computer = (BO.Computer)gridManageComputers.Rows[index].DataBoundItem;

			if(computer != null)
			{
				ComputersEdit ce = new ComputersEdit();
				ce.txtComputerID.Text = gridManageComputers.CurrentRow.Cells[0].Value.ToString();
				ce.cmbPC.Text = gridManageComputers.CurrentRow.Cells[1].Value.ToString();
				ce.txtPricePerHour.Text = gridManageComputers.CurrentRow.Cells[2].Value.ToString();

				ce.ShowDialog();

			}

		}

		private void btnRefresh_Click(object sender, EventArgs e)
		{
			this.Hide();
			ManageComputers mg = new ManageComputers();
			mg.ShowDialog();
		}
	}
}
