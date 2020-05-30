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

namespace Game_center_management.Staff_Forms
{
	public partial class StaffEditForm : Form
	{
		private readonly EmployessBLL employessBll;
		public StaffEditForm()
		{
			InitializeComponent();
			employessBll = new EmployessBLL();
		}

		private void StaffEditForm_Load(object sender, EventArgs e)
		{
			txtUpdateBy.Text += UserSession.LoggedUser.Username;
			txtUpdateBy.ReadOnly = true;
			txtUpdateDate.Text += DateTime.Now.ToShortDateString();
			txtUpdateDate.ReadOnly = true;
			txtEmployeeID.Visible = false;
			txtEmployeeID.ReadOnly = false;
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			Employess employess = new Employess();

			employess.Name = txtNameStaff.Text;
			employess.LastName = txtLastNameStaff.Text;
			employess.Username = txtUsernameStaff.Text;
			employess.Password = txtPasswordStaff.Text;
			employess.PersonalID = txtPersonalID.Text;
			employess.Adress = txtAddress.Text;
			employess.Birthday = DateTime.Parse(rdDatetimepicker.Text);
			employess.Email = txtEmail.Text;
			employess.PhoneNumber = txtPhoneNumber.Text;
			employess.Salary = double.Parse(txtSalary.Text);
			employess.UpdatedBy = txtUpdateBy.Text;
			employess.UpdateDate = DateTime.Parse(txtUpdateDate.Text);
			employess.LastUpdate = int.Parse(txtUpdateNo.Text);

			var result =employessBll.Modify(employess);
			if (result != null)
			{
				StaffForm sf = new StaffForm();
				sf.FillGrid();
				this.Close();
			}
		


		}
	}
}
