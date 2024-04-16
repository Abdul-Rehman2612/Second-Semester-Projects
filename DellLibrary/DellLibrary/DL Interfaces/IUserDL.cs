using DellLibrary.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DellLibrary.DL_Interfaces
{
    public interface IUserDL
    {
        bool UniqueAttributeCheck(string text, string attribute); // checks for unique attributes
        string UserSignIn(UserBL user); // checks for a user to sign in
    }
}
