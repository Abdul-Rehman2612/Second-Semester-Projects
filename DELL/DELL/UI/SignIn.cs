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
            WindowState = FormWindowState.Maximized; // maximize windows size
        }
        // if user clicks sign up now label the sign up form opens
        private void Registernow_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            SignUp signUp = new SignUp();
            signUp.Show();
        }
        // if user clicks back button user returns to main menu
        private void Backbtn_Click(object sender, EventArgs e)
        {
            Hide();
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
        }
        // if user clicks sign in button user authentication functions are called to check whether the user is valid or not!
        private void SignInbtn_Click(object sender, EventArgs e)
        {
            UserBL user = new UserBL(UInput.Text, PInput.Text); // makes object of the user for signing in
            try
            {
                CustomerBL customer = (CustomerBL)ObjectHandler.GetCustomerUDL().UserSignIn(user); // checks user in customers data
                if (customer!=null) // if user is customer
                {
                    MessageBox.Show("Signed In successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Hide();
                    CustomerUI uI = new CustomerUI(customer);
                    uI.Show();
                }
                else // if user is not a customer
                {
                    EmployeeBL emp = (EmployeeBL)ObjectHandler.GetEmployeeUDL().UserSignIn(user);  // checks user in employees data
                    if (emp!=null)
                    {
                        if (emp.GetDesignation()=="CEO") // if user is CEO
                        {
                            MessageBox.Show("Signed In successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Hide();
                            CeoUI uI = new CeoUI(emp);
                            uI.Show();
                        }
                        else if (emp.GetDesignation()=="Technician") // if user is technician
                        {
                            MessageBox.Show("Signed In successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Hide();
                            TechnicianUI uI = new TechnicianUI(emp);
                            uI.Show();
                        }
                        else if (emp.GetDesignation()=="SalesPerson") // if user is salesperson
                        {
                            MessageBox.Show("Signed In successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Hide();
                            SalesPersonUI uI = new SalesPersonUI(emp);
                            uI.Show();
                        }
                    }
                    else // if user not found
                    {
                        MessageBox.Show("Invalid Credentials!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // if user clicks exit button application closes
        private void Exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
