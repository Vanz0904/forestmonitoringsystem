namespace desktop_app.Forms
{
    partial class Register
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
            this.RegisterPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.linkSignin = new Guna.UI.WinForms.GunaLinkLabel();
            this.txtConfirmPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtRegisterPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRegisterUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnRegister = new Guna.UI2.WinForms.Guna2Button();
            this.LoginInfoPanel = new System.Windows.Forms.Panel();
            this.guna2CirclePictureBox2 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.RegisterPanel.SuspendLayout();
            this.LoginInfoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // RegisterPanel
            // 
            this.RegisterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.RegisterPanel.BorderRadius = 10;
            this.RegisterPanel.BorderThickness = 1;
            this.RegisterPanel.Controls.Add(this.linkSignin);
            this.RegisterPanel.Controls.Add(this.txtConfirmPassword);
            this.RegisterPanel.Controls.Add(this.txtRegisterPassword);
            this.RegisterPanel.Controls.Add(this.label1);
            this.RegisterPanel.Controls.Add(this.txtRegisterUsername);
            this.RegisterPanel.Controls.Add(this.btnRegister);
            this.RegisterPanel.Controls.Add(this.LoginInfoPanel);
            this.RegisterPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RegisterPanel.FillColor = System.Drawing.Color.Black;
            this.RegisterPanel.Location = new System.Drawing.Point(0, 0);
            this.RegisterPanel.Name = "RegisterPanel";
            this.RegisterPanel.ShadowDecoration.Parent = this.RegisterPanel;
            this.RegisterPanel.Size = new System.Drawing.Size(800, 450);
            this.RegisterPanel.TabIndex = 1;
            // 
            // linkSignin
            // 
            this.linkSignin.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.linkSignin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.linkSignin.AutoSize = true;
            this.linkSignin.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkSignin.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkSignin.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.linkSignin.Location = new System.Drawing.Point(470, 323);
            this.linkSignin.Name = "linkSignin";
            this.linkSignin.Size = new System.Drawing.Size(53, 19);
            this.linkSignin.TabIndex = 5;
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
            this.txtConfirmPassword.Location = new System.Drawing.Point(261, 267);
            this.txtConfirmPassword.Margin = new System.Windows.Forms.Padding(0);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '\0';
            this.txtConfirmPassword.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtConfirmPassword.PlaceholderText = "Confirm your password";
            this.txtConfirmPassword.SelectedText = "";
            this.txtConfirmPassword.ShadowDecoration.Parent = this.txtConfirmPassword;
            this.txtConfirmPassword.Size = new System.Drawing.Size(278, 39);
            this.txtConfirmPassword.TabIndex = 3;
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
            this.txtRegisterPassword.Location = new System.Drawing.Point(261, 218);
            this.txtRegisterPassword.Margin = new System.Windows.Forms.Padding(0);
            this.txtRegisterPassword.Name = "txtRegisterPassword";
            this.txtRegisterPassword.PasswordChar = '\0';
            this.txtRegisterPassword.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtRegisterPassword.PlaceholderText = "Enter your password";
            this.txtRegisterPassword.SelectedText = "";
            this.txtRegisterPassword.ShadowDecoration.Parent = this.txtRegisterPassword;
            this.txtRegisterPassword.Size = new System.Drawing.Size(278, 39);
            this.txtRegisterPassword.TabIndex = 2;
            this.txtRegisterPassword.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(276, 323);
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
            this.txtRegisterUsername.Location = new System.Drawing.Point(261, 169);
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
            this.btnRegister.Location = new System.Drawing.Point(280, 362);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.ShadowDecoration.Parent = this.btnRegister;
            this.btnRegister.Size = new System.Drawing.Size(240, 35);
            this.btnRegister.TabIndex = 4;
            this.btnRegister.Text = "SIGN UP";
            this.btnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            // 
            // LoginInfoPanel
            // 
            this.LoginInfoPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LoginInfoPanel.Controls.Add(this.guna2CirclePictureBox2);
            this.LoginInfoPanel.Controls.Add(this.guna2TextBox1);
            this.LoginInfoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoginInfoPanel.Location = new System.Drawing.Point(0, 0);
            this.LoginInfoPanel.Name = "LoginInfoPanel";
            this.LoginInfoPanel.Size = new System.Drawing.Size(800, 450);
            this.LoginInfoPanel.TabIndex = 0;
            // 
            // guna2CirclePictureBox2
            // 
            this.guna2CirclePictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2CirclePictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox2.FillColor = System.Drawing.Color.Black;
            this.guna2CirclePictureBox2.Image = global::desktop_app.Properties.Resources.add_user_male;
            this.guna2CirclePictureBox2.Location = new System.Drawing.Point(365, 35);
            this.guna2CirclePictureBox2.Name = "guna2CirclePictureBox2";
            this.guna2CirclePictureBox2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox2.ShadowDecoration.Parent = this.guna2CirclePictureBox2;
            this.guna2CirclePictureBox2.Size = new System.Drawing.Size(70, 70);
            this.guna2CirclePictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox2.TabIndex = 0;
            this.guna2CirclePictureBox2.TabStop = false;
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2TextBox1.BorderColor = System.Drawing.Color.Silver;
            this.guna2TextBox1.BorderRadius = 18;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.guna2TextBox1.FocusedState.FillColor = System.Drawing.Color.Black;
            this.guna2TextBox1.FocusedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.guna2TextBox1.FocusedState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2TextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.DimGray;
            this.guna2TextBox1.HoverState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.IconRight = global::desktop_app.Properties.Resources.user;
            this.guna2TextBox1.Location = new System.Drawing.Point(261, 120);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(0);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.guna2TextBox1.PlaceholderText = "Enter your fullname";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.ShadowDecoration.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Size = new System.Drawing.Size(278, 39);
            this.guna2TextBox1.TabIndex = 0;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RegisterPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Register";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.RegisterPanel.ResumeLayout(false);
            this.RegisterPanel.PerformLayout();
            this.LoginInfoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel RegisterPanel;
        private System.Windows.Forms.Panel LoginInfoPanel;
        private Guna.UI.WinForms.GunaLinkLabel linkSignin;
        private Guna.UI2.WinForms.Guna2TextBox txtConfirmPassword;
        private Guna.UI2.WinForms.Guna2TextBox txtRegisterPassword;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtRegisterUsername;
        private Guna.UI2.WinForms.Guna2Button btnRegister;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox2;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
    }
}