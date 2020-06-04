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
	public partial class ComputerPartsEdit : Form
	{

		ComputerPartsBLL computerParts;
		public ComputerPartsEdit()
		{
			InitializeComponent();
			computerParts = new ComputerPartsBLL();
		}

		private void ComputerPartsEdit_Load(object sender, EventArgs e)
		{
			txtUpdateBy.Text += UserSession.LoggedUser.Username;
			txtUpdateBy.ReadOnly = true;
			txtUpdateDate.Text += DateTime.Now.ToShortDateString();
			txtUpdateDate.ReadOnly = true;
			txtPartID.ReadOnly = true;
			txtPartID.Visible = true;
			txtUpdateNo.ReadOnly = true;


		}

		private void btnsave_Click(object sender, EventArgs e)
		{
			BO.ComputerParts parts = new BO.ComputerParts();

			parts.PartID = int.Parse(txtPartID.Text);
			parts.ComputerCase = txtCase.Text;
			parts.ComputerMouse = txtMouse.Text;
			parts.ComputerKeyboard = txtKeyboard.Text;
			parts.ComputerHeadSet = txtHeadSets.Text;
			parts.ComputerMonitor = txtMonitor.Text;
			parts.ComputerMousePad = txtMousePad.Text;
			parts.ComputerCPU = txtProcessor.Text;
			parts.ComputerGraphicCard = txtGrahpicCard.Text;
			parts.ComputerMotherboard = txtMotherBoard.Text;
			parts.ComputerRAM = txtRam.Text;
			parts.ComputerSSD = txtSsd.Text;
			parts.ComputerHDD = txtHDD.Text;
			parts.ComputerPSU = txtPsu.Text;
			parts.ComputerCooler = txtCooler.Text;
			parts.UpdatedBy = txtUpdateBy.Text;
			parts.UpdateDate =DateTime.Parse( txtUpdateDate.Text);
			parts.LastUpdate = int.Parse(txtUpdateNo.Text);
			var result = computerParts.Modify(parts);
			if(result != null)
			{
				ComputerParts cp = new ComputerParts();
				cp.InitData();
				this.Close();
			}




		}
	}
}
