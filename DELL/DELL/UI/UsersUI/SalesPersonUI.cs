using DELL.Utility;
using DellLibrary.BL;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DELL.UI.UsersUI
{
    public partial class SalesPersonUI : Form
    {
        EmployeeBL SalesPerson = null;
        public SalesPersonUI(EmployeeBL emp)
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized; // maximize windows size
            SalesPerson = emp; // intializing the salesperson object with the userdata found
            LoadStats(); // loads statistical data for SalesPerson
            LoadCustomersData(); // loads customers data for SalesPerson
            ClearInputsC(); // clears input fields
        }
        private void LoadStats() // loads statistical data for CEO
        {
            try
            {
                int count = ObjectHandler.GetCustomerDL().GetCustomerCount(); // gets customer count
                DataShow1.Text=$"Total Customers: {count}";
                count = ObjectHandler.GetOrderDL().GetOrderCount(SalesPerson.GetUsername()); // gets employees count
                DataShow2.Text=$"Orders Placed: {count}";
                count = ObjectHandler.GetOrderDL().GetOrderCount(); // gets orders count
                DataShow3.Text=$"Total Orders: {count}";
                count = ObjectHandler.GetProductDL().GetProductCount(); // gets products count
                DataShow4.Text=$"Total Products: {count}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadEntityData(string op) // loads data for an entity
        {
            if (op=="C")
            {
                LoadCustomersData(); // loads customers data for CEO
                ClearInputsC(); // clears input fields
            }
            LoadStats();
        }


        //                           Customers Operations
        private void LoadCustomersData()
        {
            try
            {
                // Retrieve customers' data from the data access layer
                CGridView.DataSource = null; // Unbind the data source
                CGridView.Rows.Clear(); // Clear the rows
                List<CustomerBL> customers = ObjectHandler.GetCustomerDL().GetAllCustomers("Active");
                // Add rows to the DataGridView
                foreach (CustomerBL c in customers)
                {
                    CGridView.Rows.Add(
                        c.GetName(),
                        c.GetUsername(),
                        c.GetPassword(),
                        c.GetEmail(),
                        c.GetDob(),
                        c.GetContact(),
                        c.GetAddress(),
                        c.GetGender()
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ClearInputsC()
        {
            NInputC.Text="";
            UInputC.Text="";
            PInputC.Text="";
            EInputC.Text="";
            AInputC.Text="";
            CInputC.Text="";
            GInputC.Text="";
        }
        private void LoadDataIntoInputsC(CustomerBL customer)
        {
            NInputC.Text=customer.GetName();
            UInputC.Text=customer.GetUsername();
            PInputC.Text=customer.GetPassword();
            EInputC.Text=customer.GetEmail();
            AInputC.Text=customer.GetAddress();
            CInputC.Text=customer.GetContact();
            GInputC.Text=customer.GetGender();
            DOBIC.Value=customer.GetDob();
        }
        private void CGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (CGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = CGridView.SelectedRows[0];
                if (selectedRow.Index >= 0 && selectedRow.Index < CGridView.Rows.Count)
                {
                    string name = selectedRow.Cells["Column1C"].Value?.ToString();
                    string username = selectedRow.Cells["Column2C"].Value?.ToString();
                    string password = selectedRow.Cells["Column3C"].Value?.ToString();
                    string email = selectedRow.Cells["Column4C"].Value?.ToString();
                    if (DateTime.TryParse(selectedRow.Cells["Column5C"].Value?.ToString(), out DateTime dob))
                    {
                        // Successfully parsed the DOB
                        string contact = selectedRow.Cells["Column6C"].Value?.ToString();
                        string address = selectedRow.Cells["Column7C"].Value?.ToString();
                        string gender = selectedRow.Cells["Column8C"].Value?.ToString();
                        string status = "Active";
                        CustomerBL customer = new CustomerBL(name, username, password, email, dob, address, contact, gender, status);
                        LoadDataIntoInputsC(customer);
                    }
                    else
                    {
                        ClearInputsC();
                    }
                }
            }
        }
        private void AddCbtn_Click(object sender, EventArgs e)
        {
            // makes new user object
            CustomerBL user = new CustomerBL(NInputC.Text, UInputC.Text, PInputC.Text, EInputC.Text, DOBIC.Value, AInputC.Text, CInputC.Text, GInputC.Text, "Active");
            // calls Object Handler to call customer interface to add customer
            string uStatus = ObjectHandler.GetCustomerDL().AddCustomer(user);
            // if customer added successfully
            if (uStatus=="True")
            {
                MessageBox.Show("Customer added successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadEntityData("C"); // loads customers data
            }
            // if customer not added
            else
            {
                MessageBox.Show(uStatus, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void UpdateCBtn_Click(object sender, EventArgs e)
        {

        }
        private void DeleteCBtn_Click(object sender, EventArgs e)
        {
            if (UInputC.Text!="")
            {
                string message = ObjectHandler.GetCustomerDL().RemoveCustomer(UInputC.Text);
                if (message=="True")
                {
                    MessageBox.Show("Customer data deleted successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadEntityData("C"); // loads customers data
                }
                // if customer not deleted
                else
                {
                    MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void Backbtn_Click(object sender, EventArgs e)
        {
            Hide();
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
        }
    }
}
