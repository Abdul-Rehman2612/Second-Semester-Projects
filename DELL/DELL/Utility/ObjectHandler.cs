using DellLibrary.DL.DB;
using DellLibrary.DL.FH;
using DellLibrary.DL_Interfaces;

namespace DELL.Utility
{
    internal class ObjectHandler
    {
        private static readonly ICustomerDL customerDL = new CustomerDLDB();
        private static readonly IUserDL customerUDL = new CustomerDLDB();
        private static readonly IUserDL employeeUDL = new EmployeeDLDB();
        private static readonly IOrderDL orderDL = new OrderDLDB();
        private static readonly IProductDL productDL = new ProductDLDB();
        private static readonly IOrderDetailsDL orderDetailsDL = new OrderDetailsDLDB();

        private static readonly IEmployeeDL employeeDL = new EmployeeDLDB();

        public static ICustomerDL GetCustomerDL() { return customerDL; }
        public static IUserDL GetCustomerUDL() { return customerUDL; }
        public static IEmployeeDL GetEmployeeDL() { return employeeDL; }
        public static IUserDL GetEmployeeUDL() { return employeeUDL; }
        public static IOrderDL GetOrderDL() { return orderDL; }
        public static IProductDL GetProductDL() { return productDL; }
        public static IOrderDetailsDL GetOrderDetailsDL() { return orderDetailsDL; }

    }
}
