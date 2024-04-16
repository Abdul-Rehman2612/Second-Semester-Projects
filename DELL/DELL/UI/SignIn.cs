using DellLibrary.BL;
using DELL.Utility;
using System;
using System.Windows.Forms;
namespace DELL.UI
{
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
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
            string message = ObjectHandler.GetCustomerUDL().UserSignIn(user); // checks user in customers data
            if (message=="Customer") // if user is customer
            {
                MessageBox.Show("Signed In successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Hide();
            }
            else // if user is not a customer
            {
                message = ObjectHandler.GetEmployeeUDL().UserSignIn(user);  // checks user in employees data
                if (message=="CEO") // if user is CEO
                {
                    MessageBox.Show("Signed In successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Hide();
                }
                else if (message=="Technician") // if user is technician
                {
                    MessageBox.Show("Signed In successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Hide();
                }
                else if (message=="SalesPerson") // if user is salesperson
                {
                    MessageBox.Show("Signed In successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Hide();
                }
                else // if user not found
                {
                    MessageBox.Show(message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
        // if user clicks exit button application closes
        private void Exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
