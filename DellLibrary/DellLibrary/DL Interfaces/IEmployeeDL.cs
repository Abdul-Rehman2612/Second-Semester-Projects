using DellLibrary.BL;
using System.Collections.Generic;

namespace DellLibrary.DL_Interfaces
{
    public interface IEmployeeDL
    {
        string AddEmployee(EmployeeBL employee); // for adding an employee
        string RemoveEmployee(string username); // for removing an employee
        string DeactivateEmployeeAccount(string username); // for deactivating an employee's account
        string UpdateEmployee(EmployeeBL employee,string username,string email); // for updating an employee's info
        EmployeeBL GetEmployeebyUsername(string username); // for getting employee for specific username
        List<EmployeeBL> GetAllEmployeesByStatus(string status); // returns all employees list by status
        int GetEmployeeCount(); // returns employees count
        List<EmployeeBL> GetEmployeesByDesignation(string designation,string status); // returns the list of employees with specific designation
    }
}
