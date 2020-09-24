using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Threading;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Game_center_management.BO;
using Game_center_maagement.BO;
using game_center_management.BLL;
using Game_center_management.Products;
using Game_center_management.Computer_Forms;
using Game_center_management.Forms;
using Microsoft.VisualBasic.Devices;
using Telerik.WinControls.UI;
using Computer = Game_center_management.BO.Computer;
using Bill = Game_center_management.BO.Bill;
using game_center_management.DAL;

namespace Game_center_management
{
	public partial class MainForm : Form
	{
		private ComputersBLL computers;
        private readonly BillBLL billBLL;
		public MainForm()
		{
			InitializeComponent();
			computers = new ComputersBLL();
            billBLL = new BillBLL();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			foreach (Computer computer in computers.GetAll())
			{
                if (computer.IsActive == true)
                {
                    listviewitem.Items.Add(new ListViewItem(computer.ComputerID.ToString(), 0)).ForeColor = System.Drawing.Color.Red;
                }
                else if (computer.IsActive == false)
                {
                    listviewitem.Items.Add(new ListViewItem(computer.ComputerID.ToString(), 0)).ForeColor = System.Drawing.Color.Green;
                }
			}
		}
        
		private void radMenuItem17_Click(object sender, EventArgs e)
		{
			StaffForm staffForm = new StaffForm();
			staffForm.ShowDialog();
		}
        private static int nr = 1;
		private void MainForm_Shown(object sender, EventArgs e)
		{
           

            if (lang == false)
            {
                LoginForm loginForm = new LoginForm();
                loginForm.ShowDialog();
                if (nr == 1)
                {
                    if (LoginForm.lang1 == true)
                    {
                        lang = true;
                        LangChanged(langCode: "sq");
                    }
                    else if (LoginForm.lang2 == true)
                    {
                        lang = true;
                        LangChanged(langCode: "en-US");
                    }
                    nr++;
                }
            }
          

            if (UserSession.LoggedUser != null)
            {
                lblLoggedUser.Text += UserSession.LoggedUser.Username;
                lblUserAdministrator.Text = UserSession.LoggedUser.Username;
                lblDatetime.Text += DateTime.Now.ToString();
                timer1.Start();
            }
            else
            {
                this.Close();

            }
        }


		private void radMenuItem16_Click(object sender, EventArgs e)
		{
			UserAccounts useracc = new UserAccounts();
			useracc.ShowDialog();

		}

		private void radMenuItem18_Click(object sender, EventArgs e)
		{
			ManageComputers manageComputers = new ManageComputers();
			manageComputers.ShowDialog();
		}

		private void menuRegjistrimiProduktev_Click(object sender, EventArgs e)
		{
			Products.Products products = new Products.Products();
			products.ShowDialog();
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			lblDatetime.Text = DateTime.Now.ToString();
			timer1.Start();
        }

		private void radMenuItem17_Click_1(object sender, EventArgs e)
		{
			Application.Restart();
		}

		//private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		//{
  //          DialogResult dialog = MessageBox.Show("Are you sure you want to Exit ?", "Exit", MessageBoxButtons.YesNo);
  //          if (dialog == DialogResult.No)
  //          {
  //              e.Cancel = true;
  //          }
  //      }
        
        private void startToolStripMenuItem_Click(object sender, EventArgs e)
		{
            ComputerStart cs = new ComputerStart();
            ListViewItem item = listviewitem.SelectedItems[0];
            cs.txtComputerID.Text = item.SubItems[0].Text;
            cs.txtEmployee.Text = lblLoggedUser.Text;
            cs.ShowDialog();

        }
		private void listviewitem_MouseClick(object sender, MouseEventArgs e)
		{
			
		}

        public static int cID;
		private void listviewitem_MouseClick_1(object sender, MouseEventArgs e)
		{

            ListViewItem item = listviewitem.SelectedItems[0];
            cID = int.Parse(item.SubItems[0].Text);

            //if (e.Button == MouseButtons.Right)
            //{

            //	if (listviewitem.FocusedItem.Bounds.Contains(e.Location))
            //	{
            //		contextMenuStrip1.Show(Cursor.Position);
            //	}
            //	else
            //	{
            //		contextMenuStrip1.Hide();

            //	}
            //}

            //ListView listView = sender as ListView;
            //if (e.Button == MouseButtons.Right)
            //{
            //	ListViewItem item = listviewitem.GetItemAt(e.X, e.Y);
            //	if (item != null)
            //	{
            //		item.Selected = true;
            //		contextMenuStrip1.Show(listView, e.Location);
            //	}
            //}

        }


