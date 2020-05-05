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
	public class ProductBLL: IbaseCrud<Product>
	{

		private readonly ProductsDal productsDal;

		public ProductBLL()
		{
			productsDal = new ProductsDal();
		}
		public int ADD(Product model)
		{

			try
			{
			 return	productsDal.ADD(model);
			}
			catch (Exception e)
			{
				return -1;
			}

		}

		public int Modify(Product model)
		{
			throw new NotImplementedException();
		}

		public int Remove(int ID)
		{
			return productsDal.Remove(ID);
		}

		public List<Product> GetAll()
		{
			 return productsDal.GetAll();
		}
	}
}
