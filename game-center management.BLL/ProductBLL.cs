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
			return	productsDal.ADD(model);

		}

		public int Modify(Product model)
		{
		   return productsDal.Modify(model);
		}

		public int Remove(int ID)
		{
			return productsDal.Remove(ID);
		}

		public  Product GetByID(int ID)
		{

			return productsDal.GetByID(ID);
		}
		public List<Product> GetAll()
		{
			 return productsDal.GetAll();
		}
	}
}
