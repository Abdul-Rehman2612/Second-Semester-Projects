using System;

namespace DellLibrary.BL
{
    public class EmployeeBL : UserBL
    {
        private string designation; // Employee's job title
        readonly private DateTime hireDate; // Date of employment
        private DateTime resignationDate; // Date of resignation

        // Full constructor with resignation date
        public EmployeeBL(string name, string username, string password, string email, DateTime dob, string address, string contact, string gender, string status, string designation, DateTime hireDate, DateTime resignationDate) : base(name, username, password, email, dob, address, contact, gender, status)
        {
            this.designation = designation;
            this.hireDate = hireDate;
            this.resignationDate = resignationDate;
        }

        // Constructor without resignation date
        public EmployeeBL(string name, string username, string password, string email, DateTime dob, string address, string contact, string gender, string status, string designation, DateTime hireDate) : base(name, username, password, email, dob, address, contact, gender, status)
        {
            this.designation = designation;
            this.hireDate = hireDate;
        }

        // Constructor with basic details
        public EmployeeBL(string name, string username, string password, string email, DateTime dob, string address, string contact, string gender) : base(name, username, password, email, dob, address, contact, gender)
        {
        }

        public EmployeeBL() { } // Default constructor
        public EmployeeBL(string username, string password) : base(username, password) { } // Constructor with only username and password

        public string GetDesignation() { return designation; } // Get employee designation
        public void SetDesignation(string value) { designation = value; } // Set employee designation
        public DateTime GetHireDate() { return hireDate; } // Get hire date
        public DateTime GetResignationDate() { return resignationDate; } // Get resignation date
        public void SetResignationDate(DateTime value) { resignationDate = value; } // Set resignation date
    }

}
