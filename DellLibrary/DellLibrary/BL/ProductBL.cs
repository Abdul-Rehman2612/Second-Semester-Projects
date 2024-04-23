using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DellLibrary.BL
{
    public class ProductBL
    {
        private int productID; // Unique identifier for the product
        private string productName; // Name of the product
        private string productDetails; // Details of the product
        private double productPrice; // Price of the product
        private int unitInStock; // Units in stock
        private string productStatus; // Status of the product
                                      // Full constructor
        public ProductBL(int productID, string productName, string productDetails, double productPrice, int unitInStock, string productStatus)
        {
            this.productID = productID;
            this.productName = productName;
            this.productDetails = productDetails;
            this.productPrice = productPrice;
            this.unitInStock = unitInStock;
            this.productStatus = productStatus;
        }
        // Constructor without product ID
        public ProductBL(string productName, string productDetails, double productPrice, int unitInStock, string productStatus)
        {
            this.productName = productName;
            this.productDetails = productDetails;
            this.productPrice = productPrice;
            this.unitInStock = unitInStock;
            this.productStatus = productStatus;
        }
        // Getters and setters for product properties
        public int GetProductID() { return productID; }
        public string GetProductName() { return productName; }
        public void SetProductName(string value) { productName = value; }
        public string GetProductDetails() { return productDetails; }
        public void SetProductDetails(string value) { productDetails = value; }
        public double GetProductPrice() { return productPrice; }
        public void SetProductPrice(double value) { productPrice = value; }
        public int GetUnitInStock() { return unitInStock; }
        public void SetUnitInStock(int value) { unitInStock = value; }
        public string GetProductStatus() { return productStatus; }
        public void SetProductStatus(string value) { productStatus = value; }

    }
}
