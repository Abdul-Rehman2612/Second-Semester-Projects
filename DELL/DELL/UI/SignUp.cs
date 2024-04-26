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
            WindowState = FormWindowState.Maximized;
        }

        private void Registernow_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            SignIn signIn = new SignIn();
            signIn.Show();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Hide();
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
        }

        private void Exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void SignUpbtn_Click(object sender, EventArgs e)
        {
            CustomerBL user = new CustomerBL(NInput.Text, UInput.Text, PInput.Text, EInput.Text, DOBI.Value, AInput.Text, CInput.Text, GInput.Text, "Active");
            string uStatus = ObjectHandler.GetCustomerDL().AddCustomer(user);
            if (uStatus=="True")
            {
                MessageBox.Show("Signed up successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearInputs();
            }
            else
            {
                MessageBox.Show(uStatus, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
