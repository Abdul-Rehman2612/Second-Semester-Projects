namespace DELL.UI
{
    partial class SignIn
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignIn));
            this.MainPanel = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.TopContainer = new Guna.UI2.WinForms.Guna2Panel();
            this.Logo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.BottomContainer = new Guna.UI2.WinForms.Guna2Panel();
            this.Password = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.Label();
            this.ButtonsContainer = new System.Windows.Forms.TableLayoutPanel();
            this.UNInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.PInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.MainPanel.SuspendLayout();
            this.TopContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.BottomContainer.SuspendLayout();
            this.ButtonsContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.TopContainer);
            this.MainPanel.Controls.Add(this.BottomContainer);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.FillColor = System.Drawing.Color.Lavender;
            this.MainPanel.FillColor2 = System.Drawing.Color.Lavender;
            this.MainPanel.FillColor3 = System.Drawing.Color.Lavender;
            this.MainPanel.FillColor4 = System.Drawing.Color.Lavender;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(784, 561);
            this.MainPanel.TabIndex = 1;
            // 
            // TopContainer
            // 
            this.TopContainer.BackColor = System.Drawing.Color.Lavender;
            this.TopContainer.Controls.Add(this.Logo);
            this.TopContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TopContainer.FillColor = System.Drawing.Color.Transparent;
            this.TopContainer.Location = new System.Drawing.Point(0, 0);
            this.TopContainer.Name = "TopContainer";
            this.TopContainer.Size = new System.Drawing.Size(784, 150);
            this.TopContainer.TabIndex = 2;
            // 
            // Logo
            // 
            this.Logo.BackColor = System.Drawing.Color.Transparent;
            this.Logo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Logo.ErrorImage = ((System.Drawing.Image)(resources.GetObject("Logo.ErrorImage")));
            this.Logo.FillColor = System.Drawing.Color.Transparent;
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.ImageRotate = 0F;
            this.Logo.Location = new System.Drawing.Point(0, 0);
            this.Logo.MinimumSize = new System.Drawing.Size(0, 100);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(784, 150);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo.TabIndex = 1;
            this.Logo.TabStop = false;
            this.Logo.UseTransparentBackground = true;
            // 
            // BottomContainer
            // 
            this.BottomContainer.BackColor = System.Drawing.Color.Lavender;
            this.BottomContainer.Controls.Add(this.ButtonsContainer);
            this.BottomContainer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomContainer.Location = new System.Drawing.Point(0, 150);
            this.BottomContainer.Name = "BottomContainer";
            this.BottomContainer.Size = new System.Drawing.Size(784, 411);
            this.BottomContainer.TabIndex = 1;
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Password.Font = new System.Drawing.Font("Sitka Heading", 24F, System.Drawing.FontStyle.Bold);
            this.Password.Location = new System.Drawing.Point(167, 160);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(162, 42);
            this.Password.TabIndex = 6;
            this.Password.Text = "Password";
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Username.Font = new System.Drawing.Font("Sitka Heading", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.Location = new System.Drawing.Point(167, 76);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(162, 42);
            this.Username.TabIndex = 5;
            this.Username.Text = "Username";
            // 
            // ButtonsContainer
            // 
            this.ButtonsContainer.BackColor = System.Drawing.Color.GhostWhite;
            this.ButtonsContainer.ColumnCount = 5;
            this.ButtonsContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.95798F));
            this.ButtonsContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.46915F));
            this.ButtonsContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.65146F));
            this.ButtonsContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.83644F));
            this.ButtonsContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.08496F));
            this.ButtonsContainer.Controls.Add(this.Username, 1, 1);
            this.ButtonsContainer.Controls.Add(this.Password, 1, 3);
            this.ButtonsContainer.Controls.Add(this.UNInput, 3, 1);
            this.ButtonsContainer.Controls.Add(this.PInput, 3, 3);
            this.ButtonsContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonsContainer.Location = new System.Drawing.Point(0, 0);
            this.ButtonsContainer.Name = "ButtonsContainer";
            this.ButtonsContainer.RowCount = 4;
            this.ButtonsContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.62376F));
            this.ButtonsContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.79208F));
            this.ButtonsContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.79208F));
            this.ButtonsContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.79208F));
            this.ButtonsContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ButtonsContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ButtonsContainer.Size = new System.Drawing.Size(784, 202);
            this.ButtonsContainer.TabIndex = 0;
            // 
            // UNInput
            // 
            this.UNInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UNInput.DefaultText = "";
            this.UNInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.UNInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.UNInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UNInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UNInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UNInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UNInput.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.UNInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UNInput.Location = new System.Drawing.Point(434, 79);
            this.UNInput.Name = "UNInput";
            this.UNInput.PasswordChar = '\0';
            this.UNInput.PlaceholderText = "Enter Username";
            this.UNInput.SelectedText = "";
            this.UNInput.Size = new System.Drawing.Size(204, 36);
            this.UNInput.TabIndex = 7;
            // 
            // PInput
            // 
            this.PInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PInput.DefaultText = "";
            this.PInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PInput.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PInput.Location = new System.Drawing.Point(434, 163);
            this.PInput.Name = "PInput";
            this.PInput.PasswordChar = '\0';
            this.PInput.PlaceholderText = "Enter Password";
            this.PInput.SelectedText = "";
            this.PInput.Size = new System.Drawing.Size(204, 36);
            this.PInput.TabIndex = 8;
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.MainPanel);
            this.Name = "SignIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignIn";
            this.MainPanel.ResumeLayout(false);
            this.TopContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.BottomContainer.ResumeLayout(false);
            this.ButtonsContainer.ResumeLayout(false);
            this.ButtonsContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel MainPanel;
        private Guna.UI2.WinForms.Guna2Panel TopContainer;
        private Guna.UI2.WinForms.Guna2PictureBox Logo;
        private Guna.UI2.WinForms.Guna2Panel BottomContainer;
        private System.Windows.Forms.TableLayoutPanel ButtonsContainer;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Label Password;
        private Guna.UI2.WinForms.Guna2TextBox UNInput;
        private Guna.UI2.WinForms.Guna2TextBox PInput;
    }
}