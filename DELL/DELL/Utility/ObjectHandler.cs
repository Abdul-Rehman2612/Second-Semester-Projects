using DellLibrary.DL.DB;
using DellLibrary.DL_Interfaces;

namespace DELL.Utility
{
    internal class ObjectHandler
    {
        private static readonly ICustomerDL CustomerDL = new CustomerDLDB();
        private static readonly IUserDL CustomerUDL = new CustomerDLDB();
        private static readonly IEmployeeDL EmployeeDL = new EmployeeDLDB();
        private static readonly IUserDL EmployeeUDL = new EmployeeDLDB();
        public static ICustomerDL GetCustomerDL() { return CustomerDL; }
        public static IUserDL GetCustomerUDL() { return CustomerUDL; }
        public static IEmployeeDL GetEmployeeDL() { return EmployeeDL; }
        public static IUserDL GetEmployeeUDL() { return EmployeeUDL; }
    }
}
