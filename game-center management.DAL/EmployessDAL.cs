using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
using Game_center_maagement.BO;
using Game_center_maagement.BO.Interfaces;


namespace game_center_management.DAL
{

	public class EmployessDAL: IbaseCrud<Employess>
	{
		public string _connString = ConfigurationManager.ConnectionStrings["Game Center"].ConnectionString;


		public int ADD(Employess model)
		{
			try
			{
				SqlConnection conn = new SqlConnection(_connString);
				conn.Open();
				SqlCommand cmd = new SqlCommand("Shto",conn);
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.AddWithValue("Emri", model.Name);
				cmd.Parameters.AddWithValue("NumriPersonal", model.PersonalID);
				cmd.Parameters.AddWithValue("Mbiemri", model.LastName);
				cmd.Parameters.AddWithValue("DataeLindjes", model.Birthday);
				cmd.Parameters.AddWithValue("Email", model.Email);
				cmd.Parameters.AddWithValue("NumriTelefonit", model.PhoneNumber);
				cmd.Parameters.AddWithValue("UserName", model.Username);
				cmd.Parameters.AddWithValue("UserPassword", model.Password);
				int rowaffected = cmd.ExecuteNonQuery();
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
			throw new NotImplementedException();
		}
	}
}
