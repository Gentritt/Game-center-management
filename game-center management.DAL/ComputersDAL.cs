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
		public int IsActive(Computer model)
        {
			try
			{
				using (var con = SQLfunctions.GetConnection())
				{
					using (var cmd = SQLfunctions.Command(con, cmdText: "IsActive", cmdType: CommandType.StoredProcedure))
					{
						cmd.Parameters.AddWithValue("@computerId", model.ComputerID);
						
						int rowaffected = cmd.ExecuteNonQuery();
						return rowaffected;
					}
				}
			}
			catch (Exception e)
			{
				return -1;
			}
		}
		public int IsActiveFalse(Computer model)
		{
			try
			{
				using (var con = SQLfunctions.GetConnection())
				{
					using (var cmd = SQLfunctions.Command(con, cmdText: "IsActiveFalse", cmdType: CommandType.StoredProcedure))
					{
						cmd.Parameters.AddWithValue("@computerId", model.ComputerID);

						int rowaffected = cmd.ExecuteNonQuery();
						return rowaffected;
					}
				}
			}
			catch (Exception e)
			{
				return -1;
			}
		}
		public int ADD(Computer model)
		{
			try
			{

				using (var con = SQLfunctions.GetConnection())
				{
					using (var cmd = SQLfunctions.Command(con,cmdText: "Add_Computers",cmdType:CommandType.StoredProcedure))
					{

						cmd.Parameters.AddWithValue("@partid", model.PartID);
						cmd.Parameters.AddWithValue("@priceperhour", model.PricePerHour);
						cmd.Parameters.AddWithValue("@insertby", model.Insertby);
						cmd.Parameters.AddWithValue("@insertdate", model.InserDate);

						int rowaffected = cmd.ExecuteNonQuery();
						return rowaffected;

					}

				}

			}
			catch (Exception e)
			{
				return -1;

			}


		}

		public int Modify(Computer model)
		{
			try
			{
				using (var con = SQLfunctions.GetConnection())
				{
					using (var cmd = SQLfunctions.Command(con, cmdText: "Computers_Update", cmdType: CommandType.StoredProcedure))
					{
						cmd.Parameters.AddWithValue("@computerid", model.ComputerID);
						cmd.Parameters.AddWithValue("@partid", model.PartID);
						cmd.Parameters.AddWithValue("@priceperhour", model.PricePerHour);
						cmd.Parameters.AddWithValue("@updateby", model.UpdatedBy);
						cmd.Parameters.AddWithValue("@updatedate", model.UpdateDate);
						cmd.Parameters.AddWithValue("@updateno", model.LastUpdate);

						int rowaffected = cmd.ExecuteNonQuery();
						return rowaffected;
					}
				}
			}
			catch (Exception e)
			{
				return -1;
			}
			
		}

		public int Remove(int ID)
		{
			try
			{
				using (var con = SQLfunctions.GetConnection())
				{
					using (var cmd = SQLfunctions.Command(con,cmdText: "Computers_Delete",cmdType:CommandType.StoredProcedure))
					{
						cmd.Parameters.AddWithValue("@computerid", ID);
						int rowaffected = cmd.ExecuteNonQuery();
						return rowaffected;
					}
				}
			}
			catch (Exception e)
			{
				return -1;
			}
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
							   Computer computer = ToObject(reader);
								computers.Add(computer);
								
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

		public Computer ToObject(SqlDataReader reader)
		{
			Computer computer = new Computer();
			//ComputerParts computerParts = new ComputerParts();

			computer.PartID = int.Parse(reader["PartID"].ToString());
			computer.ComputerID = int.Parse(reader["ComputerID"].ToString());
			if(reader["PricePerHour"]!=DBNull.Value)
			 computer.PricePerHour = double.Parse(reader["PricePerHour"].ToString());
			computer.IsActive = (bool)reader["IsActive"];

			return computer;

		}
	}
}
