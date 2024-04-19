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
        int GetOrderCount();
        List<OrderBL> GetOrdersForUser(string username);
    }
}
