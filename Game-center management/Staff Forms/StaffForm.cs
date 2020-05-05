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
using Game_center_management.Staff_Forms;
using Telerik.Pivot.Core.Totals;
using Telerik.WinControls.UI;

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
			//gridServiceStaff.AutoSizeColumnsMode = (GridViewAutoSizeColumnsMode) DataGridViewAutoSizeColumnsMode.ColumnHeader;

			FillGrid();

		}
		public void FillGrid()
		{
			var result = employessBll.GetAll();
			gridServiceStaff.DataSource = result;

		}

		private void gridServiceStaff_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void gridServiceStaff_Click(object sender, EventArgs e)
		{

		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			
			

		}

		private void contextMenuStaff_Opening(object sender, CancelEventArgs e)
		{

		}

		private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
		{

			int index = gridServiceStaff.SelectedCells[0].RowIndex;
			if (index < 0) return;

			Employess employess = (Employess) gridServiceStaff.Rows[index].DataBoundItem;
			if (employess != null)
			{

				employessBll.Remove(employess.ID);

			}


		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			gridServiceStaff.Update();
			
		}

		private void btnRefresh_Click(object sender, EventArgs e)
		{
			this.Hide();
			StaffForm stf = new StaffForm();
			stf.ShowDialog();
		}
	}
}
