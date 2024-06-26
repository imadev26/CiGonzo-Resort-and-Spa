
namespace WindowsFormsApp1.Forms
{
    partial class Ajouter_Nouveu_Chambres
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView_room = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_EspaceLOG = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_DescLOG = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_price_night = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_nb_lits = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_N_maison = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_type_maison = new System.Windows.Forms.ComboBox();
            this.button_RM_add = new System.Windows.Forms.Button();
            this.txt_nb_chambre = new System.Windows.Forms.NumericUpDown();
            this.button_RM_reset = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_etat_chambre = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ID_room = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_room)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_nb_lits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_nb_chambre)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_room
            // 
            this.dataGridView_room.AllowUserToAddRows = false;
            this.dataGridView_room.AllowUserToDeleteRows = false;
            this.dataGridView_room.AllowUserToResizeColumns = false;
            this.dataGridView_room.AllowUserToResizeRows = false;
            this.dataGridView_room.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_room.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_room.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_room.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_room.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_room.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_room.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_room.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView_room.Name = "dataGridView_room";
            this.dataGridView_room.ReadOnly = true;
            this.dataGridView_room.RowHeadersWidth = 82;
            this.dataGridView_room.RowTemplate.Height = 33;
            this.dataGridView_room.Size = new System.Drawing.Size(1154, 215);
            this.dataGridView_room.TabIndex = 74;
            this.dataGridView_room.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView_room_MouseDoubleClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_EspaceLOG);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txt_DescLOG);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.txt_price_night);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txt_nb_lits);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txt_N_maison);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cb_type_maison);
            this.panel1.Controls.Add(this.button_RM_add);
            this.panel1.Controls.Add(this.txt_nb_chambre);
            this.panel1.Controls.Add(this.button_RM_reset);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cb_etat_chambre);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_ID_room);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1154, 323);
            this.panel1.TabIndex = 75;
            // 
            // txt_EspaceLOG
            // 
            this.txt_EspaceLOG.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_EspaceLOG.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_EspaceLOG.Location = new System.Drawing.Point(518, 295);
            this.txt_EspaceLOG.Margin = new System.Windows.Forms.Padding(2);
            this.txt_EspaceLOG.Name = "txt_EspaceLOG";
            this.txt_EspaceLOG.Size = new System.Drawing.Size(229, 23);
            this.txt_EspaceLOG.TabIndex = 108;
            this.txt_EspaceLOG.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_EspaceLOG_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(268, 298);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 20);
            this.label8.TabIndex = 107;
            this.label8.Text = "Espace / m²";
            // 
            // txt_DescLOG
            // 
            this.txt_DescLOG.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_DescLOG.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DescLOG.Location = new System.Drawing.Point(519, 261);
            this.txt_DescLOG.Margin = new System.Windows.Forms.Padding(2);
            this.txt_DescLOG.Name = "txt_DescLOG";
            this.txt_DescLOG.Size = new System.Drawing.Size(229, 23);
            this.txt_DescLOG.TabIndex = 106;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(268, 257);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(189, 20);
            this.label7.TabIndex = 105;
            this.label7.Text = "Description de Logement";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(4)))), ((int)(((byte)(156)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Montserrat", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(876, 67);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(213, 57);
            this.button1.TabIndex = 104;
            this.button1.Text = "Nouvelle";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_price_night
            // 
            this.txt_price_night.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_price_night.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_price_night.Location = new System.Drawing.Point(518, 185);
            this.txt_price_night.Margin = new System.Windows.Forms.Padding(2);
            this.txt_price_night.Name = "txt_price_night";
            this.txt_price_night.Size = new System.Drawing.Size(229, 23);
            this.txt_price_night.TabIndex = 103;
            this.txt_price_night.TextChanged += new System.EventHandler(this.txt_price_night_TextChanged);
            this.txt_price_night.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_price_night_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(268, 181);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173, 20);
            this.label6.TabIndex = 102;
            this.label6.Text = "Prix par nuit / personne";
            // 
            // txt_nb_lits
            // 
            this.txt_nb_lits.BackColor = System.Drawing.SystemColors.Menu;
            this.txt_nb_lits.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_nb_lits.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nb_lits.Location = new System.Drawing.Point(519, 149);
            this.txt_nb_lits.Margin = new System.Windows.Forms.Padding(2);
            this.txt_nb_lits.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.txt_nb_lits.Name = "txt_nb_lits";
            this.txt_nb_lits.Size = new System.Drawing.Size(228, 19);
            this.txt_nb_lits.TabIndex = 101;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(268, 143);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 20);
            this.label5.TabIndex = 100;
            this.label5.Text = "Nombre de lits";
            // 
            // txt_N_maison
            // 
            this.txt_N_maison.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_N_maison.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_N_maison.Location = new System.Drawing.Point(518, 65);
            this.txt_N_maison.Margin = new System.Windows.Forms.Padding(2);
            this.txt_N_maison.Name = "txt_N_maison";
            this.txt_N_maison.Size = new System.Drawing.Size(229, 23);
            this.txt_N_maison.TabIndex = 99;
            this.txt_N_maison.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_N_maison_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(268, 67);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 98;
            this.label1.Text = "N° logement";
            // 
            // cb_type_maison
            // 
            this.cb_type_maison.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cb_type_maison.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_type_maison.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_type_maison.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_type_maison.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_type_maison.FormattingEnabled = true;
            this.cb_type_maison.Location = new System.Drawing.Point(518, 25);
            this.cb_type_maison.Margin = new System.Windows.Forms.Padding(2);
            this.cb_type_maison.Name = "cb_type_maison";
            this.cb_type_maison.Size = new System.Drawing.Size(229, 24);
            this.cb_type_maison.TabIndex = 97;
            // 
            // button_RM_add
            // 
            this.button_RM_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(4)))), ((int)(((byte)(156)))));
            this.button_RM_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_RM_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_RM_add.Font = new System.Drawing.Font("Montserrat", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_RM_add.ForeColor = System.Drawing.Color.White;
            this.button_RM_add.Location = new System.Drawing.Point(876, 197);
            this.button_RM_add.Margin = new System.Windows.Forms.Padding(2);
            this.button_RM_add.Name = "button_RM_add";
            this.button_RM_add.Size = new System.Drawing.Size(213, 57);
            this.button_RM_add.TabIndex = 94;
            this.button_RM_add.Text = "Ajouter";
            this.button_RM_add.UseVisualStyleBackColor = false;
            this.button_RM_add.Click += new System.EventHandler(this.button_RM_add_Click_1);
            // 
            // txt_nb_chambre
            // 
            this.txt_nb_chambre.BackColor = System.Drawing.SystemColors.Menu;
            this.txt_nb_chambre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_nb_chambre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nb_chambre.Location = new System.Drawing.Point(519, 109);
            this.txt_nb_chambre.Margin = new System.Windows.Forms.Padding(2);
            this.txt_nb_chambre.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.txt_nb_chambre.Name = "txt_nb_chambre";
            this.txt_nb_chambre.Size = new System.Drawing.Size(228, 19);
            this.txt_nb_chambre.TabIndex = 96;
            // 
            // button_RM_reset
            // 
            this.button_RM_reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(4)))), ((int)(((byte)(156)))));
            this.button_RM_reset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_RM_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_RM_reset.Font = new System.Drawing.Font("Montserrat", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_RM_reset.ForeColor = System.Drawing.Color.White;
            this.button_RM_reset.Location = new System.Drawing.Point(876, 131);
            this.button_RM_reset.Margin = new System.Windows.Forms.Padding(2);
            this.button_RM_reset.Name = "button_RM_reset";
            this.button_RM_reset.Size = new System.Drawing.Size(213, 57);
            this.button_RM_reset.TabIndex = 95;
            this.button_RM_reset.Text = "Charger";
            this.button_RM_reset.UseVisualStyleBackColor = false;
            this.button_RM_reset.Click += new System.EventHandler(this.button_RM_reset_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(268, 219);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 20);
            this.label4.TabIndex = 92;
            this.label4.Text = "État de la chambre";
            // 
            // cb_etat_chambre
            // 
            this.cb_etat_chambre.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cb_etat_chambre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_etat_chambre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_etat_chambre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_etat_chambre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_etat_chambre.FormattingEnabled = true;
            this.cb_etat_chambre.Location = new System.Drawing.Point(518, 224);
            this.cb_etat_chambre.Margin = new System.Windows.Forms.Padding(2);
            this.cb_etat_chambre.Name = "cb_etat_chambre";
            this.cb_etat_chambre.Size = new System.Drawing.Size(229, 24);
            this.cb_etat_chambre.TabIndex = 93;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(268, 105);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 20);
            this.label3.TabIndex = 91;
            this.label3.Text = "Nombre de chambres";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(268, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 20);
            this.label2.TabIndex = 90;
            this.label2.Text = "Type de logement";
            // 
            // txt_ID_room
            // 
            this.txt_ID_room.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_ID_room.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ID_room.Location = new System.Drawing.Point(1117, 11);
            this.txt_ID_room.Margin = new System.Windows.Forms.Padding(2);
            this.txt_ID_room.Name = "txt_ID_room";
            this.txt_ID_room.ReadOnly = true;
            this.txt_ID_room.Size = new System.Drawing.Size(26, 30);
            this.txt_ID_room.TabIndex = 87;
            this.txt_ID_room.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView_room);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 323);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1154, 215);
            this.panel2.TabIndex = 76;
            // 
            // Ajouter_Nouveu_Chambres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 538);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Ajouter_Nouveu_Chambres";
            this.Text = "Ajouter_Nouveu_Chambres";
            this.Load += new System.EventHandler(this.Ajouter_Nouveu_Chambres_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_room)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_nb_lits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_nb_chambre)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_room;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_RM_add;
        private System.Windows.Forms.NumericUpDown txt_nb_chambre;
        private System.Windows.Forms.Button button_RM_reset;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_etat_chambre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_ID_room;
        private System.Windows.Forms.NumericUpDown txt_nb_lits;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_N_maison;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_type_maison;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_price_night;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_EspaceLOG;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_DescLOG;
        private System.Windows.Forms.Label label7;
    }
}