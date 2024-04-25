using DellLibrary.BL;
using DellLibrary.DL_Interfaces;
using DellLibrary.Utility;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Net.NetworkInformation;

namespace DellLibrary.DL.DB
{
    public class EmployeeDLDB : IUserDL, IEmployeeDL
    {
        public string AddEmployee(EmployeeBL user)
        {
            string message = Validations.IsValidNewUser(user);
            if (message == "True")
            {
                string query = "INSERT INTO Employees (Name, Username, Password, Email, DOB, Address, Contact, Gender, Status, Designation, HireDate) " +
                               "VALUES (@Name, @Username, @Password, @Email, @DOB, @Address, @Contact, @Gender, @Status, @Designation, @HireDate)";

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
                        command.Parameters.AddWithValue("@Designation", user.GetDesignation());
                        command.Parameters.AddWithValue("@HireDate", user.GetHireDate());

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
        public string UpdateEmployee(EmployeeBL user, string username, string email)
        {
            string message;

            bool isCEO = user.GetDesignation() == "CEO";

            message = Validations.IsValidUpdatedUser(user, username, email, isCEO);

            if (message == "True")
            {
                string query = "UPDATE Employees SET Name=@Name, Username=@Username, Password=@Password, Email=@Email, DOB=@DOB, Address=@Address, Contact=@Contact, Gender=@Gender WHERE Username=@user";

                using (SqlConnection con = Configuration.GetConnection())
                {
                    try
                    {
                        con.Open();
                        SqlCommand command = new SqlCommand(query, con);

                        command.Parameters.AddWithValue("@Name", user.GetName());
                        command.Parameters.AddWithValue("@Username", user.GetUsername());
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
        public string RemoveEmployee(string username)
        {
            string message = "";
            using (SqlConnection con = Configuration.GetConnection())
            {
                string query = $"DELETE Employees where Username=@Username;";
                try
                {
                    con.Open();
                    SqlCommand command = new SqlCommand(query, con);

                    command.Parameters.AddWithValue("@Username", username);

                    SqlDataReader sqlDataReader = command.ExecuteReader();
                    int rowAffected = sqlDataReader.RecordsAffected;
                    if (rowAffected>0)
                    {
                        message="True";
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
        public string DeactivateEmployeeAccount(string username)
        {
            string message = "";

            string query = "UPDATE Employees SET Status='Deactivated' WHERE Username=@username;";

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
        public string ActivateEmployeeAccount(string username)
        {
            string message = "";

            string query = "UPDATE Employees SET Status='Active' WHERE Username=@username;";

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
        public List<EmployeeBL> GetAllEmployees()
        {
            List<EmployeeBL> Employees = new List<EmployeeBL>();
            using (SqlConnection con = Configuration.GetConnection())
            {
                string query = $"Select * from Employees where Designation<>'CEO';";
                try
                {
                    con.Open();
                    SqlCommand command = new SqlCommand(query, con);
                    SqlDataReader sqlDataReader = command.ExecuteReader();

                    while (sqlDataReader.Read())
                    {
                        if (sqlDataReader.IsDBNull(11))
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
                catch (Exception e)
                {
                    throw (e);
                }
                finally
                {
                    con.Close();
                }
            }
            return Employees;
        }
        public EmployeeBL GetEmployeebyUsername(string username)
        {
            EmployeeBL employee = null;
            using (SqlConnection con = Configuration.GetConnection())
            {
                string query = $"Select * from Employees where Username=@username and designation!='CEO';";
                try
                {
                    con.Open();
                    SqlCommand command = new SqlCommand(query, con);
                    command.Parameters.AddWithValue("@Username", username);
                    SqlDataReader sqlDataReader = command.ExecuteReader();

                    while (sqlDataReader.Read())
                    {
                        if (sqlDataReader.IsDBNull(11))
                        {
                            employee = new EmployeeBL(sqlDataReader.GetString(0), username, sqlDataReader.GetString(2), sqlDataReader.GetString(3), sqlDataReader.GetDateTime(4), sqlDataReader.GetString(5), sqlDataReader.GetString(6), sqlDataReader.GetString(7), sqlDataReader.GetString(8), sqlDataReader.GetString(9), sqlDataReader.GetDateTime(10));
                        }
                        else
                        {
                            employee = new EmployeeBL(sqlDataReader.GetString(0), username, sqlDataReader.GetString(2), sqlDataReader.GetString(3), sqlDataReader.GetDateTime(4), sqlDataReader.GetString(5), sqlDataReader.GetString(6), sqlDataReader.GetString(7), sqlDataReader.GetString(8), sqlDataReader.GetString(9), sqlDataReader.GetDateTime(10), sqlDataReader.GetDateTime(11));
                        }
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
            return employee;
        }
        public List<EmployeeBL> GetAllEmployeesByStatus(string eStatus)
        {
            List<EmployeeBL> Employees = new List<EmployeeBL>();
            using (SqlConnection con = Configuration.GetConnection())
            {
                string query = $"Select * from Employees where Designation<>'CEO' and status = @estatus;";
                try
                {
                    con.Open();
                    SqlCommand command = new SqlCommand(query, con);
                    command.Parameters.AddWithValue("@estatus", eStatus);
                    SqlDataReader sqlDataReader = command.ExecuteReader();

                    while (sqlDataReader.Read())
                    {
                        if (sqlDataReader.IsDBNull(11))
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
                catch (Exception e)
                {
                    throw (e);
                }
                finally
                {
                    con.Close();
                }
            }
            return Employees;
        }
        public List<EmployeeBL> GetEmployeesByDesignation(string designation, string status)
        {
            List<EmployeeBL> Employees = new List<EmployeeBL>();
            using (SqlConnection con = Configuration.GetConnection())
            {
                string query = $"Select * from Employees where Designation=@designation and Status=@status;";
                try
                {
                    con.Open();
                    SqlCommand sqlCommand = new SqlCommand(query, con);
                    SqlCommand command = sqlCommand;
                    command.Parameters.AddWithValue("@designation", designation);
                    command.Parameters.AddWithValue("@status", status);

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
                        DateTime hireDate = sqlDataReader.GetDateTime(10);
                        EmployeeBL employee = new EmployeeBL(name, username, password, email, birthDate, address, contact, gender, status, designation, hireDate);
                        Employees.Add(employee);
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
            return Employees;
        }
        public bool UniqueAttributeCheck(string text, string attribute)
        {
            bool check = false;

            string Query = $"Select * from Employees where {attribute}='{text}';";
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
            EmployeeBL employee = null;

            string query = $"SELECT * FROM Employees WHERE Username COLLATE Latin1_General_BIN = @Username AND Password COLLATE Latin1_General_BIN = @Password AND Status='Active';";
            using (SqlConnection con = Configuration.GetConnection())
            {
                try
                {
                    con.Open();
                    SqlCommand command = new SqlCommand(query, con);

                    command.Parameters.AddWithValue("@Username", user.GetUsername());
                    command.Parameters.AddWithValue("@Password", user.GetPassword());
                    SqlDataReader sqlDataReader = command.ExecuteReader();
                    if (sqlDataReader.Read() && sqlDataReader.IsDBNull(11))
                    {
                        string designation = sqlDataReader.GetString(9);
                        employee = new EmployeeBL(sqlDataReader.GetString(0), sqlDataReader.GetString(1), sqlDataReader.GetString(2), sqlDataReader.GetString(3), sqlDataReader.GetDateTime(4), sqlDataReader.GetString(5), sqlDataReader.GetString(6), sqlDataReader.GetString(7), sqlDataReader.GetString(8), sqlDataReader.GetString(9), sqlDataReader.GetDateTime(10));
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
            return employee;
        }
        public int GetEmployeeCount()
        {
            int EmployeeCount = 0;
            using (SqlConnection con = Configuration.GetConnection())
            {
                string query = $"Select Count(*) from Employees;";
                try
                {
                    con.Open();
                    SqlCommand command = new SqlCommand(query, con);
                    command.Parameters.AddWithValue("@Status", "Active");
                    SqlDataReader sqlDataReader = command.ExecuteReader();
                    if (sqlDataReader.Read())
                    {
                        EmployeeCount= sqlDataReader.GetInt32(0);
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
            return EmployeeCount;
        }
    }
}
