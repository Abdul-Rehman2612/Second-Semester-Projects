using DellLibrary.BL;
using System.Collections.Generic;

namespace DellLibrary.DL_Interfaces
{
    public interface IProductDL
    {
        int GetProductCount();
        ProductBL GetProductByProductID(int id);
        string AddProduct(ProductBL product);
        string UpdateProduct(ProductBL product, string productName);
        List<ProductBL> GetAllProducts();
        string DeleteProduct(int ProductID);
        string CheckProductName(string ProductName);
    }
}
