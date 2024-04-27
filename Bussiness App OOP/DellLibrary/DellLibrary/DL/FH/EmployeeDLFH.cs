using DellLibrary.BL;
using DellLibrary.DL_Interfaces;
using DellLibrary.Utility;
using System;
using System.Collections.Generic;
using System.IO;

namespace DellLibrary.DL.FH
{
    public class EmployeeDLFH : IUserDL, IEmployeeDL
    {
        private string filePath = "D:\\employee.txt";
        public string AddEmployee(EmployeeBL user)
        {
            string message = Validations.IsValidNewUser(user);
            if (message == "True")
            {
                try
                {
                    string newEmployee = $"{user.GetName()},{user.GetUsername()},{user.GetPassword()},{user.GetEmail()},{user.GetDob()},{user.GetAddress()},{user.GetContact()},{user.GetGender()},{user.GetStatus()},{user.GetDesignation()},{user.GetHireDate()}";


                    File.AppendAllText(filePath, newEmployee + Environment.NewLine);
                    message = "True";
                }
                catch (Exception e)
                {
                    message = e.Message;
                }
            }
            return message;
        }
        public string UpdateEmployee(EmployeeBL user, string username, string email)
        {
            string message;
            bool isCEO = user.GetDesignation() == "CEO";
            message = Validations.IsValidUpdatedUser(user, username, email, isCEO);
            if (message == "True")
            {
                try
                {
                    string[] lines = File.ReadAllLines(filePath);
                    for (int i = 0; i < lines.Length; i++)
                    {
                        string[] parts = lines[i].Split(',');

                        if (parts[1] == username)
                        {
                            lines[i] = $"{user.GetName()},{user.GetUsername()},{user.GetPassword()},{user.GetEmail()},{user.GetDob()},{user.GetAddress()},{user.GetContact()},{user.GetGender()}";
                            break;
                        }
                    }

                    File.WriteAllLines(filePath, lines);
                    message = "True";
                }
                catch (Exception e)
                {
                    message = e.Message;
                }
            }
            return message;
        }
        public string RemoveEmployee(string username)
        {
            string message = "";

            try
            {
                string[] lines = File.ReadAllLines(filePath);
                List<string> updatedLines = new List<string>();

                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');
                    if (parts[1] != username)
                    {
                        updatedLines.Add(line);
                    }
                }

                File.WriteAllLines(filePath, updatedLines);
                message = "True";
            }
            catch (Exception e)
            {
                message = e.Message;
            }

