using DellLibrary.BL;
using DellLibrary.DL_Interfaces;
using DellLibrary.Utility;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DellLibrary.DL.DB
{
    public class OrderDLDB : IOrderDL
    {
        private readonly static IEmployeeDL employeeDL = new EmployeeDLDB();
        public List<OrderBL> GetOrdersForUser(string username)
        {
            List<OrderBL> orders = new List<OrderBL>();
            // makes connection with DB to get orders count
            using (SqlConnection con = Configuration.GetConnection())
            {
                string query = $"Select Count(O.OrderId) from Orders as O join Customers as C on O.CustomerID=C.Username where C.Username=@Username;";
                // first try to execute retreive command
                try
                {
                    con.Open(); // opens Database Connection
                    SqlCommand command = new SqlCommand(query, con); // command to execute the query
                    command.Parameters.AddWithValue("@Username", username); // add parameters
                    SqlDataReader sqlDataReader = command.ExecuteReader(); // Execute the query
                    if (sqlDataReader.Read()) // if orders data found
                    {
                        int orderId = sqlDataReader.GetInt32(0);
                        string orderType = sqlDataReader.GetString(3);
                        DateTime orderDate = sqlDataReader.GetDateTime(4);
                        string employeeUN = sqlDataReader.GetString(2);
                        EmployeeBL employee = employeeDL.GetEmployeebyUsername(username);
                        OrderBL order = new OrderBL(orderId, orderType, orderDate,employee);
                        orders.Add(order);

                    }
                }
                catch (Exception e) // if any exception returns the exception message
                {
                    throw (e);
                }
                finally // closes the database connection at the end
                {
                    con.Close();
                }
            }
            return orders;
        }
        public int GetOrderCount() // returns order count
        {
            int OrderCount = 0;
            // makes connection with DB to get orders count
            using (SqlConnection con = Configuration.GetConnection())
            {
                string query = $"Select Count(O.OrderId) from Orders as O join Customers as C on O.CustomerID=C.Username where C.Status='Active';";
                // first try to execute retreive command
                try
                {
                    con.Open(); // opens Database Connection
                    SqlCommand command = new SqlCommand(query, con); // command to execute the query
                    command.Parameters.AddWithValue("@Status", "Active"); // add parameters
                    SqlDataReader sqlDataReader = command.ExecuteReader(); // Execute the query
                    if (sqlDataReader.Read()) // if orders data found
                    {
                        OrderCount= sqlDataReader.GetInt32(0);
                    }
                }
                catch (Exception e) // if any exception returns the exception message
                {
                    throw (e);
                }
                finally // closes the database connection at the end
                {
                    con.Close();
                }
            }
            return OrderCount; // returns orders count
        }
    }
}
