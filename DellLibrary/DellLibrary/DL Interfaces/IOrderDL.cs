using DellLibrary.BL;
using System.Collections.Generic;

namespace DellLibrary.DL_Interfaces
{
    public interface IOrderDL
    {
        int GetOrderCount();
        List<OrderBL> GetOrdersForUser(string username);
        int GetOrderCountForEmployee(string username);
        int GetOrderCountForCustomer(string username);
        int AddOrder(OrderBL order, string username);
    }
}
