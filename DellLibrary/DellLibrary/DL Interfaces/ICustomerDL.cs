using DellLibrary.BL;
using System.Collections.Generic;

namespace DellLibrary.DL_Interfaces
{
    public interface ICustomerDL
    {
        string AddCustomer(CustomerBL customer); // for adding a customer
        string RemoveCustomer(string username); // for removing a customer
        List<CustomerBL> GetAllCustomers(string s); // returns all active customers list
        List<CustomerBL> GetAllCustomers(); // returns all customers list
        int GetCustomerCount(); // returns customer count
        CustomerBL GetCustomerByUsername(string username); // returns customer corresponding to username of customer
    }
}
