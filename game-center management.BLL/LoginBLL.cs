using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game_center_management.BO;
using game_center_management.DAL;

namespace game_center_management.BLL
{
	public class LoginBLL
	{
		private readonly EmployessDAL employessDAL;
		public LoginBLL()
		{
			employessDAL = new EmployessDAL();
		}

		public Employess Login(string username, string password)
		{

			return employessDAL.Login(username, password);	
		}

	}
}
