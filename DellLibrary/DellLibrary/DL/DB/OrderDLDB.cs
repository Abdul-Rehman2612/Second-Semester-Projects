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
        private readonly static IOrderDetailsDL orderDetailsDL = new OrderDetailsDLDB();
        public int GetOrderCount() // returns order count
        {
            int OrderCount = 0;
            using (SqlConnection con = Configuration.GetConnection())
            {
                try
                {
                    string query = "SELECT Count(OrderId) FROM Orders;";

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
            string query = "SELECT O.OrderId, O.OrderType, O.OrderDate, O.TotalPrice, O.EmployeeID " +
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
                        if(employee!=null)
                        {
                            OrderBL order = new OrderBL(orderId, orderType, orderDate, employee, totalPrice);
                            List<OrderDetailsBL> orderDetails = orderDetailsDL.GetOrderDetailsForOrder(orderId);
                            order.AddOrderDetailsList(orderDetails);
                            orders.Add(order);
                        }
                        else
                        {
                            OrderBL order = new OrderBL(orderId, orderType, orderDate, totalPrice);
                            List<OrderDetailsBL> orderDetails = orderDetailsDL.GetOrderDetailsForOrder(orderId);
                            order.AddOrderDetailsList(orderDetails);
                            orders.Add(order);
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
            return orders;
        }
        public int GetOrderCountForEmployee(string empUsername) // returns order count
        {
            int OrderCount = 0;
            using (SqlConnection con = Configuration.GetConnection())
            {
                try
                {
                    string query = "SELECT Count(OrderId) FROM Orders where EmployeeID=@empUsername;";

                    con.Open(); // Opens Database Connection

                    SqlCommand command = new SqlCommand(query, con); // Command to execute the query
                    command.Parameters.AddWithValue("empUsername", empUsername);
                    SqlDataReader sqlDataReader = command.ExecuteReader(); // Execute the query

                    if (sqlDataReader.Read()) // If orders data found for employee
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
        public int GetOrderCountForCustomer(string custUsername) // returns order count
        {
            int OrderCount = 0;
            using (SqlConnection con = Configuration.GetConnection())
            {
                try
                {
                    string query = "SELECT Count(OrderId) FROM Orders where CustomerID=@custUsername;";

                    con.Open(); // Opens Database Connection

                    SqlCommand command = new SqlCommand(query, con); // Command to execute the query
                    command.Parameters.AddWithValue("custUsername", custUsername);
                    SqlDataReader sqlDataReader = command.ExecuteReader(); // Execute the query

                    if (sqlDataReader.Read()) // If orders data found for employee
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

    }
}
