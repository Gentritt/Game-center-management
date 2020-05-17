using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using Game_center_management.BO;
using Game_center_management.BO.Interfaces;

namespace game_center_management.DAL
{
	public class ComputerPartsDAL : IbaseCrud<ComputerParts>, IConvertToObject<ComputerParts>
	{
		public int ADD(ComputerParts model)
		{
			try
			{
				using (var con = SQLfunctions.GetConnection())
				{
					using (var cmd = SQLfunctions.Command(con,cmdText: "ADD_ComputerParts", CommandType.StoredProcedure))
					{
						cmd.Parameters.AddWithValue("@case", model.ComputerCase);
						cmd.Parameters.AddWithValue("@mouse", model.ComputerMouse);
						cmd.Parameters.AddWithValue("@keyboard", model.ComputerKeyboard);
						cmd.Parameters.AddWithValue("@headsets", model.ComputerHeadSet);
						cmd.Parameters.AddWithValue("@monitor", model.ComputerMonitor);
						cmd.Parameters.AddWithValue("@mousepad", model.ComputerMousePad);
						cmd.Parameters.AddWithValue("@processor", model.ComputerCPU);
						cmd.Parameters.AddWithValue("@graphiccard", model.ComputerGraphicCard);
						cmd.Parameters.AddWithValue("@motherboard", model.ComputerMotherboard);
						cmd.Parameters.AddWithValue("@ram", model.ComputerRAM);
						cmd.Parameters.AddWithValue("@ssd", model.ComputerSSD);
						cmd.Parameters.AddWithValue("@hdd", model.ComputerHDD);
						cmd.Parameters.AddWithValue("@psu", model.ComputerPSU);
						cmd.Parameters.AddWithValue("@cooler", model.ComputerCooler);
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

		public int Modify(ComputerParts model)
		{
			throw new NotImplementedException();
		}

		public int Remove(int ID)
		{
			try
			{
				using (var con = SQLfunctions.GetConnection())
				{
					using (var cmd = SQLfunctions.Command(con,cmdText: "Delete_ComputerPartsByID",CommandType.StoredProcedure))
					{

						cmd.Parameters.AddWithValue("@partid", ID);
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


		public List<ComputerParts> GetAll()
		{

			try
			{
				List<ComputerParts> ComputerPartsResult = null;
				using (var conn = SQLfunctions.GetConnection())
				{
					using (var cmd = SQLfunctions.Command(conn, cmdText: "GetALL_ComputerParts", CommandType.StoredProcedure))
					{
						ComputerPartsResult = new List<ComputerParts>();
						using (SqlDataReader reader = cmd.ExecuteReader())
						{
							while (reader.Read())
							{
							    ComputerParts computerParts = ToObject(reader);
								ComputerPartsResult.Add(computerParts);


							}

						}



					}


				}

				return ComputerPartsResult;



			}
			catch (Exception e)
			{
				return null;


			}


		}

		public ComputerParts ToObject(SqlDataReader reader)
		{
			ComputerParts computerParts = new ComputerParts();

			computerParts.PartID = int.Parse(reader["PartID"].ToString());
			computerParts.ComputerCPU = reader["Processor"].ToString();
			computerParts.ComputerCase = reader["Case"].ToString();
			computerParts.ComputerCooler = reader["Cooler"].ToString();
			computerParts.ComputerGraphicCard = reader["GraphicCard"].ToString();
			computerParts.ComputerHDD = reader["HDD"].ToString();
			computerParts.ComputerHeadSet = reader["HeadSets"].ToString();
			computerParts.ComputerKeyboard = reader["Keyboard"].ToString();
			computerParts.ComputerMonitor = reader["Monitor"].ToString();
			computerParts.ComputerMotherboard = reader["MotherBoard"].ToString();
			computerParts.ComputerMouse = reader["Mouse"].ToString();
			computerParts.ComputerMousePad = reader["MousePad"].ToString();
			computerParts.ComputerPSU = reader["PCU"].ToString();
			computerParts.ComputerRAM = reader["RAM"].ToString();
			computerParts.ComputerSSD = reader["SSD"].ToString();
			//computerParts.Insertby = reader["InsertBy"].ToString();
			//computerParts.InserDate = (DateTime) reader["InsertDate"];

			return computerParts;


		}
	}
}
