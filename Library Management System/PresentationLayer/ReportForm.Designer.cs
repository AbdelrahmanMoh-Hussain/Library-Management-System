namespace Library_Management_System.PresentationLayer
{
    partial class ReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_perm = new System.Windows.Forms.Label();
            this.label_date = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.userCount_label = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.transCount_label = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bookCount_label = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.catCount_label = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btn_add = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton22 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label_perm);
            this.panel1.Controls.Add(this.label_date);
            this.panel1.Controls.Add(this.label_name);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Location = new System.Drawing.Point(34, 138);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(902, 1163);
            this.panel1.TabIndex = 0;
            // 
            // label_perm
            // 
            this.label_perm.AutoSize = true;
            this.label_perm.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label_perm.Location = new System.Drawing.Point(418, 222);
            this.label_perm.Name = "label_perm";
            this.label_perm.Size = new System.Drawing.Size(119, 30);
            this.label_perm.TabIndex = 14;
            this.label_perm.Text = "Permission";
            this.label_perm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_date
            // 
            this.label_date.AutoSize = true;
            this.label_date.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label_date.Location = new System.Drawing.Point(418, 285);
            this.label_date.Name = "label_date";
            this.label_date.Size = new System.Drawing.Size(119, 30);
            this.label_date.TabIndex = 14;
            this.label_date.Text = "Permission";
            this.label_date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label_name.Location = new System.Drawing.Point(397, 151);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(161, 30);
            this.label_name.TabIndex = 14;
            this.label_name.Text = "Reporter Name";
            this.label_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(95, 222);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 30);
            this.label8.TabIndex = 14;
            this.label8.Text = "Permission";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(95, 285);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 30);
            this.label6.TabIndex = 14;
            this.label6.Text = "Report Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(95, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 30);
            this.label3.TabIndex = 14;
            this.label3.Text = "Reporter Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(32, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 42);
            this.label2.TabIndex = 14;
            this.label2.Text = "Report Details";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(32, 503);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 42);
            this.label1.TabIndex = 5;
            this.label1.Text = "Summary";
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(80)))), ((int)(((byte)(105)))));
            this.panel4.Controls.Add(this.userCount_label);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Location = new System.Drawing.Point(482, 826);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(307, 203);
            this.panel4.TabIndex = 12;
            // 
            // userCount_label
            // 
            this.userCount_label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.userCount_label.AutoSize = true;
            this.userCount_label.Font = new System.Drawing.Font("Stencil", 18.27692F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userCount_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(233)))), ((int)(((byte)(135)))));
            this.userCount_label.Location = new System.Drawing.Point(138, 110);
            this.userCount_label.Name = "userCount_label";
            this.userCount_label.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.userCount_label.Size = new System.Drawing.Size(55, 39);
            this.userCount_label.TabIndex = 4;
            this.userCount_label.Text = "58";
            this.userCount_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Stencil", 16.06154F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(88, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(133, 35);
            this.label9.TabIndex = 3;
            this.label9.Text = "# Users";
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(80)))), ((int)(((byte)(105)))));
            this.panel3.Controls.Add(this.transCount_label);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Location = new System.Drawing.Point(482, 604);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(307, 203);
            this.panel3.TabIndex = 9;
            // 
            // transCount_label
            // 
            this.transCount_label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.transCount_label.AutoSize = true;
            this.transCount_label.Font = new System.Drawing.Font("Stencil", 18.27692F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.transCount_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(233)))), ((int)(((byte)(135)))));
            this.transCount_label.Location = new System.Drawing.Point(138, 110);
            this.transCount_label.Name = "transCount_label";
            this.transCount_label.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.transCount_label.Size = new System.Drawing.Size(55, 39);
            this.transCount_label.TabIndex = 4;
            this.transCount_label.Text = "58";
            this.transCount_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Stencil", 16.06154F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(26, 51);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(258, 35);
            this.label12.TabIndex = 3;
            this.label12.Text = "# Transactions";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(80)))), ((int)(((byte)(105)))));
            this.panel2.Controls.Add(this.bookCount_label);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(119, 604);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(307, 203);
            this.panel2.TabIndex = 10;
            // 
            // bookCount_label
            // 
            this.bookCount_label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bookCount_label.AutoSize = true;
            this.bookCount_label.Font = new System.Drawing.Font("Stencil", 18.27692F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bookCount_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(233)))), ((int)(((byte)(135)))));
            this.bookCount_label.Location = new System.Drawing.Point(126, 110);
            this.bookCount_label.Name = "bookCount_label";
            this.bookCount_label.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bookCount_label.Size = new System.Drawing.Size(55, 39);
            this.bookCount_label.TabIndex = 4;
            this.bookCount_label.Text = "58";
            this.bookCount_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Stencil", 16.06154F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(84, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 35);
            this.label5.TabIndex = 3;
            this.label5.Text = "# Books";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel6
            // 
            this.panel6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(80)))), ((int)(((byte)(105)))));
            this.panel6.Controls.Add(this.catCount_label);
            this.panel6.Controls.Add(this.label13);
            this.panel6.Location = new System.Drawing.Point(119, 826);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(307, 203);
            this.panel6.TabIndex = 11;
            // 
            // catCount_label
            // 
            this.catCount_label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.catCount_label.AutoSize = true;
            this.catCount_label.Font = new System.Drawing.Font("Stencil", 18.27692F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.catCount_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(233)))), ((int)(((byte)(135)))));
            this.catCount_label.Location = new System.Drawing.Point(126, 110);
            this.catCount_label.Name = "catCount_label";
            this.catCount_label.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.catCount_label.Size = new System.Drawing.Size(55, 39);
            this.catCount_label.TabIndex = 4;
            this.catCount_label.Text = "58";
            this.catCount_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Stencil", 16.06154F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(52, 42);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(219, 35);
            this.label13.TabIndex = 3;
            this.label13.Text = "# Categories";
            // 
            // btn_add
            // 
            this.btn_add.ActiveBorderThickness = 1;
            this.btn_add.ActiveCornerRadius = 20;
            this.btn_add.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btn_add.ActiveForecolor = System.Drawing.Color.White;
            this.btn_add.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btn_add.BackColor = System.Drawing.SystemColors.Control;
            this.btn_add.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_add.BackgroundImage")));
            this.btn_add.ButtonText = "Settings";
            this.btn_add.Font = new System.Drawing.Font("Century Gothic", 13.84615F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_add.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_add.IdleBorderThickness = 1;
            this.btn_add.IdleCornerRadius = 20;
            this.btn_add.IdleFillColor = System.Drawing.Color.White;
            this.btn_add.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btn_add.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btn_add.Location = new System.Drawing.Point(34, 46);
            this.btn_add.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(247, 66);
            this.btn_add.TabIndex = 13;
            this.btn_add.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Preview";
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 13.84615F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.Location = new System.Drawing.Point(385, 46);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(247, 66);
            this.bunifuThinButton21.TabIndex = 13;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.btn_add2_Click);
            // 
            // bunifuThinButton22
            // 
            this.bunifuThinButton22.ActiveBorderThickness = 1;
            this.bunifuThinButton22.ActiveCornerRadius = 20;
            this.bunifuThinButton22.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton22.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton22.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton22.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuThinButton22.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton22.BackgroundImage")));
            this.bunifuThinButton22.ButtonText = "Print";
            this.bunifuThinButton22.Font = new System.Drawing.Font("Century Gothic", 13.84615F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bunifuThinButton22.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton22.IdleBorderThickness = 1;
            this.bunifuThinButton22.IdleCornerRadius = 20;
            this.bunifuThinButton22.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton22.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton22.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton22.Location = new System.Drawing.Point(689, 46);
            this.bunifuThinButton22.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.bunifuThinButton22.Name = "bunifuThinButton22";
            this.bunifuThinButton22.Size = new System.Drawing.Size(247, 66);
            this.bunifuThinButton22.TabIndex = 13;
            this.bunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton22.Click += new System.EventHandler(this.btn_add3_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.Document = this.printDocument1;
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 35F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(980, 639);
            this.Controls.Add(this.bunifuThinButton22);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bunifuThinButton21);
            this.Controls.Add(this.btn_add);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 13.84615F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ReportForm";
            this.Text = "Report Printing";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        public Bunifu.Framework.UI.BunifuThinButton2 btn_add;
        public Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        public Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton22;
        private Label label6;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel4;
        private Label label9;
        private Panel panel3;
        private Label label12;
        private Panel panel2;
        private Label label5;
        private Panel panel6;
        private Label label13;
        private Label label8;
        public Label label_date;
        public Label label_name;
        public Label userCount_label;
        public Label transCount_label;
        public Label bookCount_label;
        public Label catCount_label;
        public Label label_perm;
        private PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
    }
}