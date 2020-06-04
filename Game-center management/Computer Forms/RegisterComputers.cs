using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using game_center_management.BLL;
using Game_center_management.BO;
using game_center_management.DAL;

namespace Game_center_management.Computer_Forms
{
	public partial class RegisterComputers : Form
	{
		private ComputersBLL computersBLL;

		public RegisterComputers()
		{
			InitializeComponent();
			computersBLL = new ComputersBLL();
		}

		private void ValidateFields()
		{
			if (txtPricePerHour.Text == "")
			{

				erpPricePerhour.SetError(txtPricePerHour, "This cannot be blank");
			}

			//if (txtPartID.Text == "")
			//{

			//	erpPartID.SetError(txtPartID, "This cannot be blank");

			//}
			else
			{
				Computer computer = new Computer();
				//computer.PartID = int.Parse(txtPartID.Text);
				computer.PricePerHour = double.Parse(txtPricePerHour.Text);
				computer.PartID = int.Parse(cmbPC.SelectedItem.ToString());
				computer.Insertby = txtInsertBY.Text;
				computer.InserDate = DateTime.Parse(txtInsertDate.Text);

				computersBLL.ADD(computer);


				ManageComputers mg = new ManageComputers();
				mg.InitData();
				this.Close();

			}

		}

		public void BindData()
		{
			using (var con = SQLfunctions.GetConnection())
			{
				using (var cmd = SQLfunctions.Command(con,cmdText: "GetPartID", cmdType:CommandType.StoredProcedure))
				{
					using (SqlDataReader dr = cmd.ExecuteReader())
					{
						while (dr.Read())

						{
							cmbPC.Items.Add(dr[0]);

						}
					}

				}

			}



		}

		private void RegisterComputers_Load(object sender, EventArgs e)
		{

			txtInsertBY.Text = UserSession.LoggedUser.Username;
			txtInsertBY.ReadOnly = true;
			txtInsertDate.Text += DateTime.Now.ToShortDateString();
			txtInsertDate.ReadOnly = true;
			BindData();

		}

		private void cmbPartID_SelectedIndexChanged(object sender, EventArgs e)
		{

			


		}

		private void btnSave_Click(object sender, EventArgs e)
		{

			ValidateFields();
		}
	}
}
