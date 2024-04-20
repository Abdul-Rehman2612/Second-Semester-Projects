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
        public int GetOrderCount() // returns order count
        {
            int OrderCount = 0;
            using (SqlConnection con = Configuration.GetConnection())
            {
                try
                {
                    string query = "SELECT Count(O.OrderId) FROM Orders AS O JOIN Customers AS C ON O.CustomerID = C.Username;";

                    con.Open(); // Opens Database Connection

                    SqlCommand command = new SqlCommand(query, con); // Command to execute the query
                    SqlDataReader sqlDataReader = command.ExecuteReader(); // Execute the query

                    if (sqlDataReader.Read()) // If orders data found
                    {
                        OrderCount = sqlDataReader.GetInt32(0);
                    }
                }
                catch (Exception e)
                {
                    throw (e);
                }
                finally
                {
                    con.Close(); // Closes the database connection at the end
                }
            }
            return OrderCount; // Returns orders count
        }
        public List<OrderBL> GetOrdersForUser(string username) // returns orders for a specific user
        {
            List<OrderBL> orders = new List<OrderBL>();
            string query = "SELECT O.OrderId, O.OrderType, O.OrderDate, O.TotalPrice, C.EmployeeUN " +
                           "FROM Orders AS O " +
                           "JOIN Customers AS C ON O.CustomerID = C.Username " +
                           "WHERE C.Username = @Username;";
            using (SqlConnection con = Configuration.GetConnection())
            {
                try
                {
                    con.Open(); // Opens Database Connection

                    SqlCommand command = new SqlCommand(query, con); // Command to execute the query
                    command.Parameters.AddWithValue("@Username", username); // Add parameters

                    SqlDataReader sqlDataReader = command.ExecuteReader(); // Execute the query

                    while (sqlDataReader.Read()) // Loop through results
                    {
                        int orderId = sqlDataReader.GetInt32(0);
                        string orderType = sqlDataReader.GetString(1);
                        DateTime orderDate = sqlDataReader.GetDateTime(2);
                        double totalPrice = sqlDataReader.GetDouble(3);
                        string employeeUN = sqlDataReader.GetString(4);
                        EmployeeBL employee = employeeDL.GetEmployeebyUsername(employeeUN); // Retrieve employee
                        OrderBL order = new OrderBL(orderId, orderType, orderDate, employee, totalPrice);
                        orders.Add(order);
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
            return orders;
        }

    }
}
