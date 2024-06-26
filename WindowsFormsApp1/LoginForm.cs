using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class LoginForm : Form
    {
        SqlConnection cn;
        string x;
       
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox_login_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_login_login_Click(object sender, EventArgs e)
        {
            cn = Methode.ConnectSqlserver();
            if (textBox_login_username.Text == string.Empty || textBox_login_password.Text == string.Empty)
            {
                MessageBox.Show("Fields are empty", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                   
                    string h = string.Format("SELECT * FROM Acces_Login WHERE UserName_User = '{0}' AND Password_User = '{1}'", textBox_login_username.Text, textBox_login_password.Text);
                    SqlCommand cmd = new SqlCommand(h,cn);
                    SqlDataReader dr = cmd.ExecuteReader();
                    dr.Read();
                    if (dr.HasRows == true)
                    {
                        x = dr[2].ToString();
                        MainForm M = new MainForm(x);
                        dr.Close();
                        this.Hide();
                        cn.Close();
                        M.ShowDialog();
                    }
                    else
                    {
                        dr.Close();
                        Program.cn.Close();
                        MessageBox.Show("Information Incorrect", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    cn.Close();
                }
                catch (SqlException Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void label_login_clear_Click(object sender, EventArgs e)
        {
            textBox_login_password.Text = string.Empty;
            textBox_login_username.Text = string.Empty;
        }

        private void checkBox_login_show_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_login_show.Checked == true)
            {
                textBox_login_password.UseSystemPasswordChar = false;
            }
            else
            {
                textBox_login_password.UseSystemPasswordChar = true;
            }
        }

        private void label_login_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
