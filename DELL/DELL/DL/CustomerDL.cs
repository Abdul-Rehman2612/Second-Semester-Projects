using DELL.BL;
using DELL.Utility;
using System;
using System.Data.SqlClient;

namespace DELL.DL
{
    internal class CustomerDL : IUserDL
    {
        public string AddUser(UserBL User)
        {
            string Status = Validations.IsValidUser(User);
            if (Status=="True")
            {
                string Query;
                CustomerBL user = (CustomerBL)User;
                Query = $"INSERT INTO Customers (Name, Username, Password, Email, DOB, Address, Contact, Gender, Status) " +
                   $"VALUES ('{user.Name}', '{user.Username}', '{user.Password}', '{user.Email}', '{user.Dob}', " +
                   $"'{user.Address}', '{user.Contact}', '{user.Gender}', '{user.Status}')";
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
        //public static string RemoveUser(UserBL user);
        //public static string UpdateUser(UserBL user);
        //public static List<UserBL> GetAllUsers();
        public bool UniqueAttributeCheck(string text, string attribute)
        {
            bool check = false;
            string Query = "Select * from Customers where "+attribute+"='"+text+"';";
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
                }
                finally
                {
                    con.Close();
                }
            }
            return check;
        }
        public bool UserSignIn(UserBL user)
        {
            bool check = false;
            string Query = "Select * from Customers where Username='"+user.Username+"' and Password='"+user.Password+"';\n Select * from Employees where Username='"+user.Username+"' and Password='"+user.Password+"';";
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
                }
                finally
                {
                    con.Close();
                }
            }
            return true;
        }
    }
}
