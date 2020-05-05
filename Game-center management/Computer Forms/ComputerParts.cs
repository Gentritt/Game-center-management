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

namespace Game_center_management.Computer_Forms
{
	public partial class ComputerParts : Form
	{
		private readonly ComputerPartsBLL _computerPartsBll;
		public ComputerParts()
		{
			InitializeComponent();
			
			_computerPartsBll = new ComputerPartsBLL();
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
				int index = gridComputerParts.SelectedCells[0].RowIndex;
				if (index > 0) return;
				BO.ComputerParts computerParts = (BO.ComputerParts)gridComputerParts.Rows[index].DataBoundItem;
				if (index != null)
				{

					_computerPartsBll.Remove(computerParts.PartID);


				}

			}
			else if (dialogResult == DialogResult.No)
			{
				this.Hide();
				ComputerParts cp = new ComputerParts();
				cp.ShowDialog();
			}

		


		}

		private void btnADD_Click(object sender, EventArgs e)
		{
			RegisterComputers registerComputers = new RegisterComputers();
			registerComputers.ShowDialog();
		}

		private void btnRefresh_Click(object sender, EventArgs e)
		{ 
			this.Hide();
			ComputerParts parts = new ComputerParts();
			parts.ShowDialog();
			
		}
	}
}
