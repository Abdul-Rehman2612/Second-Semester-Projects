using DELL.UI;
using DELL.Utility;
using System;
using System.Windows.Forms;
namespace DELL
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized; // maximize windows size
        }
        // if user clicks sign in button sign in form appears
        private void SignInbtn_Click(object sender, EventArgs e)
        {
            Hide();
            SignIn signIn = new SignIn();
            signIn.Show();
        }
        // if user clicks sign in button sign up form appears
        private void SignUpbtn_Click(object sender, EventArgs e)
        {
            Hide();
            SignUp signUp = new SignUp();
            signUp.Show();
        }
        // if user clicks exit button application closes
        private void Exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TopContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BottomContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Inputs_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Logo_Click(object sender, EventArgs e)
        {

        }

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
