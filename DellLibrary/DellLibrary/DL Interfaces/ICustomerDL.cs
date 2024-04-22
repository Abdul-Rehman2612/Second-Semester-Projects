using DellLibrary.BL;
using System.Collections.Generic;

namespace DellLibrary.DL_Interfaces
{
    public interface ICustomerDL
    {
        string AddCustomer(CustomerBL customer); // for adding a customer
        string RemoveCustomer(string username); // for removing a customer
        string UpdateCustomer(CustomerBL customer,string username,string email); // for removing a customer
        List<CustomerBL> GetAllCustomersByStatus(string s); // returns all customers list by status
        List<CustomerBL> GetAllCustomers(); // returns all customers list
        int GetCustomerCount(); // returns customer count
        CustomerBL GetCustomerByUsername(string username); // returns customer corresponding to username of customer
    }
}
