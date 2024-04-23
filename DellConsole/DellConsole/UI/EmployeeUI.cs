using DellLibrary.BL;
using DellLibrary.Utility;
using System;
namespace DellConsole.UI
{
    internal class EmployeeUI
    {
        // Takes inputs for new employee
        public static EmployeeBL EmployeeInputs()
        {
            // Variables to store user inputs
            string name, username, password, email, contact, gender, address;
            DateTime dob;

            // Loop for name input and validation
            name = NameInput();

            // Loop for username input and validation
            username = UsernameInput();

            // Loop for password input and validation
            password = PasswordInput();

            // Loop for email input and validation
            email = EmailInput();

            // Loop for date of birth input and validation
            dob = DOBInput();

            // Loop for gender input and validation
            gender = GenderInput();

            // Loop for contact input and validation
            contact = ContactInput();

            // Loop for address input
            address = AddressInput();

            // Create and return an EmployeeBL object with validated inputs
            EmployeeBL employee = new EmployeeBL(name, username, password, email, dob, address, contact, gender, "Active", "SalesPerson", DateTime.Now);
            return employee;
        }
        // Takes inputs to update existing employee
        public static EmployeeBL UpdateEmployee(EmployeeBL employee,string email)
        {
            // Update name
            employee.SetName(NameInput());
            // Update password
            employee.SetPassword(PasswordInput());
            // Update email
            employee.SetEmail(EmailInput(email));
            // Update dob
            employee.SetDob(DOBInput());
            // Update gender
            employee.SetGender(GenderInput());
            // Update address
            employee.SetAddress(AddressInput());
            // Update contact
            employee.SetContact(ContactInput());
            
            return employee; // return the updated employee
        }
        // Method responsible for gathering and validating user's name input
        private static string NameInput()
        {
            string name;
            while (true)
            {
                // Prompt the user to enter their name
                name = Utility.Input("name");

                // Validate the entered name
                string nameCheckResult = Validations.NameCheck(name);

                // If validation fails, display error message and prompt again
                if (nameCheckResult != "True")
                {
                    Console.WriteLine(nameCheckResult);
                }
                // If validation succeeds, return value
                else
                {
                    return name;
                }
            }
        }

        // Method responsible for gathering and validating user's username input
        private static string UsernameInput()
        {
            string username;
            while (true)
            {
                // Prompt the user to enter their username
                username = Utility.Input("username");

                // Validate the entered username
                string usernameCheckResult = Validations.UsernameCheck(username);

                // If validation fails, display error message and prompt again
                if (usernameCheckResult != "True")
                {
                    Console.WriteLine(usernameCheckResult);
                }
                // If validation succeeds, return value
                else
                {
                    return username;
                }
            }
        }

        // Method responsible for gathering and validating user's password input
        private static string PasswordInput()
        {
            string password;
            while (true)
            {
                // Prompt the user to enter their password
                password = Utility.Input("password");

                // Validate the entered password
                string passwordCheckResult = Validations.PasswordCheck(password);

                // If validation fails, display error message and prompt again
                if (passwordCheckResult != "True")
                {
                    Console.WriteLine(passwordCheckResult);
                }
                // If validation succeeds, return value
                else
                {
                    return password;
                }
            }
        }

        // Method responsible for gathering and validating user's email input
        private static string EmailInput()
        {
            string email;
            while (true)
            {
                // Prompt the user to enter their email
                email = Utility.Input("email");

                // Validate the entered email
                string emailCheckResult = Validations.EmailCheck(email);

                // If validation fails, display error message and prompt again
                if (emailCheckResult != "True")
                {
                    Console.WriteLine(emailCheckResult);
                }
                // If validation succeeds, return value
                else
                {
                    return email;
                }
            }
        }
        // Method responsible for gathering and validating user's updated email input
        private static string EmailInput(string email)
        {
            string email2;
            while (true)
            {
                // Prompt the user to enter their email
                email2 = Utility.Input("email");

                // Validate the entered email
                string emailCheckResult = Validations.UpdatedEmailCheck(email,email2);

                // If validation fails, display error message and prompt again
                if (emailCheckResult != "True")
                {
                    Console.WriteLine(emailCheckResult);
                }
                // If validation succeeds, return value
                else
                {
                    return email;
                }
            }
        }
        // Method responsible for gathering and validating user's date of birth input
        private static DateTime DOBInput()
        {
            DateTime dob;
            while (true)
            {
                // Prompt the user to enter their date of birth
                string dobInput = Utility.Input("DOB (YYYY-MM-DD)");

                // Attempt to parse the entered date of birth
                if (DateTime.TryParse(dobInput, out dob))
                {
                    // Validate the parsed date of birth
                    string ageCheckResult = Validations.AgeCheck(dob);

                    // If validation fails, display error message and prompt again
                    if (ageCheckResult != "True")
                    {
                        Console.WriteLine(ageCheckResult);
                    }
                    // If validation succeeds, return value
                    else
                    {
                        return dob;
                    }
                }
                // If parsing fails, display error message and prompt again
                else
                {
                    Console.WriteLine("Invalid date format. Please enter in YYYY-MM-DD format.");
                }
            }
        }

        // Method responsible for gathering and validating user's gender input
        private static string GenderInput()
        {
            string gender;
            while (true)
            {
                // Prompt the user to enter their gender
                Console.Write("Enter gender (F/M): ");
                gender = Console.ReadLine().ToLower();

                // Validate the entered gender
                if (gender == "f" || gender == "m" || gender == "female" || gender == "male")
                {
                    // Normalize the gender value
                    gender = gender == "f" || gender == "female" ? "Female" : "Male";
                    return gender;
                }
                // If validation fails, display error message and prompt again
                else
                {
                    Console.WriteLine("Invalid gender input. Please enter 'F' or 'M'.");
                }
            }
        }

        // Method responsible for gathering and validating user's contact input
        private static string ContactInput()
        {
            string contact;
            while (true)
            {
                // Prompt the user to enter their contact information
                Console.Write("Enter contact: ");
                contact = Console.ReadLine();

                // Validate the entered contact information
                string contactCheckResult = Validations.ContactCheck(contact);

                // If validation fails, display error message and prompt again
                if (contactCheckResult != "True")
                {
                    Console.WriteLine(contactCheckResult);
                }
                // If validation succeeds, exit the loop
                else
                {
                    return contact;
                }
            }
        }
        // Method responsible for gathering user's address input
        private static string AddressInput()
        {
            string address;
            while (true)
            {
                // Prompt the user to enter their address
                Console.Write("Enter address: ");
                address = Console.ReadLine();

                // If address is empty, display error message and prompt again
                if (string.IsNullOrEmpty(address))
                {
                    Console.WriteLine("Address cannot be empty.");
                }
                // If validation succeeds, return value
                else
                {
                    return address;
                }
            }
        }
        // Method responsible for printing an employee's info
        public static void PrintEmployeeInfo(EmployeeBL employee)
        {
            // Print the employee's details
            Console.WriteLine($"{employee.GetName(),-15}{employee.GetUsername(),-15}{employee.GetPassword(),-15}{employee.GetEmail(),-15}{employee.GetDob().ToString("yyyy-MM-dd"),-15}{employee.GetAddress(),-15}{employee.GetContact(),-15}{employee.GetGender(),-15}{employee.GetDesignation(),-15}{employee.GetHireDate().ToString("yyyy-MM-dd"),-15}");
        }
    }
}
