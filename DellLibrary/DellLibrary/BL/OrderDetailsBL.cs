using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DellLibrary.BL
{
    public class OrderDetailsBL
    {
        private ProductBL product;
        private int quantity;
        private double price;
        // public OrderDetailsBL(ProductBL product,int quantity)
        // {
        //     this.product = product;
        //     this.quantity = quantity;
        //     price = quantity * product.GetProductPrice();
        // }
        public OrderDetailsBL(ProductBL product,int quantity,double price)
        {
            this.product = product;
            this.quantity = quantity;
            this.price = price;
        }
        public OrderDetailsBL(OrderDetailsBL o)
        {
            product = o.product;
            quantity = o.quantity;
            price = o.price;
        }
        // public double GetPrice() { return price; }
    }
}
