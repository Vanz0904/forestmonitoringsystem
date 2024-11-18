namespace desktop_app
{
    partial class Authentication
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
            this.Login_Registration = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.HoverGradientBg = new Guna.UI.WinForms.GunaGradient2Panel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Signin = new System.Windows.Forms.Panel();
            this.RegisterPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.Signup = new System.Windows.Forms.Panel();
            this.linkSignin = new Guna.UI.WinForms.GunaLinkLabel();
            this.txtConfirmPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtRegisterPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRegisterUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnRegister = new Guna.UI2.WinForms.Guna2Button();
            this.guna2CirclePictureBox2 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.HoveringForm = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.HoverGradientBg.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.RegisterPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Login_Registration
            // 
            this.Login_Registration.TargetControl = this.HoverGradientBg;
            // 
            // HoverGradientBg
            // 
            this.HoverGradientBg.BackColor = System.Drawing.Color.Transparent;
            this.HoverGradientBg.Controls.Add(this.guna2Panel1);
            this.HoverGradientBg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HoverGradientBg.GradientColor1 = System.Drawing.Color.Black;
            this.HoverGradientBg.GradientColor2 = System.Drawing.Color.Transparent;
            this.HoverGradientBg.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.HoverGradientBg.Location = new System.Drawing.Point(0, 0);
            this.HoverGradientBg.Name = "HoverGradientBg";
            this.HoverGradientBg.Size = new System.Drawing.Size(1111, 538);
            this.HoverGradientBg.TabIndex = 2;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2Panel1.BorderRadius = 10;
            this.guna2Panel1.Controls.Add(this.tableLayoutPanel1);
            this.guna2Panel1.FillColor = System.Drawing.Color.Black;
            this.guna2Panel1.Location = new System.Drawing.Point(119, 67);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(872, 404);
            this.guna2Panel1.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.Signin, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.RegisterPanel, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(872, 404);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Signin
            // 
            this.Signin.BackgroundImage = global::desktop_app.Properties.Resources.register_banner_jpeg;
            this.Signin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Signin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Signin.Location = new System.Drawing.Point(439, 3);
            this.Signin.Name = "Signin";
            this.Signin.Size = new System.Drawing.Size(430, 398);
            this.Signin.TabIndex = 10;
            // 
            // RegisterPanel
            // 
            this.RegisterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.RegisterPanel.BorderRadius = 10;
            this.RegisterPanel.BorderThickness = 1;
            this.RegisterPanel.Controls.Add(this.Signup);
            this.RegisterPanel.Controls.Add(this.linkSignin);
            this.RegisterPanel.Controls.Add(this.txtConfirmPassword);
            this.RegisterPanel.Controls.Add(this.txtRegisterPassword);
            this.RegisterPanel.Controls.Add(this.label1);
            this.RegisterPanel.Controls.Add(this.txtRegisterUsername);
            this.RegisterPanel.Controls.Add(this.btnRegister);
            this.RegisterPanel.Controls.Add(this.guna2CirclePictureBox2);
            this.RegisterPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RegisterPanel.FillColor = System.Drawing.Color.Black;
            this.RegisterPanel.Location = new System.Drawing.Point(3, 3);
            this.RegisterPanel.Name = "RegisterPanel";
            this.RegisterPanel.ShadowDecoration.Parent = this.RegisterPanel;
            this.RegisterPanel.Size = new System.Drawing.Size(430, 398);
            this.RegisterPanel.TabIndex = 0;
            // 
            // Signup
            // 
            this.Signup.BackgroundImage = global::desktop_app.Properties.Resources.login_banner1;
            this.Signup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Signup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Signup.Location = new System.Drawing.Point(0, 0);
            this.Signup.Name = "Signup";
            this.Signup.Size = new System.Drawing.Size(430, 398);
            this.Signup.TabIndex = 8;
            // 
            // linkSignin
            // 
            this.linkSignin.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.linkSignin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.linkSignin.AutoSize = true;
            this.linkSignin.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkSignin.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkSignin.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.linkSignin.Location = new System.Drawing.Point(285, 286);
            this.linkSignin.Name = "linkSignin";
            this.linkSignin.Size = new System.Drawing.Size(53, 19);
            this.linkSignin.TabIndex = 7;
            this.linkSignin.TabStop = true;
            this.linkSignin.Text = "Sign in";
            this.linkSignin.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.linkSignin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkSignin_LinkClicked);
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtConfirmPassword.BorderColor = System.Drawing.Color.Silver;
            this.txtConfirmPassword.BorderRadius = 18;
            this.txtConfirmPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtConfirmPassword.DefaultText = "";
            this.txtConfirmPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtConfirmPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtConfirmPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtConfirmPassword.DisabledState.Parent = this.txtConfirmPassword;
            this.txtConfirmPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtConfirmPassword.FillColor = System.Drawing.Color.Transparent;
            this.txtConfirmPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.txtConfirmPassword.FocusedState.FillColor = System.Drawing.Color.Black;
            this.txtConfirmPassword.FocusedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.txtConfirmPassword.FocusedState.Parent = this.txtConfirmPassword;
            this.txtConfirmPassword.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.txtConfirmPassword.HoverState.BorderColor = System.Drawing.Color.DimGray;
            this.txtConfirmPassword.HoverState.Parent = this.txtConfirmPassword;
            this.txtConfirmPassword.IconRight = global::desktop_app.Properties.Resources.unlock;
            this.txtConfirmPassword.Location = new System.Drawing.Point(76, 232);
            this.txtConfirmPassword.Margin = new System.Windows.Forms.Padding(0);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '\0';
            this.txtConfirmPassword.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtConfirmPassword.PlaceholderText = "Confirm your password";
            this.txtConfirmPassword.SelectedText = "";
            this.txtConfirmPassword.ShadowDecoration.Parent = this.txtConfirmPassword;
            this.txtConfirmPassword.Size = new System.Drawing.Size(278, 39);
            this.txtConfirmPassword.TabIndex = 1;
            this.txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // txtRegisterPassword
            // 
            this.txtRegisterPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtRegisterPassword.BorderColor = System.Drawing.Color.Silver;
            this.txtRegisterPassword.BorderRadius = 18;
            this.txtRegisterPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRegisterPassword.DefaultText = "";
            this.txtRegisterPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtRegisterPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtRegisterPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRegisterPassword.DisabledState.Parent = this.txtRegisterPassword;
            this.txtRegisterPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRegisterPassword.FillColor = System.Drawing.Color.Transparent;
            this.txtRegisterPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.txtRegisterPassword.FocusedState.FillColor = System.Drawing.Color.Black;
            this.txtRegisterPassword.FocusedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.txtRegisterPassword.FocusedState.Parent = this.txtRegisterPassword;
            this.txtRegisterPassword.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegisterPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.txtRegisterPassword.HoverState.BorderColor = System.Drawing.Color.DimGray;
            this.txtRegisterPassword.HoverState.Parent = this.txtRegisterPassword;
            this.txtRegisterPassword.IconRight = global::desktop_app.Properties.Resources._lock;
            this.txtRegisterPassword.Location = new System.Drawing.Point(76, 177);
            this.txtRegisterPassword.Margin = new System.Windows.Forms.Padding(0);
            this.txtRegisterPassword.Name = "txtRegisterPassword";
            this.txtRegisterPassword.PasswordChar = '\0';
            this.txtRegisterPassword.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtRegisterPassword.PlaceholderText = "Enter your password";
            this.txtRegisterPassword.SelectedText = "";
            this.txtRegisterPassword.ShadowDecoration.Parent = this.txtRegisterPassword;
            this.txtRegisterPassword.Size = new System.Drawing.Size(278, 39);
            this.txtRegisterPassword.TabIndex = 1;
            this.txtRegisterPassword.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(91, 286);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Already hava an account?";
            // 
            // txtRegisterUsername
            // 
            this.txtRegisterUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtRegisterUsername.BorderColor = System.Drawing.Color.Silver;
            this.txtRegisterUsername.BorderRadius = 18;
            this.txtRegisterUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRegisterUsername.DefaultText = "";
            this.txtRegisterUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtRegisterUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtRegisterUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRegisterUsername.DisabledState.Parent = this.txtRegisterUsername;
            this.txtRegisterUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRegisterUsername.FillColor = System.Drawing.Color.Transparent;
            this.txtRegisterUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.txtRegisterUsername.FocusedState.FillColor = System.Drawing.Color.Black;
            this.txtRegisterUsername.FocusedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.txtRegisterUsername.FocusedState.Parent = this.txtRegisterUsername;
            this.txtRegisterUsername.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegisterUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.txtRegisterUsername.HoverState.BorderColor = System.Drawing.Color.DimGray;
            this.txtRegisterUsername.HoverState.Parent = this.txtRegisterUsername;
            this.txtRegisterUsername.IconRight = global::desktop_app.Properties.Resources.user;
            this.txtRegisterUsername.Location = new System.Drawing.Point(76, 122);
            this.txtRegisterUsername.Margin = new System.Windows.Forms.Padding(0);
            this.txtRegisterUsername.Name = "txtRegisterUsername";
            this.txtRegisterUsername.PasswordChar = '\0';
            this.txtRegisterUsername.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtRegisterUsername.PlaceholderText = "Enter your username";
            this.txtRegisterUsername.SelectedText = "";
            this.txtRegisterUsername.ShadowDecoration.Parent = this.txtRegisterUsername;
            this.txtRegisterUsername.Size = new System.Drawing.Size(278, 39);
            this.txtRegisterUsername.TabIndex = 1;
            // 
            // btnRegister
            // 
            this.btnRegister.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRegister.Animated = true;
            this.btnRegister.AutoRoundedCorners = true;
            this.btnRegister.BorderColor = System.Drawing.Color.Transparent;
            this.btnRegister.BorderRadius = 16;
            this.btnRegister.BorderThickness = 1;
            this.btnRegister.CheckedState.Parent = this.btnRegister;
            this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegister.CustomImages.Parent = this.btnRegister;
            this.btnRegister.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.btnRegister.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.Color.Black;
            this.btnRegister.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.btnRegister.HoverState.FillColor = System.Drawing.Color.Black;
            this.btnRegister.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.btnRegister.HoverState.Parent = this.btnRegister;
            this.btnRegister.Location = new System.Drawing.Point(95, 325);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.ShadowDecoration.Parent = this.btnRegister;
            this.btnRegister.Size = new System.Drawing.Size(240, 35);
            this.btnRegister.TabIndex = 4;
            this.btnRegister.Text = "SIGN UP";
            this.btnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            // 
            // guna2CirclePictureBox2
            // 
            this.guna2CirclePictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2CirclePictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox2.FillColor = System.Drawing.Color.Black;
            this.guna2CirclePictureBox2.Image = global::desktop_app.Properties.Resources.add_user_male;
            this.guna2CirclePictureBox2.Location = new System.Drawing.Point(175, 21);
            this.guna2CirclePictureBox2.Name = "guna2CirclePictureBox2";
            this.guna2CirclePictureBox2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox2.ShadowDecoration.Parent = this.guna2CirclePictureBox2;
            this.guna2CirclePictureBox2.Size = new System.Drawing.Size(80, 80);
            this.guna2CirclePictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox2.TabIndex = 0;
            this.guna2CirclePictureBox2.TabStop = false;
            // 
            // Authentication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(0)))));
            this.BackgroundImage = global::desktop_app.Properties.Resources.michiru_mountain;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1111, 538);
            this.Controls.Add(this.HoverGradientBg);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Authentication";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.LoginRegistrationForm_Load);
            this.HoverGradientBg.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.RegisterPanel.ResumeLayout(false);
            this.RegisterPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaDragControl Login_Registration;
        private Guna.UI2.WinForms.Guna2ShadowForm HoveringForm;
        private Guna.UI.WinForms.GunaGradient2Panel HoverGradientBg;
        private Guna.UI2.WinForms.Guna2Panel RegisterPanel;
        private Guna.UI2.WinForms.Guna2TextBox txtRegisterPassword;
        private Guna.UI2.WinForms.Guna2TextBox txtRegisterUsername;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox2;
        private Guna.UI2.WinForms.Guna2Button btnRegister;
        private Guna.UI.WinForms.GunaLinkLabel linkSignin;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtConfirmPassword;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel Signup;
        private System.Windows.Forms.Panel Signin;
    }
}

