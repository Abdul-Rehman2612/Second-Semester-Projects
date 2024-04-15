using DELL.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DELL.DL_Interface
{
    internal interface IUserDL
    {
        bool UniqueAttributeCheck(string text, string attribute); // checks for unique attributes
        string UserSignIn(UserBL user); // checks for a user to sign in
    }
}
