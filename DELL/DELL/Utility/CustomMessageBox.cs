using DELL.UI;
using System.Windows.Forms;

namespace DELL.Utility
{
    public class CustomMessageBox : Form
    {
        public CustomMessageBox(string message)
        {
            InitializeComponent(message);
        }
        private void InitializeComponent(string message)
        {
            this.Text = "Error";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new System.Drawing.Size(300, 150);

            // Label to display the message
            Label lblMessage = new Label();
            lblMessage.Text = message;
            lblMessage.AutoSize = true;
            lblMessage.Location = new System.Drawing.Point(20, 20);
            lblMessage.Width = 250;

            // Button for OK
            Button btnOK = new Button();
            btnOK.Text = "OK";
            btnOK.DialogResult = DialogResult.OK;
            btnOK.Location = new System.Drawing.Point(50, 70);
            btnOK.Click += (sender, e) => this.Close();

            // Button for Forgot Password
            Button btnForgotPassword = new Button();
            btnForgotPassword.Text = "Forgot Password";
            btnForgotPassword.Location = new System.Drawing.Point(150, 70);
            btnForgotPassword.Click += (sender, e) => OpenForgetPasswordForm();

            // Add controls to the form
            this.Controls.Add(lblMessage);
            this.Controls.Add(btnOK);
            this.Controls.Add(btnForgotPassword);

        }
        private void OpenForgetPasswordForm()
        {
            // Code to open ForgetPasswordForm goes here
            ForgotPassword forgetPasswordForm = new ForgotPassword();
            forgetPasswordForm.Show();
        }
    }
}
