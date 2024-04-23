using System;
using System.Collections.Generic;


namespace DellLibrary.BL
{
    public class CustomerBL: UserBL
    {
        private List<OrderBL> orderList = new List<OrderBL>(); // List of orders

        public CustomerBL() { } // Default constructor

        // Constructor with full details
        public CustomerBL(string name, string username, string password, string email, DateTime dob, string address, string contact, string gender, string status) : base(name, username, password, email, dob, address, contact, gender, status) { }

        // Constructor without status
        public CustomerBL(string name, string username, string password, string email, DateTime dob, string address, string contact, string gender) : base(name, username, password, email, dob, address, contact, gender) { }

        // Constructor with only username and password
        public CustomerBL(string username, string password) : base(username, password) { }

        public void AddOrder(OrderBL order) // Add single order
        {
            orderList.Add(new OrderBL(order));
        }
        public void AddOrdersList(List<OrderBL> orders) // Add multiple orders
        {
            foreach (OrderBL order in orders)
            {
                orderList.Add(new OrderBL(order));
            }
        }

        public List<OrderBL> GetOrders() { return orderList; } // Get orders

    }
}
