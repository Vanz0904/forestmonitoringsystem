namespace desktop_app.Forms
{
    partial class Updates
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.closeDialog = new Guna.UI2.WinForms.Guna2Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gunaAnimateWindow1 = new Guna.UI.WinForms.GunaAnimateWindow(this.components);
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.HoveringPanel = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.guna2ShadowPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.guna2Panel1.Controls.Add(this.panel1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(423, 179);
            this.guna2Panel1.TabIndex = 0;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel2.Controls.Add(this.close);
            this.guna2Panel2.Controls.Add(this.label1);
            this.guna2Panel2.Controls.Add(this.label7);
            this.guna2Panel2.Controls.Add(this.closeDialog);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(30)))), ((int)(((byte)(0)))));
            this.guna2Panel2.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(423, 179);
            this.guna2Panel2.TabIndex = 0;
            // 
            // closeDialog
            // 
            this.closeDialog.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.closeDialog.Animated = true;
            this.closeDialog.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.closeDialog.BorderRadius = 5;
            this.closeDialog.BorderThickness = 1;
            this.closeDialog.CheckedState.Parent = this.closeDialog;
            this.closeDialog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeDialog.CustomImages.Parent = this.closeDialog;
            this.closeDialog.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.closeDialog.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeDialog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(30)))), ((int)(((byte)(0)))));
            this.closeDialog.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.closeDialog.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(30)))), ((int)(((byte)(0)))));
            this.closeDialog.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.closeDialog.HoverState.Parent = this.closeDialog;
            this.closeDialog.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.closeDialog.Location = new System.Drawing.Point(339, 135);
            this.closeDialog.Name = "closeDialog";
            this.closeDialog.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(30)))), ((int)(((byte)(0)))));
            this.closeDialog.PressedDepth = 0;
            this.closeDialog.ShadowDecoration.Parent = this.closeDialog;
            this.closeDialog.Size = new System.Drawing.Size(72, 32);
            this.closeDialog.TabIndex = 1;
            this.closeDialog.Text = "Okay";
            this.closeDialog.Click += new System.EventHandler(this.CloseDialog_Click);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(13, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(211, 21);
            this.label7.TabIndex = 2;
            this.label7.Text = "Features not available 💀";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Error Message";
            // 
            // close
            // 
            this.close.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.close.AutoSize = true;
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.close.Location = new System.Drawing.Point(379, 13);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(31, 21);
            this.close.TabIndex = 2;
            this.close.Text = "✖️";
            this.close.Click += new System.EventHandler(this.Close_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.guna2ShadowPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(423, 179);
            this.panel1.TabIndex = 1;
            // 
            // gunaAnimateWindow1
            // 
            this.gunaAnimateWindow1.AnimationType = Guna.UI.WinForms.GunaAnimateWindow.AnimateWindowType.AW_BLEND;
            this.gunaAnimateWindow1.Interval = 500;
            this.gunaAnimateWindow1.TargetControl = this.guna2Panel2;
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.guna2Panel2);
            this.guna2ShadowPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(20)))), ((int)(((byte)(0)))));
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.Radius = 10;
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(20)))), ((int)(((byte)(0)))));
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(423, 179);
            this.guna2ShadowPanel1.TabIndex = 0;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this.label1;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 10;
            this.guna2Elipse1.TargetControl = this;
            // 
            // Updates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 179);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Updates";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Updates";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.Load += new System.EventHandler(this.Updates_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Button closeDialog;
        private System.Windows.Forms.Label close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaAnimateWindow gunaAnimateWindow1;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2ShadowForm HoveringPanel;
    }
}