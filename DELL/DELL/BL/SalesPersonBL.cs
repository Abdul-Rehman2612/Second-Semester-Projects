using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DELL.BL
{
    internal class SalesPersonBL : EmployeeBL
    {
        public SalesPersonBL() { }
        public SalesPersonBL(string name, string username, string password, string email, DateTime dob, string address, string contact, string gender, string status, string designation, DateTime hireDate) : base(name, username, password, email, dob, address, contact, gender, status, designation, hireDate)
        {
        }
    }
}
