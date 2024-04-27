using DellLibrary.BL;
using DellLibrary.DL_Interfaces;
using DellLibrary.Utility;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Input;

namespace DellLibrary.DL.DB
{
    public class OrderDetailsDLDB : IOrderDetailsDL
    {
        private static IProductDL ProductDL = new ProductDLDB();

        public List<OrderDetailsBL> GetOrderDetailsForOrder(int id)
        {
            List<OrderDetailsBL> orderDetails = new List<OrderDetailsBL>();
            string query = "SELECT ProductID, Quantity, Price FROM OrderDetails WHERE OrderID = @id";

            using (SqlConnection con = Configuration.GetConnection())
            {
                try
                {
                    con.Open();
                    SqlCommand command = new SqlCommand(query, con);
                    command.Parameters.AddWithValue("@id", id);
                    SqlDataReader sqlDataReader = command.ExecuteReader();

                    while (sqlDataReader.Read())
                    {
                        int productID = sqlDataReader.GetInt32(0);
                        int quantity = sqlDataReader.GetInt32(1);
                        double price = sqlDataReader.GetDouble(2);

                        ProductBL product = ProductDL.GetProductByProductID(productID);
                        if (product != null)
                        {
                            OrderDetailsBL orderDetail = new OrderDetailsBL(product, quantity, price);
                            orderDetails.Add(orderDetail);
                        }
                    }
                }
                catch (Exception e)
                {
                    throw e;
                }
                finally
                {
                    con.Close();
                }
            }

            return orderDetails;
        }
        public void AddOrderDetails(OrderBL order)
        {
            foreach (OrderDetailsBL od in order.GetOrderDetails())
            {
                string query = "Insert into OrderDetails(OrderID,ProductID, Quantity, Price) Values(@oid,@pid,@qt,@p)";

                using (SqlConnection con = Configuration.GetConnection())
                {
                    try
                    {
                        con.Open();
                        SqlCommand command = new SqlCommand(query, con);
                        command.Parameters.AddWithValue("@oid", order.GetOrderID());
                        command.Parameters.AddWithValue("@pid", od.GetProduct().GetProductID());
                        command.Parameters.AddWithValue("@qt", od.GetQuantity());
                        command.Parameters.AddWithValue("@p", od.GetPrice());
                        SqlDataReader sqlDataReader = command.ExecuteReader();
                    }
                    catch (Exception e)
                    {
                        throw e;
                    }
                    finally
                    {
                        con.Close();
                        IProductDL productDetails = new ProductDLDB();
                        productDetails.UpdateProductStock(od.GetProduct(),od.GetQuantity());
                    }
                }
            }
        }
    }
}
