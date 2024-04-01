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
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.Logo = new System.Windows.Forms.Label();
            this.TopContainer = new Guna.UI2.WinForms.Guna2Panel();
            this.Username = new Guna.UI.WinForms.GunaLabel();
            this.Password = new Guna.UI.WinForms.GunaLabel();
            this.BottomContainer = new Guna.UI2.WinForms.Guna2Panel();
            this.Inputs = new System.Windows.Forms.TableLayoutPanel();
            this.PInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.UInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.SignInbtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.Backbtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.Registernow = new System.Windows.Forms.LinkLabel();
            this.MainPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.Exitbtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
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
            this.Logo.Location = new System.Drawing.Point(0, 0);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(784, 150);
            this.Logo.TabIndex = 1;
            this.Logo.Text = "Sign In";
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
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Username.Font = new System.Drawing.Font("Sitka Heading", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.Location = new System.Drawing.Point(197, 67);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(140, 52);
            this.Username.TabIndex = 6;
            this.Username.Text = "Username";
            this.Username.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Password.Font = new System.Drawing.Font("Sitka Heading", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(197, 119);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(140, 51);
            this.Password.TabIndex = 7;
            this.Password.Text = "Password";
            this.Password.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.Inputs.ColumnCount = 7;
            this.Inputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.29178F));
            this.Inputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.50192F));
            this.Inputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.62462F));
            this.Inputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.020527F));
            this.Inputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.06449F));
            this.Inputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.50192F));
            this.Inputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.99474F));
            this.Inputs.Controls.Add(this.Username, 2, 1);
            this.Inputs.Controls.Add(this.PInput, 4, 2);
            this.Inputs.Controls.Add(this.Password, 2, 2);
            this.Inputs.Controls.Add(this.UInput, 4, 1);
            this.Inputs.Controls.Add(this.SignInbtn, 4, 3);
            this.Inputs.Controls.Add(this.Backbtn, 1, 5);
            this.Inputs.Controls.Add(this.Registernow, 2, 3);
            this.Inputs.Controls.Add(this.Exitbtn, 5, 5);
            this.Inputs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Inputs.ForeColor = System.Drawing.Color.Black;
            this.Inputs.Location = new System.Drawing.Point(0, 0);
            this.Inputs.Name = "Inputs";
            this.Inputs.RowCount = 7;
            this.Inputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.Inputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.Inputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.61539F));
            this.Inputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.76923F));
            this.Inputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.76923F));
            this.Inputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.84615F));
            this.Inputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 81F));
            this.Inputs.Size = new System.Drawing.Size(784, 411);
            this.Inputs.TabIndex = 0;
            // 
            // PInput
            // 
            this.PInput.AutoRoundedCorners = true;
            this.PInput.BorderRadius = 18;
            this.PInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PInput.DefaultText = "";
            this.PInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PInput.FillColor = System.Drawing.SystemColors.InactiveBorder;
            this.PInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PInput.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PInput.ForeColor = System.Drawing.Color.Black;
            this.PInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PInput.Location = new System.Drawing.Point(353, 125);
            this.PInput.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.PInput.Name = "PInput";
            this.PInput.PasswordChar = '\0';
            this.PInput.PlaceholderText = "Enter Password";
            this.PInput.SelectedText = "";
            this.PInput.Size = new System.Drawing.Size(210, 39);
            this.PInput.TabIndex = 13;
            // 
            // UInput
            // 
            this.UInput.AutoRoundedCorners = true;
            this.UInput.BorderRadius = 19;
            this.UInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UInput.DefaultText = "";
            this.UInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.UInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.UInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UInput.FillColor = System.Drawing.SystemColors.InactiveBorder;
            this.UInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UInput.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UInput.ForeColor = System.Drawing.Color.Black;
            this.UInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UInput.Location = new System.Drawing.Point(353, 73);
            this.UInput.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.UInput.Name = "UInput";
            this.UInput.PasswordChar = '\0';
            this.UInput.PlaceholderText = "Enter Username";
            this.UInput.SelectedText = "";
            this.UInput.Size = new System.Drawing.Size(210, 40);
            this.UInput.TabIndex = 12;
            // 
            // SignInbtn
            // 
            this.SignInbtn.AllowAnimations = true;
            this.SignInbtn.AllowMouseEffects = true;
            this.SignInbtn.AllowToggling = false;
            this.SignInbtn.AnimationSpeed = 200;
            this.SignInbtn.AutoGenerateColors = false;
            this.SignInbtn.AutoRoundBorders = false;
            this.SignInbtn.AutoSize = true;
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
            this.SignInbtn.Dock = System.Windows.Forms.DockStyle.Right;
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
            this.SignInbtn.Location = new System.Drawing.Point(436, 173);
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
            this.SignInbtn.Size = new System.Drawing.Size(129, 60);
            this.SignInbtn.TabIndex = 14;
            this.SignInbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SignInbtn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.SignInbtn.TextMarginLeft = 0;
            this.SignInbtn.TextPadding = new System.Windows.Forms.Padding(0);
            this.SignInbtn.UseDefaultRadiusAndThickness = true;
            this.SignInbtn.Click += new System.EventHandler(this.SignInbtn_Click);
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
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.Backbtn.CustomizableEdges = borderEdges2;
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
            this.Backbtn.Location = new System.Drawing.Point(68, 268);
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
            this.Backbtn.Size = new System.Drawing.Size(123, 56);
            this.Backbtn.TabIndex = 15;
            this.Backbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Backbtn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Backbtn.TextMarginLeft = 0;
            this.Backbtn.TextPadding = new System.Windows.Forms.Padding(0);
            this.Backbtn.UseDefaultRadiusAndThickness = true;
            this.Backbtn.Click += new System.EventHandler(this.Backbtn_Click);
            // 
            // Registernow
            // 
            this.Registernow.AutoSize = true;
            this.Registernow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Registernow.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.Registernow.LinkColor = System.Drawing.Color.Silver;
            this.Registernow.Location = new System.Drawing.Point(197, 170);
            this.Registernow.Name = "Registernow";
            this.Registernow.Size = new System.Drawing.Size(140, 67);
            this.Registernow.TabIndex = 16;
            this.Registernow.TabStop = true;
            this.Registernow.Tag = "";
            this.Registernow.Text = "Don\'t have an account?\r\nRegister now!";
            this.Registernow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Registernow.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Registernow_LinkClicked);
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
            this.Exitbtn.Location = new System.Drawing.Point(571, 268);
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
            this.Exitbtn.Size = new System.Drawing.Size(123, 56);
            this.Exitbtn.TabIndex = 19;
            this.Exitbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Exitbtn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Exitbtn.TextMarginLeft = 0;
            this.Exitbtn.TextPadding = new System.Windows.Forms.Padding(0);
            this.Exitbtn.UseDefaultRadiusAndThickness = true;
            this.Exitbtn.Click += new System.EventHandler(this.Exitbtn_Click);
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.MainPanel);
            this.MinimumSize = new System.Drawing.Size(600, 600);
            this.Name = "SignIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignIn";
            this.TopContainer.ResumeLayout(false);
            this.BottomContainer.ResumeLayout(false);
            this.Inputs.ResumeLayout(false);
            this.Inputs.PerformLayout();
            this.MainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Logo;
        private Guna.UI2.WinForms.Guna2Panel TopContainer;
        private Guna.UI.WinForms.GunaLabel Username;
        private Guna.UI.WinForms.GunaLabel Password;
        private Guna.UI2.WinForms.Guna2Panel BottomContainer;
        private System.Windows.Forms.TableLayoutPanel Inputs;
        private Guna.UI2.WinForms.Guna2TextBox UInput;
        private Guna.UI2.WinForms.Guna2TextBox PInput;
        private Guna.UI2.WinForms.Guna2Panel MainPanel;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton SignInbtn;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton Backbtn;
        private System.Windows.Forms.LinkLabel Registernow;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton Exitbtn;
    }
}