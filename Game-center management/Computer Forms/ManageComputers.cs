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
	public partial class ManageComputers : Form
	{
		private readonly ComputersBLL _computersBll;
		public ManageComputers()
		{
			InitializeComponent();
			_computersBll = new ComputersBLL();

			gridManageComputers.AutoGenerateColumns = false;
		}

		private void InitData()
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

	}
}
