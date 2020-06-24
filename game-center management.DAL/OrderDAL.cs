using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using Game_center_management.BO;
using Game_center_management.BO.Interfaces;

namespace game_center_management.DAL
{
    public class OrderDAL : IbaseCrud<Orders>, IConvertToObject<Orders>
    {
        public int ADD(Orders model)
        {
            try
            {
				using (var con = SQLfunctions.GetConnection())
                {
					using(var cmd = SQLfunctions.Command(con, cmdText:"OrderAdd", CommandType.StoredProcedure))
                    {
						cmd.Parameters.AddWithValue("@productId", model.ProductId);
						cmd.Parameters.AddWithValue("@billId", model.BillId);
						cmd.Parameters.AddWithValue("@quantity", model.Quantity);
						cmd.Parameters.AddWithValue("@price", model.Price);

						int rowaffected = cmd.ExecuteNonQuery();

						return rowaffected;
                    }
                }
            }
            catch (Exception e)
            {
				return -1;
            }
        }
		public Orders GetByName(int name)
		{
			Orders order = null;
			try
			{
				using (var con = SQLfunctions.GetConnection())
				{
					using (var cmd = SQLfunctions.Command(con, cmdText: "GetByIdOrder", cmdType: CommandType.StoredProcedure))
					{
						cmd.Parameters.AddWithValue("@id", name);

						using (SqlDataReader reader = cmd.ExecuteReader())
						{
							if (reader.HasRows)
							{
								order = new Orders();
								if (reader.Read())
								{
									order.ProductId = int.Parse(reader["ProductID"].ToString());
									order.Price = double.Parse(reader["ProductPrice"].ToString());
								}
							}
						}
					}
				}
				return order;
			}
			catch (Exception e)
			{
				return null;
			}
		}
		public List<Orders> GetAll()
        {
			try
			{
				List<Orders> orders = null;
				using (var conn = SQLfunctions.GetConnection())
				{
					using (var cmd =
						SQLfunctions.Command(conn, cmdText: "GetAll_Order", CommandType.StoredProcedure))
					{
						orders = new List<Orders>();
						using (SqlDataReader reader = cmd.ExecuteReader())
						{
							while (reader.Read())
							{
								Orders order = ToObject(reader);
								orders.Add(order);
							}
						}
					}
				}
				return orders;
			}
			catch (Exception e)
			{
				return null;
			}
		}

        public int Modify(Orders model)
        {
            throw new NotImplementedException();
        }

        public int Remove(int ID)
        {
            throw new NotImplementedException();
        }

        public Orders ToObject(SqlDataReader reader)
        {
			Orders order = new Orders();
			order.OrderID = int.Parse(reader["OrderID"].ToString());
			order.ProductId = int.Parse(reader["ProductID"].ToString());
			order.BillId = int.Parse(reader["BillID"].ToString());
			order.Quantity = int.Parse(reader["Quantity"].ToString());
			order.Price = double.Parse(reader["Price"].ToString());

			return order;
		}
    }
}
