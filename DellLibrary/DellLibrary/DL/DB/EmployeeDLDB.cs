using DellLibrary.BL;
using DellLibrary.DL_Interfaces;
using DellLibrary.Utility;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DellLibrary.DL.DB
{
    public class EmployeeDLDB : IUserDL, IEmployeeDL
    {
        public string AddEmployee(EmployeeBL user) // adds employee to DB
        {
            string message = Validations.IsValidNewUser(user); // checks if user is valid or not
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
                        if (rowsAffected > 0) // if the employee was added
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
        public string UpdateEmployee(EmployeeBL user, string username, string email) // updates employee data
        {
            string message;

            // Determine if the user is a CEO
            bool isCEO = user.GetDesignation() == "CEO";

            // Validate user information
            message = Validations.IsValidUpdatedUser(user, username, email, isCEO);

            // If the user is valid
            if (message == "True")
            {
                // Query to update employee
                string query = "UPDATE Employees SET Name=@Name, Username=@Username, Password=@Password, Email=@Email, DOB=@DOB, Address=@Address, Contact=@Contact, Gender=@Gender WHERE Username=@user";

                // Connection to the database
                using (SqlConnection con = Configuration.GetConnection())
                {
                    try
                    {
                        con.Open();
                        SqlCommand command = new SqlCommand(query, con);

                        // Add parameters
                        command.Parameters.AddWithValue("@Name", user.GetName());
                        command.Parameters.AddWithValue("@Username", user.GetUsername());
                        command.Parameters.AddWithValue("@user", username);
                        command.Parameters.AddWithValue("@Password", user.GetPassword());
                        command.Parameters.AddWithValue("@Email", user.GetEmail());
                        command.Parameters.AddWithValue("@DOB", user.GetDob());
                        command.Parameters.AddWithValue("@Address", user.GetAddress());
                        command.Parameters.AddWithValue("@Contact", user.GetContact());
                        command.Parameters.AddWithValue("@Gender", user.GetGender());

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
            }
            return message; // Return the result message
        }
        public string RemoveEmployee(string username) // removes employee
        {
            string message = "";
            // makes connection with DB to remove employee
            using (SqlConnection con = Configuration.GetConnection())
            {
                // first try to execute delete command
                string query = $"DELETE Employees where Username=@Username;";
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
        public string DeactivateEmployeeAccount(string username) // deactivates employee account
        {
            string message="";

            // Query to update employee
            string query = "UPDATE Employees SET Status='Deactivated' WHERE Username=@username;";

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
        public EmployeeBL GetEmployeebyUsername(string username) // returns employee for a username
        {
            EmployeeBL employee = null;
            // makes connection with DB to get employees
            using (SqlConnection con = Configuration.GetConnection())
            {
                string query = $"Select * from Employees where Username=@username and designation!='CEO';";
                // first try to execute retreive command
                try
                {
                    con.Open(); // opens Database Connection
                    SqlCommand command = new SqlCommand(query, con); // command to execute the query
                    command.Parameters.AddWithValue("@Username", username);
                    SqlDataReader sqlDataReader = command.ExecuteReader(); // Execute the query

                    while (sqlDataReader.Read()) // if employees data found
                    {
                        if (sqlDataReader.IsDBNull(11)) // if resignation date is null
                        {
                            employee = new EmployeeBL(sqlDataReader.GetString(0), username, sqlDataReader.GetString(2), sqlDataReader.GetString(3), sqlDataReader.GetDateTime(4), sqlDataReader.GetString(5), sqlDataReader.GetString(6), sqlDataReader.GetString(7), sqlDataReader.GetString(8), sqlDataReader.GetString(9), sqlDataReader.GetDateTime(10));
                        }
                        else
                        {
                            employee = new EmployeeBL(sqlDataReader.GetString(0), username, sqlDataReader.GetString(2), sqlDataReader.GetString(3), sqlDataReader.GetDateTime(4), sqlDataReader.GetString(5), sqlDataReader.GetString(6), sqlDataReader.GetString(7), sqlDataReader.GetString(8), sqlDataReader.GetString(9), sqlDataReader.GetDateTime(10), sqlDataReader.GetDateTime(11));
                        }
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
            return employee; // returns employee
        }
        public List<EmployeeBL> GetAllEmployeesByStatus(string eStatus) // returns the list of employees acc to current status
        {
            List<EmployeeBL> Employees = new List<EmployeeBL>();
            // makes connection with DB to get employees
            using (SqlConnection con = Configuration.GetConnection())
            {
                string query = $"Select * from Employees where Designation<>'CEO' where status = @estatus;";
                // first try to execute retreive command
                try
                {
                    con.Open(); // opens Database Connection
                    SqlCommand command = new SqlCommand(query, con); // command to execute the query
                    command.Parameters.AddWithValue("@estatus", eStatus);
                    SqlDataReader sqlDataReader = command.ExecuteReader(); // Execute the query

                    while (sqlDataReader.Read()) // if employees data found
                    {
                        if (sqlDataReader.IsDBNull(11)) // if resignation date is null
                        {
                            EmployeeBL employee = new EmployeeBL(sqlDataReader.GetString(0), sqlDataReader.GetString(1), sqlDataReader.GetString(2), sqlDataReader.GetString(3), sqlDataReader.GetDateTime(4), sqlDataReader.GetString(5), sqlDataReader.GetString(6), sqlDataReader.GetString(7), sqlDataReader.GetString(8), sqlDataReader.GetString(9), sqlDataReader.GetDateTime(10));
                            Employees.Add(employee);
                        }
                        else
                        {
                            EmployeeBL employee = new EmployeeBL(sqlDataReader.GetString(0), sqlDataReader.GetString(1), sqlDataReader.GetString(2), sqlDataReader.GetString(3), sqlDataReader.GetDateTime(4), sqlDataReader.GetString(5), sqlDataReader.GetString(6), sqlDataReader.GetString(7), sqlDataReader.GetString(8), sqlDataReader.GetString(9), sqlDataReader.GetDateTime(10), sqlDataReader.GetDateTime(11));
                            Employees.Add(employee);
                        }
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
            return Employees; // returns list
        }
        public List<EmployeeBL> GetEmployeesByDesignation(string designation,string status) // returns the list of employees with specific designation and status
        {
            List<EmployeeBL> Employees = new List<EmployeeBL>();
            // makes connection with DB to get employees
            using (SqlConnection con = Configuration.GetConnection())
            {
                string query = $"Select * from Employees where Designation=@designation and Status=@status;";
                // first try to execute retreive command
                try
                {
                    con.Open(); // opens Database Connection
                    SqlCommand sqlCommand = new SqlCommand(query, con);
                    SqlCommand command = sqlCommand; // command to execute the query
                    // Add parameters
                    command.Parameters.AddWithValue("@designation", designation);
                    command.Parameters.AddWithValue("@status", status);

                    SqlDataReader sqlDataReader = command.ExecuteReader(); // Execute the query
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
                        DateTime hireDate = sqlDataReader.GetDateTime(10);
                        EmployeeBL employee = new EmployeeBL(name, username,password,email,birthDate,address,contact,gender,status,designation,hireDate);
                        Employees.Add(employee);
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
            return Employees; // returns list
        }
        public bool UniqueAttributeCheck(string text, string attribute) // checks database for a unique attribute
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
        public UserBL UserSignIn(UserBL user) // checks user in database for signing in
        {
            EmployeeBL employee = null;
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
                    if (sqlDataReader.Read() && sqlDataReader.IsDBNull(11)) // if employee was found && resignation date is null
                    {
                        string designation = sqlDataReader.GetString(9);
                        employee = new EmployeeBL(sqlDataReader.GetString(0), sqlDataReader.GetString(1), sqlDataReader.GetString(2), sqlDataReader.GetString(3), sqlDataReader.GetDateTime(4), sqlDataReader.GetString(5), sqlDataReader.GetString(6), sqlDataReader.GetString(7), sqlDataReader.GetString(8), sqlDataReader.GetString(9), sqlDataReader.GetDateTime(10));
                    }
                }
                catch (Exception ex) // throw exception in case of errors
                {
                    throw (ex);
                }
                finally
                {
                    con.Close();
                }
            }
            return employee; // return the result message
        }
        public int GetEmployeeCount() // returns count of total employees in database
        {
            int EmployeeCount = 0;
            // makes connection with DB to get employees count
            using (SqlConnection con = Configuration.GetConnection())
            {
                string query = $"Select Count(*) from Employees where Status=@Status;";
                // first try to execute retreive command
                try
                {
                    con.Open(); // opens Database Connection
                    SqlCommand command = new SqlCommand(query, con); // command to execute the query
                    command.Parameters.AddWithValue("@Status", "Active"); // add parameters
                    SqlDataReader sqlDataReader = command.ExecuteReader(); // Execute the query
                    if (sqlDataReader.Read()) // if employees data found
                    {
                        EmployeeCount= sqlDataReader.GetInt32(0);
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
            return EmployeeCount; // returns count
        }
    }
}