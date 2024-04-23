using System;
using System.Collections.Generic;

namespace DellConsole.UI
{
    internal class AdminUI
    {
        // List of options available in the admin menu
        private static List<string> menu = new List<string>() {"1.Add employee","2.Remove employee","3.Update employee", "4.View all employees","5.Exit"};

        // Displays the admin menu options and returns the user's choice
        public static string PrintAdminMenu()
        {
            // Display each menu option
            foreach (string item in menu)
            {
                Console.WriteLine(item);
            }

            // Prompt the user to enter their choice
            Console.Write("Enter option...");

            // Return the user's choice
            return Console.ReadLine();
        }
    }
}
