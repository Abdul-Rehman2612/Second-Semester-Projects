namespace Prison_Escape.UI
{
    partial class Level1
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.GameSt = new System.Windows.Forms.Panel();
            this.GamePage = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // GameSt
            // 
            this.GameSt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.GameSt.Dock = System.Windows.Forms.DockStyle.Right;
            this.GameSt.ForeColor = System.Drawing.SystemColors.Control;
            this.GameSt.Location = new System.Drawing.Point(1170, 0);
            this.GameSt.Name = "GameSt";
            this.GameSt.Size = new System.Drawing.Size(200, 749);
            this.GameSt.TabIndex = 0;
            // 
            // GamePage
            // 
            this.GamePage.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.GamePage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GamePage.Location = new System.Drawing.Point(0, 0);
            this.GamePage.Name = "GamePage";
            this.GamePage.Size = new System.Drawing.Size(1170, 749);
            this.GamePage.TabIndex = 1;
            this.GamePage.Paint += new System.Windows.Forms.PaintEventHandler(this.GamePage_Paint);
            // 
            // Level1
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.GamePage);
            this.Controls.Add(this.GameSt);
            this.MinimumSize = new System.Drawing.Size(1364, 726);
            this.Name = "Level1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Level1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel GameSt;
        private System.Windows.Forms.Panel GamePage;
    }
}

