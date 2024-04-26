using DellLibrary.BL;
using DELL.Utility;
using DELL.UI.UsersUI;
using System;
using System.Windows.Forms;

namespace DELL.UI
{
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
        }

        private void Registernow_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            SignUp signUp = new SignUp();
            signUp.Show();
        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            Hide();
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
        }

        private void SignInbtn_Click(object sender, EventArgs e)
        {
            UserBL user = new UserBL(UInput.Text, PInput.Text);
            try
            {
                CustomerBL customer = (CustomerBL)ObjectHandler.GetCustomerUDL().UserSignIn(user);
                if (customer != null)
                {
                    MessageBox.Show("Signed In successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Hide();
                    CustomerUI uI = new CustomerUI(customer);
                    uI.Show();
                }
                else
                {
                    EmployeeBL emp = (EmployeeBL)ObjectHandler.GetEmployeeUDL().UserSignIn(user);
                    if (emp != null)
                    {
                        if (emp.GetDesignation() == "CEO")
                        {
                            MessageBox.Show("Signed In successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Hide();
                            CeoUI uI = new CeoUI(emp);
                            uI.Show();
                        }
                        else if (emp.GetDesignation() == "Technician")
                        {
                            MessageBox.Show("Signed In successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CeoUI uI = new CeoUI(emp);
                            uI.Show();
                        }
                        else if (emp.GetDesignation() == "SalesPerson")
                        {
                            MessageBox.Show("Signed In successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Hide();
                            SalesPersonUI uI = new SalesPersonUI(emp);
                            uI.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid Credentials!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
