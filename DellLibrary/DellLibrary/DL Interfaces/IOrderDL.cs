using DellLibrary.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DellLibrary.DL_Interfaces
{
    public interface IOrderDL
    {
        int GetOrderCount(); // returns the count of total orders
        List<OrderBL> GetOrdersForUser(string username); // returns the list of orders for a user
        int GetOrderCountForEmployee(string username); // returns orders count where employee username found
        int GetOrderCountForCustomer(string username); // returns orders count where customer username found

    }
}
