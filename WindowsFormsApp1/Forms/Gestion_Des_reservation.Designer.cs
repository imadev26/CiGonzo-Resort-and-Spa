
namespace WindowsFormsApp1.Forms
{
    partial class Gestion_Des_reservation
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
            this.panel6 = new System.Windows.Forms.Panel();
            this.DGV_Res = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.BTN_RES_search = new System.Windows.Forms.Button();
            this.BTN_RES_Charger = new System.Windows.Forms.Button();
            this.BTN_Res_delete = new System.Windows.Forms.Button();
            this.BTN_RES_update = new System.Windows.Forms.Button();
            this.BTN_RES_reset = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.TXT_CLT_ID = new System.Windows.Forms.TextBox();
            this.TXT_Type_Logement = new System.Windows.Forms.TextBox();
            this.TXT_N_Logement = new System.Windows.Forms.TextBox();
            this.Prix_Service = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_reserv_Noreservation = new System.Windows.Forms.TextBox();
            this.dateTimePicker_reserv_dateout = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_reserv_datein = new System.Windows.Forms.DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.numericUpDown_reserv_ExtratPerson = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_NB_couple = new System.Windows.Forms.NumericUpDown();
            this.label17 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TXT_SRSH_ID = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TXT_SRCH_NOM2 = new System.Windows.Forms.TextBox();
            this.TXT_SRCH_NOM = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Res)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_reserv_ExtratPerson)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_NB_couple)).BeginInit();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1455, 807);
            this.panel1.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.DGV_Res);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 362);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1455, 445);
            this.panel6.TabIndex = 1;
            // 
            // DGV_Res
            // 
            this.DGV_Res.AllowUserToAddRows = false;
            this.DGV_Res.AllowUserToDeleteRows = false;
            this.DGV_Res.AllowUserToResizeColumns = false;
            this.DGV_Res.AllowUserToResizeRows = false;
            this.DGV_Res.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_Res.BackgroundColor = System.Drawing.Color.White;
            this.DGV_Res.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Res.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_Res.Location = new System.Drawing.Point(0, 0);
            this.DGV_Res.Name = "DGV_Res";
            this.DGV_Res.Size = new System.Drawing.Size(1455, 445);
            this.DGV_Res.TabIndex = 0;
            this.DGV_Res.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.DGV_Res_MouseDoubleClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1455, 362);
            this.panel2.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.BTN_RES_search);
            this.panel5.Controls.Add(this.BTN_RES_Charger);
            this.panel5.Controls.Add(this.BTN_Res_delete);
            this.panel5.Controls.Add(this.BTN_RES_update);
            this.panel5.Controls.Add(this.BTN_RES_reset);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(390, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(581, 362);
            this.panel5.TabIndex = 4;
            // 
            // BTN_RES_search
            // 
            this.BTN_RES_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(4)))), ((int)(((byte)(156)))));
            this.BTN_RES_search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_RES_search.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BTN_RES_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_RES_search.Font = new System.Drawing.Font("Montserrat", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_RES_search.ForeColor = System.Drawing.Color.White;
            this.BTN_RES_search.Location = new System.Drawing.Point(0, 165);
            this.BTN_RES_search.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_RES_search.Name = "BTN_RES_search";
            this.BTN_RES_search.Size = new System.Drawing.Size(581, 39);
            this.BTN_RES_search.TabIndex = 173;
            this.BTN_RES_search.Text = "Chercher";
            this.BTN_RES_search.UseVisualStyleBackColor = false;
            this.BTN_RES_search.Click += new System.EventHandler(this.BTN_RES_search_Click);
            // 
            // BTN_RES_Charger
            // 
            this.BTN_RES_Charger.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(4)))), ((int)(((byte)(156)))));
            this.BTN_RES_Charger.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_RES_Charger.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BTN_RES_Charger.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_RES_Charger.Font = new System.Drawing.Font("Montserrat", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_RES_Charger.ForeColor = System.Drawing.Color.White;
            this.BTN_RES_Charger.Location = new System.Drawing.Point(0, 204);
            this.BTN_RES_Charger.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_RES_Charger.Name = "BTN_RES_Charger";
            this.BTN_RES_Charger.Size = new System.Drawing.Size(581, 39);
            this.BTN_RES_Charger.TabIndex = 175;
            this.BTN_RES_Charger.Text = "Charger";
            this.BTN_RES_Charger.UseVisualStyleBackColor = false;
            this.BTN_RES_Charger.Click += new System.EventHandler(this.BTN_RES_Charger_Click);
            // 
            // BTN_Res_delete
            // 
            this.BTN_Res_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.BTN_Res_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Res_delete.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BTN_Res_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Res_delete.Font = new System.Drawing.Font("Montserrat", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Res_delete.ForeColor = System.Drawing.Color.White;
            this.BTN_Res_delete.Location = new System.Drawing.Point(0, 243);
            this.BTN_Res_delete.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_Res_delete.Name = "BTN_Res_delete";
            this.BTN_Res_delete.Size = new System.Drawing.Size(581, 40);
            this.BTN_Res_delete.TabIndex = 177;
            this.BTN_Res_delete.Text = "Supprimé";
            this.BTN_Res_delete.UseVisualStyleBackColor = false;
            this.BTN_Res_delete.Click += new System.EventHandler(this.BTN_Res_delete_Click);
            // 
            // BTN_RES_update
            // 
            this.BTN_RES_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(4)))), ((int)(((byte)(156)))));
            this.BTN_RES_update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_RES_update.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BTN_RES_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_RES_update.Font = new System.Drawing.Font("Montserrat", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_RES_update.ForeColor = System.Drawing.Color.White;
            this.BTN_RES_update.Location = new System.Drawing.Point(0, 283);
            this.BTN_RES_update.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_RES_update.Name = "BTN_RES_update";
            this.BTN_RES_update.Size = new System.Drawing.Size(581, 40);
            this.BTN_RES_update.TabIndex = 176;
            this.BTN_RES_update.Text = "Mise à jour";
            this.BTN_RES_update.UseVisualStyleBackColor = false;
            this.BTN_RES_update.Click += new System.EventHandler(this.BTN_RES_update_Click);
            // 
            // BTN_RES_reset
            // 
            this.BTN_RES_reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(4)))), ((int)(((byte)(156)))));
            this.BTN_RES_reset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_RES_reset.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BTN_RES_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_RES_reset.Font = new System.Drawing.Font("Montserrat", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_RES_reset.ForeColor = System.Drawing.Color.White;
            this.BTN_RES_reset.Location = new System.Drawing.Point(0, 323);
            this.BTN_RES_reset.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_RES_reset.Name = "BTN_RES_reset";
            this.BTN_RES_reset.Size = new System.Drawing.Size(581, 39);
            this.BTN_RES_reset.TabIndex = 174;
            this.BTN_RES_reset.Text = "Réinitialiser";
            this.BTN_RES_reset.UseVisualStyleBackColor = false;
            this.BTN_RES_reset.Click += new System.EventHandler(this.BTN_RES_reset_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.TXT_CLT_ID);
            this.panel4.Controls.Add(this.TXT_Type_Logement);
            this.panel4.Controls.Add(this.TXT_N_Logement);
            this.panel4.Controls.Add(this.Prix_Service);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.textBox_reserv_Noreservation);
            this.panel4.Controls.Add(this.dateTimePicker_reserv_dateout);
            this.panel4.Controls.Add(this.dateTimePicker_reserv_datein);
            this.panel4.Controls.Add(this.label16);
            this.panel4.Controls.Add(this.label14);
            this.panel4.Controls.Add(this.numericUpDown_reserv_ExtratPerson);
            this.panel4.Controls.Add(this.numericUpDown_NB_couple);
            this.panel4.Controls.Add(this.label17);
            this.panel4.Controls.Add(this.label15);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(971, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(484, 362);
            this.panel4.TabIndex = 3;
            // 
            // TXT_CLT_ID
            // 
            this.TXT_CLT_ID.BackColor = System.Drawing.SystemColors.Menu;
            this.TXT_CLT_ID.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TXT_CLT_ID.Location = new System.Drawing.Point(260, 139);
            this.TXT_CLT_ID.Margin = new System.Windows.Forms.Padding(2);
            this.TXT_CLT_ID.Name = "TXT_CLT_ID";
            this.TXT_CLT_ID.ReadOnly = true;
            this.TXT_CLT_ID.Size = new System.Drawing.Size(203, 20);
            this.TXT_CLT_ID.TabIndex = 155;
            // 
            // TXT_Type_Logement
            // 
            this.TXT_Type_Logement.Location = new System.Drawing.Point(260, 76);
            this.TXT_Type_Logement.Name = "TXT_Type_Logement";
            this.TXT_Type_Logement.ReadOnly = true;
            this.TXT_Type_Logement.Size = new System.Drawing.Size(203, 20);
            this.TXT_Type_Logement.TabIndex = 154;
            // 
            // TXT_N_Logement
            // 
            this.TXT_N_Logement.BackColor = System.Drawing.SystemColors.Menu;
            this.TXT_N_Logement.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TXT_N_Logement.Location = new System.Drawing.Point(260, 108);
            this.TXT_N_Logement.Margin = new System.Windows.Forms.Padding(2);
            this.TXT_N_Logement.Name = "TXT_N_Logement";
            this.TXT_N_Logement.ReadOnly = true;
            this.TXT_N_Logement.Size = new System.Drawing.Size(203, 20);
            this.TXT_N_Logement.TabIndex = 153;
            // 
            // Prix_Service
            // 
            this.Prix_Service.Location = new System.Drawing.Point(326, 296);
            this.Prix_Service.Margin = new System.Windows.Forms.Padding(2);
            this.Prix_Service.Name = "Prix_Service";
            this.Prix_Service.Size = new System.Drawing.Size(138, 20);
            this.Prix_Service.TabIndex = 152;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 46);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 20);
            this.label5.TabIndex = 151;
            this.label5.Text = "ID de réservation";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 298);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(220, 20);
            this.label4.TabIndex = 150;
            this.label4.Text = "Prix des prestations réservées";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 139);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 20);
            this.label3.TabIndex = 149;
            this.label3.Text = "Client ayant réservé";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 108);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 146;
            this.label2.Text = "N° logement";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 77);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 144;
            this.label1.Text = "Type Logement";
            // 
            // textBox_reserv_Noreservation
            // 
            this.textBox_reserv_Noreservation.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox_reserv_Noreservation.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox_reserv_Noreservation.Location = new System.Drawing.Point(260, 45);
            this.textBox_reserv_Noreservation.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_reserv_Noreservation.Name = "textBox_reserv_Noreservation";
            this.textBox_reserv_Noreservation.ReadOnly = true;
            this.textBox_reserv_Noreservation.Size = new System.Drawing.Size(78, 20);
            this.textBox_reserv_Noreservation.TabIndex = 143;
            // 
            // dateTimePicker_reserv_dateout
            // 
            this.dateTimePicker_reserv_dateout.CustomFormat = "dd - MMM - yyyy";
            this.dateTimePicker_reserv_dateout.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_reserv_dateout.Location = new System.Drawing.Point(260, 199);
            this.dateTimePicker_reserv_dateout.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker_reserv_dateout.Name = "dateTimePicker_reserv_dateout";
            this.dateTimePicker_reserv_dateout.Size = new System.Drawing.Size(204, 20);
            this.dateTimePicker_reserv_dateout.TabIndex = 138;
            // 
            // dateTimePicker_reserv_datein
            // 
            this.dateTimePicker_reserv_datein.CustomFormat = "";
            this.dateTimePicker_reserv_datein.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_reserv_datein.Location = new System.Drawing.Point(260, 168);
            this.dateTimePicker_reserv_datein.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker_reserv_datein.Name = "dateTimePicker_reserv_datein";
            this.dateTimePicker_reserv_datein.Size = new System.Drawing.Size(204, 20);
            this.dateTimePicker_reserv_datein.TabIndex = 137;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(21, 201);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(58, 20);
            this.label16.TabIndex = 136;
            this.label16.Text = "Départ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(21, 170);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 20);
            this.label14.TabIndex = 135;
            this.label14.Text = "Arrivée";
            // 
            // numericUpDown_reserv_ExtratPerson
            // 
            this.numericUpDown_reserv_ExtratPerson.BackColor = System.Drawing.SystemColors.Menu;
            this.numericUpDown_reserv_ExtratPerson.Location = new System.Drawing.Point(326, 263);
            this.numericUpDown_reserv_ExtratPerson.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown_reserv_ExtratPerson.Name = "numericUpDown_reserv_ExtratPerson";
            this.numericUpDown_reserv_ExtratPerson.ReadOnly = true;
            this.numericUpDown_reserv_ExtratPerson.Size = new System.Drawing.Size(137, 20);
            this.numericUpDown_reserv_ExtratPerson.TabIndex = 141;
            // 
            // numericUpDown_NB_couple
            // 
            this.numericUpDown_NB_couple.BackColor = System.Drawing.SystemColors.Menu;
            this.numericUpDown_NB_couple.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.numericUpDown_NB_couple.InterceptArrowKeys = false;
            this.numericUpDown_NB_couple.Location = new System.Drawing.Point(326, 230);
            this.numericUpDown_NB_couple.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown_NB_couple.Name = "numericUpDown_NB_couple";
            this.numericUpDown_NB_couple.ReadOnly = true;
            this.numericUpDown_NB_couple.Size = new System.Drawing.Size(137, 20);
            this.numericUpDown_NB_couple.TabIndex = 139;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(21, 263);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(305, 20);
            this.label17.TabIndex = 142;
            this.label17.Text = "nombre de personne(s) supplémentaire(s)";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(21, 232);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(156, 20);
            this.label15.TabIndex = 140;
            this.label15.Text = "Nombre de couple(s)";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(390, 362);
            this.panel3.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TXT_SRSH_ID);
            this.groupBox1.Location = new System.Drawing.Point(12, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(350, 88);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rechercher par numéro de réservation";
            // 
            // TXT_SRSH_ID
            // 
            this.TXT_SRSH_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_SRSH_ID.Location = new System.Drawing.Point(17, 31);
            this.TXT_SRSH_ID.Name = "TXT_SRSH_ID";
            this.TXT_SRSH_ID.Size = new System.Drawing.Size(251, 30);
            this.TXT_SRSH_ID.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.TXT_SRCH_NOM2);
            this.groupBox2.Controls.Add(this.TXT_SRCH_NOM);
            this.groupBox2.Location = new System.Drawing.Point(12, 184);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(350, 88);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Rechercher par nom client réserver";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(156, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Nom";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Prénom";
            // 
            // TXT_SRCH_NOM2
            // 
            this.TXT_SRCH_NOM2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_SRCH_NOM2.Location = new System.Drawing.Point(159, 29);
            this.TXT_SRCH_NOM2.Name = "TXT_SRCH_NOM2";
            this.TXT_SRCH_NOM2.Size = new System.Drawing.Size(153, 30);
            this.TXT_SRCH_NOM2.TabIndex = 1;
            // 
            // TXT_SRCH_NOM
            // 
            this.TXT_SRCH_NOM.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_SRCH_NOM.Location = new System.Drawing.Point(34, 29);
            this.TXT_SRCH_NOM.Name = "TXT_SRCH_NOM";
            this.TXT_SRCH_NOM.Size = new System.Drawing.Size(109, 30);
            this.TXT_SRCH_NOM.TabIndex = 0;
            // 
            // Gestion_Des_reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1455, 807);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Gestion_Des_reservation";
            this.Text = "Ajouter_reservation";
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Res)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_reserv_ExtratPerson)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_NB_couple)).EndInit();
            this.panel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TXT_SRSH_ID;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TXT_SRCH_NOM;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox Prix_Service;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_reserv_Noreservation;
        private System.Windows.Forms.DateTimePicker dateTimePicker_reserv_dateout;
        private System.Windows.Forms.DateTimePicker dateTimePicker_reserv_datein;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown numericUpDown_reserv_ExtratPerson;
        private System.Windows.Forms.NumericUpDown numericUpDown_NB_couple;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button BTN_RES_search;
        private System.Windows.Forms.Button BTN_RES_Charger;
        private System.Windows.Forms.Button BTN_Res_delete;
        private System.Windows.Forms.Button BTN_RES_update;
        private System.Windows.Forms.Button BTN_RES_reset;
        private System.Windows.Forms.DataGridView DGV_Res;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TXT_SRCH_NOM2;
        private System.Windows.Forms.TextBox TXT_N_Logement;
        private System.Windows.Forms.TextBox TXT_Type_Logement;
        private System.Windows.Forms.TextBox TXT_CLT_ID;
    }
}