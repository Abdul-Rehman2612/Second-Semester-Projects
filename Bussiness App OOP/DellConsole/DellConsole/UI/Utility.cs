using System;

namespace DellConsole.UI
{
    internal class Utility
    {
        // Displays the main menu and returns the user's choice
        public static string Menu()
        {
            Console.WriteLine("1.Manage employees\n2.Exit");
            Console.Write("\nEnter option...");
            return Console.ReadLine();
        }

        // Displays a message and prompts the user to press any key to continue
        public static void PressAnyKeyToContinue(string message)
        {
            Console.WriteLine(message);
            Console.Write("Press any key to continue...");
            Console.ReadKey();
        }

        // Displays the header for the application
        public static void Header()
        {
            Console.WriteLine("        *************************");
            Console.WriteLine("        *      Dell System      *");
            Console.WriteLine("        *************************");
        }

        // Displays the header for adding an employee
        public static void AddEmpHeader()
        {
            Console.WriteLine("        **************************");
            Console.WriteLine("        *      Add Employee      *");
            Console.WriteLine("        **************************");
        }

        // Displays the header for removing an employee
        public static void RemoveEmpHeader()
        {
            Console.WriteLine("        *****************************");
            Console.WriteLine("        *      Remove Employee      *");
            Console.WriteLine("        *****************************");
        }
        // Displays the header for managing employees
        public static void ManageEmpHeader()
        {
            Console.WriteLine("        ******************************");
            Console.WriteLine("        *      Managae Employee      *");
            Console.WriteLine("        ******************************");
        }

        // Displays the header for updating an employee
        public static void UpdateEmpHeader()
        {
            Console.WriteLine("        *****************************");
            Console.WriteLine("        *      Update Employee      *");
            Console.WriteLine("        *****************************");
        }

        // Displays the header for viewing employee data
        public static void ViewEmpHeader()
        {
            Console.WriteLine("        ***************************");
            Console.WriteLine("        *      View Employee      *");
            Console.WriteLine("        ***************************");
        }

        // Prompts the user to input a value for a specific attribute and returns the input
        public static string Input(string attribute)
        {
            Console.Write("Enter "+attribute+": ");
            return Console.ReadLine();
        }
        // Prompts the user to input option
        public static string YesNoOption()
        {
            // Prompt the user for input
            Console.WriteLine("\nDo you want to delete user data (Y/N)?");

            // Keep looping until a valid input is received
            while (true)
            {
                // Read the user's input from the console and convert it to lowercase
                Console.Write("Enter option: ");
                string option = Console.ReadLine().ToLower();

                // Check if the input matches one of the valid options
                if (option == "y" || option == "yes" || option == "no" || option == "n")
                {
                    // Convert the input to uppercase (Y or N) for consistency
                    option = option == "yes" || option == "y" ? "Y" : "N";

                    // Return the valid option
                    return option;
                }
            }
        }
    }
}
