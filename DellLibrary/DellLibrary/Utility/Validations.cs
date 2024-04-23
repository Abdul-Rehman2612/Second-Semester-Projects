using DellLibrary.BL;
using DellLibrary.DL.DB;
using DellLibrary.DL_Interfaces;
using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace DellLibrary.Utility
{
    public class Validations
    {
        // Check if the user information is valid
        public static string IsValidNewUser(UserBL user)
        {
            string Check;

            // Check if any required information is missing
            if (user.GetName() == "" || user.GetUsername() == "" || user.GetPassword() == "" || user.GetEmail() == "" || user.GetAddress() == "" || user.GetContact() == "" || user.GetGender() == "")
            {
                return "Missing Information!";
            }

            // Check each attribute for validity

            Check = UsernameCheck(user.GetUsername());
            if (Check != "True")
            {
                return Check;
            }

            Check = EmailCheck(user.GetEmail());
            if (Check != "True")
            {
                return Check;
            }

            Check=IsValidInfo(user);
            return Check;
        }
        // Check if the user updated information is valid
        public static string IsValidInfo(UserBL user)
        {
            string Check;
            // Check each attribute for validity
            Check = NameCheck(user.GetName());
            if (Check != "True")
            {
                return Check;
            }

            Check = PasswordCheck(user.GetPassword());
            if (Check != "True")
            {
                return Check;
            }

            Check = ContactCheck(user.GetContact());
            if (Check != "True")
            {
                return Check;
            }

            Check = AgeCheck(user.GetDob());
            return Check;
        }
        // Check if the username for admin is valid
        public static string AdminUsernameCheck(string username,string u2)
        {
            string Check = "True";
            if (UsernameCheck(username)!="True" && username!=u2)
            {
                Check=UsernameCheck(username);
            }
            return Check;
        }
        // Check if the user information is valid to be updated
        public static string IsValidUpdatedUser(UserBL user,string username,string email,bool isAdmin)
        {
            string Check;

            // Check if any required information is missing
            if (user.GetName() == "" || user.GetUsername() == "" || user.GetPassword() == "" || user.GetEmail() == "" || user.GetAddress() == "" || user.GetContact() == "" || user.GetGender() == "")
            {
                return "Missing Information!";
            }
            if(isAdmin)
            {
                Check = AdminUsernameCheck(username, user.GetUsername());
                if (Check!="True")
                {
                    return Check;
                }
            }
            else
            {
                if (user.GetUsername()!=username)
                {
                    return "Username cannot be changed!";
                }
            }

            Check = UpdatedEmailCheck(email,user.GetEmail());
            if(Check!="True")
            {
                return Check;
            }

            Check = IsValidInfo(user);
            return Check;
        }
        // Check if the updated email is valid
        public static string UpdatedEmailCheck(string email,string em2)
        {
            string Check = EmailCheck(em2);
            if (Check != "True" && em2!=email)
            {
                return Check;
            }
            return "True";
        }
        // Check if the contact information is valid
        public static string ContactCheck(string contact)
        {
            // Check length of contact number
            if (contact.Length < 4)
            {
                return "Contact must be at least 4 characters long.";
            }
            if (contact.Length > 15)
            {
                return "Contact must not exceed 15 characters.";
            }
            // Check if contact contains only numeric characters
            foreach (char c in contact)
            {
                if (!char.IsDigit(c))
                {
                    return "Contact must contain only numeric characters.";
                }
            }
            return "True";
        }
        // Check if the email address is valid
        public static string EmailCheck(string email)
        {
            // Check length of email address
            if (email.Length > 50)
            {
                return "Email must not exceed 50 characters.";
            }
            // Validate email format using regex pattern
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            if (!Regex.IsMatch(email, pattern))
            {
                return "Email is not valid!";
            }
            // Check if email address already exists
            IUserDL check = new CustomerDLDB();
            if (check.UniqueAttributeCheck(email, "Email"))
            {
                return "Email already exists!";
            }
            check = new EmployeeDLDB();
            return check.UniqueAttributeCheck(email, "Email") ? "Email already exists!" : "True";
        }
        // Check if the password is valid
        public static string PasswordCheck(string password)
        {
            // Check length of password
            if (password.Length < 6 || password.Length > 20)
            {
                return "Password must be between 6 and 20 characters long.";
            }
            // Check if password contains at least one letter and one digit
            if (!password.Any(char.IsLetter) || !password.Any(char.IsDigit))
            {
                return "Password must contain at least one letter and one digit.";
            }
            // Check if password contains spaces
            return password.Any(char.IsWhiteSpace) ? "Password cannot contain spaces." : "True";
        }
        // Check if the username is valid
        public static string UsernameCheck(string username)
        {
            // Check length of username
            if (username.Length > 20)
            {
                return "Username must not exceed 20 characters.";
            }
            // Check if username contains only letters and digits
            foreach (char c in username)
            {
                if (!char.IsLetterOrDigit(c))
                {
                    return "Username must contain only letters and digits.";
                }
            }
            // Check if username already exists
            IUserDL check = new CustomerDLDB();
            if (check.UniqueAttributeCheck(username, "Username"))
            {
                return "Username already exists!";
            }
            check = new EmployeeDLDB();
            return check.UniqueAttributeCheck(username, "Username") ? "Username already exists!" : "True";
        }
        // Check if the user is older than 15 years
        public static string AgeCheck(DateTime dob)
        {
            // Calculate the date 15 years ago from the current date
            DateTime cutoffDate = DateTime.Today.AddYears(-15);
            // Compare the DOB with the cutoff date
            if (cutoffDate > dob)
            {
                return "True";
            }
            else
            {
                return "Age must be greater than 16 years!";
            }
        }
        // Check if the name is valid
        public static string NameCheck(string text)
        {
            // Check length of name
            if (text.Length > 50)
            {
                return "Name must be smaller than 50 characters!";
            }
            // Check if name contains only alphabets
            foreach (char c in text)
            {
                if ((c < 'a' || c > 'z') && (c < 'A' || c > 'Z') && c != ' ')
                {
                    return "Name can only consist of alphabets!";
                }
            }
            // Check if the first letter of name is capital
            if (text[0] < 'A' || text[0] > 'Z')
            {
                return "First letter of name must be capital!";
            }
            return "True";
        }
    }
}
