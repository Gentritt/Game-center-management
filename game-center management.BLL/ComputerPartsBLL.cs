using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game_center_management.BO;
using Game_center_management.BO.Interfaces;
using game_center_management.DAL;

namespace game_center_management.BLL
{
	public class ComputerPartsBLL: IbaseCrud<ComputerParts>
	{
		private readonly ComputerPartsDAL _computersDal;

		public ComputerPartsBLL()
		{
			_computersDal = new ComputerPartsDAL();
		}
		public int ADD(ComputerParts model)
		{
			return _computersDal.ADD(model);

		}

		public int Modify(ComputerParts model)
		{
			throw new NotImplementedException();
		}

		public int Remove(int ID)
		{
			throw new NotImplementedException();
		}

		public int Remove(ComputerParts model)
		{
			throw new NotImplementedException();
		}

		public ComputerParts get(int ID)
		{
			throw new NotImplementedException();
		}

		public ComputerParts get(ComputerParts model)
		{
			throw new NotImplementedException();
		}

		public List<ComputerParts> GetAll()
		{
			return _computersDal.GetAll();
		}
	}
}
