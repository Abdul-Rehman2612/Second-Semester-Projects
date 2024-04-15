using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DELL.BL
{
    internal class ProductBL
    {
        private int productID;
        private string productName;
        private string productDetails;
        private double productPrice;
        private int unitInStock;
        private string productStatus;
        public ProductBL(int productID, string productName, string productDetails, double productPrice, int unitInStock, string productStatus)
        {
            this.productID = productID;
            this.productName = productName;
            this.productDetails = productDetails;
            this.productPrice = productPrice;
            this.unitInStock = unitInStock;
            this.productStatus = productStatus;
        }
        public ProductBL(string productName, string productDetails, double productPrice, int unitInStock, string productStatus)
        {
            this.productName = productName;
            this.productDetails = productDetails;
            this.productPrice = productPrice;
            this.unitInStock = unitInStock;
            this.productStatus = productStatus;
        }
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
