﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;

namespace game_center_management.DAL
{
	public class SqlHelper
	{
		//private static string _Conn

		public static SqlConnection GetConnection()
		{

			try
			{

				SqlConnection conn = new SqlConnection();
				//conn.Open();
				return conn;

			}
			catch (Exception e)
			{

				Console.WriteLine(e);
				throw;
			}

		}

		public SqlCommand Command(SqlConnection conn,string cmdText,CommandType cmdType = CommandType.StoredProcedure)
		{
			SqlCommand command = new SqlCommand(cmdText,conn);
			command.CommandType = CommandType.StoredProcedure;
			return command;


		}


	}
}
