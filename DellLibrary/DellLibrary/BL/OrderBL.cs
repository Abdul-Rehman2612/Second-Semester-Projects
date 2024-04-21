using System;
using System.Collections.Generic;

namespace DellLibrary.BL
{
    public class OrderBL
    {
        private int orderID;
        readonly private string orderType;
        readonly private EmployeeBL employee;
        readonly private DateTime orderDate;
        private double totalPrice;
        private List<OrderDetailsBL> orderDetails = new List<OrderDetailsBL>();
        public OrderBL(int orderID, string orderType, DateTime orderDate,EmployeeBL employee,double totalPrice)
        {
            this.orderID = orderID;
            this.orderType = orderType;
            this.orderDate = orderDate;
            this.employee = employee;
            this.totalPrice = totalPrice;
        }
        public OrderBL(int orderID, string orderType, DateTime orderDate, double totalPrice)
        {
            this.orderID = orderID;
            this.orderType = orderType;
            this.orderDate = orderDate;
            this.employee = null;
            this.totalPrice = totalPrice;
        }
        public OrderBL(OrderBL order)
        {
            orderID = order.orderID;
            orderType = order.orderType;
            orderDate = order.orderDate;
            foreach(OrderDetailsBL o in order.orderDetails)
            {
                orderDetails.Add(new OrderDetailsBL(o));
            }
        }
        // public OrderBL(string orderType, DateTime orderDate)
        // {
        //     this.orderType = orderType;
        //     this.orderDate = orderDate;
        //     employee = null;
        //     totalPrice = 0;
        // }
        // public OrderBL(string orderType,DateTime orderDate,EmployeeBL employee)
        // {
        //     this.orderType = orderType;
        //     this.orderDate = orderDate;
        //     this.employee = employee;
        //     totalPrice = CalculateTotalPrice();
        // }
        // private double CalculateTotalPrice()
        // {
        //     double t = 0;
        //     foreach(OrderDetailsBL od in orderDetails)
        //     {
        //         t+=od.GetPrice();
        //     }
        //     return t;
        // }
        // public void SetOrderID(int value) { orderID = value; }
        // public EmployeeBL GetEmployee() { return employee; }
        // public int GetOrderID() { return orderID; }
        // public double GetTotalPrice() { return totalPrice; }
        // public string GetCustomerType() { return orderType; }
        // public DateTime GetOrderDate() { return orderDate; }
    }
}
