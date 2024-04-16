using DellLibrary.BL;

namespace DellLibrary.DL_Interfaces
{
    public interface ICustomerDL
    {
        string AddCustomer(CustomerBL customer); // calls function for adding customer
        string RemoveCustomer(string username); // calls function for removing a customer
        CustomerBL GetCustomer(); // calls function to get customer
    }
}
