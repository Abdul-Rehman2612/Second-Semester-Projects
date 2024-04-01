using DELL.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DELL.DL
{
    internal class UserDL
    {
        static List<UserBL> users = new List<UserBL>();
        public static bool AddUser(UserBL user,bool customer)
        {
            if (customer)
            {
                users.Add(user);
            }
            return true;
        }
    
     }
}
