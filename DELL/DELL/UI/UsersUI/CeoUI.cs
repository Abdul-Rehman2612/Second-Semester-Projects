using DELL.Utility;
using DellLibrary.BL;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DELL.UI.UsersUI
{
    public partial class CeoUI : Form
    {
        private EmployeeBL CEO = null; // CEO data stored
        public CeoUI(EmployeeBL emp)
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized; // maximize windows size
            CEO = emp; // intializing the CEO object with the userdata found
            LoadStats(); // loads statistical data for CEO
            LoadSalesPersonsData(); // loads SalesPersons data for CEO
            LoadTechniciansData(); // loads SalesPersons data for CEO
            LoadCustomersData(); // loads customers data for CEO
            ClearInputsSP(); // clears input fields
            ClearInputsMT(); // clears input fields
            ClearInputsC(); // clears input fields
        }
        private void LoadStats()
        {
            try
            {
                int count = ObjectHandler.GetCustomerDL().GetCustomerCount(); // gets customer count
                DataShow1.Text=$"Total Customers: {count}";
                count = ObjectHandler.GetEmployeeDL().GetEmployeeCount(); // gets employees count
                DataShow2.Text=$"Total Employees: {count-1}";
                count = ObjectHandler.GetOrderDL().GetOrderCount(); // gets orders count
                DataShow3.Text=$"Total Orders: {count}";
                count = ObjectHandler.GetProductDL().GetProductCount(); // gets products count
                DataShow4.Text=$"Total Products: {count}";
            }
            catch (Exception e) // if any exception returns the exception message
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //                           SalesPersons Operations
        private void LoadSalesPersonsData()
        {
            try
            {
                // Retrieve salespersons' data from the data access layer
                SPGridView.DataSource = null; // Unbind the data source
                SPGridView.Rows.Clear(); // Clear the rows
                                         // Add rows to the DataGridView
                List<EmployeeBL> employees = ObjectHandler.GetEmployeeDL().GetEmployeesByDesignation("SalesPerson");
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
        private void ClearInputsSP()
        {
            NInputSP.Text="";
            UInputSP.Text="";
            PInputSP.Text="";
            EInputSP.Text="";
            AInputSP.Text="";
            CInputSP.Text="";
            GInputSP.Text="";
            DOBISP.Value = DateTime.Now.AddDays(-1);
        }
        private void LoadDataIntoInputsSP(EmployeeBL employee)
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
        private void SPGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (SPGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = SPGridView.SelectedRows[0];
                if (selectedRow.Index >= 0 && selectedRow.Index < SPGridView.Rows.Count)
                {
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
        private void AddSpbtn_Click(object sender, EventArgs e)
        {
            // makes new user object
            EmployeeBL user = new EmployeeBL(NInputSP.Text, UInputSP.Text, PInputSP.Text, EInputSP.Text, DOBISP.Value, AInputSP.Text, CInputSP.Text, GInputSP.Text, "Active", "SalesPerson", DateTime.Now);
            // calls Object Handler to call employee interface to add employee
            string uStatus = ObjectHandler.GetEmployeeDL().AddEmployee(user);
            // if employee added successfully
            if (uStatus=="True")
            {
                MessageBox.Show("SalesPerson data added successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadSalesPersonsData();
                ClearInputsSP();
            }
            // if employee not added
            else
            {
                MessageBox.Show(uStatus, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void UpdateSpBtn_Click(object sender, EventArgs e)
        {
            if (UInputSP.Text!="")
            {
                string message = ObjectHandler.GetEmployeeDL().RemoveEmployee(UInputSP.Text);
                if (message=="True")
                {
                    MessageBox.Show("SalesPerson data updated successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadSalesPersonsData();
                    ClearInputsSP();
                }
                // if employee not deleted
                else
                {
                    MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void DeleteSpBtn_Click(object sender, EventArgs e)
        {
            if (UInputSP.Text!="")
            {
                string message = ObjectHandler.GetEmployeeDL().RemoveEmployee(UInputSP.Text);
                if (message=="True")
                {
                    MessageBox.Show("SalesPerson data deleted successfully!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadSalesPersonsData();
                    ClearInputsSP();
                }
                // if employee not deleted
                else
                {
                    MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        //                           Technicians Operations
        private void LoadTechniciansData()
        {
            try
            {
                // Retrieve technicians' data from the data access layer
                TGridView.DataSource = null; // Unbind the data source
                TGridView.Rows.Clear(); // Clear the rows
                List<EmployeeBL> employees = ObjectHandler.GetEmployeeDL().GetEmployeesByDesignation("Technician");
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
        private void ClearInputsMT()
        {
            NInputMT.Text="";
            UInputMT.Text="";
            PInputMT.Text="";
            EInputMT.Text="";
            AInputMT.Text="";
            CInputMT.Text="";
            GInputMT.Text="";
            DOBIMT.Value = DateTime.Now.AddDays(-1);
        }
        private void LoadDataIntoInputsMT(EmployeeBL employee)
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
        private void TGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (TGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = TGridView.SelectedRows[0];
                if (selectedRow.Index >= 0 && selectedRow.Index < TGridView.Rows.Count)
                {
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
        private void AddMTBtn_Click(object sender, EventArgs e)
        {
            // makes new user object
            EmployeeBL user = new EmployeeBL(NInputMT.Text, UInputMT.Text, PInputMT.Text, EInputMT.Text, DOBIMT.Value, AInputMT.Text, CInputMT.Text, GInputMT.Text, "Active", "Technician", DateTime.Now);
            // calls Object Handler to call employee interface to add employee
            string uStatus = ObjectHandler.GetEmployeeDL().AddEmployee(user);
            // if employee added successfully
            if (uStatus=="True")
            {
                MessageBox.Show("Technician added successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadTechniciansData();
                ClearInputsMT();
            }
            // if employee not added
            else
            {
                MessageBox.Show(uStatus, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void UpdateMTBtn_Click(object sender, EventArgs e)
        {
            if (UInputMT.Text!="")
            {
                string message = ObjectHandler.GetEmployeeDL().RemoveEmployee(UInputMT.Text);
                if (message=="True")
                {
                    MessageBox.Show("Technician data updated successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadTechniciansData();
                    ClearInputsMT();
                }
                // if employee not deleted
                else
                {
                    MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void DeleteMTBtn_Click(object sender, EventArgs e)
        {
            if (UInputMT.Text!="")
            {
                string message = ObjectHandler.GetEmployeeDL().RemoveEmployee(UInputMT.Text);
                if (message=="True")
                {
                    MessageBox.Show("Technician data deleted successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadTechniciansData();
                    ClearInputsMT();
                }
                // if employee not deleted
                else
                {
                    MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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
            DOBIC.Value = DateTime.Now.AddDays(-1);
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
                LoadCustomersData();
                ClearInputsC();
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
                    LoadCustomersData();
                    ClearInputsC();
                }
                // if customer not deleted
                else
                {
                    MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}
