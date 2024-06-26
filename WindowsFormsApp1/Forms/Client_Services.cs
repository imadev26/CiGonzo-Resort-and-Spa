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
    public partial class Client_Services : Form
    {
        SqlConnection cn;
        DataSet Ds = new DataSet();
        public Client_Services()
        {
            InitializeComponent();
        }
        void clear()
        {
            cb_ClientID.SelectedIndex = -1;
            cb_cat.SelectedIndex = -1;
            cb_service.SelectedIndex = -1;
            cb_produit.SelectedIndex = -1;
            txt_Nbperson.Text = string.Empty;
            txt_PrixService.Text = string.Empty;
            label9.Text = "0";
        }
        void DGV()
        {
            cn = Methode.ConnectSqlserver();
            Ds.Tables.Clear();
            string Main = "select * from reserevation_service order by Date_res";
            SqlDataAdapter dap = new SqlDataAdapter(Main, cn);
            dap.Fill(Ds, "reserevation_service");
            dataGridView1.DataSource = Ds.Tables["reserevation_service"];
            cn.Close();
        }

        
       

        string idClient = "select ID_Client,CONCAT(LName_Client,' ',FName_Client) as 'FNAME' from Client_Table";
        string IdCat = "Select Id_Cat,nom_cat from Categorie ";
        void charger()
        {
            cn = Methode.ConnectSqlserver();
            SqlDataAdapter sda = new SqlDataAdapter(idClient, cn);
            SqlDataAdapter sda1 = new SqlDataAdapter(IdCat, cn);
            sda.Fill(Ds, "Client_Table");
            sda1.Fill(Ds, "Categorie");
            cb_ClientID.DataSource = Ds.Tables["Client_Table"];
            cb_cat.DataSource = Ds.Tables["Categorie"];
            cb_ClientID.DisplayMember = "FNAME";
            cb_ClientID.ValueMember = "ID_Client";
            cb_cat.DisplayMember = "nom_cat";
            cb_cat.ValueMember = "Id_Cat";
            cb_ClientID.SelectedIndex = -1;
            cb_cat.SelectedIndex = -1;
            cn.Close();
            
        }

            

        private void Client_Services_Load(object sender, EventArgs e)
        {
            charger();
            DGV();
            cb_produit_Enter(sender, e);
        }

        private void cb_service_Enter(object sender, EventArgs e)
        {
            if (cb_cat.SelectedIndex == -1)
            {
                return;
            }
            else
            {
                Ds.Tables.Clear();
                string Idservice = string.Format("Select id_service,nom_service from Cl_service where Cl_service.Id_Cat = {0}", cb_cat.SelectedValue);
                cn = Methode.ConnectSqlserver();
                SqlDataAdapter dap = new SqlDataAdapter(Idservice, cn);
                dap.Fill(Ds, "Cl_service");
                cb_service.DataSource = Ds.Tables["Cl_service"];
                cb_service.DisplayMember = "nom_service";
                cb_service.ValueMember = "id_service";
                cn.Close();
            }


        }

        private void cb_produit_Enter(object sender, EventArgs e)
        {
            if (cb_service.SelectedIndex == -1)
            {
                return;
            }
            else
            {
                Ds.Tables.Clear();
                string IdPROD = string.Format("select ID_produit,nom_produit from produit where produit.id_service = {0}", cb_service.SelectedValue);
                cn = Methode.ConnectSqlserver();
                SqlDataAdapter dap = new SqlDataAdapter(IdPROD, cn);
                dap.Fill(Ds, "produit");
                cb_produit.DataSource = Ds.Tables["produit"];
                cb_produit.DisplayMember = "nom_produit";
                cb_produit.ValueMember = "ID_produit";
                cn.Close();
                
            }
        }

        private void txt_PrixService_TextChanged(object sender, EventArgs e)
        {
            label9.Text = txt_PrixService.Text;
            txt_Nbperson.Text = string.Empty;
        }

        private void txt_Nbperson_TextChanged(object sender, EventArgs e)
        {
            if (txt_Nbperson.Text == string.Empty)
            {
                label9.Text = txt_PrixService.Text;
                return;
            }
            else
            {
                label9.Text = (float.Parse(txt_PrixService.Text) * int.Parse(txt_Nbperson.Text)).ToString();
            }
        }

        private void button_ADD_Reservation_Click(object sender, EventArgs e)
        {
            cn = Methode.ConnectSqlserver();
            if (cb_ClientID.SelectedIndex == -1 || cb_cat.SelectedIndex == -1 || cb_produit.SelectedIndex == -1 || cb_service.SelectedIndex == -1 || txt_PrixService.Text == string.Empty || txt_Nbperson.Text == string.Empty)
            {
                MessageBox.Show("vous devez remplir tous les champs");
            }
            else
            {
                string S = string.Format("insert into reserevation_service values('{0}','{1}','{2}','{3}','{4}','{5}')", cb_cat.SelectedValue, cb_service.SelectedValue, cb_produit.SelectedValue, cb_ClientID.SelectedValue, int.Parse(txt_PrixService.Text), int.Parse(txt_Nbperson.Text));
                SqlCommand cmd = new SqlCommand(S, cn);
                int k = cmd.ExecuteNonQuery();
                if (k != 0)
                {

                    MessageBox.Show("ajouté");
                    DGV();
                }
            }
            cn.Close();
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            clear();
            cb_ClientID.SelectedValue = dataGridView1.CurrentRow.Cells[4].Value;
            cb_cat.SelectedValue = dataGridView1.CurrentRow.Cells[1].Value;
            cb_service_Enter(sender, e);
            cb_service.SelectedValue = dataGridView1.CurrentRow.Cells[2].Value;
            cb_produit_Enter(sender, e);
            cb_produit.SelectedValue = dataGridView1.CurrentRow.Cells[3].Value;
            txt_PrixService.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txt_Nbperson.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txt_ID_RESER.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void BTN_Delete_Reservation_Click(object sender, EventArgs e)
        {
            cn = Methode.ConnectSqlserver();
            if (cb_ClientID.SelectedIndex == -1 || cb_cat.SelectedIndex == -1 || cb_produit.SelectedIndex == -1 || cb_service.SelectedIndex == -1 )
            {
                MessageBox.Show("vous devez remplir tous les champs");
            }
            else
            {
                string S = string.Format("Delete from reserevation_service where ID_Reservation = '{0}'", txt_ID_RESER.Text);
                SqlCommand cmd = new SqlCommand(S, cn);
                int k = cmd.ExecuteNonQuery();
                if (k != 0)
                {
                    MessageBox.Show("Supprimé");
                    btn_chercher_Click(sender, e);
                }
            }
            cn.Close();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            cn = Methode.ConnectSqlserver();
            if (cb_ClientID.SelectedIndex == -1 || cb_cat.SelectedIndex == -1 || cb_produit.SelectedIndex == -1 || cb_service.SelectedIndex == -1)
            {
                MessageBox.Show("vous devez remplir tous les champs");
            }
            else
            {
                string S = string.Format("update reserevation_service set ID_Client = '{0}' , ID_Cat = '{1}' , id_service = '{2}' , id_produit = '{3}' , price_service = '{4}',qte = '{5}' where ID_Reservation = '{6}'", cb_ClientID.SelectedValue, cb_cat.SelectedValue, cb_service.SelectedValue, cb_produit.SelectedValue, float.Parse(txt_PrixService.Text),int.Parse(txt_Nbperson.Text),txt_ID_RESER.Text);
                SqlCommand cmd = new SqlCommand(S, cn);
                int k = cmd.ExecuteNonQuery();
                if (k != 0)
                {
                    MessageBox.Show("Updated");
                    clear();
                    DGV();
                }
            }
            cn.Close();
        }

        private void btn_chercher_Click(object sender, EventArgs e)
        {
            cn = Methode.ConnectSqlserver();
            Ds.Tables.Clear();
            string Main = string.Format("select * from reserevation_service where ID_Client = '{0}'",cb_ClientID.SelectedValue);
            SqlDataAdapter dap = new SqlDataAdapter(Main, cn);
            dap.Fill(Ds, "cherche_resClient");
            dataGridView1.DataSource = Ds.Tables["cherche_resClient"];
            cn.Close();
        }

        private void txt_Nbperson_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btn_changer_Click(object sender, EventArgs e)
        {
            Client_Services_Load(sender, e);
            clear();
        }
    }
}
