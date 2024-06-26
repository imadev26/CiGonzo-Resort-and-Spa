
namespace WindowsFormsApp1.Forms
{
    partial class Gestion_Des_Chambres
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.radioButton_room_reserved = new System.Windows.Forms.RadioButton();
            this.radioButton_room_ready = new System.Windows.Forms.RadioButton();
            this.radioButton_room_notready = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_RM_type = new System.Windows.Forms.TextBox();
            this.textBox_room_charges = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.textBox_room_number = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_RM_delete = new System.Windows.Forms.Button();
            this.button_room_clear = new System.Windows.Forms.Button();
            this.button_RM_update = new System.Windows.Forms.Button();
            this.dataGridView_main_room = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_DescLOG = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_ESpaceLOG = new System.Windows.Forms.TextBox();
            this.btn_ChargerROOMS = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_main_room)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1154, 349);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txt_ESpaceLOG);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txt_DescLOG);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.textBox_RM_type);
            this.panel3.Controls.Add(this.textBox_room_charges);
            this.panel3.Controls.Add(this.label22);
            this.panel3.Controls.Add(this.textBox_room_number);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(884, 349);
            this.panel3.TabIndex = 75;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.radioButton_room_reserved);
            this.groupBox1.Controls.Add(this.radioButton_room_ready);
            this.groupBox1.Controls.Add(this.radioButton_room_notready);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 259);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(884, 90);
            this.groupBox1.TabIndex = 88;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "État";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Montserrat", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(9, 34);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(179, 27);
            this.label13.TabIndex = 58;
            this.label13.Text = "Status logement";
            // 
            // radioButton_room_reserved
            // 
            this.radioButton_room_reserved.AutoSize = true;
            this.radioButton_room_reserved.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton_room_reserved.Font = new System.Drawing.Font("Montserrat", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_room_reserved.Location = new System.Drawing.Point(248, 32);
            this.radioButton_room_reserved.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton_room_reserved.Name = "radioButton_room_reserved";
            this.radioButton_room_reserved.Size = new System.Drawing.Size(150, 31);
            this.radioButton_room_reserved.TabIndex = 61;
            this.radioButton_room_reserved.TabStop = true;
            this.radioButton_room_reserved.Text = "Préparation";
            this.radioButton_room_reserved.UseVisualStyleBackColor = true;
            this.radioButton_room_reserved.CheckedChanged += new System.EventHandler(this.radioButton_room_reserved_CheckedChanged_1);
            // 
            // radioButton_room_ready
            // 
            this.radioButton_room_ready.AutoSize = true;
            this.radioButton_room_ready.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton_room_ready.Font = new System.Drawing.Font("Montserrat", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_room_ready.Location = new System.Drawing.Point(466, 32);
            this.radioButton_room_ready.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton_room_ready.Name = "radioButton_room_ready";
            this.radioButton_room_ready.Size = new System.Drawing.Size(139, 31);
            this.radioButton_room_ready.TabIndex = 59;
            this.radioButton_room_ready.TabStop = true;
            this.radioButton_room_ready.Text = "Disponible";
            this.radioButton_room_ready.UseVisualStyleBackColor = true;
            this.radioButton_room_ready.CheckedChanged += new System.EventHandler(this.radioButton_room_ready_CheckedChanged_1);
            // 
            // radioButton_room_notready
            // 
            this.radioButton_room_notready.AutoSize = true;
            this.radioButton_room_notready.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton_room_notready.Font = new System.Drawing.Font("Montserrat", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_room_notready.Location = new System.Drawing.Point(675, 32);
            this.radioButton_room_notready.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton_room_notready.Name = "radioButton_room_notready";
            this.radioButton_room_notready.Size = new System.Drawing.Size(156, 31);
            this.radioButton_room_notready.TabIndex = 60;
            this.radioButton_room_notready.TabStop = true;
            this.radioButton_room_notready.Text = "Indisponible";
            this.radioButton_room_notready.UseVisualStyleBackColor = true;
            this.radioButton_room_notready.CheckedChanged += new System.EventHandler(this.radioButton_room_notready_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(274, 120);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 87;
            this.label2.Text = "Room Type :";
            // 
            // textBox_RM_type
            // 
            this.textBox_RM_type.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox_RM_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_RM_type.Location = new System.Drawing.Point(452, 117);
            this.textBox_RM_type.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_RM_type.Name = "textBox_RM_type";
            this.textBox_RM_type.Size = new System.Drawing.Size(159, 23);
            this.textBox_RM_type.TabIndex = 86;
            // 
            // textBox_room_charges
            // 
            this.textBox_room_charges.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox_room_charges.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox_room_charges.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_room_charges.Location = new System.Drawing.Point(452, 83);
            this.textBox_room_charges.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_room_charges.Name = "textBox_room_charges";
            this.textBox_room_charges.Size = new System.Drawing.Size(159, 23);
            this.textBox_room_charges.TabIndex = 84;
            this.textBox_room_charges.Text = "0";
            this.textBox_room_charges.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_room_charges_KeyPress);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(274, 86);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(121, 20);
            this.label22.TabIndex = 85;
            this.label22.Text = "Room Charges :";
            // 
            // textBox_room_number
            // 
            this.textBox_room_number.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox_room_number.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox_room_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_room_number.Location = new System.Drawing.Point(452, 47);
            this.textBox_room_number.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_room_number.Name = "textBox_room_number";
            this.textBox_room_number.ReadOnly = true;
            this.textBox_room_number.Size = new System.Drawing.Size(159, 23);
            this.textBox_room_number.TabIndex = 82;
            this.textBox_room_number.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_room_number_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(274, 50);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(121, 20);
            this.label12.TabIndex = 83;
            this.label12.Text = "Room Number :";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_ChargerROOMS);
            this.panel2.Controls.Add(this.button_RM_delete);
            this.panel2.Controls.Add(this.button_room_clear);
            this.panel2.Controls.Add(this.button_RM_update);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(884, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(270, 349);
            this.panel2.TabIndex = 74;
            // 
            // button_RM_delete
            // 
            this.button_RM_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.button_RM_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_RM_delete.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button_RM_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_RM_delete.Font = new System.Drawing.Font("Montserrat", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_RM_delete.ForeColor = System.Drawing.Color.White;
            this.button_RM_delete.Location = new System.Drawing.Point(0, 160);
            this.button_RM_delete.Margin = new System.Windows.Forms.Padding(2);
            this.button_RM_delete.Name = "button_RM_delete";
            this.button_RM_delete.Size = new System.Drawing.Size(270, 63);
            this.button_RM_delete.TabIndex = 73;
            this.button_RM_delete.Text = "Supprimer";
            this.button_RM_delete.UseVisualStyleBackColor = false;
            this.button_RM_delete.Click += new System.EventHandler(this.button_RM_delete_Click);
            // 
            // button_room_clear
            // 
            this.button_room_clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(4)))), ((int)(((byte)(156)))));
            this.button_room_clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_room_clear.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button_room_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_room_clear.Font = new System.Drawing.Font("Montserrat", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_room_clear.ForeColor = System.Drawing.Color.White;
            this.button_room_clear.Location = new System.Drawing.Point(0, 223);
            this.button_room_clear.Margin = new System.Windows.Forms.Padding(2);
            this.button_room_clear.Name = "button_room_clear";
            this.button_room_clear.Size = new System.Drawing.Size(270, 63);
            this.button_room_clear.TabIndex = 64;
            this.button_room_clear.Text = "Nouveau";
            this.button_room_clear.UseVisualStyleBackColor = false;
            this.button_room_clear.Click += new System.EventHandler(this.button_room_clear_Click);
            // 
            // button_RM_update
            // 
            this.button_RM_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(4)))), ((int)(((byte)(156)))));
            this.button_RM_update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_RM_update.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button_RM_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_RM_update.Font = new System.Drawing.Font("Montserrat", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_RM_update.ForeColor = System.Drawing.Color.White;
            this.button_RM_update.Location = new System.Drawing.Point(0, 286);
            this.button_RM_update.Margin = new System.Windows.Forms.Padding(2);
            this.button_RM_update.Name = "button_RM_update";
            this.button_RM_update.Size = new System.Drawing.Size(270, 63);
            this.button_RM_update.TabIndex = 72;
            this.button_RM_update.Text = "Mise à jour";
            this.button_RM_update.UseVisualStyleBackColor = false;
            this.button_RM_update.Click += new System.EventHandler(this.button_RM_update_Click);
            // 
            // dataGridView_main_room
            // 
            this.dataGridView_main_room.AllowUserToAddRows = false;
            this.dataGridView_main_room.AllowUserToDeleteRows = false;
            this.dataGridView_main_room.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_main_room.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_main_room.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_main_room.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_main_room.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView_main_room.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_main_room.Location = new System.Drawing.Point(0, 349);
            this.dataGridView_main_room.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView_main_room.Name = "dataGridView_main_room";
            this.dataGridView_main_room.ReadOnly = true;
            this.dataGridView_main_room.RowHeadersWidth = 82;
            this.dataGridView_main_room.RowTemplate.Height = 33;
            this.dataGridView_main_room.Size = new System.Drawing.Size(1154, 189);
            this.dataGridView_main_room.TabIndex = 56;
            this.dataGridView_main_room.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView_main_room_MouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(274, 160);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 89;
            this.label1.Text = "Description :";
            // 
            // txt_DescLOG
            // 
            this.txt_DescLOG.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_DescLOG.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DescLOG.Location = new System.Drawing.Point(452, 158);
            this.txt_DescLOG.Margin = new System.Windows.Forms.Padding(2);
            this.txt_DescLOG.Name = "txt_DescLOG";
            this.txt_DescLOG.Size = new System.Drawing.Size(159, 23);
            this.txt_DescLOG.TabIndex = 90;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(274, 203);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 91;
            this.label3.Text = "Espace / m²";
            // 
            // txt_ESpaceLOG
            // 
            this.txt_ESpaceLOG.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_ESpaceLOG.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ESpaceLOG.Location = new System.Drawing.Point(452, 200);
            this.txt_ESpaceLOG.Margin = new System.Windows.Forms.Padding(2);
            this.txt_ESpaceLOG.Name = "txt_ESpaceLOG";
            this.txt_ESpaceLOG.Size = new System.Drawing.Size(159, 23);
            this.txt_ESpaceLOG.TabIndex = 92;
            this.txt_ESpaceLOG.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ESpaceLOG_KeyPress);
            // 
            // btn_ChargerROOMS
            // 
            this.btn_ChargerROOMS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(4)))), ((int)(((byte)(156)))));
            this.btn_ChargerROOMS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ChargerROOMS.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_ChargerROOMS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ChargerROOMS.Font = new System.Drawing.Font("Montserrat", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ChargerROOMS.ForeColor = System.Drawing.Color.White;
            this.btn_ChargerROOMS.Location = new System.Drawing.Point(0, 97);
            this.btn_ChargerROOMS.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ChargerROOMS.Name = "btn_ChargerROOMS";
            this.btn_ChargerROOMS.Size = new System.Drawing.Size(270, 63);
            this.btn_ChargerROOMS.TabIndex = 74;
            this.btn_ChargerROOMS.Text = "Charger";
            this.btn_ChargerROOMS.UseVisualStyleBackColor = false;
            this.btn_ChargerROOMS.Click += new System.EventHandler(this.btn_ChargerROOMS_Click);
            // 
            // Gestion_Des_Chambres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 538);
            this.Controls.Add(this.dataGridView_main_room);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Gestion_Des_Chambres";
            this.Text = "Gestion_Des_Chambres";
            this.Load += new System.EventHandler(this.Gestion_Des_Chambres_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_main_room)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_room_clear;
        public System.Windows.Forms.DataGridView dataGridView_main_room;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button_RM_delete;
        private System.Windows.Forms.Button button_RM_update;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RadioButton radioButton_room_reserved;
        private System.Windows.Forms.RadioButton radioButton_room_ready;
        private System.Windows.Forms.RadioButton radioButton_room_notready;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_RM_type;
        public System.Windows.Forms.TextBox textBox_room_charges;
        private System.Windows.Forms.Label label22;
        public System.Windows.Forms.TextBox textBox_room_number;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_ESpaceLOG;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_DescLOG;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_ChargerROOMS;
    }
}