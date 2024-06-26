
namespace WindowsFormsApp1.Forms
{
    partial class AjtUSERcs
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TXT_USER = new System.Windows.Forms.TextBox();
            this.TXT_MDP_USER = new System.Windows.Forms.TextBox();
            this.CB_TYPE_USER = new System.Windows.Forms.ComboBox();
            this.DGV_USERS = new System.Windows.Forms.DataGridView();
            this.button_USER_add = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BTN_USER_RESET = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_USERS)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DGV_USERS);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1139, 499);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BTN_USER_RESET);
            this.panel2.Controls.Add(this.button_USER_add);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1139, 196);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom d\'utilisateur";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mot de passe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "type d\'utilisateur";
            // 
            // TXT_USER
            // 
            this.TXT_USER.Location = new System.Drawing.Point(201, 42);
            this.TXT_USER.Name = "TXT_USER";
            this.TXT_USER.Size = new System.Drawing.Size(168, 20);
            this.TXT_USER.TabIndex = 3;
            // 
            // TXT_MDP_USER
            // 
            this.TXT_MDP_USER.Location = new System.Drawing.Point(201, 91);
            this.TXT_MDP_USER.Name = "TXT_MDP_USER";
            this.TXT_MDP_USER.Size = new System.Drawing.Size(168, 20);
            this.TXT_MDP_USER.TabIndex = 4;
            // 
            // CB_TYPE_USER
            // 
            this.CB_TYPE_USER.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_TYPE_USER.FormattingEnabled = true;
            this.CB_TYPE_USER.Items.AddRange(new object[] {
            "Modérateur",
            "User"});
            this.CB_TYPE_USER.Location = new System.Drawing.Point(201, 139);
            this.CB_TYPE_USER.Name = "CB_TYPE_USER";
            this.CB_TYPE_USER.Size = new System.Drawing.Size(168, 21);
            this.CB_TYPE_USER.TabIndex = 5;
            // 
            // DGV_USERS
            // 
            this.DGV_USERS.AllowUserToAddRows = false;
            this.DGV_USERS.AllowUserToDeleteRows = false;
            this.DGV_USERS.AllowUserToResizeColumns = false;
            this.DGV_USERS.AllowUserToResizeRows = false;
            this.DGV_USERS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_USERS.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.DGV_USERS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_USERS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_USERS.Location = new System.Drawing.Point(0, 196);
            this.DGV_USERS.Name = "DGV_USERS";
            this.DGV_USERS.Size = new System.Drawing.Size(1139, 303);
            this.DGV_USERS.TabIndex = 1;
            // 
            // button_USER_add
            // 
            this.button_USER_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(4)))), ((int)(((byte)(156)))));
            this.button_USER_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_USER_add.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button_USER_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_USER_add.Font = new System.Drawing.Font("Montserrat", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_USER_add.ForeColor = System.Drawing.Color.White;
            this.button_USER_add.Location = new System.Drawing.Point(450, 147);
            this.button_USER_add.Margin = new System.Windows.Forms.Padding(2);
            this.button_USER_add.Name = "button_USER_add";
            this.button_USER_add.Size = new System.Drawing.Size(689, 49);
            this.button_USER_add.TabIndex = 6;
            this.button_USER_add.Text = "Ajouter";
            this.button_USER_add.UseVisualStyleBackColor = false;
            this.button_USER_add.Click += new System.EventHandler(this.button_USER_add_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.CB_TYPE_USER);
            this.panel3.Controls.Add(this.TXT_USER);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.TXT_MDP_USER);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(450, 196);
            this.panel3.TabIndex = 6;
            // 
            // BTN_USER_RESET
            // 
            this.BTN_USER_RESET.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(4)))), ((int)(((byte)(156)))));
            this.BTN_USER_RESET.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_USER_RESET.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BTN_USER_RESET.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_USER_RESET.Font = new System.Drawing.Font("Montserrat", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_USER_RESET.ForeColor = System.Drawing.Color.White;
            this.BTN_USER_RESET.Location = new System.Drawing.Point(450, 98);
            this.BTN_USER_RESET.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_USER_RESET.Name = "BTN_USER_RESET";
            this.BTN_USER_RESET.Size = new System.Drawing.Size(689, 49);
            this.BTN_USER_RESET.TabIndex = 7;
            this.BTN_USER_RESET.Text = "Réinitialiser";
            this.BTN_USER_RESET.UseVisualStyleBackColor = false;
            this.BTN_USER_RESET.Click += new System.EventHandler(this.BTN_USER_RESET_Click);
            // 
            // AjtUSERcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 499);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AjtUSERcs";
            this.Text = "AjtUSERcs";
            this.Load += new System.EventHandler(this.AjtUSERcs_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_USERS)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView DGV_USERS;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox CB_TYPE_USER;
        private System.Windows.Forms.TextBox TXT_MDP_USER;
        private System.Windows.Forms.TextBox TXT_USER;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTN_USER_RESET;
        private System.Windows.Forms.Button button_USER_add;
        private System.Windows.Forms.Panel panel3;
    }
}