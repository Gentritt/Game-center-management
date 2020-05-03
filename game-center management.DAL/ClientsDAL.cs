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
				SqlCommand cmd = new SqlCommand("Clients_Insert", con);
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.AddWithValue("@name", model.Name);
				cmd.Parameters.AddWithValue("@lastname", model.LastName);
				cmd.Parameters.AddWithValue("@personalid", model.PersonalID);
				cmd.Parameters.AddWithValue("@address", model.Address);
				cmd.Parameters.AddWithValue("@birthday", model.Birthday);
				cmd.Parameters.AddWithValue("@email", model.Email);
				cmd.Parameters.AddWithValue("@username",model.UserName);
				cmd.Parameters.AddWithValue("@password", model.Password);
				cmd.Parameters.AddWithValue("@balance", model.Balance);
				cmd.Parameters.AddWithValue("@phonenumber", model.PhoneNumber);
				cmd.Parameters.AddWithValue("@insertby", model.Insertby);
				cmd.Parameters.AddWithValue("@insertdate", model.InserDate);

				//cmd.Parameters.AddWithValue("@isactive", model.IsActive);
				//cmd.Parameters.AddWithValue("@isguest", model.IsGuest);

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
					using (var cmd = SQLfunctions.Command(con,cmdText: "Clients_GetALL", CommandType.StoredProcedure))
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

			clients.ID = int.Parse(reader["ClientID"].ToString());
			clients.Name = reader["Name"].ToString();
			clients.LastName = reader["LastName"].ToString();
			clients.Address = reader["Adress"].ToString();
			clients.Birthday = (DateTime) reader["Birthday"];
			clients.PhoneNumber = reader["PhoneNumber"].ToString();
			clients.UserName = reader["UserName"].ToString();
			clients.Balance = decimal.Parse(reader["Balance"].ToString());
			//clients.IsGuest = (bool) reader["IsGuest"];
			clients.Insertby = reader["InsertBy"].ToString();
			clients.InserDate = DateTime.Parse(reader["InsertDate"].ToString());
			clients.IsActive = (bool) reader["IsActive"];
			clients.Email = reader["Email"].ToString();
			clients.PersonalID = reader["PersonalID"].ToString();
			

			return clients;

		}
	}
}