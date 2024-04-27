using DellLibrary.BL;

namespace DellLibrary.DL_Interfaces
{
    public interface IUserDL
    {
        bool UniqueAttributeCheck(string text, string attribute);
        UserBL UserSignIn(UserBL user);
    }
}
