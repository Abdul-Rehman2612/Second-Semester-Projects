using System.Data.SqlClient;
using System;
namespace DELL.Utility
{
    class Configuration
    {
        public static SqlConnection GetConnection()
        {
            return new SqlConnection("Server=(local);Database=Dell;Trusted_Connection=True");
        }
    }
}