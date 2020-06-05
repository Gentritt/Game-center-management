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
	public partial class ComputersEdit : Form
	{
		private ComputersBLL computersBll;
		public ComputersEdit()
		{
			InitializeComponent();
			computersBll = new ComputersBLL();
		}

		public void BindData()
		{
			using (var con = SQLfunctions.GetConnection())
			{
				using (var cmd = SQLfunctions.Command(con, cmdText: "GetPartID", cmdType: CommandType.StoredProcedure))
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

		private static int count = 0;
		private void ComputersEdit_Load(object sender, EventArgs e)
		{
			FillComboBox fill = new FillComboBox();
			txtUpdateDate.Text += DateTime.Now.ToShortDateString();
			txtUpdateDate.ReadOnly = true;
			txtupdateby.Text += UserSession.LoggedUser.Username;
			txtupdateby.ReadOnly = true;
			txtComputerID.ReadOnly = true;
			txtComputerID.Visible = false;
			txtUpdateNo.ReadOnly = true;
			BindData();
			count++;
			txtUpdateNo.Text = count.ToString();

		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			Computer computer = new Computer();
			computer.PartID = int.Parse(cmbPC.SelectedItem.ToString());
			computer.ComputerID = int.Parse(txtComputerID.Text);
			computer.PricePerHour = double.Parse(txtPricePerHour.Text);
			computer.UpdatedBy = txtupdateby.Text;
			computer.UpdateDate = DateTime.Parse(txtUpdateDate.Text);
			computer.LastUpdate = int.Parse(txtUpdateNo.Text);

			var result = computersBll.Modify(computer);
			if (result != null)
			{

				ManageComputers mg = new ManageComputers();
				mg.InitData();
				this.Close();
			}

		}

		private void cmbPC_SelectedIndexChanged(object sender, EventArgs e)
		{
		}
	}
}
