using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game_center_management.BO;
using Game_center_management.BO.Interfaces;

namespace game_center_management.DAL
{
	public class ComputersDAL: ComputerParts,IbaseCrud<Computer>
	{
		public int ADD(Computer model)
		{
			throw new NotImplementedException();
		}

		public int Modify(Computer model)
		{
			throw new NotImplementedException();
		}

		public int Remove(int ID)
		{
			throw new NotImplementedException();
		}


		public List<Computer> GetAll()
		{
			try
			{

				List<Computer> computers = null;
				using (var con = SQLfunctions.GetConnection() )
				{
					using (var cmd = SQLfunctions.Command(con,cmdText:"GetALL_Computers",CommandType.StoredProcedure))
					{
						computers = new List<Computer>();

						using (SqlDataReader reader = cmd.ExecuteReader())
						{
							while (reader.Read())
							{
								//var result = ToObject(reader);
								//computers.Add(result);
								
							}

						}
					}
				}

				return computers;

			}
			catch (Exception e)
			{
				return null;

			}
		}

		//public Computer ToObject(SqlDataReader reader)
		//{
		//	Computer computer = new Computer();
		//	//ComputerParts computerParts = new ComputerParts();

		//	computer.PartID = int.Parse(reader["PartID"].ToString());


		//}
	}
}
