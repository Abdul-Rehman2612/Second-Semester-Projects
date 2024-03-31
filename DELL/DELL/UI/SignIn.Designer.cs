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
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.MainPanel = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.TopContainer = new Guna.UI2.WinForms.Guna2Panel();
            this.Logo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.BottomContainer = new Guna.UI2.WinForms.Guna2Panel();
            this.ButtonsContainer = new System.Windows.Forms.TableLayoutPanel();
            this.SignInbtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.Back = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.TextBoxContainer = new System.Windows.Forms.TableLayoutPanel();
            this.Username = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Password = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.UNInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.PInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.MainPanel.SuspendLayout();
            this.TopContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.BottomContainer.SuspendLayout();
            this.ButtonsContainer.SuspendLayout();
            this.TextBoxContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.TopContainer);
            this.MainPanel.Controls.Add(this.BottomContainer);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.FillColor = System.Drawing.Color.Black;
            this.MainPanel.FillColor2 = System.Drawing.Color.Blue;
            this.MainPanel.FillColor3 = System.Drawing.Color.Black;
            this.MainPanel.FillColor4 = System.Drawing.Color.Black;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(784, 561);
            this.MainPanel.TabIndex = 1;
            // 
            // TopContainer
            // 
            this.TopContainer.BackColor = System.Drawing.Color.Transparent;
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
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(784, 150);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo.TabIndex = 1;
            this.Logo.TabStop = false;
            this.Logo.UseTransparentBackground = true;
            // 
            // BottomContainer
            // 
            this.BottomContainer.BackColor = System.Drawing.Color.Transparent;
            this.BottomContainer.Controls.Add(this.ButtonsContainer);
            this.BottomContainer.Controls.Add(this.TextBoxContainer);
            this.BottomContainer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomContainer.Location = new System.Drawing.Point(0, 150);
            this.BottomContainer.Name = "BottomContainer";
            this.BottomContainer.Size = new System.Drawing.Size(784, 411);
            this.BottomContainer.TabIndex = 1;
            // 
            // ButtonsContainer
            // 
            this.ButtonsContainer.ColumnCount = 5;
            this.ButtonsContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.88265F));
            this.ButtonsContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.30612F));
            this.ButtonsContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonsContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.15306F));
            this.ButtonsContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.53061F));
            this.ButtonsContainer.Controls.Add(this.SignInbtn, 3, 0);
            this.ButtonsContainer.Controls.Add(this.Back, 1, 1);
            this.ButtonsContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonsContainer.Location = new System.Drawing.Point(0, 227);
            this.ButtonsContainer.Name = "ButtonsContainer";
            this.ButtonsContainer.RowCount = 3;
            this.ButtonsContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.ButtonsContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.ButtonsContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.ButtonsContainer.Size = new System.Drawing.Size(784, 184);
            this.ButtonsContainer.TabIndex = 1;
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
            this.SignInbtn.BackColor1 = System.Drawing.Color.Gray;
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
            this.SignInbtn.IdleBorderColor = System.Drawing.Color.CornflowerBlue;
            this.SignInbtn.IdleBorderRadius = 50;
            this.SignInbtn.IdleBorderThickness = 2;
            this.SignInbtn.IdleFillColor = System.Drawing.Color.Gray;
            this.SignInbtn.IdleIconLeftImage = null;
            this.SignInbtn.IdleIconRightImage = null;
            this.SignInbtn.IndicateFocus = false;
            this.SignInbtn.Location = new System.Drawing.Point(420, 3);
            this.SignInbtn.Name = "SignInbtn";
            this.SignInbtn.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.SignInbtn.OnDisabledState.BorderRadius = 50;
            this.SignInbtn.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.SignInbtn.OnDisabledState.BorderThickness = 2;
            this.SignInbtn.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.SignInbtn.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.SignInbtn.OnDisabledState.IconLeftImage = null;
            this.SignInbtn.OnDisabledState.IconRightImage = null;
            this.SignInbtn.onHoverState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.SignInbtn.onHoverState.BorderRadius = 50;
            this.SignInbtn.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.SignInbtn.onHoverState.BorderThickness = 2;
            this.SignInbtn.onHoverState.FillColor = System.Drawing.Color.Blue;
            this.SignInbtn.onHoverState.ForeColor = System.Drawing.Color.Cyan;
            this.SignInbtn.onHoverState.IconLeftImage = null;
            this.SignInbtn.onHoverState.IconRightImage = null;
            this.SignInbtn.OnIdleState.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.SignInbtn.OnIdleState.BorderRadius = 50;
            this.SignInbtn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.SignInbtn.OnIdleState.BorderThickness = 2;
            this.SignInbtn.OnIdleState.FillColor = System.Drawing.Color.Gray;
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
            this.SignInbtn.Size = new System.Drawing.Size(152, 55);
            this.SignInbtn.TabIndex = 0;
            this.SignInbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SignInbtn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.SignInbtn.TextMarginLeft = 0;
            this.SignInbtn.TextPadding = new System.Windows.Forms.Padding(0);
            this.SignInbtn.UseDefaultRadiusAndThickness = true;
            // 
            // Back
            // 
            this.Back.AllowAnimations = true;
            this.Back.AllowMouseEffects = true;
            this.Back.AllowToggling = false;
            this.Back.AnimationSpeed = 200;
            this.Back.AutoGenerateColors = false;
            this.Back.AutoRoundBorders = false;
            this.Back.AutoSizeLeftIcon = true;
            this.Back.AutoSizeRightIcon = true;
            this.Back.BackColor = System.Drawing.Color.Transparent;
            this.Back.BackColor1 = System.Drawing.Color.Gray;
            this.Back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Back.BackgroundImage")));
            this.Back.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Back.ButtonText = "Back";
            this.Back.ButtonTextMarginLeft = 0;
            this.Back.ColorContrastOnClick = 45;
            this.Back.ColorContrastOnHover = 45;
            this.Back.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.Back.CustomizableEdges = borderEdges2;
            this.Back.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Back.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.Back.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Back.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.Back.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Back.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Idle;
            this.Back.Font = new System.Drawing.Font("Sitka Display", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.ForeColor = System.Drawing.SystemColors.Info;
            this.Back.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Back.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.Back.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.Back.IconMarginLeft = 11;
            this.Back.IconPadding = 10;
            this.Back.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Back.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.Back.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.Back.IconSize = 25;
            this.Back.IdleBorderColor = System.Drawing.Color.CornflowerBlue;
            this.Back.IdleBorderRadius = 50;
            this.Back.IdleBorderThickness = 2;
            this.Back.IdleFillColor = System.Drawing.Color.Gray;
            this.Back.IdleIconLeftImage = null;
            this.Back.IdleIconRightImage = null;
            this.Back.IndicateFocus = false;
            this.Back.Location = new System.Drawing.Point(104, 64);
            this.Back.Name = "Back";
            this.Back.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.Back.OnDisabledState.BorderRadius = 50;
            this.Back.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Back.OnDisabledState.BorderThickness = 2;
            this.Back.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Back.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.Back.OnDisabledState.IconLeftImage = null;
            this.Back.OnDisabledState.IconRightImage = null;
            this.Back.onHoverState.BorderColor = System.Drawing.Color.Black;
            this.Back.onHoverState.BorderRadius = 50;
            this.Back.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Back.onHoverState.BorderThickness = 2;
            this.Back.onHoverState.FillColor = System.Drawing.Color.Red;
            this.Back.onHoverState.ForeColor = System.Drawing.Color.Black;
            this.Back.onHoverState.IconLeftImage = null;
            this.Back.onHoverState.IconRightImage = null;
            this.Back.OnIdleState.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.Back.OnIdleState.BorderRadius = 50;
            this.Back.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Back.OnIdleState.BorderThickness = 2;
            this.Back.OnIdleState.FillColor = System.Drawing.Color.Gray;
            this.Back.OnIdleState.ForeColor = System.Drawing.SystemColors.Info;
            this.Back.OnIdleState.IconLeftImage = null;
            this.Back.OnIdleState.IconRightImage = null;
            this.Back.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.Back.OnPressedState.BorderRadius = 50;
            this.Back.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Back.OnPressedState.BorderThickness = 2;
            this.Back.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.Back.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.Back.OnPressedState.IconLeftImage = null;
            this.Back.OnPressedState.IconRightImage = null;
            this.Back.Size = new System.Drawing.Size(114, 55);
            this.Back.TabIndex = 2;
            this.Back.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Back.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Back.TextMarginLeft = 0;
            this.Back.TextPadding = new System.Windows.Forms.Padding(0);
            this.Back.UseDefaultRadiusAndThickness = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // TextBoxContainer
            // 
            this.TextBoxContainer.ColumnCount = 5;
            this.TextBoxContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.36225F));
            this.TextBoxContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.72959F));
            this.TextBoxContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.545918F));
            this.TextBoxContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.44898F));
            this.TextBoxContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.65816F));
            this.TextBoxContainer.Controls.Add(this.Username, 1, 1);
            this.TextBoxContainer.Controls.Add(this.Password, 1, 3);
            this.TextBoxContainer.Controls.Add(this.UNInput, 3, 1);
            this.TextBoxContainer.Controls.Add(this.PInput, 3, 3);
            this.TextBoxContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.TextBoxContainer.Location = new System.Drawing.Point(0, 0);
            this.TextBoxContainer.Name = "TextBoxContainer";
            this.TextBoxContainer.RowCount = 5;
            this.TextBoxContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 61F));
            this.TextBoxContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.TextBoxContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.TextBoxContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.TextBoxContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TextBoxContainer.Size = new System.Drawing.Size(784, 227);
            this.TextBoxContainer.TabIndex = 0;
            // 
            // Username
            // 
            this.Username.BackColor = System.Drawing.Color.Transparent;
            this.Username.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Username.Font = new System.Drawing.Font("Sitka Text", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.ForeColor = System.Drawing.SystemColors.Control;
            this.Username.Location = new System.Drawing.Point(194, 64);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(137, 41);
            this.Username.TabIndex = 0;
            this.Username.Text = "Username";
            // 
            // Password
            // 
            this.Password.BackColor = System.Drawing.Color.Transparent;
            this.Password.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Password.Font = new System.Drawing.Font("Sitka Text", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.ForeColor = System.Drawing.SystemColors.Control;
            this.Password.Location = new System.Drawing.Point(194, 131);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(132, 41);
            this.Password.TabIndex = 1;
            this.Password.Text = "Password";
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
            this.UNInput.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UNInput.ForeColor = System.Drawing.Color.Black;
            this.UNInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UNInput.Location = new System.Drawing.Point(401, 66);
            this.UNInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UNInput.Name = "UNInput";
            this.UNInput.PasswordChar = '\0';
            this.UNInput.PlaceholderText = "Enter Username";
            this.UNInput.SelectedText = "";
            this.UNInput.Size = new System.Drawing.Size(168, 36);
            this.UNInput.TabIndex = 2;
            // 
            // PInput
            // 
            this.PInput.BorderColor = System.Drawing.Color.Black;
            this.PInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PInput.DefaultText = "";
            this.PInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PInput.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PInput.Location = new System.Drawing.Point(401, 133);
            this.PInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PInput.Name = "PInput";
            this.PInput.PasswordChar = '\0';
            this.PInput.PlaceholderText = "Enter Password";
            this.PInput.SelectedText = "";
            this.PInput.Size = new System.Drawing.Size(168, 36);
            this.PInput.TabIndex = 3;
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.MainPanel);
            this.MinimumSize = new System.Drawing.Size(600, 500);
            this.Name = "SignIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dell";
            this.MainPanel.ResumeLayout(false);
            this.TopContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.BottomContainer.ResumeLayout(false);
            this.ButtonsContainer.ResumeLayout(false);
            this.TextBoxContainer.ResumeLayout(false);
            this.TextBoxContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2CustomGradientPanel MainPanel;
        private Guna.UI2.WinForms.Guna2Panel TopContainer;
        private Guna.UI2.WinForms.Guna2PictureBox Logo;
        private Guna.UI2.WinForms.Guna2Panel BottomContainer;
        private System.Windows.Forms.TableLayoutPanel TextBoxContainer;
        private Guna.UI2.WinForms.Guna2HtmlLabel Password;
        private Guna.UI2.WinForms.Guna2TextBox UNInput;
        private Guna.UI2.WinForms.Guna2HtmlLabel Username;
        private Guna.UI2.WinForms.Guna2TextBox PInput;
        private System.Windows.Forms.TableLayoutPanel ButtonsContainer;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton Back;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton SignInbtn;
    }
}