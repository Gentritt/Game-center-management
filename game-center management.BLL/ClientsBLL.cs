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
	public class ClientsBLL: IbaseCrud<Clients>
	{
		private readonly ClientsDAL clientsDal;

		public ClientsBLL()
		{
				clientsDal = new ClientsDAL();
		}
		public int ADD(Clients model)
		{

			 return clientsDal.ADD(model);
		}

		public int Modify(Clients model)
		{
			throw new NotImplementedException();
		}

		public int Remove(int ID)
		{
			throw new NotImplementedException();
		}

		public int Remove(Clients model)
		{
			throw new NotImplementedException();
		}

		public Clients get(int ID)
		{
			throw new NotImplementedException();
		}

		public Clients get(Clients model)
		{
			throw new NotImplementedException();
		}

		public List<Clients> GetAll()
		{
			return clientsDal.GetAll();
		}
	}
}
