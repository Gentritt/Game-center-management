using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Game_center_management.Forms;

namespace Game_center_management
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			this.Shown += MainForm_Shown;
		}

		private void radMenuItem17_Click(object sender, EventArgs e)
		{
			StaffForm staffForm = new StaffForm();
			staffForm.ShowDialog();

		}

		private void MainForm_Shown(object sender, EventArgs e)
		{
			LoginForm loginForm = new LoginForm();
			loginForm.ShowDialog();



		}

		private void radMenuItem24_Click(object sender, EventArgs e)
		{

		}
	}
}
