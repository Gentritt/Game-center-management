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
    public partial class ComputerStart : Form
    {
        private readonly BillBLL billBll;
        private readonly ComputersBLL computerBll;
        public ComputerStart()
        {
            InitializeComponent();
            billBll = new BillBLL();
            computerBll = new ComputersBLL();
        }
        
        private void ComputerStart_Load(object sender, EventArgs e)
        {
            BindData();
            txtStartTime.Text = DateTime.Now.ToShortTimeString();
            txtStartTime.ReadOnly = true;
            txtEmployee.ReadOnly = true;
            txtComputerID.ReadOnly = true;
        }
        public void BindData()
        {
            using (var con = SQLfunctions.GetConnection())
            {
                using (var cmd = SQLfunctions.Command(con, cmdText: "GetClient", cmdType: CommandType.StoredProcedure))
                {
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            cmbClientID.Items.Add(dr[0]);
                        }
                    }
                }
            }
        }
        public static int cID;
        private void BtnSave_Click(object sender, EventArgs e)
        {
            Bill bill = new Bill();
            bill.EmployeeUsername = txtEmployee.Text;
            bill.ComputerId = int.Parse(txtComputerID.Text);
            bill.ClientUsername = cmbClientID.SelectedItem.ToString();
            bill.StartTime = DateTime.Parse(txtStartTime.Text);
           
            var result = billBll.ADD(bill);

            Computer pc = new Computer();
            pc.ComputerID = int.Parse(txtComputerID.Text);

            var result1 = computerBll.IsActive(pc);

            if (result != 0)
            {
                MessageBox.Show("Data inserted succesfully!!!");
                //Bill products = new Products();
                //products.InitData();
                this.Close();

            }
            else
            {
                MessageBox.Show("Insert / FAil");
            }
            cID = int.Parse(txtComputerID.Text);

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "file://C:\\Users\\Eugen\\Documents\\My HelpAndManual Projects\\Projekti.chm", "ComputerS.htm");
        }
    }
}