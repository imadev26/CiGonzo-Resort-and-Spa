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
    public partial class Gestion_Des_Chambres : Form
    {
        SqlConnection cn;
        public Gestion_Des_Chambres()
        {
            InitializeComponent();
        }
        
        void ClearRoom()
        {
            textBox_room_number.Clear();
            textBox_room_charges.Clear();
            textBox_RM_type.Clear();
            radioButton_room_reserved.Checked = false;
            radioButton_room_ready.Checked = false;
            radioButton_room_notready.Checked = false;
            txt_ESpaceLOG.Clear();
            txt_DescLOG.Clear();
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
            SqlCommand cmd = new SqlCommand("SELECT ID_logement AS 'ID Logement', type_logement AS 'Type Logement', Price_night AS 'Prix / Nuit', Status_logement AS 'État',Des_Logement as 'Description',space_m2 as 'Espace / m²' FROM logement_Table", cn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable t = new DataTable();
            t.Load(dr);
            dataGridView_main_room.DataSource = null;
            dataGridView_main_room.DataSource = t;
            dataGridView_main_room.ClearSelection();
            dr.Close();
            cn.Close();
        }

        private void button_RM_delete_Click(object sender, EventArgs e)
        {
            if (textBox_room_number.Text == string.Empty)
            {
                MessageBox.Show("veuillez saisir Numéro de Logement", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (ExistRoom(textBox_room_number.Text) == false)
            {
                MessageBox.Show("Numéro de Logement n'existe pas", "", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else
            {
                try
                {
                    cn = Methode.ConnectSqlserver();
                    string h = string.Format("DELETE logement_Table WHERE ID_logement = '{0}'", textBox_room_number.Text);
                    SqlCommand cmd = new SqlCommand(h,cn);
                    if (MessageBox.Show("Vous devez vraiment supprimer ce logement ??","",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        int k = cmd.ExecuteNonQuery();
                        if (k != 0)
                        {
                            MessageBox.Show("Logement Supprimé");
                        }
                        else
                        {
                            MessageBox.Show("Logement n'a pas été supprimé, veuillez vérifier", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (SqlException s)
                {
                    MessageBox.Show(s.Message);
                }
            }
            cn.Close();
            ChargeRoom();
        }

        

        private void button_RM_update_Click(object sender, EventArgs e)
        {
            if (textBox_room_number.Text.Equals(string.Empty))
            {
                MessageBox.Show("Les champs doivent être remplis en premier", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (ExistRoom(textBox_room_number.Text) == false)
            {
                MessageBox.Show("Le numéro de chambre n'existe pas", "", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else
            {
                try
                {
                    string check;
                    if (radioButton_room_reserved.Checked)
                    {
                        check = radioButton_room_reserved.Text;
                    }
                    else if (radioButton_room_ready.Checked)
                    {
                        check = radioButton_room_ready.Text;
                    }
                    else
                    {
                        check = radioButton_room_notready.Text;
                    }
                    cn = Methode.ConnectSqlserver();
                    string h = string.Format("UPDATE logement_Table SET type_logement = '{0}', Price_night = '{1}', Status_logement = '{2}',Des_Logement = '{4}',space_m2 = '{5}' WHERE ID_logement = '{3}'", textBox_RM_type.Text, textBox_room_charges.Text, check, textBox_room_number.Text,txt_DescLOG.Text,txt_ESpaceLOG.Text);
                    SqlCommand cmd = new SqlCommand(h,cn);
                    if (MessageBox.Show("vous devez vraiment mettre a joure ce logement", "",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        int k = cmd.ExecuteNonQuery();
                        if (k != 0)
                        {
                            MessageBox.Show("Mise à jour de Logement effectuée avec succès", "", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        }
                        else
                        {
                            MessageBox.Show("Veuillez réessayer", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (SqlException s)
                {
                    MessageBox.Show(s.Message);
                }
            }
            cn.Close();
            ClearRoom();
            //ChargeRoom();
        }

        private void dataGridView_main_room_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dataGridView_main_room.SelectedRows.Count > 0)
            {
                textBox_room_number.Text = dataGridView_main_room.CurrentRow.Cells[0].Value.ToString();
                textBox_RM_type.Text = dataGridView_main_room.CurrentRow.Cells[1].Value.ToString();
                textBox_room_charges.Text = dataGridView_main_room.CurrentRow.Cells[2].Value.ToString();
                txt_DescLOG.Text = dataGridView_main_room.CurrentRow.Cells[4].Value.ToString();
                txt_ESpaceLOG.Text = dataGridView_main_room.CurrentRow.Cells[5].Value.ToString();
                if (radioButton_room_reserved.Text == dataGridView_main_room.CurrentRow.Cells[3].Value.ToString())
                {
                    radioButton_room_reserved.Checked = true;
                }
                else if (radioButton_room_ready.Text == dataGridView_main_room.CurrentRow.Cells[3].Value.ToString())
                {
                    radioButton_room_ready.Checked = true;
                }
                else
                {
                    radioButton_room_notready.Checked = true;
                }
                dataGridView_main_room.ClearSelection();
            }
        }

        private void button_room_clear_Click(object sender, EventArgs e)
        {
            ClearRoom();
        }
        

        private void Gestion_Des_Chambres_Load(object sender, EventArgs e)
        {
            
        }

        private void radioButton_room_ready_CheckedChanged_1(object sender, EventArgs e)
        {
            try
            {
                cn = Methode.ConnectSqlserver();
                string h = string.Format("SELECT ID_logement AS 'ID Logement', type_logement AS 'Type Logement', Price_night AS 'Prix / Nuit', Status_logement AS 'État',Des_Logement as 'Description',space_m2 as 'Espace / m²' FROM logement_Table WHERE Status_logement = 'Disponible'");
                SqlCommand cmd = new SqlCommand(h, cn);
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable t = new DataTable();
                t.Load(dr);
                dataGridView_main_room.DataSource = null;
                dataGridView_main_room.DataSource = t;
                dataGridView_main_room.ClearSelection();
                dr.Close();
                cn.Close();
            }
            catch (SqlException s)
            {
                MessageBox.Show(s.Message);
            }
        }

        private void radioButton_room_reserved_CheckedChanged_1(object sender, EventArgs e)
        {
            try
            {
                cn = Methode.ConnectSqlserver();
                string h = string.Format("SELECT ID_logement AS 'ID Logement', type_logement AS 'Type Logement', Price_night AS 'Prix / Nuit', Status_logement AS 'État',Des_Logement as 'Description',space_m2 as 'Espace / m²' FROM logement_Table WHERE Status_logement = 'Préparation'");
                SqlCommand cmd = new SqlCommand(h, cn);
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable t = new DataTable();
                t.Load(dr);
                dataGridView_main_room.DataSource = null;
                dataGridView_main_room.DataSource = t;
                dataGridView_main_room.ClearSelection();
                dr.Close();
                cn.Close();
            }
            catch (SqlException s)
            {
                MessageBox.Show(s.Message);
            }
        }

        private void radioButton_room_notready_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                cn = Methode.ConnectSqlserver();
                string h = string.Format("SELECT ID_logement AS 'ID Logement', type_logement AS 'Type Logement', Price_night AS 'Prix / Nuit', Status_logement AS 'État',Des_Logement as 'Description',space_m2 as 'Espace / m²' FROM logement_Table WHERE Status_logement = 'Indisponible'");
                SqlCommand cmd = new SqlCommand(h, cn);
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable t = new DataTable();
                t.Load(dr);
                dataGridView_main_room.DataSource = null;
                dataGridView_main_room.DataSource = t;
                dataGridView_main_room.ClearSelection();
                dr.Close();
                cn.Close();
            }
            catch (SqlException s)
            {
                MessageBox.Show(s.Message);
            }
        }

        private void textBox_room_charges_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void btn_ChargerROOMS_Click(object sender, EventArgs e)
        {
            ChargeRoom();
        }

        private void txt_ESpaceLOG_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void textBox_room_number_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }
    }
}
