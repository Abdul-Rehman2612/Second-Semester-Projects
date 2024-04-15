using DELL.BL;
using DELL.DL_Interface;
using DELL.Utility;
using System;
using System.Data.SqlClient;

namespace DELL.DL.DB
{
    internal class EmployeeDLDB : IUserDL, IEmployeeDL
    {
        private static CeoBL Ceo = new CeoBL(); // CEO object
        private static TechnicianBL Technician = new TechnicianBL(); // Technician Object
        private static SalesPersonBL SalesPerson = new SalesPersonBL(); // SalesPerson Object
        public string AddEmployee(EmployeeBL user)
        {
            string Status = Validations.IsValidUser(user);
            if (Status=="True")
            {
                string Query = $"INSERT INTO Employees (Name, Username, Password, Email, DOB, Address, Contact, Gender, Status,Designation,HireDate) " +
                       $"VALUES ('{user.GetName()}', '{user.GetUsername()}', '{user.GetPassword()}', '{user.GetEmail()}', '{user.GetDob()}', " +
                       $"'{user.GetAddress()}', '{user.GetContact()}', '{user.GetGender()}', '{user.GetStatus()}','{user.GetDesignation()}','{user.GetHireDate()})";
                using (SqlConnection con = Configuration.GetConnection())
                {
                    try
                    {
                        con.Open();
                        SqlCommand command = new SqlCommand(Query, con);
                        SqlDataReader sqlDataReader = command.ExecuteReader();
                        int rowAffected = sqlDataReader.RecordsAffected;
                        if (rowAffected>0)
                        {
                            Status="True";
                        }
                    }
                    catch (Exception e)
                    {
                        Status=e.Message;
                    }
                    finally
                    {
                        con.Close();
                    }
                }
            }
            return Status;
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
            string query = $"SELECT * FROM Employees WHERE Username COLLATE Latin1_General_BIN = @Username AND Password COLLATE Latin1_General_BIN = @Password;";
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
                    if (sqlDataReader.Read()) // if user was found
                    {
                        if (sqlDataReader.IsDBNull(11)) // if resignation date is null
                        {
                            string designation = sqlDataReader.GetString(9);
                            if (designation=="CEO") // if user is CEO
                            {
                                Ceo = new CeoBL(sqlDataReader.GetString(0), sqlDataReader.GetString(1), sqlDataReader.GetString(2), sqlDataReader.GetString(3), sqlDataReader.GetDateTime(4), sqlDataReader.GetString(5), sqlDataReader.GetString(6), sqlDataReader.GetString(7), sqlDataReader.GetString(8), sqlDataReader.GetString(9), sqlDataReader.GetDateTime(10));
                            }
                            else if(designation=="Technician") // if user is Technician
                            {
                                Technician = new TechnicianBL(sqlDataReader.GetString(0), sqlDataReader.GetString(1), sqlDataReader.GetString(2), sqlDataReader.GetString(3), sqlDataReader.GetDateTime(4), sqlDataReader.GetString(5), sqlDataReader.GetString(6), sqlDataReader.GetString(7), sqlDataReader.GetString(8), sqlDataReader.GetString(9), sqlDataReader.GetDateTime(10));
                            }
                            else if(designation=="SalesPerson") // if user is SalesPerson
                            {
                                SalesPerson = new SalesPersonBL(sqlDataReader.GetString(0), sqlDataReader.GetString(1), sqlDataReader.GetString(2), sqlDataReader.GetString(3), sqlDataReader.GetDateTime(4), sqlDataReader.GetString(5), sqlDataReader.GetString(6), sqlDataReader.GetString(7), sqlDataReader.GetString(8), sqlDataReader.GetString(9), sqlDataReader.GetDateTime(10));
                            }
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
