using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using Game_center_maagement.BO;
using Game_center_management.BO;
using Game_center_management.BO.Interfaces;

namespace game_center_management.DAL
{
    public class BillsDAL : IbaseCrud<Bill>, IConvertToObject<Bill>
    {
        public int ADD(Bill model)
        {
            try
            {
                using (var con = SQLfunctions.GetConnection())
                {
                    //AddBill procedure and BillAdd with endTime
                    using (var cmd = SQLfunctions.Command(con, cmdText: "AddBill", CommandType.StoredProcedure))
                    {
                        cmd.Parameters.AddWithValue("@employee", model.EmployeeUsername);
                        cmd.Parameters.AddWithValue("@computerID", model.ComputerId);
                        cmd.Parameters.AddWithValue("@client", model.ClientUsername);
                        cmd.Parameters.AddWithValue("@startTime", model.StartTime);

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

        public List<Bill> GetAll()
        {
            try
            {
                List<Bill> billResult = null;
                using (var conn = SQLfunctions.GetConnection())
                {
                    using (var cmd = SQLfunctions.Command(conn, cmdText: "GETALL_Bill", CommandType.StoredProcedure))
                    {
                       
                        billResult = new List<Bill>();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Bill bill = ToObject(reader);
                                billResult.Add(bill);
                            }
                        }
                    }
                    return billResult;
                }
            }
            catch (Exception e)
            {
                return null;
            }
        }
        public List<Bill> Get(int id)
        {
            List<Bill> billr = null;
            try
            {
                using (var conn = SQLfunctions.GetConnection())
                {
                    using (var cmd = SQLfunctions.Command(conn, cmdText: "GetBill", CommandType.StoredProcedure))
                    {
                        cmd.Parameters.AddWithValue("@computerID", id);
                       
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            billr = new List<Bill>();
                            while (reader.Read())
                            {
                                Bill bill = ToObject(reader);
                                billr.Add(bill);
                            }
                        }
                    }
                }
                return billr;
            }
            catch (Exception e)
            {
                return null;
            }
              
        }
        public int GetEndTime(Bill model)
        {
            try
            {
                using (var conn = SQLfunctions.GetConnection())
                {
                    using (var cmd = SQLfunctions.Command(conn, cmdText: "EndTime_ADD", CommandType.StoredProcedure))
                    {
                        cmd.Parameters.AddWithValue("@billID", model.BillID);
                        cmd.Parameters.AddWithValue("@endTime", model.EndTime);

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
        public int GetTotalOrders(int billID)
        {
            try
            {
                using(var conn = SQLfunctions.GetConnection())
                {
                    using(var cmd = SQLfunctions.Command(conn, cmdText: "GetTotalPriceOrders", CommandType.StoredProcedure))
                    {
                        cmd.Parameters.AddWithValue("@billID", billID);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                if (reader.Read())
                                {
                                    StaticClass.TotalPrice = double.Parse(reader["shuma"].ToString());
                                }
                            }
                        }
                        int rowaffected = cmd.ExecuteNonQuery();

                        return rowaffected;
                    }
                }
            }
            catch (Exception e)
            {
                return - 1;
            }
        }
        public int GetTotal(Bill model)
        {
            try
            {
                using (var conn = SQLfunctions.GetConnection())
                {
                    using (var cmd = SQLfunctions.Command(conn, cmdText: "Total_ADD", CommandType.StoredProcedure))
                    {
                        cmd.Parameters.AddWithValue("@billID", model.BillID);
                        cmd.Parameters.AddWithValue("@total", model.Total);

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
        
        public int Modify(Bill model)
        {
            throw new NotImplementedException();
        }

        public int Remove(int ID)
        {
            throw new NotImplementedException();
        }

        public Bill ToObject(SqlDataReader reader)
        {
            Bill bill = new Bill();
            bill.BillID = int.Parse(reader["BillID"].ToString());
            bill.EmployeeUsername = reader["Employee"].ToString();
            bill.ComputerId = int.Parse(reader["ComputerID"].ToString());
            bill.ClientUsername = reader["Client"].ToString();
            bill.StartTime = DateTime.Parse(reader["StartTime"].ToString());
            if (reader["EndTime"] != DBNull.Value)
                bill.EndTime = DateTime.Parse(reader["EndTime"].ToString());
            if (reader["Total"] != DBNull.Value)
                bill.Total = double.Parse(reader["Total"].ToString());

            return bill;

        }
    }
}
