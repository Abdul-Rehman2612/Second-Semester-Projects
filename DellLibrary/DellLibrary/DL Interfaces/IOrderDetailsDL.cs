using DellLibrary.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DellLibrary.DL_Interfaces
{
    public interface IOrderDetailsDL
    {
        List<OrderDetailsBL> GetOrderDetailsForOrder(int id); // returns the list or items in an order against its order id
    }
}
