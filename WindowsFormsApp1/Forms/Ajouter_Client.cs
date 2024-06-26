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
    public partial class Ajouter_Client : Form
    {
        public Ajouter_Client()
        {
            InitializeComponent();
        }
        SqlConnection cn;
         bool checkDGV()
         {
            bool x = false;
            for (int i = 0; i < dataGridView_guest.Rows.Count; i++)
            {
                if (txt_CLT_ID.Text == dataGridView_guest.Rows[i].Cells[0].Value.ToString())
                {
                    x = true;
                }         
            }
            return x;
         }
        void clearCLT()
        {
            txt_CLT_pren.Clear();
            txt_CLT_nom.Clear();
            cb_gender.SelectedIndex = -1;
            dtp_ddn.ResetText();
            txt_CLT_adresse.Clear();
            txt_clt_ville.Clear();
            txt_CLT_pays.Clear();
            txt_CLT_numero.Clear();
            Cb_DocumentType.ResetText();
            txt_FaxClient.Clear();
            txt_numDoc.Clear();
            txt_Website.Clear();
            txt_Email.Clear();
            txt_CodePostal.Clear();
        }
        private int autoSETID(int i)
        {
            int x = 0;
            cn = Methode.ConnectSqlserver();
            SqlCommand cmd = new SqlCommand("select top 1 ID_Client from Client_Table order by ID_Client desc", cn);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                x = int.Parse(dr[0].ToString());
            }
            cn.Close();
            return x + i;
        }
        DataTable t = new DataTable();

        void ChargeCLT()
        {
            t.Rows.Clear();
            cn = Methode.ConnectSqlserver();
            SqlCommand cmd = new SqlCommand("SELECT ID_Client as 'Identity Client',FName_Client as 'Prénom',LName_Client as 'Nom',Gender_Client as 'Sexe',dob_Client as 'Date Naissance',Country_Guest as 'Pays',City_Client as 'Ville',Address_Client as 'Adresse',Code_Postal as 'Code Postal',ContactNo_Client as 'Numéro',Type_Document as 'Document Type',N_Document as 'Numéro de document',Website_Client as 'SiteWeb',ContactFAX_Client as 'FAX',eMail_Address as 'E-mail' FROM Client_Table", cn);
            SqlDataReader dr = cmd.ExecuteReader();
            t.Load(dr);
            dataGridView_guest.DataSource = null;
            dataGridView_guest.DataSource = t;
            dataGridView_guest.ClearSelection();
            dr.Close();
            cn.Close();
        }
        bool ExistGuest(string x)
        {
            bool a = false;
            try
            {
                Program.cn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Guest_Table WHERE ID_Guest ='" + x + "'", Program.cn);
                SqlDataReader dr = cmd.ExecuteReader();
                a = dr.HasRows;
                dr.Close();
                Program.cn.Close();
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
            }
            return a;
        }
        //void ClearGuestManagement()
        //{
        //    textBox_mian_guest_id.Clear();
        //    textBox_mian_guest_name.Clear();
        //    textBox_mian_guest_gender.Clear();
        //    textBox_mian_guest_religion.Clear();
        //    textBox_mian_guest_company.Clear();
        //    textBox_mian_guest_address.Clear();
        //    textBox_mian_guest_city.Clear();
        //    textBox_mian_guest_country.Clear();
        //    textBox_mian_guest_contact.Clear();
        //    textBox_mian_guest_idtype.Clear();
        //    textBox_mian_guest_idno.Clear();
        //    dataGridView_guest.ClearSelection();
        //}

        


        private void button_GM_reset_Click(object sender, EventArgs e)
        {
            //ClearGuestManagement();
        }

        private void button_GM_add_Click(object sender, EventArgs e)
        {
            //if (textBox_mian_guest_id.Text == string.Empty || textBox_mian_guest_name.Text == string.Empty || textBox_mian_guest_gender.Text == string.Empty || textBox_mian_guest_religion.Text == string.Empty || textBox_mian_guest_company.Text == string.Empty || textBox_mian_guest_address.Text == string.Empty || textBox_mian_guest_city.Text == string.Empty || textBox_mian_guest_country.Text == string.Empty || textBox_mian_guest_contact.Text == string.Empty || textBox_mian_guest_idtype.Text == string.Empty || textBox_mian_guest_idno.Text == string.Empty)
            //{
            //    MessageBox.Show("The fields must be filled out first", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //else if (ExistGuest(textBox_mian_guest_id.Text) == true)
            //{
            //    MessageBox.Show("Guest Id already exists", "", MessageBoxButtons.OK, MessageBoxIcon.Question);
            //}
            //else
            //{
            //    try
            //    {
            //        Program.cn.Open();
            //        string h = string.Format("INSERT INTO Guest_Table VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}')", textBox_mian_guest_id.Text, textBox_mian_guest_name.Text, textBox_mian_guest_gender.Text, textBox_mian_guest_religion.Text, textBox_mian_guest_company.Text, textBox_mian_guest_address.Text, textBox_mian_guest_city.Text, textBox_mian_guest_country.Text, textBox_mian_guest_contact.Text, textBox_mian_guest_idtype.Text, textBox_mian_guest_idno.Text);
            //        SqlCommand cmd = new SqlCommand(h, Program.cn);
            //        int k = cmd.ExecuteNonQuery();
            //        if (k == 0)
            //        {
            //            MessageBox.Show("please try again", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        }
            //        else
            //        {
            //            MessageBox.Show("Add guest done successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Question);
            //        }
            //    }
            //    catch (SqlException s)
            //    {
            //        MessageBox.Show(s.Message);
            //    }
            //}
            //Program.cn.Close();
            //ClearGuestManagement();
            //ChargeGuest();
            int years = (int)((DateTime.Now - dtp_ddn.Value).TotalDays / 365);
            try
            {
                if (txt_CLT_nom.Text.Equals(string.Empty) || txt_CLT_pren.Text.Equals(string.Empty) || txt_CLT_pays.Text.Equals(string.Empty) || txt_CLT_adresse.Text.Equals(string.Empty) || txt_CLT_adresse.Text.Equals(string.Empty) || cb_gender.SelectedIndex.Equals(-1) || Cb_DocumentType.SelectedIndex.Equals(-1) || txt_numDoc.Text.Equals(string.Empty) || txt_CodePostal.Text.Equals(string.Empty))
                {
                    MessageBox.Show("vous devez ajouter toutes les informations", "nécessité", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (checkDGV() == true)
                {
                    MessageBox.Show("veuillez actualiser car l'identité existe déjà");
                }
                else if (years < 18)
                {
                    MessageBox.Show("you have to be adult to join our services");
                }
                else
                {
                    string Q1 = string.Format("INSERT INTO Client_Table VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}')", txt_CLT_pren.Text, txt_CLT_nom.Text, cb_gender.SelectedItem.ToString(), dtp_ddn.Value.ToString(),txt_CLT_adresse.Text,txt_CodePostal.Text, txt_clt_ville.Text,txt_CLT_pays.Text,txt_CLT_numero.Text,Cb_DocumentType.SelectedItem.ToString(),txt_numDoc.Text,txt_Website.Text,txt_FaxClient.Text,txt_Email.Text);
                    cn = Methode.ConnectSqlserver();
                    SqlCommand cmd = new SqlCommand(Q1, cn);
                    int check = cmd.ExecuteNonQuery();
                    if (check != 0)
                    {
                        MessageBox.Show("Le client a été ajouté avec succès");
                        ChargeCLT();
                        clearCLT();
                        txt_CLT_ID.Text = autoSETID(1).ToString();
                        cn.Close();
                    }
                }
            }
            catch (Exception EX)
            {

                MessageBox.Show(EX.Message);
            }
            }

        private void button_GM_reset_Click_1(object sender, EventArgs e)
        {
            clearCLT();
            t.Rows.Clear();
            txt_CLT_ID.Text = autoSETID(1).ToString();
        }

        private void Ajouter_Client_Load(object sender, EventArgs e)
        {
            txt_CLT_ID.Text = autoSETID(1).ToString();
        }

        private void dataGridView_guest_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txt_CLT_ID.Text = dataGridView_guest.CurrentRow.Cells[0].Value.ToString();
            txt_CLT_pren.Text = dataGridView_guest.CurrentRow.Cells[1].Value.ToString();
            txt_CLT_nom.Text = dataGridView_guest.CurrentRow.Cells[2].Value.ToString();
            cb_gender.SelectedItem = dataGridView_guest.CurrentRow.Cells[3].Value.ToString();
            dtp_ddn.Text = dataGridView_guest.CurrentRow.Cells[4].Value.ToString();
            txt_CLT_adresse.Text = dataGridView_guest.CurrentRow.Cells[7].Value.ToString();
            txt_clt_ville.Text = dataGridView_guest.CurrentRow.Cells[6].Value.ToString();
            txt_CLT_pays.Text = dataGridView_guest.CurrentRow.Cells[5].Value.ToString();
            txt_CLT_numero.Text = dataGridView_guest.CurrentRow.Cells[9].Value.ToString();
            Cb_DocumentType.SelectedItem = dataGridView_guest.CurrentRow.Cells[10].Value.ToString();
            txt_numDoc.Text = dataGridView_guest.CurrentRow.Cells[11].Value.ToString();
            txt_Website.Text = dataGridView_guest.CurrentRow.Cells[12].Value.ToString();
            txt_FaxClient.Text = dataGridView_guest.CurrentRow.Cells[13].Value.ToString();
            txt_Email.Text = dataGridView_guest.CurrentRow.Cells[14].Value.ToString();
            txt_CodePostal.Text = dataGridView_guest.CurrentRow.Cells[8].Value.ToString();
        }

        private void btn_loadDGV_Click(object sender, EventArgs e)
        {
            ChargeCLT();
        }

        private void txt_FaxClient_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '+')
            {
                e.Handled = true;
            }
        }

        private void txt_CLT_numero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '+')
            {
                e.Handled = true;
            }
        }
    }

    
}


