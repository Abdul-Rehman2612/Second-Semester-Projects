using DellLibrary.BL;
using System.Collections.Generic;

namespace DellLibrary.DL_Interfaces
{
    public interface ICustomerDL
    {
        string AddCustomer(CustomerBL customer);
        string RemoveCustomer(string username);
        string DeactivateCustomerAccount(string username);
        string ActivateCustomerAccount(string username);
        string UpdateCustomer(CustomerBL customer, string username, string email);
        List<CustomerBL> GetAllCustomersByStatus(string s);
        List<CustomerBL> GetAllCustomers();
        int GetCustomerCount();
        CustomerBL GetCustomerByUsername(string username);
    }
}