            return message;
        }
        public List<EmployeeBL> GetAllEmployees()
        {
            List<EmployeeBL> employees = new List<EmployeeBL>();

            try
            {
                string[] lines = File.ReadAllLines(filePath);

                foreach (string line in lines)
                {
                    string[] parts = line.Split(','); 

                    if (parts[9] != "CEO" && string.IsNullOrEmpty(parts[11]))
                    {
                        EmployeeBL employee;
                        if (parts.Length >= 12 && !string.IsNullOrEmpty(parts[11]))
                        {
                            employee = new EmployeeBL(parts[0], parts[1], parts[2], parts[3], DateTime.Parse(parts[4]), parts[5], parts[6], parts[7], parts[8], parts[9], DateTime.Parse(parts[10]), DateTime.Parse(parts[11]));
                        }
                        else
                        {
                            employee = new EmployeeBL(parts[0], parts[1], parts[2], parts[3], DateTime.Parse(parts[4]), parts[5], parts[6], parts[7], parts[8], parts[9], DateTime.Parse(parts[10]));
                        }

                        employees.Add(employee); 
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return employees;
        }
        public string ActivateEmployeeAccount(string username)
        {
            string message = "";

            try
            {
                string[] lines = File.ReadAllLines(filePath);

                for (int i = 0; i < lines.Length; i++)
                {
                    string[] parts = lines[i].Split(',');


                    if (parts.Length > 1 && parts[1] == username)
                    {
                        parts[8] = "Active";

                        lines[i] = string.Join(",", parts);

                        File.WriteAllLines(filePath, lines);

                        message = "True";
                        break;
                    }
                }
            }
            catch (Exception e)
            {
                message = e.Message;
            }

            return message; 
        }
        public string DeactivateEmployeeAccount(string username)
        {
            string message = "";

            try
            {
                string[] lines = File.ReadAllLines(filePath);

                for (int i = 0; i < lines.Length; i++)
                {
                    string[] parts = lines[i].Split(',');

                    if (parts[1] == username)
                    {
                        parts[8] = "Deactivated";
                        lines[i] = string.Join(",", parts); 
                        break;
                    }
                }

                // Write the updated lines back to the file
                File.WriteAllLines(filePath, lines);
                message = "True"; // Success
            }
            catch (Exception e)
            {
                message = e.Message; // Error occurred
            }

            return message; // Return the result message
        }
        public List<EmployeeBL> GetEmployeesByDesignation(string designation, string status)
        {
            List<EmployeeBL> employees = new List<EmployeeBL>();

            try
            {
                string[] lines = File.ReadAllLines(filePath); 

                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');

                    if (parts[9] == designation && parts[8] == status) 
                    {
                        EmployeeBL employee = new EmployeeBL(parts[0], parts[1], parts[2], parts[3], DateTime.Parse(parts[4]), parts[5], parts[6], parts[7], parts[8], parts[9], DateTime.Parse(parts[10]));
                        employees.Add(employee);
                    }
                }
            }
            catch (Exception)
            {
            }

            return employees; 
        }
        public EmployeeBL GetEmployeebyUsername(string username)
        {
            EmployeeBL employee = null;

            try
            {
                string[] lines = File.ReadAllLines(filePath);

                foreach (string line in lines)
                {
                    string[] parts = line.Split(','); 

                    
                    if (parts[1] == username)
                    {
                        employee = new EmployeeBL(parts[0], parts[1], parts[2], parts[3], DateTime.Parse(parts[4]), parts[5], parts[6], parts[7], parts[8], parts[9], DateTime.Parse(parts[10]));
                        break;
                    }
                }
            }
            catch (Exception)
            {
            }

            return employee; 
        }
        public List<EmployeeBL> GetAllEmployeesByStatus(string status)
        {
            List<EmployeeBL> employees = new List<EmployeeBL>();

            try
            {
                string[] lines = File.ReadAllLines(filePath);

                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');

                    if (parts[8] == status)
                    {

                        EmployeeBL employee = new EmployeeBL(parts[0], parts[1], parts[2], parts[3], DateTime.Parse(parts[4]), parts[5], parts[6], parts[7], parts[8], parts[9], DateTime.Parse(parts[10]));
                        employees.Add(employee);
                    }
                }
            }
            catch (Exception)
            {

            }

            return employees; // Return the list of employees
        }
        public bool UniqueAttributeCheck(string text, string attribute)
        {
            bool check = false;

            try
            {
                string[] lines = File.ReadAllLines(filePath);

                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');

                    if (parts[1] == text)
                    {
                        check = true;
                        break;
                    }
                }
            }
            catch (Exception)
            {
                // Handle exceptions if needed
            }

            return check; // Return the result of the check
        }
        public UserBL UserSignIn(UserBL user)
        {
            EmployeeBL employee = null;

            try
            {
                string[] lines = File.ReadAllLines(filePath);

                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');

                    if (parts[1] == user.GetUsername() && parts[2] == user.GetPassword() && parts[8] == "Active")
                    {
                        employee = new EmployeeBL(parts[0], parts[1], parts[2], parts[3], DateTime.Parse(parts[4]), parts[5], parts[6], parts[7], parts[8], parts[9], DateTime.Parse(parts[10]));
                        break;
                    }
                }
            }
            catch (Exception)
            {
                // Handle exceptions if needed
            }

            return employee; // Return the employee object
        }
        public int GetEmployeeCount()
        {
            int employeeCount = 0;

            try
            {
                string[] lines = File.ReadAllLines(filePath);

                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');

                    if (parts[8] == "Active")
                    {
                        employeeCount++;
                    }
                }
            }
            catch (Exception)
            {

            }

            return employeeCount;
        }
    }
}
