using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using Game_center_management.BO;
using Game_center_management.BO.Interfaces;

namespace game_center_management.DAL
{
	public class ClientsDAL: IbaseCrud<Clients>,IConvertToObject<Clients>
	{
		public string _connString = ConfigurationManager.ConnectionStrings["Game-Center"].ConnectionString;


		public int ADD(Clients model)
		{
			try
			{
				SqlConnection con = new SqlConnection(_connString);
				con.Open();
				SqlCommand cmd = new SqlCommand("InsertimiKlientit", con);
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.AddWithValue("@emri", model.Name);
				cmd.Parameters.AddWithValue("@mbiemri", model.LastName);
				cmd.Parameters.AddWithValue("numriPersonal", model.PersonalID);
				cmd.Parameters.AddWithValue("adresa", model.Address);
				cmd.Parameters.AddWithValue("dataLindjes", model.Birthday);
				cmd.Parameters.AddWithValue("email", model.Email);
				cmd.Parameters.AddWithValue("@userName",model.UserName);
				cmd.Parameters.AddWithValue("userPassword", model.Password);
				cmd.Parameters.AddWithValue("balanca", model.Balance);
				//cmd.Parameters.AddWithValue("isActive", model.IsActive);
				int rowaffect = cmd.ExecuteNonQuery();
				return rowaffect;



			}
			catch (Exception e)
			{
				return -1;


			}
		}

		public int Modify(Clients model)
		{
			throw new System.NotImplementedException();
		}

		public int Remove(int ID)
		{
			throw new System.NotImplementedException();
		}

		public int Remove(Clients model)
		{
			throw new System.NotImplementedException();
		}

		public Clients get(int ID)
		{
			throw new System.NotImplementedException();
		}

		public Clients get(Clients model)
		{
			throw new System.NotImplementedException();
		}

		public List<Clients> GetAll()
		{
			try
			{
				List<Clients> clientsResult = null;
				using (var con = SQLfunctions.GetConnection())
				{
					using (var cmd = SQLfunctions.Command(con,cmdText: "usp_GetAllClients", CommandType.StoredProcedure))
					{
						clientsResult = new List<Clients>();
						using (SqlDataReader reader = cmd.ExecuteReader())
						{
							while (reader.Read())
							{
								Clients clients = ToObject(reader);
								clientsResult.Add(clients);

							}


						}

					}

				}

				return clientsResult;



			}
			catch (Exception e)
			{
				return null;

			}
			

		}

		public Clients ToObject(SqlDataReader reader)
		{
			Clients clients = new Clients();

			clients.ID = int.Parse(reader["KonsumatoriID"].ToString());
			clients.Name = reader["Emri"].ToString();
			clients.LastName = reader["Mbiemri"].ToString();
			clients.Address = reader["Adresa"].ToString();
			clients.Birthday = (DateTime) reader["DataLindjes"];
			clients.PhoneNumber = int.Parse(reader["NumriTelefonit"].ToString());
			clients.UserName = reader["UserName"].ToString();
			clients.Balance = int.Parse(reader["Balanca"].ToString());
			clients.IsGuest = (bool) reader["IsGuest"];
			clients.Insertby = reader["InsertBy"].ToString();
			clients.InserDate = DateTime.Parse(reader["InsertDate"].ToString());
			clients.IsActive = (bool) reader["IsActive"];


			return clients;

		}
	}
}