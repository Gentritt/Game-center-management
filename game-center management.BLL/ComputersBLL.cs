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

		public int IsActive(Computer model)
        {
			return computersDAL.IsActive(model);
        }
		public int IsActiveFalse(Computer model)
		{
			return computersDAL.IsActiveFalse(model);
		}
		public ComputersBLL()
		{
			computersDAL = new ComputersDAL();
		}
		public int ADD(Computer model)
		{
			return computersDAL.ADD(model);
		}

		public int Modify(Computer model)
		{
			return computersDAL.Modify(model);
		}

		public int Remove(int ID)
		{
			return computersDAL.Remove(ID);
		}

		public List<Computer> GetAll()
		{
			return computersDAL.GetAll();

		}
	}
}
