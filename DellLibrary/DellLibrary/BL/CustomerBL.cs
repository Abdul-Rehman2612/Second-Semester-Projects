using System;
using System.Collections.Generic;


namespace DellLibrary.BL
{
    public class CustomerBL: UserBL
    {
        private List<OrderBL> orderList = new List<OrderBL>();
        public CustomerBL() { }
        public CustomerBL(string name, string username, string password, string email, DateTime dob, string address, string contact, string gender, string status): base(name, username, password, email, dob, address, contact, gender, status) {}
        public CustomerBL(string username, string password) : base(username, password) {}
        public void AddOrder(OrderBL order)
        {
            orderList.Add(new OrderBL(order));
        }
        public void AddOrdersList(List<OrderBL> orders)
        {
            foreach (OrderBL order in orders)
            {
                orderList.Add(new OrderBL(order));
            }
        }
        public List<OrderBL> GetOrders() { return orderList; }
    }
}
