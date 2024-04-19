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
        private List<OrderDetailsBL> orderDetails = new List<OrderDetailsBL>();
        public OrderBL(string orderType, DateTime orderDate)
        {
            this.orderType = orderType;
            this.orderDate = orderDate;
            employee = null;
        }
        public OrderBL(string orderType,DateTime orderDate,EmployeeBL employee)
        {
            this.orderType = orderType;
            this.orderDate = orderDate;
            this.employee = employee;
        }
        public OrderBL(int orderID, string orderType, DateTime orderDate,EmployeeBL employee)
        {
            this.orderID = orderID;
            this.orderType = orderType;
            this.orderDate = orderDate;
            this.employee = employee;
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
        public void SetOrderID(int value) { orderID = value; }
        public EmployeeBL GetEmployee() { return employee; }
        public int GetOrderID() { return orderID; }
        public string GetCustomerType() { return orderType; }
        public DateTime GetOrderDate() { return orderDate; }
    }
}
