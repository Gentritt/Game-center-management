﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using game_center_management.BLL;
using Game_center_management.BO;
using Game_center_management.Forms;

namespace Game_center_management.Staff_Forms
{
	public partial class CreateUserStaff : Form
	{
		private readonly EmployessBLL employessbll;
	
		public CreateUserStaff()
		{
			InitializeComponent();
			employessbll = new EmployessBLL();
			
		}

		//private void ValidateTextBoxes()
		//{

		//	foreach (Control item in this.Controls)
		//	{
		//		if (item is TextBox)
		//		{

		//			if (string.IsNullOrEmpty(item.Text))
		//			{

		//				MessageBox.Show(item.Name + "Must be filled");
		//				break;


		//			}
		//		}
				
		//	}

		//}
		
		private void InitData()
		{
			var result = employessbll.GetAll();
			

		}

		private bool ValidateFields()
		{


			var controls = new[]
			{
				txtNameStaff, txtBirthday, txtPhoneNumber, txtPersonalID, txtLastNameStaff, txtPasswordStaff,
				txtUsernameStaff, txtPersonalID, txtEmail
			};

			bool isValid = true;
			foreach (var control in controls.Where(e => string.IsNullOrEmpty(e.Text)));
			{
				MessageBox.Show("Please fill all your required fields!!");

				isValid = false;

			}

			return isValid;
		}


		private void btnOK_Click(object sender, EventArgs e)
		{
			
			ValidateFields();
			Employess employess = new Employess();

		}

		private void CreateUserStaff_Load(object sender, EventArgs e)
		{

		}

		
	}
}
