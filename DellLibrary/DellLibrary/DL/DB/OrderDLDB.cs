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

        public int GetOrderCount()
        {
            int OrderCount = 0;
            using (SqlConnection con = Configuration.GetConnection())
            {
                try
                {
                    string query = "SELECT Count(OrderId) FROM Orders;";
                    con.Open();
                    SqlCommand command = new SqlCommand(query, con);
                    SqlDataReader sqlDataReader = command.ExecuteReader();
                    if (sqlDataReader.Read())
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
                    con.Close();
                }
            }
            return OrderCount;
        }

        public List<OrderBL> GetOrdersForUser(string username)
        {
            List<OrderBL> orders = new List<OrderBL>();
            string query = "SELECT O.OrderId, O.OrderType, O.OrderDate, O.TotalPrice, O.EmployeeID " +
                           "FROM Orders AS O " +
                           "JOIN Customers AS C ON O.CustomerID = C.Username " +
                           "WHERE C.Username = @Username;";
            using (SqlConnection con = Configuration.GetConnection())
            {
                con.Open();
                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@Username", username);
                using (SqlDataReader sqlDataReader = command.ExecuteReader())
                {
                    while (sqlDataReader.Read())
                    {
                        int orderId = sqlDataReader.GetInt32(0);
                        string orderType = sqlDataReader.GetString(1);
                        DateTime orderDate = sqlDataReader.GetDateTime(2);
                        double totalPrice = sqlDataReader.GetDouble(3);
                        string employeeUN = sqlDataReader.IsDBNull(4) ? null : sqlDataReader.GetString(4);
                        EmployeeBL employee = null;
                        if (!string.IsNullOrEmpty(employeeUN))
                        {
                            employee = employeeDL.GetEmployeebyUsername(employeeUN);
                        }
                        List<OrderDetailsBL> orderDetails = orderDetailsDL.GetOrderDetailsForOrder(orderId);
                        OrderBL order = employee != null ? new OrderBL(orderId, orderType, orderDate, employee, totalPrice,orderDetails) :
                                                            new OrderBL(orderId, orderType, orderDate, totalPrice,orderDetails);
                        orders.Add(order);
                    }
                }
            }
            return orders;
        }

        public int GetOrderCountForEmployee(string empUsername)
        {
            int OrderCount = 0;
            using (SqlConnection con = Configuration.GetConnection())
            {
                try
                {
                    string query = "SELECT Count(OrderId) FROM Orders where EmployeeID=@empUsername;";
                    con.Open();
                    SqlCommand command = new SqlCommand(query, con);
                    command.Parameters.AddWithValue("empUsername", empUsername);
                    SqlDataReader sqlDataReader = command.ExecuteReader();
                    if (sqlDataReader.Read())
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
                    con.Close();
                }
            }
            return OrderCount;
        }

        public int GetOrderCountForCustomer(string custUsername)
        {
            int OrderCount = 0;
            using (SqlConnection con = Configuration.GetConnection())
            {
                try
                {
                    string query = "SELECT Count(OrderId) FROM Orders where CustomerID=@custUsername;";
                    con.Open();
                    SqlCommand command = new SqlCommand(query, con);
                    command.Parameters.AddWithValue("custUsername", custUsername);
                    SqlDataReader sqlDataReader = command.ExecuteReader();
                    if (sqlDataReader.Read())
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
                    con.Close();
                }
            }
            return OrderCount;
        }

        public int AddOrder(OrderBL order, string username)
        {
            try
            {
                using (SqlConnection con = Configuration.GetConnection())
                {
                    con.Open();
                    string query = "INSERT INTO Orders (OrderType, CustomerID, OrderDate, TotalPrice) " +
                                   "OUTPUT INSERTED.OrderID " +
                                   "VALUES (@OrderType, @Username, @OrderDate, @TotalPrice)";
                    SqlCommand command = new SqlCommand(query, con);
                    command.Parameters.AddWithValue("@OrderType", order.GetOrderType());
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@OrderDate", order.GetOrderDate());
                    command.Parameters.AddWithValue("@TotalPrice", order.GetTotalPrice());
                    int orderID = (int)command.ExecuteScalar();
                    return orderID;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error adding order to database: " + ex.Message);
                return -1;
            }
        }
    }
}
