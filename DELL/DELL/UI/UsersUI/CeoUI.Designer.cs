using System;
using System.Drawing;
using System.Windows.Forms;

namespace DELL.UI.UsersUI
{
    partial class CeoUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CeoUI));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.Dashboard = new System.Windows.Forms.TabPage();
            this.DashboardInfo = new System.Windows.Forms.TableLayoutPanel();
            this.Pic1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Pic2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Pic3 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Pic4 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.DataShow1 = new System.Windows.Forms.Label();
            this.DataShow2 = new System.Windows.Forms.Label();
            this.DataShow3 = new System.Windows.Forms.Label();
            this.DataShow4 = new System.Windows.Forms.Label();
            this.CeoPanel = new Guna.UI2.WinForms.Guna2TabControl();
            this.ManageEmployee = new System.Windows.Forms.TabPage();
            this.Inputs = new System.Windows.Forms.TableLayoutPanel();
            this.Contact = new Guna.UI.WinForms.GunaLabel();
            this.DOB = new Guna.UI.WinForms.GunaLabel();
            this.Address = new Guna.UI.WinForms.GunaLabel();
            this.Gender = new Guna.UI.WinForms.GunaLabel();
            this.Username = new Guna.UI.WinForms.GunaLabel();
            this.Password = new Guna.UI.WinForms.GunaLabel();
            this.IName = new Guna.UI.WinForms.GunaLabel();
            this.Email = new Guna.UI.WinForms.GunaLabel();
            this.NInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.UInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.PInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.EInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.CInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.AInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.GInput = new Guna.UI2.WinForms.Guna2ComboBox();
            this.DOBI = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.BottomContainer = new System.Windows.Forms.Panel();
            this.SPGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ButtonsContainer = new System.Windows.Forms.TableLayoutPanel();
            this.DeleteSpBtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.AddSpbtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.UpdateBtnSp = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.MainPanel = new Guna.UI.WinForms.GunaPanel();
            this.InputsContainer = new Guna.UI2.WinForms.Guna2Panel();
            this.TopContainer = new Guna.UI2.WinForms.Guna2Panel();
            this.Logo2 = new System.Windows.Forms.Label();
            this.Logo = new System.Windows.Forms.Label();
            this.Dashboard.SuspendLayout();
            this.DashboardInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic4)).BeginInit();
            this.CeoPanel.SuspendLayout();
            this.ManageEmployee.SuspendLayout();
            this.Inputs.SuspendLayout();
            this.BottomContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SPGridView1)).BeginInit();
            this.ButtonsContainer.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.InputsContainer.SuspendLayout();
            this.TopContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // Dashboard
            // 
            this.Dashboard.BackColor = System.Drawing.Color.GhostWhite;
            this.Dashboard.Controls.Add(this.DashboardInfo);
            this.Dashboard.Location = new System.Drawing.Point(154, 4);
            this.Dashboard.Name = "Dashboard";
            this.Dashboard.Padding = new System.Windows.Forms.Padding(3);
            this.Dashboard.Size = new System.Drawing.Size(776, 529);
            this.Dashboard.TabIndex = 0;
            this.Dashboard.Text = "Dashboard";
            // 
            // DashboardInfo
            // 
            this.DashboardInfo.ColumnCount = 5;
            this.DashboardInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.DashboardInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.DashboardInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.DashboardInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.DashboardInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.DashboardInfo.Controls.Add(this.Pic1, 1, 1);
            this.DashboardInfo.Controls.Add(this.Pic2, 3, 1);
            this.DashboardInfo.Controls.Add(this.Pic3, 1, 4);
            this.DashboardInfo.Controls.Add(this.Pic4, 3, 4);
            this.DashboardInfo.Controls.Add(this.DataShow1, 1, 2);
            this.DashboardInfo.Controls.Add(this.DataShow2, 3, 2);
            this.DashboardInfo.Controls.Add(this.DataShow3, 1, 5);
            this.DashboardInfo.Controls.Add(this.DataShow4, 3, 5);
            this.DashboardInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DashboardInfo.Location = new System.Drawing.Point(3, 3);
            this.DashboardInfo.Name = "DashboardInfo";
            this.DashboardInfo.RowCount = 7;
            this.DashboardInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.35484F));
            this.DashboardInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 175F));
            this.DashboardInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.35484F));
            this.DashboardInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.225806F));
            this.DashboardInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 175F));
            this.DashboardInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.35484F));
            this.DashboardInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.35484F));
            this.DashboardInfo.Size = new System.Drawing.Size(770, 523);
            this.DashboardInfo.TabIndex = 0;
            // 
            // Pic1
            // 
            this.Pic1.Image = ((System.Drawing.Image)(resources.GetObject("Pic1.Image")));
            this.Pic1.ImageRotate = 0F;
            this.Pic1.Location = new System.Drawing.Point(126, 44);
            this.Pic1.Name = "Pic1";
            this.Pic1.Size = new System.Drawing.Size(194, 169);
            this.Pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pic1.TabIndex = 8;
            this.Pic1.TabStop = false;
            // 
            // Pic2
            // 
            this.Pic2.BackColor = System.Drawing.Color.Transparent;
            this.Pic2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pic2.Image = ((System.Drawing.Image)(resources.GetObject("Pic2.Image")));
            this.Pic2.ImageRotate = 0F;
            this.Pic2.Location = new System.Drawing.Point(449, 44);
            this.Pic2.Name = "Pic2";
            this.Pic2.Size = new System.Drawing.Size(194, 169);
            this.Pic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pic2.TabIndex = 9;
            this.Pic2.TabStop = false;
            // 
            // Pic3
            // 
            this.Pic3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pic3.Image = ((System.Drawing.Image)(resources.GetObject("Pic3.Image")));
            this.Pic3.ImageRotate = 0F;
            this.Pic3.Location = new System.Drawing.Point(126, 266);
            this.Pic3.Name = "Pic3";
            this.Pic3.Size = new System.Drawing.Size(194, 169);
            this.Pic3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pic3.TabIndex = 10;
            this.Pic3.TabStop = false;
            // 
            // Pic4
            // 
            this.Pic4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pic4.Image = ((System.Drawing.Image)(resources.GetObject("Pic4.Image")));
            this.Pic4.ImageRotate = 0F;
            this.Pic4.Location = new System.Drawing.Point(449, 266);
            this.Pic4.Name = "Pic4";
            this.Pic4.Size = new System.Drawing.Size(194, 169);
            this.Pic4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pic4.TabIndex = 11;
            this.Pic4.TabStop = false;
            // 
            // DataShow1
            // 
            this.DataShow1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataShow1.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataShow1.Location = new System.Drawing.Point(126, 216);
            this.DataShow1.Name = "DataShow1";
            this.DataShow1.Size = new System.Drawing.Size(194, 41);
            this.DataShow1.TabIndex = 12;
            // 
            // DataShow2
            // 
            this.DataShow2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataShow2.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataShow2.Location = new System.Drawing.Point(449, 216);
            this.DataShow2.Name = "DataShow2";
            this.DataShow2.Size = new System.Drawing.Size(194, 41);
            this.DataShow2.TabIndex = 13;
            // 
            // DataShow3
            // 
            this.DataShow3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataShow3.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataShow3.Location = new System.Drawing.Point(126, 438);
            this.DataShow3.Name = "DataShow3";
            this.DataShow3.Size = new System.Drawing.Size(194, 41);
            this.DataShow3.TabIndex = 14;
            // 
            // DataShow4
            // 
            this.DataShow4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataShow4.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataShow4.Location = new System.Drawing.Point(449, 438);
            this.DataShow4.Name = "DataShow4";
            this.DataShow4.Size = new System.Drawing.Size(194, 41);
            this.DataShow4.TabIndex = 15;
            // 
            // CeoPanel
            // 
            this.CeoPanel.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.CeoPanel.Controls.Add(this.Dashboard);
            this.CeoPanel.Controls.Add(this.ManageEmployee);
            this.CeoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CeoPanel.Font = new System.Drawing.Font("Sitka Display", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CeoPanel.ItemSize = new System.Drawing.Size(150, 40);
            this.CeoPanel.Location = new System.Drawing.Point(0, 0);
            this.CeoPanel.Name = "CeoPanel";
            this.CeoPanel.SelectedIndex = 0;
            this.CeoPanel.Size = new System.Drawing.Size(934, 537);
            this.CeoPanel.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.CeoPanel.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.CeoPanel.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.CeoPanel.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.CeoPanel.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.CeoPanel.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.CeoPanel.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.CeoPanel.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.CeoPanel.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.CeoPanel.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.CeoPanel.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.CeoPanel.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.CeoPanel.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.CeoPanel.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.CeoPanel.TabButtonSelectedState.InnerColor = System.Drawing.Color.Lime;
            this.CeoPanel.TabButtonSize = new System.Drawing.Size(150, 40);
            this.CeoPanel.TabIndex = 0;
            this.CeoPanel.TabMenuBackColor = System.Drawing.Color.Lavender;
            // 
            // ManageEmployee
            // 
            this.ManageEmployee.BackColor = System.Drawing.Color.GhostWhite;
            this.ManageEmployee.Controls.Add(this.Inputs);
            this.ManageEmployee.Controls.Add(this.BottomContainer);
            this.ManageEmployee.Font = new System.Drawing.Font("Sitka Display", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManageEmployee.Location = new System.Drawing.Point(154, 4);
            this.ManageEmployee.Name = "ManageEmployee";
            this.ManageEmployee.Padding = new System.Windows.Forms.Padding(3);
            this.ManageEmployee.Size = new System.Drawing.Size(776, 529);
            this.ManageEmployee.TabIndex = 1;
            this.ManageEmployee.Text = "Manage SalesPersons";
            // 
            // Inputs
            // 
            this.Inputs.BackColor = System.Drawing.Color.GhostWhite;
            this.Inputs.ColumnCount = 7;
            this.Inputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.46055F));
            this.Inputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.20111F));
            this.Inputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.295F));
            this.Inputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.302407F));
            this.Inputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.11686F));
            this.Inputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.64033F));
            this.Inputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.98374F));
            this.Inputs.Controls.Add(this.Contact, 4, 3);
            this.Inputs.Controls.Add(this.DOB, 4, 1);
            this.Inputs.Controls.Add(this.Address, 4, 4);
            this.Inputs.Controls.Add(this.Gender, 4, 2);
            this.Inputs.Controls.Add(this.Username, 1, 2);
            this.Inputs.Controls.Add(this.Password, 1, 3);
            this.Inputs.Controls.Add(this.IName, 1, 1);
            this.Inputs.Controls.Add(this.Email, 1, 4);
            this.Inputs.Controls.Add(this.NInput, 2, 1);
            this.Inputs.Controls.Add(this.UInput, 2, 2);
            this.Inputs.Controls.Add(this.PInput, 2, 3);
            this.Inputs.Controls.Add(this.EInput, 2, 4);
            this.Inputs.Controls.Add(this.CInput, 5, 3);
            this.Inputs.Controls.Add(this.AInput, 5, 4);
            this.Inputs.Controls.Add(this.GInput, 5, 2);
            this.Inputs.Controls.Add(this.DOBI, 5, 1);
            this.Inputs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Inputs.ForeColor = System.Drawing.Color.Black;
            this.Inputs.Location = new System.Drawing.Point(3, 3);
            this.Inputs.Name = "Inputs";
            this.Inputs.RowCount = 5;
            this.Inputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Inputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.Inputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.Inputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.Inputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.Inputs.Size = new System.Drawing.Size(770, 205);
            this.Inputs.TabIndex = 2;
            // 
            // Contact
            // 
            this.Contact.AutoSize = true;
            this.Contact.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Contact.Font = new System.Drawing.Font("Sitka Heading", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contact.Location = new System.Drawing.Point(387, 107);
            this.Contact.Name = "Contact";
            this.Contact.Size = new System.Drawing.Size(118, 49);
            this.Contact.TabIndex = 3;
            this.Contact.Text = "Contact";
            this.Contact.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DOB
            // 
            this.DOB.AutoSize = true;
            this.DOB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DOB.Font = new System.Drawing.Font("Sitka Heading", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DOB.Location = new System.Drawing.Point(387, 9);
            this.DOB.Name = "DOB";
            this.DOB.Size = new System.Drawing.Size(118, 49);
            this.DOB.TabIndex = 10;
            this.DOB.Text = "Date of birth";
            this.DOB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Address
            // 
            this.Address.AutoSize = true;
            this.Address.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Address.Font = new System.Drawing.Font("Sitka Heading", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Address.Location = new System.Drawing.Point(387, 156);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(118, 49);
            this.Address.TabIndex = 5;
            this.Address.Text = "Address";
            this.Address.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Gender
            // 
            this.Gender.AutoSize = true;
            this.Gender.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Gender.Font = new System.Drawing.Font("Sitka Heading", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gender.Location = new System.Drawing.Point(387, 58);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(118, 49);
            this.Gender.TabIndex = 9;
            this.Gender.Text = "Gender";
            this.Gender.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Username.Font = new System.Drawing.Font("Sitka Heading", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.Location = new System.Drawing.Point(83, 58);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(118, 49);
            this.Username.TabIndex = 6;
            this.Username.Text = "Username";
            this.Username.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Password.Font = new System.Drawing.Font("Sitka Heading", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(83, 107);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(118, 49);
            this.Password.TabIndex = 7;
            this.Password.Text = "Password";
            this.Password.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IName
            // 
            this.IName.AutoSize = true;
            this.IName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IName.Font = new System.Drawing.Font("Sitka Heading", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IName.Location = new System.Drawing.Point(83, 9);
            this.IName.Name = "IName";
            this.IName.Size = new System.Drawing.Size(118, 49);
            this.IName.TabIndex = 4;
            this.IName.Text = "Name";
            this.IName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Email.Font = new System.Drawing.Font("Sitka Heading", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.Location = new System.Drawing.Point(83, 156);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(118, 49);
            this.Email.TabIndex = 8;
            this.Email.Text = "Email";
            this.Email.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NInput
            // 
            this.NInput.AutoRoundedCorners = true;
            this.NInput.BorderRadius = 17;
            this.NInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NInput.DefaultText = "";
            this.NInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.NInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.NInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NInput.FillColor = System.Drawing.SystemColors.InactiveBorder;
            this.NInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NInput.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NInput.ForeColor = System.Drawing.Color.Black;
            this.NInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NInput.Location = new System.Drawing.Point(209, 15);
            this.NInput.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.NInput.Name = "NInput";
            this.NInput.PasswordChar = '\0';
            this.NInput.PlaceholderText = "Enter name";
            this.NInput.SelectedText = "";
            this.NInput.Size = new System.Drawing.Size(153, 37);
            this.NInput.TabIndex = 11;
            // 
            // UInput
            // 
            this.UInput.AutoRoundedCorners = true;
            this.UInput.BorderRadius = 17;
            this.UInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UInput.DefaultText = "";
            this.UInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.UInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.UInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UInput.FillColor = System.Drawing.SystemColors.InactiveBorder;
            this.UInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UInput.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UInput.ForeColor = System.Drawing.Color.Black;
            this.UInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UInput.Location = new System.Drawing.Point(209, 64);
            this.UInput.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.UInput.Name = "UInput";
            this.UInput.PasswordChar = '\0';
            this.UInput.PlaceholderText = "John123 etc.";
            this.UInput.SelectedText = "";
            this.UInput.Size = new System.Drawing.Size(153, 37);
            this.UInput.TabIndex = 12;
            // 
            // PInput
            // 
            this.PInput.AutoRoundedCorners = true;
            this.PInput.BorderRadius = 17;
            this.PInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PInput.DefaultText = "";
            this.PInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PInput.FillColor = System.Drawing.SystemColors.InactiveBorder;
            this.PInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PInput.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PInput.ForeColor = System.Drawing.Color.Black;
            this.PInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PInput.Location = new System.Drawing.Point(209, 113);
            this.PInput.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.PInput.Name = "PInput";
            this.PInput.PasswordChar = '●';
            this.PInput.PlaceholderText = "******";
            this.PInput.SelectedText = "";
            this.PInput.Size = new System.Drawing.Size(153, 37);
            this.PInput.TabIndex = 13;
            this.PInput.UseSystemPasswordChar = true;
            // 
            // EInput
            // 
            this.EInput.AutoRoundedCorners = true;
            this.EInput.BorderRadius = 17;
            this.EInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EInput.DefaultText = "";
            this.EInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.EInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.EInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EInput.FillColor = System.Drawing.SystemColors.InactiveBorder;
            this.EInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EInput.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EInput.ForeColor = System.Drawing.Color.Black;
            this.EInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EInput.Location = new System.Drawing.Point(209, 162);
            this.EInput.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.EInput.Name = "EInput";
            this.EInput.PasswordChar = '\0';
            this.EInput.PlaceholderText = "aaa@gmail.com";
            this.EInput.SelectedText = "";
            this.EInput.Size = new System.Drawing.Size(153, 37);
            this.EInput.TabIndex = 14;
            // 
            // CInput
            // 
            this.CInput.AutoRoundedCorners = true;
            this.CInput.BorderRadius = 17;
            this.CInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CInput.DefaultText = "";
            this.CInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.CInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.CInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CInput.FillColor = System.Drawing.SystemColors.InactiveBorder;
            this.CInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CInput.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CInput.ForeColor = System.Drawing.Color.Black;
            this.CInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CInput.Location = new System.Drawing.Point(513, 113);
            this.CInput.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.CInput.Name = "CInput";
            this.CInput.PasswordChar = '\0';
            this.CInput.PlaceholderText = "";
            this.CInput.SelectedText = "";
            this.CInput.Size = new System.Drawing.Size(164, 37);
            this.CInput.TabIndex = 15;
            // 
            // AInput
            // 
            this.AInput.AutoRoundedCorners = true;
            this.AInput.BorderRadius = 17;
            this.AInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AInput.DefaultText = "";
            this.AInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.AInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.AInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AInput.FillColor = System.Drawing.SystemColors.InactiveBorder;
            this.AInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AInput.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AInput.ForeColor = System.Drawing.Color.Black;
            this.AInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AInput.Location = new System.Drawing.Point(513, 162);
            this.AInput.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.AInput.Name = "AInput";
            this.AInput.PasswordChar = '\0';
            this.AInput.PlaceholderText = "";
            this.AInput.SelectedText = "";
            this.AInput.Size = new System.Drawing.Size(164, 37);
            this.AInput.TabIndex = 16;
            // 
            // GInput
            // 
            this.GInput.AutoRoundedCorners = true;
            this.GInput.BackColor = System.Drawing.Color.Transparent;
            this.GInput.BorderRadius = 19;
            this.GInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GInput.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.GInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GInput.FillColor = System.Drawing.SystemColors.InactiveBorder;
            this.GInput.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.GInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.GInput.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GInput.ForeColor = System.Drawing.Color.Black;
            this.GInput.ItemHeight = 34;
            this.GInput.Items.AddRange(new object[] {
            "Female",
            "Male"});
            this.GInput.Location = new System.Drawing.Point(511, 61);
            this.GInput.Name = "GInput";
            this.GInput.Size = new System.Drawing.Size(168, 40);
            this.GInput.Sorted = true;
            this.GInput.TabIndex = 17;
            // 
            // DOBI
            // 
            this.DOBI.AutoRoundedCorners = true;
            this.DOBI.BorderRadius = 20;
            this.DOBI.Checked = true;
            this.DOBI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DOBI.FillColor = System.Drawing.Color.White;
            this.DOBI.FocusedColor = System.Drawing.Color.White;
            this.DOBI.Font = new System.Drawing.Font("Sitka Text", 8F);
            this.DOBI.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DOBI.Location = new System.Drawing.Point(511, 12);
            this.DOBI.MaxDate = new System.DateTime(2024, 4, 21, 1, 42, 13, 873);
            this.DOBI.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.DOBI.Name = "DOBI";
            this.DOBI.Size = new System.Drawing.Size(168, 43);
            this.DOBI.TabIndex = 18;
            this.DOBI.Value = new System.DateTime(2024, 4, 1, 0, 0, 0, 0);
            // 
            // BottomContainer
            // 
            this.BottomContainer.Controls.Add(this.SPGridView1);
            this.BottomContainer.Controls.Add(this.ButtonsContainer);
            this.BottomContainer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomContainer.Location = new System.Drawing.Point(3, 208);
            this.BottomContainer.Name = "BottomContainer";
            this.BottomContainer.Size = new System.Drawing.Size(770, 318);
            this.BottomContainer.TabIndex = 1;
            // 
            // SPGridView1
            // 
            this.SPGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SPGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Sitka Display", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SPGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.SPGridView1.ColumnHeadersHeight = 30;
            this.SPGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.SPGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.SPGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SPGridView1.Location = new System.Drawing.Point(0, 64);
            this.SPGridView1.Name = "SPGridView1";
            this.SPGridView1.ReadOnly = true;
            this.SPGridView1.RowHeadersWidth = 40;
            this.SPGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Sitka Text", 12F);
            this.SPGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.SPGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SPGridView1.RowTemplate.Height = 20;
            this.SPGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SPGridView1.Size = new System.Drawing.Size(770, 254);
            this.SPGridView1.TabIndex = 1;
            this.SPGridView1.SelectionChanged += new System.EventHandler(this.SPGridView1_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Name";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Username";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Password";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Email";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Dob";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Contact";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Address";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.FillWeight = 80F;
            this.Column8.HeaderText = "Gender";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "HireDate";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // ButtonsContainer
            // 
            this.ButtonsContainer.ColumnCount = 7;
            this.ButtonsContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonsContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.ButtonsContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonsContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.ButtonsContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonsContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.ButtonsContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonsContainer.Controls.Add(this.DeleteSpBtn, 5, 1);
            this.ButtonsContainer.Controls.Add(this.AddSpbtn, 1, 1);
            this.ButtonsContainer.Controls.Add(this.UpdateBtnSp, 3, 1);
            this.ButtonsContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonsContainer.Location = new System.Drawing.Point(0, 0);
            this.ButtonsContainer.Name = "ButtonsContainer";
            this.ButtonsContainer.RowCount = 2;
            this.ButtonsContainer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ButtonsContainer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ButtonsContainer.Size = new System.Drawing.Size(770, 64);
            this.ButtonsContainer.TabIndex = 0;
            // 
            // DeleteSpBtn
            // 
            this.DeleteSpBtn.AllowAnimations = true;
            this.DeleteSpBtn.AllowMouseEffects = true;
            this.DeleteSpBtn.AllowToggling = false;
            this.DeleteSpBtn.AnimationSpeed = 200;
            this.DeleteSpBtn.AutoGenerateColors = false;
            this.DeleteSpBtn.AutoRoundBorders = false;
            this.DeleteSpBtn.AutoSizeLeftIcon = true;
            this.DeleteSpBtn.AutoSizeRightIcon = true;
            this.DeleteSpBtn.BackColor = System.Drawing.Color.Transparent;
            this.DeleteSpBtn.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(144)))), ((int)(((byte)(231)))));
            this.DeleteSpBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DeleteSpBtn.BackgroundImage")));
            this.DeleteSpBtn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.DeleteSpBtn.ButtonText = "Delete";
            this.DeleteSpBtn.ButtonTextMarginLeft = 0;
            this.DeleteSpBtn.ColorContrastOnClick = 45;
            this.DeleteSpBtn.ColorContrastOnHover = 45;
            this.DeleteSpBtn.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.DeleteSpBtn.CustomizableEdges = borderEdges1;
            this.DeleteSpBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.DeleteSpBtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.DeleteSpBtn.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.DeleteSpBtn.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.DeleteSpBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DeleteSpBtn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Idle;
            this.DeleteSpBtn.Font = new System.Drawing.Font("Sitka Display", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteSpBtn.ForeColor = System.Drawing.SystemColors.Info;
            this.DeleteSpBtn.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DeleteSpBtn.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.DeleteSpBtn.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.DeleteSpBtn.IconMarginLeft = 11;
            this.DeleteSpBtn.IconPadding = 10;
            this.DeleteSpBtn.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DeleteSpBtn.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.DeleteSpBtn.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.DeleteSpBtn.IconSize = 25;
            this.DeleteSpBtn.IdleBorderColor = System.Drawing.Color.LightBlue;
            this.DeleteSpBtn.IdleBorderRadius = 50;
            this.DeleteSpBtn.IdleBorderThickness = 2;
            this.DeleteSpBtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(144)))), ((int)(((byte)(231)))));
            this.DeleteSpBtn.IdleIconLeftImage = null;
            this.DeleteSpBtn.IdleIconRightImage = null;
            this.DeleteSpBtn.IndicateFocus = false;
            this.DeleteSpBtn.Location = new System.Drawing.Point(544, 3);
            this.DeleteSpBtn.Name = "DeleteSpBtn";
            this.DeleteSpBtn.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.DeleteSpBtn.OnDisabledState.BorderRadius = 0;
            this.DeleteSpBtn.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.DeleteSpBtn.OnDisabledState.BorderThickness = 2;
            this.DeleteSpBtn.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.DeleteSpBtn.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.DeleteSpBtn.OnDisabledState.IconLeftImage = null;
            this.DeleteSpBtn.OnDisabledState.IconRightImage = null;
            this.DeleteSpBtn.onHoverState.BorderColor = System.Drawing.Color.Black;
            this.DeleteSpBtn.onHoverState.BorderRadius = 0;
            this.DeleteSpBtn.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.DeleteSpBtn.onHoverState.BorderThickness = 2;
            this.DeleteSpBtn.onHoverState.FillColor = System.Drawing.Color.Red;
            this.DeleteSpBtn.onHoverState.ForeColor = System.Drawing.Color.Black;
            this.DeleteSpBtn.onHoverState.IconLeftImage = null;
            this.DeleteSpBtn.onHoverState.IconRightImage = null;
            this.DeleteSpBtn.OnIdleState.BorderColor = System.Drawing.Color.LightBlue;
            this.DeleteSpBtn.OnIdleState.BorderRadius = 0;
            this.DeleteSpBtn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.DeleteSpBtn.OnIdleState.BorderThickness = 2;
            this.DeleteSpBtn.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(144)))), ((int)(((byte)(231)))));
            this.DeleteSpBtn.OnIdleState.ForeColor = System.Drawing.SystemColors.Info;
            this.DeleteSpBtn.OnIdleState.IconLeftImage = null;
            this.DeleteSpBtn.OnIdleState.IconRightImage = null;
            this.DeleteSpBtn.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.DeleteSpBtn.OnPressedState.BorderRadius = 0;
            this.DeleteSpBtn.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.DeleteSpBtn.OnPressedState.BorderThickness = 2;
            this.DeleteSpBtn.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.DeleteSpBtn.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.DeleteSpBtn.OnPressedState.IconLeftImage = null;
            this.DeleteSpBtn.OnPressedState.IconRightImage = null;
            this.DeleteSpBtn.Size = new System.Drawing.Size(134, 59);
            this.DeleteSpBtn.TabIndex = 17;
            this.DeleteSpBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DeleteSpBtn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.DeleteSpBtn.TextMarginLeft = 0;
            this.DeleteSpBtn.TextPadding = new System.Windows.Forms.Padding(0);
            this.DeleteSpBtn.UseDefaultRadiusAndThickness = true;
            this.DeleteSpBtn.Click += new System.EventHandler(this.DeleteSpBtn_Click);
            // 
            // AddSpbtn
            // 
            this.AddSpbtn.AllowAnimations = true;
            this.AddSpbtn.AllowMouseEffects = true;
            this.AddSpbtn.AllowToggling = false;
            this.AddSpbtn.AnimationSpeed = 200;
            this.AddSpbtn.AutoGenerateColors = false;
            this.AddSpbtn.AutoRoundBorders = false;
            this.AddSpbtn.AutoSizeLeftIcon = true;
            this.AddSpbtn.AutoSizeRightIcon = true;
            this.AddSpbtn.BackColor = System.Drawing.Color.Transparent;
            this.AddSpbtn.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(144)))), ((int)(((byte)(231)))));
            this.AddSpbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddSpbtn.BackgroundImage")));
            this.AddSpbtn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.AddSpbtn.ButtonText = "Add";
            this.AddSpbtn.ButtonTextMarginLeft = 0;
            this.AddSpbtn.ColorContrastOnClick = 45;
            this.AddSpbtn.ColorContrastOnHover = 45;
            this.AddSpbtn.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.AddSpbtn.CustomizableEdges = borderEdges2;
            this.AddSpbtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.AddSpbtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.AddSpbtn.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.AddSpbtn.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.AddSpbtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddSpbtn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Idle;
            this.AddSpbtn.Font = new System.Drawing.Font("Sitka Display", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddSpbtn.ForeColor = System.Drawing.SystemColors.Info;
            this.AddSpbtn.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddSpbtn.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.AddSpbtn.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.AddSpbtn.IconMarginLeft = 11;
            this.AddSpbtn.IconPadding = 10;
            this.AddSpbtn.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AddSpbtn.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.AddSpbtn.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.AddSpbtn.IconSize = 25;
            this.AddSpbtn.IdleBorderColor = System.Drawing.Color.LightBlue;
            this.AddSpbtn.IdleBorderRadius = 50;
            this.AddSpbtn.IdleBorderThickness = 2;
            this.AddSpbtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(144)))), ((int)(((byte)(231)))));
            this.AddSpbtn.IdleIconLeftImage = null;
            this.AddSpbtn.IdleIconRightImage = null;
            this.AddSpbtn.IndicateFocus = false;
            this.AddSpbtn.Location = new System.Drawing.Point(90, 3);
            this.AddSpbtn.Name = "AddSpbtn";
            this.AddSpbtn.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.AddSpbtn.OnDisabledState.BorderRadius = 0;
            this.AddSpbtn.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.AddSpbtn.OnDisabledState.BorderThickness = 2;
            this.AddSpbtn.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.AddSpbtn.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.AddSpbtn.OnDisabledState.IconLeftImage = null;
            this.AddSpbtn.OnDisabledState.IconRightImage = null;
            this.AddSpbtn.onHoverState.BorderColor = System.Drawing.Color.Black;
            this.AddSpbtn.onHoverState.BorderRadius = 0;
            this.AddSpbtn.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.AddSpbtn.onHoverState.BorderThickness = 2;
            this.AddSpbtn.onHoverState.FillColor = System.Drawing.Color.Red;
            this.AddSpbtn.onHoverState.ForeColor = System.Drawing.Color.Black;
            this.AddSpbtn.onHoverState.IconLeftImage = null;
            this.AddSpbtn.onHoverState.IconRightImage = null;
            this.AddSpbtn.OnIdleState.BorderColor = System.Drawing.Color.LightBlue;
            this.AddSpbtn.OnIdleState.BorderRadius = 0;
            this.AddSpbtn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.AddSpbtn.OnIdleState.BorderThickness = 2;
            this.AddSpbtn.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(144)))), ((int)(((byte)(231)))));
            this.AddSpbtn.OnIdleState.ForeColor = System.Drawing.SystemColors.Info;
            this.AddSpbtn.OnIdleState.IconLeftImage = null;
            this.AddSpbtn.OnIdleState.IconRightImage = null;
            this.AddSpbtn.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.AddSpbtn.OnPressedState.BorderRadius = 0;
            this.AddSpbtn.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.AddSpbtn.OnPressedState.BorderThickness = 2;
            this.AddSpbtn.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.AddSpbtn.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.AddSpbtn.OnPressedState.IconLeftImage = null;
            this.AddSpbtn.OnPressedState.IconRightImage = null;
            this.AddSpbtn.Size = new System.Drawing.Size(134, 59);
            this.AddSpbtn.TabIndex = 16;
            this.AddSpbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AddSpbtn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.AddSpbtn.TextMarginLeft = 0;
            this.AddSpbtn.TextPadding = new System.Windows.Forms.Padding(0);
            this.AddSpbtn.UseDefaultRadiusAndThickness = true;
            this.AddSpbtn.Click += new System.EventHandler(this.AddSpbtn_Click);
            // 
            // UpdateBtnSp
            // 
            this.UpdateBtnSp.AllowAnimations = true;
            this.UpdateBtnSp.AllowMouseEffects = true;
            this.UpdateBtnSp.AllowToggling = false;
            this.UpdateBtnSp.AnimationSpeed = 200;
            this.UpdateBtnSp.AutoGenerateColors = false;
            this.UpdateBtnSp.AutoRoundBorders = false;
            this.UpdateBtnSp.AutoSizeLeftIcon = true;
            this.UpdateBtnSp.AutoSizeRightIcon = true;
            this.UpdateBtnSp.BackColor = System.Drawing.Color.Transparent;
            this.UpdateBtnSp.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(144)))), ((int)(((byte)(231)))));
            this.UpdateBtnSp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("UpdateBtnSp.BackgroundImage")));
            this.UpdateBtnSp.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.UpdateBtnSp.ButtonText = "Update";
            this.UpdateBtnSp.ButtonTextMarginLeft = 0;
            this.UpdateBtnSp.ColorContrastOnClick = 45;
            this.UpdateBtnSp.ColorContrastOnHover = 45;
            this.UpdateBtnSp.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.UpdateBtnSp.CustomizableEdges = borderEdges3;
            this.UpdateBtnSp.DialogResult = System.Windows.Forms.DialogResult.None;
            this.UpdateBtnSp.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.UpdateBtnSp.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.UpdateBtnSp.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.UpdateBtnSp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UpdateBtnSp.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Idle;
            this.UpdateBtnSp.Font = new System.Drawing.Font("Sitka Display", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateBtnSp.ForeColor = System.Drawing.SystemColors.Info;
            this.UpdateBtnSp.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UpdateBtnSp.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.UpdateBtnSp.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.UpdateBtnSp.IconMarginLeft = 11;
            this.UpdateBtnSp.IconPadding = 10;
            this.UpdateBtnSp.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.UpdateBtnSp.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.UpdateBtnSp.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.UpdateBtnSp.IconSize = 25;
            this.UpdateBtnSp.IdleBorderColor = System.Drawing.Color.LightBlue;
            this.UpdateBtnSp.IdleBorderRadius = 50;
            this.UpdateBtnSp.IdleBorderThickness = 2;
            this.UpdateBtnSp.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(144)))), ((int)(((byte)(231)))));
            this.UpdateBtnSp.IdleIconLeftImage = null;
            this.UpdateBtnSp.IdleIconRightImage = null;
            this.UpdateBtnSp.IndicateFocus = false;
            this.UpdateBtnSp.Location = new System.Drawing.Point(317, 3);
            this.UpdateBtnSp.Name = "UpdateBtnSp";
            this.UpdateBtnSp.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.UpdateBtnSp.OnDisabledState.BorderRadius = 0;
            this.UpdateBtnSp.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.UpdateBtnSp.OnDisabledState.BorderThickness = 2;
            this.UpdateBtnSp.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.UpdateBtnSp.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.UpdateBtnSp.OnDisabledState.IconLeftImage = null;
            this.UpdateBtnSp.OnDisabledState.IconRightImage = null;
            this.UpdateBtnSp.onHoverState.BorderColor = System.Drawing.Color.Black;
            this.UpdateBtnSp.onHoverState.BorderRadius = 0;
            this.UpdateBtnSp.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.UpdateBtnSp.onHoverState.BorderThickness = 2;
            this.UpdateBtnSp.onHoverState.FillColor = System.Drawing.Color.Red;
            this.UpdateBtnSp.onHoverState.ForeColor = System.Drawing.Color.Black;
            this.UpdateBtnSp.onHoverState.IconLeftImage = null;
            this.UpdateBtnSp.onHoverState.IconRightImage = null;
            this.UpdateBtnSp.OnIdleState.BorderColor = System.Drawing.Color.LightBlue;
            this.UpdateBtnSp.OnIdleState.BorderRadius = 0;
            this.UpdateBtnSp.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.UpdateBtnSp.OnIdleState.BorderThickness = 2;
            this.UpdateBtnSp.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(144)))), ((int)(((byte)(231)))));
            this.UpdateBtnSp.OnIdleState.ForeColor = System.Drawing.SystemColors.Info;
            this.UpdateBtnSp.OnIdleState.IconLeftImage = null;
            this.UpdateBtnSp.OnIdleState.IconRightImage = null;
            this.UpdateBtnSp.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.UpdateBtnSp.OnPressedState.BorderRadius = 0;
            this.UpdateBtnSp.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.UpdateBtnSp.OnPressedState.BorderThickness = 2;
            this.UpdateBtnSp.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.UpdateBtnSp.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.UpdateBtnSp.OnPressedState.IconLeftImage = null;
            this.UpdateBtnSp.OnPressedState.IconRightImage = null;
            this.UpdateBtnSp.Size = new System.Drawing.Size(134, 59);
            this.UpdateBtnSp.TabIndex = 18;
            this.UpdateBtnSp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.UpdateBtnSp.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.UpdateBtnSp.TextMarginLeft = 0;
            this.UpdateBtnSp.TextPadding = new System.Windows.Forms.Padding(0);
            this.UpdateBtnSp.UseDefaultRadiusAndThickness = true;
            this.UpdateBtnSp.Click += new System.EventHandler(this.UpdateBtnSp_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.InputsContainer);
            this.MainPanel.Controls.Add(this.TopContainer);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(934, 687);
            this.MainPanel.TabIndex = 2;
            // 
            // InputsContainer
            // 
            this.InputsContainer.Controls.Add(this.CeoPanel);
            this.InputsContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.InputsContainer.Location = new System.Drawing.Point(0, 150);
            this.InputsContainer.Name = "InputsContainer";
            this.InputsContainer.Size = new System.Drawing.Size(934, 537);
            this.InputsContainer.TabIndex = 1;
            // 
            // TopContainer
            // 
            this.TopContainer.Controls.Add(this.Logo2);
            this.TopContainer.Controls.Add(this.Logo);
            this.TopContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopContainer.Location = new System.Drawing.Point(0, 0);
            this.TopContainer.Name = "TopContainer";
            this.TopContainer.Size = new System.Drawing.Size(934, 150);
            this.TopContainer.TabIndex = 0;
            // 
            // Logo2
            // 
            this.Logo2.BackColor = System.Drawing.Color.Lavender;
            this.Logo2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Logo2.Image = ((System.Drawing.Image)(resources.GetObject("Logo2.Image")));
            this.Logo2.Location = new System.Drawing.Point(150, 0);
            this.Logo2.Name = "Logo2";
            this.Logo2.Size = new System.Drawing.Size(784, 150);
            this.Logo2.TabIndex = 1;
            // 
            // Logo
            // 
            this.Logo.Dock = System.Windows.Forms.DockStyle.Left;
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(0, 0);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(150, 150);
            this.Logo.TabIndex = 0;
            // 
            // CeoUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 687);
            this.Controls.Add(this.MainPanel);
            this.MinimumSize = new System.Drawing.Size(950, 726);
            this.Name = "CeoUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CeoUI";
            this.Dashboard.ResumeLayout(false);
            this.DashboardInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Pic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic4)).EndInit();
            this.CeoPanel.ResumeLayout(false);
            this.ManageEmployee.ResumeLayout(false);
            this.Inputs.ResumeLayout(false);
            this.Inputs.PerformLayout();
            this.BottomContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SPGridView1)).EndInit();
            this.ButtonsContainer.ResumeLayout(false);
            this.MainPanel.ResumeLayout(false);
            this.InputsContainer.ResumeLayout(false);
            this.TopContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage Dashboard;
        private Guna.UI2.WinForms.Guna2TabControl CeoPanel;
        private System.Windows.Forms.TabPage ManageEmployee;
        private Guna.UI.WinForms.GunaPanel MainPanel;
        private Guna.UI2.WinForms.Guna2Panel InputsContainer;
        private Guna.UI2.WinForms.Guna2Panel TopContainer;
        private System.Windows.Forms.Label Logo2;
        private System.Windows.Forms.Label Logo;
        private System.Windows.Forms.TableLayoutPanel DashboardInfo;
        private Guna.UI2.WinForms.Guna2PictureBox Pic1;
        private Guna.UI2.WinForms.Guna2PictureBox Pic2;
        private Guna.UI2.WinForms.Guna2PictureBox Pic3;
        private Guna.UI2.WinForms.Guna2PictureBox Pic4;
        private System.Windows.Forms.Label DataShow1;
        private System.Windows.Forms.Label DataShow2;
        private System.Windows.Forms.Label DataShow3;
        private System.Windows.Forms.Label DataShow4;
        private System.Windows.Forms.Panel BottomContainer;
        private System.Windows.Forms.TableLayoutPanel Inputs;
        private Guna.UI.WinForms.GunaLabel Contact;
        private Guna.UI.WinForms.GunaLabel DOB;
        private Guna.UI.WinForms.GunaLabel Address;
        private Guna.UI.WinForms.GunaLabel Gender;
        private Guna.UI.WinForms.GunaLabel Username;
        private Guna.UI.WinForms.GunaLabel Password;
        private Guna.UI.WinForms.GunaLabel IName;
        private Guna.UI.WinForms.GunaLabel Email;
        private Guna.UI2.WinForms.Guna2TextBox NInput;
        private Guna.UI2.WinForms.Guna2TextBox UInput;
        private Guna.UI2.WinForms.Guna2TextBox PInput;
        private Guna.UI2.WinForms.Guna2TextBox EInput;
        private Guna.UI2.WinForms.Guna2TextBox CInput;
        private Guna.UI2.WinForms.Guna2TextBox AInput;
        private Guna.UI2.WinForms.Guna2ComboBox GInput;
        private Guna.UI2.WinForms.Guna2DateTimePicker DOBI;
        private System.Windows.Forms.TableLayoutPanel ButtonsContainer;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton AddSpbtn;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton DeleteSpBtn;
        private System.Windows.Forms.DataGridView SPGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton UpdateBtnSp;
    }
}