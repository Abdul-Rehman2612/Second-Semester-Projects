using DellLibrary.BL;

namespace DellLibrary.DL_Interfaces
{
    public interface IUserDL
    {
        bool UniqueAttributeCheck(string text, string attribute); // checks for unique attributes
        UserBL UserSignIn(UserBL user); // checks for a user to sign in
    }
}
