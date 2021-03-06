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
using System.Windows;
using System.Windows.Forms;


namespace game_center_management.DAL
{

	public class EmployessDAL: IbaseCrud<Employess>,IConvertToObject<Employess>
	{
		//public string _connString = ConfigurationManager.ConnectionStrings["Game-Center"].ConnectionString;

		public int ADD(Employess model)
		{
				try
				{

					using (var conn = SQLfunctions.GetConnection())
					{
						using (var command = SQLfunctions.Command(conn, cmdText: "UserName_Check",
							cmdType: CommandType.StoredProcedure))
						{
							command.Parameters.AddWithValue("@username", model.Username);

							var result = command.ExecuteScalar();
							result = (result == DBNull.Value) ? null : result;
							int res = Convert.ToInt32(result);
							if (result != null)
							{
								//return -1;
								MessageBox.Show($"This UserName Exits:  {model.Username}");

							}

							else
							{
								using (var con = SQLfunctions.GetConnection())
								{
									using (var cmd =
										SQLfunctions.Command(con, cmdText: "Add_Employess",
											CommandType.StoredProcedure))
									{
										cmd.Parameters.AddWithValue("@name", model.Name);
										cmd.Parameters.AddWithValue("@personalid", model.PersonalID);
										cmd.Parameters.AddWithValue("@lastname", model.LastName);
										cmd.Parameters.AddWithValue("@birthday", model.Birthday);
										cmd.Parameters.AddWithValue("@email", model.Email);
										cmd.Parameters.AddWithValue("@phonenumber", model.PhoneNumber);
										cmd.Parameters.AddWithValue("@username", model.Username);
										cmd.Parameters.AddWithValue("@password", model.Password);
										cmd.Parameters.AddWithValue("@salary", model.Salary);
										cmd.Parameters.AddWithValue("@insertBy", model.Insertby);
										cmd.Parameters.AddWithValue("@insertDate", model.InserDate);
										cmd.Parameters.AddWithValue("@address", model.Adress);

										int RowAffected = cmd.ExecuteNonQuery();
										return RowAffected;
									}
								}

								
							}

							return res;
						}


					}

				}

				catch (Exception e)
				{
					return -1;
				}
		}
		

		public int Modify(Employess model)
		{
			try
			{
				using (var con = SQLfunctions.GetConnection())
				{
					using (var cmd = SQLfunctions.Command(con,cmdText: "Employess_Edit",cmdType:CommandType.StoredProcedure))
					{
						cmd.Parameters.AddWithValue("@employeeid", model.ID);
						cmd.Parameters.AddWithValue("@name", model.Name);
						cmd.Parameters.AddWithValue("@lastname", model.LastName);
						cmd.Parameters.AddWithValue("@personalid", model.PersonalID);
						cmd.Parameters.AddWithValue("@address", model.Adress);
						cmd.Parameters.AddWithValue("@birthday", model.Birthday);
						cmd.Parameters.AddWithValue("@email", model.Email);
						cmd.Parameters.AddWithValue("@phonenumber", model.PhoneNumber);
						cmd.Parameters.AddWithValue("@username", model.Username);
						cmd.Parameters.AddWithValue("@password", model.Password);
						cmd.Parameters.AddWithValue("@salary", model.Salary);
						cmd.Parameters.AddWithValue("@updateby", model.UpdatedBy);
						cmd.Parameters.AddWithValue("@updatedate", model.UpdateDate);
						cmd.Parameters.AddWithValue("@updateno", model.LastUpdate);

						var rowaffectd = cmd.ExecuteNonQuery();
						return rowaffectd;

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
					using (var cmd = SQLfunctions.Command(con,cmdText: "Delete_EmployeeByID",CommandType.StoredProcedure))
					{
						cmd.Parameters.AddWithValue("employeeid", ID);
						int rowaffected = cmd.ExecuteNonQuery();
						return rowaffected;

					}

				}



			}
			catch (Exception )
			{
				return -1;

			}

		}


		public List<Employess> GetAll()
		{

			try
			{
				List<Employess> EmployessResult = null;
				using (var conn = SQLfunctions.GetConnection())
				{
					using (var cmd = SQLfunctions.Command(conn,cmdText: "Employess_GetALL" ,CommandType.StoredProcedure))
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

				using (var cmd = SQLfunctions.Command(con,cmdText: "LoginEmployee",CommandType.StoredProcedure))
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

			employess.ID = int.Parse(reader["EmployeeID"].ToString());
			employess.Username = reader["UserName"].ToString();
			employess.Name = reader["Name"].ToString();
			employess.LastName = reader["LastName"].ToString();
			employess.Email = reader["Email"].ToString();
			employess.Password = reader["Password"].ToString();
			employess.Adress = reader["Adress"].ToString();
			employess.Birthday = DateTime.Parse(reader["Birthday"].ToString());
			if( reader["Salary"]!= DBNull.Value)
				employess.Salary=double.Parse(reader["Salary"].ToString());
			//employess.Insertby = reader["InsertBy"].ToString();
			//employess.InserDate = DateTime.Parse(reader["InsertDate"].ToString());
			employess.IsActive = (bool)reader["IsActive"];
			employess.PersonalID = reader["PersonalID"].ToString();
			employess.PhoneNumber = reader["PhoneNumber"].ToString();
			


			return employess;

		}
	}
}
