using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DELL.BL
{
    internal class UserBL
    {
        protected string name;
        protected string username;
        protected string password;
        protected string email;
        protected DateTime dob;
        protected string address;
        protected string contact;
        protected string gender;
        protected string status;
        public UserBL() { }
        public UserBL(string username, string password)
        {
            this.username = username;
            this.password = password;
        }
        public UserBL(string name,string username,string password,string  email,DateTime dob,string address,string contact,string gender,string status)
        {
            this.name = name;
            this.username = username;
            this.password = password;
            this.email = email;
            this.dob = dob;
            this.address = address;
            this.contact = contact;
            this.gender = gender;
            this.status = status;
        }
        public string Name { get => name; set => name=value; }
        public string Username { get => username; set => username=value; }
        public string Password { get => password; set => password=value; }
        public string Email { get => email; set => email=value; }
        public DateTime Dob { get => dob; set => dob=value; }
        public string Address { get => address; set => address=value; }
        public string Contact { get => contact; set => contact=value; }
        public string Gender { get => gender; set => gender=value; }
        public string Status { get => status; set => status=value; }
    }
}
