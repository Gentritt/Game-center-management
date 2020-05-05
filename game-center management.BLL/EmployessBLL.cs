using System;
using System.Collections.Generic;
using Game_center_management.BO;
using Game_center_management.BO.Interfaces;
using game_center_management.DAL;

namespace game_center_management.BLL
{
	public class EmployessBLL : IbaseCrud<Employess>
	{
		private readonly EmployessDAL empDal;

		public EmployessBLL()
		{
			empDal = new EmployessDAL();
			
		}

		public int ADD(Employess model)
		{
			try
			{
				return empDal.ADD(model);
			}
			catch (Exception e)
			{
				return -1;
			}
		}

		public int Modify(Employess model)
		{
			throw new System.NotImplementedException();
		}

		public int Remove(int ID)
		{
			return empDal.Remove(ID);
		}

		public int Remove(Employess model)
		{
			throw new System.NotImplementedException();
		}

		public Employess get(int ID)
		{
			throw new System.NotImplementedException();
		}

		public Employess get(Employess model)
		{
			throw new System.NotImplementedException();
		}

		public List<Employess> GetAll()
		{
			return empDal.GetAll();
		}
	}
}