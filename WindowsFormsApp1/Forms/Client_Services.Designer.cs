
namespace WindowsFormsApp1.Forms
{
    partial class Client_Services
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Client_Services));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_ID_RESER = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_Nbperson = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_PrixService = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_ClientID = new System.Windows.Forms.ComboBox();
            this.cb_produit = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_service = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_cat = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_changer = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_chercher = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.BTN_Delete_Reservation = new System.Windows.Forms.Button();
            this.button_ADD_Reservation = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_ID_RESER);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1107, 110);
            this.panel1.TabIndex = 0;
            // 
            // txt_ID_RESER
            // 
            this.txt_ID_RESER.Location = new System.Drawing.Point(1034, 12);
            this.txt_ID_RESER.Name = "txt_ID_RESER";
            this.txt_ID_RESER.Size = new System.Drawing.Size(61, 20);
            this.txt_ID_RESER.TabIndex = 16;
            this.txt_ID_RESER.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkBlue;
            this.label5.Location = new System.Drawing.Point(464, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 31);
            this.label5.TabIndex = 1;
            this.label5.Text = "Notre Service";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(251, 110);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-9, -7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(260, 117);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 110);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1107, 311);
            this.panel3.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.dataGridView1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 117);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(886, 194);
            this.panel6.TabIndex = 13;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(886, 194);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.txt_Nbperson);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.txt_PrixService);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.cb_ClientID);
            this.panel5.Controls.Add(this.cb_produit);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.cb_service);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.cb_cat);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(886, 117);
            this.panel5.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(810, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 22);
            this.label9.TabIndex = 15;
            this.label9.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(711, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 22);
            this.label8.TabIndex = 14;
            this.label8.Text = "Total";
            // 
            // txt_Nbperson
            // 
            this.txt_Nbperson.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nbperson.Location = new System.Drawing.Point(531, 71);
            this.txt_Nbperson.Name = "txt_Nbperson";
            this.txt_Nbperson.Size = new System.Drawing.Size(139, 30);
            this.txt_Nbperson.TabIndex = 13;
            this.txt_Nbperson.TextChanged += new System.EventHandler(this.txt_Nbperson_TextChanged);
            this.txt_Nbperson.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Nbperson_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(501, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Qte";
            // 
            // txt_PrixService
            // 
            this.txt_PrixService.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PrixService.Location = new System.Drawing.Point(430, 40);
            this.txt_PrixService.Name = "txt_PrixService";
            this.txt_PrixService.Size = new System.Drawing.Size(240, 30);
            this.txt_PrixService.TabIndex = 10;
            this.txt_PrixService.TextChanged += new System.EventHandler(this.txt_PrixService_TextChanged);
            this.txt_PrixService.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Nbperson_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(360, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Prix Service";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Client";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Catégorie";
            // 
            // cb_ClientID
            // 
            this.cb_ClientID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_ClientID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_ClientID.FormattingEnabled = true;
            this.cb_ClientID.Location = new System.Drawing.Point(74, 6);
            this.cb_ClientID.Name = "cb_ClientID";
            this.cb_ClientID.Size = new System.Drawing.Size(240, 33);
            this.cb_ClientID.TabIndex = 1;
            // 
            // cb_produit
            // 
            this.cb_produit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_produit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_produit.FormattingEnabled = true;
            this.cb_produit.Location = new System.Drawing.Point(429, 6);
            this.cb_produit.Name = "cb_produit";
            this.cb_produit.Size = new System.Drawing.Size(241, 33);
            this.cb_produit.TabIndex = 8;
            this.cb_produit.Enter += new System.EventHandler(this.cb_produit_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Service";
            // 
            // cb_service
            // 
            this.cb_service.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_service.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_service.FormattingEnabled = true;
            this.cb_service.Location = new System.Drawing.Point(74, 74);
            this.cb_service.Name = "cb_service";
            this.cb_service.Size = new System.Drawing.Size(240, 33);
            this.cb_service.TabIndex = 7;
            this.cb_service.Enter += new System.EventHandler(this.cb_service_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(342, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nom du service";
            // 
            // cb_cat
            // 
            this.cb_cat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_cat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_cat.FormattingEnabled = true;
            this.cb_cat.Location = new System.Drawing.Point(74, 40);
            this.cb_cat.Name = "cb_cat";
            this.cb_cat.Size = new System.Drawing.Size(240, 33);
            this.cb_cat.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btn_changer);
            this.panel4.Controls.Add(this.btn_reset);
            this.panel4.Controls.Add(this.btn_chercher);
            this.panel4.Controls.Add(this.btn_Update);
            this.panel4.Controls.Add(this.BTN_Delete_Reservation);
            this.panel4.Controls.Add(this.button_ADD_Reservation);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(886, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(221, 311);
            this.panel4.TabIndex = 9;
            // 
            // btn_changer
            // 
            this.btn_changer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(4)))), ((int)(((byte)(156)))));
            this.btn_changer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_changer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_changer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_changer.Font = new System.Drawing.Font("Montserrat", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_changer.ForeColor = System.Drawing.Color.White;
            this.btn_changer.Location = new System.Drawing.Point(0, 17);
            this.btn_changer.Margin = new System.Windows.Forms.Padding(2);
            this.btn_changer.Name = "btn_changer";
            this.btn_changer.Size = new System.Drawing.Size(221, 49);
            this.btn_changer.TabIndex = 12;
            this.btn_changer.Text = "Charger";
            this.btn_changer.UseVisualStyleBackColor = false;
            this.btn_changer.Click += new System.EventHandler(this.btn_changer_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(4)))), ((int)(((byte)(156)))));
            this.btn_reset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_reset.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reset.Font = new System.Drawing.Font("Montserrat", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reset.ForeColor = System.Drawing.Color.White;
            this.btn_reset.Location = new System.Drawing.Point(0, 66);
            this.btn_reset.Margin = new System.Windows.Forms.Padding(2);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(221, 49);
            this.btn_reset.TabIndex = 11;
            this.btn_reset.Text = "Réinitialiser";
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_chercher
            // 
            this.btn_chercher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(4)))), ((int)(((byte)(156)))));
            this.btn_chercher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_chercher.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_chercher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_chercher.Font = new System.Drawing.Font("Montserrat", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_chercher.ForeColor = System.Drawing.Color.White;
            this.btn_chercher.Location = new System.Drawing.Point(0, 115);
            this.btn_chercher.Margin = new System.Windows.Forms.Padding(2);
            this.btn_chercher.Name = "btn_chercher";
            this.btn_chercher.Size = new System.Drawing.Size(221, 49);
            this.btn_chercher.TabIndex = 10;
            this.btn_chercher.Text = "Chercher";
            this.btn_chercher.UseVisualStyleBackColor = false;
            this.btn_chercher.Click += new System.EventHandler(this.btn_chercher_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.Color.DarkGreen;
            this.btn_Update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Update.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Update.Font = new System.Drawing.Font("Montserrat", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.ForeColor = System.Drawing.Color.White;
            this.btn_Update.Location = new System.Drawing.Point(0, 164);
            this.btn_Update.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(221, 49);
            this.btn_Update.TabIndex = 9;
            this.btn_Update.Text = "Mise a jour";
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // BTN_Delete_Reservation
            // 
            this.BTN_Delete_Reservation.BackColor = System.Drawing.Color.Red;
            this.BTN_Delete_Reservation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Delete_Reservation.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BTN_Delete_Reservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Delete_Reservation.Font = new System.Drawing.Font("Montserrat", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Delete_Reservation.ForeColor = System.Drawing.Color.White;
            this.BTN_Delete_Reservation.Location = new System.Drawing.Point(0, 213);
            this.BTN_Delete_Reservation.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_Delete_Reservation.Name = "BTN_Delete_Reservation";
            this.BTN_Delete_Reservation.Size = new System.Drawing.Size(221, 49);
            this.BTN_Delete_Reservation.TabIndex = 8;
            this.BTN_Delete_Reservation.Text = "Supprimé";
            this.BTN_Delete_Reservation.UseVisualStyleBackColor = false;
            this.BTN_Delete_Reservation.Click += new System.EventHandler(this.BTN_Delete_Reservation_Click);
            // 
            // button_ADD_Reservation
            // 
            this.button_ADD_Reservation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(4)))), ((int)(((byte)(156)))));
            this.button_ADD_Reservation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_ADD_Reservation.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button_ADD_Reservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ADD_Reservation.Font = new System.Drawing.Font("Montserrat", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ADD_Reservation.ForeColor = System.Drawing.Color.White;
            this.button_ADD_Reservation.Location = new System.Drawing.Point(0, 262);
            this.button_ADD_Reservation.Margin = new System.Windows.Forms.Padding(2);
            this.button_ADD_Reservation.Name = "button_ADD_Reservation";
            this.button_ADD_Reservation.Size = new System.Drawing.Size(221, 49);
            this.button_ADD_Reservation.TabIndex = 7;
            this.button_ADD_Reservation.Text = "Ajouter";
            this.button_ADD_Reservation.UseVisualStyleBackColor = false;
            this.button_ADD_Reservation.Click += new System.EventHandler(this.button_ADD_Reservation_Click);
            // 
            // Client_Services
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1107, 421);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Client_Services";
            this.Text = "Client_Services";
            this.Load += new System.EventHandler(this.Client_Services_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cb_service;
        private System.Windows.Forms.ComboBox cb_cat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_ClientID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox cb_produit;
        private System.Windows.Forms.Button button_ADD_Reservation;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_Nbperson;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_PrixService;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BTN_Delete_Reservation;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.TextBox txt_ID_RESER;
        private System.Windows.Forms.Button btn_chercher;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_changer;
    }
}