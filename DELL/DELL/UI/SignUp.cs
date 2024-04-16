using DellLibrary.BL;
using DELL.Utility;
using System;
using System.Windows.Forms;

namespace DELL.UI
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }
        // if user clicks the label it redirects it to the sign in form
        private void Registernow_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            SignIn signIn = new SignIn();
            signIn.Show();
        }
        // if clicked returns user to main menu
        private void Back_Click(object sender, EventArgs e)
        {
            Hide();
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
        }
        // if clicked closes application
        private void Exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        // clears all input textboxes
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
        private void SignUpbtn_Click(object sender, EventArgs e)
        {
            // makes new user object
            CustomerBL user = new CustomerBL(NInput.Text, UInput.Text, PInput.Text, EInput.Text, DOBI.Value, AInput.Text, CInput.Text, GInput.Text, "Active");
            // calls Object Handler to call Customer interface to add customer
            string uStatus = ObjectHandler.GetCustomerDL().AddCustomer(user);
            // if customer added successfully
            if (uStatus=="True")
            {
                MessageBox.Show("Signed up successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearInputs();
            }
            // if customer not added
            else
            {
                MessageBox.Show(uStatus, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
