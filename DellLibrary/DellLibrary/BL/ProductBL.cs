using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DellLibrary.BL
{
    public class ProductBL
    {
        private int productID; 
        private string productName;
        private string productDetails; 
        private double productPrice;
        private int unitInStock; 
        

        public ProductBL(int productID, string productName, string productDetails, double productPrice, int unitInStock)
        {
            this.productID = productID;
            this.productName = productName;
            this.productDetails = productDetails;
            this.productPrice = productPrice;
            this.unitInStock = unitInStock;
        }

        public ProductBL(string productName, string productDetails, double productPrice, int unitInStock)
        {
            this.productName = productName;
            this.productDetails = productDetails;
            this.productPrice = productPrice;
            this.unitInStock = unitInStock;
        }

        public int GetProductID() { return productID; }
        public string GetProductName() { return productName; }
        public void SetProductName(string value) { productName = value; }
        public string GetProductDetails() { return productDetails; }
        public void SetProductDetails(string value) { productDetails = value; }
        public double GetProductPrice() { return productPrice; }
        public void SetProductPrice(double value) { productPrice = value; }
        public int GetUnitsInStock() { return unitInStock; }
        public void SetUnitsInStock(int value) { unitInStock = value; }

    }
}
