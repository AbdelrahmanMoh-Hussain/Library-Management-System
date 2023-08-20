namespace Library_Management_System.Presentation_Layer
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            Bunifu.UI.WinForms.BunifuAnimatorNS.Animation animation1 = new Bunifu.UI.WinForms.BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainBar = new System.Windows.Forms.Panel();
            this.name_label = new System.Windows.Forms.Label();
            this.perm_label = new System.Windows.Forms.Label();
            this.cat_btn = new System.Windows.Forms.Button();
            this.users_btn = new System.Windows.Forms.Button();
            this.trans_btn = new System.Windows.Forms.Button();
            this.books_btn = new System.Windows.Forms.Button();
            this.bunifuImageButton6 = new Bunifu.UI.WinForms.BunifuImageButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.home_btn = new System.Windows.Forms.Button();
            this.bunifuImageButton5 = new Bunifu.UI.WinForms.BunifuImageButton();
            this.bunifuImageButton4 = new Bunifu.UI.WinForms.BunifuImageButton();
            this.TitleBar = new System.Windows.Forms.Panel();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.bunifuImageButton3 = new Bunifu.UI.WinForms.BunifuImageButton();
            this.bunifuImageButton2 = new Bunifu.UI.WinForms.BunifuImageButton();
            this.bunifuImageButton1 = new Bunifu.UI.WinForms.BunifuImageButton();
            this.Home = new System.Windows.Forms.Panel();
            this.button11 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
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
            this.Main = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.bunifuThinButton24 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton23 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton22 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Container = new System.Windows.Forms.Panel();
            this.bunifuTransition1 = new Bunifu.UI.WinForms.BunifuTransition(this.components);
            this.MainBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.TitleBar.SuspendLayout();
            this.Home.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.Main.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel7.SuspendLayout();
            this.Container.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainBar
            // 
            this.MainBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(43)))), ((int)(((byte)(72)))));
            this.MainBar.Controls.Add(this.name_label);
            this.MainBar.Controls.Add(this.perm_label);
            this.MainBar.Controls.Add(this.cat_btn);
            this.MainBar.Controls.Add(this.users_btn);
            this.MainBar.Controls.Add(this.trans_btn);
            this.MainBar.Controls.Add(this.books_btn);
            this.MainBar.Controls.Add(this.bunifuImageButton6);
            this.MainBar.Controls.Add(this.pictureBox1);
            this.MainBar.Controls.Add(this.home_btn);
            this.MainBar.Controls.Add(this.bunifuImageButton5);
            this.MainBar.Controls.Add(this.bunifuImageButton4);
            this.bunifuTransition1.SetDecoration(this.MainBar, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.MainBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.MainBar.Location = new System.Drawing.Point(0, 0);
            this.MainBar.Name = "MainBar";
            this.MainBar.Size = new System.Drawing.Size(256, 730);
            this.MainBar.TabIndex = 0;
            // 
            // name_label
            // 
            this.name_label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.name_label.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.name_label, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.name_label.Font = new System.Drawing.Font("Sylfaen", 12.18462F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.name_label.ForeColor = System.Drawing.Color.White;
            this.name_label.Location = new System.Drawing.Point(76, 163);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(72, 29);
            this.name_label.TabIndex = 0;
            this.name_label.Text = "name";
            // 
            // perm_label
            // 
            this.perm_label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.perm_label.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.perm_label, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.perm_label.Font = new System.Drawing.Font("Sylfaen", 12.18462F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.perm_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(233)))), ((int)(((byte)(135)))));
            this.perm_label.Location = new System.Drawing.Point(125, 192);
            this.perm_label.Name = "perm_label";
            this.perm_label.Size = new System.Drawing.Size(71, 29);
            this.perm_label.TabIndex = 0;
            this.perm_label.Text = "Perm";
            // 
            // cat_btn
            // 
            this.cat_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(43)))), ((int)(((byte)(72)))));
            this.bunifuTransition1.SetDecoration(this.cat_btn, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.cat_btn.FlatAppearance.BorderSize = 0;
            this.cat_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cat_btn.ForeColor = System.Drawing.Color.White;
            this.cat_btn.Image = global::Library_Management_System.Properties.Resources.categorize_40px;
            this.cat_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cat_btn.Location = new System.Drawing.Point(0, 468);
            this.cat_btn.Name = "cat_btn";
            this.cat_btn.Size = new System.Drawing.Size(251, 50);
            this.cat_btn.TabIndex = 11;
            this.cat_btn.Text = "Categories";
            this.cat_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cat_btn.UseVisualStyleBackColor = false;
            this.cat_btn.Click += new System.EventHandler(this.button12_Click);
            // 
            // users_btn
            // 
            this.users_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(43)))), ((int)(((byte)(72)))));
            this.bunifuTransition1.SetDecoration(this.users_btn, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.users_btn.FlatAppearance.BorderSize = 0;
            this.users_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.users_btn.ForeColor = System.Drawing.Color.White;
            this.users_btn.Image = global::Library_Management_System.Properties.Resources.user_filled_40px;
            this.users_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.users_btn.Location = new System.Drawing.Point(0, 392);
            this.users_btn.Name = "users_btn";
            this.users_btn.Size = new System.Drawing.Size(247, 50);
            this.users_btn.TabIndex = 10;
            this.users_btn.Text = "Users";
            this.users_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.users_btn.UseVisualStyleBackColor = false;
            this.users_btn.Click += new System.EventHandler(this.button6_Click);
            // 
            // trans_btn
            // 
            this.trans_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(43)))), ((int)(((byte)(72)))));
            this.bunifuTransition1.SetDecoration(this.trans_btn, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.trans_btn.FlatAppearance.BorderSize = 0;
            this.trans_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.trans_btn.ForeColor = System.Drawing.Color.White;
            this.trans_btn.Image = global::Library_Management_System.Properties.Resources.sell_40px;
            this.trans_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.trans_btn.Location = new System.Drawing.Point(0, 544);
            this.trans_btn.Name = "trans_btn";
            this.trans_btn.Size = new System.Drawing.Size(247, 50);
            this.trans_btn.TabIndex = 8;
            this.trans_btn.Text = "Transactions     ";
            this.trans_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.trans_btn.UseVisualStyleBackColor = false;
            this.trans_btn.Click += new System.EventHandler(this.button4_Click);
            // 
            // books_btn
            // 
            this.books_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(43)))), ((int)(((byte)(72)))));
            this.bunifuTransition1.SetDecoration(this.books_btn, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.books_btn.FlatAppearance.BorderSize = 0;
            this.books_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.books_btn.ForeColor = System.Drawing.Color.White;
            this.books_btn.Image = global::Library_Management_System.Properties.Resources.books_40px;
            this.books_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.books_btn.Location = new System.Drawing.Point(0, 316);
            this.books_btn.Name = "books_btn";
            this.books_btn.Size = new System.Drawing.Size(247, 50);
            this.books_btn.TabIndex = 6;
            this.books_btn.Text = "Books";
            this.books_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.books_btn.UseVisualStyleBackColor = false;
            this.books_btn.Click += new System.EventHandler(this.button2_Click);
            // 
            // bunifuImageButton6
            // 
            this.bunifuImageButton6.ActiveImage = null;
            this.bunifuImageButton6.AllowAnimations = true;
            this.bunifuImageButton6.AllowBuffering = false;
            this.bunifuImageButton6.AllowToggling = false;
            this.bunifuImageButton6.AllowZooming = true;
            this.bunifuImageButton6.AllowZoomingOnFocus = false;
            this.bunifuImageButton6.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.bunifuImageButton6, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuImageButton6.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuImageButton6.ErrorImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton6.ErrorImage")));
            this.bunifuImageButton6.FadeWhenInactive = false;
            this.bunifuImageButton6.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.bunifuImageButton6.Image = global::Library_Management_System.Properties.Resources.collapse_40px;
            this.bunifuImageButton6.ImageActive = null;
            this.bunifuImageButton6.ImageLocation = null;
            this.bunifuImageButton6.ImageMargin = 20;
            this.bunifuImageButton6.ImageSize = new System.Drawing.Size(45, 45);
            this.bunifuImageButton6.ImageZoomSize = new System.Drawing.Size(65, 65);
            this.bunifuImageButton6.InitialImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton6.InitialImage")));
            this.bunifuImageButton6.Location = new System.Drawing.Point(0, 9);
            this.bunifuImageButton6.Name = "bunifuImageButton6";
            this.bunifuImageButton6.Rotation = 0;
            this.bunifuImageButton6.ShowActiveImage = true;
            this.bunifuImageButton6.ShowCursorChanges = true;
            this.bunifuImageButton6.ShowImageBorders = true;
            this.bunifuImageButton6.ShowSizeMarkers = false;
            this.bunifuImageButton6.Size = new System.Drawing.Size(65, 65);
            this.bunifuImageButton6.TabIndex = 5;
            this.bunifuImageButton6.ToolTipText = "";
            this.bunifuImageButton6.WaitOnLoad = false;
            this.bunifuImageButton6.Zoom = 20;
            this.bunifuImageButton6.ZoomSpeed = 10;
            this.bunifuImageButton6.Click += new System.EventHandler(this.bunifuImageButton6_Click);
            // 
            // pictureBox1
            // 
            this.bunifuTransition1.SetDecoration(this.pictureBox1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.pictureBox1.Image = global::Library_Management_System.Properties.Resources._236831;
            this.pictureBox1.Location = new System.Drawing.Point(63, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(173, 151);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // home_btn
            // 
            this.home_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(43)))), ((int)(((byte)(72)))));
            this.bunifuTransition1.SetDecoration(this.home_btn, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.home_btn.FlatAppearance.BorderSize = 0;
            this.home_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.home_btn.ForeColor = System.Drawing.Color.White;
            this.home_btn.Image = global::Library_Management_System.Properties.Resources.home_filled_40px;
            this.home_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.home_btn.Location = new System.Drawing.Point(0, 240);
            this.home_btn.Name = "home_btn";
            this.home_btn.Size = new System.Drawing.Size(247, 50);
            this.home_btn.TabIndex = 0;
            this.home_btn.Text = "Home";
            this.home_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.home_btn.UseVisualStyleBackColor = false;
            this.home_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // bunifuImageButton5
            // 
            this.bunifuImageButton5.ActiveImage = null;
            this.bunifuImageButton5.AllowAnimations = true;
            this.bunifuImageButton5.AllowBuffering = false;
            this.bunifuImageButton5.AllowToggling = false;
            this.bunifuImageButton5.AllowZooming = true;
            this.bunifuImageButton5.AllowZoomingOnFocus = false;
            this.bunifuImageButton5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bunifuImageButton5.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.bunifuImageButton5, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuImageButton5.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuImageButton5.ErrorImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton5.ErrorImage")));
            this.bunifuImageButton5.FadeWhenInactive = false;
            this.bunifuImageButton5.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.bunifuImageButton5.Image = global::Library_Management_System.Properties.Resources.lock_100px;
            this.bunifuImageButton5.ImageActive = null;
            this.bunifuImageButton5.ImageLocation = null;
            this.bunifuImageButton5.ImageMargin = 20;
            this.bunifuImageButton5.ImageSize = new System.Drawing.Size(45, 45);
            this.bunifuImageButton5.ImageZoomSize = new System.Drawing.Size(65, 65);
            this.bunifuImageButton5.InitialImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton5.InitialImage")));
            this.bunifuImageButton5.Location = new System.Drawing.Point(3, 636);
            this.bunifuImageButton5.Name = "bunifuImageButton5";
            this.bunifuImageButton5.Rotation = 0;
            this.bunifuImageButton5.ShowActiveImage = true;
            this.bunifuImageButton5.ShowCursorChanges = true;
            this.bunifuImageButton5.ShowImageBorders = true;
            this.bunifuImageButton5.ShowSizeMarkers = false;
            this.bunifuImageButton5.Size = new System.Drawing.Size(65, 65);
            this.bunifuImageButton5.TabIndex = 4;
            this.bunifuImageButton5.ToolTipText = "";
            this.bunifuImageButton5.WaitOnLoad = false;
            this.bunifuImageButton5.Zoom = 20;
            this.bunifuImageButton5.ZoomSpeed = 10;
            this.bunifuImageButton5.Click += new System.EventHandler(this.bunifuImageButton5_Click);
            // 
            // bunifuImageButton4
            // 
            this.bunifuImageButton4.ActiveImage = null;
            this.bunifuImageButton4.AllowAnimations = true;
            this.bunifuImageButton4.AllowBuffering = false;
            this.bunifuImageButton4.AllowToggling = false;
            this.bunifuImageButton4.AllowZooming = true;
            this.bunifuImageButton4.AllowZoomingOnFocus = false;
            this.bunifuImageButton4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bunifuImageButton4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.bunifuImageButton4, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuImageButton4.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuImageButton4.ErrorImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton4.ErrorImage")));
            this.bunifuImageButton4.FadeWhenInactive = false;
            this.bunifuImageButton4.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.bunifuImageButton4.Image = global::Library_Management_System.Properties.Resources.info_64px;
            this.bunifuImageButton4.ImageActive = null;
            this.bunifuImageButton4.ImageLocation = null;
            this.bunifuImageButton4.ImageMargin = 20;
            this.bunifuImageButton4.ImageSize = new System.Drawing.Size(45, 45);
            this.bunifuImageButton4.ImageZoomSize = new System.Drawing.Size(65, 65);
            this.bunifuImageButton4.InitialImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton4.InitialImage")));
            this.bunifuImageButton4.Location = new System.Drawing.Point(131, 636);
            this.bunifuImageButton4.Name = "bunifuImageButton4";
            this.bunifuImageButton4.Rotation = 0;
            this.bunifuImageButton4.ShowActiveImage = true;
            this.bunifuImageButton4.ShowCursorChanges = true;
            this.bunifuImageButton4.ShowImageBorders = true;
            this.bunifuImageButton4.ShowSizeMarkers = false;
            this.bunifuImageButton4.Size = new System.Drawing.Size(65, 65);
            this.bunifuImageButton4.TabIndex = 3;
            this.bunifuImageButton4.ToolTipText = "";
            this.bunifuImageButton4.WaitOnLoad = false;
            this.bunifuImageButton4.Zoom = 20;
            this.bunifuImageButton4.ZoomSpeed = 10;
            this.bunifuImageButton4.Click += new System.EventHandler(this.bunifuImageButton4_Click);
            // 
            // TitleBar
            // 
            this.TitleBar.Controls.Add(this.TitleLabel);
            this.TitleBar.Controls.Add(this.bunifuImageButton3);
            this.TitleBar.Controls.Add(this.bunifuImageButton2);
            this.TitleBar.Controls.Add(this.bunifuImageButton1);
            this.bunifuTransition1.SetDecoration(this.TitleBar, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.TitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleBar.Location = new System.Drawing.Point(256, 0);
            this.TitleBar.Name = "TitleBar";
            this.TitleBar.Size = new System.Drawing.Size(980, 68);
            this.TitleBar.TabIndex = 1;
            // 
            // TitleLabel
            // 
            this.TitleLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TitleLabel.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.TitleLabel, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.TitleLabel.Font = new System.Drawing.Font("Stencil", 16.06154F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TitleLabel.Location = new System.Drawing.Point(418, 9);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(98, 35);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Home";
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
            this.bunifuTransition1.SetDecoration(this.bunifuImageButton3, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
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
            this.bunifuImageButton3.Location = new System.Drawing.Point(771, 1);
            this.bunifuImageButton3.Name = "bunifuImageButton3";
            this.bunifuImageButton3.Rotation = 0;
            this.bunifuImageButton3.ShowActiveImage = true;
            this.bunifuImageButton3.ShowCursorChanges = true;
            this.bunifuImageButton3.ShowImageBorders = true;
            this.bunifuImageButton3.ShowSizeMarkers = false;
            this.bunifuImageButton3.Size = new System.Drawing.Size(65, 65);
            this.bunifuImageButton3.TabIndex = 2;
            this.bunifuImageButton3.ToolTipText = "";
            this.bunifuImageButton3.WaitOnLoad = false;
            this.bunifuImageButton3.Zoom = 20;
            this.bunifuImageButton3.ZoomSpeed = 10;
            this.bunifuImageButton3.Click += new System.EventHandler(this.bunifuImageButton3_Click);
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.ActiveImage = null;
            this.bunifuImageButton2.AllowAnimations = true;
            this.bunifuImageButton2.AllowBuffering = false;
            this.bunifuImageButton2.AllowToggling = false;
            this.bunifuImageButton2.AllowZooming = true;
            this.bunifuImageButton2.AllowZoomingOnFocus = false;
            this.bunifuImageButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.bunifuImageButton2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuImageButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuImageButton2.ErrorImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.ErrorImage")));
            this.bunifuImageButton2.FadeWhenInactive = false;
            this.bunifuImageButton2.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.bunifuImageButton2.Image = global::Library_Management_System.Properties.Resources.maximize_window_40px;
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.ImageLocation = null;
            this.bunifuImageButton2.ImageMargin = 20;
            this.bunifuImageButton2.ImageSize = new System.Drawing.Size(45, 45);
            this.bunifuImageButton2.ImageZoomSize = new System.Drawing.Size(65, 65);
            this.bunifuImageButton2.InitialImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.InitialImage")));
            this.bunifuImageButton2.Location = new System.Drawing.Point(842, 1);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Rotation = 0;
            this.bunifuImageButton2.ShowActiveImage = true;
            this.bunifuImageButton2.ShowCursorChanges = true;
            this.bunifuImageButton2.ShowImageBorders = true;
            this.bunifuImageButton2.ShowSizeMarkers = false;
            this.bunifuImageButton2.Size = new System.Drawing.Size(65, 65);
            this.bunifuImageButton2.TabIndex = 1;
            this.bunifuImageButton2.ToolTipText = "";
            this.bunifuImageButton2.WaitOnLoad = false;
            this.bunifuImageButton2.Zoom = 20;
            this.bunifuImageButton2.ZoomSpeed = 10;
            this.bunifuImageButton2.Click += new System.EventHandler(this.bunifuImageButton2_Click);
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
            this.bunifuTransition1.SetDecoration(this.bunifuImageButton1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
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
            this.bunifuImageButton1.Location = new System.Drawing.Point(913, 0);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Rotation = 0;
            this.bunifuImageButton1.ShowActiveImage = true;
            this.bunifuImageButton1.ShowCursorChanges = true;
            this.bunifuImageButton1.ShowImageBorders = true;
            this.bunifuImageButton1.ShowSizeMarkers = false;
            this.bunifuImageButton1.Size = new System.Drawing.Size(65, 65);
            this.bunifuImageButton1.TabIndex = 0;
            this.bunifuImageButton1.ToolTipText = "";
            this.bunifuImageButton1.WaitOnLoad = false;
            this.bunifuImageButton1.Zoom = 20;
            this.bunifuImageButton1.ZoomSpeed = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // Home
            // 
            this.Home.Controls.Add(this.button11);
            this.Home.Controls.Add(this.button9);
            this.Home.Controls.Add(this.button7);
            this.Home.Controls.Add(this.panel4);
            this.Home.Controls.Add(this.panel3);
            this.Home.Controls.Add(this.panel2);
            this.Home.Controls.Add(this.panel6);
            this.bunifuTransition1.SetDecoration(this.Home, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.Home.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Home.Font = new System.Drawing.Font("Mistral", 13.84615F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Home.Location = new System.Drawing.Point(0, 0);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(980, 662);
            this.Home.TabIndex = 2;
            // 
            // button11
            // 
            this.button11.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(154)))), ((int)(((byte)(139)))));
            this.bunifuTransition1.SetDecoration(this.button11, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Stencil", 12.18462F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button11.ForeColor = System.Drawing.Color.White;
            this.button11.Image = global::Library_Management_System.Properties.Resources.add_64px;
            this.button11.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button11.Location = new System.Drawing.Point(685, 518);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(228, 101);
            this.button11.TabIndex = 12;
            this.button11.Text = "Add Category";
            this.button11.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button10_Click);
            // 
            // button9
            // 
            this.button9.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(154)))), ((int)(((byte)(139)))));
            this.bunifuTransition1.SetDecoration(this.button9, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Stencil", 12.18462F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Image = global::Library_Management_System.Properties.Resources.add_64px;
            this.button9.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button9.Location = new System.Drawing.Point(399, 518);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(228, 101);
            this.button9.TabIndex = 12;
            this.button9.Text = "Add Transaction";
            this.button9.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button7
            // 
            this.button7.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(154)))), ((int)(((byte)(139)))));
            this.bunifuTransition1.SetDecoration(this.button7, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Stencil", 12.18462F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Image = global::Library_Management_System.Properties.Resources.add_64px;
            this.button7.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button7.Location = new System.Drawing.Point(113, 518);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(228, 101);
            this.button7.TabIndex = 11;
            this.button7.Text = "Add Book";
            this.button7.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(80)))), ((int)(((byte)(105)))));
            this.panel4.Controls.Add(this.userCount_label);
            this.panel4.Controls.Add(this.label9);
            this.bunifuTransition1.SetDecoration(this.panel4, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panel4.Location = new System.Drawing.Point(526, 274);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(307, 203);
            this.panel4.TabIndex = 8;
            // 
            // userCount_label
            // 
            this.userCount_label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.userCount_label.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.userCount_label, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.userCount_label.Font = new System.Drawing.Font("Stencil", 18.27692F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userCount_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(233)))), ((int)(((byte)(135)))));
            this.userCount_label.Location = new System.Drawing.Point(128, 110);
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
            this.bunifuTransition1.SetDecoration(this.label9, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.label9.Font = new System.Drawing.Font("Stencil", 16.06154F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(86, 42);
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
            this.bunifuTransition1.SetDecoration(this.panel3, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panel3.Location = new System.Drawing.Point(526, 52);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(307, 203);
            this.panel3.TabIndex = 5;
            // 
            // transCount_label
            // 
            this.transCount_label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.transCount_label.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.transCount_label, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.transCount_label.Font = new System.Drawing.Font("Stencil", 18.27692F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.transCount_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(233)))), ((int)(((byte)(135)))));
            this.transCount_label.Location = new System.Drawing.Point(128, 110);
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
            this.bunifuTransition1.SetDecoration(this.label12, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.label12.Font = new System.Drawing.Font("Stencil", 16.06154F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(27, 51);
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
            this.bunifuTransition1.SetDecoration(this.panel2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panel2.Location = new System.Drawing.Point(163, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(307, 203);
            this.panel2.TabIndex = 5;
            // 
            // bookCount_label
            // 
            this.bookCount_label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bookCount_label.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.bookCount_label, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bookCount_label.Font = new System.Drawing.Font("Stencil", 18.27692F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bookCount_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(233)))), ((int)(((byte)(135)))));
            this.bookCount_label.Location = new System.Drawing.Point(130, 110);
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
            this.bunifuTransition1.SetDecoration(this.label5, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.label5.Font = new System.Drawing.Font("Stencil", 16.06154F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(83, 51);
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
            this.bunifuTransition1.SetDecoration(this.panel6, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panel6.Location = new System.Drawing.Point(163, 274);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(307, 203);
            this.panel6.TabIndex = 6;
            // 
            // catCount_label
            // 
            this.catCount_label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.catCount_label.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.catCount_label, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
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
            this.bunifuTransition1.SetDecoration(this.label13, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.label13.Font = new System.Drawing.Font("Stencil", 16.06154F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(46, 42);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(219, 35);
            this.label13.TabIndex = 3;
            this.label13.Text = "# Categories";
            // 
            // Main
            // 
            this.Main.Controls.Add(this.panel8);
            this.Main.Controls.Add(this.dataGridView1);
            this.Main.Controls.Add(this.panel7);
            this.bunifuTransition1.SetDecoration(this.Main, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main.Location = new System.Drawing.Point(0, 0);
            this.Main.Name = "Main";
            this.Main.Size = new System.Drawing.Size(980, 662);
            this.Main.TabIndex = 0;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.bunifuThinButton24);
            this.panel8.Controls.Add(this.bunifuThinButton23);
            this.panel8.Controls.Add(this.bunifuThinButton22);
            this.panel8.Controls.Add(this.bunifuThinButton21);
            this.bunifuTransition1.SetDecoration(this.panel8, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel8.Location = new System.Drawing.Point(0, 559);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(980, 103);
            this.panel8.TabIndex = 1;
            // 
            // bunifuThinButton24
            // 
            this.bunifuThinButton24.ActiveBorderThickness = 1;
            this.bunifuThinButton24.ActiveCornerRadius = 20;
            this.bunifuThinButton24.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton24.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton24.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton24.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bunifuThinButton24.BackColor = System.Drawing.Color.White;
            this.bunifuThinButton24.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton24.BackgroundImage")));
            this.bunifuThinButton24.ButtonText = "Show Info";
            this.bunifuTransition1.SetDecoration(this.bunifuThinButton24, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuThinButton24.Font = new System.Drawing.Font("Century Gothic", 13.84615F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bunifuThinButton24.ForeColor = System.Drawing.Color.SlateGray;
            this.bunifuThinButton24.IdleBorderThickness = 1;
            this.bunifuThinButton24.IdleCornerRadius = 20;
            this.bunifuThinButton24.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton24.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton24.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton24.Location = new System.Drawing.Point(721, 26);
            this.bunifuThinButton24.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.bunifuThinButton24.Name = "bunifuThinButton24";
            this.bunifuThinButton24.Size = new System.Drawing.Size(183, 48);
            this.bunifuThinButton24.TabIndex = 0;
            this.bunifuThinButton24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton24.Click += new System.EventHandler(this.bunifuThinButton24_Click);
            // 
            // bunifuThinButton23
            // 
            this.bunifuThinButton23.ActiveBorderThickness = 1;
            this.bunifuThinButton23.ActiveCornerRadius = 20;
            this.bunifuThinButton23.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton23.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton23.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton23.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bunifuThinButton23.BackColor = System.Drawing.Color.White;
            this.bunifuThinButton23.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton23.BackgroundImage")));
            this.bunifuThinButton23.ButtonText = "Delete";
            this.bunifuTransition1.SetDecoration(this.bunifuThinButton23, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuThinButton23.Font = new System.Drawing.Font("Century Gothic", 13.84615F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bunifuThinButton23.ForeColor = System.Drawing.Color.Sienna;
            this.bunifuThinButton23.IdleBorderThickness = 1;
            this.bunifuThinButton23.IdleCornerRadius = 20;
            this.bunifuThinButton23.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton23.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton23.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton23.Location = new System.Drawing.Point(510, 26);
            this.bunifuThinButton23.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.bunifuThinButton23.Name = "bunifuThinButton23";
            this.bunifuThinButton23.Size = new System.Drawing.Size(183, 48);
            this.bunifuThinButton23.TabIndex = 0;
            this.bunifuThinButton23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton23.Click += new System.EventHandler(this.bunifuThinButton23_Click);
            // 
            // bunifuThinButton22
            // 
            this.bunifuThinButton22.ActiveBorderThickness = 1;
            this.bunifuThinButton22.ActiveCornerRadius = 20;
            this.bunifuThinButton22.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton22.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton22.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton22.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bunifuThinButton22.BackColor = System.Drawing.Color.White;
            this.bunifuThinButton22.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton22.BackgroundImage")));
            this.bunifuThinButton22.ButtonText = "Update";
            this.bunifuTransition1.SetDecoration(this.bunifuThinButton22, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuThinButton22.Font = new System.Drawing.Font("Century Gothic", 13.84615F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bunifuThinButton22.ForeColor = System.Drawing.Color.SteelBlue;
            this.bunifuThinButton22.IdleBorderThickness = 1;
            this.bunifuThinButton22.IdleCornerRadius = 20;
            this.bunifuThinButton22.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton22.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton22.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton22.Location = new System.Drawing.Point(299, 26);
            this.bunifuThinButton22.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.bunifuThinButton22.Name = "bunifuThinButton22";
            this.bunifuThinButton22.Size = new System.Drawing.Size(183, 48);
            this.bunifuThinButton22.TabIndex = 0;
            this.bunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton22.Click += new System.EventHandler(this.bunifuThinButton22_Click);
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bunifuThinButton21.BackColor = System.Drawing.Color.White;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Add";
            this.bunifuTransition1.SetDecoration(this.bunifuThinButton21, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 13.84615F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.Location = new System.Drawing.Point(88, 26);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(183, 48);
            this.bunifuThinButton21.TabIndex = 0;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Stencil", 13.84615F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuTransition1.SetDecoration(this.dataGridView1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Stencil", 13.84615F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView1.Location = new System.Drawing.Point(0, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 56;
            this.dataGridView1.RowTemplate.Height = 31;
            this.dataGridView1.Size = new System.Drawing.Size(980, 606);
            this.dataGridView1.TabIndex = 2;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.label1);
            this.panel7.Controls.Add(this.textBox1);
            this.bunifuTransition1.SetDecoration(this.panel7, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(980, 56);
            this.panel7.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 9.969231F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(20, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search";
            // 
            // textBox1
            // 
            this.bunifuTransition1.SetDecoration(this.textBox1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.textBox1.Location = new System.Drawing.Point(97, 9);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(347, 37);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Container
            // 
            this.Container.Controls.Add(this.Home);
            this.Container.Controls.Add(this.Main);
            this.bunifuTransition1.SetDecoration(this.Container, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.Container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Container.Location = new System.Drawing.Point(256, 68);
            this.Container.Name = "Container";
            this.Container.Size = new System.Drawing.Size(980, 662);
            this.Container.TabIndex = 13;
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = Bunifu.UI.WinForms.BunifuAnimatorNS.AnimationType.Scale;
            this.bunifuTransition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.bunifuTransition1.DefaultAnimation = animation1;
            this.bunifuTransition1.Interval = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1236, 730);
            this.Controls.Add(this.Container);
            this.Controls.Add(this.TitleBar);
            this.Controls.Add(this.MainBar);
            this.bunifuTransition1.SetDecoration(this, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.Font = new System.Drawing.Font("Stencil", 13.84615F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MainBar.ResumeLayout(false);
            this.MainBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.TitleBar.ResumeLayout(false);
            this.TitleBar.PerformLayout();
            this.Home.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.Main.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.Container.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel MainBar;
        private Panel TitleBar;
        private Panel Home;
        private Panel Main;
        private Bunifu.UI.WinForms.BunifuImageButton bunifuImageButton5;
        private Bunifu.UI.WinForms.BunifuImageButton bunifuImageButton4;
        private Label TitleLabel;
        private Bunifu.UI.WinForms.BunifuImageButton bunifuImageButton3;
        private Bunifu.UI.WinForms.BunifuImageButton bunifuImageButton2;
        private Bunifu.UI.WinForms.BunifuImageButton bunifuImageButton1;
        private PictureBox pictureBox1;
        private Button home_btn;
        private Bunifu.UI.WinForms.BunifuImageButton bunifuImageButton6;
        private Button users_btn;
        private Button trans_btn;
        private Button books_btn;
        private Panel panel4;
        private Label label9;
        private Panel panel3;
        private Label label12;
        private Panel panel2;
        private Label label5;
        private Panel panel6;
        private Label label13;
        private Button button9;
        private Button button7;
        private Button button11;
        private DataGridView dataGridView1;
        private Panel panel8;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton24;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton23;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton22;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private Panel Container;
        private Button cat_btn;
        private Bunifu.UI.WinForms.BunifuTransition bunifuTransition1;
        private Panel panel7;
        private Label label1;
        private TextBox textBox1;
        public Label name_label;
        public Label perm_label;
        public Label userCount_label;
        public Label transCount_label;
        public Label bookCount_label;
        public Label catCount_label;
    }
}