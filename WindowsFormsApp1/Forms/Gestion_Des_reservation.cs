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
    public partial class Gestion_Des_reservation : Form
    {

        public Gestion_Des_reservation()
        {
            InitializeComponent();
        }
        SqlConnection cn;
        DataSet Ds = new DataSet();
        DataTable t = new DataTable();
        string chaine = "Select NReservation,LName_Client as 'Nom',FName_Client as 'Prénom',Reservation_Table.ID_logement,type_logement,N_logement,Reservation_Table.ID_Client,DateIn_Reservation,DateOut_Reservation,N_couple_Reservation,N_Extra_Person_Reservation,Room_Service_Charges_Reservation from Reservation_Table join Client_Table on Reservation_Table.ID_Client = Client_Table.ID_Client inner join logement_Table on logement_Table.ID_logement = Reservation_Table.ID_logement";
        void charger()
        {
            cn = Methode.ConnectSqlserver();
            string Querry = "Select NReservation,LName_Client as 'Nom',FName_Client as 'Prénom',Reservation_Table.ID_logement,type_logement,N_logement,Reservation_Table.ID_Client,DateIn_Reservation,DateOut_Reservation,N_couple_Reservation,N_Extra_Person_Reservation,Room_Service_Charges_Reservation from Reservation_Table join Client_Table on Reservation_Table.ID_Client = Client_Table.ID_Client inner join logement_Table on logement_Table.ID_logement = Reservation_Table.ID_logement";
            SqlCommand cmd = new SqlCommand(Querry,cn);
            SqlDataReader rd = cmd.ExecuteReader();
            t.Load(rd);
            DGV_Res.DataSource = null;
            DGV_Res.DataSource = t;
            DGV_Res.ClearSelection();
            rd.Close();
            cn.Close();
        }
        void clear()
        {
            TXT_SRCH_NOM.Text = string.Empty;
            TXT_SRCH_NOM2.Text = string.Empty;
            TXT_SRSH_ID.Text = string.Empty;
            textBox_reserv_Noreservation.Text = string.Empty;
            TXT_CLT_ID.Text = string.Empty;
            TXT_N_Logement.Text = string.Empty;
            TXT_Type_Logement.Text = string.Empty;
            dateTimePicker_reserv_datein.ResetText();
            dateTimePicker_reserv_dateout.ResetText();
            numericUpDown_NB_couple.Value = 0;
            numericUpDown_reserv_ExtratPerson.Value = 0;
            Prix_Service.Text.Equals(string.Empty);
        }
        void chercher(string x)
        {
            cn = Methode.ConnectSqlserver();
            string querry = string.Format("Select NReservation,LName_Client as 'Nom',FName_Client as 'Prénom',Reservation_Table.ID_logement,type_logement,N_logement,Reservation_Table.ID_Client,DateIn_Reservation,DateOut_Reservation,N_couple_Reservation,N_Extra_Person_Reservation,Room_Service_Charges_Reservation from Reservation_Table join Client_Table on Reservation_Table.ID_Client = Client_Table.ID_Client inner join logement_Table on logement_Table.ID_logement = Reservation_Table.ID_logement where NReservation = '{0}'", x);
            SqlCommand cmd = new SqlCommand(querry,cn);
            SqlDataReader dr = cmd.ExecuteReader();
            t.Rows.Clear();
            t.Load(dr);
            DGV_Res.DataSource = null;
            DGV_Res.DataSource = t;
            DGV_Res.ClearSelection();
            cn.Close();
        }
        void ChercherParNom()
        {
            if (TXT_CLT_ID.Text != string.Empty && TXT_SRCH_NOM.Text != string.Empty && TXT_SRCH_NOM2.Text != string.Empty)
            {
                cn = Methode.ConnectSqlserver();
                string querry = string.Format(chaine + " where FName_Client = '{0}' and LName_Client = '{1}' and Reservation_Table.NReservation = '{2}' ", TXT_SRCH_NOM.Text, TXT_SRCH_NOM2.Text,TXT_SRSH_ID.Text);
                SqlCommand cmd = new SqlCommand(querry, cn);
                SqlDataReader dr = cmd.ExecuteReader();
                t.Rows.Clear();
                t.Load(dr);
                DGV_Res.DataSource = t;
                cn.Close();
            }
            else if (TXT_CLT_ID.Text == string.Empty && TXT_SRCH_NOM.Text == string.Empty && TXT_SRCH_NOM2.Text == string.Empty)
            {
                MessageBox.Show("Vous ne pouvez pas effectuer de recherche sans entrer les informations de réservation");
            }
            else if (TXT_SRCH_NOM.Text != string.Empty && TXT_SRCH_NOM2.Text != string.Empty)
            {
                cn = Methode.ConnectSqlserver();
                string querry = string.Format(chaine + " where FName_Client = '{0}' and LName_Client = '{1}'", TXT_SRCH_NOM.Text, TXT_SRCH_NOM2.Text);
                SqlCommand cmd = new SqlCommand(querry, cn);
                SqlDataReader dr = cmd.ExecuteReader();
                t.Rows.Clear();
                t.Load(dr);
                DGV_Res.DataSource = t;
                cn.Close();
            }
            else if (TXT_SRCH_NOM2.Text != string.Empty && TXT_SRSH_ID.Text != string.Empty)
            {
                cn = Methode.ConnectSqlserver();
                string querry = string.Format(chaine + " where LName_Client = '{0}' and Reservation_Table.NReservation = '{1}'", TXT_SRCH_NOM2.Text, TXT_SRSH_ID.Text);
                SqlCommand cmd = new SqlCommand(querry, cn);
                SqlDataReader dr = cmd.ExecuteReader();
                t.Rows.Clear();
                t.Load(dr);
                DGV_Res.DataSource = t;
                cn.Close();
            }
            else if (TXT_SRSH_ID.Text != String.Empty && TXT_SRCH_NOM.Text != string.Empty || TXT_SRCH_NOM.Text == string.Empty && TXT_SRCH_NOM2.Text == string.Empty)
            {
                cn = Methode.ConnectSqlserver();
                string querry = string.Format(chaine +" where  Reservation_Table.NReservation = '{0}'", TXT_SRSH_ID.Text);
                SqlCommand cmd = new SqlCommand(querry, cn);
                SqlDataReader dr = cmd.ExecuteReader();
                t.Rows.Clear();
                t.Load(dr);
                DGV_Res.DataSource = t;
                cn.Close();
            }
            
            else
            {
                MessageBox.Show("Pour effectuer une recherche, vous devez au moins renseigner le numéro de réservation ou le nom et prénom de la personne réserver");
            }

            //if (TXT_SRSH_ID.Text == string.Empty && TXT_SRCH_NOM.Text != string.Empty && TXT_SRCH_NOM2.Text != string.Empty)
            //{
            //    cn = Methode.ConnectSqlserver();
            //    string querry = string.Format("Select NReservation,LName_Client as 'Nom',FName_Client as 'Prénom',Reservation_Table.ID_logement,type_logement,N_logement,Reservation_Table.ID_Client,DateIn_Reservation,DateOut_Reservation,N_couple_Reservation,N_Extra_Person_Reservation,Room_Service_Charges_Reservation from Reservation_Table join Client_Table on Reservation_Table.ID_Client = Client_Table.ID_Client inner join logement_Table on logement_Table.ID_logement = Reservation_Table.ID_logement where CONCAT(FName_Client, ' ', LName_Client) = '{0}'+' '+'{1}' ", TXT_SRCH_NOM.Text, TXT_SRCH_NOM2.Text);
            //    SqlCommand cmd = new SqlCommand(querry, cn);
            //    SqlDataReader dr = cmd.ExecuteReader();
            //    t.Rows.Clear();
            //    t.Load(dr);
            //    DGV_Res.DataSource = t;
            //    cn.Close();
            //}
            //else if (TXT_SRCH_NOM2.Text != string.Empty && TXT_SRCH_NOM.Text == string.Empty)
            //{
            //    cn = Methode.ConnectSqlserver();
            //    string querry = string.Format("Select NReservation,LName_Client as 'Nom',FName_Client as 'Prénom',Reservation_Table.ID_logement,type_logement,N_logement,Reservation_Table.ID_Client,DateIn_Reservation,DateOut_Reservation,N_couple_Reservation,N_Extra_Person_Reservation,Room_Service_Charges_Reservation from Reservation_Table join Client_Table on Reservation_Table.ID_Client = Client_Table.ID_Client inner join logement_Table on logement_Table.ID_logement = Reservation_Table.ID_logement where LName_Client = '{0}'", TXT_SRCH_NOM2.Text);
            //    SqlCommand cmd = new SqlCommand(querry, cn);
            //    SqlDataReader dr = cmd.ExecuteReader();
            //    t.Rows.Clear();
            //    t.Load(dr);
            //    DGV_Res.DataSource = t;
            //    cn.Close();
            //}
            //else if (TXT_SRCH_NOM2.Text != string.Empty && TXT_SRCH_NOM.Text == string.Empty && TXT_SRSH_ID.Text != string.Empty)
            //{
            //    cn = Methode.ConnectSqlserver();
            //    string querry = string.Format("Select NReservation,LName_Client as 'Nom',FName_Client as 'Prénom',Reservation_Table.ID_logement,type_logement,N_logement,Reservation_Table.ID_Client,DateIn_Reservation,DateOut_Reservation,N_couple_Reservation,N_Extra_Person_Reservation,Room_Service_Charges_Reservation from Reservation_Table join Client_Table on Reservation_Table.ID_Client = Client_Table.ID_Client inner join logement_Table on logement_Table.ID_logement = Reservation_Table.ID_logement where NReservation = {1} and LName_Client = '{0}'", TXT_SRCH_NOM2.Text,TXT_SRSH_ID.Text);
            //    SqlCommand cmd = new SqlCommand(querry, cn);
            //    SqlDataReader dr = cmd.ExecuteReader();
            //    t.Rows.Clear();
            //    t.Load(dr);
            //    DGV_Res.DataSource = t;
            //    cn.Close();
            //}
            //else if (TXT_SRSH_ID.Text != string.Empty && TXT_SRCH_NOM.Text != string.Empty && TXT_SRCH_NOM2.Text != string.Empty)
            //{
            //    cn = Methode.ConnectSqlserver();
            //    string querry = string.Format("Select NReservation,LName_Client as 'Nom',FName_Client as 'Prénom',Reservation_Table.ID_logement,type_logement,N_logement,Reservation_Table.ID_Client,DateIn_Reservation,DateOut_Reservation,N_couple_Reservation,N_Extra_Person_Reservation,Room_Service_Charges_Reservation from Reservation_Table join Client_Table on Reservation_Table.ID_Client = Client_Table.ID_Client inner join logement_Table on logement_Table.ID_logement = Reservation_Table.ID_logement where CONCAT(FName_Client, ' ', LName_Client) = '{0}'+' '+'{1}' and  NReservation = '{2}'", TXT_SRCH_NOM.Text, TXT_SRCH_NOM2.Text,TXT_SRSH_ID.Text);
            //    SqlCommand cmd = new SqlCommand(querry, cn);
            //    SqlDataReader dr = cmd.ExecuteReader();
            //    t.Rows.Clear();
            //    t.Load(dr);
            //    DGV_Res.DataSource = t;
            //    cn.Close();
            //}
            //else if (TXT_SRSH_ID.Text != string.Empty && TXT_SRCH_NOM.Text == string.Empty)
            //{
            //    cn = Methode.ConnectSqlserver();
            //    string querry = string.Format("Select NReservation,LName_Client as 'Nom',FName_Client as 'Prénom',Reservation_Table.ID_logement,type_logement,N_logement,Reservation_Table.ID_Client,DateIn_Reservation,DateOut_Reservation,N_couple_Reservation,N_Extra_Person_Reservation,Room_Service_Charges_Reservation from Reservation_Table join Client_Table on Reservation_Table.ID_Client = Client_Table.ID_Client inner join logement_Table on logement_Table.ID_logement = Reservation_Table.ID_logement where NReservation = {0} ",TXT_SRSH_ID.Text);
            //    SqlCommand cmd = new SqlCommand(querry, cn);
            //    SqlDataReader dr = cmd.ExecuteReader();
            //    t.Rows.Clear();
            //    t.Load(dr);
            //    DGV_Res.DataSource = t;
            //    cn.Close();
            //}

        }

        //void ChargerNlog()
        //{
        //    Ds.Tables.Clear();
        //    string h = string.Format("select distinct ID_logement, N_logement from logement_Table where Status_logement = 'Indisponible' and type_logement ='{0}'", cb_typelogement.SelectedValue);
        //    cn = Methode.ConnectSqlserver();
        //    SqlDataAdapter dap = new SqlDataAdapter(h, cn);
        //    dap.Fill(Ds, "logement_T");
        //    cb_N_logement.DataSource = Ds.Tables["logement_T"];
        //    cb_N_logement.DisplayMember = "N_logement";
        //    cb_N_logement.ValueMember = "ID_logement";
        //    cb_N_logement.SelectedIndex = -1;
        //}
        void miseajoure()
        {
            cn = Methode.ConnectSqlserver();
            string querry = string.Format("update Reservation_Table set DateIn_Reservation = '{0}',DateOut_Reservation = '{1}',N_couple_Reservation = '{2}',N_Extra_Person_Reservation = '{3}',Room_Service_Charges_Reservation = '{4}'", dateTimePicker_reserv_datein.Value, dateTimePicker_reserv_dateout.Value, numericUpDown_NB_couple.Value, numericUpDown_reserv_ExtratPerson.Value, Prix_Service.Text);
            SqlCommand cmd = new SqlCommand(querry, cn);
            int k = cmd.ExecuteNonQuery();
            if (k != 0)
            {
                MessageBox.Show("la mise à jour du client a réussi", "réussi", MessageBoxButtons.OK, MessageBoxIcon.Question);
                chercher(textBox_reserv_Noreservation.Text);
            }
            else
            {
                MessageBox.Show("la mise à jour du client a échoué, veuillez réessayer", "échec", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            cn.Close();
        }
        

        private void BTN_RES_Charger_Click(object sender, EventArgs e)
        {
            t.Rows.Clear();
            charger();
        }

        private void BTN_RES_reset_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void BTN_RES_search_Click(object sender, EventArgs e)
        {
            if (TXT_SRSH_ID.Text != string.Empty && TXT_SRCH_NOM.Text == string.Empty)
            {
                chercher(TXT_SRSH_ID.Text);
            }
            else
            {
                ChercherParNom();
            }
        }

        private void BTN_Res_delete_Click(object sender, EventArgs e)
        {
            string querry = string.Format("Delete from Reservation_Table where NReservation = '{0}'", textBox_reserv_Noreservation.Text);
            cn = Methode.ConnectSqlserver();
            SqlCommand cmd = new SqlCommand(querry, cn);
            int k = cmd.ExecuteNonQuery();
            if (k != 0)
            {
                MessageBox.Show("La Réservation a été supprimé avec succès", "réussi", MessageBoxButtons.OK, MessageBoxIcon.Question);
                chercher(textBox_reserv_Noreservation.Text);
            }
        }

      

        private void DGV_Res_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBox_reserv_Noreservation.Text = DGV_Res.CurrentRow.Cells[0].Value.ToString();
            TXT_CLT_ID.Text = DGV_Res.CurrentRow.Cells[1].Value.ToString() +" "+ DGV_Res.CurrentRow.Cells[2].Value.ToString();
            TXT_Type_Logement.Text = DGV_Res.CurrentRow.Cells[4].Value.ToString();
            TXT_N_Logement.Text = DGV_Res.CurrentRow.Cells[5].Value.ToString();
            dateTimePicker_reserv_datein.Value = Convert.ToDateTime(DGV_Res.CurrentRow.Cells[7].Value);
            dateTimePicker_reserv_dateout.Value = Convert.ToDateTime(DGV_Res.CurrentRow.Cells[8].Value);
            numericUpDown_NB_couple.Value = Convert.ToDecimal(DGV_Res.CurrentRow.Cells[9].Value);
            numericUpDown_reserv_ExtratPerson.Value = Convert.ToDecimal(DGV_Res.CurrentRow.Cells[10].Value);
            Prix_Service.Text = DGV_Res.CurrentRow.Cells[11].Value.ToString();
        }

        private void BTN_RES_update_Click(object sender, EventArgs e)
        {
            miseajoure();
        }

        private void cb_typelogement_Enter(object sender, EventArgs e)
        {

        }
    }
   
}
