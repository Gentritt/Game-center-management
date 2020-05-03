﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using game_center_management.BLL;
using Game_center_management.Forms;

namespace Game_center_management.Forms
{
	public partial class UserAccounts : Form
	{
		private readonly ClientsBLL clientsBll;
		public UserAccounts()
		{

			InitializeComponent();
			clientsBll = new ClientsBLL();
		}

		private void radGridView1_Click(object sender, EventArgs e)
		{

		}

		public void InitData()
		{
			
			var result = clientsBll.GetAll();
			gridUsers.DataSource = result;



		}

		

		private void Create_User_Load(object sender, EventArgs e)
		{
			InitData();

		}

		private void btnCreateAccount_Click(object sender, EventArgs e)
		{
			CreateUserAccounts createUser = new CreateUserAccounts();
			createUser.ShowDialog();
		}

		private void gridUsers_Click(object sender, EventArgs e)
		{

		}
	}
}
