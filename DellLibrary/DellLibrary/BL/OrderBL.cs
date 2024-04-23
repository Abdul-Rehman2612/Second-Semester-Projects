using System;
using System.Collections.Generic;

namespace DellLibrary.BL
{
    public class OrderBL
    {
        private int orderID; // Unique identifier
        readonly private string orderType; // Type of order
        readonly private EmployeeBL employee; // Associated employee
        readonly private DateTime orderDate; // Order date
        private double totalPrice; // Total price
        private List<OrderDetailsBL> orderDetails = new List<OrderDetailsBL>(); // Order details list
        // Full constructor with an employee
        public OrderBL(int orderID, string orderType, DateTime orderDate, EmployeeBL employee, double totalPrice)
        {
            this.orderID = orderID;
            this.orderType = orderType;
            this.orderDate = orderDate;
            this.employee = employee;
            this.totalPrice = totalPrice;
        }
        // Constructor without an employee
        public OrderBL(int orderID, string orderType, DateTime orderDate, double totalPrice)
        {
            this.orderID = orderID;
            this.orderType = orderType;
            this.orderDate = orderDate;
            employee = null; // No employee associated with this order
            this.totalPrice = totalPrice;
        }
        // Copy constructor
        public OrderBL(OrderBL order)
        {
            orderID = order.orderID;
            orderType = order.orderType;
            orderDate = order.orderDate;
            employee = order.employee; // Shallow copy of the employee object
            totalPrice = order.totalPrice;
            foreach (OrderDetailsBL o in order.orderDetails)
            {
                orderDetails.Add(new OrderDetailsBL(o)); // Deep copy of order details
            }
        }
        // Method to add a list of order details to the order
        public void AddOrderDetailsList(List<OrderDetailsBL> orderDetails)
        {
            foreach (OrderDetailsBL orderDetail in orderDetails)
            {
                this.orderDetails.Add(new OrderDetailsBL(orderDetail)); // Deep copy of order details
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
        public EmployeeBL GetEmployee() { return employee; } // Get associated employee
        public int GetOrderID() { return orderID; } // Get unique identifier
        public double GetTotalPrice() { return totalPrice; } // Get total price
        public string GetOrderType() { return orderType; } // Get order type
        public DateTime GetOrderDate() { return orderDate; } // Get order date
    }
}
