using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game_center_management.BO;
using Game_center_management.BO.Interfaces;
using Game_center_management;
using game_center_management.DAL;

namespace game_center_management.BLL
{
	
	public class ComputersBLL:IbaseCrud<Computer>
	{
		private readonly ComputersDAL computersDAL;

		public ComputersBLL()
		{
			computersDAL = new ComputersDAL();
		}
		public int ADD(Computer model)
		{
			throw new NotImplementedException();
		}

		public int Modify(Computer model)
		{
			throw new NotImplementedException();
		}

		public int Remove(int ID)
		{
			throw new NotImplementedException();
		}

		public List<Computer> GetAll()
		{
			return computersDAL.GetAll();

		}
	}
}
