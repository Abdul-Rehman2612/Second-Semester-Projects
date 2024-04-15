using DELL.BL;

namespace DELL.DL_Interface
{
    internal interface ICustomerDL
    {
        string AddCustomer(CustomerBL customer); // calls function for adding customer
        string RemoveCustomer(string username); // calls function for removing a customer
        CustomerBL GetCustomer(); // calls function to get customer
    }
}
