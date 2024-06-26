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
    public partial class Gestion_Des_Clients : Form
    {
        public Gestion_Des_Clients()
        {
            InitializeComponent();
        }
        SqlConnection cn;
        DataTable t = new DataTable();
        void ClearGuestManagement()
        {
            //textBox_mian_guest_id.Clear();
            //textBox_mian_guest_name.Clear();
            //textBox_mian_guest_gender.Clear();
            //textBox_mian_guest_religion.Clear();
            //textBox_mian_guest_company.Clear();
            //textBox_mian_guest_address.Clear();
            //textBox_mian_guest_city.Clear();
            //textBox_mian_guest_country.Clear();
            //textBox_mian_guest_contact.Clear();
            //textBox_mian_guest_idtype.Clear();
            //textBox_mian_guest_idno.Clear();
            //dataGridView_SG_guest.ClearSelection();
        }
        void clearCLT()
        {
            txt_CLT_ID.Clear();
            txt_CLT_pren.Clear();
            txt_CLT_nom.Clear();
            cb_gender.SelectedIndex =   -1;
            dtp_ddn.ResetText();
            txt_CLT_adresse.Clear();
            txt_clt_ville.Clear();
            txt_CLT_pays.Clear();
            txt_CLT_numero.Clear();
            txt_postal.Clear();
            cb_typeDOC.SelectedIndex = -1;
            txt_NumDoc.Clear();
            txt_Website.Clear();
            txt_Numfax.Clear();
            txt_Email.Clear();
            textBox_SG_id.Clear();
            textBox_SG_name.Clear();
        }

        bool ExistGuest(string x)
        {
            bool a = false;
            try
            {
                cn = Methode.ConnectSqlserver();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Client_Table WHERE ID_Client ='" + x + "'",cn);
                SqlDataReader dr = cmd.ExecuteReader();
                a = dr.HasRows;
                dr.Close();
                cn.Close();
            }
            catch (SqlException EX)
            {
                MessageBox.Show(EX.Message);
            }
            return a;
        }
        void ClearGuest()
        {
            //textBox_mian_guest_id.Clear();
            //textBox_mian_guest_name.Clear();
            //textBox_mian_guest_gender.Clear();
            //textBox_mian_guest_religion.Clear();
            //textBox_mian_guest_company.Clear();
            //textBox_mian_guest_address.Clear();
            //textBox_mian_guest_city.Clear();
            //textBox_mian_guest_country.Clear();
            //textBox_mian_guest_contact.Clear();
            //textBox_mian_guest_idtype.Clear();
            //textBox_mian_guest_idno.Clear();
        }
        void ChargeCLT()
        {
            cn = Methode.ConnectSqlserver();
            SqlCommand cmd = new SqlCommand("SELECT ID_Client as 'Identity Client',FName_Client as 'Prénom',LName_Client as 'Nom',Gender_Client as 'Sexe',dob_Client as 'Date Naissance',Country_Guest as 'Pays',City_Client as 'Ville',Address_Client as 'Adresse',Code_Postal as 'Code Postal',ContactNo_Client as 'Numéro',Type_Document as 'Document Type',N_Document as 'Numéro de document',Website_Client as 'SiteWeb',ContactFAX_Client as 'FAX',eMail_Address as 'E-mail' FROM Client_Table", cn);
            SqlDataReader dr = cmd.ExecuteReader();
            t.Load(dr);
            dataGridView_SG_guest.DataSource = null;
            dataGridView_SG_guest.DataSource = t;
            dataGridView_SG_guest.ClearSelection();
            dr.Close();
            cn.Close();
        }
        void ChargeGuest()
        {
            Program.cn.Open();
            SqlCommand cmd = new SqlCommand("SELECT ID_Guest as 'Id', Name_Guest as 'Name', Gender_Guest as 'Gender', Religion_Guest as 'Religion', Company_Guest as 'Company', Address_Guest as 'Address', City_Guest as 'City', Country_Guest as 'Country', ContactNo_Guest as 'Contact No', IdType_Guest as 'Id Type', IdNumber_Guest as 'Id Number' FROM Guest_Table", Program.cn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable t = new DataTable();
            t.Load(dr);
            dataGridView_SG_guest.DataSource = null;
            dataGridView_SG_guest.DataSource = t;
            dataGridView_SG_guest.ClearSelection();
            dr.Close();
            Program.cn.Close();
        }


        private void button_SG_search_Click(object sender, EventArgs e)
        {
            //if (textBox_SG_id.Text == string.Empty && textBox_SG_name.Text == string.Empty)
            //{
            //    MessageBox.Show("The field must be filled out first", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //else if (textBox_SG_id.Text != string.Empty || textBox_SG_name.Text == string.Empty)
            //{
            //    try
            //    {
            //        Program.cn.Open();
            //        string h = string.Format("SELECT * FROM Guest_table WHERE ID_Guest = '{0}'", textBox_SG_id.Text);
            //        SqlCommand cmd = new SqlCommand(h, Program.cn);
            //        SqlDataReader dr = cmd.ExecuteReader();
            //        DataTable t = new DataTable();
            //        t.Load(dr);
            //        dataGridView_SG_guest.DataSource = null;
            //        dataGridView_SG_guest.DataSource = t;
            //        dataGridView_SG_guest.ClearSelection();
            //        dr.Close();
            //        Program.cn.Close();
            //    }
            //    catch (SqlException s)
            //    {
            //        MessageBox.Show(s.Message);
            //    }
            //}
            //else if (textBox_SG_name.Text != string.Empty || textBox_SG_id.Text == string.Empty)
            //{
            //    try
            //    {
            //        Program.cn.Open();
            //        string h = string.Format("SELECT * FROM Guest_table WHERE Name_Guest = '{0}'", textBox_SG_name.Text);
            //        SqlCommand cmd = new SqlCommand(h, Program.cn);
            //        SqlDataReader dr = cmd.ExecuteReader();
            //        DataTable t = new DataTable();
            //        t.Load(dr);
            //        dataGridView_SG_guest.DataSource = null;
            //        dataGridView_SG_guest.DataSource = t;
            //        dataGridView_SG_guest.ClearSelection();
            //        dr.Close();
            //        Program.cn.Close();
            //    }
            //    catch (SqlException s)
            //    {
            //        MessageBox.Show(s.Message);
            //    }
            //}
            //else if (textBox_SG_name.Text != string.Empty || textBox_SG_id.Text != string.Empty)
            //{
            //    try
            //    {
            //        Program.cn.Open();
            //        string h = string.Format("SELECT * FROM Guest_table WHERE ID_Guest = '{0}' AND Name_Guest = '{1}'", textBox_SG_id.Text, textBox_SG_name.Text);
            //        SqlCommand cmd = new SqlCommand(h, Program.cn);
            //        SqlDataReader dr = cmd.ExecuteReader();
            //        DataTable t = new DataTable();
            //        t.Load(dr);
            //        dataGridView_SG_guest.DataSource = null;
            //        dataGridView_SG_guest.DataSource = t;
            //        dataGridView_SG_guest.ClearSelection();
            //        dr.Close();
            //        Program.cn.Close();
            //    }
            //    catch (SqlException s)
            //    {
            //        MessageBox.Show(s.Message);
            //    }
            //}
        }

        //private void button_SG_reset_Click(object sender, EventArgs e)
        //{
        //    textBox_SG_id.Clear();
        //    textBox_SG_name.Clear();
        //    ChargeGuest();
        //}

        private void dataGridView_SG_guest_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //if (dataGridView_SG_guest.SelectedRows.Count > 0)
            //{
            //    textBox_mian_guest_id.Text = dataGridView_SG_guest.CurrentRow.Cells[0].Value.ToString();
            //    textBox_mian_guest_name.Text = dataGridView_SG_guest.CurrentRow.Cells[1].Value.ToString();
            //    textBox_mian_guest_gender.Text = dataGridView_SG_guest.CurrentRow.Cells[2].Value.ToString();
            //    textBox_mian_guest_religion.Text = dataGridView_SG_guest.CurrentRow.Cells[3].Value.ToString();
            //    textBox_mian_guest_company.Text = dataGridView_SG_guest.CurrentRow.Cells[4].Value.ToString();
            //    textBox_mian_guest_address.Text = dataGridView_SG_guest.CurrentRow.Cells[5].Value.ToString();
            //    textBox_mian_guest_city.Text = dataGridView_SG_guest.CurrentRow.Cells[6].Value.ToString();
            //    textBox_mian_guest_country.Text = dataGridView_SG_guest.CurrentRow.Cells[7].Value.ToString();
            //    textBox_mian_guest_contact.Text = dataGridView_SG_guest.CurrentRow.Cells[8].Value.ToString();
            //    textBox_mian_guest_idtype.Text = dataGridView_SG_guest.CurrentRow.Cells[9].Value.ToString();
            //    textBox_mian_guest_idno.Text = dataGridView_SG_guest.CurrentRow.Cells[10].Value.ToString();
            //}
    }

        private void button_main_guest_clear_Click(object sender, EventArgs e)
        {
            ClearGuest();
        }

        private void button_GM_update_Click(object sender, EventArgs e)
        {
            //if (textBox_mian_guest_id.Text == string.Empty || textBox_mian_guest_name.Text == string.Empty || textBox_mian_guest_gender.Text == string.Empty || textBox_mian_guest_religion.Text == string.Empty || textBox_mian_guest_company.Text == string.Empty || textBox_mian_guest_address.Text == string.Empty || textBox_mian_guest_city.Text == string.Empty || textBox_mian_guest_country.Text == string.Empty || textBox_mian_guest_contact.Text == string.Empty || textBox_mian_guest_idtype.Text == string.Empty || textBox_mian_guest_idno.Text == string.Empty)
            //{
            //    MessageBox.Show("Not all fields are full", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //else if (ExistGuest(textBox_mian_guest_id.Text) == false)
            //{
            //    MessageBox.Show("Guest Id doesn't exist", "", MessageBoxButtons.OK, MessageBoxIcon.Question);
            //}
            //else
            //{
            //    try
            //    {
            //        Program.cn.Open();
            //        string h = string.Format("UPDATE Guest_Table SET Name_Guest='{0}', Gender_Guest = '{1}', Religion_Guest='{2}', Company_Guest = '{3}' , Address_Guest = '{4}' , City_Guest = '{5}' , Country_Guest = '{6}' , ContactNo_Guest='{7}' , IdType_Guest = '{8}' , IdNumber_Guest = '{9}' WHERE ID_Guest = '{10}'", textBox_mian_guest_name.Text, textBox_mian_guest_gender.Text, textBox_mian_guest_religion.Text, textBox_mian_guest_company.Text, textBox_mian_guest_address.Text, textBox_mian_guest_city.Text, textBox_mian_guest_country.Text, textBox_mian_guest_contact.Text, textBox_mian_guest_idtype.Text, textBox_mian_guest_idno.Text, textBox_mian_guest_id.Text);
            //        SqlCommand cmd = new SqlCommand(h, Program.cn);
            //        int k = cmd.ExecuteNonQuery();
            //        if (k == 0)
            //        {
            //            MessageBox.Show("please try again", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        }
            //        else
            //        {
            //            MessageBox.Show("Update guest done successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Question);
            //        }
            //    }
            //    catch (SqlException s)
            //    {
            //        MessageBox.Show(s.Message);
            //    }
            //}
            //Program.cn.Close();
            //ChargeGuest();
        }

        private void button_GM_delete_Click(object sender, EventArgs e)
        {
            //if (textBox_mian_guest_id.Text == string.Empty)
            //{
            //    MessageBox.Show("ID Guest field is obligation", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //else if (ExistGuest(textBox_mian_guest_id.Text) == false)
            //{
            //    MessageBox.Show("Guest ID does not exist", "", MessageBoxButtons.OK, MessageBoxIcon.Question);
            //}
            //else
            //{
            //    DialogResult result = MessageBox.Show("Are you want to delete this Guset", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //    if (DialogResult.Yes == result)
            //    {
            //        try
            //        {
            //            Program.cn.Open();
            //            string h = string.Format("DELETE Guest_Table WHERE ID_Guest = '{0}'", textBox_mian_guest_id.Text);
            //            SqlCommand cmd = new SqlCommand(h, Program.cn);
            //            int k = cmd.ExecuteNonQuery();
            //            if (k == 0)
            //            {
            //                MessageBox.Show("please try again", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //            }
            //            else
            //            {
            //                MessageBox.Show("Delete guest done successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Question);
            //                ClearGuestManagement();
            //            }
            //        }
            //        catch (SqlException s)
            //        {
            //            MessageBox.Show(s.Message);
            //        }
            //    }
            //}
            //Program.cn.Close();
            //ChargeGuest();
        }

        private void button_SG_search_Click_1(object sender, EventArgs e)
        {
            if (textBox_SG_id.Text == string.Empty && textBox_SG_name.Text == string.Empty)
            {
                MessageBox.Show("vous devez entrer l'identité ou le nom du client", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBox_SG_id.Text != string.Empty || textBox_SG_name.Text == string.Empty)
            {
                try
                {
                    SqlConnection cn = Methode.ConnectSqlserver();
                    string h = string.Format("SELECT ID_Client as 'Identity Client',FName_Client as 'Prénom',LName_Client as 'Nom',Gender_Client as 'Sexe',dob_Client as 'Date Naissance',Country_Guest as 'Pays',City_Client as 'Ville',Address_Client as 'Adresse',Code_Postal as 'Code Postal',ContactNo_Client as 'Numéro',Type_Document as 'Document Type',N_Document as 'Numéro de document',Website_Client as 'SiteWeb',ContactFAX_Client as 'FAX',eMail_Address as 'E-mail' FROM Client_Table WHERE ID_Client = '{0}'", textBox_SG_id.Text);
                    SqlCommand cmd = new SqlCommand(h, cn);
                    SqlDataReader dr = cmd.ExecuteReader();
                    DataTable t = new DataTable();
                    t.Load(dr);
                    dataGridView_SG_guest.DataSource = null;
                    dataGridView_SG_guest.DataSource = t;
                    dataGridView_SG_guest.ClearSelection();
                    dr.Close();
                    cn.Close();
                }
                catch (SqlException s)
                {
                    MessageBox.Show(s.Message);
                }
            }
            else if (textBox_SG_name.Text != string.Empty || textBox_SG_id.Text == string.Empty)
            {
                try
                {
                    cn = Methode.ConnectSqlserver();
                    string h = string.Format("SELECT ID_Client as 'Identity Client',FName_Client as 'Prénom',LName_Client as 'Nom',Gender_Client as 'Sexe',dob_Client as 'Date Naissance',Country_Guest as 'Pays',City_Client as 'Ville',Address_Client as 'Adresse',Code_Postal as 'Code Postal',ContactNo_Client as 'Numéro',Type_Document as 'Document Type',N_Document as 'Numéro de document',Website_Client as 'SiteWeb',ContactFAX_Client as 'FAX',eMail_Address as 'E-mail' FROM Client_Table where CONCAT(FName_Client,' ',LName_Client) = '{0}' or CONCAT(LName_Client,' ',FName_Client) = '{0}' or LName_Client = '{0}'", textBox_SG_name.Text);
                    SqlCommand cmd = new SqlCommand(h, cn);
                    SqlDataReader dr = cmd.ExecuteReader();
                    DataTable t = new DataTable();
                    t.Load(dr);
                    dataGridView_SG_guest.DataSource = null;
                    dataGridView_SG_guest.DataSource = t;
                    dataGridView_SG_guest.ClearSelection();
                    dr.Close();
                    cn.Close();
                }
                catch (SqlException s)
                {
                    MessageBox.Show(s.Message);
                }
            }
            else if (textBox_SG_name.Text != string.Empty || textBox_SG_id.Text != string.Empty)
            {
                try
                {
                    cn = Methode.ConnectSqlserver();
                    string h = string.Format("SELECT ID_Client as 'Identity Client',FName_Client as 'Prénom',LName_Client as 'Nom',Gender_Client as 'Sexe',dob_Client as 'Date Naissance',Country_Guest as 'Pays',City_Client as 'Ville',Address_Client as 'Adresse',Code_Postal as 'Code Postal',ContactNo_Client as 'Numéro',Type_Document as 'Document Type',N_Document as 'Numéro de document',Website_Client as 'SiteWeb',ContactFAX_Client as 'FAX',eMail_Address as 'E-mail' FROM Client_Table WHERE ID_Client = '{0}' AND CONCAT(FName_Client,' ',LName_Client) = '{1}' or CONCAT(LName_Client,' ',FName_Client) = '{1}' or LName_Client = '{1}'", textBox_SG_id.Text,textBox_SG_name);
                    SqlCommand cmd = new SqlCommand(h,cn);
                    SqlDataReader dr = cmd.ExecuteReader();
                    DataTable t = new DataTable();
                    t.Load(dr);
                    dataGridView_SG_guest.DataSource = null;
                    dataGridView_SG_guest.DataSource = t;
                    dataGridView_SG_guest.ClearSelection();
                    dr.Close();
                    cn.Close();
                }
                catch (SqlException s)
                {
                    MessageBox.Show(s.Message);
                }
            }
        }

        private void dataGridView_SG_guest_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            textBox_SG_id.Text = dataGridView_SG_guest.CurrentRow.Cells[0].Value.ToString();
            textBox_SG_name.Text = dataGridView_SG_guest.CurrentRow.Cells[1].Value.ToString() + " " + dataGridView_SG_guest.CurrentRow.Cells[2].Value.ToString();
            txt_CLT_ID.Text = dataGridView_SG_guest.CurrentRow.Cells[0].Value.ToString();
            txt_CLT_pren.Text = dataGridView_SG_guest.CurrentRow.Cells[1].Value.ToString();
            txt_CLT_nom.Text = dataGridView_SG_guest.CurrentRow.Cells[2].Value.ToString();
            cb_gender.SelectedItem = dataGridView_SG_guest.CurrentRow.Cells[3].Value.ToString();
            dtp_ddn.Text = dataGridView_SG_guest.CurrentRow.Cells[4].Value.ToString();
            txt_CLT_adresse.Text = dataGridView_SG_guest.CurrentRow.Cells[7].Value.ToString();
            txt_clt_ville.Text = dataGridView_SG_guest.CurrentRow.Cells[6].Value.ToString();
            txt_CLT_pays.Text = dataGridView_SG_guest.CurrentRow.Cells[5].Value.ToString();
            txt_CLT_numero.Text = dataGridView_SG_guest.CurrentRow.Cells[9].Value.ToString();
            cb_typeDOC.SelectedItem = dataGridView_SG_guest.CurrentRow.Cells[10].Value.ToString();
            txt_NumDoc.Text = dataGridView_SG_guest.CurrentRow.Cells[11].Value.ToString();
            txt_Website.Text = dataGridView_SG_guest.CurrentRow.Cells[12].Value.ToString();
            txt_Numfax.Text = dataGridView_SG_guest.CurrentRow.Cells[13].Value.ToString();
            txt_Email.Text = dataGridView_SG_guest.CurrentRow.Cells[14].Value.ToString();
            txt_postal.Text = dataGridView_SG_guest.CurrentRow.Cells[8].Value.ToString();
        }

        private void button_GM_update_Click_1(object sender, EventArgs e)
        {
            if (txt_CLT_ID.Text.Equals(string.Empty) && textBox_SG_id.Text.Equals(string.Empty))
            {
                MessageBox.Show("Vous devez ajouter toutes les informations", "nécessité", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (ExistGuest(txt_CLT_ID.Text) == false)
            {
                MessageBox.Show("Ce client n'existe pas veuillez vérifier l'identité du client", "", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else
            {
                try
                {
                    cn = Methode.ConnectSqlserver();
                    string h = string.Format("UPDATE Client_Table SET FName_Client='{0}', LName_Client = '{1}', Gender_Client='{2}', dob_Client = '{3}' , Address_Client = '{4}' , City_Client = '{5}' , Country_Guest = '{6}' , ContactNo_Client='{7}',Type_Document = '{9}',N_Document = '{10}',Website_Client = '{11}',ContactFAX_Client = '{12}',eMail_Address = '{13}',Code_Postal = '{14}'  WHERE ID_Client = '{8}'", txt_CLT_pren.Text, txt_CLT_nom.Text, cb_gender.SelectedItem.ToString(), dtp_ddn.Value.ToString(), txt_CLT_adresse.Text, txt_clt_ville.Text, txt_CLT_pays.Text, txt_CLT_numero.Text, txt_CLT_ID.Text,cb_typeDOC.SelectedItem.ToString(),txt_NumDoc.Text,txt_Website.Text,txt_Numfax.Text,txt_Email.Text,txt_postal.Text);
                    SqlCommand cmd = new SqlCommand(h, cn);
                    int k = cmd.ExecuteNonQuery();
                    if (k != 0)
                    {
                        MessageBox.Show("la mise à jour du client a réussi", "réussi", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        button_SG_search_Click_1(sender,e);
                    }
                    else
                    {
                        MessageBox.Show("la mise à jour du client a échoué, veuillez réessayer", "échec", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    cn.Close();
                    clearCLT();
                }
                catch (Exception EX)
                {

                    MessageBox.Show(EX.Message);
                }
            }
            

        }



        private void button_SG_Charger_Click(object sender, EventArgs e)
        {
            t.Rows.Clear();
            ChargeCLT();
        }

        private void button_SG_reset_Click_2(object sender, EventArgs e)
        {
            clearCLT();
            t.Rows.Clear();
        }

        private void button_GM_delete_Click_1(object sender, EventArgs e)
        {
            if (textBox_SG_id.Text == string.Empty && textBox_SG_name.Text == string.Empty)
            {
                MessageBox.Show("vous devez entrer l'identité ou le nom du client", "échec", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBox_SG_id.Text != string.Empty || textBox_SG_name.Text == string.Empty)
            {
                try
                {
                    SqlConnection cn = Methode.ConnectSqlserver();
                    string h = string.Format("Delete FROM Client_Table WHERE ID_Client = '{0}'", textBox_SG_id.Text);
                    SqlCommand cmd = new SqlCommand(h, cn);
                    if (MessageBox.Show("vous voulez vraiment supprimer ce client", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        int k1 = cmd.ExecuteNonQuery();
                        if (k1 != 0)
                        {
                            MessageBox.Show("le client vous voulez vraiment supprimer", "réussi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            button_SG_search_Click_1(sender, e);
                            clearCLT();
                        }
                        else
                        {
                            MessageBox.Show("le client n'a pas été supprimé, veuillez vérifier l'identité ou le nom", "échec", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    cn.Close();
                }
                catch (SqlException s)
                {
                    MessageBox.Show(s.Message);
                }
            }
            else if (textBox_SG_name.Text != string.Empty || textBox_SG_id.Text == string.Empty)
            {
                try
                {
                    cn = Methode.ConnectSqlserver();
                    string h = string.Format("delete from Client_Table where CONCAT(FName_Client,' ',LName_Client) = '{0}' or CONCAT(LName_Client,' ',FName_Client) = '{0}' or LName_Client = '{0}'", textBox_SG_name.Text);
                    SqlCommand cmd = new SqlCommand(h, cn);
                    int k2 = cmd.ExecuteNonQuery();
                    if (k2 != 0)
                    {
                        MessageBox.Show("le client a été supprimé avec succès", "réussi", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        button_SG_search_Click_1(sender, e);
                        clearCLT();
                    }
                    else
                    {
                        MessageBox.Show("le client n'a pas été supprimé, veuillez vérifier l'identité ou le nom", "échec", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    cn.Close();
                }
                catch (SqlException s)
                {
                    MessageBox.Show(s.Message);
                }
            }
            else if (textBox_SG_name.Text != string.Empty || textBox_SG_id.Text != string.Empty)
            {
                try
                {
                    cn = Methode.ConnectSqlserver();
                    string h = string.Format("delete FROM Client_Table WHERE ID_Client = '{0}' AND CONCAT(FName_Client,' ',LName_Client) = '{1}' or CONCAT(LName_Client,' ',FName_Client) = '{1}' or LName_Client = '{1}'", textBox_SG_id.Text, textBox_SG_name);
                    SqlCommand cmd = new SqlCommand(h, cn);
                    int k3 = cmd.ExecuteNonQuery();
                    if (k3 != 0)
                    {
                        MessageBox.Show("le client a été supprimé avec succès", "réussi", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        button_SG_search_Click_1(sender, e);
                        clearCLT();
                    }
                    else
                    {
                        MessageBox.Show("le client n'a pas été supprimé, veuillez vérifier l'identité ou le nom", "échec", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    cn.Close();
                }
                catch (SqlException s)
                {
                    MessageBox.Show(s.Message);
                }
            }
        }
    }
}
