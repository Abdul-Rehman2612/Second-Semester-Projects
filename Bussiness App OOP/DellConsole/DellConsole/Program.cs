using DellConsole.UI;
using DELLConsole.Utility;
using DellLibrary.BL;
using System;
using System.Collections.Generic;

namespace DellConsole
{
    internal class Program
    {
        static void Main()
        {
            while (true)
            {
                // Clear the console screen
                Console.Clear();

                // Display the header for the admin menu
                Utility.Header();

                // Display the main menu and get user's choice
                string option = Utility.Menu();

                // If the user chooses option 1 (Admin menu)
                if (option == "1")
                {
                    while (true)
                    {
                        // Clear the console screen
                        Console.Clear();

                        // Display the header for the manage employee menu
                        Utility.ManageEmpHeader();

                        // Print the admin menu and get user's choice
                        option = AdminUI.PrintAdminMenu();

                        // If the user chooses to add an employee
                        if (option == "1")
                        {
                            // Display header for adding employee
                            Console.Clear();
                            Utility.AddEmpHeader();

                            // Gather inputs for a new employee
                            EmployeeBL employee = EmployeeUI.EmployeeInputs();

                            // Add the employee to the data layer
                            string message = ObjectHandler.GetEmployeeDL().AddEmployee(employee);

                            // Display success or error message
                            if (message == "True")
                            {
                                Utility.PressAnyKeyToContinue("\nEmployee added successfully!");
                            }
                            else
                            {
                                Utility.PressAnyKeyToContinue(message);
                            }
                        }
                        // If the user chooses to remove an employee
                        else if (option == "2")
                        {
                            // Display header for removing employee
                            Console.Clear();
                            Utility.RemoveEmpHeader();

                            // Prompt for employee username
                            string username = Utility.Input("employee username");
                            try
                            {
                                // Attempt to get employee details
                                EmployeeBL employee = ObjectHandler.GetEmployeeDL().GetEmployeebyUsername(username);
                                if (employee != null)
                                {
                                    // Display employee details and confirm deletion
                                    Console.WriteLine($"\n\n{"Name",-15}{"Username",-15}{"Password",-15}{"Email",-15}{"DOB",-15}{"Address",-15}{"Contact",-15}{"Gender",-15}{"Designation",-15}{"Join Date",-15}");
                                    EmployeeUI.PrintEmployeeInfo(employee);
                                    string op = Utility.YesNoOption();
                                    if (op == "Y")
                                    {
                                        // Remove employee 
                                        op = ObjectHandler.GetEmployeeDL().RemoveEmployee(username);
                                        if (op == "True")
                                        {
                                            Utility.PressAnyKeyToContinue("\nEmployee deleted successfully!");
                                        }
                                        else
                                        {
                                            Utility.PressAnyKeyToContinue("\nEmployee data not deleted!");
                                        }
                                    }
                                    else
                                    {
                                        Utility.PressAnyKeyToContinue("\nEmployee data not deleted!");
                                    }
                                }
                                else
                                {
                                    Utility.PressAnyKeyToContinue("\nEmployee data not found!");
                                }
                            }
                            catch (Exception ex)
                            {
                                Utility.PressAnyKeyToContinue(ex.Message);
                            }
                        }
                        // If the user chooses to update an employee
                        else if (option == "3")
                        {
                            // Display header for updating employee
                            Console.Clear();
                            Utility.UpdateEmpHeader();

                            // Gather username input to update employee data
                            string username = Utility.Input("employee username");
                            try
                            {
                                // Attempt to get employee details
                                EmployeeBL employee = ObjectHandler.GetEmployeeDL().GetEmployeebyUsername(username);
                                if (employee != null)
                                {
                                    string email = employee.GetEmail();
                                   
                                    Console.WriteLine($"\n\n{"Name",-15}{"Username",-15}{"Password",-15}{"Email",-15}{"DOB",-15}{"Address",-15}{"Contact",-15}{"Gender",-15}{"Designation",-15}{"Join Date",-15}");
                                    EmployeeUI.PrintEmployeeInfo(employee);
                                    // Update employee information
                                    employee = EmployeeUI.UpdateEmployee(employee, email);
                                    string op = ObjectHandler.GetEmployeeDL().UpdateEmployee(employee, username, email);
                                    if (op == "True")
                                    {
                                        Utility.PressAnyKeyToContinue("\nEmployee updated successfully!");
                                    }
                                    else
                                    {
                                        Utility.PressAnyKeyToContinue("\nEmployee data not updated!");
                                    }
                                }
                                else
                                {
                                    Utility.PressAnyKeyToContinue("\nEmployee data not found!");
                                }
                            }
                            catch (Exception ex)
                            {
                                Utility.PressAnyKeyToContinue(ex.Message);
                            }
                        }
                        // If the user chooses to view all employees
                        else if (option == "4")
                        {
                            // Display header for viewing all employees
                            Console.Clear();
                            Utility.ViewEmpHeader();

                            List<EmployeeBL> employees = ObjectHandler.GetEmployeeDL().GetEmployeesByDesignation("SalesPerson", "Active");

                            // Display all employees
                            Console.WriteLine($"\n\n{"Name",-15}{"Username",-15}{"Password",-15}{"Email",-15}{"DOB",-15}{"Address",-15}{"Contact",-15}{"Gender",-15}{"Designation",-15}{"Join Date",-15}");
                            foreach (EmployeeBL emp in employees)
                            {
                                EmployeeUI.PrintEmployeeInfo(emp);
                            }
                            Utility.PressAnyKeyToContinue("\nAll employees data!");
                        }
                        // If the user chooses to go back to the main menu
                        else if (option == "5")
                        {
                            break; 
                        }
                        // If the user enters an invalid option
                        else
                        {
                            Utility.PressAnyKeyToContinue("Wrong user input!");
                        }
                    }
                }
                else if (option == "2")
                {
                    // Exit the application
                    Environment.Exit(0);
                }
                else
                {
                    Utility.PressAnyKeyToContinue("Wrong user input!");
                }
            }
        }
    }
}
