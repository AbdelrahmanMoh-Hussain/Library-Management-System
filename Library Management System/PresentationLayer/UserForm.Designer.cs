namespace Library_Management_System.PresentationLayer
{
    partial class UserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuImageButton1 = new Bunifu.UI.WinForms.BunifuImageButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_add = new Bunifu.Framework.UI.BunifuThinButton2();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.password_txt = new System.Windows.Forms.Label();
            this.permission_txt = new System.Windows.Forms.Label();
            this.username_txt = new System.Windows.Forms.Label();
            this.password_txtbox = new System.Windows.Forms.TextBox();
            this.name_txt = new System.Windows.Forms.Label();
            this.userName_txtbox = new System.Windows.Forms.TextBox();
            this.name_txtbox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.bunifuImageButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(533, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(425, 730);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Subheading", 18.27692F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(103, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 48);
            this.label1.TabIndex = 13;
            this.label1.Text = "Add New User";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Library_Management_System.Properties.Resources._236831;
            this.pictureBox1.Location = new System.Drawing.Point(92, 215);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(252, 245);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.ActiveImage = null;
            this.bunifuImageButton1.AllowAnimations = true;
            this.bunifuImageButton1.AllowBuffering = false;
            this.bunifuImageButton1.AllowToggling = false;
            this.bunifuImageButton1.AllowZooming = true;
            this.bunifuImageButton1.AllowZoomingOnFocus = false;
            this.bunifuImageButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuImageButton1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.ErrorImage")));
            this.bunifuImageButton1.FadeWhenInactive = false;
            this.bunifuImageButton1.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.bunifuImageButton1.Image = global::Library_Management_System.Properties.Resources.delete_sign_64px;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.ImageLocation = null;
            this.bunifuImageButton1.ImageMargin = 20;
            this.bunifuImageButton1.ImageSize = new System.Drawing.Size(45, 45);
            this.bunifuImageButton1.ImageZoomSize = new System.Drawing.Size(65, 65);
            this.bunifuImageButton1.InitialImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.InitialImage")));
            this.bunifuImageButton1.Location = new System.Drawing.Point(348, 12);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Rotation = 0;
            this.bunifuImageButton1.ShowActiveImage = true;
            this.bunifuImageButton1.ShowCursorChanges = true;
            this.bunifuImageButton1.ShowImageBorders = true;
            this.bunifuImageButton1.ShowSizeMarkers = false;
            this.bunifuImageButton1.Size = new System.Drawing.Size(65, 65);
            this.bunifuImageButton1.TabIndex = 8;
            this.bunifuImageButton1.ToolTipText = "";
            this.bunifuImageButton1.WaitOnLoad = false;
            this.bunifuImageButton1.Zoom = 20;
            this.bunifuImageButton1.ZoomSpeed = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Controls.Add(this.btn_add);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.password_txt);
            this.panel2.Controls.Add(this.permission_txt);
            this.panel2.Controls.Add(this.username_txt);
            this.panel2.Controls.Add(this.password_txtbox);
            this.panel2.Controls.Add(this.name_txt);
            this.panel2.Controls.Add(this.userName_txtbox);
            this.panel2.Controls.Add(this.name_txtbox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(537, 730);
            this.panel2.TabIndex = 1;
            // 
            // btn_add
            // 
            this.btn_add.ActiveBorderThickness = 1;
            this.btn_add.ActiveCornerRadius = 20;
            this.btn_add.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btn_add.ActiveForecolor = System.Drawing.Color.White;
            this.btn_add.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btn_add.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_add.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_add.BackgroundImage")));
            this.btn_add.ButtonText = "Add";
            this.btn_add.Font = new System.Drawing.Font("Century Gothic", 13.84615F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_add.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_add.IdleBorderThickness = 1;
            this.btn_add.IdleCornerRadius = 20;
            this.btn_add.IdleFillColor = System.Drawing.Color.White;
            this.btn_add.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btn_add.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btn_add.Location = new System.Drawing.Point(61, 574);
            this.btn_add.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(394, 66);
            this.btn_add.TabIndex = 12;
            this.btn_add.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Sitka Subheading", 12.18462F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Manger",
            "User"});
            this.comboBox1.Location = new System.Drawing.Point(61, 441);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(394, 40);
            this.comboBox1.TabIndex = 11;
            // 
            // password_txt
            // 
            this.password_txt.AutoSize = true;
            this.password_txt.Font = new System.Drawing.Font("Sitka Subheading", 13.84615F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.password_txt.Location = new System.Drawing.Point(61, 297);
            this.password_txt.Name = "password_txt";
            this.password_txt.Size = new System.Drawing.Size(126, 36);
            this.password_txt.TabIndex = 9;
            this.password_txt.Text = "Password";
            this.password_txt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // permission_txt
            // 
            this.permission_txt.AutoSize = true;
            this.permission_txt.Font = new System.Drawing.Font("Sitka Subheading", 13.84615F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.permission_txt.Location = new System.Drawing.Point(61, 398);
            this.permission_txt.Name = "permission_txt";
            this.permission_txt.Size = new System.Drawing.Size(144, 36);
            this.permission_txt.TabIndex = 9;
            this.permission_txt.Text = "Permission";
            this.permission_txt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // username_txt
            // 
            this.username_txt.AutoSize = true;
            this.username_txt.Font = new System.Drawing.Font("Sitka Subheading", 13.84615F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.username_txt.Location = new System.Drawing.Point(61, 191);
            this.username_txt.Name = "username_txt";
            this.username_txt.Size = new System.Drawing.Size(139, 36);
            this.username_txt.TabIndex = 9;
            this.username_txt.Text = "User Name";
            this.username_txt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // password_txtbox
            // 
            this.password_txtbox.Font = new System.Drawing.Font("Sitka Subheading", 12.18462F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.password_txtbox.Location = new System.Drawing.Point(61, 333);
            this.password_txtbox.Name = "password_txtbox";
            this.password_txtbox.Size = new System.Drawing.Size(394, 35);
            this.password_txtbox.TabIndex = 10;
            this.password_txtbox.UseSystemPasswordChar = true;
            // 
            // name_txt
            // 
            this.name_txt.AutoSize = true;
            this.name_txt.Font = new System.Drawing.Font("Sitka Subheading", 13.84615F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.name_txt.Location = new System.Drawing.Point(61, 96);
            this.name_txt.Name = "name_txt";
            this.name_txt.Size = new System.Drawing.Size(79, 36);
            this.name_txt.TabIndex = 9;
            this.name_txt.Text = "Name";
            this.name_txt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // userName_txtbox
            // 
            this.userName_txtbox.Font = new System.Drawing.Font("Sitka Subheading", 12.18462F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.userName_txtbox.Location = new System.Drawing.Point(61, 227);
            this.userName_txtbox.Name = "userName_txtbox";
            this.userName_txtbox.Size = new System.Drawing.Size(394, 35);
            this.userName_txtbox.TabIndex = 10;
            // 
            // name_txtbox
            // 
            this.name_txtbox.Font = new System.Drawing.Font("Sitka Subheading", 12.18462F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.name_txtbox.Location = new System.Drawing.Point(61, 132);
            this.name_txtbox.Name = "name_txtbox";
            this.name_txtbox.Size = new System.Drawing.Size(394, 35);
            this.name_txtbox.TabIndex = 10;
            // 
            // AddUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 100F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 730);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Cambria Math", 9.969231F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 14, 4, 14);
            this.Name = "AddUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddUserForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Bunifu.UI.WinForms.BunifuImageButton bunifuImageButton1;
        private Label name_txt;
        public TextBox name_txtbox;
        private Label password_txt;
        private Label permission_txt;
        private Label username_txt;
        public TextBox password_txtbox;
        public TextBox userName_txtbox;
        public Bunifu.Framework.UI.BunifuThinButton2 btn_add;
        private Label label1;
        private PictureBox pictureBox1;
        public ComboBox comboBox1;
    }
}