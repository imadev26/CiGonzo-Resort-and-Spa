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
    public partial class Gestion_Users : Form
    {
        SqlConnection cn;
        DataTable t = new DataTable();
        string x,x1,x2;
        bool b1 = false;


        public Gestion_Users()
        {
            InitializeComponent();
        }
        

        void MAJ()
        {
            if (TXT_USER.Text == x && TXT_MDP_USER.Text == x1 && CB_TYPE_USER.SelectedItem.ToString() == x2)
            {
                MessageBox.Show("Vous devez modifier certaines informations");
            }
            else
            {
                try
                {
                    cn = Methode.ConnectSqlserver();
                    string querry = string.Format("Update Acces_Login set UserName_User = '{0}',Password_User = '{1}',Account_Type = '{2}' where UserName_User = '{3}' and Account_Type in ('Modérateur','User')", TXT_USER.Text, TXT_MDP_USER.Text, CB_TYPE_USER.SelectedItem, x);
                    SqlCommand cmd = new SqlCommand(querry, cn);
                    int k = cmd.ExecuteNonQuery();
                    if (k != 0)
                    {
                        t.Rows.Clear();
                        MessageBox.Show("l'utilisateur a été modifié");
                        b1 = true;
                    }
                    else
                    {
                        MessageBox.Show("l'utilisateur n'a pas été modifié");
                        chercher(TXT_USER.Text);
                    }
                    cn.Close();
                }
                catch (Exception EX)
                {

                    MessageBox.Show(EX.Message);
                }
            }
        }
        void supprimer(string s1)
        {
            try
            {
                cn = Methode.ConnectSqlserver();
                string querry = string.Format("Delete Acces_Login where UserName_User = '{0}' and Account_Type in ('Modérateur','User')", s1);
                SqlCommand cmd = new SqlCommand(querry, cn);
                int k = cmd.ExecuteNonQuery();
                if (k != 0)
                {
                    t.Rows.Clear();
                    MessageBox.Show("l'utilisateur a été Supprimé");
                    b1 = true;
                }
                else
                {
                    MessageBox.Show("l'utilisateur n'a pas été Supprimé");

                }
                cn.Close();
            }
            catch (Exception EX)
            {

                MessageBox.Show(EX.Message);
            }
        }
        void chercher(String S)
        {
            cn = Methode.ConnectSqlserver();
            string querry = string.Format("select UserName_User as 'Nom d''utilisateur',Password_User as 'Mot de passe',Account_Type as 'Compte Type' from Acces_Login where UserName_User = '{0}' and Account_Type in ('Modérateur','User')", S);
            t.Rows.Clear();
            SqlCommand cmd = new SqlCommand(querry, cn);
            SqlDataReader rd = cmd.ExecuteReader();
            t.Load(rd);
            DGV_USERS.DataSource = t;
            cn.Close();
        }
        void MainDGV()
        {
            cn = Methode.ConnectSqlserver();
            string querry = "select UserName_User as 'Nom d''utilisateur',Password_User as 'Mot de passe',Account_Type as 'Compte Type' from Acces_Login where Account_Type in ('Modérateur','User')";
            SqlCommand cmd = new SqlCommand(querry, cn);
            SqlDataReader dr = cmd.ExecuteReader();
            t.Load(dr);
            DGV_USERS.DataSource = t;
            cn.Close();
        }
        void clear()
        {
            TXT_FIND_BYUSER.Text = string.Empty;
            TXT_MDP_USER.Text = string.Empty;
            TXT_USER.Text = string.Empty;
            CB_TYPE_USER.SelectedIndex = -1;
            t.Rows.Clear();
        }

        private void Gestion_Users_Load(object sender, EventArgs e)
        {
            MainDGV();
        }

        private void BTN_SRCH_Click(object sender, EventArgs e)
        {
            chercher(TXT_FIND_BYUSER.Text);
        }

        private void BTN_CHARGER_Click(object sender, EventArgs e)
        {
            t.Rows.Clear();
            Gestion_Users_Load(sender, e);
        }

        private void BTN_RESET_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void BTN_DROP_Click(object sender, EventArgs e)
        {
            supprimer(TXT_USER.Text);
            if (b1 == true)
            {
                Gestion_Users_Load(sender, e);
                b1 = false;
            }
        }

        private void DGV_USERS_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            TXT_USER.Text = DGV_USERS.CurrentRow.Cells[0].Value.ToString();
            x = DGV_USERS.CurrentRow.Cells[0].Value.ToString();
            TXT_MDP_USER.Text = DGV_USERS.CurrentRow.Cells[1].Value.ToString();
            x1 = DGV_USERS.CurrentRow.Cells[1].Value.ToString();
            CB_TYPE_USER.SelectedItem = DGV_USERS.CurrentRow.Cells[2].Value.ToString();
            x2 = DGV_USERS.CurrentRow.Cells[2].Value.ToString();
            TXT_FIND_BYUSER.Text = DGV_USERS.CurrentRow.Cells[0].Value.ToString();
        }

        private void BTN_MAJ_Click(object sender, EventArgs e)
        {
            MAJ();
            if (b1 == true)
            {
                BTN_SRCH_Click(sender, e);
                clear();
                chercher(x);
            }
        }
    }
}
