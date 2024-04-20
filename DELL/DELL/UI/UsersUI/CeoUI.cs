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
            LoadData(); // loading data for the forms
        }
        private void LoadData()
        {
            LoadStats(); // loads statistical data for CEO
            LoadSalesPersonsData(); // loads SalesPersons data for CEO
            ClearInputs(); // clears input fields
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
                throw (e);
            }
        }
        private void LoadSalesPersonsData()
        {
            // Retrieve salespersons' data from the data access layer
            List<EmployeeBL> employees = ObjectHandler.GetEmployeeDL().GetEmployeesByDesignation("SalesPerson");
            SPGridView1.DataSource = null; // Unbind the data source
            SPGridView1.Rows.Clear(); // Clear the rows

            // Add rows to the DataGridView
            foreach (EmployeeBL e in employees)
            {
                SPGridView1.Rows.Add(
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
        private void ClearInputs()
        {
            NInput.Text="";
            UInput.Text="";
            PInput.Text="";
            EInput.Text="";
            AInput.Text="";
            CInput.Text="";
            GInput.Text="";
            DOBI.Value = DateTime.Now.AddDays(-1);
        }
        private void LoadDataIntoInputs(EmployeeBL employee)
        {
            NInput.Text=employee.GetName();
            UInput.Text=employee.GetUsername();
            PInput.Text=employee.GetPassword();
            EInput.Text=employee.GetEmail();
            AInput.Text=employee.GetAddress();
            CInput.Text=employee.GetContact();
            GInput.Text=employee.GetGender();
            DOBI.Value=employee.GetDob();
        }
        private void AddSpbtn_Click(object sender, EventArgs e)
        {
            // makes new user object
            EmployeeBL user = new EmployeeBL(NInput.Text, UInput.Text, PInput.Text, EInput.Text, DOBI.Value, AInput.Text, CInput.Text, GInput.Text, "Active", "SalesPerson", DateTime.Now);
            // calls Object Handler to call employee interface to add employee
            string uStatus = ObjectHandler.GetEmployeeDL().AddEmployee(user);
            // if employee added successfully
            if (uStatus=="True")
            {
                MessageBox.Show("Sales person added successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
            // if employee not added
            else
            {
                MessageBox.Show(uStatus, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void SPGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (SPGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = SPGridView1.SelectedRows[0];
                if (selectedRow.Index >= 0 && selectedRow.Index < SPGridView1.Rows.Count)
                {
                    string name = selectedRow.Cells["Column1"].Value?.ToString();
                    string username = selectedRow.Cells["Column2"].Value?.ToString();
                    string password = selectedRow.Cells["Column3"].Value?.ToString();
                    string email = selectedRow.Cells["Column4"].Value?.ToString();
                    if (DateTime.TryParse(selectedRow.Cells["Column5"].Value?.ToString(), out DateTime dob))
                    {
                        // Successfully parsed the DOB
                        string contact = selectedRow.Cells["Column6"].Value?.ToString();
                        string address = selectedRow.Cells["Column7"].Value?.ToString();
                        string gender = selectedRow.Cells["Column8"].Value?.ToString();
                        string status = "Active";
                        string designation = "SalesPerson";

                        if (DateTime.TryParse(selectedRow.Cells["Column9"].Value?.ToString(), out DateTime hireDate))
                        {
                            // Successfully parsed the hire date
                            EmployeeBL employee = new EmployeeBL(name, username, password, email, dob, address, contact, gender, status, designation, hireDate);
                            LoadDataIntoInputs(employee);
                        }
                        else
                        {
                            ClearInputs();
                        }
                    }
                    else
                    {
                        ClearInputs();
                    }
                }
            }
        }
        private void DeleteSpBtn_Click(object sender, EventArgs e)
        {
            if(UInput.Text!="")
            {
                string message=ObjectHandler.GetEmployeeDL().RemoveEmployee(UInput.Text);
                if (message=="True")
                {
                    MessageBox.Show("Sales person deleted successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                // if employee not deleted
                else
                {
                    MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void UpdateBtnSp_Click(object sender, EventArgs e)
        {

        }
    }
}
