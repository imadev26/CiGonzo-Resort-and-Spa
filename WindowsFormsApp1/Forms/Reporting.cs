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
    public partial class Reporting : Form
    {
        SqlConnection cn;
        DataSet Ds1 = new DataSet();
        
        public Reporting()
        {
            InitializeComponent();
        }

        void cbcharger()
        {
            string s = "Select ID_Client,CONCAT(LName_Client,' ',FName_Client) as 'FNAME' from Client_Table";
            cn = Methode.ConnectSqlserver();
            SqlDataAdapter sda = new SqlDataAdapter(s, cn);
            sda.Fill(Ds1, "Client_Table");
            cb_IDCLT_FAC.DisplayMember = "FNAME";
            cb_IDCLT_FAC.ValueMember = "ID_Client";
            cb_IDCLT_FAC.DataSource = Ds1.Tables["Client_Table"];
            cb_IDCLT_FAC.SelectedIndex = -1;
        }
        DataSet1 ds = new DataSet1();
        private void Reporting_Load(object sender, EventArgs e)
        {
            cbcharger();
            crystalReportViewer1.Visible = false;
            //DataSet1TableAdapters.Client_TableTableAdapter daclient = new DataSet1TableAdapters.Client_TableTableAdapter();
            //daclient.Fill(ds.Client_Table);
            //cb_IDCLT_FAC.DataSource = ds.Client_Table;
            //cb_IDCLT_FAC.DisplayMember = ds.Client_Table.Columns[1].Caption;
            //cb_IDCLT_FAC.ValueMember = ds.Client_Table.Columns[0].Caption;


            //cn = Methode.ConnectSqlserver();
            //SqlDataAdapter sda = new SqlDataAdapter(Querry,cn);
            //DataSet1 d1 = new DataSet1();
            //sda.Fill(d1.DataTable2);
            //CrystalReport cr1 = new CrystalReport();
            //cr1.SetDataSource(d1.Tables["DataTable2"]);
            //crystalReportViewer1.ReportSource = cr1;
            //crystalReportViewer1.Refresh();
        }

        private void cb_IDCLT_FAC_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_IDCLT_FAC.SelectedIndex.Equals(-1))
            {
                return;
            }
            else
            {
                ds.Clear();
                int x = int.Parse(cb_IDCLT_FAC.SelectedValue.ToString());
                crystalReportViewer1.Visible = true;
                DataSet1TableAdapters.Client_Table1TableAdapter daclient1 = new DataSet1TableAdapters.Client_Table1TableAdapter();
                daclient1.FillbyID(ds.Client_Table1, x);
                DataSet1TableAdapters.DT_GonzFoodTableAdapter gonzDT = new DataSet1TableAdapters.DT_GonzFoodTableAdapter();
                gonzDT.FillbyID(ds.DT_GonzFood, x);
                DataSet1TableAdapters.DT_LogementTableAdapter gonzLA = new DataSet1TableAdapters.DT_LogementTableAdapter();
                gonzLA.FillbyID(ds.DT_Logement, x);
                CrystalReport1 rapport = new CrystalReport1();
                rapport.SetDataSource(ds);
                crystalReportViewer1.ReportSource = rapport;
            }

        }

        private void cb_IDCLT_FAC_SelectedValueChanged(object sender, EventArgs e)
        {
            string querry = string.Format("select * from reserevation_service,Reservation_Table where reserevation_service.ID_Client = Reservation_Table.ID_Client and reserevation_service.ID_Client = '{0}'", cb_IDCLT_FAC.SelectedValue);
            cn = Methode.ConnectSqlserver();
            SqlCommand cmd = new SqlCommand(querry, cn);
            SqlDataReader Sdr = cmd.ExecuteReader();
            if (Sdr.HasRows)
            {
                crystalReportViewer1.DisplayToolbar = Enabled;
            }
            else
            {
                crystalReportViewer1.DisplayToolbar = false;
            }
        }
    }
}
