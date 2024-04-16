using DellLibrary.BL;
using DellLibrary.DL_Interfaces;
using DellLibrary.Utility;
using System;
using System.Data.SqlClient;

namespace DellLibrary.DL.DB
{
    public class CustomerDLDB : IUserDL, ICustomerDL
    {
        private static CustomerBL customer = new CustomerBL();
        public CustomerBL GetCustomer() // returns the customer object
        { 
            return customer;
        }
        public string AddCustomer(CustomerBL user)
        {
            string message = Validations.IsValidUser(user); // checks if user is valid or not

            // if the user is valid
            if (message == "True")
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
                        SqlCommand command = new SqlCommand(query, con);

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

                        // execute command
                        int rowsAffected = command.ExecuteNonQuery();
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
        public string RemoveCustomer(string username)
        {

            string message = "";
            // makes connection with DB to add user
            using (SqlConnection con = Configuration.GetConnection())
            {
                // first try to execute insert command
                try
                {
                    con.Open();
                    SqlCommand command = new SqlCommand("", con);
                    SqlDataReader sqlDataReader = command.ExecuteReader();
                    int rowAffected = sqlDataReader.RecordsAffected;
                    if (rowAffected>0)
                    {
                        message="True";
                    }
                }
                // if any exception returns the exception message
                catch (Exception e)
                {
                    message=e.Message;
                }
                // closes te connection at the end
                finally
                {
                    con.Close();
                }
            }
            // returns the message
            return message;
        }
        public string UpdateCustomer(CustomerBL customer)
        {
            return null;
        }
        public bool UniqueAttributeCheck(string text, string attribute)
        {
            bool check = false;
            string Query = $"Select * from Customers where {attribute}='{text}";
            using (SqlConnection con = Configuration.GetConnection())
            {
                try
                {
                    con.Open();
                    SqlCommand command = new SqlCommand(Query, con);
                    SqlDataReader sqlDataReader = command.ExecuteReader();
                    if (sqlDataReader.Read())
                    {
                        check=true;
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
        public string UserSignIn(UserBL user)
        {
            string message = "";
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
                        customer = new CustomerBL(name,username,password,email,birthDate,address,contact,gender,status);
                        message = "Customer";
                    }
                    else // if user not found
                    {
                        message = "Invalid username or password";
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
            return message; // return the result message
        }
    }
}
