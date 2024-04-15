using System;
using System.Collections.Generic;

namespace DELL.BL
{
    internal class OrderBL
    {
        private int orderID;
        readonly private string customerType;
        readonly private DateTime orderDate;
        private List<OrderDetailsBL> orderDetails= new List<OrderDetailsBL>();
        public OrderBL(string customerType, DateTime orderDate)
        {
            this.customerType=customerType;
            this.orderDate=orderDate;
        }
        public OrderBL(int orderID, string customerType, DateTime orderDate)
        {
            this.orderID = orderID;
            this.customerType = customerType;
            this.orderDate = orderDate;
        }
        public OrderBL(OrderBL order)
        {
            this.orderID = order.orderID;
            this.customerType = order.customerType;
            this.orderDate = order.orderDate;
            foreach(OrderDetailsBL o in order.orderDetails)
            {
                this.orderDetails.Add(new OrderDetailsBL(o));
            }
        }
        public void SetOrderID(int value) { orderID=value; }
        public int GetOrderID() { return orderID; }
        public string GetCustomerType() { return customerType; }
        public DateTime GetOrderDate() { return orderDate; }
    }
}
