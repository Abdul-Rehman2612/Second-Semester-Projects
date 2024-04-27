using DellLibrary.BL;
using System.Collections.Generic;

namespace DellLibrary.DL_Interfaces
{
    public interface IOrderDetailsDL
    {
        List<OrderDetailsBL> GetOrderDetailsForOrder(int id);
        void AddOrderDetails(OrderBL order);
    }
}
