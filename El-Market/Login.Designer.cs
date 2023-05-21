namespace El_Market
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.CircleButton1 = new Guna.UI.WinForms.GunaCircleButton();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUser = new Bunifu.Framework.UI.BunifuImageButton();
            this.cbSelectRole = new System.Windows.Forms.ComboBox();
            this.txtUsername = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnLogin = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnReset = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUser)).BeginInit();
            this.SuspendLayout();
            // 
            // CircleButton1
            // 
            this.CircleButton1.AnimationHoverSpeed = 0.07F;
            this.CircleButton1.AnimationSpeed = 0.03F;
            this.CircleButton1.BaseColor = System.Drawing.Color.DarkOrange;
            this.CircleButton1.BorderColor = System.Drawing.Color.Black;
            this.CircleButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.CircleButton1.FocusedColor = System.Drawing.Color.Empty;
            this.CircleButton1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CircleButton1.ForeColor = System.Drawing.Color.White;
            this.CircleButton1.Image = null;
            this.CircleButton1.ImageSize = new System.Drawing.Size(52, 52);
            this.CircleButton1.Location = new System.Drawing.Point(-212, -12);
            this.CircleButton1.Name = "CircleButton1";
            this.CircleButton1.OnHoverBaseColor = System.Drawing.Color.DarkOrange;
            this.CircleButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.CircleButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.CircleButton1.OnHoverImage = null;
            this.CircleButton1.OnPressedColor = System.Drawing.Color.Black;
            this.CircleButton1.Size = new System.Drawing.Size(546, 619);
            this.CircleButton1.TabIndex = 5;
            this.CircleButton1.Text = "                  El-Market";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(847, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 1;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkOrange;
            this.label2.Location = new System.Drawing.Point(520, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Login";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(477, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 38);
            this.label1.TabIndex = 3;
            this.label1.Text = "El-Market";
            // 
            // btnUser
            // 
            this.btnUser.BackColor = System.Drawing.Color.Transparent;
            this.btnUser.Image = ((System.Drawing.Image)(resources.GetObject("btnUser.Image")));
            this.btnUser.ImageActive = null;
            this.btnUser.Location = new System.Drawing.Point(580, 102);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(150, 150);
            this.btnUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnUser.TabIndex = 4;
            this.btnUser.TabStop = false;
            this.btnUser.Zoom = 10;
            // 
            // cbSelectRole
            // 
            this.cbSelectRole.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSelectRole.ForeColor = System.Drawing.Color.Black;
            this.cbSelectRole.FormattingEnabled = true;
            this.cbSelectRole.Items.AddRange(new object[] {
            "Admin",
            "Cashier"});
            this.cbSelectRole.Location = new System.Drawing.Point(510, 274);
            this.cbSelectRole.Name = "cbSelectRole";
            this.cbSelectRole.Size = new System.Drawing.Size(239, 30);
            this.cbSelectRole.TabIndex = 5;
            this.cbSelectRole.Text = "Select Role";
            // 
            // txtUsername
            // 
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.DarkOrange;
            this.txtUsername.HintForeColor = System.Drawing.Color.Empty;
            this.txtUsername.HintText = "Enter Username";
            this.txtUsername.isPassword = false;
            this.txtUsername.LineFocusedColor = System.Drawing.Color.DarkOrange;
            this.txtUsername.LineIdleColor = System.Drawing.Color.DarkOrange;
            this.txtUsername.LineMouseHoverColor = System.Drawing.Color.DarkOrange;
            this.txtUsername.LineThickness = 3;
            this.txtUsername.Location = new System.Drawing.Point(510, 328);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(239, 49);
            this.txtUsername.TabIndex = 0;
            this.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtPassword
            // 
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.DarkOrange;
            this.txtPassword.HintForeColor = System.Drawing.Color.Black;
            this.txtPassword.HintText = "Enter Password";
            this.txtPassword.isPassword = false;
            this.txtPassword.LineFocusedColor = System.Drawing.Color.DarkOrange;
            this.txtPassword.LineIdleColor = System.Drawing.Color.DarkOrange;
            this.txtPassword.LineMouseHoverColor = System.Drawing.Color.DarkOrange;
            this.txtPassword.LineThickness = 3;
            this.txtPassword.Location = new System.Drawing.Point(510, 400);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(239, 49);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnLogin
            // 
            this.btnLogin.ActiveBorderThickness = 1;
            this.btnLogin.ActiveCornerRadius = 20;
            this.btnLogin.ActiveFillColor = System.Drawing.Color.DarkOrange;
            this.btnLogin.ActiveForecolor = System.Drawing.Color.White;
            this.btnLogin.ActiveLineColor = System.Drawing.Color.DarkOrange;
            this.btnLogin.BackColor = System.Drawing.Color.White;
            this.btnLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogin.BackgroundImage")));
            this.btnLogin.ButtonText = "Login";
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnLogin.IdleBorderThickness = 1;
            this.btnLogin.IdleCornerRadius = 20;
            this.btnLogin.IdleFillColor = System.Drawing.Color.DarkOrange;
            this.btnLogin.IdleForecolor = System.Drawing.Color.White;
            this.btnLogin.IdleLineColor = System.Drawing.Color.DarkOrange;
            this.btnLogin.Location = new System.Drawing.Point(510, 458);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(113, 49);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnReset
            // 
            this.btnReset.ActiveBorderThickness = 1;
            this.btnReset.ActiveCornerRadius = 20;
            this.btnReset.ActiveFillColor = System.Drawing.Color.DarkOrange;
            this.btnReset.ActiveForecolor = System.Drawing.Color.White;
            this.btnReset.ActiveLineColor = System.Drawing.Color.DarkOrange;
            this.btnReset.BackColor = System.Drawing.Color.White;
            this.btnReset.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReset.BackgroundImage")));
            this.btnReset.ButtonText = "Reset";
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnReset.IdleBorderThickness = 1;
            this.btnReset.IdleCornerRadius = 20;
            this.btnReset.IdleFillColor = System.Drawing.Color.DarkOrange;
            this.btnReset.IdleForecolor = System.Drawing.Color.White;
            this.btnReset.IdleLineColor = System.Drawing.Color.DarkOrange;
            this.btnReset.Location = new System.Drawing.Point(636, 458);
            this.btnReset.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(113, 49);
            this.btnReset.TabIndex = 7;
            this.btnReset.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(879, 600);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.cbSelectRole);
            this.Controls.Add(this.btnUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.CircleButton1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaCircleButton CircleButton1;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuImageButton btnUser;
        private System.Windows.Forms.ComboBox cbSelectRole;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtUsername;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPassword;
        private Bunifu.Framework.UI.BunifuThinButton2 btnLogin;
        private Bunifu.Framework.UI.BunifuThinButton2 btnReset;
    }
}