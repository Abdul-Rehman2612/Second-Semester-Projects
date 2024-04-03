using DELL.BL;
using DELL.DL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DELL.UI
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }
        private void Registernow_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            SignIn signIn = new SignIn();
            signIn.Show();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
        }
        private void Exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void SignUpbtn_Click(object sender, EventArgs e)
        {
            UserBL user=new CustomerBL(NInput.Text,UInput.Text,PInput.Text,EInput.Text,DOBI.Value,AInput.Text,CInput.Text,GInput.Text,"Active");
            string uc = UserDL.AddUserToDB(user,true);
            if (uc=="True")
            {
                MessageBox.Show("Signed up successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(uc, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
