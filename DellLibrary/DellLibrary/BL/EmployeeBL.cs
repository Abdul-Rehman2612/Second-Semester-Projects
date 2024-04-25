using System;

namespace DellLibrary.BL
{
    public class EmployeeBL : UserBL
    {
        private string designation; 
        readonly private DateTime hireDate; 
        private DateTime resignationDate;

        public EmployeeBL(string name, string username, string password, string email, DateTime dob, string address, string contact, string gender, string status, string designation, DateTime hireDate, DateTime resignationDate) : base(name, username, password, email, dob, address, contact, gender, status)
        {
            this.designation = designation;
            this.hireDate = hireDate;
            this.resignationDate = resignationDate;
        }

        public EmployeeBL(string name, string username, string password, string email, DateTime dob, string address, string contact, string gender, string status, string designation, DateTime hireDate) : base(name, username, password, email, dob, address, contact, gender, status)
        {
            this.designation = designation;
            this.hireDate = hireDate;
        }

        public EmployeeBL(string name, string username, string password, string email, DateTime dob, string address, string contact, string gender) : base(name, username, password, email, dob, address, contact, gender)
        {
        }

        public EmployeeBL() { }
        public EmployeeBL(string username, string password) : base(username, password) { }

        public string GetDesignation() { return designation; } 
        public void SetDesignation(string value) { designation = value; } 
        public DateTime GetHireDate() { return hireDate; } 
        public DateTime GetResignationDate() { return resignationDate; } 
        public void SetResignationDate(DateTime value) { resignationDate = value; } 
    }

}
