using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DellLibrary.BL
{
    public class OrderDetailsBL
    {
        private ProductBL product; // Associated product
        private int quantity; // Product quantity
        private double price; // Product price
        public OrderDetailsBL(ProductBL product,int quantity)
        {
            this.product = product;
            this.quantity = quantity;
            price = quantity * product.GetProductPrice();
        }
        public OrderDetailsBL(ProductBL product, int quantity, double price)
        {
            this.product = product; // Set product
            this.quantity = quantity; // Set quantity
            this.price = price; // Set price
        }
        public OrderDetailsBL(OrderDetailsBL o)
        {
            product = o.product; // Copy product
            quantity = o.quantity; // Copy quantity
            price = o.price; // Copy price
        }
        public void AddQuantity(int quantity)
        {
            this.quantity += quantity;
            UpdatePrice();
        }
        public void UpdatePrice()
        {
            price=quantity * product.GetProductPrice();
        }
        public double GetPrice() { return price; }
        public ProductBL GetProduct() { return product; }
        public int GetQuantity() { return quantity; }
        public void SetQuantity(int quantity)
        {
            this.quantity=quantity;
        }
    }
}
