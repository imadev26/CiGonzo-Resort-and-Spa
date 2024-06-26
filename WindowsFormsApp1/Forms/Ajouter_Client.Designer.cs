
namespace WindowsFormsApp1.Forms
{
    partial class Ajouter_Client
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView_guest = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btn_loadDGV = new System.Windows.Forms.Button();
            this.button_GM_reset = new System.Windows.Forms.Button();
            this.button_GM_add = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_FaxClient = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_CLT_numero = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_CLT_pays = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_clt_ville = new System.Windows.Forms.TextBox();
            this.txt_CLT_adresse = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_Website = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_numDoc = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Cb_DocumentType = new System.Windows.Forms.ComboBox();
            this.txt_CLT_ID = new System.Windows.Forms.TextBox();
            this.txt_CLT_pren = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_CLT_nom = new System.Windows.Forms.TextBox();
            this.dtp_ddn = new System.Windows.Forms.DateTimePicker();
            this.cb_gender = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txt_CodePostal = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_guest)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView_guest);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1155, 538);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView_guest
            // 
            this.dataGridView_guest.AllowUserToAddRows = false;
            this.dataGridView_guest.AllowUserToDeleteRows = false;
            this.dataGridView_guest.AllowUserToResizeColumns = false;
            this.dataGridView_guest.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.dataGridView_guest.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_guest.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_guest.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_guest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_guest.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_guest.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_guest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_guest.Location = new System.Drawing.Point(0, 327);
            this.dataGridView_guest.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView_guest.Name = "dataGridView_guest";
            this.dataGridView_guest.ReadOnly = true;
            this.dataGridView_guest.RowHeadersWidth = 82;
            this.dataGridView_guest.RowTemplate.Height = 33;
            this.dataGridView_guest.Size = new System.Drawing.Size(1155, 211);
            this.dataGridView_guest.TabIndex = 69;
            this.dataGridView_guest.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView_guest_MouseDoubleClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1155, 327);
            this.panel2.TabIndex = 70;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(514, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(641, 327);
            this.panel5.TabIndex = 120;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btn_loadDGV);
            this.panel7.Controls.Add(this.button_GM_reset);
            this.panel7.Controls.Add(this.button_GM_add);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(434, 0);
            this.panel7.Margin = new System.Windows.Forms.Padding(2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(207, 327);
            this.panel7.TabIndex = 127;
            // 
            // btn_loadDGV
            // 
            this.btn_loadDGV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(4)))), ((int)(((byte)(156)))));
            this.btn_loadDGV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_loadDGV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_loadDGV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_loadDGV.Font = new System.Drawing.Font("Montserrat", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_loadDGV.ForeColor = System.Drawing.Color.White;
            this.btn_loadDGV.Location = new System.Drawing.Point(0, 180);
            this.btn_loadDGV.Margin = new System.Windows.Forms.Padding(2);
            this.btn_loadDGV.Name = "btn_loadDGV";
            this.btn_loadDGV.Size = new System.Drawing.Size(207, 49);
            this.btn_loadDGV.TabIndex = 126;
            this.btn_loadDGV.Text = "Charger";
            this.btn_loadDGV.UseVisualStyleBackColor = false;
            this.btn_loadDGV.Click += new System.EventHandler(this.btn_loadDGV_Click);
            // 
            // button_GM_reset
            // 
            this.button_GM_reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(4)))), ((int)(((byte)(156)))));
            this.button_GM_reset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_GM_reset.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button_GM_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_GM_reset.Font = new System.Drawing.Font("Montserrat", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_GM_reset.ForeColor = System.Drawing.Color.White;
            this.button_GM_reset.Location = new System.Drawing.Point(0, 229);
            this.button_GM_reset.Margin = new System.Windows.Forms.Padding(2);
            this.button_GM_reset.Name = "button_GM_reset";
            this.button_GM_reset.Size = new System.Drawing.Size(207, 49);
            this.button_GM_reset.TabIndex = 125;
            this.button_GM_reset.Text = "Réinitialiser";
            this.button_GM_reset.UseVisualStyleBackColor = false;
            this.button_GM_reset.Click += new System.EventHandler(this.button_GM_reset_Click_1);
            // 
            // button_GM_add
            // 
            this.button_GM_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(4)))), ((int)(((byte)(156)))));
            this.button_GM_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_GM_add.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button_GM_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_GM_add.Font = new System.Drawing.Font("Montserrat", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_GM_add.ForeColor = System.Drawing.Color.White;
            this.button_GM_add.Location = new System.Drawing.Point(0, 278);
            this.button_GM_add.Margin = new System.Windows.Forms.Padding(2);
            this.button_GM_add.Name = "button_GM_add";
            this.button_GM_add.Size = new System.Drawing.Size(207, 49);
            this.button_GM_add.TabIndex = 0;
            this.button_GM_add.Text = "Ajouter";
            this.button_GM_add.UseVisualStyleBackColor = false;
            this.button_GM_add.Click += new System.EventHandler(this.button_GM_add_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.groupBox2);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(434, 327);
            this.panel6.TabIndex = 126;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.txt_CodePostal);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.txt_FaxClient);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txt_CLT_numero);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txt_CLT_pays);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txt_clt_ville);
            this.groupBox2.Controls.Add(this.txt_CLT_adresse);
            this.groupBox2.Location = new System.Drawing.Point(4, 13);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(427, 312);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Contact et adresse du client";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(74, 246);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(13, 16);
            this.label14.TabIndex = 155;
            this.label14.Text = "*";
            // 
            // txt_FaxClient
            // 
            this.txt_FaxClient.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_FaxClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_FaxClient.Location = new System.Drawing.Point(199, 241);
            this.txt_FaxClient.Name = "txt_FaxClient";
            this.txt_FaxClient.Size = new System.Drawing.Size(180, 21);
            this.txt_FaxClient.TabIndex = 154;
            this.txt_FaxClient.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_FaxClient_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(37, 249);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 16);
            this.label12.TabIndex = 153;
            this.label12.Text = "FAX";
            // 
            // txt_CLT_numero
            // 
            this.txt_CLT_numero.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_CLT_numero.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CLT_numero.Location = new System.Drawing.Point(199, 206);
            this.txt_CLT_numero.Margin = new System.Windows.Forms.Padding(2);
            this.txt_CLT_numero.Name = "txt_CLT_numero";
            this.txt_CLT_numero.Size = new System.Drawing.Size(180, 22);
            this.txt_CLT_numero.TabIndex = 4;
            this.txt_CLT_numero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_CLT_numero_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(37, 212);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 16);
            this.label9.TabIndex = 152;
            this.label9.Text = "Numéro de client";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(35, 60);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 16);
            this.label8.TabIndex = 151;
            this.label8.Text = "Pays du client";
            // 
            // txt_CLT_pays
            // 
            this.txt_CLT_pays.AutoCompleteCustomSource.AddRange(new string[] {
            "Afghanistan",
            "Albania",
            "Algeria",
            "Andorra",
            "Angola",
            "Antigua & Deps",
            "Argentina",
            "Armenia",
            "Australia",
            "Austria",
            "Azerbaijan",
            "Bahamas",
            "Bahrain",
            "Bangladesh",
            "Barbados",
            "Belarus",
            "Belgium",
            "Belize",
            "Benin",
            "Bhutan",
            "Bolivia",
            "Bosnia Herzegovina",
            "Botswana",
            "Brazil",
            "Brunei",
            "Bulgaria",
            "Burkina",
            "Burundi",
            "Cambodia",
            "Cameroon",
            "Canada",
            "Cape Verde",
            "Central African Rep",
            "Chad",
            "Chile",
            "China",
            "Colombia",
            "Comoros",
            "Congo",
            "Congo {Democratic Rep}",
            "Costa Rica",
            "Croatia",
            "Cuba",
            "Cyprus",
            "Czech Republic",
            "Denmark",
            "Djibouti",
            "Dominica",
            "Dominican Republic",
            "East Timor",
            "Ecuador",
            "Egypt",
            "El Salvador",
            "Equatorial Guinea",
            "Eritrea",
            "Estonia",
            "Ethiopia",
            "Fiji",
            "Finland",
            "France",
            "Gabon",
            "Gambia",
            "Georgia",
            "Germany",
            "Ghana",
            "Greece",
            "Grenada",
            "Guatemala",
            "Guinea",
            "Guinea-Bissau",
            "Guyana",
            "Haiti",
            "Honduras",
            "Hungary",
            "Iceland",
            "India",
            "Indonesia",
            "Iran",
            "Iraq",
            "Ireland {Republic}",
            "Israel",
            "Italy",
            "Ivory Coast",
            "Jamaica",
            "Japan",
            "Jordan",
            "Kazakhstan",
            "Kenya",
            "Kiribati",
            "Korea North",
            "Korea South",
            "Kosovo",
            "Kuwait",
            "Kyrgyzstan",
            "Laos",
            "Latvia",
            "Lebanon",
            "Lesotho",
            "Liberia",
            "Libya",
            "Liechtenstein",
            "Lithuania",
            "Luxembourg",
            "Macedonia",
            "Madagascar",
            "Malawi",
            "Malaysia",
            "Maldives",
            "Mali",
            "Malta",
            "Marshall Islands",
            "Mauritania",
            "Mauritius",
            "Mexico",
            "Micronesia",
            "Moldova",
            "Monaco",
            "Mongolia",
            "Montenegro",
            "Morocco",
            "Mozambique",
            "Myanmar, {Burma}",
            "Namibia",
            "Nauru",
            "Nepal",
            "Netherlands",
            "New Zealand",
            "Nicaragua",
            "Niger",
            "Nigeria",
            "Norway",
            "Oman",
            "Pakistan",
            "Palau",
            "Panama",
            "Papua New Guinea",
            "Paraguay",
            "Peru",
            "Philippines",
            "Poland",
            "Portugal",
            "Qatar",
            "Romania",
            "Russian Federation",
            "Rwanda",
            "St Kitts & Nevis",
            "St Lucia",
            "Saint Vincent & the Grenadines",
            "Samoa",
            "San Marino",
            "Sao Tome & Principe",
            "Saudi Arabia",
            "Senegal",
            "Serbia",
            "Seychelles",
            "Sierra Leone",
            "Singapore",
            "Slovakia",
            "Slovenia",
            "Solomon Islands",
            "Somalia",
            "South Africa",
            "South Sudan",
            "Spain",
            "Sri Lanka",
            "Sudan",
            "Suriname",
            "Swaziland",
            "Sweden",
            "Switzerland",
            "Syria",
            "Taiwan",
            "Tajikistan",
            "Tanzania",
            "Thailand",
            "Togo",
            "Tonga",
            "Trinidad & Tobago",
            "Tunisia",
            "Turkey",
            "Turkmenistan",
            "Tuvalu",
            "Uganda",
            "Ukraine",
            "United Arab Emirates",
            "United Kingdom",
            "United States",
            "Uruguay",
            "Uzbekistan",
            "Vanuatu",
            "Vatican City",
            "Venezuela",
            "Vietnam",
            "Yemen",
            "Zambia",
            "Zimbabwe"});
            this.txt_CLT_pays.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txt_CLT_pays.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_CLT_pays.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_CLT_pays.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CLT_pays.Location = new System.Drawing.Point(199, 54);
            this.txt_CLT_pays.Margin = new System.Windows.Forms.Padding(2);
            this.txt_CLT_pays.Name = "txt_CLT_pays";
            this.txt_CLT_pays.Size = new System.Drawing.Size(161, 22);
            this.txt_CLT_pays.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(37, 136);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 16);
            this.label6.TabIndex = 147;
            this.label6.Text = "Adresse du client";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(35, 98);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 16);
            this.label7.TabIndex = 148;
            this.label7.Text = "Ville du client";
            // 
            // txt_clt_ville
            // 
            this.txt_clt_ville.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_clt_ville.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_clt_ville.Location = new System.Drawing.Point(199, 92);
            this.txt_clt_ville.Margin = new System.Windows.Forms.Padding(2);
            this.txt_clt_ville.Name = "txt_clt_ville";
            this.txt_clt_ville.Size = new System.Drawing.Size(161, 22);
            this.txt_clt_ville.TabIndex = 2;
            // 
            // txt_CLT_adresse
            // 
            this.txt_CLT_adresse.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_CLT_adresse.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CLT_adresse.Location = new System.Drawing.Point(199, 130);
            this.txt_CLT_adresse.Margin = new System.Windows.Forms.Padding(2);
            this.txt_CLT_adresse.Name = "txt_CLT_adresse";
            this.txt_CLT_adresse.Size = new System.Drawing.Size(213, 22);
            this.txt_CLT_adresse.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.groupBox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(514, 327);
            this.panel4.TabIndex = 119;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_Email);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txt_Website);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txt_numDoc);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Cb_DocumentType);
            this.groupBox1.Controls.Add(this.txt_CLT_ID);
            this.groupBox1.Controls.Add(this.txt_CLT_pren);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_CLT_nom);
            this.groupBox1.Controls.Add(this.dtp_ddn);
            this.groupBox1.Controls.Add(this.cb_gender);
            this.groupBox1.Location = new System.Drawing.Point(9, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(490, 313);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informations du client";
            // 
            // txt_Email
            // 
            this.txt_Email.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_Email.Location = new System.Drawing.Point(242, 284);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(160, 20);
            this.txt_Email.TabIndex = 157;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(109, 288);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(13, 16);
            this.label16.TabIndex = 156;
            this.label16.Text = "*";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(45, 288);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(45, 16);
            this.label15.TabIndex = 155;
            this.label15.Text = "E-Mail";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(109, 251);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(13, 16);
            this.label13.TabIndex = 154;
            this.label13.Text = "*";
            // 
            // txt_Website
            // 
            this.txt_Website.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_Website.Location = new System.Drawing.Point(242, 247);
            this.txt_Website.Name = "txt_Website";
            this.txt_Website.Size = new System.Drawing.Size(160, 20);
            this.txt_Website.TabIndex = 153;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(45, 251);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 16);
            this.label11.TabIndex = 152;
            this.label11.Text = "Site Web";
            // 
            // txt_numDoc
            // 
            this.txt_numDoc.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_numDoc.Location = new System.Drawing.Point(242, 211);
            this.txt_numDoc.Name = "txt_numDoc";
            this.txt_numDoc.Size = new System.Drawing.Size(162, 20);
            this.txt_numDoc.TabIndex = 151;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(45, 215);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(148, 16);
            this.label10.TabIndex = 150;
            this.label10.Text = "Numero De Document";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 179);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 16);
            this.label1.TabIndex = 149;
            this.label1.Text = "Document Type";
            // 
            // Cb_DocumentType
            // 
            this.Cb_DocumentType.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Cb_DocumentType.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cb_DocumentType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cb_DocumentType.FormattingEnabled = true;
            this.Cb_DocumentType.Items.AddRange(new object[] {
            "Passport",
            "ID CARD",
            "Permis De Conduire",
            "Autre"});
            this.Cb_DocumentType.Location = new System.Drawing.Point(242, 172);
            this.Cb_DocumentType.Margin = new System.Windows.Forms.Padding(2);
            this.Cb_DocumentType.Name = "Cb_DocumentType";
            this.Cb_DocumentType.Size = new System.Drawing.Size(164, 23);
            this.Cb_DocumentType.TabIndex = 148;
            // 
            // txt_CLT_ID
            // 
            this.txt_CLT_ID.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_CLT_ID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_CLT_ID.Font = new System.Drawing.Font("Montserrat", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CLT_ID.Location = new System.Drawing.Point(4, 17);
            this.txt_CLT_ID.Margin = new System.Windows.Forms.Padding(2);
            this.txt_CLT_ID.Name = "txt_CLT_ID";
            this.txt_CLT_ID.ReadOnly = true;
            this.txt_CLT_ID.Size = new System.Drawing.Size(18, 25);
            this.txt_CLT_ID.TabIndex = 1;
            this.txt_CLT_ID.Visible = false;
            // 
            // txt_CLT_pren
            // 
            this.txt_CLT_pren.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_CLT_pren.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CLT_pren.Location = new System.Drawing.Point(240, 29);
            this.txt_CLT_pren.Margin = new System.Windows.Forms.Padding(2);
            this.txt_CLT_pren.Name = "txt_CLT_pren";
            this.txt_CLT_pren.Size = new System.Drawing.Size(162, 22);
            this.txt_CLT_pren.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(45, 143);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 16);
            this.label5.TabIndex = 147;
            this.label5.Text = "Date de naissance";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(45, 107);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 146;
            this.label4.Text = "Client sexe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 71);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 16);
            this.label3.TabIndex = 145;
            this.label3.Text = "Nom du client";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 35);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 16);
            this.label2.TabIndex = 144;
            this.label2.Text = "Prénom du client";
            // 
            // txt_CLT_nom
            // 
            this.txt_CLT_nom.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_CLT_nom.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CLT_nom.Location = new System.Drawing.Point(238, 65);
            this.txt_CLT_nom.Margin = new System.Windows.Forms.Padding(2);
            this.txt_CLT_nom.Name = "txt_CLT_nom";
            this.txt_CLT_nom.Size = new System.Drawing.Size(163, 22);
            this.txt_CLT_nom.TabIndex = 1;
            // 
            // dtp_ddn
            // 
            this.dtp_ddn.CalendarFont = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_ddn.CalendarMonthBackground = System.Drawing.SystemColors.InactiveCaption;
            this.dtp_ddn.Checked = false;
            this.dtp_ddn.CustomFormat = "MMMM dd, yyyy";
            this.dtp_ddn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_ddn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_ddn.Location = new System.Drawing.Point(240, 138);
            this.dtp_ddn.Margin = new System.Windows.Forms.Padding(2);
            this.dtp_ddn.Name = "dtp_ddn";
            this.dtp_ddn.Size = new System.Drawing.Size(164, 21);
            this.dtp_ddn.TabIndex = 3;
            // 
            // cb_gender
            // 
            this.cb_gender.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cb_gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_gender.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cb_gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_gender.FormattingEnabled = true;
            this.cb_gender.Items.AddRange(new object[] {
            "Homme",
            "Femme",
            "X",
            "O"});
            this.cb_gender.Location = new System.Drawing.Point(240, 100);
            this.cb_gender.Margin = new System.Windows.Forms.Padding(2);
            this.cb_gender.Name = "cb_gender";
            this.cb_gender.Size = new System.Drawing.Size(164, 23);
            this.cb_gender.TabIndex = 2;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(37, 174);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(81, 16);
            this.label17.TabIndex = 157;
            this.label17.Text = "Code Postal";
            // 
            // txt_CodePostal
            // 
            this.txt_CodePostal.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_CodePostal.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CodePostal.Location = new System.Drawing.Point(199, 168);
            this.txt_CodePostal.Margin = new System.Windows.Forms.Padding(2);
            this.txt_CodePostal.Name = "txt_CodePostal";
            this.txt_CodePostal.Size = new System.Drawing.Size(213, 22);
            this.txt_CodePostal.TabIndex = 156;
            // 
            // Ajouter_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 538);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Ajouter_Client";
            this.Load += new System.EventHandler(this.Ajouter_Client_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_guest)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView_guest;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button button_GM_reset;
        private System.Windows.Forms.Button button_GM_add;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_CLT_numero;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_CLT_pays;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_clt_ville;
        private System.Windows.Forms.TextBox txt_CLT_adresse;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_CLT_pren;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_CLT_nom;
        private System.Windows.Forms.TextBox txt_CLT_ID;
        private System.Windows.Forms.DateTimePicker dtp_ddn;
        private System.Windows.Forms.ComboBox cb_gender;
        private System.Windows.Forms.Button btn_loadDGV;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_numDoc;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Cb_DocumentType;
        private System.Windows.Forms.TextBox txt_Website;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_FaxClient;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txt_CodePostal;
    }
}