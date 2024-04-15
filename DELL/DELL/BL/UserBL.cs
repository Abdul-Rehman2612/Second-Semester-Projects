using System;

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
        public UserBL(string name, string username, string password, string email, DateTime dob, string address, string contact, string gender, string status)
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
        public string GetName() { return name; }
        public void SetName(string value) { name = value; }
        public string GetUsername() { return username; }
        public void SetUsername(string value) { username = value; }
        public string GetPassword() { return password; }
        public void SetPassword(string value) { password = value; }
        public string GetEmail() { return email; }
        public void SetEmail(string value) { email = value; }
        public DateTime GetDob() { return dob; }
        public void SetDob(DateTime value) { dob = value; }
        public string GetAddress() { return address; }
        public void SetAddress(string value) { address = value; }
        public string GetContact() { return contact; }
        public void SetContact(string value) { contact = value; }
        public string GetGender() { return gender; }
        public void SetGender(string value) { gender = value; }
        public string GetStatus() { return status; }
        public void SetStatus(string value) { status = value; }
    }
}
