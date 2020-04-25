using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_center_management
{
	public partial class LoginForm : Form
	{
		public LoginForm()
		{
			InitializeComponent();
		}



		private void lblX_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		

		private void btnCancel_Click_1(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
