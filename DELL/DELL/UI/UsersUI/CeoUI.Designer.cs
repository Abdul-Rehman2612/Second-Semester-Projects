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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges13 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges14 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges15 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges16 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges17 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges18 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.CEOMainPanel = new Guna.UI.WinForms.GunaPanel();
            this.CEOTabControl = new Guna.UI2.WinForms.Guna2TabControl();
            this.Dashboard = new System.Windows.Forms.TabPage();
            this.MainPanelDB = new Guna.UI.WinForms.GunaPanel();
            this.DashboardInfo = new System.Windows.Forms.TableLayoutPanel();
            this.Pic1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Pic2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Pic3 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Pic4 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.DataShow1 = new System.Windows.Forms.Label();
            this.DataShow2 = new System.Windows.Forms.Label();
            this.DataShow3 = new System.Windows.Forms.Label();
            this.DataShow4 = new System.Windows.Forms.Label();
            this.ManageSalesPersons = new System.Windows.Forms.TabPage();
            this.MainPanelMSP = new Guna.UI.WinForms.GunaPanel();
            this.BottomContainerMSP = new Guna.UI.WinForms.GunaPanel();
            this.SPGridView = new System.Windows.Forms.DataGridView();
            this.Column1SP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2SP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3SP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4SP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5SP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6SP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7SP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8SP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9SP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ButtonsContainerMSP = new System.Windows.Forms.TableLayoutPanel();
            this.DeleteSpBtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.AddSpbtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.UpdateSpBtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.TopContainerMSP = new Guna.UI.WinForms.GunaPanel();
            this.MSPLabel = new System.Windows.Forms.Label();
            this.InputsSP = new System.Windows.Forms.TableLayoutPanel();
            this.ContactSP = new Guna.UI.WinForms.GunaLabel();
            this.DOBSP = new Guna.UI.WinForms.GunaLabel();
            this.AddressSP = new Guna.UI.WinForms.GunaLabel();
            this.GenderSP = new Guna.UI.WinForms.GunaLabel();
            this.UsernameSP = new Guna.UI.WinForms.GunaLabel();
            this.PasswordSP = new Guna.UI.WinForms.GunaLabel();
            this.INameSP = new Guna.UI.WinForms.GunaLabel();
            this.EmailSP = new Guna.UI.WinForms.GunaLabel();
            this.NInputSP = new Guna.UI2.WinForms.Guna2TextBox();
            this.UInputSP = new Guna.UI2.WinForms.Guna2TextBox();
            this.PInputSP = new Guna.UI2.WinForms.Guna2TextBox();
            this.EInputSP = new Guna.UI2.WinForms.Guna2TextBox();
            this.CInputSP = new Guna.UI2.WinForms.Guna2TextBox();
            this.AInputSP = new Guna.UI2.WinForms.Guna2TextBox();
            this.GInputSP = new Guna.UI2.WinForms.Guna2ComboBox();
            this.DOBISP = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.ManageTechnicians = new System.Windows.Forms.TabPage();
            this.MainPanelMT = new Guna.UI.WinForms.GunaPanel();
            this.BottomContainerMT = new Guna.UI.WinForms.GunaPanel();
            this.TGridView = new System.Windows.Forms.DataGridView();
            this.Column1MT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2MT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3MT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4MT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5MT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6MT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7MT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8MT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9MT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ButtonsContainerMT = new System.Windows.Forms.TableLayoutPanel();
            this.DeleteMTBtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.AddMTBtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.UpdateMTBtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.TopContainerMT = new Guna.UI.WinForms.GunaPanel();
            this.MTLabel = new System.Windows.Forms.Label();
            this.InputsMT = new System.Windows.Forms.TableLayoutPanel();
            this.ContactMT = new Guna.UI.WinForms.GunaLabel();
            this.DOBMT = new Guna.UI.WinForms.GunaLabel();
            this.AddressMT = new Guna.UI.WinForms.GunaLabel();
            this.GenderMT = new Guna.UI.WinForms.GunaLabel();
            this.UsernameMT = new Guna.UI.WinForms.GunaLabel();
            this.PasswordMT = new Guna.UI.WinForms.GunaLabel();
            this.NameMT = new Guna.UI.WinForms.GunaLabel();
            this.EmailMT = new Guna.UI.WinForms.GunaLabel();
            this.NInputMT = new Guna.UI2.WinForms.Guna2TextBox();
            this.UInputMT = new Guna.UI2.WinForms.Guna2TextBox();
            this.PInputMT = new Guna.UI2.WinForms.Guna2TextBox();
            this.EInputMT = new Guna.UI2.WinForms.Guna2TextBox();
            this.CInputMT = new Guna.UI2.WinForms.Guna2TextBox();
            this.AInputMT = new Guna.UI2.WinForms.Guna2TextBox();
            this.GInputMT = new Guna.UI2.WinForms.Guna2ComboBox();
            this.DOBIMT = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.CEOTopContainer = new Guna.UI2.WinForms.Guna2Panel();
            this.Logo2 = new System.Windows.Forms.Label();
            this.Logo = new System.Windows.Forms.Label();
            this.CEOMainPanel.SuspendLayout();
            this.CEOTabControl.SuspendLayout();
            this.Dashboard.SuspendLayout();
            this.MainPanelDB.SuspendLayout();
            this.DashboardInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic4)).BeginInit();
            this.ManageSalesPersons.SuspendLayout();
            this.MainPanelMSP.SuspendLayout();
            this.BottomContainerMSP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SPGridView)).BeginInit();
            this.ButtonsContainerMSP.SuspendLayout();
            this.TopContainerMSP.SuspendLayout();
            this.InputsSP.SuspendLayout();
            this.ManageTechnicians.SuspendLayout();
            this.MainPanelMT.SuspendLayout();
            this.BottomContainerMT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TGridView)).BeginInit();
            this.ButtonsContainerMT.SuspendLayout();
            this.TopContainerMT.SuspendLayout();
            this.InputsMT.SuspendLayout();
            this.CEOTopContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // CEOMainPanel
            // 
            this.CEOMainPanel.Controls.Add(this.CEOTabControl);
            this.CEOMainPanel.Controls.Add(this.CEOTopContainer);
            this.CEOMainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CEOMainPanel.Location = new System.Drawing.Point(0, 0);
            this.CEOMainPanel.Name = "CEOMainPanel";
            this.CEOMainPanel.Size = new System.Drawing.Size(934, 749);
            this.CEOMainPanel.TabIndex = 2;
            // 
            // CEOTabControl
            // 
            this.CEOTabControl.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.CEOTabControl.Controls.Add(this.Dashboard);
            this.CEOTabControl.Controls.Add(this.ManageSalesPersons);
            this.CEOTabControl.Controls.Add(this.ManageTechnicians);
            this.CEOTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CEOTabControl.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CEOTabControl.ItemSize = new System.Drawing.Size(150, 40);
            this.CEOTabControl.Location = new System.Drawing.Point(0, 150);
            this.CEOTabControl.Name = "CEOTabControl";
            this.CEOTabControl.SelectedIndex = 0;
            this.CEOTabControl.Size = new System.Drawing.Size(934, 599);
            this.CEOTabControl.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.CEOTabControl.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.CEOTabControl.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.CEOTabControl.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.CEOTabControl.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.CEOTabControl.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.CEOTabControl.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.CEOTabControl.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.CEOTabControl.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.CEOTabControl.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.CEOTabControl.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.CEOTabControl.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.CEOTabControl.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.CEOTabControl.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.CEOTabControl.TabButtonSelectedState.InnerColor = System.Drawing.Color.Lime;
            this.CEOTabControl.TabButtonSize = new System.Drawing.Size(150, 40);
            this.CEOTabControl.TabIndex = 1;
            this.CEOTabControl.TabMenuBackColor = System.Drawing.Color.Lavender;
            // 
            // Dashboard
            // 
            this.Dashboard.BackColor = System.Drawing.Color.GhostWhite;
            this.Dashboard.Controls.Add(this.MainPanelDB);
            this.Dashboard.Location = new System.Drawing.Point(154, 4);
            this.Dashboard.Name = "Dashboard";
            this.Dashboard.Padding = new System.Windows.Forms.Padding(3);
            this.Dashboard.Size = new System.Drawing.Size(776, 591);
            this.Dashboard.TabIndex = 0;
            this.Dashboard.Text = "Dashboard";
            // 
            // MainPanelDB
            // 
            this.MainPanelDB.Controls.Add(this.DashboardInfo);
            this.MainPanelDB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanelDB.Location = new System.Drawing.Point(3, 3);
            this.MainPanelDB.Name = "MainPanelDB";
            this.MainPanelDB.Size = new System.Drawing.Size(770, 585);
            this.MainPanelDB.TabIndex = 0;
            // 
            // DashboardInfo
            // 
            this.DashboardInfo.BackColor = System.Drawing.Color.White;
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
            this.DashboardInfo.Location = new System.Drawing.Point(0, 0);
            this.DashboardInfo.Name = "DashboardInfo";
            this.DashboardInfo.RowCount = 7;
            this.DashboardInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.35484F));
            this.DashboardInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 175F));
            this.DashboardInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.35484F));
            this.DashboardInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.225806F));
            this.DashboardInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 175F));
            this.DashboardInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.35484F));
            this.DashboardInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.35484F));
            this.DashboardInfo.Size = new System.Drawing.Size(770, 585);
            this.DashboardInfo.TabIndex = 1;
            // 
            // Pic1
            // 
            this.Pic1.Image = ((System.Drawing.Image)(resources.GetObject("Pic1.Image")));
            this.Pic1.ImageRotate = 0F;
            this.Pic1.Location = new System.Drawing.Point(126, 59);
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
            this.Pic2.Location = new System.Drawing.Point(449, 59);
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
            this.Pic3.Location = new System.Drawing.Point(126, 299);
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
            this.Pic4.Location = new System.Drawing.Point(449, 299);
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
            this.DataShow1.Location = new System.Drawing.Point(126, 231);
            this.DataShow1.Name = "DataShow1";
            this.DataShow1.Size = new System.Drawing.Size(194, 56);
            this.DataShow1.TabIndex = 12;
            // 
            // DataShow2
            // 
            this.DataShow2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataShow2.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataShow2.Location = new System.Drawing.Point(449, 231);
            this.DataShow2.Name = "DataShow2";
            this.DataShow2.Size = new System.Drawing.Size(194, 56);
            this.DataShow2.TabIndex = 13;
            // 
            // DataShow3
            // 
            this.DataShow3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataShow3.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataShow3.Location = new System.Drawing.Point(126, 471);
            this.DataShow3.Name = "DataShow3";
            this.DataShow3.Size = new System.Drawing.Size(194, 56);
            this.DataShow3.TabIndex = 14;
            // 
            // DataShow4
            // 
            this.DataShow4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataShow4.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataShow4.Location = new System.Drawing.Point(449, 471);
            this.DataShow4.Name = "DataShow4";
            this.DataShow4.Size = new System.Drawing.Size(194, 56);
            this.DataShow4.TabIndex = 15;
            // 
            // ManageSalesPersons
            // 
            this.ManageSalesPersons.BackColor = System.Drawing.Color.White;
            this.ManageSalesPersons.Controls.Add(this.MainPanelMSP);
            this.ManageSalesPersons.Font = new System.Drawing.Font("Sitka Display", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManageSalesPersons.Location = new System.Drawing.Point(154, 4);
            this.ManageSalesPersons.Name = "ManageSalesPersons";
            this.ManageSalesPersons.Padding = new System.Windows.Forms.Padding(3);
            this.ManageSalesPersons.Size = new System.Drawing.Size(776, 591);
            this.ManageSalesPersons.TabIndex = 1;
            this.ManageSalesPersons.Text = "Manage SalesPersons";
            // 
            // MainPanelMSP
            // 
            this.MainPanelMSP.Controls.Add(this.BottomContainerMSP);
            this.MainPanelMSP.Controls.Add(this.TopContainerMSP);
            this.MainPanelMSP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanelMSP.Location = new System.Drawing.Point(3, 3);
            this.MainPanelMSP.Name = "MainPanelMSP";
            this.MainPanelMSP.Size = new System.Drawing.Size(770, 585);
            this.MainPanelMSP.TabIndex = 0;
            // 
            // BottomContainerMSP
            // 
            this.BottomContainerMSP.Controls.Add(this.SPGridView);
            this.BottomContainerMSP.Controls.Add(this.ButtonsContainerMSP);
            this.BottomContainerMSP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BottomContainerMSP.Location = new System.Drawing.Point(0, 234);
            this.BottomContainerMSP.Name = "BottomContainerMSP";
            this.BottomContainerMSP.Size = new System.Drawing.Size(770, 351);
            this.BottomContainerMSP.TabIndex = 1;
            // 
            // SPGridView
            // 
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SPGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle15;
            this.SPGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SPGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Sitka Display", 12F);
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SPGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.SPGridView.ColumnHeadersHeight = 30;
            this.SPGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.SPGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1SP,
            this.Column2SP,
            this.Column3SP,
            this.Column4SP,
            this.Column5SP,
            this.Column6SP,
            this.Column7SP,
            this.Column8SP,
            this.Column9SP});
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Sitka Display", 12F);
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SPGridView.DefaultCellStyle = dataGridViewCellStyle17;
            this.SPGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SPGridView.Location = new System.Drawing.Point(0, 64);
            this.SPGridView.Name = "SPGridView";
            this.SPGridView.ReadOnly = true;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Sitka Display", 12F);
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SPGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.SPGridView.RowHeadersWidth = 40;
            this.SPGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Sitka Text", 12F);
            this.SPGridView.RowsDefaultCellStyle = dataGridViewCellStyle19;
            this.SPGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SPGridView.RowTemplate.Height = 20;
            this.SPGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SPGridView.Size = new System.Drawing.Size(770, 287);
            this.SPGridView.TabIndex = 2;
            this.SPGridView.SelectionChanged += new System.EventHandler(this.SPGridView_SelectionChanged);
            // 
            // Column1SP
            // 
            this.Column1SP.HeaderText = "Name";
            this.Column1SP.Name = "Column1SP";
            this.Column1SP.ReadOnly = true;
            // 
            // Column2SP
            // 
            this.Column2SP.HeaderText = "Username";
            this.Column2SP.Name = "Column2SP";
            this.Column2SP.ReadOnly = true;
            // 
            // Column3SP
            // 
            this.Column3SP.HeaderText = "Password";
            this.Column3SP.Name = "Column3SP";
            this.Column3SP.ReadOnly = true;
            // 
            // Column4SP
            // 
            this.Column4SP.HeaderText = "Email";
            this.Column4SP.Name = "Column4SP";
            this.Column4SP.ReadOnly = true;
            // 
            // Column5SP
            // 
            this.Column5SP.HeaderText = "Dob";
            this.Column5SP.Name = "Column5SP";
            this.Column5SP.ReadOnly = true;
            // 
            // Column6SP
            // 
            this.Column6SP.HeaderText = "Contact";
            this.Column6SP.Name = "Column6SP";
            this.Column6SP.ReadOnly = true;
            // 
            // Column7SP
            // 
            this.Column7SP.HeaderText = "Address";
            this.Column7SP.Name = "Column7SP";
            this.Column7SP.ReadOnly = true;
            // 
            // Column8SP
            // 
            this.Column8SP.FillWeight = 80F;
            this.Column8SP.HeaderText = "Gender";
            this.Column8SP.Name = "Column8SP";
            this.Column8SP.ReadOnly = true;
            // 
            // Column9SP
            // 
            this.Column9SP.HeaderText = "HireDate";
            this.Column9SP.Name = "Column9SP";
            this.Column9SP.ReadOnly = true;
            // 
            // ButtonsContainerMSP
            // 
            this.ButtonsContainerMSP.ColumnCount = 7;
            this.ButtonsContainerMSP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonsContainerMSP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.ButtonsContainerMSP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonsContainerMSP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.ButtonsContainerMSP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonsContainerMSP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.ButtonsContainerMSP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonsContainerMSP.Controls.Add(this.DeleteSpBtn, 5, 1);
            this.ButtonsContainerMSP.Controls.Add(this.AddSpbtn, 1, 1);
            this.ButtonsContainerMSP.Controls.Add(this.UpdateSpBtn, 3, 1);
            this.ButtonsContainerMSP.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonsContainerMSP.Location = new System.Drawing.Point(0, 0);
            this.ButtonsContainerMSP.Name = "ButtonsContainerMSP";
            this.ButtonsContainerMSP.RowCount = 2;
            this.ButtonsContainerMSP.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ButtonsContainerMSP.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ButtonsContainerMSP.Size = new System.Drawing.Size(770, 64);
            this.ButtonsContainerMSP.TabIndex = 1;
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
            borderEdges13.BottomLeft = true;
            borderEdges13.BottomRight = true;
            borderEdges13.TopLeft = true;
            borderEdges13.TopRight = true;
            this.DeleteSpBtn.CustomizableEdges = borderEdges13;
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
            borderEdges14.BottomLeft = true;
            borderEdges14.BottomRight = true;
            borderEdges14.TopLeft = true;
            borderEdges14.TopRight = true;
            this.AddSpbtn.CustomizableEdges = borderEdges14;
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
            // UpdateSpBtn
            // 
            this.UpdateSpBtn.AllowAnimations = true;
            this.UpdateSpBtn.AllowMouseEffects = true;
            this.UpdateSpBtn.AllowToggling = false;
            this.UpdateSpBtn.AnimationSpeed = 200;
            this.UpdateSpBtn.AutoGenerateColors = false;
            this.UpdateSpBtn.AutoRoundBorders = false;
            this.UpdateSpBtn.AutoSizeLeftIcon = true;
            this.UpdateSpBtn.AutoSizeRightIcon = true;
            this.UpdateSpBtn.BackColor = System.Drawing.Color.Transparent;
            this.UpdateSpBtn.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(144)))), ((int)(((byte)(231)))));
            this.UpdateSpBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("UpdateSpBtn.BackgroundImage")));
            this.UpdateSpBtn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.UpdateSpBtn.ButtonText = "Update";
            this.UpdateSpBtn.ButtonTextMarginLeft = 0;
            this.UpdateSpBtn.ColorContrastOnClick = 45;
            this.UpdateSpBtn.ColorContrastOnHover = 45;
            this.UpdateSpBtn.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges15.BottomLeft = true;
            borderEdges15.BottomRight = true;
            borderEdges15.TopLeft = true;
            borderEdges15.TopRight = true;
            this.UpdateSpBtn.CustomizableEdges = borderEdges15;
            this.UpdateSpBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.UpdateSpBtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.UpdateSpBtn.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.UpdateSpBtn.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.UpdateSpBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UpdateSpBtn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Idle;
            this.UpdateSpBtn.Font = new System.Drawing.Font("Sitka Display", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateSpBtn.ForeColor = System.Drawing.SystemColors.Info;
            this.UpdateSpBtn.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UpdateSpBtn.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.UpdateSpBtn.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.UpdateSpBtn.IconMarginLeft = 11;
            this.UpdateSpBtn.IconPadding = 10;
            this.UpdateSpBtn.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.UpdateSpBtn.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.UpdateSpBtn.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.UpdateSpBtn.IconSize = 25;
            this.UpdateSpBtn.IdleBorderColor = System.Drawing.Color.LightBlue;
            this.UpdateSpBtn.IdleBorderRadius = 50;
            this.UpdateSpBtn.IdleBorderThickness = 2;
            this.UpdateSpBtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(144)))), ((int)(((byte)(231)))));
            this.UpdateSpBtn.IdleIconLeftImage = null;
            this.UpdateSpBtn.IdleIconRightImage = null;
            this.UpdateSpBtn.IndicateFocus = false;
            this.UpdateSpBtn.Location = new System.Drawing.Point(317, 3);
            this.UpdateSpBtn.Name = "UpdateSpBtn";
            this.UpdateSpBtn.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.UpdateSpBtn.OnDisabledState.BorderRadius = 0;
            this.UpdateSpBtn.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.UpdateSpBtn.OnDisabledState.BorderThickness = 2;
            this.UpdateSpBtn.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.UpdateSpBtn.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.UpdateSpBtn.OnDisabledState.IconLeftImage = null;
            this.UpdateSpBtn.OnDisabledState.IconRightImage = null;
            this.UpdateSpBtn.onHoverState.BorderColor = System.Drawing.Color.Black;
            this.UpdateSpBtn.onHoverState.BorderRadius = 0;
            this.UpdateSpBtn.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.UpdateSpBtn.onHoverState.BorderThickness = 2;
            this.UpdateSpBtn.onHoverState.FillColor = System.Drawing.Color.Red;
            this.UpdateSpBtn.onHoverState.ForeColor = System.Drawing.Color.Black;
            this.UpdateSpBtn.onHoverState.IconLeftImage = null;
            this.UpdateSpBtn.onHoverState.IconRightImage = null;
            this.UpdateSpBtn.OnIdleState.BorderColor = System.Drawing.Color.LightBlue;
            this.UpdateSpBtn.OnIdleState.BorderRadius = 0;
            this.UpdateSpBtn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.UpdateSpBtn.OnIdleState.BorderThickness = 2;
            this.UpdateSpBtn.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(144)))), ((int)(((byte)(231)))));
            this.UpdateSpBtn.OnIdleState.ForeColor = System.Drawing.SystemColors.Info;
            this.UpdateSpBtn.OnIdleState.IconLeftImage = null;
            this.UpdateSpBtn.OnIdleState.IconRightImage = null;
            this.UpdateSpBtn.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.UpdateSpBtn.OnPressedState.BorderRadius = 0;
            this.UpdateSpBtn.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.UpdateSpBtn.OnPressedState.BorderThickness = 2;
            this.UpdateSpBtn.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.UpdateSpBtn.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.UpdateSpBtn.OnPressedState.IconLeftImage = null;
            this.UpdateSpBtn.OnPressedState.IconRightImage = null;
            this.UpdateSpBtn.Size = new System.Drawing.Size(134, 59);
            this.UpdateSpBtn.TabIndex = 18;
            this.UpdateSpBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.UpdateSpBtn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.UpdateSpBtn.TextMarginLeft = 0;
            this.UpdateSpBtn.TextPadding = new System.Windows.Forms.Padding(0);
            this.UpdateSpBtn.UseDefaultRadiusAndThickness = true;
            // 
            // TopContainerMSP
            // 
            this.TopContainerMSP.Controls.Add(this.MSPLabel);
            this.TopContainerMSP.Controls.Add(this.InputsSP);
            this.TopContainerMSP.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopContainerMSP.Location = new System.Drawing.Point(0, 0);
            this.TopContainerMSP.Name = "TopContainerMSP";
            this.TopContainerMSP.Size = new System.Drawing.Size(770, 234);
            this.TopContainerMSP.TabIndex = 0;
            // 
            // MSPLabel
            // 
            this.MSPLabel.BackColor = System.Drawing.Color.Transparent;
            this.MSPLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MSPLabel.Font = new System.Drawing.Font("Sitka Display", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MSPLabel.Location = new System.Drawing.Point(0, 0);
            this.MSPLabel.Name = "MSPLabel";
            this.MSPLabel.Size = new System.Drawing.Size(770, 39);
            this.MSPLabel.TabIndex = 4;
            this.MSPLabel.Text = "Manage SalesPersons";
            this.MSPLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InputsSP
            // 
            this.InputsSP.BackColor = System.Drawing.Color.GhostWhite;
            this.InputsSP.ColumnCount = 7;
            this.InputsSP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.46055F));
            this.InputsSP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.20111F));
            this.InputsSP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.295F));
            this.InputsSP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.302407F));
            this.InputsSP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.11686F));
            this.InputsSP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.64033F));
            this.InputsSP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.98374F));
            this.InputsSP.Controls.Add(this.ContactSP, 4, 2);
            this.InputsSP.Controls.Add(this.DOBSP, 4, 0);
            this.InputsSP.Controls.Add(this.AddressSP, 4, 3);
            this.InputsSP.Controls.Add(this.GenderSP, 4, 1);
            this.InputsSP.Controls.Add(this.UsernameSP, 1, 1);
            this.InputsSP.Controls.Add(this.PasswordSP, 1, 2);
            this.InputsSP.Controls.Add(this.INameSP, 1, 0);
            this.InputsSP.Controls.Add(this.EmailSP, 1, 3);
            this.InputsSP.Controls.Add(this.NInputSP, 2, 0);
            this.InputsSP.Controls.Add(this.UInputSP, 2, 1);
            this.InputsSP.Controls.Add(this.PInputSP, 2, 2);
            this.InputsSP.Controls.Add(this.EInputSP, 2, 3);
            this.InputsSP.Controls.Add(this.CInputSP, 5, 2);
            this.InputsSP.Controls.Add(this.AInputSP, 5, 3);
            this.InputsSP.Controls.Add(this.GInputSP, 5, 1);
            this.InputsSP.Controls.Add(this.DOBISP, 5, 0);
            this.InputsSP.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.InputsSP.ForeColor = System.Drawing.Color.Black;
            this.InputsSP.Location = new System.Drawing.Point(0, 39);
            this.InputsSP.Name = "InputsSP";
            this.InputsSP.RowCount = 4;
            this.InputsSP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.InputsSP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.InputsSP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.InputsSP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.InputsSP.Size = new System.Drawing.Size(770, 195);
            this.InputsSP.TabIndex = 3;
            // 
            // ContactSP
            // 
            this.ContactSP.AutoSize = true;
            this.ContactSP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContactSP.Font = new System.Drawing.Font("Sitka Heading", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContactSP.Location = new System.Drawing.Point(387, 98);
            this.ContactSP.Name = "ContactSP";
            this.ContactSP.Size = new System.Drawing.Size(118, 49);
            this.ContactSP.TabIndex = 3;
            this.ContactSP.Text = "Contact";
            this.ContactSP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DOBSP
            // 
            this.DOBSP.AutoSize = true;
            this.DOBSP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DOBSP.Font = new System.Drawing.Font("Sitka Heading", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DOBSP.Location = new System.Drawing.Point(387, 0);
            this.DOBSP.Name = "DOBSP";
            this.DOBSP.Size = new System.Drawing.Size(118, 49);
            this.DOBSP.TabIndex = 10;
            this.DOBSP.Text = "DOB";
            this.DOBSP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddressSP
            // 
            this.AddressSP.AutoSize = true;
            this.AddressSP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddressSP.Font = new System.Drawing.Font("Sitka Heading", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressSP.Location = new System.Drawing.Point(387, 147);
            this.AddressSP.Name = "AddressSP";
            this.AddressSP.Size = new System.Drawing.Size(118, 49);
            this.AddressSP.TabIndex = 5;
            this.AddressSP.Text = "Address";
            this.AddressSP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GenderSP
            // 
            this.GenderSP.AutoSize = true;
            this.GenderSP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GenderSP.Font = new System.Drawing.Font("Sitka Heading", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenderSP.Location = new System.Drawing.Point(387, 49);
            this.GenderSP.Name = "GenderSP";
            this.GenderSP.Size = new System.Drawing.Size(118, 49);
            this.GenderSP.TabIndex = 9;
            this.GenderSP.Text = "Gender";
            this.GenderSP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UsernameSP
            // 
            this.UsernameSP.AutoSize = true;
            this.UsernameSP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UsernameSP.Font = new System.Drawing.Font("Sitka Heading", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameSP.Location = new System.Drawing.Point(83, 49);
            this.UsernameSP.Name = "UsernameSP";
            this.UsernameSP.Size = new System.Drawing.Size(118, 49);
            this.UsernameSP.TabIndex = 6;
            this.UsernameSP.Text = "Username";
            this.UsernameSP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PasswordSP
            // 
            this.PasswordSP.AutoSize = true;
            this.PasswordSP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PasswordSP.Font = new System.Drawing.Font("Sitka Heading", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordSP.Location = new System.Drawing.Point(83, 98);
            this.PasswordSP.Name = "PasswordSP";
            this.PasswordSP.Size = new System.Drawing.Size(118, 49);
            this.PasswordSP.TabIndex = 7;
            this.PasswordSP.Text = "Password";
            this.PasswordSP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // INameSP
            // 
            this.INameSP.AutoSize = true;
            this.INameSP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.INameSP.Font = new System.Drawing.Font("Sitka Heading", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.INameSP.Location = new System.Drawing.Point(83, 0);
            this.INameSP.Name = "INameSP";
            this.INameSP.Size = new System.Drawing.Size(118, 49);
            this.INameSP.TabIndex = 4;
            this.INameSP.Text = "Name";
            this.INameSP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EmailSP
            // 
            this.EmailSP.AutoSize = true;
            this.EmailSP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EmailSP.Font = new System.Drawing.Font("Sitka Heading", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailSP.Location = new System.Drawing.Point(83, 147);
            this.EmailSP.Name = "EmailSP";
            this.EmailSP.Size = new System.Drawing.Size(118, 49);
            this.EmailSP.TabIndex = 8;
            this.EmailSP.Text = "Email";
            this.EmailSP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NInputSP
            // 
            this.NInputSP.AutoRoundedCorners = true;
            this.NInputSP.BorderRadius = 17;
            this.NInputSP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NInputSP.DefaultText = "";
            this.NInputSP.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.NInputSP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.NInputSP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NInputSP.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NInputSP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NInputSP.FillColor = System.Drawing.SystemColors.InactiveBorder;
            this.NInputSP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NInputSP.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NInputSP.ForeColor = System.Drawing.Color.Black;
            this.NInputSP.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NInputSP.Location = new System.Drawing.Point(209, 6);
            this.NInputSP.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.NInputSP.Name = "NInputSP";
            this.NInputSP.PasswordChar = '\0';
            this.NInputSP.PlaceholderText = "Enter name";
            this.NInputSP.SelectedText = "";
            this.NInputSP.Size = new System.Drawing.Size(153, 37);
            this.NInputSP.TabIndex = 11;
            // 
            // UInputSP
            // 
            this.UInputSP.AutoRoundedCorners = true;
            this.UInputSP.BorderRadius = 17;
            this.UInputSP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UInputSP.DefaultText = "";
            this.UInputSP.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.UInputSP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.UInputSP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UInputSP.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UInputSP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UInputSP.FillColor = System.Drawing.SystemColors.InactiveBorder;
            this.UInputSP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UInputSP.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UInputSP.ForeColor = System.Drawing.Color.Black;
            this.UInputSP.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UInputSP.Location = new System.Drawing.Point(209, 55);
            this.UInputSP.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.UInputSP.Name = "UInputSP";
            this.UInputSP.PasswordChar = '\0';
            this.UInputSP.PlaceholderText = "John123 etc.";
            this.UInputSP.SelectedText = "";
            this.UInputSP.Size = new System.Drawing.Size(153, 37);
            this.UInputSP.TabIndex = 12;
            // 
            // PInputSP
            // 
            this.PInputSP.AutoRoundedCorners = true;
            this.PInputSP.BorderRadius = 17;
            this.PInputSP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PInputSP.DefaultText = "";
            this.PInputSP.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PInputSP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PInputSP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PInputSP.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PInputSP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PInputSP.FillColor = System.Drawing.SystemColors.InactiveBorder;
            this.PInputSP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PInputSP.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PInputSP.ForeColor = System.Drawing.Color.Black;
            this.PInputSP.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PInputSP.Location = new System.Drawing.Point(209, 104);
            this.PInputSP.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.PInputSP.Name = "PInputSP";
            this.PInputSP.PasswordChar = '●';
            this.PInputSP.PlaceholderText = "******";
            this.PInputSP.SelectedText = "";
            this.PInputSP.Size = new System.Drawing.Size(153, 37);
            this.PInputSP.TabIndex = 13;
            this.PInputSP.UseSystemPasswordChar = true;
            // 
            // EInputSP
            // 
            this.EInputSP.AutoRoundedCorners = true;
            this.EInputSP.BorderRadius = 17;
            this.EInputSP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EInputSP.DefaultText = "";
            this.EInputSP.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.EInputSP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.EInputSP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EInputSP.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EInputSP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EInputSP.FillColor = System.Drawing.SystemColors.InactiveBorder;
            this.EInputSP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EInputSP.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EInputSP.ForeColor = System.Drawing.Color.Black;
            this.EInputSP.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EInputSP.Location = new System.Drawing.Point(209, 153);
            this.EInputSP.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.EInputSP.Name = "EInputSP";
            this.EInputSP.PasswordChar = '\0';
            this.EInputSP.PlaceholderText = "aaa@gmail.com";
            this.EInputSP.SelectedText = "";
            this.EInputSP.Size = new System.Drawing.Size(153, 37);
            this.EInputSP.TabIndex = 14;
            // 
            // CInputSP
            // 
            this.CInputSP.AutoRoundedCorners = true;
            this.CInputSP.BorderRadius = 17;
            this.CInputSP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CInputSP.DefaultText = "";
            this.CInputSP.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.CInputSP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.CInputSP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CInputSP.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CInputSP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CInputSP.FillColor = System.Drawing.SystemColors.InactiveBorder;
            this.CInputSP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CInputSP.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CInputSP.ForeColor = System.Drawing.Color.Black;
            this.CInputSP.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CInputSP.Location = new System.Drawing.Point(513, 104);
            this.CInputSP.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.CInputSP.Name = "CInputSP";
            this.CInputSP.PasswordChar = '\0';
            this.CInputSP.PlaceholderText = "";
            this.CInputSP.SelectedText = "";
            this.CInputSP.Size = new System.Drawing.Size(164, 37);
            this.CInputSP.TabIndex = 15;
            // 
            // AInputSP
            // 
            this.AInputSP.AutoRoundedCorners = true;
            this.AInputSP.BorderRadius = 17;
            this.AInputSP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AInputSP.DefaultText = "";
            this.AInputSP.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.AInputSP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.AInputSP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AInputSP.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AInputSP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AInputSP.FillColor = System.Drawing.SystemColors.InactiveBorder;
            this.AInputSP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AInputSP.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AInputSP.ForeColor = System.Drawing.Color.Black;
            this.AInputSP.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AInputSP.Location = new System.Drawing.Point(513, 153);
            this.AInputSP.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.AInputSP.Name = "AInputSP";
            this.AInputSP.PasswordChar = '\0';
            this.AInputSP.PlaceholderText = "";
            this.AInputSP.SelectedText = "";
            this.AInputSP.Size = new System.Drawing.Size(164, 37);
            this.AInputSP.TabIndex = 16;
            // 
            // GInputSP
            // 
            this.GInputSP.AutoRoundedCorners = true;
            this.GInputSP.BackColor = System.Drawing.Color.Transparent;
            this.GInputSP.BorderRadius = 19;
            this.GInputSP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GInputSP.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.GInputSP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GInputSP.FillColor = System.Drawing.SystemColors.InactiveBorder;
            this.GInputSP.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.GInputSP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.GInputSP.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GInputSP.ForeColor = System.Drawing.Color.Black;
            this.GInputSP.ItemHeight = 34;
            this.GInputSP.Items.AddRange(new object[] {
            "Female",
            "Male"});
            this.GInputSP.Location = new System.Drawing.Point(511, 52);
            this.GInputSP.Name = "GInputSP";
            this.GInputSP.Size = new System.Drawing.Size(168, 40);
            this.GInputSP.Sorted = true;
            this.GInputSP.TabIndex = 17;
            // 
            // DOBISP
            // 
            this.DOBISP.AutoRoundedCorners = true;
            this.DOBISP.BorderRadius = 20;
            this.DOBISP.Checked = true;
            this.DOBISP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DOBISP.FillColor = System.Drawing.Color.White;
            this.DOBISP.FocusedColor = System.Drawing.Color.White;
            this.DOBISP.Font = new System.Drawing.Font("Sitka Text", 8F);
            this.DOBISP.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DOBISP.Location = new System.Drawing.Point(511, 3);
            this.DOBISP.MaxDate = new System.DateTime(2024, 4, 21, 1, 42, 13, 873);
            this.DOBISP.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.DOBISP.Name = "DOBISP";
            this.DOBISP.Size = new System.Drawing.Size(168, 43);
            this.DOBISP.TabIndex = 18;
            this.DOBISP.Value = new System.DateTime(2024, 4, 1, 0, 0, 0, 0);
            // 
            // ManageTechnicians
            // 
            this.ManageTechnicians.BackColor = System.Drawing.Color.White;
            this.ManageTechnicians.Controls.Add(this.MainPanelMT);
            this.ManageTechnicians.Location = new System.Drawing.Point(154, 4);
            this.ManageTechnicians.Name = "ManageTechnicians";
            this.ManageTechnicians.Padding = new System.Windows.Forms.Padding(3);
            this.ManageTechnicians.Size = new System.Drawing.Size(776, 591);
            this.ManageTechnicians.TabIndex = 2;
            this.ManageTechnicians.Text = "Manage Technicians";
            // 
            // MainPanelMT
            // 
            this.MainPanelMT.Controls.Add(this.BottomContainerMT);
            this.MainPanelMT.Controls.Add(this.TopContainerMT);
            this.MainPanelMT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanelMT.Location = new System.Drawing.Point(3, 3);
            this.MainPanelMT.Name = "MainPanelMT";
            this.MainPanelMT.Size = new System.Drawing.Size(770, 585);
            this.MainPanelMT.TabIndex = 1;
            // 
            // BottomContainerMT
            // 
            this.BottomContainerMT.Controls.Add(this.TGridView);
            this.BottomContainerMT.Controls.Add(this.ButtonsContainerMT);
            this.BottomContainerMT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BottomContainerMT.Location = new System.Drawing.Point(0, 234);
            this.BottomContainerMT.Name = "BottomContainerMT";
            this.BottomContainerMT.Size = new System.Drawing.Size(770, 351);
            this.BottomContainerMT.TabIndex = 1;
            // 
            // TGridView
            // 
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle20;
            this.TGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.TGridView.ColumnHeadersHeight = 30;
            this.TGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.TGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1MT,
            this.Column2MT,
            this.Column3MT,
            this.Column4MT,
            this.Column5MT,
            this.Column6MT,
            this.Column7MT,
            this.Column8MT,
            this.Column9MT});
            this.TGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TGridView.Location = new System.Drawing.Point(0, 64);
            this.TGridView.Name = "TGridView";
            this.TGridView.ReadOnly = true;
            this.TGridView.RowHeadersWidth = 40;
            this.TGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Sitka Text", 12F);
            this.TGridView.RowsDefaultCellStyle = dataGridViewCellStyle21;
            this.TGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TGridView.RowTemplate.Height = 20;
            this.TGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TGridView.Size = new System.Drawing.Size(770, 287);
            this.TGridView.TabIndex = 2;
            this.TGridView.SelectionChanged += new System.EventHandler(this.TGridView_SelectionChanged);
            // 
            // Column1MT
            // 
            this.Column1MT.HeaderText = "Name";
            this.Column1MT.Name = "Column1MT";
            this.Column1MT.ReadOnly = true;
            // 
            // Column2MT
            // 
            this.Column2MT.HeaderText = "Username";
            this.Column2MT.Name = "Column2MT";
            this.Column2MT.ReadOnly = true;
            // 
            // Column3MT
            // 
            this.Column3MT.HeaderText = "Password";
            this.Column3MT.Name = "Column3MT";
            this.Column3MT.ReadOnly = true;
            // 
            // Column4MT
            // 
            this.Column4MT.HeaderText = "Email";
            this.Column4MT.Name = "Column4MT";
            this.Column4MT.ReadOnly = true;
            // 
            // Column5MT
            // 
            this.Column5MT.HeaderText = "Dob";
            this.Column5MT.Name = "Column5MT";
            this.Column5MT.ReadOnly = true;
            // 
            // Column6MT
            // 
            this.Column6MT.HeaderText = "Contact";
            this.Column6MT.Name = "Column6MT";
            this.Column6MT.ReadOnly = true;
            // 
            // Column7MT
            // 
            this.Column7MT.HeaderText = "Address";
            this.Column7MT.Name = "Column7MT";
            this.Column7MT.ReadOnly = true;
            // 
            // Column8MT
            // 
            this.Column8MT.FillWeight = 80F;
            this.Column8MT.HeaderText = "Gender";
            this.Column8MT.Name = "Column8MT";
            this.Column8MT.ReadOnly = true;
            // 
            // Column9MT
            // 
            this.Column9MT.HeaderText = "HireDate";
            this.Column9MT.Name = "Column9MT";
            this.Column9MT.ReadOnly = true;
            // 
            // ButtonsContainerMT
            // 
            this.ButtonsContainerMT.ColumnCount = 7;
            this.ButtonsContainerMT.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonsContainerMT.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.ButtonsContainerMT.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonsContainerMT.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.ButtonsContainerMT.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonsContainerMT.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.ButtonsContainerMT.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonsContainerMT.Controls.Add(this.DeleteMTBtn, 5, 1);
            this.ButtonsContainerMT.Controls.Add(this.AddMTBtn, 1, 1);
            this.ButtonsContainerMT.Controls.Add(this.UpdateMTBtn, 3, 1);
            this.ButtonsContainerMT.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonsContainerMT.Location = new System.Drawing.Point(0, 0);
            this.ButtonsContainerMT.Name = "ButtonsContainerMT";
            this.ButtonsContainerMT.RowCount = 2;
            this.ButtonsContainerMT.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ButtonsContainerMT.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ButtonsContainerMT.Size = new System.Drawing.Size(770, 64);
            this.ButtonsContainerMT.TabIndex = 1;
            // 
            // DeleteMTBtn
            // 
            this.DeleteMTBtn.AllowAnimations = true;
            this.DeleteMTBtn.AllowMouseEffects = true;
            this.DeleteMTBtn.AllowToggling = false;
            this.DeleteMTBtn.AnimationSpeed = 200;
            this.DeleteMTBtn.AutoGenerateColors = false;
            this.DeleteMTBtn.AutoRoundBorders = false;
            this.DeleteMTBtn.AutoSizeLeftIcon = true;
            this.DeleteMTBtn.AutoSizeRightIcon = true;
            this.DeleteMTBtn.BackColor = System.Drawing.Color.Transparent;
            this.DeleteMTBtn.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(144)))), ((int)(((byte)(231)))));
            this.DeleteMTBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DeleteMTBtn.BackgroundImage")));
            this.DeleteMTBtn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.DeleteMTBtn.ButtonText = "Delete";
            this.DeleteMTBtn.ButtonTextMarginLeft = 0;
            this.DeleteMTBtn.ColorContrastOnClick = 45;
            this.DeleteMTBtn.ColorContrastOnHover = 45;
            this.DeleteMTBtn.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges16.BottomLeft = true;
            borderEdges16.BottomRight = true;
            borderEdges16.TopLeft = true;
            borderEdges16.TopRight = true;
            this.DeleteMTBtn.CustomizableEdges = borderEdges16;
            this.DeleteMTBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.DeleteMTBtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.DeleteMTBtn.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.DeleteMTBtn.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.DeleteMTBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DeleteMTBtn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Idle;
            this.DeleteMTBtn.Font = new System.Drawing.Font("Sitka Display", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteMTBtn.ForeColor = System.Drawing.SystemColors.Info;
            this.DeleteMTBtn.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DeleteMTBtn.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.DeleteMTBtn.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.DeleteMTBtn.IconMarginLeft = 11;
            this.DeleteMTBtn.IconPadding = 10;
            this.DeleteMTBtn.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DeleteMTBtn.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.DeleteMTBtn.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.DeleteMTBtn.IconSize = 25;
            this.DeleteMTBtn.IdleBorderColor = System.Drawing.Color.LightBlue;
            this.DeleteMTBtn.IdleBorderRadius = 50;
            this.DeleteMTBtn.IdleBorderThickness = 2;
            this.DeleteMTBtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(144)))), ((int)(((byte)(231)))));
            this.DeleteMTBtn.IdleIconLeftImage = null;
            this.DeleteMTBtn.IdleIconRightImage = null;
            this.DeleteMTBtn.IndicateFocus = false;
            this.DeleteMTBtn.Location = new System.Drawing.Point(544, 3);
            this.DeleteMTBtn.Name = "DeleteMTBtn";
            this.DeleteMTBtn.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.DeleteMTBtn.OnDisabledState.BorderRadius = 0;
            this.DeleteMTBtn.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.DeleteMTBtn.OnDisabledState.BorderThickness = 2;
            this.DeleteMTBtn.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.DeleteMTBtn.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.DeleteMTBtn.OnDisabledState.IconLeftImage = null;
            this.DeleteMTBtn.OnDisabledState.IconRightImage = null;
            this.DeleteMTBtn.onHoverState.BorderColor = System.Drawing.Color.Black;
            this.DeleteMTBtn.onHoverState.BorderRadius = 0;
            this.DeleteMTBtn.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.DeleteMTBtn.onHoverState.BorderThickness = 2;
            this.DeleteMTBtn.onHoverState.FillColor = System.Drawing.Color.Red;
            this.DeleteMTBtn.onHoverState.ForeColor = System.Drawing.Color.Black;
            this.DeleteMTBtn.onHoverState.IconLeftImage = null;
            this.DeleteMTBtn.onHoverState.IconRightImage = null;
            this.DeleteMTBtn.OnIdleState.BorderColor = System.Drawing.Color.LightBlue;
            this.DeleteMTBtn.OnIdleState.BorderRadius = 0;
            this.DeleteMTBtn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.DeleteMTBtn.OnIdleState.BorderThickness = 2;
            this.DeleteMTBtn.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(144)))), ((int)(((byte)(231)))));
            this.DeleteMTBtn.OnIdleState.ForeColor = System.Drawing.SystemColors.Info;
            this.DeleteMTBtn.OnIdleState.IconLeftImage = null;
            this.DeleteMTBtn.OnIdleState.IconRightImage = null;
            this.DeleteMTBtn.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.DeleteMTBtn.OnPressedState.BorderRadius = 0;
            this.DeleteMTBtn.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.DeleteMTBtn.OnPressedState.BorderThickness = 2;
            this.DeleteMTBtn.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.DeleteMTBtn.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.DeleteMTBtn.OnPressedState.IconLeftImage = null;
            this.DeleteMTBtn.OnPressedState.IconRightImage = null;
            this.DeleteMTBtn.Size = new System.Drawing.Size(134, 59);
            this.DeleteMTBtn.TabIndex = 17;
            this.DeleteMTBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DeleteMTBtn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.DeleteMTBtn.TextMarginLeft = 0;
            this.DeleteMTBtn.TextPadding = new System.Windows.Forms.Padding(0);
            this.DeleteMTBtn.UseDefaultRadiusAndThickness = true;
            this.DeleteMTBtn.Click += new System.EventHandler(this.DeleteMTBtn_Click);
            // 
            // AddMTBtn
            // 
            this.AddMTBtn.AllowAnimations = true;
            this.AddMTBtn.AllowMouseEffects = true;
            this.AddMTBtn.AllowToggling = false;
            this.AddMTBtn.AnimationSpeed = 200;
            this.AddMTBtn.AutoGenerateColors = false;
            this.AddMTBtn.AutoRoundBorders = false;
            this.AddMTBtn.AutoSizeLeftIcon = true;
            this.AddMTBtn.AutoSizeRightIcon = true;
            this.AddMTBtn.BackColor = System.Drawing.Color.Transparent;
            this.AddMTBtn.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(144)))), ((int)(((byte)(231)))));
            this.AddMTBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddMTBtn.BackgroundImage")));
            this.AddMTBtn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.AddMTBtn.ButtonText = "Add";
            this.AddMTBtn.ButtonTextMarginLeft = 0;
            this.AddMTBtn.ColorContrastOnClick = 45;
            this.AddMTBtn.ColorContrastOnHover = 45;
            this.AddMTBtn.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges17.BottomLeft = true;
            borderEdges17.BottomRight = true;
            borderEdges17.TopLeft = true;
            borderEdges17.TopRight = true;
            this.AddMTBtn.CustomizableEdges = borderEdges17;
            this.AddMTBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.AddMTBtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.AddMTBtn.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.AddMTBtn.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.AddMTBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddMTBtn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Idle;
            this.AddMTBtn.Font = new System.Drawing.Font("Sitka Display", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddMTBtn.ForeColor = System.Drawing.SystemColors.Info;
            this.AddMTBtn.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddMTBtn.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.AddMTBtn.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.AddMTBtn.IconMarginLeft = 11;
            this.AddMTBtn.IconPadding = 10;
            this.AddMTBtn.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AddMTBtn.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.AddMTBtn.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.AddMTBtn.IconSize = 25;
            this.AddMTBtn.IdleBorderColor = System.Drawing.Color.LightBlue;
            this.AddMTBtn.IdleBorderRadius = 50;
            this.AddMTBtn.IdleBorderThickness = 2;
            this.AddMTBtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(144)))), ((int)(((byte)(231)))));
            this.AddMTBtn.IdleIconLeftImage = null;
            this.AddMTBtn.IdleIconRightImage = null;
            this.AddMTBtn.IndicateFocus = false;
            this.AddMTBtn.Location = new System.Drawing.Point(90, 3);
            this.AddMTBtn.Name = "AddMTBtn";
            this.AddMTBtn.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.AddMTBtn.OnDisabledState.BorderRadius = 0;
            this.AddMTBtn.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.AddMTBtn.OnDisabledState.BorderThickness = 2;
            this.AddMTBtn.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.AddMTBtn.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.AddMTBtn.OnDisabledState.IconLeftImage = null;
            this.AddMTBtn.OnDisabledState.IconRightImage = null;
            this.AddMTBtn.onHoverState.BorderColor = System.Drawing.Color.Black;
            this.AddMTBtn.onHoverState.BorderRadius = 0;
            this.AddMTBtn.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.AddMTBtn.onHoverState.BorderThickness = 2;
            this.AddMTBtn.onHoverState.FillColor = System.Drawing.Color.Red;
            this.AddMTBtn.onHoverState.ForeColor = System.Drawing.Color.Black;
            this.AddMTBtn.onHoverState.IconLeftImage = null;
            this.AddMTBtn.onHoverState.IconRightImage = null;
            this.AddMTBtn.OnIdleState.BorderColor = System.Drawing.Color.LightBlue;
            this.AddMTBtn.OnIdleState.BorderRadius = 0;
            this.AddMTBtn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.AddMTBtn.OnIdleState.BorderThickness = 2;
            this.AddMTBtn.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(144)))), ((int)(((byte)(231)))));
            this.AddMTBtn.OnIdleState.ForeColor = System.Drawing.SystemColors.Info;
            this.AddMTBtn.OnIdleState.IconLeftImage = null;
            this.AddMTBtn.OnIdleState.IconRightImage = null;
            this.AddMTBtn.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.AddMTBtn.OnPressedState.BorderRadius = 0;
            this.AddMTBtn.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.AddMTBtn.OnPressedState.BorderThickness = 2;
            this.AddMTBtn.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.AddMTBtn.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.AddMTBtn.OnPressedState.IconLeftImage = null;
            this.AddMTBtn.OnPressedState.IconRightImage = null;
            this.AddMTBtn.Size = new System.Drawing.Size(134, 59);
            this.AddMTBtn.TabIndex = 16;
            this.AddMTBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AddMTBtn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.AddMTBtn.TextMarginLeft = 0;
            this.AddMTBtn.TextPadding = new System.Windows.Forms.Padding(0);
            this.AddMTBtn.UseDefaultRadiusAndThickness = true;
            this.AddMTBtn.Click += new System.EventHandler(this.AddMTBtn_Click);
            // 
            // UpdateMTBtn
            // 
            this.UpdateMTBtn.AllowAnimations = true;
            this.UpdateMTBtn.AllowMouseEffects = true;
            this.UpdateMTBtn.AllowToggling = false;
            this.UpdateMTBtn.AnimationSpeed = 200;
            this.UpdateMTBtn.AutoGenerateColors = false;
            this.UpdateMTBtn.AutoRoundBorders = false;
            this.UpdateMTBtn.AutoSizeLeftIcon = true;
            this.UpdateMTBtn.AutoSizeRightIcon = true;
            this.UpdateMTBtn.BackColor = System.Drawing.Color.Transparent;
            this.UpdateMTBtn.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(144)))), ((int)(((byte)(231)))));
            this.UpdateMTBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("UpdateMTBtn.BackgroundImage")));
            this.UpdateMTBtn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.UpdateMTBtn.ButtonText = "Update";
            this.UpdateMTBtn.ButtonTextMarginLeft = 0;
            this.UpdateMTBtn.ColorContrastOnClick = 45;
            this.UpdateMTBtn.ColorContrastOnHover = 45;
            this.UpdateMTBtn.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges18.BottomLeft = true;
            borderEdges18.BottomRight = true;
            borderEdges18.TopLeft = true;
            borderEdges18.TopRight = true;
            this.UpdateMTBtn.CustomizableEdges = borderEdges18;
            this.UpdateMTBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.UpdateMTBtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.UpdateMTBtn.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.UpdateMTBtn.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.UpdateMTBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UpdateMTBtn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Idle;
            this.UpdateMTBtn.Font = new System.Drawing.Font("Sitka Display", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateMTBtn.ForeColor = System.Drawing.SystemColors.Info;
            this.UpdateMTBtn.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UpdateMTBtn.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.UpdateMTBtn.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.UpdateMTBtn.IconMarginLeft = 11;
            this.UpdateMTBtn.IconPadding = 10;
            this.UpdateMTBtn.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.UpdateMTBtn.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.UpdateMTBtn.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.UpdateMTBtn.IconSize = 25;
            this.UpdateMTBtn.IdleBorderColor = System.Drawing.Color.LightBlue;
            this.UpdateMTBtn.IdleBorderRadius = 50;
            this.UpdateMTBtn.IdleBorderThickness = 2;
            this.UpdateMTBtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(144)))), ((int)(((byte)(231)))));
            this.UpdateMTBtn.IdleIconLeftImage = null;
            this.UpdateMTBtn.IdleIconRightImage = null;
            this.UpdateMTBtn.IndicateFocus = false;
            this.UpdateMTBtn.Location = new System.Drawing.Point(317, 3);
            this.UpdateMTBtn.Name = "UpdateMTBtn";
            this.UpdateMTBtn.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.UpdateMTBtn.OnDisabledState.BorderRadius = 0;
            this.UpdateMTBtn.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.UpdateMTBtn.OnDisabledState.BorderThickness = 2;
            this.UpdateMTBtn.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.UpdateMTBtn.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.UpdateMTBtn.OnDisabledState.IconLeftImage = null;
            this.UpdateMTBtn.OnDisabledState.IconRightImage = null;
            this.UpdateMTBtn.onHoverState.BorderColor = System.Drawing.Color.Black;
            this.UpdateMTBtn.onHoverState.BorderRadius = 0;
            this.UpdateMTBtn.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.UpdateMTBtn.onHoverState.BorderThickness = 2;
            this.UpdateMTBtn.onHoverState.FillColor = System.Drawing.Color.Red;
            this.UpdateMTBtn.onHoverState.ForeColor = System.Drawing.Color.Black;
            this.UpdateMTBtn.onHoverState.IconLeftImage = null;
            this.UpdateMTBtn.onHoverState.IconRightImage = null;
            this.UpdateMTBtn.OnIdleState.BorderColor = System.Drawing.Color.LightBlue;
            this.UpdateMTBtn.OnIdleState.BorderRadius = 0;
            this.UpdateMTBtn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.UpdateMTBtn.OnIdleState.BorderThickness = 2;
            this.UpdateMTBtn.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(144)))), ((int)(((byte)(231)))));
            this.UpdateMTBtn.OnIdleState.ForeColor = System.Drawing.SystemColors.Info;
            this.UpdateMTBtn.OnIdleState.IconLeftImage = null;
            this.UpdateMTBtn.OnIdleState.IconRightImage = null;
            this.UpdateMTBtn.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.UpdateMTBtn.OnPressedState.BorderRadius = 0;
            this.UpdateMTBtn.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.UpdateMTBtn.OnPressedState.BorderThickness = 2;
            this.UpdateMTBtn.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.UpdateMTBtn.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.UpdateMTBtn.OnPressedState.IconLeftImage = null;
            this.UpdateMTBtn.OnPressedState.IconRightImage = null;
            this.UpdateMTBtn.Size = new System.Drawing.Size(134, 59);
            this.UpdateMTBtn.TabIndex = 18;
            this.UpdateMTBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.UpdateMTBtn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.UpdateMTBtn.TextMarginLeft = 0;
            this.UpdateMTBtn.TextPadding = new System.Windows.Forms.Padding(0);
            this.UpdateMTBtn.UseDefaultRadiusAndThickness = true;
            // 
            // TopContainerMT
            // 
            this.TopContainerMT.Controls.Add(this.MTLabel);
            this.TopContainerMT.Controls.Add(this.InputsMT);
            this.TopContainerMT.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopContainerMT.Location = new System.Drawing.Point(0, 0);
            this.TopContainerMT.Name = "TopContainerMT";
            this.TopContainerMT.Size = new System.Drawing.Size(770, 234);
            this.TopContainerMT.TabIndex = 0;
            // 
            // MTLabel
            // 
            this.MTLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MTLabel.Font = new System.Drawing.Font("Sitka Display", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MTLabel.Location = new System.Drawing.Point(0, 0);
            this.MTLabel.Name = "MTLabel";
            this.MTLabel.Size = new System.Drawing.Size(770, 39);
            this.MTLabel.TabIndex = 4;
            this.MTLabel.Text = "Manage Technicians";
            this.MTLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InputsMT
            // 
            this.InputsMT.BackColor = System.Drawing.Color.GhostWhite;
            this.InputsMT.ColumnCount = 7;
            this.InputsMT.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.46055F));
            this.InputsMT.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.20111F));
            this.InputsMT.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.295F));
            this.InputsMT.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.302407F));
            this.InputsMT.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.11686F));
            this.InputsMT.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.64033F));
            this.InputsMT.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.98374F));
            this.InputsMT.Controls.Add(this.ContactMT, 4, 2);
            this.InputsMT.Controls.Add(this.DOBMT, 4, 0);
            this.InputsMT.Controls.Add(this.AddressMT, 4, 3);
            this.InputsMT.Controls.Add(this.GenderMT, 4, 1);
            this.InputsMT.Controls.Add(this.UsernameMT, 1, 1);
            this.InputsMT.Controls.Add(this.PasswordMT, 1, 2);
            this.InputsMT.Controls.Add(this.NameMT, 1, 0);
            this.InputsMT.Controls.Add(this.EmailMT, 1, 3);
            this.InputsMT.Controls.Add(this.NInputMT, 2, 0);
            this.InputsMT.Controls.Add(this.UInputMT, 2, 1);
            this.InputsMT.Controls.Add(this.PInputMT, 2, 2);
            this.InputsMT.Controls.Add(this.EInputMT, 2, 3);
            this.InputsMT.Controls.Add(this.CInputMT, 5, 2);
            this.InputsMT.Controls.Add(this.AInputMT, 5, 3);
            this.InputsMT.Controls.Add(this.GInputMT, 5, 1);
            this.InputsMT.Controls.Add(this.DOBIMT, 5, 0);
            this.InputsMT.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.InputsMT.ForeColor = System.Drawing.Color.Black;
            this.InputsMT.Location = new System.Drawing.Point(0, 39);
            this.InputsMT.Name = "InputsMT";
            this.InputsMT.RowCount = 4;
            this.InputsMT.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.InputsMT.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.InputsMT.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.InputsMT.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.InputsMT.Size = new System.Drawing.Size(770, 195);
            this.InputsMT.TabIndex = 3;
            // 
            // ContactMT
            // 
            this.ContactMT.AutoSize = true;
            this.ContactMT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContactMT.Font = new System.Drawing.Font("Sitka Heading", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContactMT.Location = new System.Drawing.Point(387, 98);
            this.ContactMT.Name = "ContactMT";
            this.ContactMT.Size = new System.Drawing.Size(118, 49);
            this.ContactMT.TabIndex = 3;
            this.ContactMT.Text = "Contact";
            this.ContactMT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DOBMT
            // 
            this.DOBMT.AutoSize = true;
            this.DOBMT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DOBMT.Font = new System.Drawing.Font("Sitka Heading", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DOBMT.Location = new System.Drawing.Point(387, 0);
            this.DOBMT.Name = "DOBMT";
            this.DOBMT.Size = new System.Drawing.Size(118, 49);
            this.DOBMT.TabIndex = 10;
            this.DOBMT.Text = "DOB";
            this.DOBMT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddressMT
            // 
            this.AddressMT.AutoSize = true;
            this.AddressMT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddressMT.Font = new System.Drawing.Font("Sitka Heading", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressMT.Location = new System.Drawing.Point(387, 147);
            this.AddressMT.Name = "AddressMT";
            this.AddressMT.Size = new System.Drawing.Size(118, 49);
            this.AddressMT.TabIndex = 5;
            this.AddressMT.Text = "Address";
            this.AddressMT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GenderMT
            // 
            this.GenderMT.AutoSize = true;
            this.GenderMT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GenderMT.Font = new System.Drawing.Font("Sitka Heading", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenderMT.Location = new System.Drawing.Point(387, 49);
            this.GenderMT.Name = "GenderMT";
            this.GenderMT.Size = new System.Drawing.Size(118, 49);
            this.GenderMT.TabIndex = 9;
            this.GenderMT.Text = "Gender";
            this.GenderMT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UsernameMT
            // 
            this.UsernameMT.AutoSize = true;
            this.UsernameMT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UsernameMT.Font = new System.Drawing.Font("Sitka Heading", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameMT.Location = new System.Drawing.Point(83, 49);
            this.UsernameMT.Name = "UsernameMT";
            this.UsernameMT.Size = new System.Drawing.Size(118, 49);
            this.UsernameMT.TabIndex = 6;
            this.UsernameMT.Text = "Username";
            this.UsernameMT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PasswordMT
            // 
            this.PasswordMT.AutoSize = true;
            this.PasswordMT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PasswordMT.Font = new System.Drawing.Font("Sitka Heading", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordMT.Location = new System.Drawing.Point(83, 98);
            this.PasswordMT.Name = "PasswordMT";
            this.PasswordMT.Size = new System.Drawing.Size(118, 49);
            this.PasswordMT.TabIndex = 7;
            this.PasswordMT.Text = "Password";
            this.PasswordMT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NameMT
            // 
            this.NameMT.AutoSize = true;
            this.NameMT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NameMT.Font = new System.Drawing.Font("Sitka Heading", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameMT.Location = new System.Drawing.Point(83, 0);
            this.NameMT.Name = "NameMT";
            this.NameMT.Size = new System.Drawing.Size(118, 49);
            this.NameMT.TabIndex = 4;
            this.NameMT.Text = "Name";
            this.NameMT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EmailMT
            // 
            this.EmailMT.AutoSize = true;
            this.EmailMT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EmailMT.Font = new System.Drawing.Font("Sitka Heading", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailMT.Location = new System.Drawing.Point(83, 147);
            this.EmailMT.Name = "EmailMT";
            this.EmailMT.Size = new System.Drawing.Size(118, 49);
            this.EmailMT.TabIndex = 8;
            this.EmailMT.Text = "Email";
            this.EmailMT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NInputMT
            // 
            this.NInputMT.AutoRoundedCorners = true;
            this.NInputMT.BorderRadius = 17;
            this.NInputMT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NInputMT.DefaultText = "";
            this.NInputMT.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.NInputMT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.NInputMT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NInputMT.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NInputMT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NInputMT.FillColor = System.Drawing.SystemColors.InactiveBorder;
            this.NInputMT.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NInputMT.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NInputMT.ForeColor = System.Drawing.Color.Black;
            this.NInputMT.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NInputMT.Location = new System.Drawing.Point(209, 6);
            this.NInputMT.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.NInputMT.Name = "NInputMT";
            this.NInputMT.PasswordChar = '\0';
            this.NInputMT.PlaceholderText = "Enter name";
            this.NInputMT.SelectedText = "";
            this.NInputMT.Size = new System.Drawing.Size(153, 37);
            this.NInputMT.TabIndex = 11;
            // 
            // UInputMT
            // 
            this.UInputMT.AutoRoundedCorners = true;
            this.UInputMT.BorderRadius = 17;
            this.UInputMT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UInputMT.DefaultText = "";
            this.UInputMT.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.UInputMT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.UInputMT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UInputMT.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UInputMT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UInputMT.FillColor = System.Drawing.SystemColors.InactiveBorder;
            this.UInputMT.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UInputMT.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UInputMT.ForeColor = System.Drawing.Color.Black;
            this.UInputMT.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UInputMT.Location = new System.Drawing.Point(209, 55);
            this.UInputMT.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.UInputMT.Name = "UInputMT";
            this.UInputMT.PasswordChar = '\0';
            this.UInputMT.PlaceholderText = "John123 etc.";
            this.UInputMT.SelectedText = "";
            this.UInputMT.Size = new System.Drawing.Size(153, 37);
            this.UInputMT.TabIndex = 12;
            // 
            // PInputMT
            // 
            this.PInputMT.AutoRoundedCorners = true;
            this.PInputMT.BorderRadius = 17;
            this.PInputMT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PInputMT.DefaultText = "";
            this.PInputMT.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PInputMT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PInputMT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PInputMT.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PInputMT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PInputMT.FillColor = System.Drawing.SystemColors.InactiveBorder;
            this.PInputMT.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PInputMT.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PInputMT.ForeColor = System.Drawing.Color.Black;
            this.PInputMT.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PInputMT.Location = new System.Drawing.Point(209, 104);
            this.PInputMT.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.PInputMT.Name = "PInputMT";
            this.PInputMT.PasswordChar = '●';
            this.PInputMT.PlaceholderText = "******";
            this.PInputMT.SelectedText = "";
            this.PInputMT.Size = new System.Drawing.Size(153, 37);
            this.PInputMT.TabIndex = 13;
            this.PInputMT.UseSystemPasswordChar = true;
            // 
            // EInputMT
            // 
            this.EInputMT.AutoRoundedCorners = true;
            this.EInputMT.BorderRadius = 17;
            this.EInputMT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EInputMT.DefaultText = "";
            this.EInputMT.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.EInputMT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.EInputMT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EInputMT.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EInputMT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EInputMT.FillColor = System.Drawing.SystemColors.InactiveBorder;
            this.EInputMT.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EInputMT.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EInputMT.ForeColor = System.Drawing.Color.Black;
            this.EInputMT.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EInputMT.Location = new System.Drawing.Point(209, 153);
            this.EInputMT.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.EInputMT.Name = "EInputMT";
            this.EInputMT.PasswordChar = '\0';
            this.EInputMT.PlaceholderText = "aaa@gmail.com";
            this.EInputMT.SelectedText = "";
            this.EInputMT.Size = new System.Drawing.Size(153, 37);
            this.EInputMT.TabIndex = 14;
            // 
            // CInputMT
            // 
            this.CInputMT.AutoRoundedCorners = true;
            this.CInputMT.BorderRadius = 17;
            this.CInputMT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CInputMT.DefaultText = "";
            this.CInputMT.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.CInputMT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.CInputMT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CInputMT.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CInputMT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CInputMT.FillColor = System.Drawing.SystemColors.InactiveBorder;
            this.CInputMT.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CInputMT.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CInputMT.ForeColor = System.Drawing.Color.Black;
            this.CInputMT.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CInputMT.Location = new System.Drawing.Point(513, 104);
            this.CInputMT.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.CInputMT.Name = "CInputMT";
            this.CInputMT.PasswordChar = '\0';
            this.CInputMT.PlaceholderText = "";
            this.CInputMT.SelectedText = "";
            this.CInputMT.Size = new System.Drawing.Size(164, 37);
            this.CInputMT.TabIndex = 15;
            // 
            // AInputMT
            // 
            this.AInputMT.AutoRoundedCorners = true;
            this.AInputMT.BorderRadius = 17;
            this.AInputMT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AInputMT.DefaultText = "";
            this.AInputMT.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.AInputMT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.AInputMT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AInputMT.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AInputMT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AInputMT.FillColor = System.Drawing.SystemColors.InactiveBorder;
            this.AInputMT.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AInputMT.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AInputMT.ForeColor = System.Drawing.Color.Black;
            this.AInputMT.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AInputMT.Location = new System.Drawing.Point(513, 153);
            this.AInputMT.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.AInputMT.Name = "AInputMT";
            this.AInputMT.PasswordChar = '\0';
            this.AInputMT.PlaceholderText = "";
            this.AInputMT.SelectedText = "";
            this.AInputMT.Size = new System.Drawing.Size(164, 37);
            this.AInputMT.TabIndex = 16;
            // 
            // GInputMT
            // 
            this.GInputMT.AutoRoundedCorners = true;
            this.GInputMT.BackColor = System.Drawing.Color.Transparent;
            this.GInputMT.BorderRadius = 19;
            this.GInputMT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GInputMT.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.GInputMT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GInputMT.FillColor = System.Drawing.SystemColors.InactiveBorder;
            this.GInputMT.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.GInputMT.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.GInputMT.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GInputMT.ForeColor = System.Drawing.Color.Black;
            this.GInputMT.ItemHeight = 34;
            this.GInputMT.Items.AddRange(new object[] {
            "Female",
            "Male"});
            this.GInputMT.Location = new System.Drawing.Point(511, 52);
            this.GInputMT.Name = "GInputMT";
            this.GInputMT.Size = new System.Drawing.Size(168, 40);
            this.GInputMT.Sorted = true;
            this.GInputMT.TabIndex = 17;
            // 
            // DOBIMT
            // 
            this.DOBIMT.AutoRoundedCorners = true;
            this.DOBIMT.BorderRadius = 20;
            this.DOBIMT.Checked = true;
            this.DOBIMT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DOBIMT.FillColor = System.Drawing.Color.White;
            this.DOBIMT.FocusedColor = System.Drawing.Color.White;
            this.DOBIMT.Font = new System.Drawing.Font("Sitka Text", 8F);
            this.DOBIMT.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DOBIMT.Location = new System.Drawing.Point(511, 3);
            this.DOBIMT.MaxDate = new System.DateTime(2024, 4, 21, 1, 42, 13, 873);
            this.DOBIMT.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.DOBIMT.Name = "DOBIMT";
            this.DOBIMT.Size = new System.Drawing.Size(168, 43);
            this.DOBIMT.TabIndex = 18;
            this.DOBIMT.Value = new System.DateTime(2024, 4, 1, 0, 0, 0, 0);
            // 
            // CEOTopContainer
            // 
            this.CEOTopContainer.Controls.Add(this.Logo2);
            this.CEOTopContainer.Controls.Add(this.Logo);
            this.CEOTopContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.CEOTopContainer.Location = new System.Drawing.Point(0, 0);
            this.CEOTopContainer.Name = "CEOTopContainer";
            this.CEOTopContainer.Size = new System.Drawing.Size(934, 150);
            this.CEOTopContainer.TabIndex = 0;
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
            this.ClientSize = new System.Drawing.Size(934, 749);
            this.Controls.Add(this.CEOMainPanel);
            this.MinimumSize = new System.Drawing.Size(950, 726);
            this.Name = "CeoUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CeoUI";
            this.CEOMainPanel.ResumeLayout(false);
            this.CEOTabControl.ResumeLayout(false);
            this.Dashboard.ResumeLayout(false);
            this.MainPanelDB.ResumeLayout(false);
            this.DashboardInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Pic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic4)).EndInit();
            this.ManageSalesPersons.ResumeLayout(false);
            this.MainPanelMSP.ResumeLayout(false);
            this.BottomContainerMSP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SPGridView)).EndInit();
            this.ButtonsContainerMSP.ResumeLayout(false);
            this.TopContainerMSP.ResumeLayout(false);
            this.InputsSP.ResumeLayout(false);
            this.InputsSP.PerformLayout();
            this.ManageTechnicians.ResumeLayout(false);
            this.MainPanelMT.ResumeLayout(false);
            this.BottomContainerMT.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TGridView)).EndInit();
            this.ButtonsContainerMT.ResumeLayout(false);
            this.TopContainerMT.ResumeLayout(false);
            this.InputsMT.ResumeLayout(false);
            this.InputsMT.PerformLayout();
            this.CEOTopContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaPanel CEOMainPanel;
        private Guna.UI2.WinForms.Guna2Panel CEOTopContainer;
        private System.Windows.Forms.Label Logo2;
        private System.Windows.Forms.Label Logo;
        private Guna.UI2.WinForms.Guna2TabControl CEOTabControl;
        private TabPage Dashboard;
        private TabPage ManageSalesPersons;
        private Guna.UI.WinForms.GunaPanel MainPanelDB;
        private TableLayoutPanel DashboardInfo;
        private Guna.UI2.WinForms.Guna2PictureBox Pic1;
        private Guna.UI2.WinForms.Guna2PictureBox Pic2;
        private Guna.UI2.WinForms.Guna2PictureBox Pic3;
        private Guna.UI2.WinForms.Guna2PictureBox Pic4;
        private Label DataShow1;
        private Label DataShow2;
        private Label DataShow3;
        private Label DataShow4;
        private Guna.UI.WinForms.GunaPanel MainPanelMSP;
        private Guna.UI.WinForms.GunaPanel TopContainerMSP;
        private TableLayoutPanel InputsSP;
        private Guna.UI.WinForms.GunaLabel ContactSP;
        private Guna.UI.WinForms.GunaLabel DOBSP;
        private Guna.UI.WinForms.GunaLabel AddressSP;
        private Guna.UI.WinForms.GunaLabel GenderSP;
        private Guna.UI.WinForms.GunaLabel UsernameSP;
        private Guna.UI.WinForms.GunaLabel PasswordSP;
        private Guna.UI.WinForms.GunaLabel INameSP;
        private Guna.UI.WinForms.GunaLabel EmailSP;
        private Guna.UI2.WinForms.Guna2TextBox NInputSP;
        private Guna.UI2.WinForms.Guna2TextBox UInputSP;
        private Guna.UI2.WinForms.Guna2TextBox PInputSP;
        private Guna.UI2.WinForms.Guna2TextBox EInputSP;
        private Guna.UI2.WinForms.Guna2TextBox CInputSP;
        private Guna.UI2.WinForms.Guna2TextBox AInputSP;
        private Guna.UI2.WinForms.Guna2ComboBox GInputSP;
        private Guna.UI2.WinForms.Guna2DateTimePicker DOBISP;
        private Guna.UI.WinForms.GunaPanel BottomContainerMSP;
        private TableLayoutPanel ButtonsContainerMSP;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton DeleteSpBtn;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton AddSpbtn;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton UpdateSpBtn;
        private DataGridView SPGridView;
        private Label MSPLabel;
        private TabPage ManageTechnicians;
        private Guna.UI.WinForms.GunaPanel MainPanelMT;
        private Guna.UI.WinForms.GunaPanel BottomContainerMT;
        private DataGridView TGridView;
        private TableLayoutPanel ButtonsContainerMT;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton DeleteMTBtn;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton AddMTBtn;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton UpdateMTBtn;
        private Guna.UI.WinForms.GunaPanel TopContainerMT;
        private Label MTLabel;
        private TableLayoutPanel InputsMT;
        private Guna.UI.WinForms.GunaLabel ContactMT;
        private Guna.UI.WinForms.GunaLabel DOBMT;
        private Guna.UI.WinForms.GunaLabel AddressMT;
        private Guna.UI.WinForms.GunaLabel GenderMT;
        private Guna.UI.WinForms.GunaLabel UsernameMT;
        private Guna.UI.WinForms.GunaLabel PasswordMT;
        private Guna.UI.WinForms.GunaLabel NameMT;
        private Guna.UI.WinForms.GunaLabel EmailMT;
        private Guna.UI2.WinForms.Guna2TextBox NInputMT;
        private Guna.UI2.WinForms.Guna2TextBox UInputMT;
        private Guna.UI2.WinForms.Guna2TextBox PInputMT;
        private Guna.UI2.WinForms.Guna2TextBox EInputMT;
        private Guna.UI2.WinForms.Guna2TextBox CInputMT;
        private Guna.UI2.WinForms.Guna2TextBox AInputMT;
        private Guna.UI2.WinForms.Guna2ComboBox GInputMT;
        private Guna.UI2.WinForms.Guna2DateTimePicker DOBIMT;
        private DataGridViewTextBoxColumn Column1SP;
        private DataGridViewTextBoxColumn Column2SP;
        private DataGridViewTextBoxColumn Column3SP;
        private DataGridViewTextBoxColumn Column4SP;
        private DataGridViewTextBoxColumn Column5SP;
        private DataGridViewTextBoxColumn Column6SP;
        private DataGridViewTextBoxColumn Column7SP;
        private DataGridViewTextBoxColumn Column8SP;
        private DataGridViewTextBoxColumn Column9SP;
        private DataGridViewTextBoxColumn Column1MT;
        private DataGridViewTextBoxColumn Column2MT;
        private DataGridViewTextBoxColumn Column3MT;
        private DataGridViewTextBoxColumn Column4MT;
        private DataGridViewTextBoxColumn Column5MT;
        private DataGridViewTextBoxColumn Column6MT;
        private DataGridViewTextBoxColumn Column7MT;
        private DataGridViewTextBoxColumn Column8MT;
        private DataGridViewTextBoxColumn Column9MT;
    }
}