using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game_center_management.Computer_Forms;
using game_center_management.DAL;

namespace Game_center_management
{
	class FillComboBox
	{
		//public void BindData()
		//{
		//	try
		//	{
		//		using (var con = SQLfunctions.GetConnection())
		//		{
		//			using (var cmd = SQLfunctions.Command(con, cmdText: "GetPartID", cmdType: CommandType.StoredProcedure))
		//			{
		//				using (SqlDataReader dr = cmd.ExecuteReader())
		//				{
		//					while (dr.Read())

		//					{
		//						ComputersEdit cp = new ComputersEdit();

		//						cp.cmbPC.Items.Add(dr[0]);

		//					}
							
							
		//				}



		//			}

					
		//		}
		//	}
		//	catch (Exception e)
		//	{
		//		throw (e);
		//	}
			



		//}
	}
}
