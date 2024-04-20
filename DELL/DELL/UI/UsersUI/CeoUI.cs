using DELL.Utility;
using DellLibrary.BL;
using DellLibrary.DL_Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
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
            LoadData(); // loading data for the forms
            CEO = emp; // intializing the CEO object with the userdata found
        }
        private void LoadData()
        {
            LoadStats(); // loads statistical data for CEO
            LoadSalesPersonsData(); // loads SalesPersons data for CEO
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
                MessageBox.Show(e.Message);
            }
        }
        private void LoadSalesPersonsData()
        {
            try
            {
                // Retrieve salespersons' data from the data access layer
                List<EmployeeBL> employees = ObjectHandler.GetEmployeeDL().GetEmployeesByDesignation("SalesPerson");
                MessageBox.Show($"{employees.Count}");
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
            catch (Exception ex)
            {
                // Handle any exceptions that may occur during data retrieval or UI manipulation
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                LoadSalesPersonsData();
                ClearInputs();
            }
            // if employee not added
            else
            {
                MessageBox.Show(uStatus, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void SPGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (SPGridView1.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                // Retrieve data from the selected row
                DataGridViewRow selectedRow = SPGridView1.Rows[e.RowIndex];

                // Assuming these are the column names corresponding to the properties of EmployeeBL
                string name = selectedRow.Cells["Name"].Value.ToString();
                string username = selectedRow.Cells["Username"].Value.ToString();
                string password = selectedRow.Cells["Password"].Value.ToString();
                string email = selectedRow.Cells["Email"].Value.ToString();
                DateTime dob;
                if (DateTime.TryParse(selectedRow.Cells["DOB"].Value.ToString(), out dob))
                {
                }
                string address = selectedRow.Cells["Address"].Value.ToString();
                string contact = selectedRow.Cells["Contact"].Value.ToString();
                string gender = selectedRow.Cells["Gender"].Value.ToString();
                string status = selectedRow.Cells["Status"].Value.ToString();
                string designation = selectedRow.Cells["Designation"].Value.ToString();
                DateTime hireDate;
                if (DateTime.TryParse(selectedRow.Cells["HireDate"].Value.ToString(), out hireDate))
                {
                }
                if (!string.IsNullOrEmpty(username))
                {
                    // Assuming EmployeeBL constructor accepts these parameters
                    EmployeeBL employee = new EmployeeBL(name,username,password,email,dob,address,contact,gender,status,designation,hireDate);
                    LoadDataIntoInputs(employee);
                }
            }
        }
    }
}
