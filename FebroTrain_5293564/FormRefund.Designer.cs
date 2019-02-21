namespace FebroTrain_5293564
{
    partial class FormRefund
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tCODEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tROOMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tSEATDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dGOALDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dSTARTTIMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dENDTIMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dSTARTSTATIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dENDSTATIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rCOSTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aBOOKINGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cUSTOM_BOOKING = new FebroTrain_5293564.CUSTOM_BOOKING();
            this.a_BOOKINGTableAdapter = new FebroTrain_5293564.CUSTOM_BOOKINGTableAdapters.A_BOOKINGTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.oracleConnection1 = new System.Data.OracleClient.OracleConnection();
            this.oracleCommand1 = new System.Data.OracleClient.OracleCommand();
            this.oracleCommand2 = new System.Data.OracleClient.OracleCommand();
            this.oracleCommand3 = new System.Data.OracleClient.OracleCommand();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBOOKINGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOM_BOOKING)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cIDDataGridViewTextBoxColumn,
            this.bDATEDataGridViewTextBoxColumn,
            this.tCODEDataGridViewTextBoxColumn,
            this.tROOMDataGridViewTextBoxColumn,
            this.tSEATDataGridViewTextBoxColumn,
            this.dGOALDataGridViewTextBoxColumn,
            this.dSTARTTIMEDataGridViewTextBoxColumn,
            this.dENDTIMEDataGridViewTextBoxColumn,
            this.dSTARTSTATIONDataGridViewTextBoxColumn,
            this.dENDSTATIONDataGridViewTextBoxColumn,
            this.rCOSTDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.aBOOKINGBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1097, 348);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // cIDDataGridViewTextBoxColumn
            // 
            this.cIDDataGridViewTextBoxColumn.DataPropertyName = "C_ID";
            this.cIDDataGridViewTextBoxColumn.HeaderText = "C_ID";
            this.cIDDataGridViewTextBoxColumn.Name = "cIDDataGridViewTextBoxColumn";
            this.cIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.cIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // bDATEDataGridViewTextBoxColumn
            // 
            this.bDATEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.bDATEDataGridViewTextBoxColumn.DataPropertyName = "B_DATE";
            dataGridViewCellStyle3.Format = "g";
            dataGridViewCellStyle3.NullValue = null;
            this.bDATEDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.bDATEDataGridViewTextBoxColumn.HeaderText = "날짜";
            this.bDATEDataGridViewTextBoxColumn.Name = "bDATEDataGridViewTextBoxColumn";
            this.bDATEDataGridViewTextBoxColumn.ReadOnly = true;
            this.bDATEDataGridViewTextBoxColumn.Width = 54;
            // 
            // tCODEDataGridViewTextBoxColumn
            // 
            this.tCODEDataGridViewTextBoxColumn.DataPropertyName = "T_CODE";
            this.tCODEDataGridViewTextBoxColumn.HeaderText = "기차번호";
            this.tCODEDataGridViewTextBoxColumn.Name = "tCODEDataGridViewTextBoxColumn";
            this.tCODEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tROOMDataGridViewTextBoxColumn
            // 
            this.tROOMDataGridViewTextBoxColumn.DataPropertyName = "T_ROOM";
            this.tROOMDataGridViewTextBoxColumn.HeaderText = "호실";
            this.tROOMDataGridViewTextBoxColumn.Name = "tROOMDataGridViewTextBoxColumn";
            this.tROOMDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tSEATDataGridViewTextBoxColumn
            // 
            this.tSEATDataGridViewTextBoxColumn.DataPropertyName = "T_SEAT";
            this.tSEATDataGridViewTextBoxColumn.HeaderText = "좌석번호";
            this.tSEATDataGridViewTextBoxColumn.Name = "tSEATDataGridViewTextBoxColumn";
            this.tSEATDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dGOALDataGridViewTextBoxColumn
            // 
            this.dGOALDataGridViewTextBoxColumn.DataPropertyName = "D_GOAL";
            this.dGOALDataGridViewTextBoxColumn.HeaderText = "운행방향";
            this.dGOALDataGridViewTextBoxColumn.Name = "dGOALDataGridViewTextBoxColumn";
            this.dGOALDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dSTARTTIMEDataGridViewTextBoxColumn
            // 
            this.dSTARTTIMEDataGridViewTextBoxColumn.DataPropertyName = "D_STARTTIME";
            this.dSTARTTIMEDataGridViewTextBoxColumn.HeaderText = "출발시간";
            this.dSTARTTIMEDataGridViewTextBoxColumn.Name = "dSTARTTIMEDataGridViewTextBoxColumn";
            this.dSTARTTIMEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dENDTIMEDataGridViewTextBoxColumn
            // 
            this.dENDTIMEDataGridViewTextBoxColumn.DataPropertyName = "D_ENDTIME";
            this.dENDTIMEDataGridViewTextBoxColumn.HeaderText = "도착시간";
            this.dENDTIMEDataGridViewTextBoxColumn.Name = "dENDTIMEDataGridViewTextBoxColumn";
            this.dENDTIMEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dSTARTSTATIONDataGridViewTextBoxColumn
            // 
            this.dSTARTSTATIONDataGridViewTextBoxColumn.DataPropertyName = "D_STARTSTATION";
            this.dSTARTSTATIONDataGridViewTextBoxColumn.HeaderText = "출발역";
            this.dSTARTSTATIONDataGridViewTextBoxColumn.Name = "dSTARTSTATIONDataGridViewTextBoxColumn";
            this.dSTARTSTATIONDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dENDSTATIONDataGridViewTextBoxColumn
            // 
            this.dENDSTATIONDataGridViewTextBoxColumn.DataPropertyName = "D_ENDSTATION";
            this.dENDSTATIONDataGridViewTextBoxColumn.HeaderText = "도착역";
            this.dENDSTATIONDataGridViewTextBoxColumn.Name = "dENDSTATIONDataGridViewTextBoxColumn";
            this.dENDSTATIONDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rCOSTDataGridViewTextBoxColumn
            // 
            this.rCOSTDataGridViewTextBoxColumn.DataPropertyName = "R_COST";
            this.rCOSTDataGridViewTextBoxColumn.HeaderText = "운행비용";
            this.rCOSTDataGridViewTextBoxColumn.Name = "rCOSTDataGridViewTextBoxColumn";
            this.rCOSTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aBOOKINGBindingSource
            // 
            this.aBOOKINGBindingSource.DataMember = "A_BOOKING";
            this.aBOOKINGBindingSource.DataSource = this.cUSTOM_BOOKING;
            // 
            // cUSTOM_BOOKING
            // 
            this.cUSTOM_BOOKING.DataSetName = "CUSTOM_BOOKING";
            this.cUSTOM_BOOKING.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // a_BOOKINGTableAdapter
            // 
            this.a_BOOKINGTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1120, 397);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "예약취소";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // oracleConnection1
            // 
            this.oracleConnection1.ConnectionString = "Data Source=Febro2;User ID=A5293564;Password=computer12;Unicode=True";
            // 
            // oracleCommand1
            // 
            this.oracleCommand1.Connection = this.oracleConnection1;
            this.oracleCommand1.Parameters.AddRange(new System.Data.OracleClient.OracleParameter[] {
            new System.Data.OracleClient.OracleParameter("id", System.Data.OracleClient.OracleType.VarChar),
            new System.Data.OracleClient.OracleParameter("dates", System.Data.OracleClient.OracleType.VarChar),
            new System.Data.OracleClient.OracleParameter("code", System.Data.OracleClient.OracleType.VarChar),
            new System.Data.OracleClient.OracleParameter("room", System.Data.OracleClient.OracleType.VarChar),
            new System.Data.OracleClient.OracleParameter("seat", System.Data.OracleClient.OracleType.VarChar),
            new System.Data.OracleClient.OracleParameter("goal", System.Data.OracleClient.OracleType.VarChar),
            new System.Data.OracleClient.OracleParameter("starttime", System.Data.OracleClient.OracleType.VarChar),
            new System.Data.OracleClient.OracleParameter("endtime", System.Data.OracleClient.OracleType.VarChar),
            new System.Data.OracleClient.OracleParameter("startstation", System.Data.OracleClient.OracleType.VarChar),
            new System.Data.OracleClient.OracleParameter("endstation", System.Data.OracleClient.OracleType.VarChar)});
            // 
            // oracleCommand2
            // 
            this.oracleCommand2.Connection = this.oracleConnection1;
            this.oracleCommand2.Parameters.AddRange(new System.Data.OracleClient.OracleParameter[] {
            new System.Data.OracleClient.OracleParameter("aa", System.Data.OracleClient.OracleType.VarChar),
            new System.Data.OracleClient.OracleParameter("bb", System.Data.OracleClient.OracleType.VarChar),
            new System.Data.OracleClient.OracleParameter("cc", System.Data.OracleClient.OracleType.VarChar),
            new System.Data.OracleClient.OracleParameter("dd", System.Data.OracleClient.OracleType.VarChar),
            new System.Data.OracleClient.OracleParameter("ee", System.Data.OracleClient.OracleType.VarChar)});
            // 
            // oracleCommand3
            // 
            this.oracleCommand3.Connection = this.oracleConnection1;
            this.oracleCommand3.Parameters.AddRange(new System.Data.OracleClient.OracleParameter[] {
            new System.Data.OracleClient.OracleParameter("dates", System.Data.OracleClient.OracleType.VarChar),
            new System.Data.OracleClient.OracleParameter("room", System.Data.OracleClient.OracleType.VarChar),
            new System.Data.OracleClient.OracleParameter("seat", System.Data.OracleClient.OracleType.VarChar)});
            // 
            // FormRefund
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1220, 434);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormRefund";
            this.Text = "예약현황";
            this.Load += new System.EventHandler(this.FormRefund_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBOOKINGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOM_BOOKING)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private CUSTOM_BOOKING cUSTOM_BOOKING;
        private System.Windows.Forms.BindingSource aBOOKINGBindingSource;
        private CUSTOM_BOOKINGTableAdapters.A_BOOKINGTableAdapter a_BOOKINGTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tCODEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tROOMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tSEATDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dGOALDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dSTARTTIMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dENDTIMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dSTARTSTATIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dENDSTATIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rCOSTDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button2;
        private System.Data.OracleClient.OracleConnection oracleConnection1;
        private System.Data.OracleClient.OracleCommand oracleCommand1;
        private System.Data.OracleClient.OracleCommand oracleCommand2;
        private System.Data.OracleClient.OracleCommand oracleCommand3;
    }
}