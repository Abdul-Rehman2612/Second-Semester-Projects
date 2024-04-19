using DELL.Utility;
using DellLibrary.BL;
using DellLibrary.DL_Interfaces;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DELL.UI.UsersUI
{
    public partial class CeoUI : Form
    {
        private EmployeeBL CEO = null;

        public CeoUI(EmployeeBL emp)
        {
            InitializeComponent();
            LoadData();
            CEO = emp;
        }
        private void LoadData()
        {
            LoadStats();
            LoadSalesPersonsData();
            WindowState = FormWindowState.Maximized;
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
                SalesPersonsDataView.Rows.Clear();
                // Set the window state to maximized
                List<EmployeeBL> employees=new List<EmployeeBL>();
                employees = ObjectHandler.GetEmployeeDL().GetEmployeesByDesignation("SalesPerson");
                // Add rows to the DataGridView
                foreach (EmployeeBL e in employees)
                {
                    SalesPersonsDataView.Rows.Add(e.GetName(), e.GetUsername(), e.GetPassword(), e.GetEmail(), e.GetDob(), e.GetContact(), e.GetAddress(), e.GetGender(),e.GetHireDate());
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions that may occur during data binding
                MessageBox.Show("Error: " + ex.Message);
            }

        }
        private void AddSpbtn_Click(object sender, EventArgs e)
        {
        }
    }
}
