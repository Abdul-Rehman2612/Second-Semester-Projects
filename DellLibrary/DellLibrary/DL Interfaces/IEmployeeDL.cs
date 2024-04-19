using DellLibrary.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DellLibrary.DL_Interfaces
{
    public interface IEmployeeDL
    {
        string AddEmployee(EmployeeBL employee); // for adding an employee
        string RemoveEmployee(string username); // for removing an employee
        EmployeeBL GetEmployeebyUsername(string username); // for getting employee for specific username
        List<EmployeeBL> GetAllEmployees(); // returns all employees list
        int GetEmployeeCount(); // returns employees count
        List<EmployeeBL> GetEmployeesByDesignation(string designation); // returns the list of employees with specific designation
    }
}
