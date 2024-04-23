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
        public string AddCustomer(CustomerBL user) // adds customer to DB
        {
            string message = Validations.IsValidNewUser(user); // checks if user is valid or not

            if (message == "True") // if the user is valid
            {
                // query to add customer
                string query = "INSERT INTO Customers (Name, Username, Password, Email, DOB, Address, Contact, Gender, Status) " +
                               "VALUES (@Name, @Username, @Password, @Email, @DOB, @Address, @Contact, @Gender, @Status)";
                // connection to the database
                using (SqlConnection con = Configuration.GetConnection())
                {
                    try
                    {
                        con.Open();
                        SqlCommand command = new SqlCommand(query, con); // command to execute query

                        // Add parameters
                        command.Parameters.AddWithValue("@Name", user.GetName());
                        command.Parameters.AddWithValue("@Username", user.GetUsername());
                        command.Parameters.AddWithValue("@Password", user.GetPassword());
                        command.Parameters.AddWithValue("@Email", user.GetEmail());
                        command.Parameters.AddWithValue("@DOB", user.GetDob());
                        command.Parameters.AddWithValue("@Address", user.GetAddress());
                        command.Parameters.AddWithValue("@Contact", user.GetContact());
                        command.Parameters.AddWithValue("@Gender", user.GetGender());
                        command.Parameters.AddWithValue("@Status", user.GetStatus());

                        int rowsAffected = command.ExecuteNonQuery(); // execute command
                        if (rowsAffected > 0) // if the customer was added
                        {
                            message = "True";
                        }
                    }
                    catch (Exception e) // if error occurs
                    {
                        message = e.Message;
                    }
                    finally // Close the database connection at end
                    {
                        con.Close();
                    }
                }
            }
            return message; // return the result message
        }
        public string RemoveCustomer(string username) // removes customer from DB
        {
            string message = "";
            // makes connection with DB to remove customer
            using (SqlConnection con = Configuration.GetConnection())
            {
                // first try to execute delete command
                string query = $"DELETE Customers where Username=@Username;";
                try
                {
                    con.Open(); // opens Database Connection
                    SqlCommand command = new SqlCommand(query, con); // command to execute the query

                    // Add parameters
                    command.Parameters.AddWithValue("@Username", username);

                    SqlDataReader sqlDataReader = command.ExecuteReader(); // Execute the query
                    int rowAffected = sqlDataReader.RecordsAffected;
                    if (rowAffected>0)
                    {
                        message="True";
                    }
                }
                // if any exception returns the exception message
                catch (Exception e)
                {
                    message = e.Message;
                }
                finally // closes the database connection at the end
                {
                    con.Close();
                }
            }
            // returns the message
            return message;
        }
        public string DeactivateCustomerAccount(string username) // deactivates customer account
        {
            string message = "";

            // Query to update employee
            string query = "UPDATE Customers SET Status='Deactivated' WHERE Username=@username;";

            // Connection to the database
            using (SqlConnection con = Configuration.GetConnection())
            {
                try
                {
                    con.Open();
                    SqlCommand command = new SqlCommand(query, con);

                    // Add parameters
                    command.Parameters.AddWithValue("@username", username);

                    // Execute command
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0) // If the employee was updated
                    {
                        message = "True";
                    }
                }
                catch (Exception e) // If an error occurs
                {
                    message = e.Message;
                }
                finally // Close the database connection at the end
                {
                    con.Close();
                }
            }

            return message; // Return the result message
        }
        public string UpdateCustomer(CustomerBL user, string username, string email) // updates customer in DB
        {
            string message = Validations.IsValidUpdatedUser(user, username, email, false); // checks if user is valid or not

            if (message == "True") // if the user is valid
            {
                // query to add customer
                string query = "UPDATE Customers SET Name=@Name, Password=@Password, Email=@Email, DOB=@DOB, Address=@Address, Contact=@Contact, Gender=@Gender WHERE Username=@user";
                // connection to the database
                using (SqlConnection con = Configuration.GetConnection())
                {
                    try
                    {
                        con.Open();
                        SqlCommand command = new SqlCommand(query, con); // command to execute query

                        // Add parameters
                        command.Parameters.AddWithValue("@Name", user.GetName());
                        command.Parameters.AddWithValue("@user", username);
                        command.Parameters.AddWithValue("@Password", user.GetPassword());
                        command.Parameters.AddWithValue("@Email", user.GetEmail());
                        command.Parameters.AddWithValue("@DOB", user.GetDob());
                        command.Parameters.AddWithValue("@Address", user.GetAddress());
                        command.Parameters.AddWithValue("@Contact", user.GetContact());
                        command.Parameters.AddWithValue("@Gender", user.GetGender());

                        int rowsAffected = command.ExecuteNonQuery(); // execute command
                        if (rowsAffected > 0) // if the customer was added
                        {
                            message = "True";
                        }
                    }
                    catch (Exception e) // if error occurs
                    {
                        message = e.Message;
                    }
                    finally // Close the database connection at end
                    {
                        con.Close();
                    }
                }
            }
            return message; // return the result message
        }
        public CustomerBL GetCustomerByUsername(string userName) // returns customer for a username
        {
            CustomerBL customer = null;
            // query to find user in the database
            string query = $"SELECT * FROM Customers WHERE Username=@userName;";
            using (SqlConnection con = Configuration.GetConnection()) // Connection to the database 
            {
                try
                {
                    con.Open();
                    SqlCommand command = new SqlCommand(query, con); // command to execute the query

                    // Add parameters
                    command.Parameters.AddWithValue("@UserName", userName);

                    SqlDataReader sqlDataReader = command.ExecuteReader(); // Execute the query
                    if (sqlDataReader.Read()) // if user was found
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
                        if (orders!= null)
                        {
                            customer.AddOrdersList(orders);
                        }
                    }
                    else // if user not found
                    {
                        customer = null;
                    }
                }
                catch (Exception ex) // if error occurs
                {
                    throw (ex);
                }
                finally // Close the database connection at end
                {
                    con.Close();
                }
            }
            return customer; // return the result message
        }
        public List<CustomerBL> GetAllCustomersByStatus(string cstatus) // returns the list of all customers by status
        {
            List<CustomerBL> Customers = new List<CustomerBL>();
            // makes connection with DB to get customers
            using (SqlConnection con = Configuration.GetConnection())
            {
                string query = $"Select * from Customers where Status=@cstatus;";
                // first try to execute retreive command
                try
                {
                    con.Open(); // opens Database Connection
                    SqlCommand command = new SqlCommand(query, con); // command to execute the query
                    command.Parameters.AddWithValue("@cstatus", cstatus);
                    SqlDataReader sqlDataReader = command.ExecuteReader(); // Execute the query

                    while (sqlDataReader.Read()) // if customers data found
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
                        if (orders!= null)
                        {
                            customer.AddOrdersList(orders);
                        }
                        Customers.Add(customer);
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
            return Customers; // returns list
        }
        public List<CustomerBL> GetAllCustomers() // returns the list of all customers
        {
            List<CustomerBL> Customers = new List<CustomerBL>();
            // makes connection with DB to get customers
            using (SqlConnection con = Configuration.GetConnection())
            {
                string query = $"Select * from Customers;";
                // first try to execute retreive command
                try
                {
                    con.Open(); // opens Database Connection
                    SqlCommand command = new SqlCommand(query, con); // command to execute the query
                    SqlDataReader sqlDataReader = command.ExecuteReader(); // Execute the query

                    while (sqlDataReader.Read()) // if customers data found
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
                        if (orders!= null)
                        {
                            customer.AddOrdersList(orders);
                        }
                        Customers.Add(customer);
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
            return Customers; // returns list
        }
        public bool UniqueAttributeCheck(string text, string attribute) // checks for unique attributes
        {
            bool check = false;
            // query to check attributes
            string Query = $"Select * from Customers where {attribute}='{text}';";

            // making connection with database
            using (SqlConnection con = Configuration.GetConnection())
            {
                try
                {
                    // Open the database connection
                    con.Open();

                    SqlCommand command = new SqlCommand(Query, con);
                    SqlDataReader sqlDataReader = command.ExecuteReader(); // executes command

                    if (sqlDataReader.Read()) // if attribute found
                    {
                        check = true;
                    }
                }
                catch (Exception) // If an exception occurs during database operations, set check to true
                {
                    check = true;
                }
                finally // Ensure the connection is closed after database operations
                {
                    con.Close();
                }
            }

            return check; // Return the result of the check
        }
        public UserBL UserSignIn(UserBL user) // checks user in database for signing in
        {
            CustomerBL customer = null;
            // query to find user in the database
            string query = $"SELECT * FROM Customers WHERE Username COLLATE Latin1_General_BIN = @Username AND Password COLLATE Latin1_General_BIN = @Password AND Status='Active';";
            using (SqlConnection con = Configuration.GetConnection()) // Connection to the database 
            {
                try
                {
                    con.Open();
                    SqlCommand command = new SqlCommand(query, con); // command to execute the query

                    // Add parameters
                    command.Parameters.AddWithValue("@Username", user.GetUsername());
                    command.Parameters.AddWithValue("@Password", user.GetPassword());

                    SqlDataReader sqlDataReader = command.ExecuteReader(); // Execute the query
                    if (sqlDataReader.Read()) // if user was found
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
                        if (orders!= null)
                        {
                            customer.AddOrdersList(orders);
                        }
                    }
                    else // if user not found
                    {
                        customer = null;
                    }
                }
                catch (Exception ex) // if error occurs
                {
                    throw (ex);
                }
                finally // Close the database connection at end
                {
                    con.Close();
                }
            }
            return customer; // return the result message
        }
        public int GetCustomerCount() // returns count of total customers in database
        {
            int CustomerCount = 0;
            // makes connection with DB to get customers count
            using (SqlConnection con = Configuration.GetConnection())
            {
                string query = $"Select Count(username) from Customers where Status=@status;";
                // first try to execute retreive command
                try
                {
                    con.Open(); // opens Database Connection
                    SqlCommand command = new SqlCommand(query, con); // command to execute the query
                    command.Parameters.AddWithValue("@status", "Active"); // add parameters
                    SqlDataReader sqlDataReader = command.ExecuteReader(); // Execute the query
                    if (sqlDataReader.Read()) // if customers data found
                    {
                        CustomerCount = sqlDataReader.GetInt32(0);
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
            return CustomerCount; // returns customer count
        }
    }
}
