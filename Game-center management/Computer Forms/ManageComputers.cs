﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_center_management.Computer_Forms
{
	public partial class ManageComputers : Form
	{
		public ManageComputers()
		{
			InitializeComponent();
		}

		private void btnADD_Click(object sender, EventArgs e)
		{
		
		}

		private void radButton1_Click(object sender, EventArgs e)
		{
			ComputerParts computerParts = new ComputerParts();
			computerParts.ShowDialog();
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{

		}
	}
}
