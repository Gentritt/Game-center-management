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
    public partial class BillDetails : Form
    {
        private readonly BillBLL billBLL;
        private readonly ComputersBLL computersBLL;

        ManageComputers mc = new ManageComputers();
        public BillDetails()
        {
            InitializeComponent();
            billBLL = new BillBLL();
            computersBLL = new ComputersBLL();
        }
        
        private void Calculate()
        {
            //foreach (var item in grdComputer.Columns)
            //{
            //    if(this.rdvBill.CurrentRow.Cells[2].Value.ToString() == item.ToString())
            //    {
            //        lblTotal.Text = grdComputer.CurrentRow.Cells[2].Value.ToString();
            //    }
            //}

            //string data = string.Empty;
            //int indexOfYourColumn = 0;
            //foreach (DataGridViewRow row in grdComputer.Rows)
            //{
            //    data = row.Cells[indexOfYourColumn].Value.ToString();

            //    foreach (var item in data)
            //    {
            //        if (this.rdvBill.CurrentRow.Cells[2].Value.ToString() == item.ToString())
            //        {
            //            lblTotal.Text = grdComputer.CurrentRow.Cells[2].Value.ToString();

            //        }

            //    }
            //}

        }
        private void InitData()
        {
            int id = MainForm.cID;
            //int id = ComputerStart.cID;
            var result = billBLL.Get(id);
            rdvBill.DataSource = result;
            
        }
        private void BillDetails_Load(object sender, EventArgs e)
        {
            InitData();
        }
        private void TotalPrice()
        {
            DateTime startTime = DateTime.Parse(this.rdvBill.CurrentRow.Cells[4].Value.ToString());
            DateTime endTime = DateTime.Parse(this.rdvBill.CurrentRow.Cells[5].Value.ToString());
            //int Column =int.Parse(this.grdComputer.CurrentRow.Cells[2].Value.ToString());

            double minutes = (endTime - startTime).TotalHours;
            double cost = 1;
            if (minutes < 1)
                lblTotal.Text = Convert.ToDouble(cost).ToString();
            else
                lblTotal.Text = Convert.ToDouble(cost + Math.Round(minutes - 1)).ToString();

            int billId = int.Parse(this.rdvBill.CurrentRow.Cells[0].Value.ToString());
            int total = int.Parse(lblTotal.Text);
            Bill bill = new Bill();
            bill.Total = int.Parse(total.ToString());
            bill.BillID = billId;
            billBLL.GetTotal(bill);
        }
        private void BtnPrint_Click(object sender, EventArgs e)
        {
            
            lblBillID.Text = this.rdvBill.CurrentRow.Cells[0].Value.ToString();
            lblEmployee.Text = this.rdvBill.CurrentRow.Cells[1].Value.ToString();
            lblComputerID.Text = this.rdvBill.CurrentRow.Cells[2].Value.ToString();
            lblClient.Text = this.rdvBill.CurrentRow.Cells[3].Value.ToString();
            lblStartTime.Text = this.rdvBill.CurrentRow.Cells[4].Value.ToString();
            lblEndTime.Text = this.rdvBill.CurrentRow.Cells[5].Value.ToString();
            //lblTotal.Text = this.rdvBill.CurrentRow.Cells[6].Value.ToString();
            //Calculate();
            TotalPrice();
            UsingTime();
            if (lblEndTime.Text != "01/01/0001 00:00:00")
            {
                btnEndTime.Enabled = false;
            }
            else
            {
                btnEndTime.Enabled = true;
                lblEndTime.Text = "";
            }

        }
        private void UsingTime()
        {
            DateTime startTime = DateTime.Parse(this.rdvBill.CurrentRow.Cells[4].Value.ToString()); ;
            DateTime endTime = DateTime.Parse(this.rdvBill.CurrentRow.Cells[5].Value.ToString());
            string diffTime = endTime.Subtract(startTime).ToString().Split('.')[0].ToString();
            if (lblEndTime.Text != "01/01/0001 00:00:00")
            {
                lblUsingTime.Text = diffTime;
            }
            else
            {
                lblUsingTime.Text = "";
            }
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            this.Hide();
            BillDetails bd = new BillDetails();
            bd.ShowDialog();
        }

        private void BtnEndTime_Click(object sender, EventArgs e)
        {
            string dateTime = DateTime.Now.ToShortTimeString();
            int billId = int.Parse(this.rdvBill.CurrentRow.Cells[0].Value.ToString());

            Bill bill = new Bill();
            bill.EndTime = DateTime.Parse(dateTime);
            bill.BillID = billId;

            billBLL.GetEndTime(bill);
        }
    }
}
