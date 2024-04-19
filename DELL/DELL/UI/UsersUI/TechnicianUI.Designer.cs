namespace DELL.UI.UsersUI
{
    partial class TechnicianUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TechnicianUI));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.Dashboard = new System.Windows.Forms.TabPage();
            this.Backbtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.TechnicianPanel = new Guna.UI2.WinForms.Guna2TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.MainPanel = new Guna.UI.WinForms.GunaPanel();
            this.BottomContainer = new Guna.UI2.WinForms.Guna2Panel();
            this.TopContainer = new Guna.UI2.WinForms.Guna2Panel();
            this.Logo2 = new System.Windows.Forms.Label();
            this.Logo = new System.Windows.Forms.Label();
            this.Dashboard.SuspendLayout();
            this.TechnicianPanel.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.BottomContainer.SuspendLayout();
            this.TopContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // Dashboard
            // 
            this.Dashboard.BackColor = System.Drawing.Color.GhostWhite;
            this.Dashboard.Controls.Add(this.Backbtn);
            this.Dashboard.Location = new System.Drawing.Point(154, 4);
            this.Dashboard.Name = "Dashboard";
            this.Dashboard.Padding = new System.Windows.Forms.Padding(3);
            this.Dashboard.Size = new System.Drawing.Size(776, 529);
            this.Dashboard.TabIndex = 0;
            this.Dashboard.Text = "Dashboard";
            // 
            // Backbtn
            // 
            this.Backbtn.AllowAnimations = true;
            this.Backbtn.AllowMouseEffects = true;
            this.Backbtn.AllowToggling = false;
            this.Backbtn.AnimationSpeed = 200;
            this.Backbtn.AutoGenerateColors = false;
            this.Backbtn.AutoRoundBorders = false;
            this.Backbtn.AutoSizeLeftIcon = true;
            this.Backbtn.AutoSizeRightIcon = true;
            this.Backbtn.BackColor = System.Drawing.Color.Transparent;
            this.Backbtn.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(144)))), ((int)(((byte)(231)))));
            this.Backbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Backbtn.BackgroundImage")));
            this.Backbtn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Backbtn.ButtonText = "Back";
            this.Backbtn.ButtonTextMarginLeft = 0;
            this.Backbtn.ColorContrastOnClick = 45;
            this.Backbtn.ColorContrastOnHover = 45;
            this.Backbtn.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.Backbtn.CustomizableEdges = borderEdges1;
            this.Backbtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Backbtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.Backbtn.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Backbtn.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.Backbtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Backbtn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Idle;
            this.Backbtn.Font = new System.Drawing.Font("Sitka Display", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Backbtn.ForeColor = System.Drawing.SystemColors.Info;
            this.Backbtn.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Backbtn.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.Backbtn.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.Backbtn.IconMarginLeft = 11;
            this.Backbtn.IconPadding = 10;
            this.Backbtn.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Backbtn.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.Backbtn.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.Backbtn.IconSize = 25;
            this.Backbtn.IdleBorderColor = System.Drawing.Color.LightBlue;
            this.Backbtn.IdleBorderRadius = 50;
            this.Backbtn.IdleBorderThickness = 2;
            this.Backbtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(144)))), ((int)(((byte)(231)))));
            this.Backbtn.IdleIconLeftImage = null;
            this.Backbtn.IdleIconRightImage = null;
            this.Backbtn.IndicateFocus = false;
            this.Backbtn.Location = new System.Drawing.Point(3, 3);
            this.Backbtn.Name = "Backbtn";
            this.Backbtn.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.Backbtn.OnDisabledState.BorderRadius = 50;
            this.Backbtn.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Backbtn.OnDisabledState.BorderThickness = 2;
            this.Backbtn.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Backbtn.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.Backbtn.OnDisabledState.IconLeftImage = null;
            this.Backbtn.OnDisabledState.IconRightImage = null;
            this.Backbtn.onHoverState.BorderColor = System.Drawing.Color.Black;
            this.Backbtn.onHoverState.BorderRadius = 50;
            this.Backbtn.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Backbtn.onHoverState.BorderThickness = 2;
            this.Backbtn.onHoverState.FillColor = System.Drawing.Color.Red;
            this.Backbtn.onHoverState.ForeColor = System.Drawing.Color.Black;
            this.Backbtn.onHoverState.IconLeftImage = null;
            this.Backbtn.onHoverState.IconRightImage = null;
            this.Backbtn.OnIdleState.BorderColor = System.Drawing.Color.LightBlue;
            this.Backbtn.OnIdleState.BorderRadius = 50;
            this.Backbtn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Backbtn.OnIdleState.BorderThickness = 2;
            this.Backbtn.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(144)))), ((int)(((byte)(231)))));
            this.Backbtn.OnIdleState.ForeColor = System.Drawing.SystemColors.Info;
            this.Backbtn.OnIdleState.IconLeftImage = null;
            this.Backbtn.OnIdleState.IconRightImage = null;
            this.Backbtn.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.Backbtn.OnPressedState.BorderRadius = 50;
            this.Backbtn.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Backbtn.OnPressedState.BorderThickness = 2;
            this.Backbtn.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.Backbtn.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.Backbtn.OnPressedState.IconLeftImage = null;
            this.Backbtn.OnPressedState.IconRightImage = null;
            this.Backbtn.Size = new System.Drawing.Size(770, 523);
            this.Backbtn.TabIndex = 16;
            this.Backbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Backbtn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Backbtn.TextMarginLeft = 0;
            this.Backbtn.TextPadding = new System.Windows.Forms.Padding(0);
            this.Backbtn.UseDefaultRadiusAndThickness = true;
            this.Backbtn.Click += new System.EventHandler(this.Backbtn_Click);
            // 
            // TechnicianPanel
            // 
            this.TechnicianPanel.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.TechnicianPanel.Controls.Add(this.Dashboard);
            this.TechnicianPanel.Controls.Add(this.tabPage2);
            this.TechnicianPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TechnicianPanel.Font = new System.Drawing.Font("Sitka Display", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TechnicianPanel.ItemSize = new System.Drawing.Size(150, 40);
            this.TechnicianPanel.Location = new System.Drawing.Point(0, 0);
            this.TechnicianPanel.Name = "TechnicianPanel";
            this.TechnicianPanel.SelectedIndex = 0;
            this.TechnicianPanel.Size = new System.Drawing.Size(934, 537);
            this.TechnicianPanel.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.TechnicianPanel.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.TechnicianPanel.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.TechnicianPanel.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.TechnicianPanel.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.TechnicianPanel.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.TechnicianPanel.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.TechnicianPanel.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.TechnicianPanel.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.TechnicianPanel.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.TechnicianPanel.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.TechnicianPanel.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.TechnicianPanel.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.TechnicianPanel.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.TechnicianPanel.TabButtonSelectedState.InnerColor = System.Drawing.Color.Lime;
            this.TechnicianPanel.TabButtonSize = new System.Drawing.Size(150, 40);
            this.TechnicianPanel.TabIndex = 0;
            this.TechnicianPanel.TabMenuBackColor = System.Drawing.Color.Lavender;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.GhostWhite;
            this.tabPage2.Font = new System.Drawing.Font("Sitka Display", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(154, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(776, 591);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.BottomContainer);
            this.MainPanel.Controls.Add(this.TopContainer);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(934, 687);
            this.MainPanel.TabIndex = 3;
            // 
            // BottomContainer
            // 
            this.BottomContainer.Controls.Add(this.TechnicianPanel);
            this.BottomContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BottomContainer.Location = new System.Drawing.Point(0, 150);
            this.BottomContainer.Name = "BottomContainer";
            this.BottomContainer.Size = new System.Drawing.Size(934, 537);
            this.BottomContainer.TabIndex = 1;
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
            // TechnicianUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(934, 687);
            this.Controls.Add(this.MainPanel);
            this.MinimumSize = new System.Drawing.Size(950, 700);
            this.Name = "TechnicianUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TechnicianUI";
            this.Dashboard.ResumeLayout(false);
            this.TechnicianPanel.ResumeLayout(false);
            this.MainPanel.ResumeLayout(false);
            this.BottomContainer.ResumeLayout(false);
            this.TopContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage Dashboard;
        private Guna.UI2.WinForms.Guna2TabControl TechnicianPanel;
        private System.Windows.Forms.TabPage tabPage2;
        private Guna.UI.WinForms.GunaPanel MainPanel;
        private Guna.UI2.WinForms.Guna2Panel BottomContainer;
        private Guna.UI2.WinForms.Guna2Panel TopContainer;
        private System.Windows.Forms.Label Logo2;
        private System.Windows.Forms.Label Logo;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton Backbtn;
    }
}