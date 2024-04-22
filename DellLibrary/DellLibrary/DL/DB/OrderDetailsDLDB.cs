using DellLibrary.BL;
using DellLibrary.DL_Interfaces;
using DellLibrary.Utility;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DellLibrary.DL.DB
{
    public class OrderDetailsDLDB: IOrderDetailsDL
    {
        private static IProductDL ProductDL = new ProductDLDB();
        public List<OrderDetailsBL> GetOrderDetailsForOrder(int id)
        {
            List<OrderDetailsBL> orderDetails = new List<OrderDetailsBL>();
            string query = "SELECT ProductID,Quantity,Price from OrderDetails where OrderID=@id";
            using (SqlConnection con = Configuration.GetConnection())
            {
                try
                {
                    con.Open(); // Opens Database Connection
                    SqlCommand command = new SqlCommand(query, con); // Command to execute the query
                    command.Parameters.AddWithValue("@OrderID",id); // Add parameters
                    SqlDataReader sqlDataReader = command.ExecuteReader(); // Execute the query
                    while (sqlDataReader.Read()) // Loop through results
                    {
                        int productID = sqlDataReader.GetInt32(0);
                        int quantity = sqlDataReader.GetInt32(1);
                        double price = sqlDataReader.GetDouble(2);
                        ProductBL product = ProductDL.GetProductByProductID(productID); // Retrieve employee
                        OrderDetailsBL orderDetail = new OrderDetailsBL(product,quantity,price);
                        if (product!=null)
                        {
                            orderDetails.Add(orderDetail);
                        }
                    }
                }
                catch (Exception e) // throw exception
                {
                    throw (e);
                }
                finally
                {
                    con.Close(); // Closes the database connection at the end
                }
            }
            return orderDetails;
        }
    }
}
