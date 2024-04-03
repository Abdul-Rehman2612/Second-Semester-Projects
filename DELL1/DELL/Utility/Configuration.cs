using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Dell.UI
{
    class Configuration
    {
        readonly String ConnectionStr = @"Data Source=(local);Database=Dell;Integrated Security=True";
        readonly SqlConnection con;
        private static Configuration _instance;
        public static Configuration GetInstance()
        {
            if (_instance == null)
                _instance = new Configuration();
            return _instance;
        }
        private Configuration()
        {
            con = new SqlConnection(ConnectionStr);
        }
        public SqlConnection GetConnection()
        {
            return con;
        }
    }
}