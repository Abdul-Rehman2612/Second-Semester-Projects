using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace DELL.BL
{
    internal class CustomerBL: UserBL
    {
        public CustomerBL(string name, string username, string password, string email, string dob, string address, string contact, string gender, string status): base(name, username, password, email, dob, address, contact, gender, status) 
        {}
        public CustomerBL(string username, string password) : base(username, password)
        {}
    }
}
