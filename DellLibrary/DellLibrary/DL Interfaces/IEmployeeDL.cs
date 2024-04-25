using DellLibrary.BL;
using System.Collections.Generic;

namespace DellLibrary.DL_Interfaces
{
    public interface IEmployeeDL
    {
        string AddEmployee(EmployeeBL employee);
        string RemoveEmployee(string username);
        string DeactivateEmployeeAccount(string username);
        string ActivateEmployeeAccount(string username);
        string UpdateEmployee(EmployeeBL employee, string username, string email);
        List<EmployeeBL> GetAllEmployees();
        EmployeeBL GetEmployeebyUsername(string username);
        List<EmployeeBL> GetAllEmployeesByStatus(string status);
        int GetEmployeeCount();
        List<EmployeeBL> GetEmployeesByDesignation(string designation, string status);
    }
}
