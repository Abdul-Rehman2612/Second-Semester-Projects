using DELL.BL;

namespace DELL.DL
{
    internal interface IUserDL
    {
        string AddUser(UserBL user);
        // string RemoveUser(UserBL user);
        // string UpdateUser(UserBL user);
        // List<UserBL> GetAllUsers();
        bool UniqueAttributeCheck(string text, string attribute);
        string UserSignIn(UserBL user);
    }
}
