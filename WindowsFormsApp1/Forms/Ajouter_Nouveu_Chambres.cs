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
    public partial class Ajouter_Nouveu_Chambres : Form
    {
        public Ajouter_Nouveu_Chambres()
        {
            InitializeComponent();
        }
        SqlConnection cn;


        void chargeCB()
        {
            cb_type_maison.Items.Clear();
            cn = Methode.ConnectSqlserver();
            SqlCommand cmd = new SqlCommand("select room_Type from room_Type", cn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read() == true)
            {
                cb_type_maison.Items.Add(dr[0]);
            }
            dr.Close();
            cn.Close();
        }
        void chargerCB1()
        {
            cb_etat_chambre.Items.Clear();
            cn = Methode.ConnectSqlserver();
            SqlCommand cmd = new SqlCommand("SELECT Status_Room FROM Room_Status_Table", cn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read() == true)
            {
                cb_etat_chambre.Items.Add(dr[0]);
            }
            dr.Close();
            cn.Close();
        }
        private int autoSETID(int i)
        {
            int x = 0;
            cn = Methode.ConnectSqlserver();
            SqlCommand cmd = new SqlCommand("select Top 1 ID_logement from logement_Table order by ID_logement DESC", cn);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                x = int.Parse(dr[0].ToString());
            }
            cn.Close();
            return x + i;
        }
        
        void ClearRoom()
        {
            txt_nb_chambre.Value = 0;
            txt_nb_lits.Value = 0;
            txt_N_maison.Clear();
            txt_price_night.Clear();
            cb_etat_chambre.SelectedIndex = -1;
            cb_type_maison.SelectedIndex = -1;
            txt_DescLOG.Clear();
            txt_EspaceLOG.Clear();
        }
        bool ExistRoom(string x)
        {
            bool a = false;
            try
            {
                cn = Methode.ConnectSqlserver();
                SqlCommand cmd = new SqlCommand("SELECT * FROM logement_Table WHERE ID_logement ='" + x + "'",cn);
                SqlDataReader dr = cmd.ExecuteReader();
                a = dr.HasRows;
                dr.Close();
                cn.Close();
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
            }
            return a;
        }
        void ChargeRoom()
        {
            cn = Methode.ConnectSqlserver();
            SqlCommand cmd = new SqlCommand("Select ID_logement as 'ID Logement', type_logement as 'Type Logement',N_logement as 'N° Logement',N_chambre as 'Nombre de chambres',N_beds as 'Nombre de lits',Status_logement as 'État',Des_Logement as 'Description',space_m2 as 'Espace / m²' from logement_Table", cn);  
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable t = new DataTable();
            t.Load(dr);
            dataGridView_room.DataSource = null;
            dataGridView_room.DataSource = t;
            dataGridView_room.ClearSelection();
            dr.Close();
            cn.Close();
        }

        private void button_RM_add_Click(object sender, EventArgs e)
        {
            //if (textBox_RM_number.Text == string.Empty || textBox_RM_type.Text == string.Empty || numericUpDown_RM_charges.Text == string.Empty || comboBox_RM_status.Text == string.Empty)
            //{
            //    MessageBox.Show("The fields must be filled out first", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //else if (ExistRoom(textBox_RM_number.Text) == true)
            //{
            //    MessageBox.Show("Room Number already exists", "", MessageBoxButtons.OK, MessageBoxIcon.Question);
            //}
            //else
            //{
            //    try
            //    {
            //        Program.cn.Open();
            //        string h = string.Format("INSERT INTO Room_Table VALUES ('{0}','{1}','{2}','{3}')", textBox_RM_number.Text, textBox_RM_type.Text, numericUpDown_RM_charges.Text, comboBox_RM_status.Text);
            //        SqlCommand cmd = new SqlCommand(h, Program.cn);
            //        int k = cmd.ExecuteNonQuery();
            //        if (k == 0)
            //        {
            //            MessageBox.Show("please try again", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        }
            //        else
            //        {
            //            MessageBox.Show("Add room done successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Question);
            //        }
            //    }
            //    catch (SqlException s)
            //    {
            //        MessageBox.Show(s.Message);
            //    }
            //}
            //Program.cn.Close();
            //ChargeRoom();
        }

        private void button_RM_reset_Click(object sender, EventArgs e)
        {
            ClearRoom();
        }

        private void dataGridView_room_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //if (dataGridView_room.SelectedRows.Count > 0)
            //{
            //    textBox_RM_number.Text = dataGridView_room.CurrentRow.Cells[0].Value.ToString();
            //    textBox_RM_type.Text = dataGridView_room.CurrentRow.Cells[1].Value.ToString();
            //    numericUpDown_RM_charges.Text = dataGridView_room.CurrentRow.Cells[2].Value.ToString();
            //    comboBox_RM_status.Items.Add(dataGridView_room.CurrentRow.Cells[3].Value.ToString());
            //    comboBox_RM_status.Text = dataGridView_room.CurrentRow.Cells[3].Value.ToString();
            //    dataGridView_room.ClearSelection();
            //}
            if (dataGridView_room.Rows.Count-1 > 0)
            {
                txt_ID_room.Text = dataGridView_room.CurrentRow.Cells[0].Value.ToString();
                cb_type_maison.SelectedItem = dataGridView_room.CurrentRow.Cells[1].Value.ToString();
                txt_N_maison.Text = dataGridView_room.CurrentRow.Cells[2].Value.ToString();
                txt_nb_chambre.Text = dataGridView_room.CurrentRow.Cells[3].Value.ToString();
                txt_nb_lits.Text = dataGridView_room.CurrentRow.Cells[4].Value.ToString();
                cb_etat_chambre.SelectedItem = dataGridView_room.CurrentRow.Cells[5].Value.ToString();
                txt_price_night.Enabled = false;
                txt_DescLOG.Text = dataGridView_room.CurrentRow.Cells[6].Value.ToString();
                txt_EspaceLOG.Text = dataGridView_room.CurrentRow.Cells[7].Value.ToString();

            }
        }

        

        private void button_RM_add_Click_1(object sender, EventArgs e)
        {
            if (txt_ID_room.Text.Equals(string.Empty) || txt_nb_chambre.Value.Equals(0) || txt_nb_lits.Value.Equals(0) || txt_N_maison.Text.Equals(string.Empty) || txt_EspaceLOG.Text.Equals(string.Empty))
            {
                MessageBox.Show("vous devez ajouter toutes les informations", "nécessité", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (ExistRoom(txt_ID_room.Text) == true)
            {
                MessageBox.Show("veuillez actualiser car l'identité de maison existe déjà"," ", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else
            {
                try
                {
                    cn = Methode.ConnectSqlserver();
                    string Q = string.Format("INSERT INTO logement_Table VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}')", cb_type_maison.SelectedItem.ToString(), txt_N_maison.Text, txt_nb_chambre.Value, txt_nb_lits.Value, txt_price_night.Text, cb_etat_chambre.SelectedItem.ToString(),txt_DescLOG.Text,txt_EspaceLOG.Text);
                    SqlCommand cmd = new SqlCommand(Q, cn);
                    int K = cmd.ExecuteNonQuery();
                    if (K == 0)
                    {
                        MessageBox.Show("veuillez vérifier les informations car l'événement n'a pas été affecté", "èchec", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("le logement a été ajouté avec succès", "succès", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        ChargeRoom();
                    }
                }
                catch (Exception EX)
                {

                    MessageBox.Show(EX.Message);
                }
            }
        }

        private void Ajouter_Nouveu_Chambres_Load(object sender, EventArgs e)
        {
            txt_ID_room.Text = autoSETID(1).ToString();
            chargeCB();
            chargerCB1();
        }

        private void button_RM_reset_Click_1(object sender, EventArgs e)
        {
            txt_ID_room.Text = autoSETID(1).ToString();
            ChargeRoom();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt_ID_room.Text = autoSETID(1).ToString();
            txt_price_night.Enabled = true;
            ClearRoom();
        }

        private void txt_EspaceLOG_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txt_price_night_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txt_N_maison_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txt_price_night_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
