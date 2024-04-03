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
        public string Designation { get => designation; set => designation=value; }
        public DateTime HireDate { get => hireDate; set => hireDate=value; }
        public DateTime ResignationDate { get => resignationDate; set => resignationDate=value; }
        public EmployeeBL(string name, string username, string password, string email, DateTime dob, string address, string contact, string gender, string status, string designation, DateTime hireDate) : base(name, username, password, email, dob, address, contact, gender, status)
        { 
            this.designation = designation;
            this.hireDate = hireDate;
        }
        public EmployeeBL(string username, string password) : base(username, password)
        { }
        
    }
}
