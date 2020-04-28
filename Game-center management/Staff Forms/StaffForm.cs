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

namespace Game_center_management.Forms
{
	public partial class StaffForm : Form
	{
		private readonly EmployessBLL employessBll;
		public StaffForm()
		{
			
			InitializeComponent();
			employessBll = new EmployessBLL();
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			CreateUserStaff createUserStaff = new CreateUserStaff();
			createUserStaff.ShowDialog();

		}

		
		private void StaffForm_Load(object sender, EventArgs e)
		{

			FillGrid();

		}
		private void FillGrid()
		{
			var result = employessBll.GetAll();
			gridServiceStaff.DataSource = result;

		}

		private void gridServiceStaff_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
