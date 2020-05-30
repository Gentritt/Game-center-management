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
			gridServiceStaff.AutoGenerateColumns = false;
			FillGrid();

		}
		public void FillGrid()
		{
			var result = employessBll.GetAll();
			gridServiceStaff.DataSource = result;

		}


		private void btnDelete_Click(object sender, EventArgs e)
		{
			DialogResult dialogResult = MessageBox.Show("Are you sure you wanna delete this? ", "Delete Employee",
				MessageBoxButtons.YesNo);
			if (dialogResult == DialogResult.Yes)
			{
				int index = this.gridServiceStaff.Rows.IndexOf((GridViewDataRowInfo) this.gridServiceStaff.CurrentRow);
				if (index < 0) return;

				Employess employess = (Employess)gridServiceStaff.Rows[index].DataBoundItem;
				if (employess != null)
				{

					employessBll.Remove(employess.ID);

				}


			}
			
			else if (dialogResult == DialogResult.No)
			{
				this.Hide();
				StaffForm form = new StaffForm();
				form.ShowDialog();

			}

		



		}

		

		private void btnEdit_Click(object sender, EventArgs e)
		{

			int index = this.gridServiceStaff.Rows.IndexOf((GridViewDataRowInfo) this.gridServiceStaff.CurrentRow);
			if (index < 0) return;
			BO.Employess employess = (BO.Employess)gridServiceStaff.Rows[index].DataBoundItem;

			if (employess != null)
			{
				StaffEditForm edit = new StaffEditForm();
				edit.txtEmployeeID.Text = this.gridServiceStaff.CurrentRow.Cells[0].Value.ToString();
				edit.txtNameStaff.Text = this.gridServiceStaff.CurrentRow.Cells[1].Value.ToString();
				edit.txtLastNameStaff.Text = this.gridServiceStaff.CurrentRow.Cells[2].Value.ToString();
				edit.txtPersonalID.Text = this.gridServiceStaff.CurrentRow.Cells[3].Value.ToString();
				edit.txtAddress.Text = this.gridServiceStaff.CurrentRow.Cells[4].Value.ToString();
				edit.rdDatetimepicker.Text = this.gridServiceStaff.CurrentRow.Cells[5].Value.ToString();
				edit.txtEmail.Text = this.gridServiceStaff.CurrentRow.Cells[6].Value.ToString();
				edit.txtPhoneNumber.Text = this.gridServiceStaff.CurrentRow.Cells[7].Value.ToString();
				edit.txtUsernameStaff.Text = this.gridServiceStaff.CurrentRow.Cells[8].Value.ToString();
				edit.txtPasswordStaff.Text = this.gridServiceStaff.CurrentRow.Cells[9].Value.ToString();
				edit.txtSalary.Text = this.gridServiceStaff.CurrentRow.Cells[10].Value.ToString();
				edit.ShowDialog();
			}
		}

		private void btnRefresh_Click(object sender, EventArgs e)
		{
			this.Hide();
			StaffForm stf = new StaffForm();
			stf.ShowDialog();
		}

		private void pnlServicStaff_Paint(object sender, PaintEventArgs e)
		{

		}
	}
}
