using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        //DECLARATION
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        string username;
        
        public MainForm(string x)
        {
            InitializeComponent();
            random = new Random();
            username = x;
            button1.Visible = false;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        //Methodes
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }
        private void ActivateButton(object btnSender)
        {
            if (btnSender!= null)
            {
                DisableButton();
                if (currentButton != (Button)btnSender)
                {
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panelTitleBar.BackColor = color;
                    panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color,-0.3);
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    button1.Visible = true;

                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType()==typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        //Methode Open form child

        private void OpenChildForm(Form childForm,Object btnsender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnsender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.btn_gesreserv.Controls.Add(childForm);
            this.btn_gesreserv.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lbl_Title.Text = currentButton.Text;

        }
        //methode 


        private void btn_Ajt_User_Click(object sender, EventArgs e)
        {
            //
            OpenChildForm(new Forms.AjtUSERcs(), sender);
        }

        private void btn_AjtCLT_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Ajouter_Client(), sender);
        }

        private void btn_GST_CLT_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Gestion_Des_Clients(), sender);
        }

        private void btn_Ajt_Chambre_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Ajouter_Nouveu_Chambres(), sender);
        }

        private void btn_GST_Chambre_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Gestion_Des_Chambres(), sender);
        }

        private void btn_GST_reservation_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Gestion_Des_reservation(), sender);
        }

        private void btn_Ajt_Reservation_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Ajouter_reservation(), sender);
        }

        private void btn_GST_Fac_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Reporting(), sender);
        }

        private void btn_Ajt_Service_Click(object sender, EventArgs e)
        {
                
        }

        private void btn_GST_User_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Gestion_Users(), sender);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (username == "Modérateur")
            {
                btn_Ajt_User.Visible = false;
                btn_GST_User.Visible = false;
            }
            else if (username == "User")
            {
                btn_Ajt_User.Visible = false;
                btn_GST_User.Visible = false;
                btn_GST_CLT.Visible = false;
                btn_GST_Chambre.Visible = false;
                btn_GST_reservation.Visible = false;
            }
            
        }

        private void btn_User_Logout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Vous étes sure ??","",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                LoginForm Log = new LoginForm();
                this.Hide();
                Log.ShowDialog();
            }
        }

        private void btn_OutService_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Client_Services(), sender);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();
            
        }
        private void Reset()
        {
            DisableButton();
            lbl_Title.Text = "Page D'Accueil";
            panelTitleBar.BackColor = Color.FromArgb(26, 1, 155);
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            currentButton = null;
            button1.Visible = false;
        }

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Vous étes sure ??","", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
