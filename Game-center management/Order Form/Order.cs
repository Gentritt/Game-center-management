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
using Game_center_management.Products;

namespace Game_center_management.Products
{
    public partial class Order : Form
    {
        private readonly OrderBLL orderBLL;
        public Order()
        {
            InitializeComponent();
            orderBLL = new OrderBLL();
        }
        private void Order_Load(object sender, EventArgs e)
        {
            var result = orderBLL.GetAll();
            grvOrders.DataSource = result;
        }
        private static int id;
       
        private void cmbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            Orders o = new Orders();
            
            orderBLL.GetByName(cmbProduct.SelectedItem.ToString());
            lblPrice.Text = o.Price.ToString();
            id = o.ProductId;
        }

        private void btnGiveOrder_Click(object sender, EventArgs e)
        {
            Orders orders = new Orders();
            orders.ProductId = int.Parse(textBox1.Text);
            orders.BillId = int.Parse(lblBillID.Text);
            orders.Quantity = int.Parse(txtQuantity.Text);
            orders.Price = double.Parse(textBox2.Text);
            
            var result = orderBLL.ADD(orders);

            if (result != 0)
            {
                MessageBox.Show("Data inserted succesfully!!!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Insert / FAil");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
