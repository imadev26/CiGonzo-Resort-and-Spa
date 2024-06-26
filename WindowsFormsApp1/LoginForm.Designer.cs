
namespace WindowsFormsApp1
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
            this.label_login_exit = new System.Windows.Forms.Label();
            this.label_login_clear = new System.Windows.Forms.Label();
            this.button_login_login = new System.Windows.Forms.Button();
            this.checkBox_login_show = new System.Windows.Forms.CheckBox();
            this.textBox_login_password = new System.Windows.Forms.TextBox();
            this.label_login_password = new System.Windows.Forms.Label();
            this.textBox_login_username = new System.Windows.Forms.TextBox();
            this.label_login_username = new System.Windows.Forms.Label();
            this.pictureBox_login_logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_login_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // label_login_exit
            // 
            this.label_login_exit.AutoSize = true;
            this.label_login_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_login_exit.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_login_exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(4)))), ((int)(((byte)(156)))));
            this.label_login_exit.Location = new System.Drawing.Point(133, 489);
            this.label_login_exit.Name = "label_login_exit";
            this.label_login_exit.Size = new System.Drawing.Size(68, 22);
            this.label_login_exit.TabIndex = 19;
            this.label_login_exit.Text = "Quitter";
            this.label_login_exit.Click += new System.EventHandler(this.label_login_exit_Click);
            // 
            // label_login_clear
            // 
            this.label_login_clear.AutoSize = true;
            this.label_login_clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_login_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label_login_clear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(4)))), ((int)(((byte)(156)))));
            this.label_login_clear.Location = new System.Drawing.Point(34, 389);
            this.label_login_clear.Name = "label_login_clear";
            this.label_login_clear.Size = new System.Drawing.Size(78, 16);
            this.label_login_clear.TabIndex = 18;
            this.label_login_clear.Text = "Réinitialiser";
            this.label_login_clear.Click += new System.EventHandler(this.label_login_clear_Click);
            // 
            // button_login_login
            // 
            this.button_login_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(4)))), ((int)(((byte)(156)))));
            this.button_login_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_login_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_login_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_login_login.ForeColor = System.Drawing.Color.White;
            this.button_login_login.Location = new System.Drawing.Point(33, 452);
            this.button_login_login.Name = "button_login_login";
            this.button_login_login.Size = new System.Drawing.Size(279, 34);
            this.button_login_login.TabIndex = 17;
            this.button_login_login.Text = "Se connecter";
            this.button_login_login.UseVisualStyleBackColor = false;
            this.button_login_login.Click += new System.EventHandler(this.button_login_login_Click);
            // 
            // checkBox_login_show
            // 
            this.checkBox_login_show.AutoSize = true;
            this.checkBox_login_show.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox_login_show.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_login_show.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(4)))), ((int)(((byte)(156)))));
            this.checkBox_login_show.Location = new System.Drawing.Point(156, 385);
            this.checkBox_login_show.Name = "checkBox_login_show";
            this.checkBox_login_show.Size = new System.Drawing.Size(156, 20);
            this.checkBox_login_show.TabIndex = 16;
            this.checkBox_login_show.Text = "Afficher Mot de passe";
            this.checkBox_login_show.UseVisualStyleBackColor = true;
            this.checkBox_login_show.CheckedChanged += new System.EventHandler(this.checkBox_login_show_CheckedChanged);
            // 
            // textBox_login_password
            // 
            this.textBox_login_password.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox_login_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_login_password.ForeColor = System.Drawing.Color.Black;
            this.textBox_login_password.Location = new System.Drawing.Point(33, 352);
            this.textBox_login_password.Name = "textBox_login_password";
            this.textBox_login_password.Size = new System.Drawing.Size(279, 30);
            this.textBox_login_password.TabIndex = 15;
            this.textBox_login_password.UseSystemPasswordChar = true;
            // 
            // label_login_password
            // 
            this.label_login_password.AutoSize = true;
            this.label_login_password.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_login_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(4)))), ((int)(((byte)(156)))));
            this.label_login_password.Location = new System.Drawing.Point(33, 327);
            this.label_login_password.Name = "label_login_password";
            this.label_login_password.Size = new System.Drawing.Size(117, 22);
            this.label_login_password.TabIndex = 14;
            this.label_login_password.Text = "Mot de passe";
            // 
            // textBox_login_username
            // 
            this.textBox_login_username.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox_login_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_login_username.ForeColor = System.Drawing.Color.Black;
            this.textBox_login_username.Location = new System.Drawing.Point(33, 274);
            this.textBox_login_username.Name = "textBox_login_username";
            this.textBox_login_username.Size = new System.Drawing.Size(279, 30);
            this.textBox_login_username.TabIndex = 13;
            this.textBox_login_username.TextChanged += new System.EventHandler(this.textBox_login_username_TextChanged);
            // 
            // label_login_username
            // 
            this.label_login_username.AutoSize = true;
            this.label_login_username.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_login_username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(4)))), ((int)(((byte)(156)))));
            this.label_login_username.Location = new System.Drawing.Point(33, 249);
            this.label_login_username.Name = "label_login_username";
            this.label_login_username.Size = new System.Drawing.Size(149, 22);
            this.label_login_username.TabIndex = 12;
            this.label_login_username.Text = "Nom d\'utilisateur";
            // 
            // pictureBox_login_logo
            // 
            this.pictureBox_login_logo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_login_logo.Image")));
            this.pictureBox_login_logo.Location = new System.Drawing.Point(-154, -24);
            this.pictureBox_login_logo.Name = "pictureBox_login_logo";
            this.pictureBox_login_logo.Size = new System.Drawing.Size(654, 286);
            this.pictureBox_login_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_login_logo.TabIndex = 10;
            this.pictureBox_login_logo.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(347, 546);
            this.Controls.Add(this.label_login_exit);
            this.Controls.Add(this.label_login_clear);
            this.Controls.Add(this.button_login_login);
            this.Controls.Add(this.checkBox_login_show);
            this.Controls.Add(this.textBox_login_password);
            this.Controls.Add(this.label_login_password);
            this.Controls.Add(this.textBox_login_username);
            this.Controls.Add(this.label_login_username);
            this.Controls.Add(this.pictureBox_login_logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_login_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_login_exit;
        private System.Windows.Forms.Label label_login_clear;
        private System.Windows.Forms.Button button_login_login;
        private System.Windows.Forms.CheckBox checkBox_login_show;
        private System.Windows.Forms.TextBox textBox_login_password;
        private System.Windows.Forms.Label label_login_password;
        private System.Windows.Forms.TextBox textBox_login_username;
        private System.Windows.Forms.Label label_login_username;
        private System.Windows.Forms.PictureBox pictureBox_login_logo;
    }
}