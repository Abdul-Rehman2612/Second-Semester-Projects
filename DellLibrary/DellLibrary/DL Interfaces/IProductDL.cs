using DellLibrary.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DellLibrary.DL_Interfaces
{
    public interface IProductDL
    {
        int GetProductCount(); // returns products count
        ProductBL GetProductByProductID(int id); // returns product
    }
}
