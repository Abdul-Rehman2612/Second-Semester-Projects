using DELL.BL;
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
        // if user clicks back button ruser returns to main menu
        private void Backbtn_Click(object sender, EventArgs e)
        {
            Hide();
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
        }
        // if user clicks sign in button user authentication functions are called to check whether the user is valid or not!
        private void SignInbtn_Click(object sender, EventArgs e)
        {
            UserBL user = new UserBL(UInput.Text, PInput.Text);
            string message = ObjectHandler.GetCustomerUDL().UserSignIn(user);
            if (message=="Customer")
            {
                MessageBox.Show("Signed In successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                message = ObjectHandler.GetEmployeeUDL().UserSignIn(user);
                if (message=="CEO")
                {
                    MessageBox.Show("Signed In successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (message=="Technician")
                {
                    MessageBox.Show("Signed In successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (message=="SalesPerson")
                {
                    MessageBox.Show("Signed In successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
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
