namespace FebroTrain_5293564
{
    partial class FormCustomer
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
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.aROUTESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rOUTE_Busan = new FebroTrain_5293564.ROUTE_Busan();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tCODEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sSTATIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eXPR1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dSTARTTIMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dGOALDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tIMETABLEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.timeTable = new FebroTrain_5293564.TimeTable();
            this.label1 = new System.Windows.Forms.Label();
            this.tIMETABLETableAdapter = new FebroTrain_5293564.TimeTableTableAdapters.TIMETABLETableAdapter();
            this.button3 = new System.Windows.Forms.Button();
            this.a_ROUTESTableAdapter = new FebroTrain_5293564.ROUTE_BusanTableAdapters.A_ROUTESTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.aROUTESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rOUTE_Busan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tIMETABLEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeTable)).BeginInit();
            this.SuspendLayout();
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(498, 18);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(59, 16);
            this.radioButton2.TabIndex = 23;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "부산행";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(433, 18);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(59, 16);
            this.radioButton1.TabIndex = 22;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "서울행";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button2.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button2.Location = new System.Drawing.Point(563, 138);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(69, 32);
            this.button2.TabIndex = 21;
            this.button2.Text = "예약하기";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.DisplayMember = "D_STARTTIME";
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Enabled = false;
            this.comboBox2.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
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
            "21:00",
            "22:00",
            "23:00"});
            this.comboBox2.Location = new System.Drawing.Point(563, 110);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(83, 24);
            this.comboBox2.TabIndex = 19;
            this.comboBox2.ValueMember = "D_STARTTIME";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.aROUTESBindingSource;
            this.comboBox1.DisplayMember = "S_STATION";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Enabled = false;
            this.comboBox1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(563, 62);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(83, 24);
            this.comboBox1.TabIndex = 18;
            this.comboBox1.ValueMember = "S_STATION";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // aROUTESBindingSource
            // 
            this.aROUTESBindingSource.DataMember = "A_ROUTES";
            this.aROUTESBindingSource.DataSource = this.rOUTE_Busan;
            // 
            // rOUTE_Busan
            // 
            this.rOUTE_Busan.DataSetName = "ROUTE_Busan";
            this.rOUTE_Busan.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(563, 90);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(72, 16);
            this.checkBox2.TabIndex = 17;
            this.checkBox2.Text = "출발시각";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(563, 42);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(60, 16);
            this.checkBox1.TabIndex = 16;
            this.checkBox1.Text = "출발역";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tCODEDataGridViewTextBoxColumn,
            this.sSTATIONDataGridViewTextBoxColumn,
            this.eXPR1DataGridViewTextBoxColumn,
            this.dSTARTTIMEDataGridViewTextBoxColumn,
            this.dGOALDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tIMETABLEBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 39);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(545, 326);
            this.dataGridView1.TabIndex = 15;
            // 
            // tCODEDataGridViewTextBoxColumn
            // 
            this.tCODEDataGridViewTextBoxColumn.DataPropertyName = "T_CODE";
            this.tCODEDataGridViewTextBoxColumn.HeaderText = "기차번호";
            this.tCODEDataGridViewTextBoxColumn.Name = "tCODEDataGridViewTextBoxColumn";
            this.tCODEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sSTATIONDataGridViewTextBoxColumn
            // 
            this.sSTATIONDataGridViewTextBoxColumn.DataPropertyName = "S_STATION";
            this.sSTATIONDataGridViewTextBoxColumn.HeaderText = "역이름";
            this.sSTATIONDataGridViewTextBoxColumn.Name = "sSTATIONDataGridViewTextBoxColumn";
            this.sSTATIONDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eXPR1DataGridViewTextBoxColumn
            // 
            this.eXPR1DataGridViewTextBoxColumn.DataPropertyName = "EXPR1";
            this.eXPR1DataGridViewTextBoxColumn.HeaderText = "도착시간";
            this.eXPR1DataGridViewTextBoxColumn.Name = "eXPR1DataGridViewTextBoxColumn";
            this.eXPR1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dSTARTTIMEDataGridViewTextBoxColumn
            // 
            this.dSTARTTIMEDataGridViewTextBoxColumn.DataPropertyName = "D_STARTTIME";
            this.dSTARTTIMEDataGridViewTextBoxColumn.HeaderText = "출발시간";
            this.dSTARTTIMEDataGridViewTextBoxColumn.Name = "dSTARTTIMEDataGridViewTextBoxColumn";
            this.dSTARTTIMEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dGOALDataGridViewTextBoxColumn
            // 
            this.dGOALDataGridViewTextBoxColumn.DataPropertyName = "D_GOAL";
            this.dGOALDataGridViewTextBoxColumn.HeaderText = "운행방향";
            this.dGOALDataGridViewTextBoxColumn.Name = "dGOALDataGridViewTextBoxColumn";
            this.dGOALDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tIMETABLEBindingSource
            // 
            this.tIMETABLEBindingSource.DataMember = "TIMETABLE";
            this.tIMETABLEBindingSource.DataSource = this.timeTable;
            // 
            // timeTable
            // 
            this.timeTable.DataSetName = "TimeTable";
            this.timeTable.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "열차시간표";
            // 
            // tIMETABLETableAdapter
            // 
            this.tIMETABLETableAdapter.ClearBeforeFill = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(563, 324);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(69, 41);
            this.button3.TabIndex = 24;
            this.button3.Text = "예약현황";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // a_ROUTESTableAdapter
            // 
            this.a_ROUTESTableAdapter.ClearBeforeFill = true;
            // 
            // FormCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(656, 378);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "FormCustomer";
            this.Text = "열차조회";
            this.Load += new System.EventHandler(this.FormCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aROUTESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rOUTE_Busan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tIMETABLEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private TimeTable timeTable;
        private System.Windows.Forms.BindingSource tIMETABLEBindingSource;
        private TimeTableTableAdapters.TIMETABLETableAdapter tIMETABLETableAdapter;
        private System.Windows.Forms.Button button3;
        private ROUTE_Busan rOUTE_Busan;
        private System.Windows.Forms.BindingSource aROUTESBindingSource;
        private ROUTE_BusanTableAdapters.A_ROUTESTableAdapter a_ROUTESTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn tCODEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sSTATIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eXPR1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dSTARTTIMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dGOALDataGridViewTextBoxColumn;
    }
}