		private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
		{


			if (listviewitem.SelectedItems.Count  <= 0)
			{

				e.Cancel = true;
			}
		}

        private void DetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BillDetails bd = new BillDetails();
            bd.ShowDialog();
        }

        private void StopToolStripMenuItem_Click(object sender, EventArgs e)
        {
           

        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            lang = true;
            this.Hide();
            MainForm mf = new MainForm();
            mf.ShowDialog();
        }

        private void RadMenuItem13_admClick(object sender, EventArgs e)
        {
            if (lblLoggedUser.Text == "admin")
            {
                miAdministrationMenu.Enabled = true;

            }
            else if (lblLoggedUser.Text != "admin")
            {
                miAdministrationMenu.Enabled = false;
            }
        }

        private static bool lang;
        private void radMenuItem22_Click(object sender, EventArgs e)
        {
            lang = true;
            LangChanged(langCode: "sq");
        }

        private void radMenuItem21_Click(object sender, EventArgs e)
        {
            lang = true;
            LangChanged(langCode: "en-US");
        }
		public void LangChanged(string langCode)
		{
			CultureInfo c1 = new CultureInfo(langCode);
			Thread.CurrentThread.CurrentCulture = c1;
			Thread.CurrentThread.CurrentUICulture = c1;

            //CultureInfo culture = new CultureInfo(language);
            //NumberFormatInfo numFormatInfo = (NumberFormatInfo)culture.NumberFormat.Clone();

            //c1.DateTimeFormat.DateSeparator = "/";
            //c1.DateTimeFormat.ShortDatePattern = "d/M/yyyy hh:mm:ss";
            //c1.DateTimeFormat.LongDatePattern = "dddd, d MMMM yyyy";
            //Thread.CurrentThread.CurrentCulture = c1;
            //Thread.CurrentThread.CurrentUICulture = c1;

            this.Hide();
			MainForm mf = new MainForm();
			mf.ShowDialog();

		}
        public static void GetHelpProvider(Form frm,string topic)
        {
            Help.ShowHelp(frm, "NewProject.chm", HelpNavigator.Topic,topic);
        }

        private void radMenuItem19_Click(object sender, EventArgs e)
        {
            //GetHelpProvider(this, "Hyrje.htm");
            Help.ShowHelp(this, "file://C:\\Users\\Eugen\\Documents\\My HelpAndManual Projects\\Projekti.chm", "Hyrje.htm");
        }

        private void orderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListViewItem item = listviewitem.SelectedItems[0];
            cId = int.Parse(item.SubItems[0].Text);

            Bill bill = new Bill();
            bill.ComputerId = cId;
            
            
            billBLL.GetBillId(bill);
            Order order = new Order();
            order.lblBillID.Text = StaticClass.BillID.ToString();

            using (var con = SQLfunctions.GetConnection())
            {
                using (var cmd = SQLfunctions.Command(con, cmdText: "GetProduct", cmdType: CommandType.StoredProcedure))
                {
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            order.cmbProduct.Items.Add(dr[0]);
                        }
                    }
                }
            }
            order.ShowDialog();

        }
        public static int cId;
        private void endToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListViewItem item = listviewitem.SelectedItems[0];
            cId = int.Parse(item.SubItems[0].Text);

            Bill bill = new Bill();
            bill.ComputerId = cId;

            billBLL.GetBillId(bill);

            string dateTime = DateTime.Now.ToShortTimeString();
            

            Bill bills = new Bill();
            
            bills.EndTime = DateTime.Parse(dateTime);
            bills.BillID = StaticClass.BillID;

            billBLL.GetEndTime(bills);

            Computer pc = new Computer();
            pc.ComputerID = cId;

            computers.IsActiveFalse(pc);

            BillDetails bd = new BillDetails();
            bd.ShowDialog();

        }

        private void radMenuItem23_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Numri/Number: 038-500-300 \n Email: gaming-center@hotmail.com \n Adresa: Rruga B Bregu i diellit","Contact Us");
        }
    }
}
