
namespace WindowsFormsApp1.Forms
{
    partial class Ajouter_reservation
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Prix_Service = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.DGV_Adapté = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_ID_CLT = new System.Windows.Forms.ComboBox();
            this.cb_N_logement = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_typelogement = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_ChargeDGV = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button_reserv_ckeckout = new System.Windows.Forms.Button();
            this.textBox_reserv_Noreservation = new System.Windows.Forms.TextBox();
            this.dateTimePicker_reserv_dateout = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_reserv_datein = new System.Windows.Forms.DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.numericUpDown_reserv_ExtratPerson = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_NB_couple = new System.Windows.Forms.NumericUpDown();
            this.label17 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.dataGridView_main_reservation = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Adapté)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_reserv_ExtratPerson)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_NB_couple)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_main_reservation)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Prix_Service);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cb_ID_CLT);
            this.panel1.Controls.Add(this.cb_N_logement);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cb_typelogement);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.textBox_reserv_Noreservation);
            this.panel1.Controls.Add(this.dateTimePicker_reserv_dateout);
            this.panel1.Controls.Add(this.dateTimePicker_reserv_datein);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.numericUpDown_reserv_ExtratPerson);
            this.panel1.Controls.Add(this.numericUpDown_NB_couple);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1154, 297);
            this.panel1.TabIndex = 0;
            // 
            // Prix_Service
            // 
            this.Prix_Service.Location = new System.Drawing.Point(337, 265);
            this.Prix_Service.Margin = new System.Windows.Forms.Padding(2);
            this.Prix_Service.Name = "Prix_Service";
            this.Prix_Service.Size = new System.Drawing.Size(138, 20);
            this.Prix_Service.TabIndex = 116;
            this.Prix_Service.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Prix_Service_KeyPress);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(484, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(480, 297);
            this.panel2.TabIndex = 115;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.DGV_Adapté);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(480, 297);
            this.panel4.TabIndex = 0;
            // 
            // DGV_Adapté
            // 
            this.DGV_Adapté.AllowUserToAddRows = false;
            this.DGV_Adapté.AllowUserToDeleteRows = false;
            this.DGV_Adapté.AllowUserToResizeColumns = false;
            this.DGV_Adapté.AllowUserToResizeRows = false;
            this.DGV_Adapté.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_Adapté.BackgroundColor = System.Drawing.Color.White;
            this.DGV_Adapté.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Adapté.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_Adapté.Location = new System.Drawing.Point(0, 0);
            this.DGV_Adapté.Margin = new System.Windows.Forms.Padding(2);
            this.DGV_Adapté.Name = "DGV_Adapté";
            this.DGV_Adapté.RowTemplate.Height = 24;
            this.DGV_Adapté.Size = new System.Drawing.Size(480, 297);
            this.DGV_Adapté.TabIndex = 0;
            this.DGV_Adapté.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.DGV_Adapté_MouseDoubleClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 15);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 20);
            this.label5.TabIndex = 114;
            this.label5.Text = "ID de réservation";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 267);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(220, 20);
            this.label4.TabIndex = 112;
            this.label4.Text = "Prix des prestations réservées";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 108);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 20);
            this.label3.TabIndex = 111;
            this.label3.Text = "Client ayant réservé";
            // 
            // cb_ID_CLT
            // 
            this.cb_ID_CLT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_ID_CLT.FormattingEnabled = true;
            this.cb_ID_CLT.Location = new System.Drawing.Point(271, 105);
            this.cb_ID_CLT.Margin = new System.Windows.Forms.Padding(2);
            this.cb_ID_CLT.Name = "cb_ID_CLT";
            this.cb_ID_CLT.Size = new System.Drawing.Size(204, 21);
            this.cb_ID_CLT.TabIndex = 110;
            this.cb_ID_CLT.Enter += new System.EventHandler(this.cb_ID_CLT_Enter);
            // 
            // cb_N_logement
            // 
            this.cb_N_logement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_N_logement.FormattingEnabled = true;
            this.cb_N_logement.Location = new System.Drawing.Point(271, 74);
            this.cb_N_logement.Margin = new System.Windows.Forms.Padding(2);
            this.cb_N_logement.Name = "cb_N_logement";
            this.cb_N_logement.Size = new System.Drawing.Size(204, 21);
            this.cb_N_logement.TabIndex = 109;
            this.cb_N_logement.Enter += new System.EventHandler(this.comboBox2_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 77);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 108;
            this.label2.Text = "N° logement";
            // 
            // cb_typelogement
            // 
            this.cb_typelogement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_typelogement.FormattingEnabled = true;
            this.cb_typelogement.Location = new System.Drawing.Point(271, 43);
            this.cb_typelogement.Margin = new System.Windows.Forms.Padding(2);
            this.cb_typelogement.Name = "cb_typelogement";
            this.cb_typelogement.Size = new System.Drawing.Size(204, 21);
            this.cb_typelogement.TabIndex = 106;
            this.cb_typelogement.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.cb_typelogement.Enter += new System.EventHandler(this.cb_typelogement_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 105;
            this.label1.Text = "Type Logement";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_ChargeDGV);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.button_reserv_ckeckout);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(964, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(190, 297);
            this.panel3.TabIndex = 104;
            // 
            // btn_ChargeDGV
            // 
            this.btn_ChargeDGV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(4)))), ((int)(((byte)(156)))));
            this.btn_ChargeDGV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ChargeDGV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_ChargeDGV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ChargeDGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ChargeDGV.ForeColor = System.Drawing.Color.White;
            this.btn_ChargeDGV.Location = new System.Drawing.Point(0, 174);
            this.btn_ChargeDGV.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ChargeDGV.Name = "btn_ChargeDGV";
            this.btn_ChargeDGV.Size = new System.Drawing.Size(190, 41);
            this.btn_ChargeDGV.TabIndex = 79;
            this.btn_ChargeDGV.Text = "Vider";
            this.btn_ChargeDGV.UseVisualStyleBackColor = false;
            this.btn_ChargeDGV.Click += new System.EventHandler(this.btn_ChargeDGV_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(4)))), ((int)(((byte)(156)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(0, 215);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 41);
            this.button1.TabIndex = 78;
            this.button1.Text = "Contrôle";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_reserv_ckeckout
            // 
            this.button_reserv_ckeckout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(4)))), ((int)(((byte)(156)))));
            this.button_reserv_ckeckout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_reserv_ckeckout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button_reserv_ckeckout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_reserv_ckeckout.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_reserv_ckeckout.ForeColor = System.Drawing.Color.White;
            this.button_reserv_ckeckout.Location = new System.Drawing.Point(0, 256);
            this.button_reserv_ckeckout.Margin = new System.Windows.Forms.Padding(2);
            this.button_reserv_ckeckout.Name = "button_reserv_ckeckout";
            this.button_reserv_ckeckout.Size = new System.Drawing.Size(190, 41);
            this.button_reserv_ckeckout.TabIndex = 77;
            this.button_reserv_ckeckout.Text = "Réservation";
            this.button_reserv_ckeckout.UseVisualStyleBackColor = false;
            this.button_reserv_ckeckout.Click += new System.EventHandler(this.button_reserv_ckeckout_Click);
            // 
            // textBox_reserv_Noreservation
            // 
            this.textBox_reserv_Noreservation.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox_reserv_Noreservation.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox_reserv_Noreservation.Location = new System.Drawing.Point(271, 14);
            this.textBox_reserv_Noreservation.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_reserv_Noreservation.Name = "textBox_reserv_Noreservation";
            this.textBox_reserv_Noreservation.ReadOnly = true;
            this.textBox_reserv_Noreservation.Size = new System.Drawing.Size(78, 20);
            this.textBox_reserv_Noreservation.TabIndex = 101;
            // 
            // dateTimePicker_reserv_dateout
            // 
            this.dateTimePicker_reserv_dateout.CustomFormat = "dd - MMM - yyyy";
            this.dateTimePicker_reserv_dateout.Location = new System.Drawing.Point(271, 168);
            this.dateTimePicker_reserv_dateout.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker_reserv_dateout.Name = "dateTimePicker_reserv_dateout";
            this.dateTimePicker_reserv_dateout.Size = new System.Drawing.Size(204, 20);
            this.dateTimePicker_reserv_dateout.TabIndex = 81;
            // 
            // dateTimePicker_reserv_datein
            // 
            this.dateTimePicker_reserv_datein.CustomFormat = "";
            this.dateTimePicker_reserv_datein.Location = new System.Drawing.Point(271, 137);
            this.dateTimePicker_reserv_datein.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker_reserv_datein.Name = "dateTimePicker_reserv_datein";
            this.dateTimePicker_reserv_datein.Size = new System.Drawing.Size(204, 20);
            this.dateTimePicker_reserv_datein.TabIndex = 80;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(32, 170);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(58, 20);
            this.label16.TabIndex = 79;
            this.label16.Text = "Départ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(32, 139);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 20);
            this.label14.TabIndex = 78;
            this.label14.Text = "Arrivée";
            // 
            // numericUpDown_reserv_ExtratPerson
            // 
            this.numericUpDown_reserv_ExtratPerson.BackColor = System.Drawing.SystemColors.Menu;
            this.numericUpDown_reserv_ExtratPerson.Location = new System.Drawing.Point(337, 232);
            this.numericUpDown_reserv_ExtratPerson.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown_reserv_ExtratPerson.Name = "numericUpDown_reserv_ExtratPerson";
            this.numericUpDown_reserv_ExtratPerson.ReadOnly = true;
            this.numericUpDown_reserv_ExtratPerson.Size = new System.Drawing.Size(137, 20);
            this.numericUpDown_reserv_ExtratPerson.TabIndex = 84;
            // 
            // numericUpDown_NB_couple
            // 
            this.numericUpDown_NB_couple.BackColor = System.Drawing.SystemColors.Menu;
            this.numericUpDown_NB_couple.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.numericUpDown_NB_couple.InterceptArrowKeys = false;
            this.numericUpDown_NB_couple.Location = new System.Drawing.Point(337, 199);
            this.numericUpDown_NB_couple.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown_NB_couple.Name = "numericUpDown_NB_couple";
            this.numericUpDown_NB_couple.ReadOnly = true;
            this.numericUpDown_NB_couple.Size = new System.Drawing.Size(137, 20);
            this.numericUpDown_NB_couple.TabIndex = 82;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(32, 232);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(305, 20);
            this.label17.TabIndex = 85;
            this.label17.Text = "nombre de personne(s) supplémentaire(s)";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(32, 201);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(156, 20);
            this.label15.TabIndex = 83;
            this.label15.Text = "Nombre de couple(s)";
            // 
            // dataGridView_main_reservation
            // 
            this.dataGridView_main_reservation.AllowUserToAddRows = false;
            this.dataGridView_main_reservation.AllowUserToDeleteRows = false;
            this.dataGridView_main_reservation.AllowUserToResizeColumns = false;
            this.dataGridView_main_reservation.AllowUserToResizeRows = false;
            this.dataGridView_main_reservation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_main_reservation.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_main_reservation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_main_reservation.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_main_reservation.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_main_reservation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_main_reservation.Location = new System.Drawing.Point(0, 297);
            this.dataGridView_main_reservation.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView_main_reservation.Name = "dataGridView_main_reservation";
            this.dataGridView_main_reservation.ReadOnly = true;
            this.dataGridView_main_reservation.RowHeadersWidth = 82;
            this.dataGridView_main_reservation.RowTemplate.Height = 33;
            this.dataGridView_main_reservation.Size = new System.Drawing.Size(1154, 241);
            this.dataGridView_main_reservation.TabIndex = 98;
            // 
            // Ajouter_reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 538);
            this.Controls.Add(this.dataGridView_main_reservation);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Ajouter_reservation";
            this.Text = "Ajouter_reservation";
            this.Load += new System.EventHandler(this.Ajouter_reservation_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Adapté)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_reserv_ExtratPerson)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_NB_couple)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_main_reservation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox_reserv_Noreservation;
        private System.Windows.Forms.Button button_reserv_ckeckout;
        public System.Windows.Forms.DataGridView dataGridView_main_reservation;
        private System.Windows.Forms.DateTimePicker dateTimePicker_reserv_dateout;
        private System.Windows.Forms.DateTimePicker dateTimePicker_reserv_datein;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown numericUpDown_reserv_ExtratPerson;
        private System.Windows.Forms.NumericUpDown numericUpDown_NB_couple;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cb_typelogement;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_N_logement;
        private System.Windows.Forms.ComboBox cb_ID_CLT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView DGV_Adapté;
        private System.Windows.Forms.TextBox Prix_Service;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_ChargeDGV;
    }
}