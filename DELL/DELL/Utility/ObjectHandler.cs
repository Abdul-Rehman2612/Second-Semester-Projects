using DellLibrary.DL.DB;
using DellLibrary.DL.FH;
using DellLibrary.DL_Interfaces;

namespace DELL.Utility
{
    internal class ObjectHandler
    {
        // Initialize instances of data access layers for various entities
        private static readonly ICustomerDL customerDL = new CustomerDLDB(); // Customer Data Access Layer
        private static readonly IUserDL customerUDL = new CustomerDLDB(); // User Data Access Layer for Customers
        private static readonly IUserDL employeeUDL = new EmployeeDLDB(); // User Data Access Layer for Employees
        private static readonly IOrderDL orderDL = new OrderDLDB(); // Order Data Access Layer
        private static readonly IProductDL productDL = new ProductDLDB(); // Product Data Access Layer
        private static readonly IOrderDetailsDL orderDetailsDL = new OrderDetailsDLDB(); // Order Details Data Access Layer
        private static readonly IEmployeeContributionDL employeeContributionDL = new EmployeeContributionDLDB(); // Employee Contribution Data Access Layer

        private static readonly IEmployeeDL employeeDL = new EmployeeDLDB(); // Employee Data Access Layer
        // private static readonly IEmployeeDL employeeDL = new EmployeeDLFH(); // User Data Access Layer for Employees

        // Methods to retrieve instances of data access layers
        public static ICustomerDL GetCustomerDL() { return customerDL; } // Get Customer Data Access Layer
        public static IUserDL GetCustomerUDL() { return customerUDL; } // Get User Data Access Layer for Customers
        public static IEmployeeDL GetEmployeeDL() { return employeeDL; } // Get Employee Data Access Layer
        public static IUserDL GetEmployeeUDL() { return employeeUDL; } // Get User Data Access Layer for Employees
        public static IOrderDL GetOrderDL() { return orderDL; } // Get Order Data Access Layer
        public static IProductDL GetProductDL() { return productDL; } // Get Product Data Access Layer
        public static IOrderDetailsDL GetOrderDetailsDL() { return orderDetailsDL; } // Get Order Details Data Access Layer
        public static IEmployeeContributionDL GetEmployeeContributionDL() { return employeeContributionDL; } // Get Employee Contribution Data Access Layer

    }
}
