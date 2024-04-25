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
        public OrderBL(int orderID, string orderType, DateTime orderDate, EmployeeBL employee, double totalPrice, List<OrderDetailsBL> orderDetails)
        {
            this.orderID = orderID;
            this.orderType = orderType;
            this.orderDate = orderDate;
            this.employee = employee;
            this.totalPrice = totalPrice;
            foreach (OrderDetailsBL orderDetail in orderDetails)
            {
                this.orderDetails.Add(new OrderDetailsBL(orderDetail));
            }
        }
        public OrderBL(int orderID, string orderType, DateTime orderDate, double totalPrice, List<OrderDetailsBL> orderDetails)
        {
            this.orderID = orderID;
            this.orderType = orderType;
            this.orderDate = orderDate;
            employee = null;
            this.totalPrice = totalPrice;
            foreach (OrderDetailsBL orderDetail in orderDetails)
            {
                this.orderDetails.Add(new OrderDetailsBL(orderDetail));
            }
        }
        public OrderBL(string orderType, DateTime orderDate, EmployeeBL employee, List<OrderDetailsBL> orderDetails)
        {
            this.orderType=orderType;
            this.orderDate=orderDate;
            this.employee = employee;
            foreach (OrderDetailsBL orderDetail in orderDetails)
            {
                this.orderDetails.Add(new OrderDetailsBL(orderDetail));
            }
            totalPrice=CalculateTotalPrice();
        }
        public OrderBL(string orderType, DateTime orderDate, List<OrderDetailsBL> orderDetails)
        {
            this.orderType=orderType;
            this.orderDate=orderDate;
            this.employee = null;
            foreach (OrderDetailsBL orderDetail in orderDetails)
            {
                this.orderDetails.Add(new OrderDetailsBL(orderDetail));
            }
            totalPrice=CalculateTotalPrice();
        }
        public OrderBL(int orderID, string orderType, DateTime orderDate, EmployeeBL employee, double totalPrice)
        {
            this.orderID=orderID;
            this.orderType=orderType;
            this.employee=employee;
            this.orderDate=orderDate;
            this.totalPrice=totalPrice;
        }

        public OrderBL(OrderBL order)
        {
            orderID = order.orderID;
            orderType = order.orderType;
            orderDate = order.orderDate;
            employee = order.employee;
            totalPrice = order.totalPrice;
            foreach (OrderDetailsBL o in order.orderDetails)
            {
                orderDetails.Add(new OrderDetailsBL(o));
            }
        }
        private double CalculateTotalPrice()
        {
            double t = 0;
            foreach (OrderDetailsBL od in orderDetails)
            {
                t+=od.GetPrice();
            }
            return t;
        }
        public void SetOrderID(int value) { orderID = value; }
        public EmployeeBL GetEmployee() { return employee; }
        public int GetOrderID() { return orderID; }
        public double GetTotalPrice() { return totalPrice; }
        public string GetOrderType() { return orderType; }
        public DateTime GetOrderDate() { return orderDate; }
        public List<OrderDetailsBL> GetOrderDetails() { return orderDetails; }
    }
}
