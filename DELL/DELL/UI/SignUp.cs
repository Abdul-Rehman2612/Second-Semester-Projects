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
    }
}
