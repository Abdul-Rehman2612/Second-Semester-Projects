using Dell.UI;
using DELL.BL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DELL.DL
{
    internal class UserDL
    {
        readonly static List<UserBL> users = new List<UserBL>();
        public static string AddUserToDB(UserBL User,bool customer)
        {
            users.Add(User);
            string Query;
            string Status = "True";
            if (customer)
            {
                CustomerBL user = (CustomerBL)User;
                Query = $"INSERT INTO Customers (Name, Username, Password, Email, DOB, Address, Contact, Gender, Status) " +
                   $"VALUES ('{user.Name}', '{user.Username}', '{user.Password}', '{user.Email}', '{user.Dob}', " +
                   $"'{user.Address}', '{user.Contact}', '{user.Gender}', '{"Active"}')";
            }
            else
            {
                EmployeeBL user = (EmployeeBL)User;
                Query = $"INSERT INTO Employees (Name, Username, Password, Email, DOB, Address, Contact, Gender, Status,Designation,HireDate) " +
                   $"VALUES ('{user.Name}', '{user.Username}', '{user.Password}', '{user.Email}', '{user.Dob}', " +
                   $"'{user.Address}', '{user.Contact}', '{user.Gender}', '{"Active"}','{user.Designation}','{user.HireDate})";
            }
            using(var Con=Configuration.GetInstance().GetConnection())
            {
                try
                {
                    Con.Open();
                    SqlCommand command = new SqlCommand(Query, Con);
                    SqlDataReader sqlDataReader = command.ExecuteReader();
                    int rowAffected = sqlDataReader.RecordsAffected;
                    if(rowAffected>0)
                    {
                        Status="True";
                    }
                }
                catch(Exception e)
                {
                    Status=e.Message;
                }
                finally
                { Con.Close(); }
            }
            return Status;
        }
    
     }
}
