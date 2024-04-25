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
        public static string IsValidNewUser(UserBL user)
        {
            string Check;

            if (user.GetName() == "" || user.GetUsername() == "" || user.GetPassword() == "" || user.GetEmail() == "" || user.GetAddress() == "" || user.GetContact() == "" || user.GetGender() == "")
            {
                return "Missing Information!";
            }

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

        public static string IsValidInfo(UserBL user)
        {
            string Check;

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

        public static string IsValidUpdatedUser(UserBL user, string username, string email, bool isAdmin)
        {
            string Check;

            if (user.GetName() == "" || user.GetUsername() == "" || user.GetPassword() == "" || user.GetEmail() == "" || user.GetAddress() == "" || user.GetContact() == "" || user.GetGender() == "")
            {
                return "Missing Information!";
            }
            if (isAdmin)
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

            Check = UpdatedEmailCheck(email, user.GetEmail());
            if (Check!="True")
            {
                return Check;
            }

            Check = IsValidInfo(user);
            return Check;
        }

        public static string IsValidNewProduct(ProductBL p)
        {
            string Check;

            if (p.GetProductName() == "" || p.GetProductDetails() == "" || p.GetUnitsInStock().ToString() == "" || p.GetProductPrice().ToString() == "")
            {
                return "Missing Information!";
            }

            Check = ProductNameCheck(p.GetProductName());
            if (Check != "True")
            {
                return Check;
            }
            Check = IsValidProdInfo(p);
            return Check;
        }

        public static string IsValidProdInfo(ProductBL product)
        {
            string Check = "True";

            if (product.GetProductPrice()<=0)
            {
                return "Price cannot be 0 or less than 0!";
            }
            if (product.GetUnitsInStock()<0)
            {
                return "Stock cannot be less than 0!";
            }

            return Check;
        }

        public static string IsValidUpdatedProduct(ProductBL p, string productName)
        {
            string Check;

            if (p.GetProductName() == "" || p.GetProductDetails() == "" || p.GetUnitsInStock().ToString() == "" || p.GetProductPrice().ToString() == "")
            {
                return "Missing Information!";
            }
            if (p.GetProductName()!=productName)
            {
                return "ProductName cannot be updated!";
            }
            Check = IsValidProdInfo(p);
            return Check;
        }

        public static string ProductNameCheck(string product)
        {
            if (product.Length > 20)
            {
                return "Product name must not exceed 20 characters.";
            }

            foreach (char c in product)
            {
                if (!char.IsLetterOrDigit(c))
                {
                    return "ProductName must contain only letters and digits.";
                }
            }

            IProductDL check = new ProductDLDB();
            if (check.CheckProductName(product)!="True")
            {
                return "Product already exists!";
            }
            return "True";
        }

        public static string AdminUsernameCheck(string username, string u2)
        {
            string Check = "True";
            if (UsernameCheck(u2)!="True" && username!=u2)
            {
                Check=UsernameCheck(u2);
            }
            return Check;
        }

        public static string UpdatedEmailCheck(string email, string em2)
        {
            string Check = EmailCheck(em2);
            if (Check != "True" && em2!=email)
            {
                return Check;
            }
            return "True";
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

            IUserDL check = new CustomerDLDB();
            if (check.UniqueAttributeCheck(email, "Email"))
            {
                return "Email already exists!";
            }
            check = new EmployeeDLDB();
            return check.UniqueAttributeCheck(email, "Email") ? "Email already exists!" : "True";
        }

        public static string PasswordCheck(string password)
        {
            if (password.Length < 6 || password.Length > 20)
            {
                return "Password must be between 6 and 20 characters long.";
            }

            if (!password.Any(char.IsLetter) || !password.Any(char.IsDigit))
            {
                return "Password must contain at least one letter and one digit.";
            }

            return password.Any(char.IsWhiteSpace) ? "Password cannot contain spaces." : "True";
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

            IUserDL check = new CustomerDLDB();
            if (check.UniqueAttributeCheck(username, "Username"))
            {
                return "Username already exists!";
            }
            check = new EmployeeDLDB();
            return check.UniqueAttributeCheck(username, "Username") ? "Username already exists!" : "True";
        }

        public static string AgeCheck(DateTime dob)
        {
            DateTime cutoffDate = DateTime.Today.AddYears(-15);
            if (cutoffDate > dob)
            {
                return "True";
            }
            else
            {
                return "Age must be greater than 16 years!";
            }
        }

        public static string NameCheck(string text)
        {
            if (text.Length > 50)
            {
                return "Name must be smaller than 50 characters!";
            }

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
            return "True";
        }
    }
}
