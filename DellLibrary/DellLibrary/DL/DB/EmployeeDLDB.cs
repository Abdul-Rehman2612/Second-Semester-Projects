using DellLibrary.BL;
using DellLibrary.DL_Interfaces;
using DellLibrary.Utility;
using System;
using System.Data.SqlClient;

namespace DellLibrary.DL.DB
{
    public class EmployeeDLDB : IUserDL, IEmployeeDL
    {
        public string AddEmployee(EmployeeBL user)
        {
            string message = Validations.IsValidUser(user); // checks if user is valid or not
            // if the user is valid
            if (message == "True")
            {
                // query to add employee
                string query = "INSERT INTO Employees (Name, Username, Password, Email, DOB, Address, Contact, Gender, Status, Designation, HireDate) " +
                               "VALUES (@Name, @Username, @Password, @Email, @DOB, @Address, @Contact, @Gender, @Status, @Designation, @HireDate)";

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
                        command.Parameters.AddWithValue("@Designation", user.GetDesignation());
                        command.Parameters.AddWithValue("@HireDate", user.GetHireDate());

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
        // public static string RemoveUser(UserBL user) { };
        // public static string UpdateUser(UserBL user) { return ""; }
        // public static List<UserBL> GetAllUsers();
        public bool UniqueAttributeCheck(string text, string attribute)
        {
            // variable for checking attribute
            bool check = false;

            // query
            string Query = $"Select * from Employees where {attribute}='{text}';";
            using (SqlConnection con = Configuration.GetConnection()) // connection to database
            {
                try
                {
                    con.Open();
                    SqlCommand command = new SqlCommand(Query, con); // command to execute query
                    SqlDataReader sqlDataReader = command.ExecuteReader(); // datareader
                    if (sqlDataReader.Read()) // if attribute found
                    {
                        check = true;
                    }
                }
                catch (Exception)
                {
                    check = true;
                }
                finally // Close the connection at end
                {
                    con.Close();
                }
            }
            // Return the result of the check
            return check;
        }
        public string UserSignIn(UserBL user)
        {
            string message = "";
            // query to find user in the database
            string query = $"SELECT * FROM Employees WHERE Username COLLATE Latin1_General_BIN = @Username AND Password COLLATE Latin1_General_BIN = @Password AND Status='Active';";
            using (SqlConnection con = Configuration.GetConnection()) // Connection to the database 
            {
                try
                {
                    con.Open();
                    SqlCommand command = new SqlCommand(query, con); // command to execute the query
                    // Add parameters
                    command.Parameters.AddWithValue("@Username", user.GetUsername());
                    command.Parameters.AddWithValue("@Password", user.GetPassword());
                    SqlDataReader sqlDataReader = command.ExecuteReader(); // datareader
                    if (sqlDataReader.Read()) // if employee was found
                    {
                        if (sqlDataReader.IsDBNull(11)) // if resignation date is null
                        {
                            string designation = sqlDataReader.GetString(9);
                            EmployeeBL employee = new EmployeeBL(sqlDataReader.GetString(0), sqlDataReader.GetString(1), sqlDataReader.GetString(2), sqlDataReader.GetString(3), sqlDataReader.GetDateTime(4), sqlDataReader.GetString(5), sqlDataReader.GetString(6), sqlDataReader.GetString(7), sqlDataReader.GetString(8), sqlDataReader.GetString(9), sqlDataReader.GetDateTime(10));
                            message = designation;
                        }
                    }
                    else // if user not found
                    {
                        message = "Invalid username or password";
                    }
                }
                catch (Exception ex)
                {
                    message=ex.Message;
                }
                finally
                {
                    con.Close();
                }
            }
            return message; // return the result message
        }
    }
}
