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
using Game_center_management.Staff_Forms;
using Telerik.WinControls.UI;

namespace Game_center_management.Computer_Forms
{
	public partial class ComputerParts : Form
	{
		private readonly ComputerPartsBLL _computerPartsBll;
		public ComputerParts()
		{
			InitializeComponent();
			
			_computerPartsBll = new ComputerPartsBLL();
			gridComputerParts.AutoGenerateColumns = false;
		}

		public void InitData()
		{
			var result = _computerPartsBll.GetAll();
			gridComputerParts.DataSource = result;


		}
		private void ComputerParts_Load(object sender, EventArgs e)
		{
			InitData();

		}

		private void btnDelete_Click(object sender, EventArgs e)

		{
			DialogResult dialogResult = MessageBox.Show("Are you sure you wanna delete this? ", "Computer Parts",
				MessageBoxButtons.YesNo);
			if (dialogResult == DialogResult.Yes)
			{
				int index = this.gridComputerParts.Rows.IndexOf((GridViewDataRowInfo)this.gridComputerParts.CurrentRow);
				if (index < 0) return;
				BO.ComputerParts computerparts = (BO.ComputerParts)gridComputerParts.Rows[index].DataBoundItem;
				if (index != null)
				{

					_computerPartsBll.Remove(computerparts.PartID);


				}

			}
			else if (dialogResult == DialogResult.No)
			{
				this.Hide();
				ManageComputers mg = new ManageComputers();
				mg.ShowDialog();
			}

		


		}

		private void btnADD_Click(object sender, EventArgs e)
		{
			RegisterComputerParts registerComputers = new RegisterComputerParts();
			registerComputers.ShowDialog();
		}

		private void btnRefresh_Click(object sender, EventArgs e)
		{ 
			this.Hide();
			ComputerParts parts = new ComputerParts();
			parts.ShowDialog();
			
		}

		private static int count = 0;
		private void btnEdit_Click(object sender, EventArgs e)
		{
			ComputerPartsEdit cp = new ComputerPartsEdit();

			int index = this.gridComputerParts.Rows.IndexOf((GridViewDataRowInfo) this.gridComputerParts.CurrentRow);
			if (index < 0) return;
			BO.ComputerParts computerParts = (BO.ComputerParts) gridComputerParts.Rows[index].DataBoundItem;
			if (computerParts != null)
			{
				
				cp.txtPartID.Text = gridComputerParts.CurrentRow.Cells[0].Value.ToString();
				cp.txtCase.Text = gridComputerParts.CurrentRow.Cells[1].Value.ToString();
				cp.txtMouse.Text = gridComputerParts.CurrentRow.Cells[2].Value.ToString();
				cp.txtKeyboard.Text = gridComputerParts.CurrentRow.Cells[3].Value.ToString();
				cp.txtHeadSets.Text = gridComputerParts.CurrentRow.Cells[4].Value.ToString();
				cp.txtMonitor.Text = gridComputerParts.CurrentRow.Cells[5].Value.ToString();
				cp.txtMousePad.Text = gridComputerParts.CurrentRow.Cells[6].Value.ToString();
				cp.txtProcessor.Text = gridComputerParts.CurrentRow.Cells[7].Value.ToString();
				cp.txtGrahpicCard.Text = gridComputerParts.CurrentRow.Cells[8].Value.ToString();
				cp.txtMotherBoard.Text = gridComputerParts.CurrentRow.Cells[9].Value.ToString();
				cp.txtRam.Text = gridComputerParts.CurrentRow.Cells[10].Value.ToString();
				cp.txtSsd.Text = gridComputerParts.CurrentRow.Cells[11].Value.ToString();
				cp.txtHDD.Text = gridComputerParts.CurrentRow.Cells[12].Value.ToString();
				cp.txtPsu.Text = gridComputerParts.CurrentRow.Cells[13].Value.ToString();
				cp.txtCooler.Text = gridComputerParts.CurrentRow.Cells[14].Value.ToString();
				count++;
				cp.txtUpdateNo.Text = count.ToString();
				cp.ShowDialog();
			}
		}

		private void radPanel1_Paint(object sender, PaintEventArgs e)
		{

		}
	}
}
