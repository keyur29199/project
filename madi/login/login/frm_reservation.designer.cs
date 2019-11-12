namespace loginform
{
    partial class frm_reservation
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
            this.components = new System.ComponentModel.Container();
            this.lblbooking = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnnxt = new System.Windows.Forms.Button();
            this.btnbook = new System.Windows.Forms.Button();
            this.cbvia = new System.Windows.Forms.ComboBox();
            this.cbd = new System.Windows.Forms.ComboBox();
            this.cbs = new System.Windows.Forms.ComboBox();
            this.lblvia = new System.Windows.Forms.Label();
            this.txtsno = new System.Windows.Forms.TextBox();
            this.lblsno = new System.Windows.Forms.Label();
            this.txtfare = new System.Windows.Forms.TextBox();
            this.lblfare = new System.Windows.Forms.Label();
            this.cbct = new System.Windows.Forms.ComboBox();
            this.lblct = new System.Windows.Forms.Label();
            this.lbld = new System.Windows.Forms.Label();
            this.lbls = new System.Windows.Forms.Label();
            this.jd3 = new System.Windows.Forms.ComboBox();
            this.jd2 = new System.Windows.Forms.ComboBox();
            this.jd1 = new System.Windows.Forms.ComboBox();
            this.lblj = new System.Windows.Forms.Label();
            this.txtdt = new System.Windows.Forms.TextBox();
            this.lbldt = new System.Windows.Forms.Label();
            this.lbltnm = new System.Windows.Forms.Label();
            this.cbtno = new System.Windows.Forms.ComboBox();
            this.lbltn = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tnmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jmonthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jyearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sourceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ctypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.snoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tablebookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prodbDataSet = new login.prodbDataSet();
            this.table_bookTableAdapter = new login.prodbDataSetTableAdapters.table_bookTableAdapter();
            this.cbtnm = new System.Windows.Forms.ComboBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablebookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodbDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lblbooking
            // 
            this.lblbooking.AutoSize = true;
            this.lblbooking.BackColor = System.Drawing.Color.Transparent;
            this.lblbooking.Font = new System.Drawing.Font("Gabriola", 36F, System.Drawing.FontStyle.Bold);
            this.lblbooking.ForeColor = System.Drawing.Color.Blue;
            this.lblbooking.Location = new System.Drawing.Point(370, -7);
            this.lblbooking.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.lblbooking.Name = "lblbooking";
            this.lblbooking.Size = new System.Drawing.Size(545, 110);
            this.lblbooking.TabIndex = 0;
            this.lblbooking.Text = "RESERVATION-BOOKING";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.cbtnm);
            this.groupBox2.Controls.Add(this.btnnxt);
            this.groupBox2.Controls.Add(this.btnbook);
            this.groupBox2.Controls.Add(this.cbvia);
            this.groupBox2.Controls.Add(this.cbd);
            this.groupBox2.Controls.Add(this.cbs);
            this.groupBox2.Controls.Add(this.lblvia);
            this.groupBox2.Controls.Add(this.txtsno);
            this.groupBox2.Controls.Add(this.lblsno);
            this.groupBox2.Controls.Add(this.txtfare);
            this.groupBox2.Controls.Add(this.lblfare);
            this.groupBox2.Controls.Add(this.cbct);
            this.groupBox2.Controls.Add(this.lblct);
            this.groupBox2.Controls.Add(this.lbld);
            this.groupBox2.Controls.Add(this.lbls);
            this.groupBox2.Controls.Add(this.jd3);
            this.groupBox2.Controls.Add(this.jd2);
            this.groupBox2.Controls.Add(this.jd1);
            this.groupBox2.Controls.Add(this.lblj);
            this.groupBox2.Controls.Add(this.txtdt);
            this.groupBox2.Controls.Add(this.lbldt);
            this.groupBox2.Controls.Add(this.lbltnm);
            this.groupBox2.Controls.Add(this.cbtno);
            this.groupBox2.Controls.Add(this.lbltn);
            this.groupBox2.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(31, 77);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1244, 298);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Train Detail";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btnnxt
            // 
            this.btnnxt.BackColor = System.Drawing.Color.Orange;
            this.btnnxt.Font = new System.Drawing.Font("Mongolian Baiti", 16.2F, System.Drawing.FontStyle.Bold);
            this.btnnxt.Location = new System.Drawing.Point(1060, 235);
            this.btnnxt.Name = "btnnxt";
            this.btnnxt.Size = new System.Drawing.Size(149, 43);
            this.btnnxt.TabIndex = 25;
            this.btnnxt.Text = "Next";
            this.btnnxt.UseVisualStyleBackColor = false;
            this.btnnxt.Click += new System.EventHandler(this.btnnxt_Click);
            // 
            // btnbook
            // 
            this.btnbook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnbook.Font = new System.Drawing.Font("Mongolian Baiti", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbook.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnbook.Location = new System.Drawing.Point(906, 235);
            this.btnbook.Name = "btnbook";
            this.btnbook.Size = new System.Drawing.Size(148, 43);
            this.btnbook.TabIndex = 24;
            this.btnbook.Text = "Book";
            this.btnbook.UseVisualStyleBackColor = false;
            this.btnbook.Click += new System.EventHandler(this.btnbook_Click);
            // 
            // cbvia
            // 
            this.cbvia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbvia.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbvia.ForeColor = System.Drawing.SystemColors.Desktop;
            this.cbvia.FormattingEnabled = true;
            this.cbvia.Items.AddRange(new object[] {
            "DIBRUGARH TOWN",
            "JAMMU TAWI",
            "PURI",
            "HOWRAH JN",
            "NEW DELHI",
            "AHMEDABAD JN",
            "HOWRAH JN",
            "ANAND VIHAR TRM",
            "BANGALORE CITY JN",
            "FIROZPUR CANTT"});
            this.cbvia.Location = new System.Drawing.Point(1012, 130);
            this.cbvia.Name = "cbvia";
            this.cbvia.Size = new System.Drawing.Size(197, 29);
            this.cbvia.TabIndex = 23;
            // 
            // cbd
            // 
            this.cbd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbd.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbd.ForeColor = System.Drawing.SystemColors.Desktop;
            this.cbd.FormattingEnabled = true;
            this.cbd.Items.AddRange(new object[] {
            "DIBRUGARH TOWN",
            "JAMMU TAWI",
            "PURI",
            "HOWRAH JN",
            "NEW DELHI",
            "GUWAHATI",
            "DANAPUR",
            "MUMBAI",
            "PUNE"});
            this.cbd.Location = new System.Drawing.Point(635, 133);
            this.cbd.Name = "cbd";
            this.cbd.Size = new System.Drawing.Size(247, 29);
            this.cbd.TabIndex = 22;
            // 
            // cbs
            // 
            this.cbs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbs.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbs.ForeColor = System.Drawing.SystemColors.Desktop;
            this.cbs.FormattingEnabled = true;
            this.cbs.Items.AddRange(new object[] {
            "NEW DELHI",
            "PUNE",
            "YESVANTPUR JN",
            "MUMBAI CST",
            "PURI",
            "AHMEDABAD JN",
            "HOWRAH JN",
            "ANAND VIHAR TRM",
            "BANGALORE CITY JN",
            "FIROZPUR CANT"});
            this.cbs.Location = new System.Drawing.Point(195, 141);
            this.cbs.Name = "cbs";
            this.cbs.Size = new System.Drawing.Size(247, 29);
            this.cbs.TabIndex = 21;
            // 
            // lblvia
            // 
            this.lblvia.AutoSize = true;
            this.lblvia.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvia.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblvia.Location = new System.Drawing.Point(932, 144);
            this.lblvia.Name = "lblvia";
            this.lblvia.Size = new System.Drawing.Size(55, 21);
            this.lblvia.TabIndex = 20;
            this.lblvia.Text = "Via :";
            // 
            // txtsno
            // 
            this.txtsno.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsno.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtsno.Location = new System.Drawing.Point(1012, 176);
            this.txtsno.Name = "txtsno";
            this.txtsno.Size = new System.Drawing.Size(197, 31);
            this.txtsno.TabIndex = 19;
            // 
            // lblsno
            // 
            this.lblsno.AutoSize = true;
            this.lblsno.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsno.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblsno.Location = new System.Drawing.Point(887, 184);
            this.lblsno.Name = "lblsno";
            this.lblsno.Size = new System.Drawing.Size(100, 21);
            this.lblsno.TabIndex = 18;
            this.lblsno.Text = "Seat No. :";
            // 
            // txtfare
            // 
            this.txtfare.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfare.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtfare.Location = new System.Drawing.Point(635, 176);
            this.txtfare.Name = "txtfare";
            this.txtfare.Size = new System.Drawing.Size(228, 31);
            this.txtfare.TabIndex = 17;
            // 
            // lblfare
            // 
            this.lblfare.AutoSize = true;
            this.lblfare.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfare.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblfare.Location = new System.Drawing.Point(494, 188);
            this.lblfare.Name = "lblfare";
            this.lblfare.Size = new System.Drawing.Size(114, 21);
            this.lblfare.TabIndex = 16;
            this.lblfare.Text = "Fare (Rs.) :";
            // 
            // cbct
            // 
            this.cbct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbct.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbct.ForeColor = System.Drawing.SystemColors.Desktop;
            this.cbct.FormattingEnabled = true;
            this.cbct.Items.AddRange(new object[] {
            "|| Ac Seat",
            "||| Ac Seat",
            " Ac Chair Seat",
            "| Class Seat",
            "|| Class Seat",
            "Genral Seat"});
            this.cbct.Location = new System.Drawing.Point(195, 185);
            this.cbct.Name = "cbct";
            this.cbct.Size = new System.Drawing.Size(247, 29);
            this.cbct.TabIndex = 15;
            // 
            // lblct
            // 
            this.lblct.AutoSize = true;
            this.lblct.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblct.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblct.Location = new System.Drawing.Point(35, 188);
            this.lblct.Name = "lblct";
            this.lblct.Size = new System.Drawing.Size(123, 21);
            this.lblct.TabIndex = 14;
            this.lblct.Text = "Class Type :";
            // 
            // lbld
            // 
            this.lbld.AutoSize = true;
            this.lbld.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbld.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lbld.Location = new System.Drawing.Point(488, 138);
            this.lbld.Name = "lbld";
            this.lbld.Size = new System.Drawing.Size(128, 21);
            this.lbld.TabIndex = 12;
            this.lbld.Text = "Destination :";
            // 
            // lbls
            // 
            this.lbls.AutoSize = true;
            this.lbls.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbls.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lbls.Location = new System.Drawing.Point(35, 141);
            this.lbls.Name = "lbls";
            this.lbls.Size = new System.Drawing.Size(85, 21);
            this.lbls.TabIndex = 10;
            this.lbls.Text = "Source :";
            // 
            // jd3
            // 
            this.jd3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.jd3.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jd3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.jd3.FormattingEnabled = true;
            this.jd3.Items.AddRange(new object[] {
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030"});
            this.jd3.Location = new System.Drawing.Point(772, 93);
            this.jd3.Name = "jd3";
            this.jd3.Size = new System.Drawing.Size(91, 29);
            this.jd3.TabIndex = 9;
            // 
            // jd2
            // 
            this.jd2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.jd2.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jd2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.jd2.FormattingEnabled = true;
            this.jd2.Items.AddRange(new object[] {
            "JAN",
            "FEB",
            "MAR",
            "APR",
            "MAY",
            "JUN",
            "JULY",
            "AUG",
            "SEP",
            "OCT",
            "NOV",
            "DES"});
            this.jd2.Location = new System.Drawing.Point(695, 92);
            this.jd2.Name = "jd2";
            this.jd2.Size = new System.Drawing.Size(71, 29);
            this.jd2.TabIndex = 8;
            // 
            // jd1
            // 
            this.jd1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.jd1.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jd1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.jd1.FormattingEnabled = true;
            this.jd1.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.jd1.Location = new System.Drawing.Point(635, 92);
            this.jd1.Name = "jd1";
            this.jd1.Size = new System.Drawing.Size(54, 29);
            this.jd1.TabIndex = 7;
            // 
            // lblj
            // 
            this.lblj.AutoSize = true;
            this.lblj.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblj.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblj.Location = new System.Drawing.Point(488, 90);
            this.lblj.Name = "lblj";
            this.lblj.Size = new System.Drawing.Size(132, 21);
            this.lblj.TabIndex = 6;
            this.lblj.Text = "Journy Date :";
            // 
            // txtdt
            // 
            this.txtdt.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdt.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtdt.Location = new System.Drawing.Point(195, 90);
            this.txtdt.Name = "txtdt";
            this.txtdt.Size = new System.Drawing.Size(247, 31);
            this.txtdt.TabIndex = 5;
            // 
            // lbldt
            // 
            this.lbldt.AutoSize = true;
            this.lbldt.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldt.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lbldt.Location = new System.Drawing.Point(31, 96);
            this.lbldt.Name = "lbldt";
            this.lbldt.Size = new System.Drawing.Size(158, 21);
            this.lbldt.TabIndex = 4;
            this.lbldt.Text = "Depature Time :";
            // 
            // lbltnm
            // 
            this.lbltnm.AutoSize = true;
            this.lbltnm.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltnm.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lbltnm.Location = new System.Drawing.Point(490, 40);
            this.lbltnm.Name = "lbltnm";
            this.lbltnm.Size = new System.Drawing.Size(130, 21);
            this.lbltnm.TabIndex = 2;
            this.lbltnm.Text = "Train Name :";
            // 
            // cbtno
            // 
            this.cbtno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbtno.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbtno.ForeColor = System.Drawing.SystemColors.Desktop;
            this.cbtno.FormattingEnabled = true;
            this.cbtno.Items.AddRange(new object[] {
            "12424",
            "11077",
            "12802",
            "12864",
            "12859",
            "12801",
            "12833",
            "12307",
            "12506",
            "12295"});
            this.cbtno.Location = new System.Drawing.Point(195, 42);
            this.cbtno.Name = "cbtno";
            this.cbtno.Size = new System.Drawing.Size(247, 29);
            this.cbtno.TabIndex = 1;
            // 
            // lbltn
            // 
            this.lbltn.AutoSize = true;
            this.lbltn.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltn.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lbltn.Location = new System.Drawing.Point(35, 50);
            this.lbltn.Name = "lbltn";
            this.lbltn.Size = new System.Drawing.Size(100, 21);
            this.lbltn.TabIndex = 0;
            this.lbltn.Text = "Trail No :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tnoDataGridViewTextBoxColumn,
            this.tnmDataGridViewTextBoxColumn,
            this.dtimeDataGridViewTextBoxColumn,
            this.jdateDataGridViewTextBoxColumn,
            this.jmonthDataGridViewTextBoxColumn,
            this.jyearDataGridViewTextBoxColumn,
            this.sourceDataGridViewTextBoxColumn,
            this.destiDataGridViewTextBoxColumn,
            this.viaDataGridViewTextBoxColumn,
            this.ctypeDataGridViewTextBoxColumn,
            this.fareDataGridViewTextBoxColumn,
            this.snoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tablebookBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(31, 398);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1244, 224);
            this.dataGridView1.TabIndex = 3;
            // 
            // tnoDataGridViewTextBoxColumn
            // 
            this.tnoDataGridViewTextBoxColumn.DataPropertyName = "T_no";
            this.tnoDataGridViewTextBoxColumn.HeaderText = "T_no";
            this.tnoDataGridViewTextBoxColumn.Name = "tnoDataGridViewTextBoxColumn";
            // 
            // tnmDataGridViewTextBoxColumn
            // 
            this.tnmDataGridViewTextBoxColumn.DataPropertyName = "T_nm";
            this.tnmDataGridViewTextBoxColumn.HeaderText = "T_nm";
            this.tnmDataGridViewTextBoxColumn.Name = "tnmDataGridViewTextBoxColumn";
            // 
            // dtimeDataGridViewTextBoxColumn
            // 
            this.dtimeDataGridViewTextBoxColumn.DataPropertyName = "D_time";
            this.dtimeDataGridViewTextBoxColumn.HeaderText = "D_time";
            this.dtimeDataGridViewTextBoxColumn.Name = "dtimeDataGridViewTextBoxColumn";
            // 
            // jdateDataGridViewTextBoxColumn
            // 
            this.jdateDataGridViewTextBoxColumn.DataPropertyName = "J_date";
            this.jdateDataGridViewTextBoxColumn.HeaderText = "J_date";
            this.jdateDataGridViewTextBoxColumn.Name = "jdateDataGridViewTextBoxColumn";
            // 
            // jmonthDataGridViewTextBoxColumn
            // 
            this.jmonthDataGridViewTextBoxColumn.DataPropertyName = "J_month";
            this.jmonthDataGridViewTextBoxColumn.HeaderText = "J_month";
            this.jmonthDataGridViewTextBoxColumn.Name = "jmonthDataGridViewTextBoxColumn";
            // 
            // jyearDataGridViewTextBoxColumn
            // 
            this.jyearDataGridViewTextBoxColumn.DataPropertyName = "J_year";
            this.jyearDataGridViewTextBoxColumn.HeaderText = "J_year";
            this.jyearDataGridViewTextBoxColumn.Name = "jyearDataGridViewTextBoxColumn";
            // 
            // sourceDataGridViewTextBoxColumn
            // 
            this.sourceDataGridViewTextBoxColumn.DataPropertyName = "Source";
            this.sourceDataGridViewTextBoxColumn.HeaderText = "Source";
            this.sourceDataGridViewTextBoxColumn.Name = "sourceDataGridViewTextBoxColumn";
            // 
            // destiDataGridViewTextBoxColumn
            // 
            this.destiDataGridViewTextBoxColumn.DataPropertyName = "Desti";
            this.destiDataGridViewTextBoxColumn.HeaderText = "Desti";
            this.destiDataGridViewTextBoxColumn.Name = "destiDataGridViewTextBoxColumn";
            // 
            // viaDataGridViewTextBoxColumn
            // 
            this.viaDataGridViewTextBoxColumn.DataPropertyName = "Via";
            this.viaDataGridViewTextBoxColumn.HeaderText = "Via";
            this.viaDataGridViewTextBoxColumn.Name = "viaDataGridViewTextBoxColumn";
            // 
            // ctypeDataGridViewTextBoxColumn
            // 
            this.ctypeDataGridViewTextBoxColumn.DataPropertyName = "C_type";
            this.ctypeDataGridViewTextBoxColumn.HeaderText = "C_type";
            this.ctypeDataGridViewTextBoxColumn.Name = "ctypeDataGridViewTextBoxColumn";
            // 
            // fareDataGridViewTextBoxColumn
            // 
            this.fareDataGridViewTextBoxColumn.DataPropertyName = "Fare";
            this.fareDataGridViewTextBoxColumn.HeaderText = "Fare";
            this.fareDataGridViewTextBoxColumn.Name = "fareDataGridViewTextBoxColumn";
            // 
            // snoDataGridViewTextBoxColumn
            // 
            this.snoDataGridViewTextBoxColumn.DataPropertyName = "S_no";
            this.snoDataGridViewTextBoxColumn.HeaderText = "S_no";
            this.snoDataGridViewTextBoxColumn.Name = "snoDataGridViewTextBoxColumn";
            // 
            // tablebookBindingSource
            // 
            this.tablebookBindingSource.DataMember = "table_book";
            this.tablebookBindingSource.DataSource = this.prodbDataSet;
            // 
            // prodbDataSet
            // 
            this.prodbDataSet.DataSetName = "prodbDataSet";
            this.prodbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // table_bookTableAdapter
            // 
            this.table_bookTableAdapter.ClearBeforeFill = true;
            // 
            // cbtnm
            // 
            this.cbtnm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbtnm.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold);
            this.cbtnm.FormattingEnabled = true;
            this.cbtnm.Items.AddRange(new object[] {
            "DIBRUGARH TOWN RAJDHANI EXPRESS",
            "JAMMU TAWI JHELUM EXPRESS",
            "PURI PURUSHOTTAM SF EXPRESS",
            "HOWRAH SF EXPRESS",
            "HOWRAH GITANJALI SF EXPRESS",
            "NEW DELHI PURUSHOTTAM SF EXPRESS",
            "HOWRAH SF EXPRESS",
            "JODHPUR SF EXPRESS",
            "GUWAHATI NORTH EAST SF EXP",
            "DANAPUR SANGHAMITRA SF EXP"});
            this.cbtnm.Location = new System.Drawing.Point(635, 40);
            this.cbtnm.Name = "cbtnm";
            this.cbtnm.Size = new System.Drawing.Size(574, 29);
            this.cbtnm.TabIndex = 26;
            // 
            // frm_reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(22F, 40F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::login.Properties.Resources.Background_Registration_Form;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1306, 688);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblbooking);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Font = new System.Drawing.Font("Mongolian Baiti", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_reservation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reservation Detail";
            this.Load += new System.EventHandler(this.frm_reservation_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablebookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodbDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblbooking;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbltn;
        private System.Windows.Forms.Label lblj;
        private System.Windows.Forms.TextBox txtdt;
        private System.Windows.Forms.Label lbldt;
        private System.Windows.Forms.Label lbltnm;
        private System.Windows.Forms.ComboBox cbtno;
        private System.Windows.Forms.TextBox txtsno;
        private System.Windows.Forms.Label lblsno;
        private System.Windows.Forms.TextBox txtfare;
        private System.Windows.Forms.Label lblfare;
        private System.Windows.Forms.ComboBox cbct;
        private System.Windows.Forms.Label lblct;
        private System.Windows.Forms.Label lbld;
        private System.Windows.Forms.Label lbls;
        private System.Windows.Forms.ComboBox jd3;
        private System.Windows.Forms.ComboBox jd2;
        private System.Windows.Forms.ComboBox jd1;
        private System.Windows.Forms.Label lblvia;
        private System.Windows.Forms.ComboBox cbs;
        private System.Windows.Forms.ComboBox cbvia;
        private System.Windows.Forms.ComboBox cbd;
        private System.Windows.Forms.Button btnbook;
        private System.Windows.Forms.Button btnnxt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private login.prodbDataSet prodbDataSet;
        private System.Windows.Forms.BindingSource tablebookBindingSource;
        private login.prodbDataSetTableAdapters.table_bookTableAdapter table_bookTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn tnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tnmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jmonthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jyearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sourceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn destiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn viaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ctypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fareDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn snoDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox cbtnm;
    }
}