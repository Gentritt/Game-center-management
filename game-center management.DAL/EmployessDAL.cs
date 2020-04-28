﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
using Game_center_management.BO;
using Game_center_management.BO.Interfaces;


namespace game_center_management.DAL
{

	public class EmployessDAL: IbaseCrud<Employess>,IConvertToObject<Employess>
	{
		public string _connString = ConfigurationManager.ConnectionStrings["Game-Center"].ConnectionString;


		public int ADD(Employess model)
		{
			try
			{
				SqlConnection conn = new SqlConnection(_connString);
				conn.Open();
				SqlCommand cmd = new SqlCommand("InsertimiPuntorit",conn);
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.AddWithValue("@emri", model.Name);
				cmd.Parameters.AddWithValue("@numriPersonal", model.PersonalID);
				cmd.Parameters.AddWithValue("@mbiemri", model.LastName);
				cmd.Parameters.AddWithValue("@dataLindjes", model.Birthday);
				cmd.Parameters.AddWithValue("@email", model.Email);
				cmd.Parameters.AddWithValue("@numriTelefonit", model.PhoneNumber);
				cmd.Parameters.AddWithValue("@userName", model.Username);
				cmd.Parameters.AddWithValue("@userPass", model.Password);
				cmd.Parameters.AddWithValue("@rroga", model.Salary);
				//cmd.Parameters.AddWithValue("@isActive", model.IsActive);
				int rowaffected = cmd.ExecuteNonQuery();
				cmd .Dispose();
				conn.Close();
				conn.Dispose();
				return rowaffected;
			}
			catch (Exception e)
			{
				return -1;

			}
		}

		public int Modify(Employess model)
		{
			throw new NotImplementedException();
		}

		public int Remove(int ID)
		{
			throw new NotImplementedException();
		}

		public int Remove(Employess model)
		{
			throw new NotImplementedException();
		}

		public Employess get(int ID)
		{
			throw new NotImplementedException();
		}

		public Employess get(Employess model)
		{
			throw new NotImplementedException();
		}

		public List<Employess> GetAll()
		{

			try
			{
				List<Employess> EmployessResult = null;
				using (var conn = SQLfunctions.GetConnection())
				{
					using (var cmd = SQLfunctions.Command(conn,cmdText: "Employes_GetALL" ,CommandType.StoredProcedure))
					{
						EmployessResult = new List<Employess>();
						using (SqlDataReader reader = cmd.ExecuteReader())
						{
							while (reader.Read())
							{
								Employess employess = ToObject(reader);
								EmployessResult.Add(employess);


							}

						}

						

					}
					

				}

				return EmployessResult;



			}
			catch (Exception e)
			{
				return null;


			}
			
		}

		public Employess Login(string username, string password)
		{
			Employess employess = null;
			using (var con = SQLfunctions.GetConnection())
			{

				using (var cmd = SQLfunctions.Command(con,cmdText: "usp_LoginPuntori",CommandType.StoredProcedure))
				{

					cmd.Parameters.AddWithValue("username", username);
					cmd.Parameters.AddWithValue("password", password);

					using (var reader = cmd.ExecuteReader())
					{
						if (reader.Read())
						{
							employess = ToObject(reader);

						}
						
					}
				}

				
					
			}

			return employess;

		}
		public Employess ToObject(SqlDataReader reader)
		{
			Employess employess = new Employess();

			employess.ID = int.Parse(reader["ID"].ToString());
			employess.Username = reader["UserName"].ToString();
			employess.Name = reader["Emri"].ToString();
			employess.LastName = reader["Mbiemri"].ToString();
			employess.Email = reader["Email"].ToString();
			employess.Adress = reader["Adresa"].ToString();
			employess.Birthday = DateTime.Parse(reader["DataLindjes"].ToString());
			employess.Salary = Double.Parse(reader["Rroga"].ToString());
			employess.Insertby = reader["InsertBy"].ToString();
			employess.InserDate = DateTime.Parse(reader["InsertDate"].ToString());
			employess.IsActive = (bool)reader["IsActive"];


			return employess;

		}
	}
}
