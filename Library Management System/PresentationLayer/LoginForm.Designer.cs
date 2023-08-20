namespace Library_Management_System.PresentationLayer
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.bunifuImageButton1 = new Bunifu.UI.WinForms.BunifuImageButton();
            this.password_txt = new System.Windows.Forms.Label();
            this.username_txt = new System.Windows.Forms.Label();
            this.password_txtbox = new System.Windows.Forms.TextBox();
            this.userName_txtbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_add = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuImageButton3 = new Bunifu.UI.WinForms.BunifuImageButton();
            this.SuspendLayout();
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
            this.bunifuImageButton1.Location = new System.Drawing.Point(650, 12);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Rotation = 0;
            this.bunifuImageButton1.ShowActiveImage = true;
            this.bunifuImageButton1.ShowCursorChanges = true;
            this.bunifuImageButton1.ShowImageBorders = true;
            this.bunifuImageButton1.ShowSizeMarkers = false;
            this.bunifuImageButton1.Size = new System.Drawing.Size(65, 65);
            this.bunifuImageButton1.TabIndex = 3;
            this.bunifuImageButton1.ToolTipText = "";
            this.bunifuImageButton1.WaitOnLoad = false;
            this.bunifuImageButton1.Zoom = 20;
            this.bunifuImageButton1.ZoomSpeed = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // password_txt
            // 
            this.password_txt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.password_txt.AutoSize = true;
            this.password_txt.Font = new System.Drawing.Font("Sitka Subheading", 18.27692F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.password_txt.Location = new System.Drawing.Point(45, 293);
            this.password_txt.Name = "password_txt";
            this.password_txt.Size = new System.Drawing.Size(165, 48);
            this.password_txt.TabIndex = 11;
            this.password_txt.Text = "Password";
            this.password_txt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // username_txt
            // 
            this.username_txt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.username_txt.AutoSize = true;
            this.username_txt.Font = new System.Drawing.Font("Sitka Subheading", 18.27692F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.username_txt.Location = new System.Drawing.Point(45, 187);
            this.username_txt.Name = "username_txt";
            this.username_txt.Size = new System.Drawing.Size(185, 48);
            this.username_txt.TabIndex = 12;
            this.username_txt.Text = "User Name";
            this.username_txt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // password_txtbox
            // 
            this.password_txtbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.password_txtbox.Font = new System.Drawing.Font("Sitka Subheading", 18.27692F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.password_txtbox.Location = new System.Drawing.Point(287, 294);
            this.password_txtbox.Name = "password_txtbox";
            this.password_txtbox.Size = new System.Drawing.Size(394, 49);
            this.password_txtbox.TabIndex = 13;
            this.password_txtbox.UseSystemPasswordChar = true;
            // 
            // userName_txtbox
            // 
            this.userName_txtbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.userName_txtbox.Font = new System.Drawing.Font("Sitka Subheading", 18.27692F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.userName_txtbox.Location = new System.Drawing.Point(287, 187);
            this.userName_txtbox.Name = "userName_txtbox";
            this.userName_txtbox.Size = new System.Drawing.Size(394, 49);
            this.userName_txtbox.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Subheading", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.SeaGreen;
            this.label1.Location = new System.Drawing.Point(264, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 79);
            this.label1.TabIndex = 12;
            this.label1.Text = "Login";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_add
            // 
            this.btn_add.ActiveBorderThickness = 1;
            this.btn_add.ActiveCornerRadius = 20;
            this.btn_add.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btn_add.ActiveForecolor = System.Drawing.Color.White;
            this.btn_add.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btn_add.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_add.BackColor = System.Drawing.SystemColors.Control;
            this.btn_add.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_add.BackgroundImage")));
            this.btn_add.ButtonText = "Log In";
            this.btn_add.Font = new System.Drawing.Font("Century Gothic", 13.84615F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_add.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_add.IdleBorderThickness = 1;
            this.btn_add.IdleCornerRadius = 20;
            this.btn_add.IdleFillColor = System.Drawing.Color.White;
            this.btn_add.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btn_add.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btn_add.Location = new System.Drawing.Point(158, 421);
            this.btn_add.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(410, 66);
            this.btn_add.TabIndex = 15;
            this.btn_add.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // bunifuImageButton3
            // 
            this.bunifuImageButton3.ActiveImage = null;
            this.bunifuImageButton3.AllowAnimations = true;
            this.bunifuImageButton3.AllowBuffering = false;
            this.bunifuImageButton3.AllowToggling = false;
            this.bunifuImageButton3.AllowZooming = true;
            this.bunifuImageButton3.AllowZoomingOnFocus = false;
            this.bunifuImageButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButton3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton3.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuImageButton3.ErrorImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton3.ErrorImage")));
            this.bunifuImageButton3.FadeWhenInactive = false;
            this.bunifuImageButton3.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.bunifuImageButton3.Image = global::Library_Management_System.Properties.Resources.minimize_window_64px;
            this.bunifuImageButton3.ImageActive = null;
            this.bunifuImageButton3.ImageLocation = null;
            this.bunifuImageButton3.ImageMargin = 20;
            this.bunifuImageButton3.ImageSize = new System.Drawing.Size(45, 45);
            this.bunifuImageButton3.ImageZoomSize = new System.Drawing.Size(65, 65);
            this.bunifuImageButton3.InitialImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton3.InitialImage")));
            this.bunifuImageButton3.Location = new System.Drawing.Point(579, 12);
            this.bunifuImageButton3.Name = "bunifuImageButton3";
            this.bunifuImageButton3.Rotation = 0;
            this.bunifuImageButton3.ShowActiveImage = true;
            this.bunifuImageButton3.ShowCursorChanges = true;
            this.bunifuImageButton3.ShowImageBorders = true;
            this.bunifuImageButton3.ShowSizeMarkers = false;
            this.bunifuImageButton3.Size = new System.Drawing.Size(65, 65);
            this.bunifuImageButton3.TabIndex = 16;
            this.bunifuImageButton3.ToolTipText = "";
            this.bunifuImageButton3.WaitOnLoad = false;
            this.bunifuImageButton3.Zoom = 20;
            this.bunifuImageButton3.ZoomSpeed = 10;
            this.bunifuImageButton3.Click += new System.EventHandler(this.bunifuImageButton3_Click_1);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 605);
            this.Controls.Add(this.bunifuImageButton3);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.password_txt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.username_txt);
            this.Controls.Add(this.password_txtbox);
            this.Controls.Add(this.userName_txtbox);
            this.Controls.Add(this.bunifuImageButton1);
            this.Font = new System.Drawing.Font("Segoe UI", 12.18462F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.UI.WinForms.BunifuImageButton bunifuImageButton1;
        private Label password_txt;
        private Label username_txt;
        public TextBox password_txtbox;
        public TextBox userName_txtbox;
        private Label label1;
        public Bunifu.Framework.UI.BunifuThinButton2 btn_add;
        private Bunifu.UI.WinForms.BunifuImageButton bunifuImageButton3;
    }
}