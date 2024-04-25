using DELL.Utility;
using DellLibrary.BL;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DELL.UI.UsersUI
{
    public partial class CeoUI : Form
    {
        private EmployeeBL CEO = null; // CEO data stored
        private string username = null; // username checked for update
        private string email = null; // email checked for update
        private string type = null; // type checked for deactivated accounts
        private string productName = null;
        public CeoUI(EmployeeBL emp)
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized; // maximize windows size
            CEO = emp; // intializing the CEO object with the user data found
            LoadStats(); // loads statistical data for CEO
            LoadSalesPersonsData(); // loads SalesPersons data for CEO
            LoadTechniciansData(); // loads SalesPersons data for CEO
            LoadCustomersData(); // loads customers data for CEO
            LoadEmployeeOrdersData(); // loads orders placed by an employee
            LoadCustomersOrdersData(); // loads orders placed by a customer
            LoadDataForEmployeeID(); // loads data for employeeID in view orders
            LoadDataForCustomerID(); // loads data for customerID in view orders
            LoadDeactivatedUsersData(); // loads data for deactivated users in user view
            LoadProductsData(); // loads products data
            SelectionNull(); // clears selections of each gridview
            ClearInputsSP(); // clears input fields
            ClearInputsMT(); // clears input fields
            ClearInputsC(); // clears input fields
            ClearInputsEO(); // clears input fields
            ClearInputsCO(); // clears input fields
            ClearInputsDAU(); // clears input fields
            ClearInputsP(); // clear input fields
            LoadDataCEO();
        }

        private void LoadStats() // Loads statistical data for CEO
        {
            try
            {
                // Gets customer count
                int count = ObjectHandler.GetCustomerDL().GetCustomerCount();
                DataShow1.Text = $"Total Customers: {count}";

                // Gets employees count
                count = ObjectHandler.GetEmployeeDL().GetEmployeeCount();
                DataShow2.Text = $"Total Employees: {count-1}";

                // Gets orders count
                count = ObjectHandler.GetOrderDL().GetOrderCount();
                DataShow3.Text = $"Total Orders: {count}";

                // Gets products count
                count = ObjectHandler.GetProductDL().GetProductCount();
                DataShow4.Text = $"Total Products: {count}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadEntityData(string op) // Loads data for an entity based on operation type
        {
            SelectionNull();
            if (op == "SP")
            {
                LoadSalesPersonsData(); // Loads SalesPersons data for CEO
                ClearInputsSP(); // Clears input fields
                LoadDataForEmployeeID(); // Loads data for employeeID in view orders
            }
            else if (op == "T")
            {
                LoadTechniciansData(); // Loads Technicians data for CEO
                ClearInputsMT(); // Clears input fields
            }
            else if (op == "C")
            {
                LoadCustomersData(); // Loads customers data for CEO
                ClearInputsC(); // Clears input fields
                LoadDataForCustomerID(); // Loads data for customerID in view orders
            }
            LoadStats(); // Loads statistical data after entity data is loaded
            // set attributes null
            username=null;
            email=null;
        }
        private void SelectionNull() // Clears selection of DataGridViews
        {
            try
            {
                CGridView.ClearSelection(); // Clears selection of CGridView
                SPGridView.ClearSelection(); // Clears selection of SPGridView
                TGridView.ClearSelection(); // Clears selection of TGridView
                EOrdersGridView.ClearSelection(); // Clears selection of EOrdersGridView
                COGridView.ClearSelection(); // Clears selection of COGridView
                DAUGridView.ClearSelection(); // clears selection of DAUGridView
                PGridView.ClearSelection(); // clear selection PGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        //                               SalesPerson Operations
        private void LoadSalesPersonsData() // Loads salespersons' data into the SPGridView
        {
            try
            {
                // Retrieve salespersons' data from the data access layer
                SPGridView.DataSource = null; // Unbind the data source
                SPGridView.Rows.Clear(); // Clear the rows
                                         // Add rows to the DataGridView
                List<EmployeeBL> employees = ObjectHandler.GetEmployeeDL().GetEmployeesByDesignation("SalesPerson", "Active");
                foreach (EmployeeBL e in employees)
                {
                    SPGridView.Rows.Add(
                        e.GetName(),
                        e.GetUsername(),
                        e.GetPassword(),
                        e.GetEmail(),
                        e.GetDob(),
                        e.GetContact(),
                        e.GetAddress(),
                        e.GetGender(),
                        e.GetHireDate()
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ClearInputsSP() // Clears input fields for SalesPersons
        {
            NInputSP.Text="";
            UInputSP.Text="";
            PInputSP.Text="";
            EInputSP.Text="";
            AInputSP.Text="";
            CInputSP.Text="";
            GInputSP.Text="";
        }
        private void LoadDataIntoInputsSP(EmployeeBL employee) // Loads data into input fields for SalesPersons
        {
            NInputSP.Text=employee.GetName();
            UInputSP.Text=employee.GetUsername();
            PInputSP.Text=employee.GetPassword();
            EInputSP.Text=employee.GetEmail();
            AInputSP.Text=employee.GetAddress();
            CInputSP.Text=employee.GetContact();
            GInputSP.Text=employee.GetGender();
            DOBISP.Value=employee.GetDob();
        }
        private void SPGridView_SelectionChanged(object sender, EventArgs e) // Handles selection change in SPGridView
        {
            try
            {
                if (SPGridView.SelectedRows.Count > 0)
                {
                    // Retrieve selected row
                    DataGridViewRow selectedRow = SPGridView.SelectedRows[0];
                    if (selectedRow.Index >= 0 && selectedRow.Index < SPGridView.Rows.Count)
                    {
                        // Extract data from selected row
                        string name = selectedRow.Cells["Column1SP"].Value?.ToString();
                        string username = selectedRow.Cells["Column2SP"].Value?.ToString();
                        string password = selectedRow.Cells["Column3SP"].Value?.ToString();
                        string email = selectedRow.Cells["Column4SP"].Value?.ToString();
                        if (DateTime.TryParse(selectedRow.Cells["Column5SP"].Value?.ToString(), out DateTime dob))
                        {
                            // Successfully parsed the DOB
                            string contact = selectedRow.Cells["Column6SP"].Value?.ToString();
                            string address = selectedRow.Cells["Column7SP"].Value?.ToString();
                            string gender = selectedRow.Cells["Column8SP"].Value?.ToString();
                            string status = "Active";
                            string designation = "SalesPerson";

                            if (DateTime.TryParse(selectedRow.Cells["Column9SP"].Value?.ToString(), out DateTime hireDate))
                            {
                                // Successfully parsed the hire date
                                this.username = username;
                                this.email = email;
                                // Create employee object
                                EmployeeBL employee = new EmployeeBL(name, username, password, email, dob, address, contact, gender, status, designation, hireDate);
                                LoadDataIntoInputsSP(employee);
                            }
                            else
                            {
                                ClearInputsSP();
                            }
                        }
                        else
                        {
                            ClearInputsSP();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void AddSpbtn_Click(object sender, EventArgs e) // Handles addition of SalesPerson
        {
            // Create new SalesPerson object
            EmployeeBL user = new EmployeeBL(NInputSP.Text, UInputSP.Text, PInputSP.Text, EInputSP.Text, DOBISP.Value, AInputSP.Text, CInputSP.Text, GInputSP.Text, "Active", "SalesPerson", DateTime.Now);
            // Add SalesPerson using ObjectHandler
            string uStatus = ObjectHandler.GetEmployeeDL().AddEmployee(user);
            // Show status message
            if (uStatus=="True")
            {
                MessageBox.Show("SalesPerson data added successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadEntityData("SP"); // Load salespersons data
            }
            else
            {
                MessageBox.Show(uStatus, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void UpdateSpBtn_Click(object sender, EventArgs e) // Handles update of SalesPerson
        {
            // Check if username is provided
            if (UInputSP.Text!="" && username!=null && email!=null)
            {
                EmployeeBL employee = new EmployeeBL(NInputSP.Text, UInputSP.Text, PInputSP.Text, EInputSP.Text, DOBISP.Value, AInputSP.Text, CInputSP.Text, GInputSP.Text);
                // Update employee
                string message = ObjectHandler.GetEmployeeDL().UpdateEmployee(employee, username, email);
                if (message=="True")
                {
                    MessageBox.Show("SalesPerson data updated successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadEntityData("SP");
                }
                // if employee not deleted
                else
                {
                    MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void DeactivateSPBtn_Click(object sender, EventArgs e) // Handles deactivation of SalesPerson
        {
            // Check if username is provided
            if (UInputSP.Text!="")
            {
                // Deactivate employee
                string message = ObjectHandler.GetEmployeeDL().DeactivateEmployeeAccount(UInputSP.Text);
                if (message=="True")
                {
                    MessageBox.Show("SalesPerson account deactivated successfully!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadEntityData("SP"); // Load salespersons data
                    LoadDeactivatedUsersData(); // Loads data or deactivated users
                }
                // if employee not deactivated
                else
                {
                    MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void DeleteSpBtn_Click(object sender, EventArgs e) // Handles deletion of SalesPerson
        {
            // Check if username is provided
            if (UInputSP.Text!="")
            {
                // Remove employee
                string message = ObjectHandler.GetEmployeeDL().RemoveEmployee(UInputSP.Text);
                if (message=="True")
                {
                    MessageBox.Show("SalesPerson data deleted successfully!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadEntityData("SP"); // Load salespersons data
                }
                // if employee not deleted
                else
                {
                    MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        //                               Technicians Operations
        private void LoadTechniciansData() // Loads technicians' data into the TGridView
        {
            try
            {
                // Retrieve technicians' data from the data access layer
                TGridView.DataSource = null; // Unbind the data source
                TGridView.Rows.Clear(); // Clear the rows
                List<EmployeeBL> employees = ObjectHandler.GetEmployeeDL().GetEmployeesByDesignation("Technician", "Active");
                // Add rows to the DataGridView
                foreach (EmployeeBL e in employees)
                {
                    TGridView.Rows.Add(
                        e.GetName(),
                        e.GetUsername(),
                        e.GetPassword(),
                        e.GetEmail(),
                        e.GetDob(),
                        e.GetContact(),
                        e.GetAddress(),
                        e.GetGender(),
                        e.GetHireDate()
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ClearInputsMT() // Clears input fields for Technicians
        {
            NInputMT.Text="";
            UInputMT.Text="";
            PInputMT.Text="";
            EInputMT.Text="";
            AInputMT.Text="";
            CInputMT.Text="";
            GInputMT.Text="";
        }
        private void LoadDataIntoInputsMT(EmployeeBL employee) // Loads data into input fields for Technicians
        {
            NInputMT.Text=employee.GetName();
            UInputMT.Text=employee.GetUsername();
            PInputMT.Text=employee.GetPassword();
            EInputMT.Text=employee.GetEmail();
            AInputMT.Text=employee.GetAddress();
            CInputMT.Text=employee.GetContact();
            GInputMT.Text=employee.GetGender();
            DOBIMT.Value=employee.GetDob();
        }
        private void TGridView_SelectionChanged(object sender, EventArgs e) // Handles selection change in TGridView
        {
            try
            {
                if (TGridView.SelectedRows.Count > 0)
                {
                    // Retrieve selected row
                    DataGridViewRow selectedRow = TGridView.SelectedRows[0];
                    if (selectedRow.Index >= 0 && selectedRow.Index < TGridView.Rows.Count)
                    {
                        // Extract data from selected row
                        string name = selectedRow.Cells["Column1MT"].Value?.ToString();
                        string username = selectedRow.Cells["Column2MT"].Value?.ToString();
                        string password = selectedRow.Cells["Column3MT"].Value?.ToString();
                        string email = selectedRow.Cells["Column4MT"].Value?.ToString();
                        if (DateTime.TryParse(selectedRow.Cells["Column5MT"].Value?.ToString(), out DateTime dob))
                        {
                            // Successfully parsed the DOB
                            string contact = selectedRow.Cells["Column6MT"].Value?.ToString();
                            string address = selectedRow.Cells["Column7MT"].Value?.ToString();
                            string gender = selectedRow.Cells["Column8MT"].Value?.ToString();
                            string status = "Active";
                            string designation = "Technician";

                            if (DateTime.TryParse(selectedRow.Cells["Column9MT"].Value?.ToString(), out DateTime hireDate))
                            {
                                // Successfully parsed the hire date
                                // Create employee object
                                this.username = username;
                                this.email = email;
                                EmployeeBL employee = new EmployeeBL(name, username, password, email, dob, address, contact, gender, status, designation, hireDate);
                                LoadDataIntoInputsMT(employee);
                            }
                            else
                            {
                                ClearInputsMT();
                            }
                        }
                        else
                        {
                            ClearInputsMT();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void AddMTBtn_Click(object sender, EventArgs e) // Handles addition of Technician
        {
            // Create new Technician object
            EmployeeBL user = new EmployeeBL(NInputMT.Text, UInputMT.Text, PInputMT.Text, EInputMT.Text, DOBIMT.Value, AInputMT.Text, CInputMT.Text, GInputMT.Text, "Active", "Technician", DateTime.Now);
            // Add Technician using ObjectHandler
            string uStatus = ObjectHandler.GetEmployeeDL().AddEmployee(user);
            // Show status message
            if (uStatus=="True")
            {
                MessageBox.Show("Technician added successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadEntityData("T"); // Load technicians data
            }
            else
            {
                MessageBox.Show(uStatus, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void UpdateMTBtn_Click(object sender, EventArgs e) // Handles update of Technician
        {
            if (UInputMT.Text!=""  && username!=null && email!=null)
            {
                // Create new Technician object
                EmployeeBL user = new EmployeeBL(NInputMT.Text, UInputMT.Text, PInputMT.Text, EInputMT.Text, DOBIMT.Value, AInputMT.Text, CInputMT.Text, GInputMT.Text);
                string message = ObjectHandler.GetEmployeeDL().UpdateEmployee(user, username, email);
                if (message=="True")
                {
                    MessageBox.Show("Technician data updated successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadEntityData("T");
                }
                // if employee not updated
                else
                {
                    MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void DeleteMTBtn_Click(object sender, EventArgs e) // Handles deletion of Technician
        {
            if (UInputMT.Text!="")
            {
                // Remove employee
                string message = ObjectHandler.GetEmployeeDL().RemoveEmployee(UInputMT.Text);
                if (message=="True")
                {
                    MessageBox.Show("Technician data deleted successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadEntityData("T"); // Load technicians data
                }
                // if employee not deleted
                else
                {
                    MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void DeactivateMTBtn_Click(object sender, EventArgs e)
        {
            // Check if username is provided
            if (UInputMT.Text!="")
            {
                // Deactivate employee
                string message = ObjectHandler.GetEmployeeDL().DeactivateEmployeeAccount(UInputMT.Text);
                if (message=="True")
                {
                    MessageBox.Show("SalesPerson account deactivated successfully!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadEntityData("T"); // Load technicians data
                    LoadDeactivatedUsersData(); // Loads data or deactivated users
                }
                // if employee not deactivated
                else
                {
                    MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        //                               Customers Operations
        private void LoadCustomersData() // Loads customers' data into the CGridView
        {
            try
            {
                // Retrieve customers' data from the data access layer
                CGridView.DataSource = null; // Unbind the data source
                CGridView.Rows.Clear(); // Clear the rows
                List<CustomerBL> customers = ObjectHandler.GetCustomerDL().GetAllCustomersByStatus("Active");
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
        private void ClearInputsC() // Clears input fields for Customers
        {
            NInputC.Text="";
            UInputC.Text="";
            PInputC.Text="";
            EInputC.Text="";
            AInputC.Text="";
            CInputC.Text="";
            GInputC.Text="";
        }
        private void LoadDataIntoInputsC(CustomerBL customer) // Loads data into input fields for Customers
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
        private void CGridView_SelectionChanged(object sender, EventArgs e) // Handles selection change in CGridView
        {
            try
            {
                if (CGridView.SelectedRows.Count > 0)
                {
                    // Retrieve selected row
                    DataGridViewRow selectedRow = CGridView.SelectedRows[0];
                    if (selectedRow.Index >= 0 && selectedRow.Index < CGridView.Rows.Count)
                    {
                        // Extract data from selected row
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
                            this.username = username;
                            this.email = email;
                            // Create customer object
                            CustomerBL customer = new CustomerBL(name, username, password, email, dob, address, contact, gender, status);
                            LoadDataIntoInputsC(customer);
                        }
                        else
                        {
                            ClearInputsC();
                        }
                    }
                    else
                    {
                        ClearInputsC();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void AddCbtn_Click(object sender, EventArgs e) // Handles addition of Customer
        {
            // Create new Customer object
            CustomerBL user = new CustomerBL(NInputC.Text, UInputC.Text, PInputC.Text, EInputC.Text, DOBIC.Value, AInputC.Text, CInputC.Text, GInputC.Text, "Active");
            // Add Customer using ObjectHandler
            string uStatus = ObjectHandler.GetCustomerDL().AddCustomer(user);
            // Show status message
            if (uStatus=="True")
            {
                MessageBox.Show("Customer added successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadEntityData("C"); // Load customers data
            }
            else
            {
                MessageBox.Show(uStatus, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void UpdateCBtn_Click(object sender, EventArgs e) // Handles update of Customer
        {
            if (UInputC.Text!=""  && username!=null && email!=null)
            {
                // Create new customer object
                CustomerBL user = new CustomerBL(NInputC.Text, UInputC.Text, PInputC.Text, EInputC.Text, DOBIC.Value, AInputC.Text, CInputC.Text, GInputC.Text);
                string message = ObjectHandler.GetCustomerDL().UpdateCustomer(user, username, email);
                if (message=="True")
                {
                    MessageBox.Show("Customer data updated successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadEntityData("C");
                }
                // if customer not updated
                else
                {
                    MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void DeleteCBtn_Click(object sender, EventArgs e)  // Handles deletion of Customer
        {
            if (UInputC.Text!="")
            {
                // Remove customer
                string message = ObjectHandler.GetCustomerDL().RemoveCustomer(UInputC.Text);
                if (message=="True")
                {
                    MessageBox.Show("Customer data deleted successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadEntityData("C"); // Load customers data
                }
                // if customer not deleted
                else
                {
                    MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void DeactivateCBtn_Click(object sender, EventArgs e) // Handles deactivation of Customer
        {
            // Check if username is provided
            if (UInputC.Text!="")
            {
                // Deactivate customer
                string message = ObjectHandler.GetCustomerDL().DeactivateCustomerAccount(UInputC.Text);
                if (message=="True")
                {
                    MessageBox.Show("Customer account deactivated successfully!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadEntityData("C"); // Load customers data
                    LoadDeactivatedUsersData(); // Loads data or deactivated users
                }
                // if customer not deactivated
                else
                {
                    MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        //                               Employee Orders Operations
        private void LoadEmployeeOrdersData() // Load employee orders data
        {
            try
            {
                // Retrieve customers' data from the data access layer
                EOrdersGridView.DataSource = null; // Unbind the data source
                EOrdersGridView.Rows.Clear(); // Clear the rows
                List<CustomerBL> customers = ObjectHandler.GetCustomerDL().GetAllCustomers();
                // Add rows to the DataGridView
                foreach (CustomerBL c in customers)
                {
                    foreach (OrderBL order in c.GetOrders())
                    {
                        // Check if the order belongs to the selected employee
                        if (order.GetEmployee() != null && order.GetEmployee().GetUsername() == EmployeeIDEO.Text)
                        {
                            // Add order details to the DataGridView
                            EOrdersGridView.Rows.Add(
                                order.GetOrderID(),
                                c.GetUsername(),
                                order.GetEmployee().GetUsername(),
                                order.GetOrderType(),
                                order.GetOrderDate(),
                                order.GetTotalPrice()
                            );
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadDataForEmployeeID() // Load data for employee ID
        {
            try
            {
                List<EmployeeBL> emp = ObjectHandler.GetEmployeeDL().GetAllEmployees();
                EmployeeIDEO.Items.Clear();

                foreach (EmployeeBL employee in emp)
                {
                    // Add employee usernames to the combo box
                    EmployeeIDEO.Items.Add(employee.GetUsername());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void EmployeeIDEO_SelectionChanged(object sender, EventArgs e) // Load employee data
        {
            if (EmployeeIDEO.SelectedItem != null) // Check if an employee is selected
            {
                LoadEmployeeOrdersData(); // Load orders for the selected employee
                EmpTO.Text=ObjectHandler.GetOrderDL().GetOrderCountForEmployee(EmployeeIDEO.Text).ToString();
                EOrdersGridView.ClearSelection();
                ClearInputsEO();
            }
        }
        private void EOGridView_SelectionChanged(object sender, EventArgs e) // Handle selection change
        {
            try
            {
                if (EOrdersGridView.SelectedRows.Count > 0) // If row selected
                {
                    DataGridViewRow selectedRow = EOrdersGridView.SelectedRows[0]; // Get selected row
                    if (selectedRow.Index >= 0 && selectedRow.Index < EOrdersGridView.Rows.Count) // Valid index
                    {
                        if (int.TryParse(selectedRow.Cells["Column1EO"].Value?.ToString(), out int orderID)) // Parse order ID
                        {
                            string customerID = selectedRow.Cells["Column2EO"].Value?.ToString(); // Get customer ID
                            string employeeID = selectedRow.Cells["Column3EO"].Value?.ToString(); // Get employee ID
                            string orderType = selectedRow.Cells["Column4EO"].Value?.ToString(); // Get order type
                            if (DateTime.TryParse(selectedRow.Cells["Column5EO"].Value?.ToString(), out DateTime orderDate)) // Parse order date
                            {
                                if (double.TryParse(selectedRow.Cells["Column6EO"].Value?.ToString(), out double totalPrice)) // Parse total price
                                {
                                    EmployeeBL employee = ObjectHandler.GetEmployeeDL().GetEmployeebyUsername(employeeID); // Get employee
                                    OrderBL order = new OrderBL(orderID, orderType, orderDate, employee, totalPrice); // Create order
                                    LoadDataIntoInputsEO(order, customerID); // Load data
                                }
                            }
                        }
                        else
                        {
                            ClearInputsEO(); // Clear inputs
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); // Show error
            }
        }
        private void ClearInputsEO() // Clear input fields related to employee orders
        {
            CustomerIDTXT.Text = "";
            OrderDateTXT.Text = "";
            PriceTXT.Text = "";
            OrderIDTXT.Text = "";
        }
        private void LoadDataIntoInputsEO(OrderBL order, string customerID) // Load order data into input fields related to employee orders
        {
            CustomerIDTXT.Text = customerID;
            OrderDateTXT.Text = order.GetOrderDate().ToString("yyyy-MM-dd");
            OrderIDTXT.Text = order.GetOrderID().ToString();
            PriceTXT.Text = order.GetTotalPrice().ToString();
        }



        //                               Customer Orders Operations
        private void LoadCustomersOrdersData() // Load customer order into grid
        {
            try
            {
                // Retrieve customers' data from the data access layer
                COGridView.DataSource = null; // Unbind the data source
                COGridView.Rows.Clear(); // Clear the rows
                List<CustomerBL> customers = ObjectHandler.GetCustomerDL().GetAllCustomers();
                // Add rows to the DataGridView
                foreach (CustomerBL c in customers)
                {
                    foreach (OrderBL order in c.GetOrders())
                    {
                        // Check if the order belongs to the selected customer
                        if (c.GetUsername() == CustomerIDCO.Text && order.GetEmployee()!=null)
                        {
                            // Add order details to the DataGridView
                            _=COGridView.Rows.Add(
                                order.GetOrderID(),
                                c.GetUsername(),
                                order.GetEmployee().GetUsername(),
                                order.GetOrderType(),
                                order.GetOrderDate(),
                                order.GetTotalPrice()
                            );
                        }
                        else if (c.GetUsername() == CustomerIDCO.Text && order.GetEmployee()==null)
                        {
                            _=COGridView.Rows.Add(
                                order.GetOrderID(),
                                c.GetUsername(),
                                "N.A.",
                                order.GetOrderType(),
                                order.GetOrderDate(),
                                order.GetTotalPrice()
                            );
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadDataForCustomerID() // Load data for customer ID
        {
            try
            {
                List<CustomerBL> customers = ObjectHandler.GetCustomerDL().GetAllCustomers();
                CustomerIDCO.Items.Clear();

                foreach (CustomerBL cust in customers)
                {
                    // Add customer usernames to the combo box
                    CustomerIDCO.Items.Add(cust.GetUsername());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CustomerIDCO_SelectionChanged(object sender, EventArgs e) // Load customer data
        {
            if (CustomerIDCO.SelectedItem != null) // Check if selected
            {
                LoadCustomersOrdersData(); // Load orders
                CustTO.Text=ObjectHandler.GetOrderDL().GetOrderCountForCustomer(CustomerIDCO.Text).ToString();
                COGridView.ClearSelection();
                ClearInputsCO();
            }
        }
        private void COGridView_SelectionChanged(object sender, EventArgs e) // Handle selection change
        {
            try
            {
                if (COGridView.SelectedRows.Count > 0) // If row selected
                {
                    DataGridViewRow selectedRow = COGridView.SelectedRows[0]; // Get selected row
                    if (selectedRow.Index >= 0 && selectedRow.Index < COGridView.Rows.Count) // Valid index
                    {
                        if (int.TryParse(selectedRow.Cells["Column1CO"].Value?.ToString(), out int orderID)) // Parse order ID
                        {
                            string customerID = selectedRow.Cells["Column2CO"].Value?.ToString(); // Get customer ID
                            string employeeID = selectedRow.Cells["Column3CO"].Value?.ToString(); // Get employee ID
                            string orderType = selectedRow.Cells["Column4CO"].Value?.ToString(); // Get order type
                            if (DateTime.TryParse(selectedRow.Cells["Column5CO"].Value?.ToString(), out DateTime orderDate)) // Parse order date
                            {
                                if (double.TryParse(selectedRow.Cells["Column6CO"].Value?.ToString(), out double totalPrice)) // Parse total price
                                {
                                    string customername = ObjectHandler.GetCustomerDL().GetCustomerByUsername(customerID).GetName(); // Get customer name
                                    EmployeeBL employee = ObjectHandler.GetEmployeeDL().GetEmployeebyUsername(employeeID); // Get employee
                                    OrderBL order = new OrderBL(orderID, orderType, orderDate, employee, totalPrice); // Create order
                                    LoadDataIntoInputsCO(order); // Load data
                                }
                            }
                        }
                        else
                        {
                            ClearInputsCO(); // Clear inputs
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); // Show error
            }
        }
        private void ClearInputsCO() // Clear input fields related to customer orders
        {
            EmployeeIDCOTXT.Text = "";
            OrderDateCOTXT.Text = "";
            TotalPriceCO.Text = "";
            OIDTXT.Text = "";
        }
        private void LoadDataIntoInputsCO(OrderBL order) // Load order data into input fields related to customer orders
        {
            if(order.GetEmployee()!=null)
            {
                EmployeeIDCOTXT.Text = order.GetEmployee().GetUsername();
            }
            else
            {
                EmployeeIDCOTXT.Text ="N.A";
            }
            OrderDateCOTXT.Text = order.GetOrderDate().ToString("yyyy-MM-dd");
            OIDTXT.Text = order.GetOrderID().ToString();
            TotalPriceCO.Text = order.GetTotalPrice().ToString();
        }



        //                               Deactivated users Operations
        private void LoadDeactivatedUsersData() // Load user data into grid
        {
            try
            {
                List<EmployeeBL> employees = ObjectHandler.GetEmployeeDL().GetAllEmployeesByStatus("Deactivated"); // Loads deactivated employees
                List<CustomerBL> customers = ObjectHandler.GetCustomerDL().GetAllCustomersByStatus("Deactivated"); // Loads deactivated customers
                DAUGridView.DataSource = null; // Unbind the data source
                DAUGridView.Rows.Clear(); // Clear the rows
                foreach (EmployeeBL u in employees)
                {
                    DAUGridView.Rows.Add(
                        u.GetName(),
                        u.GetUsername(),
                        u.GetPassword(),
                        u.GetEmail(),
                        u.GetDob(),
                        u.GetContact(),
                        u.GetAddress(),
                        u.GetGender(),
                        "Employee"
                    );
                }
                foreach (CustomerBL u in customers)
                {
                    DAUGridView.Rows.Add(
                        u.GetName(),
                        u.GetUsername(),
                        u.GetPassword(),
                        u.GetEmail(),
                        u.GetDob(),
                        u.GetContact(),
                        u.GetAddress(),
                        u.GetGender(),
                        "Customer"
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void DAUGridView_SelectionChanged(object sender, EventArgs e)// Load user data
        {
            try
            {
                if (DAUGridView.SelectedRows.Count > 0)
                {
                    // Retrieve selected row
                    DataGridViewRow selectedRow = DAUGridView.SelectedRows[0];
                    if (selectedRow.Index >= 0 && selectedRow.Index < DAUGridView.Rows.Count)
                    {
                        // Extract data from selected row
                        string name = selectedRow.Cells["Column1D"].Value?.ToString();
                        string username = selectedRow.Cells["Column2D"].Value?.ToString();
                        string password = selectedRow.Cells["Column3D"].Value?.ToString();
                        string email = selectedRow.Cells["Column4D"].Value?.ToString();
                        if (DateTime.TryParse(selectedRow.Cells["Column5D"].Value?.ToString(), out DateTime dob))
                        {
                            // Successfully parsed the DOB
                            string contact = selectedRow.Cells["Column6D"].Value?.ToString();
                            string address = selectedRow.Cells["Column7D"].Value?.ToString();
                            string gender = selectedRow.Cells["Column8D"].Value?.ToString();
                            string type = selectedRow.Cells["Column9D"].Value?.ToString();
                            // Create user object
                            UserBL user = new UserBL(name, username, password, email, dob, address, contact, gender, "Deactivated");
                            LoadDataIntoInputsDAU(user, type);
                        }
                        else
                        {
                            ClearInputsDAU();
                        }
                    }
                    else
                    {
                        ClearInputsDAU();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ClearInputsDAU() // Clears input fields for deactivated users
        {
            ND.Text="";
            UD.Text="";
            PD.Text="";
            ED.Text="";
            AD.Text="";
            CD.Text="";
            GD.Text="";
            DD.Text="";
            type = null;
        }
        private void LoadDataIntoInputsDAU(UserBL user, string type) // Load user data into input fields
        {
            ND.Text=user.GetName();
            UD.Text=user.GetUsername();
            PD.Text=user.GetPassword();
            ED.Text=user.GetEmail();
            AD.Text=user.GetAddress();
            CD.Text=user.GetContact();
            GD.Text=user.GetGender();
            DD.Text=user.GetDob().ToString("yyyy-MM-dd");
            this.type = type;
        }



        //                               Deactivated users Operations
        private void ActivateAccBtn_Click(object sender, EventArgs e) // Handles activation of user
        {
            // Check if username is provided
            if (UD.Text!="")
            {
                // Activate customer
                if (type=="Customer")
                {
                    string message = ObjectHandler.GetCustomerDL().ActivateCustomerAccount(UD.Text);
                    if (message=="True")
                    {
                        MessageBox.Show("Customer account activated successfully!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadEntityData("C"); // Load customers data
                        LoadDeactivatedUsersData(); // Loads data of deactivated users
                        ClearInputsDAU(); // clears fields
                    }
                    // if customer not activated
                    else
                    {
                        MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if(type=="Employee")
                {
                    string message = ObjectHandler.GetEmployeeDL().ActivateEmployeeAccount(UD.Text);
                    if (message=="True")
                    {
                        MessageBox.Show("Employee account activated successfully!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadEntityData("T"); // Load customers data
                        LoadEntityData("SP"); // Load customers data
                        LoadDeactivatedUsersData(); // Loads data of deactivated users
                        ClearInputsDAU(); // clears fields
                    }
                    // if employee not activated
                    else
                    {
                        MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void DeleteAccBtn_Click(object sender, EventArgs e) // Handles deletion of user
        {
            // Check if username is provided
            if (UD.Text!="")
            {
                // Activate customer
                if (type=="Customer")
                {
                    string message = ObjectHandler.GetCustomerDL().RemoveCustomer(UD.Text);
                    if (message=="True")
                    {
                        MessageBox.Show("Customer account deleted successfully!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadEntityData("C"); // Load customers data
                        LoadDeactivatedUsersData(); // Loads data of deactivated users
                        ClearInputsDAU(); // clears fields
                    }
                    // if customer not deleted
                    else
                    {
                        MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (type=="Employee")
                {
                    string message = ObjectHandler.GetEmployeeDL().RemoveEmployee(UD.Text);
                    if (message=="True")
                    {
                        MessageBox.Show("Employee account deleted successfully!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadEntityData("T"); // Load customers data
                        LoadEntityData("SP"); // Load customers data
                        LoadDeactivatedUsersData(); // Loads data of deactivated users
                        ClearInputsDAU(); // clears fields
                    }
                    // if employee not deleted
                    else
                    {
                        MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }




        //                               Manage Products
        private void LoadProductsData() // Loads products' data into the CGridView
        {
            try
            {
                // Retrieve products' data from the data access layer
                PGridView.DataSource = null; // Unbind the data source
                PGridView.Rows.Clear(); // Clear the rows
                List<ProductBL> products = ObjectHandler.GetProductDL().GetAllProducts();
                // Add rows to the DataGridView
                foreach (ProductBL p in products)
                {
                    PGridView.Rows.Add(
                        p.GetProductID(),
                        p.GetProductName(),
                        p.GetProductDetails(),
                        p.GetProductPrice(),
                        p.GetUnitsInStock()
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ClearInputsP() // Clears input fields for Products
        {
            ProdNamInput.Text = "";
            ProdDetInput.Text = "";
            UnitStockInput.Text = "";
            ProdPriceInput.Text = "";
            PInput.Text="";
            productName=null;
        }
        private void LoadDataIntoInputsP(ProductBL product) // Loads data into input fields for Products
        {
            ProdNamInput.Text = product.GetProductName();
            ProdDetInput.Text = product.GetProductDetails();
            UnitStockInput.Text = product.GetUnitsInStock().ToString();
            ProdPriceInput.Text = product.GetProductPrice().ToString();
            PInput.Text=product.GetProductID().ToString();
            productName = product.GetProductName();
        }
        private void PGridView_SelectionChanged(object sender, EventArgs e) // Handles selection change in CGridView
        {
            try
            {
                if (PGridView.SelectedRows.Count > 0)
                {
                    // Retrieve selected row
                    DataGridViewRow selectedRow = PGridView.SelectedRows[0];
                    if (selectedRow.Index >= 0 && selectedRow.Index < PGridView.Rows.Count)
                    {
                        // Extract data from selected row
                        int productID = Convert.ToInt32(selectedRow.Cells["Column1P"].Value);
                        string productName = selectedRow.Cells["Column2P"].Value?.ToString();
                        string productDetails = selectedRow.Cells["Column3P"].Value?.ToString();
                        double price = Convert.ToDouble(selectedRow.Cells["Column4P"].Value);
                        int unitsInStock = Convert.ToInt32(selectedRow.Cells["Column5P"].Value);
                        // Create product object
                        ProductBL product = new ProductBL(productID,productName, productDetails, price, unitsInStock);
                        LoadDataIntoInputsP(product);
                    }
                    else
                    {
                        ClearInputsP();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void AddProductButton_Click(object sender, EventArgs e) // Handles addition of Product
        {
            try
            {
                if (!string.IsNullOrEmpty(ProdNamInput.Text))
                {
                    double price;
                    int unitsInStock;

                    // Check if entered price is valid
                    if (!double.TryParse(ProdPriceInput.Text, out price))
                    {
                        MessageBox.Show("Invalid price format!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Check if entered units in stock is valid
                    if (!int.TryParse(UnitStockInput.Text, out unitsInStock))
                    {
                        MessageBox.Show("Invalid units in stock format!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Create new Product object
                    ProductBL product = new ProductBL(ProdNamInput.Text, ProdDetInput.Text, price, unitsInStock);
                    // Add Product using ObjectHandler
                    string status = ObjectHandler.GetProductDL().AddProduct(product);
                    // Show status message
                    if (int.TryParse(status, out int productId) && productId > 0)
                    {
                        MessageBox.Show("Product added successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadProductsData(); // Load products data
                        ClearInputsP();
                        LoadStats();
                    }
                    else
                    {
                        MessageBox.Show(status, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Missing Info!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void UpdateProductButton_Click(object sender, EventArgs e) // Handles update of Product
        {
            try
            {
                if (!string.IsNullOrEmpty(ProdNamInput.Text))
                {
                    double price;
                    int unitsInStock;

                    // Check if entered price is valid
                    if (!double.TryParse(ProdPriceInput.Text, out price))
                    {
                        MessageBox.Show("Invalid price format!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Check if entered units in stock is valid
                    if (!int.TryParse(UnitStockInput.Text, out unitsInStock))
                    {
                        MessageBox.Show("Invalid units in stock format!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Create new product object
                    ProductBL product = new ProductBL(Convert.ToInt16(PInput.Text), ProdNamInput.Text, ProdDetInput.Text, price, unitsInStock);
                    string message = ObjectHandler.GetProductDL().UpdateProduct(product, productName);
                    if (message == "True")
                    {
                        MessageBox.Show("Product data updated successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadProductsData();
                        ClearInputsP();
                    }
                    else
                    {
                        MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void DeleteProductButton_Click(object sender, EventArgs e) // Handles deletion of Product
        {
            if (!string.IsNullOrEmpty(PInput.Text))
            {
                // Remove product
                string message = ObjectHandler.GetProductDL().DeleteProduct(Convert.ToInt16(PInput.Text));
                if (message == "True")
                {
                    MessageBox.Show("Product data deleted successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadProductsData(); // Load products data
                    ClearInputsP();
                    LoadStats();
                }
                // if product not deleted
                else
                {
                    MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void bunifuButton4_Click(object sender, EventArgs e)
        {
            // Check if username is provided
            username=CEO.GetUsername();
            email=CEO.GetEmail();
            if (UNI.Text!="" && username!=null && email!=null)
            {
                EmployeeBL employee = new EmployeeBL(UnameI.Text, UNI.Text, UPI.Text, UEI.Text, DOBI.Value, UAI.Text, UCI.Text, UGI.Text,"Active","CEO",CEO.GetHireDate());
                // Update employee
                string message = ObjectHandler.GetEmployeeDL().UpdateEmployee(employee, username, email);
                if (message=="True")
                {
                    MessageBox.Show("Admin updated successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadEntityData("SP");
                    CEO.SetName(UnameI.Text); CEO.SetUsername(UNI.Text);CEO.SetPassword(UPI.Text);CEO.SetEmail(UEI.Text);CEO.SetDob(DOBI.Value);CEO.SetAddress(UAI.Text);CEO.SetContact(UCI.Text);CEO.SetGender(UGI.Text);
                    username=null;
                    LoadDataCEO();
                    email=null;
                }
                // if employee not deleted
                else
                {
                    MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void LoadDataCEO()
        {
            UnameI.Text=CEO.GetName();
            UNI.Text=CEO.GetUsername();
            UPI.Text=CEO.GetPassword();
            UEI.Text=CEO.GetEmail();
            DOBI.Value=CEO.GetDob();
            UCI.Text=CEO.GetContact();
            UAI.Text=CEO.GetAddress();
            UGI.Text=CEO.GetGender();
        }
        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
        }
    }
}
