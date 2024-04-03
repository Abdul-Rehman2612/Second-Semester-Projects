namespace DELL
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.Logo = new System.Windows.Forms.Label();
            this.TopContainer = new Guna.UI2.WinForms.Guna2Panel();
            this.BottomContainer = new Guna.UI2.WinForms.Guna2Panel();
            this.Inputs = new System.Windows.Forms.TableLayoutPanel();
            this.SignInbtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.SignUpbtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.Exitbtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.MainPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.TopContainer.SuspendLayout();
            this.BottomContainer.SuspendLayout();
            this.Inputs.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Logo
            // 
            this.Logo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Logo.Font = new System.Drawing.Font("Sitka Heading", 72F, System.Drawing.FontStyle.Bold);
            this.Logo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(144)))), ((int)(((byte)(231)))));
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(0, 0);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(784, 150);
            this.Logo.TabIndex = 1;
            this.Logo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TopContainer
            // 
            this.TopContainer.BackColor = System.Drawing.Color.Transparent;
            this.TopContainer.Controls.Add(this.Logo);
            this.TopContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopContainer.Location = new System.Drawing.Point(0, 0);
            this.TopContainer.Name = "TopContainer";
            this.TopContainer.Size = new System.Drawing.Size(784, 150);
            this.TopContainer.TabIndex = 0;
            // 
            // BottomContainer
            // 
            this.BottomContainer.Controls.Add(this.Inputs);
            this.BottomContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BottomContainer.Location = new System.Drawing.Point(0, 150);
            this.BottomContainer.Name = "BottomContainer";
            this.BottomContainer.Size = new System.Drawing.Size(784, 411);
            this.BottomContainer.TabIndex = 1;
            // 
            // Inputs
            // 
            this.Inputs.BackColor = System.Drawing.Color.GhostWhite;
            this.Inputs.ColumnCount = 5;
            this.Inputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.56357F));
            this.Inputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.56357F));
            this.Inputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.74572F));
            this.Inputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.56357F));
            this.Inputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.56357F));
            this.Inputs.Controls.Add(this.SignInbtn, 2, 1);
            this.Inputs.Controls.Add(this.SignUpbtn, 2, 3);
            this.Inputs.Controls.Add(this.Exitbtn, 2, 5);
            this.Inputs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Inputs.ForeColor = System.Drawing.Color.Black;
            this.Inputs.Location = new System.Drawing.Point(0, 0);
            this.Inputs.Name = "Inputs";
            this.Inputs.RowCount = 7;
            this.Inputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.51524F));
            this.Inputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.06875F));
            this.Inputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.899665F));
            this.Inputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.06875F));
            this.Inputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.899665F));
            this.Inputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.06875F));
            this.Inputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.47917F));
            this.Inputs.Size = new System.Drawing.Size(784, 411);
            this.Inputs.TabIndex = 0;
            // 
            // SignInbtn
            // 
            this.SignInbtn.AllowAnimations = true;
            this.SignInbtn.AllowMouseEffects = true;
            this.SignInbtn.AllowToggling = false;
            this.SignInbtn.AnimationSpeed = 200;
            this.SignInbtn.AutoGenerateColors = false;
            this.SignInbtn.AutoRoundBorders = false;
            this.SignInbtn.AutoSizeLeftIcon = true;
            this.SignInbtn.AutoSizeRightIcon = true;
            this.SignInbtn.BackColor = System.Drawing.Color.Transparent;
            this.SignInbtn.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(144)))), ((int)(((byte)(231)))));
            this.SignInbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SignInbtn.BackgroundImage")));
            this.SignInbtn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.SignInbtn.ButtonText = "Sign In";
            this.SignInbtn.ButtonTextMarginLeft = 0;
            this.SignInbtn.ColorContrastOnClick = 45;
            this.SignInbtn.ColorContrastOnHover = 45;
            this.SignInbtn.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.SignInbtn.CustomizableEdges = borderEdges1;
            this.SignInbtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.SignInbtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.SignInbtn.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.SignInbtn.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.SignInbtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SignInbtn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Idle;
            this.SignInbtn.Font = new System.Drawing.Font("Sitka Display", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignInbtn.ForeColor = System.Drawing.SystemColors.Info;
            this.SignInbtn.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SignInbtn.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.SignInbtn.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.SignInbtn.IconMarginLeft = 11;
            this.SignInbtn.IconPadding = 10;
            this.SignInbtn.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SignInbtn.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.SignInbtn.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.SignInbtn.IconSize = 25;
            this.SignInbtn.IdleBorderColor = System.Drawing.Color.LightBlue;
            this.SignInbtn.IdleBorderRadius = 50;
            this.SignInbtn.IdleBorderThickness = 2;
            this.SignInbtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(144)))), ((int)(((byte)(231)))));
            this.SignInbtn.IdleIconLeftImage = null;
            this.SignInbtn.IdleIconRightImage = null;
            this.SignInbtn.IndicateFocus = false;
            this.SignInbtn.Location = new System.Drawing.Point(293, 70);
            this.SignInbtn.Name = "SignInbtn";
            this.SignInbtn.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.SignInbtn.OnDisabledState.BorderRadius = 50;
            this.SignInbtn.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.SignInbtn.OnDisabledState.BorderThickness = 2;
            this.SignInbtn.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.SignInbtn.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.SignInbtn.OnDisabledState.IconLeftImage = null;
            this.SignInbtn.OnDisabledState.IconRightImage = null;
            this.SignInbtn.onHoverState.BorderColor = System.Drawing.Color.DarkBlue;
            this.SignInbtn.onHoverState.BorderRadius = 50;
            this.SignInbtn.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.SignInbtn.onHoverState.BorderThickness = 2;
            this.SignInbtn.onHoverState.FillColor = System.Drawing.Color.Blue;
            this.SignInbtn.onHoverState.ForeColor = System.Drawing.Color.Cyan;
            this.SignInbtn.onHoverState.IconLeftImage = null;
            this.SignInbtn.onHoverState.IconRightImage = null;
            this.SignInbtn.OnIdleState.BorderColor = System.Drawing.Color.LightBlue;
            this.SignInbtn.OnIdleState.BorderRadius = 50;
            this.SignInbtn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.SignInbtn.OnIdleState.BorderThickness = 2;
            this.SignInbtn.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(144)))), ((int)(((byte)(231)))));
            this.SignInbtn.OnIdleState.ForeColor = System.Drawing.SystemColors.Info;
            this.SignInbtn.OnIdleState.IconLeftImage = null;
            this.SignInbtn.OnIdleState.IconRightImage = null;
            this.SignInbtn.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.SignInbtn.OnPressedState.BorderRadius = 50;
            this.SignInbtn.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.SignInbtn.OnPressedState.BorderThickness = 2;
            this.SignInbtn.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.SignInbtn.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.SignInbtn.OnPressedState.IconLeftImage = null;
            this.SignInbtn.OnPressedState.IconRightImage = null;
            this.SignInbtn.Size = new System.Drawing.Size(195, 60);
            this.SignInbtn.TabIndex = 5;
            this.SignInbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SignInbtn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.SignInbtn.TextMarginLeft = 0;
            this.SignInbtn.TextPadding = new System.Windows.Forms.Padding(0);
            this.SignInbtn.UseDefaultRadiusAndThickness = true;
            this.SignInbtn.Click += new System.EventHandler(this.SignInbtn_Click);
            // 
            // SignUpbtn
            // 
            this.SignUpbtn.AllowAnimations = true;
            this.SignUpbtn.AllowMouseEffects = true;
            this.SignUpbtn.AllowToggling = false;
            this.SignUpbtn.AnimationSpeed = 200;
            this.SignUpbtn.AutoGenerateColors = false;
            this.SignUpbtn.AutoRoundBorders = false;
            this.SignUpbtn.AutoSizeLeftIcon = true;
            this.SignUpbtn.AutoSizeRightIcon = true;
            this.SignUpbtn.BackColor = System.Drawing.Color.Transparent;
            this.SignUpbtn.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(144)))), ((int)(((byte)(231)))));
            this.SignUpbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SignUpbtn.BackgroundImage")));
            this.SignUpbtn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.SignUpbtn.ButtonText = "Sign Up";
            this.SignUpbtn.ButtonTextMarginLeft = 0;
            this.SignUpbtn.ColorContrastOnClick = 45;
            this.SignUpbtn.ColorContrastOnHover = 45;
            this.SignUpbtn.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.SignUpbtn.CustomizableEdges = borderEdges2;
            this.SignUpbtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.SignUpbtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.SignUpbtn.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.SignUpbtn.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.SignUpbtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SignUpbtn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Idle;
            this.SignUpbtn.Font = new System.Drawing.Font("Sitka Display", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpbtn.ForeColor = System.Drawing.SystemColors.Info;
            this.SignUpbtn.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SignUpbtn.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.SignUpbtn.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.SignUpbtn.IconMarginLeft = 11;
            this.SignUpbtn.IconPadding = 10;
            this.SignUpbtn.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SignUpbtn.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.SignUpbtn.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.SignUpbtn.IconSize = 25;
            this.SignUpbtn.IdleBorderColor = System.Drawing.Color.LightBlue;
            this.SignUpbtn.IdleBorderRadius = 50;
            this.SignUpbtn.IdleBorderThickness = 2;
            this.SignUpbtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(144)))), ((int)(((byte)(231)))));
            this.SignUpbtn.IdleIconLeftImage = null;
            this.SignUpbtn.IdleIconRightImage = null;
            this.SignUpbtn.IndicateFocus = false;
            this.SignUpbtn.Location = new System.Drawing.Point(293, 168);
            this.SignUpbtn.Name = "SignUpbtn";
            this.SignUpbtn.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.SignUpbtn.OnDisabledState.BorderRadius = 50;
            this.SignUpbtn.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.SignUpbtn.OnDisabledState.BorderThickness = 2;
            this.SignUpbtn.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.SignUpbtn.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.SignUpbtn.OnDisabledState.IconLeftImage = null;
            this.SignUpbtn.OnDisabledState.IconRightImage = null;
            this.SignUpbtn.onHoverState.BorderColor = System.Drawing.Color.DarkBlue;
            this.SignUpbtn.onHoverState.BorderRadius = 50;
            this.SignUpbtn.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.SignUpbtn.onHoverState.BorderThickness = 2;
            this.SignUpbtn.onHoverState.FillColor = System.Drawing.Color.Blue;
            this.SignUpbtn.onHoverState.ForeColor = System.Drawing.Color.Cyan;
            this.SignUpbtn.onHoverState.IconLeftImage = null;
            this.SignUpbtn.onHoverState.IconRightImage = null;
            this.SignUpbtn.OnIdleState.BorderColor = System.Drawing.Color.LightBlue;
            this.SignUpbtn.OnIdleState.BorderRadius = 50;
            this.SignUpbtn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.SignUpbtn.OnIdleState.BorderThickness = 2;
            this.SignUpbtn.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(144)))), ((int)(((byte)(231)))));
            this.SignUpbtn.OnIdleState.ForeColor = System.Drawing.SystemColors.Info;
            this.SignUpbtn.OnIdleState.IconLeftImage = null;
            this.SignUpbtn.OnIdleState.IconRightImage = null;
            this.SignUpbtn.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.SignUpbtn.OnPressedState.BorderRadius = 50;
            this.SignUpbtn.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.SignUpbtn.OnPressedState.BorderThickness = 2;
            this.SignUpbtn.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.SignUpbtn.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.SignUpbtn.OnPressedState.IconLeftImage = null;
            this.SignUpbtn.OnPressedState.IconRightImage = null;
            this.SignUpbtn.Size = new System.Drawing.Size(195, 60);
            this.SignUpbtn.TabIndex = 6;
            this.SignUpbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SignUpbtn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.SignUpbtn.TextMarginLeft = 0;
            this.SignUpbtn.TextPadding = new System.Windows.Forms.Padding(0);
            this.SignUpbtn.UseDefaultRadiusAndThickness = true;
            this.SignUpbtn.Click += new System.EventHandler(this.SignUpbtn_Click);
            // 
            // Exitbtn
            // 
            this.Exitbtn.AllowAnimations = true;
            this.Exitbtn.AllowMouseEffects = true;
            this.Exitbtn.AllowToggling = false;
            this.Exitbtn.AnimationSpeed = 200;
            this.Exitbtn.AutoGenerateColors = false;
            this.Exitbtn.AutoRoundBorders = false;
            this.Exitbtn.AutoSizeLeftIcon = true;
            this.Exitbtn.AutoSizeRightIcon = true;
            this.Exitbtn.BackColor = System.Drawing.Color.Transparent;
            this.Exitbtn.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(144)))), ((int)(((byte)(231)))));
            this.Exitbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Exitbtn.BackgroundImage")));
            this.Exitbtn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Exitbtn.ButtonText = "Exit";
            this.Exitbtn.ButtonTextMarginLeft = 0;
            this.Exitbtn.ColorContrastOnClick = 45;
            this.Exitbtn.ColorContrastOnHover = 45;
            this.Exitbtn.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.Exitbtn.CustomizableEdges = borderEdges3;
            this.Exitbtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Exitbtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.Exitbtn.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Exitbtn.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.Exitbtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Exitbtn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Idle;
            this.Exitbtn.Font = new System.Drawing.Font("Sitka Display", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exitbtn.ForeColor = System.Drawing.SystemColors.Info;
            this.Exitbtn.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Exitbtn.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.Exitbtn.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.Exitbtn.IconMarginLeft = 11;
            this.Exitbtn.IconPadding = 10;
            this.Exitbtn.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Exitbtn.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.Exitbtn.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.Exitbtn.IconSize = 25;
            this.Exitbtn.IdleBorderColor = System.Drawing.Color.LightBlue;
            this.Exitbtn.IdleBorderRadius = 50;
            this.Exitbtn.IdleBorderThickness = 2;
            this.Exitbtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(144)))), ((int)(((byte)(231)))));
            this.Exitbtn.IdleIconLeftImage = null;
            this.Exitbtn.IdleIconRightImage = null;
            this.Exitbtn.IndicateFocus = false;
            this.Exitbtn.Location = new System.Drawing.Point(293, 266);
            this.Exitbtn.Name = "Exitbtn";
            this.Exitbtn.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.Exitbtn.OnDisabledState.BorderRadius = 50;
            this.Exitbtn.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Exitbtn.OnDisabledState.BorderThickness = 2;
            this.Exitbtn.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Exitbtn.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.Exitbtn.OnDisabledState.IconLeftImage = null;
            this.Exitbtn.OnDisabledState.IconRightImage = null;
            this.Exitbtn.onHoverState.BorderColor = System.Drawing.Color.Black;
            this.Exitbtn.onHoverState.BorderRadius = 50;
            this.Exitbtn.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Exitbtn.onHoverState.BorderThickness = 2;
            this.Exitbtn.onHoverState.FillColor = System.Drawing.Color.Red;
            this.Exitbtn.onHoverState.ForeColor = System.Drawing.Color.Black;
            this.Exitbtn.onHoverState.IconLeftImage = null;
            this.Exitbtn.onHoverState.IconRightImage = null;
            this.Exitbtn.OnIdleState.BorderColor = System.Drawing.Color.LightBlue;
            this.Exitbtn.OnIdleState.BorderRadius = 50;
            this.Exitbtn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Exitbtn.OnIdleState.BorderThickness = 2;
            this.Exitbtn.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(144)))), ((int)(((byte)(231)))));
            this.Exitbtn.OnIdleState.ForeColor = System.Drawing.SystemColors.Info;
            this.Exitbtn.OnIdleState.IconLeftImage = null;
            this.Exitbtn.OnIdleState.IconRightImage = null;
            this.Exitbtn.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.Exitbtn.OnPressedState.BorderRadius = 50;
            this.Exitbtn.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Exitbtn.OnPressedState.BorderThickness = 2;
            this.Exitbtn.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.Exitbtn.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.Exitbtn.OnPressedState.IconLeftImage = null;
            this.Exitbtn.OnPressedState.IconRightImage = null;
            this.Exitbtn.Size = new System.Drawing.Size(195, 60);
            this.Exitbtn.TabIndex = 7;
            this.Exitbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Exitbtn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Exitbtn.TextMarginLeft = 0;
            this.Exitbtn.TextPadding = new System.Windows.Forms.Padding(0);
            this.Exitbtn.UseDefaultRadiusAndThickness = true;
            this.Exitbtn.Click += new System.EventHandler(this.Exitbtn_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.BottomContainer);
            this.MainPanel.Controls.Add(this.TopContainer);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.FillColor = System.Drawing.Color.Lavender;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(784, 561);
            this.MainPanel.TabIndex = 1;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.MainPanel);
            this.DoubleBuffered = true;
            this.MinimumSize = new System.Drawing.Size(600, 600);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dell";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.TopContainer.ResumeLayout(false);
            this.BottomContainer.ResumeLayout(false);
            this.Inputs.ResumeLayout(false);
            this.MainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Logo;
        private Guna.UI2.WinForms.Guna2Panel TopContainer;
        private Guna.UI2.WinForms.Guna2Panel BottomContainer;
        private System.Windows.Forms.TableLayoutPanel Inputs;
        private Guna.UI2.WinForms.Guna2Panel MainPanel;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton SignInbtn;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton SignUpbtn;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton Exitbtn;
    }
}

