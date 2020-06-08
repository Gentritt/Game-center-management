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
        public BillDetails()
        {
            InitializeComponent();
            billBLL = new BillBLL();
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

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            lblBillID.Text = this.rdvBill.CurrentRow.Cells[0].Value.ToString();
            lblEmployee.Text = this.rdvBill.CurrentRow.Cells[1].Value.ToString();
            lblComputerID.Text = this.rdvBill.CurrentRow.Cells[2].Value.ToString();
            lblClient.Text = this.rdvBill.CurrentRow.Cells[3].Value.ToString();
            lblStartTime.Text = this.rdvBill.CurrentRow.Cells[4].Value.ToString();
            lblEndTime.Text = this.rdvBill.CurrentRow.Cells[5].Value.ToString();
            lblTotal.Text = this.rdvBill.CurrentRow.Cells[6].Value.ToString();
        }

        private void RdvBill_Click(object sender, EventArgs e)
        {

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
