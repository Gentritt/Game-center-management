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
	}
}
