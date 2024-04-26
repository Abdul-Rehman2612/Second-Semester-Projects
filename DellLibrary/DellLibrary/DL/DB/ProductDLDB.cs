using DellLibrary.BL;
using DellLibrary.DL_Interfaces;
using DellLibrary.Utility;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DellLibrary.DL.DB
{
    public class ProductDLDB : IProductDL
    {
        public int GetProductCount()
        {
            int ProductCount = 0;
            using (SqlConnection con = Configuration.GetConnection())
            {
                string query = $"Select Count(ProductID) from Products;";
                try
                {
                    con.Open();
                    SqlCommand command = new SqlCommand(query, con);
                    SqlDataReader sqlDataReader = command.ExecuteReader();
                    if (sqlDataReader.Read())
                    {
                        ProductCount = sqlDataReader.GetInt32(0);
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
            return ProductCount;
        }

        public ProductBL GetProductByProductID(int id)
        {
            ProductBL product = null;
            string query = "SELECT * from Products where ProductID=@id";
            using (SqlConnection con = Configuration.GetConnection())
            {
                try
                {
                    con.Open();
                    SqlCommand command = new SqlCommand(query, con);
                    command.Parameters.AddWithValue("@id", id);
                    SqlDataReader sqlDataReader = command.ExecuteReader();
                    while (sqlDataReader.Read())
                    {
                        int productID = sqlDataReader.GetInt32(0);
                        string productName = sqlDataReader.GetString(1);
                        string productDetails = sqlDataReader.GetString(2);
                        double productPrice = sqlDataReader.GetDouble(3);
                        int unitsInStock = sqlDataReader.GetInt32(4);
                        product = new ProductBL(productID, productName, productDetails, productPrice, unitsInStock);
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
            return product;
        }

        public List<ProductBL> GetAllProducts()
        {
            List<ProductBL> products = new List<ProductBL>();
            string query = "SELECT * from Products";
            using (SqlConnection con = Configuration.GetConnection())
            {
                try
                {
                    con.Open();
                    SqlCommand command = new SqlCommand(query, con);
                    SqlDataReader sqlDataReader = command.ExecuteReader();
                    while (sqlDataReader.Read())
                    {
                        int productID = sqlDataReader.GetInt32(0);
                        string productName = sqlDataReader.GetString(1);
                        string productDetails = sqlDataReader.GetString(2);
                        double productPrice = sqlDataReader.GetDouble(3);
                        int unitsInStock = sqlDataReader.GetInt32(4);
                        ProductBL product = new ProductBL(productID, productName, productDetails, productPrice, unitsInStock);
                        products.Add(product);
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
            return products;
        }

        public string AddProduct(ProductBL product)
        {
            string message = Validations.IsValidNewProduct(product);
            if (message == "True")
            {
                string query = "INSERT into Products(ProductName,Details,UnitPrice,UnitsInStock) " +
                               "OUTPUT INSERTED.ProductID " +
                               "VALUES(@ProductName,@ProductDetails,@ProductPrice,@UnitsInStock);";

                using (SqlConnection con = Configuration.GetConnection())
                {
                    try
                    {
                        con.Open();
                        SqlCommand command = new SqlCommand(query, con);

                        command.Parameters.AddWithValue("@ProductName", product.GetProductName());
                        command.Parameters.AddWithValue("@ProductDetails", product.GetProductDetails());
                        command.Parameters.AddWithValue("@ProductPrice", product.GetProductPrice());
                        command.Parameters.AddWithValue("@UnitsInStock", product.GetUnitsInStock());

                        int i = (int)command.ExecuteScalar();
                        message = i.ToString();
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

        public string UpdateProduct(ProductBL product, string productName)
        {
            string message = Validations.IsValidUpdatedProduct(product, productName);
            if (message == "True")
            {
                string query = "UPDATE Products SET " +
                               "ProductName = @ProductName, " +
                               "Details = @ProductDetails, " +
                               "UnitPrice = @ProductPrice, " +
                               "UnitsInStock = @UnitsInStock " +
                               "WHERE ProductID = @ProductID;";

                using (SqlConnection con = Configuration.GetConnection())
                {
                    try
                    {
                        con.Open();
                        SqlCommand command = new SqlCommand(query, con);

                        command.Parameters.AddWithValue("@UnitsInStock", product.GetUnitsInStock());
                        command.Parameters.AddWithValue("@ProductName", product.GetProductName());
                        command.Parameters.AddWithValue("@ProductDetails", product.GetProductDetails());
                        command.Parameters.AddWithValue("@ProductPrice", product.GetProductPrice());
                        command.Parameters.AddWithValue("@ProductID", product.GetProductID());

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
        public void UpdateProductStock(ProductBL product, int u)
        {

            string query = "UPDATE Products SET " +
                           "UnitsInStock = @UnitsInStock " +
                           "WHERE ProductID = @ProductID;";

            using (SqlConnection con = Configuration.GetConnection())
            {
                try
                {
                    con.Open();
                    SqlCommand command = new SqlCommand(query, con);

                    command.Parameters.AddWithValue("@UnitsInStock", product.GetUnitsInStock()-u);
                    command.Parameters.AddWithValue("@ProductID", product.GetProductID());

                    int rowsAffected = command.ExecuteNonQuery();

                }
                catch (Exception)
                {
                }
                finally
                {
                    con.Close();
                }
            }
        }

        public string DeleteProduct(int ProductID)
        {
            string message = null;
            string query = "Delete Products where productID=@ProductID";

            using (SqlConnection con = Configuration.GetConnection())
            {
                try
                {
                    con.Open();
                    SqlCommand command = new SqlCommand(query, con);
                    command.Parameters.AddWithValue("@ProductID", ProductID);
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

        public string CheckProductName(string ProductName)
        {
            string message = "True";
            string query = "SELECT * from Products where ProductName=@id";
            using (SqlConnection con = Configuration.GetConnection())
            {
                try
                {
                    con.Open();
                    SqlCommand command = new SqlCommand(query, con);
                    command.Parameters.AddWithValue("@id", ProductName);
                    SqlDataReader sqlDataReader = command.ExecuteReader();
                    if (sqlDataReader.Read())
                    {
                        message = "";
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
            return message;
        }
    }
}
