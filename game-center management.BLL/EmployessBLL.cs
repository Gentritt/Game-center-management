using System.Collections.Generic;
using Game_center_management.BO.Interfaces;

namespace game_center_management.BLL
{
	public class EmployessBLL : IbaseCrud<EmployessBLL>
	{
		private EmployessBLL emp;

		public int ADD(EmployessBLL model)
		{
			return emp.ADD(model);
		}

		public int Modify(EmployessBLL model)
		{
			return emp.Modify(model);
		}

		public int Remove(int ID)
		{
			return emp.Remove(ID);
		}

		public int Remove(EmployessBLL model)
		{
			return emp.Remove(model);
		}

		public EmployessBLL get(int ID)
		{
			return emp.get(ID);
		}

		public EmployessBLL get(EmployessBLL model)
		{
			return emp.get(model);
		}

		public List<EmployessBLL> GetAll()
		{
			return emp.GetAll();
		}
	}
}