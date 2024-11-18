namespace desktop_app.Forms
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
            this.LoginPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.linkSignup = new Guna.UI.WinForms.GunaLinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLogin = new Guna.UI2.WinForms.Guna2Button();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.txtLoginUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtLoginPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.LoginPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginPanel
            // 
            this.LoginPanel.BackColor = System.Drawing.Color.Transparent;
            this.LoginPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.LoginPanel.Controls.Add(this.linkSignup);
            this.LoginPanel.Controls.Add(this.label3);
            this.LoginPanel.Controls.Add(this.label2);
            this.LoginPanel.Controls.Add(this.btnLogin);
            this.LoginPanel.Controls.Add(this.gunaLabel1);
            this.LoginPanel.Controls.Add(this.txtLoginUsername);
            this.LoginPanel.Controls.Add(this.txtLoginPassword);
            this.LoginPanel.Controls.Add(this.guna2CirclePictureBox1);
            this.LoginPanel.Controls.Add(this.guna2Button1);
            this.LoginPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoginPanel.FillColor = System.Drawing.Color.Black;
            this.LoginPanel.Location = new System.Drawing.Point(0, 0);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.ShadowDecoration.Parent = this.LoginPanel;
            this.LoginPanel.Size = new System.Drawing.Size(800, 450);
            this.LoginPanel.TabIndex = 0;
            // 
            // linkSignup
            // 
            this.linkSignup.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.linkSignup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.linkSignup.AutoSize = true;
            this.linkSignup.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkSignup.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkSignup.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.linkSignup.Location = new System.Drawing.Point(466, 309);
            this.linkSignup.Name = "linkSignup";
            this.linkSignup.Size = new System.Drawing.Size(60, 19);
            this.linkSignup.TabIndex = 3;
            this.linkSignup.TabStop = true;
            this.linkSignup.Text = "Sign up";
            this.linkSignup.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.linkSignup.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkSignup_LinkClicked);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(-229, 317);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Already hava an account?";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(288, 309);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Don\'t hava an account?";
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogin.Animated = true;
            this.btnLogin.AutoRoundedCorners = true;
            this.btnLogin.BorderColor = System.Drawing.Color.Transparent;
            this.btnLogin.BorderRadius = 16;
            this.btnLogin.BorderThickness = 1;
            this.btnLogin.CheckedState.Parent = this.btnLogin;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.CustomImages.Parent = this.btnLogin;
            this.btnLogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.btnLogin.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.Black;
            this.btnLogin.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.btnLogin.HoverState.FillColor = System.Drawing.Color.Black;
            this.btnLogin.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.btnLogin.HoverState.Parent = this.btnLogin;
            this.btnLogin.Location = new System.Drawing.Point(289, 350);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.ShadowDecoration.Parent = this.btnLogin;
            this.btnLogin.Size = new System.Drawing.Size(240, 35);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "SIGN IN";
            this.btnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.gunaLabel1.Location = new System.Drawing.Point(360, 85);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(136, 38);
            this.gunaLabel1.TabIndex = 4;
            this.gunaLabel1.Text = "SIGN IN";
            // 
            // txtLoginUsername
            // 
            this.txtLoginUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLoginUsername.BorderColor = System.Drawing.Color.Silver;
            this.txtLoginUsername.BorderRadius = 18;
            this.txtLoginUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLoginUsername.DefaultText = "";
            this.txtLoginUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtLoginUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtLoginUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLoginUsername.DisabledState.Parent = this.txtLoginUsername;
            this.txtLoginUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLoginUsername.FillColor = System.Drawing.Color.Transparent;
            this.txtLoginUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.txtLoginUsername.FocusedState.FillColor = System.Drawing.Color.Black;
            this.txtLoginUsername.FocusedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.txtLoginUsername.FocusedState.Parent = this.txtLoginUsername;
            this.txtLoginUsername.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoginUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.txtLoginUsername.HoverState.BorderColor = System.Drawing.Color.DimGray;
            this.txtLoginUsername.HoverState.Parent = this.txtLoginUsername;
            this.txtLoginUsername.Location = new System.Drawing.Point(270, 196);
            this.txtLoginUsername.Margin = new System.Windows.Forms.Padding(0);
            this.txtLoginUsername.Name = "txtLoginUsername";
            this.txtLoginUsername.PasswordChar = '\0';
            this.txtLoginUsername.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtLoginUsername.PlaceholderText = "Username";
            this.txtLoginUsername.SelectedText = "";
            this.txtLoginUsername.ShadowDecoration.Parent = this.txtLoginUsername;
            this.txtLoginUsername.Size = new System.Drawing.Size(278, 37);
            this.txtLoginUsername.TabIndex = 0;
            // 
            // txtLoginPassword
            // 
            this.txtLoginPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLoginPassword.BorderColor = System.Drawing.Color.Silver;
            this.txtLoginPassword.BorderRadius = 18;
            this.txtLoginPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLoginPassword.DefaultText = "";
            this.txtLoginPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtLoginPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtLoginPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLoginPassword.DisabledState.Parent = this.txtLoginPassword;
            this.txtLoginPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLoginPassword.FillColor = System.Drawing.Color.Transparent;
            this.txtLoginPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.txtLoginPassword.FocusedState.FillColor = System.Drawing.Color.Black;
            this.txtLoginPassword.FocusedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.txtLoginPassword.FocusedState.Parent = this.txtLoginPassword;
            this.txtLoginPassword.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoginPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.txtLoginPassword.HoverState.BorderColor = System.Drawing.Color.DimGray;
            this.txtLoginPassword.HoverState.Parent = this.txtLoginPassword;
            this.txtLoginPassword.Location = new System.Drawing.Point(270, 251);
            this.txtLoginPassword.Margin = new System.Windows.Forms.Padding(0);
            this.txtLoginPassword.Name = "txtLoginPassword";
            this.txtLoginPassword.PasswordChar = '\0';
            this.txtLoginPassword.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtLoginPassword.PlaceholderText = "Password";
            this.txtLoginPassword.SelectedText = "";
            this.txtLoginPassword.ShadowDecoration.Parent = this.txtLoginPassword;
            this.txtLoginPassword.Size = new System.Drawing.Size(278, 37);
            this.txtLoginPassword.TabIndex = 1;
            this.txtLoginPassword.UseSystemPasswordChar = true;
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2CirclePictureBox1.Image = global::desktop_app.Properties.Resources.male_user;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(304, 79);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.ShadowDecoration.Parent = this.guna2CirclePictureBox1;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(50, 50);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox1.TabIndex = 0;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // guna2Button1
            // 
            this.guna2Button1.Animated = true;
            this.guna2Button1.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.ImageSize = new System.Drawing.Size(80, 80);
            this.guna2Button1.Location = new System.Drawing.Point(3, 238);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.PressedColor = System.Drawing.Color.Transparent;
            this.guna2Button1.PressedDepth = 0;
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(100, 100);
            this.guna2Button1.TabIndex = 6;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LoginPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.LoginPanel.ResumeLayout(false);
            this.LoginPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel LoginPanel;
        private Guna.UI.WinForms.GunaLinkLabel linkSignup;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btnLogin;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI2.WinForms.Guna2TextBox txtLoginUsername;
        private Guna.UI2.WinForms.Guna2TextBox txtLoginPassword;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}