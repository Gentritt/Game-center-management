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
   
    public class OrderBLL : IbaseCrud<Orders>
    {
        private readonly OrderDAL orderDAL;

        public OrderBLL()
        {
            orderDAL = new OrderDAL();
        }

        public int ADD(Orders model)
        {
            return orderDAL.ADD(model);
        }

        public Orders GetByName(int name)
        {
            return orderDAL.GetByName(name);
        }
        public List<Orders> GetAll()
        {
            return orderDAL.GetAll();
        }

        public int Modify(Orders model)
        {
            throw new NotImplementedException();
        }

        public int Remove(int ID)
        {
            throw new NotImplementedException();
        }
    }
}
