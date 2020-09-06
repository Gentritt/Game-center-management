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
using Game_center_maagement.BO;

namespace Game_center_management.Products
{
    public partial class Order : Form
    {
        private readonly OrderBLL orderBLL;
        private readonly ProductsDal prodal;
        
        public Order()
        {
            InitializeComponent();
            orderBLL = new OrderBLL();
            prodal = new ProductsDal();
        }
        private void Order_Load(object sender, EventArgs e)
        {
            lblBillID.Visible = false;

            var result = orderBLL.GetAll();
            grvOrders.DataSource = result;
            InitData();
        }
        private static int id;
        private void InitData()
        {
            grvProducts.DataSource = prodal.GetAll();
        }
        private void cmbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            string item = cmbProduct.SelectedItem.ToString();
            for (int rows = 0; rows < grvProducts.Rows.Count; rows++)
            {
                if (grvProducts.Rows[rows].Cells[1].Value.ToString() == item)
                {
                    id = int.Parse(grvProducts.Rows[rows].Cells[0].Value.ToString());
                }
            }
            Orders o = new Orders();
            
            orderBLL.GetByName(id);
            lblPrice.Text = StaticClass.Price.ToString();
            //id = StaticClass.ID;

            
            

            //textBox2.Text = cmbProduct.Items.Count.ToString();
            //lblPrice.Text += grvProducts.Rows[0].Cells["ProductName"].Value;

          
            
            //if (dataGridView1.row[i].Cells["ColName"].Value < dataGridView2.row[j].Cells["ColName"].Value)
        }

        private void btnGiveOrder_Click(object sender, EventArgs e)
        {
            Orders orders = new Orders();
            orders.ProductId = id;
            orders.BillId = int.Parse(lblBillID.Text);
            orders.Quantity = int.Parse(cmbQuantity.SelectedItem.ToString());
            orders.Price = double.Parse(lblPrice.Text);
            
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
       
        private void cmbQuantity_SelectedIndexChanged(object sender, EventArgs e)
        {
            double sum2 = StaticClass.Price;
            double nr = double.Parse(cmbQuantity.SelectedItem.ToString());
            double sum = sum2 * nr;
           
            lblPrice.Text = sum.ToString();
        }
    }
}
