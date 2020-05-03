using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game_center_management.BO;
using Game_center_management.BO.Interfaces;

namespace game_center_management.DAL
{
	public class ProductsDal : IbaseCrud<Product>, IConvertToObject<Product>
	{
		public int ADD(Product model)
		{
			try
			{
				using (var con = SQLfunctions.GetConnection())
				{
					using (var cmd = SQLfunctions.Command(con,cmdText: "Products_ADD", CommandType.StoredProcedure))
					{
						cmd.Parameters.AddWithValue("@productname", model.ProductName);
						cmd.Parameters.AddWithValue("@productprice", model.Price);
						cmd.Parameters.AddWithValue("@quantity", model.Quantity);
						cmd.Parameters.AddWithValue("@insertby", model.Insertby);
						cmd.Parameters.AddWithValue("@insertdate", model.InserDate);

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

		public int Modify(Product model)
		{
			throw new NotImplementedException();
		}

		public int Remove(int ID)
		{
			throw new NotImplementedException();
		}

		public int Remove(Product model)
		{
			throw new NotImplementedException();
		}

		public Product get(int ID)
		{
			throw new NotImplementedException();
		}

		public Product get(Product model)
		{
			throw new NotImplementedException();
		}

		public List<Product> GetAll()
		{
			try
			{
				List<Product> ProductResult = null;
				using (var conn = SQLfunctions.GetConnection())
				{
					using (var cmd =
						SQLfunctions.Command(conn, cmdText: "Products_getALL", CommandType.StoredProcedure))
					{
						ProductResult = new List<Product>();
						using (SqlDataReader reader = cmd.ExecuteReader())
						{
							while (reader.Read())
							{
								Product product = ToObject(reader);
								ProductResult.Add(product);


							}

						}



					}


				}

				return ProductResult;
			}
			catch(Exception e )
			{
				return null;


			}
		}

		public Product ToObject(SqlDataReader reader)
		{
			Product product = new Product();
			product.ProductName = reader["ProductName"].ToString();
			product.ProductID = int.Parse(reader["ProductID"].ToString());
			product.Price = decimal.Parse(reader["ProductPrice"].ToString());
			product.Quantity = int.Parse(reader["ProductQuantity"].ToString());
			product.Insertby = reader["InsertBy"].ToString();
			product.InserDate = (DateTime) reader["InsertDate"];

			return product;

		}
	}
}


