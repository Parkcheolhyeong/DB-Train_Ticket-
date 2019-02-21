namespace FebroTrain_5293564
{
    partial class FormDeserve
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDeserve));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.aSTATIONSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.station = new FebroTrain_5293564.Station();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.aSTATIONSBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.station_SEOULROOT1 = new FebroTrain_5293564.Station_SEOULROOT();
            this.a_STATIONSTableAdapter = new FebroTrain_5293564.StationTableAdapters.A_STATIONSTableAdapter();
            this.oracleConnection1 = new System.Data.OracleClient.OracleConnection();
            this.oracleCommand1 = new System.Data.OracleClient.OracleCommand();
            this.oracleCommand2 = new System.Data.OracleClient.OracleCommand();
            this.label6 = new System.Windows.Forms.Label();
            this.oracleCommand3 = new System.Data.OracleClient.OracleCommand();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.oracleCommand4 = new System.Data.OracleClient.OracleCommand();
            this.dEV_SEAT = new FebroTrain_5293564.DEV_SEAT();
            this.aSEATSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.a_SEATSTableAdapter = new FebroTrain_5293564.DEV_SEATTableAdapters.A_SEATSTableAdapter();
            this.oracleCommand5 = new System.Data.OracleClient.OracleCommand();
            this.a_STATIONSTableAdapter1 = new FebroTrain_5293564.Station_SEOULROOTTableAdapters.A_STATIONSTableAdapter();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.oracleCommand6 = new System.Data.OracleClient.OracleCommand();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aSTATIONSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.station)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aSTATIONSBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.station_SEOULROOT1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEV_SEAT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aSEATSBindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 70);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(745, 214);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(21, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "예약창";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(253, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "시";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(383, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "출발, 도착역";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Location = new System.Drawing.Point(693, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 32);
            this.button1.TabIndex = 4;
            this.button1.Text = "조회";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "00:00",
            "01:00",
            "02:00",
            "03:00",
            "04:00",
            "05:00",
            "06:00",
            "07:00",
            "08:00",
            "09:00",
            "10:00",
            "11:00",
            "12:00",
            "13:00",
            "14:00",
            "15:00",
            "16:00",
            "17:00",
            "18:00",
            "19:00",
            "20:00",
            "21:00",
            "22:00",
            "23:00"});
            this.comboBox1.Location = new System.Drawing.Point(154, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(90, 27);
            this.comboBox1.TabIndex = 5;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.aSTATIONSBindingSource;
            this.comboBox2.DisplayMember = "S_STATION";
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(478, 18);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(90, 27);
            this.comboBox2.TabIndex = 6;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // aSTATIONSBindingSource
            // 
            this.aSTATIONSBindingSource.DataMember = "A_STATIONS";
            this.aSTATIONSBindingSource.DataSource = this.station;
            // 
            // station
            // 
            this.station.DataSetName = "Station";
            this.station.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(574, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "~";
            // 
            // comboBox4
            // 
            this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox4.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "부산행",
            "서울행"});
            this.comboBox4.Location = new System.Drawing.Point(276, 19);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(90, 27);
            this.comboBox4.TabIndex = 9;
            this.comboBox4.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.aSTATIONSBindingSource1;
            this.comboBox3.DisplayMember = "S_STATION";
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(594, 18);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(90, 27);
            this.comboBox3.TabIndex = 10;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // aSTATIONSBindingSource1
            // 
            this.aSTATIONSBindingSource1.DataMember = "A_STATIONS";
            this.aSTATIONSBindingSource1.DataSource = this.station_SEOULROOT1;
            // 
            // station_SEOULROOT1
            // 
            this.station_SEOULROOT1.DataSetName = "Station_SEOULROOT";
            this.station_SEOULROOT1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // a_STATIONSTableAdapter
            // 
            this.a_STATIONSTableAdapter.ClearBeforeFill = true;
            // 
            // oracleConnection1
            // 
            this.oracleConnection1.ConnectionString = "Data Source=Febro2;User ID=A5293564;Password=\"computer12 \";Unicode=True";
            // 
            // oracleCommand1
            // 
            this.oracleCommand1.Connection = this.oracleConnection1;
            this.oracleCommand1.Parameters.AddRange(new System.Data.OracleClient.OracleParameter[] {
            new System.Data.OracleClient.OracleParameter("aa", System.Data.OracleClient.OracleType.VarChar),
            new System.Data.OracleClient.OracleParameter("bb", System.Data.OracleClient.OracleType.VarChar)});
            // 
            // oracleCommand2
            // 
            this.oracleCommand2.Connection = this.oracleConnection1;
            this.oracleCommand2.Parameters.AddRange(new System.Data.OracleClient.OracleParameter[] {
            new System.Data.OracleClient.OracleParameter("aa", System.Data.OracleClient.OracleType.VarChar),
            new System.Data.OracleClient.OracleParameter("bb", System.Data.OracleClient.OracleType.VarChar),
            new System.Data.OracleClient.OracleParameter("cc", System.Data.OracleClient.OracleType.VarChar)});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(10, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 12);
            this.label6.TabIndex = 12;
            this.label6.Text = "label6";
            // 
            // oracleCommand3
            // 
            this.oracleCommand3.Connection = this.oracleConnection1;
            this.oracleCommand3.Parameters.AddRange(new System.Data.OracleClient.OracleParameter[] {
            new System.Data.OracleClient.OracleParameter("aa", System.Data.OracleClient.OracleType.VarChar),
            new System.Data.OracleClient.OracleParameter("bb", System.Data.OracleClient.OracleType.VarChar),
            new System.Data.OracleClient.OracleParameter("cc", System.Data.OracleClient.OracleType.VarChar),
            new System.Data.OracleClient.OracleParameter("dd", System.Data.OracleClient.OracleType.VarChar),
            new System.Data.OracleClient.OracleParameter("ee", System.Data.OracleClient.OracleType.VarChar)});
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 52);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(30, 16);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(6, 131);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(30, 16);
            this.checkBox2.TabIndex = 14;
            this.checkBox2.Text = "2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(139, 52);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(30, 16);
            this.checkBox3.TabIndex = 15;
            this.checkBox3.Text = "3";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(140, 131);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(30, 16);
            this.checkBox4.TabIndex = 16;
            this.checkBox4.Text = "4";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.pictureBox4);
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.checkBox4);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.checkBox3);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Location = new System.Drawing.Point(6, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(306, 181);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "1호차";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(175, 98);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(77, 72);
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(42, 98);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(77, 72);
            this.pictureBox4.TabIndex = 24;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(175, 20);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(77, 72);
            this.pictureBox3.TabIndex = 23;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(42, 20);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(77, 72);
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox8);
            this.groupBox2.Controls.Add(this.pictureBox7);
            this.groupBox2.Controls.Add(this.pictureBox6);
            this.groupBox2.Controls.Add(this.pictureBox5);
            this.groupBox2.Controls.Add(this.checkBox5);
            this.groupBox2.Controls.Add(this.checkBox6);
            this.groupBox2.Controls.Add(this.checkBox7);
            this.groupBox2.Controls.Add(this.checkBox8);
            this.groupBox2.Location = new System.Drawing.Point(318, 72);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(306, 181);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "2호차";
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(174, 98);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(77, 72);
            this.pictureBox8.TabIndex = 29;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(174, 20);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(77, 72);
            this.pictureBox7.TabIndex = 28;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(35, 98);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(77, 72);
            this.pictureBox6.TabIndex = 27;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(35, 20);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(77, 72);
            this.pictureBox5.TabIndex = 26;
            this.pictureBox5.TabStop = false;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(6, 52);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(30, 16);
            this.checkBox5.TabIndex = 16;
            this.checkBox5.Text = "1";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(6, 131);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(30, 16);
            this.checkBox6.TabIndex = 13;
            this.checkBox6.Text = "2";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(138, 52);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(30, 16);
            this.checkBox7.TabIndex = 15;
            this.checkBox7.Text = "3";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Location = new System.Drawing.Point(138, 131);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(30, 16);
            this.checkBox8.TabIndex = 14;
            this.checkBox8.Text = "4";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(664, 230);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "예매";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label7.Location = new System.Drawing.Point(10, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 12);
            this.label7.TabIndex = 20;
            this.label7.Text = "label7";
            // 
            // oracleCommand4
            // 
            this.oracleCommand4.Connection = this.oracleConnection1;
            this.oracleCommand4.Parameters.AddRange(new System.Data.OracleClient.OracleParameter[] {
            new System.Data.OracleClient.OracleParameter("aa", System.Data.OracleClient.OracleType.VarChar),
            new System.Data.OracleClient.OracleParameter("bb", System.Data.OracleClient.OracleType.VarChar),
            new System.Data.OracleClient.OracleParameter("cc", System.Data.OracleClient.OracleType.VarChar)});
            // 
            // dEV_SEAT
            // 
            this.dEV_SEAT.DataSetName = "DEV_SEAT";
            this.dEV_SEAT.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aSEATSBindingSource
            // 
            this.aSEATSBindingSource.DataMember = "A_SEATS";
            this.aSEATSBindingSource.DataSource = this.dEV_SEAT;
            // 
            // a_SEATSTableAdapter
            // 
            this.a_SEATSTableAdapter.ClearBeforeFill = true;
            // 
            // oracleCommand5
            // 
            this.oracleCommand5.Connection = this.oracleConnection1;
            this.oracleCommand5.Parameters.AddRange(new System.Data.OracleClient.OracleParameter[] {
            new System.Data.OracleClient.OracleParameter("ID", System.Data.OracleClient.OracleType.VarChar),
            new System.Data.OracleClient.OracleParameter("DATES", System.Data.OracleClient.OracleType.VarChar),
            new System.Data.OracleClient.OracleParameter("CODE", System.Data.OracleClient.OracleType.VarChar),
            new System.Data.OracleClient.OracleParameter("ROOM", System.Data.OracleClient.OracleType.VarChar),
            new System.Data.OracleClient.OracleParameter("SEAT", System.Data.OracleClient.OracleType.VarChar),
            new System.Data.OracleClient.OracleParameter("GOAL", System.Data.OracleClient.OracleType.VarChar),
            new System.Data.OracleClient.OracleParameter("STARTTIME", System.Data.OracleClient.OracleType.VarChar),
            new System.Data.OracleClient.OracleParameter("ENDTIME", System.Data.OracleClient.OracleType.VarChar),
            new System.Data.OracleClient.OracleParameter("STARTSTATION", System.Data.OracleClient.OracleType.VarChar),
            new System.Data.OracleClient.OracleParameter("ENDSTATION", System.Data.OracleClient.OracleType.VarChar),
            new System.Data.OracleClient.OracleParameter("COST", System.Data.OracleClient.OracleType.VarChar)});
            // 
            // a_STATIONSTableAdapter1
            // 
            this.a_STATIONSTableAdapter1.ClearBeforeFill = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Location = new System.Drawing.Point(12, 290);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(745, 272);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "좌석안내";
            this.groupBox3.Visible = false;
            // 
            // oracleCommand6
            // 
            this.oracleCommand6.Connection = this.oracleConnection1;
            this.oracleCommand6.Parameters.AddRange(new System.Data.OracleClient.OracleParameter[] {
            new System.Data.OracleClient.OracleParameter("aa", System.Data.OracleClient.OracleType.VarChar),
            new System.Data.OracleClient.OracleParameter("bb", System.Data.OracleClient.OracleType.VarChar)});
            // 
            // FormDeserve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(782, 571);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "FormDeserve";
            this.Text = "FormDeserve";
            this.Load += new System.EventHandler(this.FormDeserve_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aSTATIONSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.station)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aSTATIONSBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.station_SEOULROOT1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEV_SEAT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aSEATSBindingSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox3;
        private Station station;
        private System.Windows.Forms.BindingSource aSTATIONSBindingSource;
        private StationTableAdapters.A_STATIONSTableAdapter a_STATIONSTableAdapter;
        private System.Data.OracleClient.OracleConnection oracleConnection1;
        private System.Data.OracleClient.OracleCommand oracleCommand1;
        private System.Data.OracleClient.OracleCommand oracleCommand2;
        private System.Windows.Forms.Label label6;
        private System.Data.OracleClient.OracleCommand oracleCommand3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Data.OracleClient.OracleCommand oracleCommand4;
        private DEV_SEAT dEV_SEAT;
        private System.Windows.Forms.BindingSource aSEATSBindingSource;
        private DEV_SEATTableAdapters.A_SEATSTableAdapter a_SEATSTableAdapter;
        private System.Data.OracleClient.OracleCommand oracleCommand5;
        private Station_SEOULROOT station_SEOULROOT1;
        private System.Windows.Forms.BindingSource aSTATIONSBindingSource1;
        private Station_SEOULROOTTableAdapters.A_STATIONSTableAdapter a_STATIONSTableAdapter1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Data.OracleClient.OracleCommand oracleCommand6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}