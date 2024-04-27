using DellLibrary.DL.DB;
using DellLibrary.DL.FH;
using DellLibrary.DL_Interfaces;

namespace DELLConsole.Utility
{
    internal class ObjectHandler
    {
        // makes object of interfaces
        private static readonly IEmployeeDL employeeDL = new EmployeeDLFH();
        // private static readonly IEmployeeDL employeeDL = new EmployeeDLDB();
        // returns the employeeDL object of interface
        public static IEmployeeDL GetEmployeeDL() { return employeeDL; }
    }
}
