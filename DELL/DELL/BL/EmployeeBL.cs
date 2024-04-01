using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DELL.BL
{
    internal class EmployeeBL:UserBL
    {
        private string designation;
        private DateTime hireDate;
        private DateTime resignationDate;
        public EmployeeBL(string name, string username, string password, string email, string dob, string address, string contact, string gender, string status, string designation, DateTime hireDate) : base(name, username, password, email, dob, address, contact, gender, status)
        { 
            this.designation = designation;
            this.hireDate = hireDate;
        }
        public EmployeeBL(string username, string password) : base(username, password)
        { }
        public string GetDesignation() { return designation;}
        public DateTime GetHireDate() {  return hireDate;}
        public DateTime GetResignationDate() {  return resignationDate;}
        public void SetResignationDate(DateTime resignationDate) { this.resignationDate=resignationDate; }
    }
}
