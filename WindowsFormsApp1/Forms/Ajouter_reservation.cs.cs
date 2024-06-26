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
    public partial class Ajouter_reservation : Form
    {
        public Ajouter_reservation()
        {
            InitializeComponent();
        }
        SqlConnection cn;
        DataSet Ds = new DataSet();

        void DGV()
        {
            cn = Methode.ConnectSqlserver();
            string Q = string.Format("select CONCAT(LName_Client,' ',FName_Client) as 'Nom de Client',DateIn_Reservation as 'Arrivée',DateOut_Reservation as 'Départ', N_couple_Reservation as 'Nombre de couple(s)', N_Extra_Person_Reservation as 'nombre de personne(s) supplémentaire(s)', type_logement as 'Logement type', N_logement as 'Numero Logement' from Client_Table join Reservation_Table on Client_Table.ID_Client = Reservation_Table.ID_Client inner join logement_Table on Reservation_Table.ID_logement = logement_Table.ID_logement");
            SqlDataAdapter dap = new SqlDataAdapter(Q, cn);
            dap.Fill(Ds, "Reservation_table");
            dataGridView_main_reservation.DataSource = Ds.Tables["Reservation_table"];
            cn.Close();
        }
        void DGV1()
        {
            cn = Methode.ConnectSqlserver();
            int a, b, c;
            a = int.Parse(numericUpDown_NB_couple.Value.ToString());
            b = int.Parse(numericUpDown_reserv_ExtratPerson.Value.ToString());
            c = a + b;
            string Q = string.Format("select * from logement_Table where N_beds >= {0} and Status_logement = 'Disponible'", c);
            SqlDataAdapter dap = new SqlDataAdapter(Q, cn);
            dap.Fill(Ds,"Logement_Control");
            DGV_Adapté.DataSource = Ds.Tables["Logement_Control"];
            cn.Close();
        }
        void LogementCH()
        {
            Ds.Tables.Clear();
            cn = Methode.ConnectSqlserver();
            SqlDataAdapter dap = new SqlDataAdapter("select distinct room_type from room_type", cn);
            dap.Fill(Ds, "Type_Logement");
            cb_typelogement.DataSource = Ds.Tables["Type_Logement"];
            cb_typelogement.DisplayMember = "room_type";
            cb_typelogement.ValueMember = "room_type";
            cn.Close();
            cb_typelogement.SelectedIndex = -1;
        }
        private int autoSETID(int i)
        {
            int x = 0;
            cn = Methode.ConnectSqlserver();
            SqlCommand cmd = new SqlCommand("select top 1 NReservation from Reservation_Table order by NReservation DESC", cn);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                x = int.Parse(dr[0].ToString());
            }
            cn.Close();
            return x + i;
        }
        void ChargerNlog()
        {
            Ds.Tables.Clear();
            string h = string.Format("select distinct ID_logement, N_logement from logement_Table where Status_logement = 'Disponible' and type_logement ='{0}'", cb_typelogement.SelectedValue);
            cn = Methode.ConnectSqlserver();
            SqlDataAdapter dap = new SqlDataAdapter(h, cn);
            dap.Fill(Ds, "logement_T");
            cb_N_logement.DataSource = Ds.Tables["logement_T"];
            cb_N_logement.DisplayMember = "N_logement";
            cb_N_logement.ValueMember = "ID_logement";
            cb_N_logement.SelectedIndex = -1;
        }
        void chargerCLT()
        {
            Ds.Tables.Clear();
            cn = Methode.ConnectSqlserver();
            SqlDataAdapter dap = new SqlDataAdapter("select ID_Client,CONCAT(LName_Client,' ',FName_Client) as Fname from PreServeur", cn);
            dap.Fill(Ds, "Type_Logement");
            cb_ID_CLT.DataSource = Ds.Tables["Type_Logement"];
            cb_ID_CLT.DisplayMember = "Fname";
            cb_ID_CLT.ValueMember = "ID_Client";
            cn.Close();
            cb_ID_CLT.SelectedIndex = -1;
        }

        void clear()
        {
            cb_typelogement.SelectedIndex = -1;
            cb_N_logement.SelectedIndex = -1;
            cb_ID_CLT.SelectedIndex = -1;
            dateTimePicker_reserv_datein.ResetText();
            dateTimePicker_reserv_dateout.ResetText();
            numericUpDown_NB_couple.Value = 0;
            numericUpDown_reserv_ExtratPerson.Value = 0;
            Prix_Service.Text.Equals(string.Empty);
        }
        void ChargeReservation()
        {
            //Program.cn.Open();
            //SqlCommand cmd = new SqlCommand("SELECT No_Reservation AS 'No. Reservation', No_Room_Reservation AS 'No. Room', ID_Guest_Reservation AS 'ID. Guest', DateIn_Reservation AS 'Date In                        ', DateOut_Reservation AS 'Date Out                      ', No_Of_Males_Reservation AS 'No. Of Males', No_Of_Females_Reservation AS 'No. Of Females', No_Of_Kids_Reservation AS 'No. Of Kids', No_Of_Extra_Person_Reservation AS 'No. Extra Person', No_Of_Extra_Bed_Reservation AS 'No. Extra Bed', No_Of_Days_Reservation AS 'No. Of Days', Room_Service_Charges_Reservation AS 'Room Service Charges', Extra_Bed_Charges_Reservation AS 'Extra Bed Charges', Extra_Person_Charges_Reservation AS 'Extra Person Charges', Total_Room_Charges_Reservation AS 'Total Room Charges' FROM Reservation_Table", Program.cn);
            //SqlDataReader dr = cmd.ExecuteReader();
            //DataTable t = new DataTable();
            //t.Load(dr);
            //dataGridView_main_reservation.DataSource = null;
            //dataGridView_main_reservation.DataSource = t;
            //dataGridView_main_reservation.ClearSelection();
            //dr.Close();
            //Program.cn.Close();
        }
        void ChargeRoom()
        {
            //Program.cn.Open();
            //SqlCommand cmd = new SqlCommand("SELECT No_Room AS 'Number', Type_Room AS 'Type', Charges_Room AS 'Charges', Status_Room AS 'Status' FROM Room_Table WHERE Status_Room = 'Available'", Program.cn);
            //SqlDataReader dr = cmd.ExecuteReader();
            //DataTable t = new DataTable();
            //t.Load(dr);
            //dataGridView_main_reservation.DataSource = null;
            //dataGridView_main_reservation.DataSource = t;
            //dataGridView_main_reservation.ClearSelection();
            //dr.Close();
            //Program.cn.Close();
        }

        private void button_reserv_ckeckout_Click(object sender, EventArgs e)
        {
            // ID GUEST = ID RESERVATION
            //if (textBox_mian_guest_id.Text == string.Empty)
            //{
            //    MessageBox.Show("Guest Information must be field", "Guest Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //if (textBox_reserv_Noreservation.Text == string.Empty)
            //{
            //    MessageBox.Show("Room Information must be field", "Room Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //else if (numericUpDown_reserv_males.Value == 0 && numericUpDown_reserv_females.Value == 0)
            //{
            //    MessageBox.Show("Number of (Males or females) must be greater than 0", "Reservation Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //else
            //{
            //    try
            //    {
            //        Program.cn.Open();
            //        //Reservation_______________________________________________________________
            //        string h1 = string.Format("INSERT INTO Reservation_Table VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}')", textBox_room_number.Text, textBox_mian_guest_id.Text, dateTimePicker_reserv_datein.Value.ToShortDateString(), dateTimePicker_reserv_dateout.Value.ToShortDateString(), numericUpDown_reserv_males.Value, numericUpDown_reserv_females.Value, numericUpDown_reserv_kids.Value, numericUpDown_reserv_extra_person.Value, numericUpDown_reserv_extra_bed.Value, numericUpDown_reserv_days.Value, textBox_room_charges.Text, numericUpDown_reserv_extra_bed_charges.Value, numericUpDown_reserv_extra_person_charges.Value, textBox_reserv_totalroom_charges.Text);
            //        SqlCommand cmd1 = new SqlCommand(h1, Program.cn);
            //        int k1 = cmd1.ExecuteNonQuery();

            //        //Room______________________________________________________________________
            //        string h2 = string.Format("UPDATE Room_Table SET Status_Room = 'Unavailable' WHERE No_Room = '{0}'", textBox_room_number.Text);
            //        SqlCommand cmd2 = new SqlCommand(h2, Program.cn);
            //        int k2 = cmd2.ExecuteNonQuery();

            //        if (k1 == 0 && k2 == 0)
            //        {
            //            MessageBox.Show("please try again", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        }
            //        else
            //        {
            //            MessageBox.Show("Reservation done successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Question);
            //        }
            //    }
            //    catch (SqlException s)
            //    {
            //        MessageBox.Show(s.Message);
            //    }
            //}
            //Program.cn.Close();
            //ChargeReservation();
            //ChargeRoom();

            DateTime FROM = Convert.ToDateTime(dateTimePicker_reserv_datein.Text);
            DateTime TODAY = Convert.ToDateTime(dateTimePicker_reserv_dateout.Text);
            if (numericUpDown_NB_couple.Value == 0 && numericUpDown_reserv_ExtratPerson.Value == 0)
            {
                MessageBox.Show("L'utilisateur doit renseigner le champ nombre de personnes");
                return;
            }
            if (FROM > TODAY)
            {
                MessageBox.Show("La date d'arrivée doit être inférieure à la date de départ");
                return;
            }
            if (cb_ID_CLT.SelectedIndex == -1 || cb_N_logement.SelectedIndex == -1 || cb_typelogement.SelectedIndex == -1 || FROM == TODAY)
            {
                MessageBox.Show("vous devez ajouter toutes les informations", "nécessité", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    
                    if (numericUpDown_NB_couple.Value != 0 && numericUpDown_reserv_ExtratPerson.Value == 0)
                    {
                        string H1 = string.Format("Insert into Reservation_Table values ('{0}','{1}','{2}','{3}','{4}',0,'{5}')", cb_N_logement.SelectedValue,cb_ID_CLT.SelectedValue,dateTimePicker_reserv_datein.Value,dateTimePicker_reserv_dateout.Value,numericUpDown_NB_couple.Value,Prix_Service.Text);
                        string H2 = string.Format("UPDATE logement_Table SET Status_logement = 'Indisponible' WHERE ID_logement = '{0}' and type_logement = '{1}'", cb_N_logement.SelectedValue, cb_typelogement.SelectedValue);
                        cn = Methode.ConnectSqlserver();
                        SqlCommand cmd = new SqlCommand(H1,cn);
                        SqlCommand cmd1 = new SqlCommand(H2, cn);
                        int k1 = cmd.ExecuteNonQuery();
                        int k2 = cmd1.ExecuteNonQuery();
                        if (k1 != 0 && k2 != 0)
                        {
                            MessageBox.Show("la réservation a été ajoutée avec succès");
                            clear();
                            DGV();
                            cn.Close();

                        }
                        else
                        {
                            MessageBox.Show("vous devez ajouter toutes les informations", "nécessité", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else if (numericUpDown_NB_couple.Value == 0 && numericUpDown_reserv_ExtratPerson.Value != 0)
                    {
                        string H1 = string.Format("Insert into Reservation_Table values ('{0}','{1}','{2}','{3}',0,'{4}','{5}')", cb_N_logement.SelectedValue, cb_ID_CLT.SelectedValue, dateTimePicker_reserv_datein.Value, dateTimePicker_reserv_dateout.Value, numericUpDown_reserv_ExtratPerson.Value, Prix_Service.Text);
                        string H2 = string.Format("UPDATE logement_Table SET Status_logement = 'Indisponible' WHERE ID_logement = '{0}' and type_logement = '{1}'", cb_N_logement.SelectedValue,cb_typelogement.SelectedValue);
                        cn = Methode.ConnectSqlserver();
                        SqlCommand cmd = new SqlCommand(H1, cn);
                        SqlCommand cmd1 = new SqlCommand(H2, cn);
                        int k1 = cmd.ExecuteNonQuery();
                        int k2 = cmd1.ExecuteNonQuery();
                        if (k1 != 0 && k2 != 0)
                        {
                            MessageBox.Show("la réservation a été ajoutée avec succès");
                            clear();
                            DGV();
                            cn.Close();
                        }
                        else
                        {
                            MessageBox.Show("vous devez ajouter toutes les informations", "nécessité", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else if (numericUpDown_NB_couple.Value != 0 && numericUpDown_reserv_ExtratPerson.Value != 0)
                    {
                        string H1 = string.Format("Insert into Reservation_Table values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", cb_N_logement.SelectedValue, cb_ID_CLT.SelectedValue, dateTimePicker_reserv_datein.Value, dateTimePicker_reserv_dateout.Value, numericUpDown_NB_couple.Value,numericUpDown_reserv_ExtratPerson.Value, Prix_Service.Text);
                        string H2 = string.Format("UPDATE logement_Table SET Status_logement = 'Indisponible' WHERE ID_logement = '{0}' and type_logement = '{1}'", cb_N_logement.SelectedValue, cb_typelogement.SelectedValue);
                        cn = Methode.ConnectSqlserver();
                        SqlCommand cmd = new SqlCommand(H1, cn);
                        SqlCommand cmd1 = new SqlCommand(H2, cn);
                        int k1 = cmd.ExecuteNonQuery();
                        int k2 = cmd1.ExecuteNonQuery();
                        if (k1 != 0 && k2 != 0)
                        {
                            MessageBox.Show("la réservation a été ajoutée avec succès");
                            clear();
                            DGV();
                            cn.Close();

                        }
                        else
                        {
                            MessageBox.Show("vous devez ajouter toutes les informations", "nécessité", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception EX)
                {

                    MessageBox.Show(EX.Message);
                }
            }
        }

        private void Ajouter_reservation_Load(object sender, EventArgs e)
        {
            LogementCH();
            DGV();
            textBox_reserv_Noreservation.Text = autoSETID(1).ToString();
            LogementCH();
        }

        private void comboBox2_Enter(object sender, EventArgs e)
        {
            ChargerNlog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_N_logement.ResetText();
        }

        private void cb_typelogement_Enter(object sender, EventArgs e)
        {

        }

        private void cb_ID_CLT_Enter(object sender, EventArgs e)
        {
            chargerCLT();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (numericUpDown_NB_couple.Value == 0 && numericUpDown_reserv_ExtratPerson.Value == 0)
            {
                MessageBox.Show("Les cases spéciales doivent être remplies dans le nombre d'invités de réservation");
            }
            else
            {
                DGV1();
            }
        }

        private void btn_ChargeDGV_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void DGV_Adapté_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            cb_typelogement.SelectedValue = DGV_Adapté.CurrentRow.Cells[1].Value;
            comboBox2_Enter( sender, e);
            cb_N_logement.SelectedValue = DGV_Adapté.CurrentRow.Cells[0].Value;
        }

        private void Prix_Service_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }
    }
}
