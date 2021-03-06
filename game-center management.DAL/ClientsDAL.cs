﻿using System;
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

		public int Balance(Clients model)
        {
			try
			{
				using (var con = SQLfunctions.GetConnection())
				{
					using (var cmd = SQLfunctions.Command(con, cmdText: "Balance", cmdType: CommandType.StoredProcedure))
					{
						cmd.Parameters.AddWithValue("@username", model.UserName);
						cmd.Parameters.AddWithValue("@price", model.Price);
						
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

		public int ADD(Clients model)
		{
			try
			{
				using (var con = SQLfunctions.GetConnection())
				{

					using (var cmd = SQLfunctions.Command(con,cmdText: "Clients_Insert", cmdType:CommandType.StoredProcedure))
					{
						cmd.Parameters.AddWithValue("@name", model.Name);
						cmd.Parameters.AddWithValue("@lastname", model.LastName);
						cmd.Parameters.AddWithValue("@personalid", model.PersonalID);
						cmd.Parameters.AddWithValue("@address", model.Address);
						cmd.Parameters.AddWithValue("@birthday", model.Birthday);
						cmd.Parameters.AddWithValue("@email", model.Email);
						cmd.Parameters.AddWithValue("@username", model.UserName);
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

				}
		
				
			
			



			}
			catch (Exception e)
			{
				return -1;


			}
		}

		public int Modify(Clients model)
		{
			try
			{
				using (var con = SQLfunctions.GetConnection())
				{
					using (var cmd = SQLfunctions.Command(con,cmdText: "Clients_Edit",cmdType:CommandType.StoredProcedure))
					{
						cmd.Parameters.AddWithValue("@clientid", model.ID);
						cmd.Parameters.AddWithValue("@name", model.Name);
						cmd.Parameters.AddWithValue("@lastname", model.LastName);
						cmd.Parameters.AddWithValue("@personalid", model.PersonalID);
						cmd.Parameters.AddWithValue("@address", model.Address);
						cmd.Parameters.AddWithValue("@birthday", model.Birthday);
						cmd.Parameters.AddWithValue("@email", model.Email);
						cmd.Parameters.AddWithValue("@phonenumber", model.PhoneNumber);
						cmd.Parameters.AddWithValue("@username", model.UserName);
						cmd.Parameters.AddWithValue("@password", model.Password);
						cmd.Parameters.AddWithValue("@balance", model.Balance);
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
					using (var cmd = SQLfunctions.Command(con,cmdText: "Delete_ClientsByID",CommandType.StoredProcedure))
					{
						cmd.Parameters.AddWithValue("@clientid", ID);
						int rowaffected = cmd.ExecuteNonQuery();
						return rowaffected;

					}

				}



			}
			catch (Exception e)
			{
				Console.WriteLine(e);
				throw;
			}
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
			clients.Password = reader["Password"].ToString();
			clients.Address = reader["Adress"].ToString();
			clients.Birthday = (DateTime) reader["Birthday"];
			clients.PhoneNumber = reader["PhoneNumber"].ToString();
			clients.UserName = reader["UserName"].ToString();
			if(reader["Balance"]!=DBNull.Value)
			clients.Balance = decimal.Parse(reader["Balance"].ToString());
			//clients.IsGuest = (bool) reader["IsGuest"];
			//clients.Insertby = reader["InsertBy"].ToString();
			//clients.InserDate = DateTime.Parse(reader["InsertDate"].ToString());
			clients.IsActive = (bool) reader["IsActive"];
			clients.Email = reader["Email"].ToString();
			clients.PersonalID = reader["PersonalID"].ToString();
			

			return clients;

		}
	}
}