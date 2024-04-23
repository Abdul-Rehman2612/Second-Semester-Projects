using DellLibrary.BL;
using DellLibrary.DL_Interfaces;
using DellLibrary.Utility;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DellLibrary.DL.FH
{
    public class EmployeeDLFH : IUserDL, IEmployeeDL
    {
        private string filePath = "D:\\employee.txt"; // Path to the CSV file
        public string AddEmployee(EmployeeBL user)
        {
            string message = Validations.IsValidNewUser(user); // Validate user
            if (message == "True")
            {
                try
                {
                    // Construct CSV line
                    string newEmployee = $"{user.GetName()},{user.GetUsername()},{user.GetPassword()},{user.GetEmail()},{user.GetDob()},{user.GetAddress()},{user.GetContact()},{user.GetGender()},{user.GetStatus()},{user.GetDesignation()},{user.GetHireDate()}";

                    // Append to CSV file
                    File.AppendAllText(filePath, newEmployee + Environment.NewLine);
                    message = "True"; // Success
                }
                catch (Exception e)
                {
                    message = e.Message; // Error occurred
                }
            }
            return message; // Return result message
        }
        public string UpdateEmployee(EmployeeBL user, string username, string email)
        {
            string message;

            // Determine if the user is a CEO
            bool isCEO = user.GetDesignation() == "CEO";

            // Validate user information
            message = Validations.IsValidUpdatedUser(user, username, email, isCEO);

            // If the user is valid
            if (message == "True")
            {
                try
                {
                    string[] lines = File.ReadAllLines(filePath); // Read all lines from the CSV file

                    for (int i = 0; i < lines.Length; i++)
                    {
                        string[] parts = lines[i].Split(','); // Split the line into parts

                        // Check if the username matches
                        if (parts[1] == username)
                        {
                            // Update the user's information
                            lines[i] = $"{user.GetName()},{user.GetUsername()},{user.GetPassword()},{user.GetEmail()},{user.GetDob()},{user.GetAddress()},{user.GetContact()},{user.GetGender()}";
                            break; // Exit the loop since the user is found
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
            }
            return message; // Return the result message
        }
        public string RemoveEmployee(string username)
        {
            string message = "";

            try
            {
                string[] lines = File.ReadAllLines(filePath); // Read all lines from the CSV file
                List<string> updatedLines = new List<string>();

                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');
                    if (parts[1] != username) // If the username does not match, keep the line
                    {
                        updatedLines.Add(line);
                    }
                }

                // Write the updated lines back to the file
                File.WriteAllLines(filePath, updatedLines);
                message = "True"; // Success
            }
            catch (Exception e)
            {
                message = e.Message; // Error occurred
            }

            return message; // Return the result message
        }
        public string DeactivateEmployeeAccount(string username)
        {
            string message = "";

            try
            {
                string[] lines = File.ReadAllLines(filePath); // Read all lines from the CSV file

                for (int i = 0; i < lines.Length; i++)
                {
                    string[] parts = lines[i].Split(','); // Split the line into parts

                    // Check if the username matches
                    if (parts[1] == username)
                    {
                        // Update the user's status
                        parts[8] = "Deactivated";
                        lines[i] = string.Join(",", parts); // Join parts back into a line
                        break; // Exit the loop since the user is found
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
        public EmployeeBL GetEmployeebyUsername(string username)
        {
            EmployeeBL employee = null;

            try
            {
                string[] lines = File.ReadAllLines(filePath); // Read all lines from the CSV file

                foreach (string line in lines)
                {
                    string[] parts = line.Split(','); // Split the line into parts

                    // Check if the username matches
                    if (parts[1] == username)
                    {
                        // Create an EmployeeBL object
                        employee = new EmployeeBL(parts[0], parts[1], parts[2], parts[3], DateTime.Parse(parts[4]), parts[5], parts[6], parts[7], parts[8], parts[9], DateTime.Parse(parts[10]));
                        break; // Exit the loop since the user is found
                    }
                }
            }
            catch (Exception)
            {
                // Handle exceptions if needed
            }

            return employee; // Return the employee object
        }
        public List<EmployeeBL> GetAllEmployeesByStatus(string status)
        {
            List<EmployeeBL> employees = new List<EmployeeBL>();

            try
            {
                string[] lines = File.ReadAllLines(filePath); // Read all lines from the CSV file

                foreach (string line in lines)
                {
                    string[] parts = line.Split(','); // Split the line into parts

                    if (parts[8] == status) // Check if the status matches
                    {
                        // Create an EmployeeBL object
                        EmployeeBL employee = new EmployeeBL(parts[0], parts[1], parts[2], parts[3], DateTime.Parse(parts[4]), parts[5], parts[6], parts[7], parts[8], parts[9], DateTime.Parse(parts[10]));
                        employees.Add(employee);
                    }
                }
            }
            catch (Exception)
            {
                // Handle exceptions if needed
            }

            return employees; // Return the list of employees
        }
        public List<EmployeeBL> GetEmployeesByDesignation(string designation, string status)
        {
            List<EmployeeBL> employees = new List<EmployeeBL>();

            try
            {
                string[] lines = File.ReadAllLines(filePath); // Read all lines from the CSV file

                foreach (string line in lines)
                {
                    string[] parts = line.Split(','); // Split the line into parts

                    if (parts[9] == designation && parts[8] == status) // Check if designation and status match
                    {
                        // Create an EmployeeBL object
                        EmployeeBL employee = new EmployeeBL(parts[0], parts[1], parts[2], parts[3], DateTime.Parse(parts[4]), parts[5], parts[6], parts[7], parts[8], parts[9], DateTime.Parse(parts[10]));
                        employees.Add(employee);
                    }
                }
            }
            catch (Exception)
            {
                // Handle exceptions if needed
            }

            return employees; // Return the list of employees
        }
        public bool UniqueAttributeCheck(string text, string attribute)
        {
            bool check = false;

            try
            {
                string[] lines = File.ReadAllLines(filePath); // Read all lines from the CSV file

                foreach (string line in lines)
                {
                    string[] parts = line.Split(','); // Split the line into parts

                    if (parts[1] == text) // Check if the attribute matches
                    {
                        check = true; // Attribute found, it's not unique
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
                string[] lines = File.ReadAllLines(filePath); // Read all lines from the CSV file

                foreach (string line in lines)
                {
                    string[] parts = line.Split(','); // Split the line into parts

                    // Check if the username and password match
                    if (parts[1] == user.GetUsername() && parts[2] == user.GetPassword() && parts[8] == "Active")
                    {
                        // Create an EmployeeBL object
                        employee = new EmployeeBL(parts[0], parts[1], parts[2], parts[3], DateTime.Parse(parts[4]), parts[5], parts[6], parts[7], parts[8], parts[9], DateTime.Parse(parts[10]));
                        break; // Exit the loop since the user is found
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
                string[] lines = File.ReadAllLines(filePath); // Read all lines from the CSV file

                // Increment count for each active employee
                foreach (string line in lines)
                {
                    string[] parts = line.Split(','); // Split the line into parts

                    if (parts[8] == "Active") // Check if the status is active
                    {
                        employeeCount++;
                    }
                }
            }
            catch (Exception)
            {
                // Handle exceptions if needed
            }

            return employeeCount; // Return the count
        }
    }
}
