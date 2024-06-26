
namespace WindowsFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btn_GST_User = new System.Windows.Forms.Button();
            this.btn_Ajt_User = new System.Windows.Forms.Button();
            this.btn_GST_Fac = new System.Windows.Forms.Button();
            this.btn_OutService = new System.Windows.Forms.Button();
            this.btn_User_Logout = new System.Windows.Forms.Button();
            this.btn_GST_reservation = new System.Windows.Forms.Button();
            this.btn_Ajt_Reservation = new System.Windows.Forms.Button();
            this.btn_GST_Chambre = new System.Windows.Forms.Button();
            this.btn_Ajt_Chambre = new System.Windows.Forms.Button();
            this.btn_GST_CLT = new System.Windows.Forms.Button();
            this.btn_AjtCLT = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.labelLOGO = new System.Windows.Forms.Label();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_gesreserv = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.btn_gesreserv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.btn_GST_User);
            this.panelMenu.Controls.Add(this.btn_Ajt_User);
            this.panelMenu.Controls.Add(this.btn_GST_Fac);
            this.panelMenu.Controls.Add(this.btn_OutService);
            this.panelMenu.Controls.Add(this.btn_User_Logout);
            this.panelMenu.Controls.Add(this.btn_GST_reservation);
            this.panelMenu.Controls.Add(this.btn_Ajt_Reservation);
            this.panelMenu.Controls.Add(this.btn_GST_Chambre);
            this.panelMenu.Controls.Add(this.btn_Ajt_Chambre);
            this.panelMenu.Controls.Add(this.btn_GST_CLT);
            this.panelMenu.Controls.Add(this.btn_AjtCLT);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(262, 761);
            this.panelMenu.TabIndex = 0;
            // 
            // btn_GST_User
            // 
            this.btn_GST_User.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_GST_User.FlatAppearance.BorderSize = 0;
            this.btn_GST_User.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_GST_User.ForeColor = System.Drawing.Color.White;
            this.btn_GST_User.Image = ((System.Drawing.Image)(resources.GetObject("btn_GST_User.Image")));
            this.btn_GST_User.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_GST_User.Location = new System.Drawing.Point(0, 578);
            this.btn_GST_User.Margin = new System.Windows.Forms.Padding(2);
            this.btn_GST_User.Name = "btn_GST_User";
            this.btn_GST_User.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.btn_GST_User.Size = new System.Drawing.Size(262, 57);
            this.btn_GST_User.TabIndex = 20;
            this.btn_GST_User.Text = "Gestion Des Utilisateur";
            this.btn_GST_User.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_GST_User.UseVisualStyleBackColor = true;
            this.btn_GST_User.Click += new System.EventHandler(this.btn_GST_User_Click);
            // 
            // btn_Ajt_User
            // 
            this.btn_Ajt_User.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Ajt_User.FlatAppearance.BorderSize = 0;
            this.btn_Ajt_User.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Ajt_User.ForeColor = System.Drawing.Color.White;
            this.btn_Ajt_User.Image = ((System.Drawing.Image)(resources.GetObject("btn_Ajt_User.Image")));
            this.btn_Ajt_User.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Ajt_User.Location = new System.Drawing.Point(0, 521);
            this.btn_Ajt_User.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Ajt_User.Name = "btn_Ajt_User";
            this.btn_Ajt_User.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.btn_Ajt_User.Size = new System.Drawing.Size(262, 57);
            this.btn_Ajt_User.TabIndex = 19;
            this.btn_Ajt_User.Text = "Ajouter un Nouveau Utilisateur";
            this.btn_Ajt_User.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Ajt_User.UseVisualStyleBackColor = true;
            this.btn_Ajt_User.Click += new System.EventHandler(this.btn_Ajt_User_Click);
            // 
            // btn_GST_Fac
            // 
            this.btn_GST_Fac.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_GST_Fac.FlatAppearance.BorderSize = 0;
            this.btn_GST_Fac.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_GST_Fac.ForeColor = System.Drawing.Color.White;
            this.btn_GST_Fac.Image = ((System.Drawing.Image)(resources.GetObject("btn_GST_Fac.Image")));
            this.btn_GST_Fac.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_GST_Fac.Location = new System.Drawing.Point(0, 464);
            this.btn_GST_Fac.Margin = new System.Windows.Forms.Padding(2);
            this.btn_GST_Fac.Name = "btn_GST_Fac";
            this.btn_GST_Fac.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.btn_GST_Fac.Size = new System.Drawing.Size(262, 57);
            this.btn_GST_Fac.TabIndex = 18;
            this.btn_GST_Fac.Text = "Gestion Des Ventes";
            this.btn_GST_Fac.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_GST_Fac.UseVisualStyleBackColor = true;
            this.btn_GST_Fac.Click += new System.EventHandler(this.btn_GST_Fac_Click);
            // 
            // btn_OutService
            // 
            this.btn_OutService.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_OutService.FlatAppearance.BorderSize = 0;
            this.btn_OutService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_OutService.ForeColor = System.Drawing.Color.White;
            this.btn_OutService.Image = ((System.Drawing.Image)(resources.GetObject("btn_OutService.Image")));
            this.btn_OutService.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_OutService.Location = new System.Drawing.Point(0, 407);
            this.btn_OutService.Margin = new System.Windows.Forms.Padding(2);
            this.btn_OutService.Name = "btn_OutService";
            this.btn_OutService.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.btn_OutService.Size = new System.Drawing.Size(262, 57);
            this.btn_OutService.TabIndex = 20;
            this.btn_OutService.Text = "Notre Service";
            this.btn_OutService.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_OutService.UseVisualStyleBackColor = true;
            this.btn_OutService.Click += new System.EventHandler(this.btn_OutService_Click);
            // 
            // btn_User_Logout
            // 
            this.btn_User_Logout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_User_Logout.FlatAppearance.BorderSize = 0;
            this.btn_User_Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_User_Logout.ForeColor = System.Drawing.Color.White;
            this.btn_User_Logout.Image = ((System.Drawing.Image)(resources.GetObject("btn_User_Logout.Image")));
            this.btn_User_Logout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_User_Logout.Location = new System.Drawing.Point(0, 704);
            this.btn_User_Logout.Margin = new System.Windows.Forms.Padding(2);
            this.btn_User_Logout.Name = "btn_User_Logout";
            this.btn_User_Logout.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.btn_User_Logout.Size = new System.Drawing.Size(262, 57);
            this.btn_User_Logout.TabIndex = 17;
            this.btn_User_Logout.Text = "Se déconnecter";
            this.btn_User_Logout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_User_Logout.UseVisualStyleBackColor = true;
            this.btn_User_Logout.Click += new System.EventHandler(this.btn_User_Logout_Click);
            // 
            // btn_GST_reservation
            // 
            this.btn_GST_reservation.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_GST_reservation.FlatAppearance.BorderSize = 0;
            this.btn_GST_reservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_GST_reservation.ForeColor = System.Drawing.Color.White;
            this.btn_GST_reservation.Image = ((System.Drawing.Image)(resources.GetObject("btn_GST_reservation.Image")));
            this.btn_GST_reservation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_GST_reservation.Location = new System.Drawing.Point(0, 350);
            this.btn_GST_reservation.Margin = new System.Windows.Forms.Padding(2);
            this.btn_GST_reservation.Name = "btn_GST_reservation";
            this.btn_GST_reservation.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.btn_GST_reservation.Size = new System.Drawing.Size(262, 57);
            this.btn_GST_reservation.TabIndex = 16;
            this.btn_GST_reservation.Text = "Gestion Des Reservation";
            this.btn_GST_reservation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_GST_reservation.UseVisualStyleBackColor = true;
            this.btn_GST_reservation.Click += new System.EventHandler(this.btn_GST_reservation_Click);
            // 
            // btn_Ajt_Reservation
            // 
            this.btn_Ajt_Reservation.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Ajt_Reservation.FlatAppearance.BorderSize = 0;
            this.btn_Ajt_Reservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Ajt_Reservation.ForeColor = System.Drawing.Color.White;
            this.btn_Ajt_Reservation.Image = ((System.Drawing.Image)(resources.GetObject("btn_Ajt_Reservation.Image")));
            this.btn_Ajt_Reservation.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btn_Ajt_Reservation.Location = new System.Drawing.Point(0, 293);
            this.btn_Ajt_Reservation.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Ajt_Reservation.Name = "btn_Ajt_Reservation";
            this.btn_Ajt_Reservation.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.btn_Ajt_Reservation.Size = new System.Drawing.Size(262, 57);
            this.btn_Ajt_Reservation.TabIndex = 15;
            this.btn_Ajt_Reservation.Text = "Ajouter une reservation";
            this.btn_Ajt_Reservation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Ajt_Reservation.UseVisualStyleBackColor = true;
            this.btn_Ajt_Reservation.Click += new System.EventHandler(this.btn_Ajt_Reservation_Click);
            // 
            // btn_GST_Chambre
            // 
            this.btn_GST_Chambre.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_GST_Chambre.FlatAppearance.BorderSize = 0;
            this.btn_GST_Chambre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_GST_Chambre.ForeColor = System.Drawing.Color.White;
            this.btn_GST_Chambre.Image = ((System.Drawing.Image)(resources.GetObject("btn_GST_Chambre.Image")));
            this.btn_GST_Chambre.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_GST_Chambre.Location = new System.Drawing.Point(0, 236);
            this.btn_GST_Chambre.Margin = new System.Windows.Forms.Padding(2);
            this.btn_GST_Chambre.Name = "btn_GST_Chambre";
            this.btn_GST_Chambre.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.btn_GST_Chambre.Size = new System.Drawing.Size(262, 57);
            this.btn_GST_Chambre.TabIndex = 14;
            this.btn_GST_Chambre.Text = "Gestion Des Chambres";
            this.btn_GST_Chambre.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_GST_Chambre.UseVisualStyleBackColor = true;
            this.btn_GST_Chambre.Click += new System.EventHandler(this.btn_GST_Chambre_Click);
            // 
            // btn_Ajt_Chambre
            // 
            this.btn_Ajt_Chambre.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Ajt_Chambre.FlatAppearance.BorderSize = 0;
            this.btn_Ajt_Chambre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Ajt_Chambre.ForeColor = System.Drawing.Color.White;
            this.btn_Ajt_Chambre.Image = ((System.Drawing.Image)(resources.GetObject("btn_Ajt_Chambre.Image")));
            this.btn_Ajt_Chambre.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Ajt_Chambre.Location = new System.Drawing.Point(0, 179);
            this.btn_Ajt_Chambre.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Ajt_Chambre.Name = "btn_Ajt_Chambre";
            this.btn_Ajt_Chambre.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.btn_Ajt_Chambre.Size = new System.Drawing.Size(262, 57);
            this.btn_Ajt_Chambre.TabIndex = 13;
            this.btn_Ajt_Chambre.Text = "Ajouter un Nouveu Chambre";
            this.btn_Ajt_Chambre.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Ajt_Chambre.UseVisualStyleBackColor = true;
            this.btn_Ajt_Chambre.Click += new System.EventHandler(this.btn_Ajt_Chambre_Click);
            // 
            // btn_GST_CLT
            // 
            this.btn_GST_CLT.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_GST_CLT.FlatAppearance.BorderSize = 0;
            this.btn_GST_CLT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_GST_CLT.ForeColor = System.Drawing.Color.White;
            this.btn_GST_CLT.Image = ((System.Drawing.Image)(resources.GetObject("btn_GST_CLT.Image")));
            this.btn_GST_CLT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_GST_CLT.Location = new System.Drawing.Point(0, 122);
            this.btn_GST_CLT.Margin = new System.Windows.Forms.Padding(2);
            this.btn_GST_CLT.Name = "btn_GST_CLT";
            this.btn_GST_CLT.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.btn_GST_CLT.Size = new System.Drawing.Size(262, 57);
            this.btn_GST_CLT.TabIndex = 12;
            this.btn_GST_CLT.Text = "Gestion Des Clients";
            this.btn_GST_CLT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_GST_CLT.UseVisualStyleBackColor = true;
            this.btn_GST_CLT.Click += new System.EventHandler(this.btn_GST_CLT_Click);
            // 
            // btn_AjtCLT
            // 
            this.btn_AjtCLT.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_AjtCLT.FlatAppearance.BorderSize = 0;
            this.btn_AjtCLT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AjtCLT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AjtCLT.ForeColor = System.Drawing.Color.White;
            this.btn_AjtCLT.Image = ((System.Drawing.Image)(resources.GetObject("btn_AjtCLT.Image")));
            this.btn_AjtCLT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_AjtCLT.Location = new System.Drawing.Point(0, 65);
            this.btn_AjtCLT.Margin = new System.Windows.Forms.Padding(2);
            this.btn_AjtCLT.Name = "btn_AjtCLT";
            this.btn_AjtCLT.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.btn_AjtCLT.Size = new System.Drawing.Size(262, 57);
            this.btn_AjtCLT.TabIndex = 11;
            this.btn_AjtCLT.Text = "Ajouter un Nouveu Client";
            this.btn_AjtCLT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_AjtCLT.UseVisualStyleBackColor = true;
            this.btn_AjtCLT.Click += new System.EventHandler(this.btn_AjtCLT_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.Controls.Add(this.labelLOGO);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(2);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(262, 65);
            this.panelLogo.TabIndex = 0;
            // 
            // labelLOGO
            // 
            this.labelLOGO.AutoSize = true;
            this.labelLOGO.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLOGO.ForeColor = System.Drawing.Color.White;
            this.labelLOGO.Location = new System.Drawing.Point(72, 21);
            this.labelLOGO.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLOGO.Name = "labelLOGO";
            this.labelLOGO.Size = new System.Drawing.Size(102, 24);
            this.labelLOGO.TabIndex = 0;
            this.labelLOGO.Text = "CiGonzo© ";
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(1)))), ((int)(((byte)(155)))));
            this.panelTitleBar.Controls.Add(this.btnMinimize);
            this.panelTitleBar.Controls.Add(this.btnMaximize);
            this.panelTitleBar.Controls.Add(this.btnClose);
            this.panelTitleBar.Controls.Add(this.lbl_Title);
            this.panelTitleBar.Controls.Add(this.button1);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(262, 0);
            this.panelTitleBar.Margin = new System.Windows.Forms.Padding(2);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1182, 65);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Montserrat Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(1058, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(42, 42);
            this.btnMinimize.TabIndex = 3;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Font = new System.Drawing.Font("Montserrat Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaximize.ForeColor = System.Drawing.Color.White;
            this.btnMaximize.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximize.Image")));
            this.btnMaximize.Location = new System.Drawing.Point(1100, 0);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(42, 42);
            this.btnMaximize.TabIndex = 2;
            this.btnMaximize.UseVisualStyleBackColor = true;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Montserrat Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(1142, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(42, 42);
            this.btnClose.TabIndex = 1;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lbl_Title
            // 
            this.lbl_Title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Montserrat SemiBold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.ForeColor = System.Drawing.Color.White;
            this.lbl_Title.Location = new System.Drawing.Point(512, 19);
            this.lbl_Title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(158, 26);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "Page D\'Accueil";
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Left;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 65);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_gesreserv
            // 
            this.btn_gesreserv.Controls.Add(this.pictureBox1);
            this.btn_gesreserv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_gesreserv.Location = new System.Drawing.Point(262, 65);
            this.btn_gesreserv.Margin = new System.Windows.Forms.Padding(2);
            this.btn_gesreserv.Name = "btn_gesreserv";
            this.btn_gesreserv.Size = new System.Drawing.Size(1182, 696);
            this.btn_gesreserv.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1182, 696);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1428, 761);
            this.Controls.Add(this.btn_gesreserv);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(1444, 0);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CiGonzo ©  V3.0";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.btn_gesreserv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label labelLOGO;
        private System.Windows.Forms.Panel btn_gesreserv;
        private System.Windows.Forms.Button btn_GST_User;
        private System.Windows.Forms.Button btn_Ajt_User;
        private System.Windows.Forms.Button btn_GST_Fac;
        private System.Windows.Forms.Button btn_User_Logout;
        private System.Windows.Forms.Button btn_GST_reservation;
        private System.Windows.Forms.Button btn_Ajt_Reservation;
        private System.Windows.Forms.Button btn_GST_Chambre;
        private System.Windows.Forms.Button btn_Ajt_Chambre;
        private System.Windows.Forms.Button btn_GST_CLT;
        private System.Windows.Forms.Button btn_AjtCLT;
        private System.Windows.Forms.Button btn_OutService;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Button btnClose;
    }
}

