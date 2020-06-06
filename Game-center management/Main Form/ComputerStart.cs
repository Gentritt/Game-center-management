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

namespace Game_center_management.Main_Form
{
    public partial class ComputerStart : Form
    {
        public ComputerStart()
        {
            InitializeComponent();
        }

        private void StartComputer_Load(object sender, EventArgs e)
        {
            BindData();
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {

        }

        public void BindData()
        {
            using (var con = SQLfunctions.GetConnection())
            {
                using (var cmd = SQLfunctions.Command(con, cmdText: "GetClientID", cmdType: CommandType.StoredProcedure))
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
    }
}
