namespace desktop_app.Forms
{
    partial class Home
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.guna2VSeparator1 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2RadialGauge1 = new Guna.UI2.WinForms.Guna2RadialGauge();
            this.panel4 = new System.Windows.Forms.Panel();
            this.guna2VSeparator2 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2RadialGauge3 = new Guna.UI2.WinForms.Guna2RadialGauge();
            this.panel2 = new System.Windows.Forms.Panel();
            this.MapDisplay = new Guna.UI2.WinForms.Guna2Panel();
            this.btnUpdates = new Guna.UI2.WinForms.Guna2Button();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.panel1.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.guna2Panel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 123);
            this.panel1.TabIndex = 0;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.tableLayoutPanel1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(30)))), ((int)(((byte)(0)))));
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(800, 123);
            this.guna2Panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Controls.Add(this.panel6, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel5, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 123);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.gunaPictureBox1);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.guna2VSeparator1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(563, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(234, 117);
            this.panel6.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(171, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 65);
            this.label5.TabIndex = 2;
            this.label5.Text = "0";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(179, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Alerts";
            // 
            // guna2VSeparator1
            // 
            this.guna2VSeparator1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2VSeparator1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.guna2VSeparator1.Location = new System.Drawing.Point(0, 0);
            this.guna2VSeparator1.Name = "guna2VSeparator1";
            this.guna2VSeparator1.Size = new System.Drawing.Size(10, 117);
            this.guna2VSeparator1.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.guna2RadialGauge1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(283, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(274, 117);
            this.panel5.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(159, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 57);
            this.label3.TabIndex = 2;
            this.label3.Text = "0m³";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(187, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Humidity";
            // 
            // guna2RadialGauge1
            // 
            this.guna2RadialGauge1.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.guna2RadialGauge1.ArrowThickness = 1;
            this.guna2RadialGauge1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(30)))), ((int)(((byte)(0)))));
            this.guna2RadialGauge1.Font = new System.Drawing.Font("Verdana", 8.2F);
            this.guna2RadialGauge1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.guna2RadialGauge1.Location = new System.Drawing.Point(3, 3);
            this.guna2RadialGauge1.MinimumSize = new System.Drawing.Size(30, 30);
            this.guna2RadialGauge1.Name = "guna2RadialGauge1";
            this.guna2RadialGauge1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(30)))), ((int)(((byte)(0)))));
            this.guna2RadialGauge1.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.guna2RadialGauge1.ProgressEndCap = System.Drawing.Drawing2D.LineCap.Round;
            this.guna2RadialGauge1.ProgressStartCap = System.Drawing.Drawing2D.LineCap.Round;
            this.guna2RadialGauge1.ProgressThickness = 10;
            this.guna2RadialGauge1.ShowPercentage = false;
            this.guna2RadialGauge1.Size = new System.Drawing.Size(112, 112);
            this.guna2RadialGauge1.TabIndex = 1;
            this.guna2RadialGauge1.Value = 60;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.guna2VSeparator2);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.guna2RadialGauge3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(274, 117);
            this.panel4.TabIndex = 2;
            // 
            // guna2VSeparator2
            // 
            this.guna2VSeparator2.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2VSeparator2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.guna2VSeparator2.Location = new System.Drawing.Point(264, 0);
            this.guna2VSeparator2.Name = "guna2VSeparator2";
            this.guna2VSeparator2.Size = new System.Drawing.Size(10, 117);
            this.guna2VSeparator2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(150, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 57);
            this.label2.TabIndex = 2;
            this.label2.Text = "0°C";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(157, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Temperature";
            // 
            // guna2RadialGauge3
            // 
            this.guna2RadialGauge3.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.guna2RadialGauge3.ArrowThickness = 1;
            this.guna2RadialGauge3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(30)))), ((int)(((byte)(0)))));
            this.guna2RadialGauge3.Font = new System.Drawing.Font("Verdana", 8.2F);
            this.guna2RadialGauge3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.guna2RadialGauge3.Location = new System.Drawing.Point(3, 3);
            this.guna2RadialGauge3.MinimumSize = new System.Drawing.Size(30, 30);
            this.guna2RadialGauge3.Name = "guna2RadialGauge3";
            this.guna2RadialGauge3.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(30)))), ((int)(((byte)(0)))));
            this.guna2RadialGauge3.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.guna2RadialGauge3.ProgressEndCap = System.Drawing.Drawing2D.LineCap.Round;
            this.guna2RadialGauge3.ProgressStartCap = System.Drawing.Drawing2D.LineCap.Round;
            this.guna2RadialGauge3.ProgressThickness = 10;
            this.guna2RadialGauge3.ShowPercentage = false;
            this.guna2RadialGauge3.Size = new System.Drawing.Size(112, 112);
            this.guna2RadialGauge3.TabIndex = 1;
            this.guna2RadialGauge3.Value = 60;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnUpdates);
            this.panel2.Controls.Add(this.MapDisplay);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 123);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 327);
            this.panel2.TabIndex = 1;
            // 
            // MapDisplay
            // 
            this.MapDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MapDisplay.BackColor = System.Drawing.Color.Transparent;
            this.MapDisplay.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.MapDisplay.BorderThickness = 5;
            this.MapDisplay.Location = new System.Drawing.Point(0, 49);
            this.MapDisplay.Name = "MapDisplay";
            this.MapDisplay.ShadowDecoration.Parent = this.MapDisplay;
            this.MapDisplay.Size = new System.Drawing.Size(800, 272);
            this.MapDisplay.TabIndex = 0;
            // 
            // btnUpdates
            // 
            this.btnUpdates.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdates.Animated = true;
            this.btnUpdates.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.btnUpdates.BorderThickness = 1;
            this.btnUpdates.CheckedState.Parent = this.btnUpdates;
            this.btnUpdates.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdates.CustomImages.Parent = this.btnUpdates;
            this.btnUpdates.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.btnUpdates.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdates.ForeColor = System.Drawing.Color.Black;
            this.btnUpdates.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.btnUpdates.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(30)))), ((int)(((byte)(0)))));
            this.btnUpdates.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.btnUpdates.HoverState.Image = global::desktop_app.Properties.Resources.download_primary;
            this.btnUpdates.HoverState.Parent = this.btnUpdates;
            this.btnUpdates.Image = global::desktop_app.Properties.Resources.download_black;
            this.btnUpdates.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnUpdates.Location = new System.Drawing.Point(0, 8);
            this.btnUpdates.Name = "btnUpdates";
            this.btnUpdates.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(30)))), ((int)(((byte)(0)))));
            this.btnUpdates.PressedDepth = 0;
            this.btnUpdates.ShadowDecoration.Parent = this.btnUpdates;
            this.btnUpdates.Size = new System.Drawing.Size(800, 35);
            this.btnUpdates.TabIndex = 0;
            this.btnUpdates.Text = "Updates";
            this.btnUpdates.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnUpdates.Click += new System.EventHandler(this.BtnUpdates_Click);
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.gunaPictureBox1.Image = global::desktop_app.Properties.Resources.wildfire;
            this.gunaPictureBox1.Location = new System.Drawing.Point(10, 0);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(109, 117);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.gunaPictureBox1.TabIndex = 3;
            this.gunaPictureBox1.TabStop = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.panel1.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel6;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2RadialGauge guna2RadialGauge1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2RadialGauge guna2RadialGauge3;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator2;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator1;
        private Guna.UI2.WinForms.Guna2Panel MapDisplay;
        private Guna.UI2.WinForms.Guna2Button btnUpdates;
    }
}