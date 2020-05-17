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
	public partial class RegisterComputerParts : Form
	{
		private readonly ComputerPartsBLL _computerPartsBll;
		public RegisterComputerParts()
		{
			InitializeComponent();
			_computerPartsBll = new ComputerPartsBLL();
			
		}

		

		private void ValidateNotNULL()
		{

			if (txtSsd.Text != "")
			{
				erpSSD.Dispose();
			}

			if (txtHDD.Text != "")
			{
				erpHDD.Dispose();
			}

			if (txtKeyboard.Text != "")
			{
				erpKeyboard.Dispose();
			}

			if (txtCooler.Text != "")
			{
				erpCooler.Dispose();
			}

			if (txtGrahpicCard.Text != "")
			{
				erpGraphicCard.Dispose();
			}

			if (txtHeadSets.Text != "")
			{
				erpHeadSets.Dispose();
			}

			if (txtMonitor.Text != "")
			{
				erpMonitor.Dispose();
			}

			if (txtMotherBoard.Text != "")
			{
				erpMotherBoard.Dispose();
			}

			if (txtMouse.Text != "")
			{
				erpMouse.Dispose();
			}

			if (txtMousePad.Text != "")
			{
				erpMousePad.Dispose();
			}

			//if (txtPricePerHOur.Text != "")
			//{

			//	erpPricePerhour.Dispose();
			//}

			if (txtPsu.Text != "")
			{
				erpPSU.Dispose();
			}

			if (txtRam.Text != "")
			{
				erpRam.Dispose();
			}

			if (txtCase.Text != "")
			{
				erpCase.Dispose();
			}

			if (txtProcessor.Text != "")
			{
				erpProcessor.Dispose();
			}
			
		}
		private void ValidateFields()
		{

			if (txtSsd.Text == "")
			{

				erpSSD.SetError(txtSsd, "This cannot be blank");
			}

			if (txtHDD.Text == "")
			{

				erpHDD.SetError(txtHDD, "This cannot be blank");
			}

			if (txtCooler.Text == "")
			{
				erpCooler.SetError(txtCooler, "This cannot be blank");
			}

			if (txtGrahpicCard.Text == "")
			{

				erpGraphicCard.SetError(txtGrahpicCard, "This cannot be blank");
			}

			if (txtKeyboard.Text == "")
			{
				erpKeyboard.SetError(txtKeyboard, "This cannot be blank");
			}

			if (txtHeadSets.Text == "")
			{
				erpHeadSets.SetError(txtHeadSets, "This cannot be blank");
			}

			if (txtMonitor.Text == "")
			{
				erpMonitor.SetError(txtMonitor, "This cannot be blank");
			}

			if (txtMousePad.Text == "")
			{
				erpMousePad.SetError(txtMousePad, "This cannot be blank");
			}

			if (txtMouse.Text == "")
			{
				erpMouse.SetError(txtMouse, "This cannot be blank");
			}

			//if (txtPricePerHOur.Text == "")
			//{
			//	erpPricePerhour.SetError(txtPricePerHOur,"This cannot be blank");
			//}

			if (txtPsu.Text == "")
			{
				erpPSU.SetError(txtPsu, "This cannot be blank");
			}

			if (txtRam.Text == "")
			{
				erpRam.SetError(txtRam, "This cannot be blank");
			}

			if (txtMotherBoard.Text == "")
			{

				erpMotherBoard.SetError(txtMotherBoard, "This cannot be blank");
			}

			if (txtProcessor.Text == "")
			{
				erpProcessor.SetError(txtProcessor, "This cannot be blank");
			}

			if (txtCase.Text == "")
			{
				erpCase.SetError(txtCase, "This cannot be blank");
			}
			else
			{
				BO.ComputerParts computerParts = new BO.ComputerParts();
				computerParts.ComputerSSD = txtSsd.Text;
				computerParts.ComputerHeadSet = txtHeadSets.Text;
				computerParts.ComputerCPU = txtProcessor.Text;
				computerParts.ComputerMonitor = txtMonitor.Text;
				computerParts.ComputerGraphicCard = txtGrahpicCard.Text;
				computerParts.ComputerMouse = txtMouse.Text;
				computerParts.ComputerMousePad = txtMousePad.Text;
				computerParts.ComputerRAM = txtRam.Text;
				computerParts.ComputerCase = txtCase.Text;
				computerParts.ComputerHDD = txtHDD.Text;
				computerParts.ComputerKeyboard = txtKeyboard.Text;
				computerParts.ComputerPSU = txtPsu.Text;
				computerParts.ComputerCooler = txtCooler.Text;
				computerParts.ComputerCase = txtCase.Text;
				computerParts.ComputerMotherboard = txtMotherBoard.Text;
				computerParts.Insertby = txtInsertBy.Text;
				computerParts.InserDate = DateTime.Parse(txtInsertDate.Text);

				_computerPartsBll.ADD(computerParts);

				ComputerParts computerPartss = new ComputerParts();
				computerPartss.InitData();
				this.Close();




			}

		}


		private void RegisterComputers_Load(object sender, EventArgs e)
		{
			txtInsertBy.Text += UserSession.LoggedUser.Username;
			txtInsertBy.ReadOnly = true;

			txtInsertDate.Text += DateTime.Now.ToShortDateString();
			txtInsertDate.ReadOnly = true;

		}

		private void btnsave_Click(object sender, EventArgs e)
		{
			ValidateFields();
			ValidateNotNULL();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void radPanel1_Paint(object sender, PaintEventArgs e)
		{

		}
	}
}
