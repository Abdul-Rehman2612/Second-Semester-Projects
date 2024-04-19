using DellLibrary.DL_Interfaces;
using DellLibrary.Utility;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DellLibrary.DL.DB
{
    public class ProductDLDB: IProductDL
    {
        public int GetProductCount()
        {
            int ProductCount = 0;
            // makes connection with DB to get products count
            using (SqlConnection con = Configuration.GetConnection())
            {
                string query = $"Select Count(ProductID) from Products;";
                // first try to execute retreive command
                try
                {
                    con.Open(); // opens Database Connection
                    SqlCommand command = new SqlCommand(query, con); // command to execute the query
                    //command.Parameters.AddWithValue("@Status", "Active"); // add parameters
                    SqlDataReader sqlDataReader = command.ExecuteReader(); // Execute the query
                    if (sqlDataReader.Read()) // if products data found
                    {
                        ProductCount = sqlDataReader.GetInt32(0);
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
            return ProductCount; // returns products count
        }
    }
}
