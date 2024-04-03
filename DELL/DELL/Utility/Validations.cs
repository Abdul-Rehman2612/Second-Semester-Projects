using DELL.BL;
using DELL.DL;
using System.Linq;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DELL.Utility
{
    internal class Validations
    {
        public static string IsValidUser(UserBL user)
        {
            string Check;
            if (user.Name=="" || user.Username=="" || user.Password=="" || user.Email=="" || user.Address=="" || user.Contact=="" || user.Gender=="")
            {
                return "Missing Information!";
            }
            Check=NameCheck(user.Name);
            if (Check!="True")
            {
                return Check;
            }
            Check=UsernameCheck(user.Username);
            if (Check!="True")
            {
                return Check;
            }
            Check=PasswordCheck(user.Password);
            if (Check!="True")
            {
                return Check;
            }
            Check=EmailCheck(user.Email);
            if (Check!="True")
            {
                return Check;
            }
            Check= ContactCheck(user.Contact);
            return Check;
        }
        public static string ContactCheck(string contact)
        {
            if (contact.Length < 4)
            {
                return "Contact must be at least 4 characters long.";
            }
            if (contact.Length > 15)
            {
                return "Contact must not exceed 15 characters.";
            }
            foreach (char c in contact)
            {
                if (!char.IsDigit(c))
                {
                    return "Contact must contain only numeric characters.";
                }
            }
            return "True";
        }
        public static string EmailCheck(string email)
        {
            if (email.Length > 50)
            {
                return "Email must not exceed 50 characters.";
            }
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            if (!Regex.IsMatch(email, pattern))
            {
                return "Email is not valid!";
            }
            IUserDL check = new CustomerDL();
            if (check.UniqueAttributeCheck(email, "Username"))
            {
                return "Email already exists!";
            }
            check = new EmployeeDL();
            if (check.UniqueAttributeCheck(email, "Username"))
            {
                return "Email already exists!";
            }
            return "True";
        }
        public static string PasswordCheck(string password)
        {
            if (password.Length < 6 || password.Length > 20)
                return "Password must be between 6 and 20 characters long.";

            if (!password.Any(char.IsLetter) || !password.Any(char.IsDigit))
                return "Password must contain at least one letter and one digit.";

            if (password.Any(char.IsWhiteSpace))
                return "Password cannot contain spaces.";

            return "True";
        }
        public static string UsernameCheck(string username)
        {
            if (username.Length > 20)
            {
                return "Username must not exceed 20 characters.";
            }
            foreach (char c in username)
            {
                if (!char.IsLetterOrDigit(c))
                {
                    return "Username must contain only letters and digits.";
                }
            }
            IUserDL check = new CustomerDL();
            if (check.UniqueAttributeCheck(username, "Username"))
            {
                return "Username already exists!";
            }
            check = new EmployeeDL();
            if (check.UniqueAttributeCheck(username, "Username"))
            {
                return "Username already exists!";
            }
            return "True";
        }
        public static string NameCheck(string text)
        {
            if (text.Length<50)
            {
                foreach (char c in text)
                {
                    if ((c < 'a' || c > 'z') && (c < 'A' || c > 'Z') && c != ' ')
                    {
                        return "Name can only consist of alphabets!";
                    }
                }
                if (text[0] < 'A' || text[0] > 'Z')
                {
                    return "First letter of name must be capital!";
                }
            }
            else
            {
                return "Name must be smaller than 50 characters!";
            }
            return "True";
        }
    }
}
