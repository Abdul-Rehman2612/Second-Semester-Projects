using DellLibrary.BL;
using DellLibrary.DL_Interfaces;
using DellLibrary.Utility;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DellLibrary.DL.DB
{
    public class CustomerDLDB : IUserDL, ICustomerDL
    {
        private static readonly IOrderDL orderDL = new OrderDLDB();
        public string AddCustomer(CustomerBL user)
        {
            string message = Validations.IsValidNewUser(user);

            if (message == "True")
            {
                string query = "INSERT INTO Customers (Name, Username, Password, Email, DOB, Address, Contact, Gender, Status) " +
                               "VALUES (@Name, @Username, @Password, @Email, @DOB, @Address, @Contact, @Gender, @Status)";
                using (SqlConnection con = Configuration.GetConnection())
                {
                    try
                    {
                        con.Open();
                        SqlCommand command = new SqlCommand(query, con);

                        command.Parameters.AddWithValue("@Name", user.GetName());
                        command.Parameters.AddWithValue("@Username", user.GetUsername());
                        command.Parameters.AddWithValue("@Password", user.GetPassword());
                        command.Parameters.AddWithValue("@Email", user.GetEmail());
                        command.Parameters.AddWithValue("@DOB", user.GetDob());
                        command.Parameters.AddWithValue("@Address", user.GetAddress());
                        command.Parameters.AddWithValue("@Contact", user.GetContact());
                        command.Parameters.AddWithValue("@Gender", user.GetGender());
                        command.Parameters.AddWithValue("@Status", user.GetStatus());

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            message = "True";
                        }
                    }
                    catch (Exception e)
                    {
                        message = e.Message;
                    }
                    finally
                    {
                        con.Close();
                    }
                }
            }
            return message;
        }
        public string RemoveCustomer(string username)
        {
            string message = "";
            using (SqlConnection con = Configuration.GetConnection())
            {
                string query = $"DELETE Customers where Username=@Username;";
                try
                {
                    con.Open();
                    SqlCommand command = new SqlCommand(query, con);

                    command.Parameters.AddWithValue("@Username", username);

                    SqlDataReader sqlDataReader = command.ExecuteReader();
                    int rowAffected = sqlDataReader.RecordsAffected;
                    if (rowAffected > 0)
                    {
                        message = "True";
                    }
                }
                catch (Exception e)
                {
                    message = e.Message;
                }
                finally
                {
                    con.Close();
                }
            }
            return message;
        }
        public string DeactivateCustomerAccount(string username)
        {
            string message = "";
            string query = "UPDATE Customers SET Status='Deactivated' WHERE Username=@username;";
            using (SqlConnection con = Configuration.GetConnection())
            {
                try
                {
                    con.Open();
                    SqlCommand command = new SqlCommand(query, con);

                    command.Parameters.AddWithValue("@username", username);

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        message = "True";
                    }
                }
                catch (Exception e)
                {
                    message = e.Message;
                }
                finally
                {
                    con.Close();
                }
            }
            return message;
        }
        public string ActivateCustomerAccount(string username)
        {
            string message = "";
            string query = "UPDATE Customers SET Status='Active' WHERE Username=@username;";
            using (SqlConnection con = Configuration.GetConnection())
            {
                try
                {
                    con.Open();
                    SqlCommand command = new SqlCommand(query, con);

                    command.Parameters.AddWithValue("@username", username);

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        message = "True";
                    }
                }
                catch (Exception e)
                {
                    message = e.Message;
                }
                finally
                {
                    con.Close();
                }
            }
            return message;
        }
        public string UpdateCustomer(CustomerBL user, string username, string email)
        {
            string message = Validations.IsValidUpdatedUser(user, username, email, false);

            if (message == "True")
            {
                string query = "UPDATE Customers SET Name=@Name, Password=@Password, Email=@Email, DOB=@DOB, Address=@Address, Contact=@Contact, Gender=@Gender WHERE Username=@user";
                using (SqlConnection con = Configuration.GetConnection())
                {
                    try
                    {
                        con.Open();
                        SqlCommand command = new SqlCommand(query, con);

                        command.Parameters.AddWithValue("@Name", user.GetName());
                        command.Parameters.AddWithValue("@user", username);
                        command.Parameters.AddWithValue("@Password", user.GetPassword());
                        command.Parameters.AddWithValue("@Email", user.GetEmail());
                        command.Parameters.AddWithValue("@DOB", user.GetDob());
                        command.Parameters.AddWithValue("@Address", user.GetAddress());
                        command.Parameters.AddWithValue("@Contact", user.GetContact());
                        command.Parameters.AddWithValue("@Gender", user.GetGender());

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            message = "True";
                        }
                    }
                    catch (Exception e)
                    {
                        message = e.Message;
                    }
                    finally
                    {
                        con.Close();
                    }
                }
            }
            return message;
        }
        public CustomerBL GetCustomerByUsername(string userName)
        {
            CustomerBL customer = null;
            string query = $"SELECT * FROM Customers WHERE Username=@userName;";
            using (SqlConnection con = Configuration.GetConnection())
            {
                try
                {
                    con.Open();
                    SqlCommand command = new SqlCommand(query, con);

                    command.Parameters.AddWithValue("@UserName", userName);

                    SqlDataReader sqlDataReader = command.ExecuteReader();
                    if (sqlDataReader.Read())
                    {
                        string name = sqlDataReader.GetString(0);
                        string username = sqlDataReader.GetString(1);
                        string password = sqlDataReader.GetString(2);
                        string email = sqlDataReader.GetString(3);
                        DateTime birthDate = sqlDataReader.GetDateTime(4);
                        string address = sqlDataReader.GetString(5);
                        string contact = sqlDataReader.GetString(6);
                        string gender = sqlDataReader.GetString(7);
                        string status = sqlDataReader.GetString(8);
                        customer = new CustomerBL(name, username, password, email, birthDate, address, contact, gender, status);
                        List<OrderBL> orders = orderDL.GetOrdersForUser(username);
                        if (orders != null)
                        {
                            customer.AddOrdersList(orders);
                        }
                    }
                    else
                    {
                        customer = null;
                    }
                }
                catch (Exception ex)
                {
                    throw (ex);
                }
                finally
                {
                    con.Close();
                }
            }
            return customer;
        }
        public List<CustomerBL> GetAllCustomersByStatus(string cstatus)
        {
            List<CustomerBL> Customers = new List<CustomerBL>();
            using (SqlConnection con = Configuration.GetConnection())
            {
                string query = $"Select * from Customers where Status=@cstatus;";
                try
                {
                    con.Open();
                    SqlCommand command = new SqlCommand(query, con);
                    command.Parameters.AddWithValue("@cstatus", cstatus);
                    SqlDataReader sqlDataReader = command.ExecuteReader();

                    while (sqlDataReader.Read())
                    {
                        string name = sqlDataReader.GetString(0);
                        string username = sqlDataReader.GetString(1);
                        string password = sqlDataReader.GetString(2);
                        string email = sqlDataReader.GetString(3);
                        DateTime birthDate = sqlDataReader.GetDateTime(4);
                        string address = sqlDataReader.GetString(5);
                        string contact = sqlDataReader.GetString(6);
                        string gender = sqlDataReader.GetString(7);
                        string status = sqlDataReader.GetString(8);
                        CustomerBL customer = new CustomerBL(name, username, password, email, birthDate, address, contact, gender, status);
                        List<OrderBL> orders = orderDL.GetOrdersForUser(username);
                        if (orders != null)
                        {
                            customer.AddOrdersList(orders);
                        }
                        Customers.Add(customer);
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
            return Customers;
        }
        public List<CustomerBL> GetAllCustomers()
        {
            List<CustomerBL> Customers = new List<CustomerBL>();
            using (SqlConnection con = Configuration.GetConnection())
            {
                string query = $"Select * from Customers;";
                try
                {
                    con.Open();
                    SqlCommand command = new SqlCommand(query, con);
                    SqlDataReader sqlDataReader = command.ExecuteReader();

                    while (sqlDataReader.Read())
                    {
                        string name = sqlDataReader.GetString(0);
                        string username = sqlDataReader.GetString(1);
                        string password = sqlDataReader.GetString(2);
                        string email = sqlDataReader.GetString(3);
                        DateTime birthDate = sqlDataReader.GetDateTime(4);
                        string address = sqlDataReader.GetString(5);
                        string contact = sqlDataReader.GetString(6);
                        string gender = sqlDataReader.GetString(7);
                        string status = sqlDataReader.GetString(8);
                        CustomerBL customer = new CustomerBL(name, username, password, email, birthDate, address, contact, gender, status);
                        List<OrderBL> orders = orderDL.GetOrdersForUser(username);
                        if (orders != null)
                        {
                            customer.AddOrdersList(orders);
                        }
                        Customers.Add(customer);
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
            return Customers;
        }
        public bool UniqueAttributeCheck(string text, string attribute)
        {
            bool check = false;
            string Query = $"Select * from Customers where {attribute}='{text}';";
            using (SqlConnection con = Configuration.GetConnection())
            {
                try
                {
                    con.Open();
                    SqlCommand command = new SqlCommand(Query, con);
                    SqlDataReader sqlDataReader = command.ExecuteReader();

                    if (sqlDataReader.Read())
                    {
                        check = true;
                    }
                }
                catch (Exception)
                {
                    check = true;
                }
                finally
                {
                    con.Close();
                }
            }

            return check;
        }
        public UserBL UserSignIn(UserBL user)
        {
            CustomerBL customer = null;
            string query = $"SELECT * FROM Customers WHERE Username COLLATE Latin1_General_BIN = @Username AND Password COLLATE Latin1_General_BIN = @Password AND Status='Active';";
            using (SqlConnection con = Configuration.GetConnection())
            {
                try
                {
                    con.Open();
                    SqlCommand command = new SqlCommand(query, con);

                    command.Parameters.AddWithValue("@Username", user.GetUsername());
                    command.Parameters.AddWithValue("@Password", user.GetPassword());

                    SqlDataReader sqlDataReader = command.ExecuteReader();
                    if (sqlDataReader.Read())
                    {
                        string name = sqlDataReader.GetString(0);
                        string username = sqlDataReader.GetString(1);
                        string password = sqlDataReader.GetString(2);
                        string email = sqlDataReader.GetString(3);
                        DateTime birthDate = sqlDataReader.GetDateTime(4);
                        string address = sqlDataReader.GetString(5);
                        string contact = sqlDataReader.GetString(6);
                        string gender = sqlDataReader.GetString(7);
                        string status = sqlDataReader.GetString(8);
                        customer = new CustomerBL(name, username, password, email, birthDate, address, contact, gender, status);
                        List<OrderBL> orders = orderDL.GetOrdersForUser(username);
                        if (orders != null)
                        {
                            customer.AddOrdersList(orders);
                        }
                    }
                    else
                    {
                        customer = null;
                    }
                }
                catch (Exception ex)
                {
                    throw (ex);
                }
                finally
                {
                    con.Close();
                }
            }
            return customer;
        }
        public int GetCustomerCount()
        {
            int CustomerCount = 0;
            using (SqlConnection con = Configuration.GetConnection())
            {
                string query = $"Select Count(username) from Customers;";
                try
                {
                    con.Open();
                    SqlCommand command = new SqlCommand(query, con);
                    command.Parameters.AddWithValue("@status", "Active");
                    SqlDataReader sqlDataReader = command.ExecuteReader();
                    if (sqlDataReader.Read())
                    {
                        CustomerCount = sqlDataReader.GetInt32(0);
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
            return CustomerCount;
        }
    }
}


