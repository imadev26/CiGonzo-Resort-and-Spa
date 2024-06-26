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

namespace WindowsFormsApp1.Forms
{
    public partial class AjtUSERcs : Form
    {
        SqlConnection cn;
        DataSet Ds = new DataSet();
        public AjtUSERcs()
        {
            InitializeComponent();
        }
        void clear()
        {
            TXT_MDP_USER.Text = string.Empty;
            TXT_USER.Text = string.Empty;
            CB_TYPE_USER.SelectedIndex = -1;
        }

        private void AjtUSERcs_Load(object sender, EventArgs e)
        {
            cn = Methode.ConnectSqlserver();
            SqlDataAdapter dap = new SqlDataAdapter("select UserName_User as 'Nom d''utilisateur',Password_User as 'Mot de passe',Account_Type as 'Compte Type'  from Acces_Login where Account_Type in ('Modérateur','User')", cn);
            dap.Fill(Ds, "Acces_Login");
            DGV_USERS.DataSource = Ds.Tables["Acces_Login"];
        }

        private void button_USER_add_Click(object sender, EventArgs e)
        {
            Ds.Tables["Acces_Login"].Clear();
            cn = Methode.ConnectSqlserver();
            string querry = string.Format("insert into Acces_Login values ('{0}','{1}','{2}')", TXT_USER.Text, TXT_MDP_USER.Text, CB_TYPE_USER.SelectedItem);
            SqlCommand cmd = new SqlCommand(querry, cn);
            int k = cmd.ExecuteNonQuery();
            if (k != 0)
            {
                MessageBox.Show("l'utilisateur a été ajouté avec succès.");
                AjtUSERcs_Load(sender, e);
            }
            else
            {
                MessageBox.Show("L'utilisateur n'a pas été ajouté.");
            }
            cn.Close();
        }

        private void BTN_USER_RESET_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}
