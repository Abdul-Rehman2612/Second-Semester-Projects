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

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void Exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void SignInbtn_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            SignIn signIn = new SignIn();
            signIn.Show();
        }
        private void ButtonsContainer_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
