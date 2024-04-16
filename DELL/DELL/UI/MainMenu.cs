using DELL.UI;
using System;
using System.Windows.Forms;
namespace DELL
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
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
    }
}
