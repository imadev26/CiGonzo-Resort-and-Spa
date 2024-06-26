
namespace WindowsFormsApp1.Forms
{
    partial class Gestion_Users
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
            this.DGV_USERS = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.BTN_RESET = new System.Windows.Forms.Button();
            this.BTN_SRCH = new System.Windows.Forms.Button();
            this.BTN_DROP = new System.Windows.Forms.Button();
            this.BTN_CHARGER = new System.Windows.Forms.Button();
            this.BTN_MAJ = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.CB_TYPE_USER = new System.Windows.Forms.ComboBox();
            this.TXT_USER = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TXT_MDP_USER = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TXT_FIND_BYUSER = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_USERS)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DGV_USERS);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1123, 460);
            this.panel1.TabIndex = 0;
            // 
            // DGV_USERS
            // 
            this.DGV_USERS.AllowUserToAddRows = false;
            this.DGV_USERS.AllowUserToDeleteRows = false;
            this.DGV_USERS.AllowUserToResizeColumns = false;
            this.DGV_USERS.AllowUserToResizeRows = false;
            this.DGV_USERS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_USERS.BackgroundColor = System.Drawing.Color.White;
            this.DGV_USERS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_USERS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_USERS.Location = new System.Drawing.Point(0, 246);
            this.DGV_USERS.Name = "DGV_USERS";
            this.DGV_USERS.Size = new System.Drawing.Size(1123, 214);
            this.DGV_USERS.TabIndex = 1;
            this.DGV_USERS.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.DGV_USERS_MouseDoubleClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1123, 246);
            this.panel2.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.BTN_RESET);
            this.panel5.Controls.Add(this.BTN_SRCH);
            this.panel5.Controls.Add(this.BTN_DROP);
            this.panel5.Controls.Add(this.BTN_CHARGER);
            this.panel5.Controls.Add(this.BTN_MAJ);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(340, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(368, 246);
            this.panel5.TabIndex = 2;
            // 
            // BTN_RESET
            // 
            this.BTN_RESET.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(4)))), ((int)(((byte)(156)))));
            this.BTN_RESET.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_RESET.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BTN_RESET.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_RESET.Font = new System.Drawing.Font("Montserrat", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_RESET.ForeColor = System.Drawing.Color.White;
            this.BTN_RESET.Location = new System.Drawing.Point(0, 1);
            this.BTN_RESET.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_RESET.Name = "BTN_RESET";
            this.BTN_RESET.Size = new System.Drawing.Size(368, 49);
            this.BTN_RESET.TabIndex = 7;
            this.BTN_RESET.Text = "Réinitialiser";
            this.BTN_RESET.UseVisualStyleBackColor = false;
            this.BTN_RESET.Click += new System.EventHandler(this.BTN_RESET_Click);
            // 
            // BTN_SRCH
            // 
            this.BTN_SRCH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(4)))), ((int)(((byte)(156)))));
            this.BTN_SRCH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_SRCH.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BTN_SRCH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_SRCH.Font = new System.Drawing.Font("Montserrat", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_SRCH.ForeColor = System.Drawing.Color.White;
            this.BTN_SRCH.Location = new System.Drawing.Point(0, 50);
            this.BTN_SRCH.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_SRCH.Name = "BTN_SRCH";
            this.BTN_SRCH.Size = new System.Drawing.Size(368, 49);
            this.BTN_SRCH.TabIndex = 10;
            this.BTN_SRCH.Text = "Chercher";
            this.BTN_SRCH.UseVisualStyleBackColor = false;
            this.BTN_SRCH.Click += new System.EventHandler(this.BTN_SRCH_Click);
            // 
            // BTN_DROP
            // 
            this.BTN_DROP.BackColor = System.Drawing.Color.Red;
            this.BTN_DROP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_DROP.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BTN_DROP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_DROP.Font = new System.Drawing.Font("Montserrat", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_DROP.ForeColor = System.Drawing.Color.White;
            this.BTN_DROP.Location = new System.Drawing.Point(0, 99);
            this.BTN_DROP.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_DROP.Name = "BTN_DROP";
            this.BTN_DROP.Size = new System.Drawing.Size(368, 49);
            this.BTN_DROP.TabIndex = 8;
            this.BTN_DROP.Text = "Supprimé";
            this.BTN_DROP.UseVisualStyleBackColor = false;
            this.BTN_DROP.Click += new System.EventHandler(this.BTN_DROP_Click);
            // 
            // BTN_CHARGER
            // 
            this.BTN_CHARGER.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(4)))), ((int)(((byte)(156)))));
            this.BTN_CHARGER.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_CHARGER.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BTN_CHARGER.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_CHARGER.Font = new System.Drawing.Font("Montserrat", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_CHARGER.ForeColor = System.Drawing.Color.White;
            this.BTN_CHARGER.Location = new System.Drawing.Point(0, 148);
            this.BTN_CHARGER.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_CHARGER.Name = "BTN_CHARGER";
            this.BTN_CHARGER.Size = new System.Drawing.Size(368, 49);
            this.BTN_CHARGER.TabIndex = 11;
            this.BTN_CHARGER.Text = "Charger";
            this.BTN_CHARGER.UseVisualStyleBackColor = false;
            this.BTN_CHARGER.Click += new System.EventHandler(this.BTN_CHARGER_Click);
            // 
            // BTN_MAJ
            // 
            this.BTN_MAJ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(4)))), ((int)(((byte)(156)))));
            this.BTN_MAJ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_MAJ.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BTN_MAJ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_MAJ.Font = new System.Drawing.Font("Montserrat", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_MAJ.ForeColor = System.Drawing.Color.White;
            this.BTN_MAJ.Location = new System.Drawing.Point(0, 197);
            this.BTN_MAJ.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_MAJ.Name = "BTN_MAJ";
            this.BTN_MAJ.Size = new System.Drawing.Size(368, 49);
            this.BTN_MAJ.TabIndex = 9;
            this.BTN_MAJ.Text = "Mise à jour";
            this.BTN_MAJ.UseVisualStyleBackColor = false;
            this.BTN_MAJ.Click += new System.EventHandler(this.BTN_MAJ_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.CB_TYPE_USER);
            this.panel4.Controls.Add(this.TXT_USER);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.TXT_MDP_USER);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(708, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(415, 246);
            this.panel4.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nom d\'utilisateur";
            // 
            // CB_TYPE_USER
            // 
            this.CB_TYPE_USER.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_TYPE_USER.FormattingEnabled = true;
            this.CB_TYPE_USER.Items.AddRange(new object[] {
            "Modérateur",
            "User"});
            this.CB_TYPE_USER.Location = new System.Drawing.Point(218, 155);
            this.CB_TYPE_USER.Name = "CB_TYPE_USER";
            this.CB_TYPE_USER.Size = new System.Drawing.Size(168, 21);
            this.CB_TYPE_USER.TabIndex = 17;
            // 
            // TXT_USER
            // 
            this.TXT_USER.Location = new System.Drawing.Point(218, 58);
            this.TXT_USER.Name = "TXT_USER";
            this.TXT_USER.Size = new System.Drawing.Size(168, 20);
            this.TXT_USER.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "type d\'utilisateur";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Mot de passe";
            // 
            // TXT_MDP_USER
            // 
            this.TXT_MDP_USER.Location = new System.Drawing.Point(218, 107);
            this.TXT_MDP_USER.Name = "TXT_MDP_USER";
            this.TXT_MDP_USER.Size = new System.Drawing.Size(168, 20);
            this.TXT_MDP_USER.TabIndex = 16;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(340, 246);
            this.panel3.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TXT_FIND_BYUSER);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(314, 167);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chercher par le nom d\'utilisateur";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nom d\'utilisateur";
            // 
            // TXT_FIND_BYUSER
            // 
            this.TXT_FIND_BYUSER.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_FIND_BYUSER.Location = new System.Drawing.Point(39, 70);
            this.TXT_FIND_BYUSER.Name = "TXT_FIND_BYUSER";
            this.TXT_FIND_BYUSER.Size = new System.Drawing.Size(245, 30);
            this.TXT_FIND_BYUSER.TabIndex = 0;
            // 
            // Gestion_Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 460);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Gestion_Users";
            this.Text = "Gestion_Users";
            this.Load += new System.EventHandler(this.Gestion_Users_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_USERS)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CB_TYPE_USER;
        private System.Windows.Forms.TextBox TXT_USER;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXT_MDP_USER;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TXT_FIND_BYUSER;
        private System.Windows.Forms.DataGridView DGV_USERS;
        private System.Windows.Forms.Button BTN_SRCH;
        private System.Windows.Forms.Button BTN_MAJ;
        private System.Windows.Forms.Button BTN_DROP;
        private System.Windows.Forms.Button BTN_RESET;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BTN_CHARGER;
        private System.Windows.Forms.Panel panel5;
    }
}