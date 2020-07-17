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
    
    public class BillBLL : IbaseCrud<Bill>
    {
        private readonly BillsDAL billsDal;
        public BillBLL()
        {
            billsDal = new BillsDAL();
        }

        public int ADD(Bill model)
        {
            return billsDal.ADD(model);
        }
        public int GetTotal(Bill model)
        {
            return billsDal.GetTotal(model);
        }
        public List<Bill> GetAll()
        {
            return billsDal.GetAll();
        }
        public int GetTotalOrders(int billID)
        {
            return billsDal.GetTotalOrders(billID);
        }
        public List<Bill> Get(int id)
        {
            return billsDal.Get(id);
        }
        public int GetEndTime(Bill model)
        {
            return billsDal.GetEndTime(model);
        }
        public int Modify(Bill model)
        {
            throw new NotImplementedException();
        }

        public int Remove(int ID)
        {
            throw new NotImplementedException();
        }
    }
}
