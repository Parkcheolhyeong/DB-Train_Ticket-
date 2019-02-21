using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OracleClient;

namespace FebroTrain_5293564
{
    public partial class FormDeserve : Form
    {
        String str_year;
        String str_month;
        String str_day;

        String d_time;
        String d_goal;
        String d_start;
        String d_end;
        String trainCode;
        bool[,] seats = new bool[2, 5];

        public FormDeserve()
        {
            InitializeComponent();

        }

        private void FormDeserve_Load(object sender, EventArgs e)
        {
            // TODO: 이 코드는 데이터를 'station_SEOULROOT1.A_STATIONS' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.a_STATIONSTableAdapter1.Fill(this.station_SEOULROOT1.A_STATIONS);
            // TODO: 이 코드는 데이터를 'station1.A_STATIONS' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            // TODO: 이 코드는 데이터를 'station_SEOULROOT.A_STATIONS' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            // TODO: 이 코드는 데이터를 'dEV_SEAT.A_SEATS' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.a_SEATSTableAdapter.Fill(this.dEV_SEAT.A_SEATS);
            oracleConnection1.Open();
            // TODO: 이 코드는 데이터를 'station.A_STATIONS' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.a_STATIONSTableAdapter.Fill(this.station.A_STATIONS);
            // TODO: 이 코드는 데이터를 'station.A_STATIONS' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.a_STATIONSTableAdapter.Fill(this.station.A_STATIONS);
            // TODO: 이 코드는 데이터를 'deserveStationTable.DESERVESTATIONTABLE' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            // TODO: 이 코드는 데이터를 'deserveTable.DESERVETABLE' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            str_year = DateTime.Now.ToString("yyyy").ToString();
            str_month = DateTime.Now.ToString("MM").ToString();
            str_day = DateTime.Now.ToString("dd").ToString();
            label1.Text = label6.Text = str_year + "년" + str_month + "월" + str_day + "일";

            //DEV_SEATTableAdapters.A_SEATSTableAdapter seatTableAdapter1 = new DEV_SEATTableAdapters.A_SEATSTableAdapter();


            this.a_STATIONSTableAdapter.FillBySEOUL(this.station.A_STATIONS);
            aSTATIONSBindingSource.ResetBindings(true);

            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 5; j++)
                    seats[i, j] = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            d_time = Convert.ToString(comboBox1.GetItemText(this.comboBox1.SelectedItem));
            d_goal = Convert.ToString(comboBox4.GetItemText(this.comboBox4.SelectedItem));


            DataRowView rowView1 = comboBox2.SelectedItem as DataRowView;
            if (rowView1 != null)
            {
                d_start = rowView1["s_station"].ToString();
            }
            DataRowView rowView2 = comboBox3.SelectedItem as DataRowView;
            if (rowView2 != null)
            {
                d_end = rowView2["s_station"].ToString();
            }
            if (d_goal.Equals("부산행"))
            {
                if (d_start.Equals("서울"))
                {
                    oracleCommand1.CommandText = "SELECT dtrain1.t_code 기차번호, dtrain1.d_goal 운행방향, to_char(to_date(dtrain1.D_STARTTIME, 'HH24:MI') + to_number(route.R_INTERVAL) / (24 * 60), 'hh24:mi') 도착시간, dtrain1.d_startTime 출발시간, '서울' 출발역, dtrain1.d_endstation 도착역, dtrain1.d_totalcost 운행비용" +
                    " FROM A_DTRAINS dtrain1, A_ROUTEs route" +
                    " WHERE dtrain1.d_goal LIKE '부산행' AND to_date(dtrain1.D_STARTTIME, 'HH24:MI') >= to_date(:bb, 'HH24:MI') AND dtrain1.d_endstation LIKE route.S_STATION AND dtrain1.d_endstation LIKE :aa"+
                    " ORDER BY dtrain1.D_STARTTIME";

                    oracleCommand1.Parameters[0].Value = d_end;
                    oracleCommand1.Parameters[1].Value = d_time;

                    OracleDataReader rdr = oracleCommand1.ExecuteReader();

                    DataTable dt = new DataTable();
                    dt.Load(rdr);
                    dataGridView1.DataSource = dt;
                }
                else
                {

                    oracleCommand2.CommandText = "SELECT dtrain1.t_code 기차번호, dtrain1.d_goal 운행방향, to_char(to_date(dtrain1.D_STARTTIME, 'HH24:MI') + to_number(route.R_INTERVAL) / (24 * 60), 'hh24:mi') 도착시간, dtrain1.d_startTime 출발시간, dtrain1.d_endstation 출발역, dtrain2.d_endstation 도착역, dtrain2.d_totalcost - dtrain1.d_totalcost 운행비용" +
                    " FROM A_DTRAINS dtrain1, A_DTRAINS dtrain2, A_ROUTES route" +
                    " WHERE dtrain1.D_GOAL LIKE '부산행' AND to_date(dtrain1.D_STARTTIME, 'HH24:MI') >= to_date(:cc, 'HH24:MI') AND dtrain1.t_code = dtrain2.t_code AND dtrain1.d_goal LIKE dtrain2.d_goal AND dtrain1.d_endstation LIKE route.S_STATION AND dtrain2.d_totalcost - dtrain1.d_totalcost > 0 AND dtrain1.d_endstation LIKE :aa AND dtrain2.d_endstation LIKE :bb"+
                    " ORDER BY dtrain1.D_STARTTIME";

                    oracleCommand2.Parameters[0].Value = d_start;
                    oracleCommand2.Parameters[1].Value = d_end;
                    oracleCommand2.Parameters[2].Value = d_time;

                    OracleDataReader rdr = oracleCommand2.ExecuteReader();

                    DataTable dt = new DataTable();
                    dt.Load(rdr);
                    dataGridView1.DataSource = dt;
                }
            }
            else if (d_goal.Equals("서울행"))
            {
                if (d_start.Equals("부산"))
                {
                    oracleCommand1.CommandText = "SELECT dtrain1.t_code 기차번호, dtrain1.d_goal 운행방향, to_char(to_date(dtrain1.D_STARTTIME, 'HH24:MI') + to_number(route.R_INTERVAL) / (24 * 60), 'hh24:mi') 도착시간, dtrain1.d_startTime 출발시간, '서울' 출발역, dtrain1.d_endstation 도착역, dtrain1.d_totalcost 운행비용" +
                    " FROM A_DTRAINS dtrain1, A_ROUTEs route" +
                    " WHERE dtrain1.d_goal LIKE '서울행' AND to_date(dtrain1.D_STARTTIME, 'HH24:MI') >= to_date(:bb, 'HH24:MI') AND dtrain1.d_endstation LIKE route.S_STATION AND dtrain1.d_endstation LIKE :aa" +
                    " ORDER BY dtrain1.D_STARTTIME";

                    oracleCommand1.Parameters[0].Value = d_end;
                    oracleCommand1.Parameters[1].Value = d_time;

                    OracleDataReader rdr = oracleCommand1.ExecuteReader();

                    DataTable dt = new DataTable();
                    dt.Load(rdr);
                    dataGridView1.DataSource = dt;
                }
                else
                {

                    oracleCommand2.CommandText = "SELECT dtrain1.t_code 기차번호, dtrain1.d_goal 운행방향, to_char(to_date(dtrain1.D_STARTTIME, 'HH24:MI') + to_number(route.R_INTERVAL) / (24 * 60), 'hh24:mi') 도착시간, dtrain1.d_startTime 출발시간, dtrain1.d_endstation 출발역, dtrain2.d_endstation 도착역, dtrain2.d_totalcost - dtrain1.d_totalcost 운행비용" +
                    " FROM A_DTRAINS dtrain1, A_DTRAINS dtrain2, A_ROUTES route" +
                    " WHERE dtrain1.D_GOAL LIKE '서울행' AND to_date(dtrain1.D_STARTTIME, 'HH24:MI') >= to_date(:cc, 'HH24:MI') AND dtrain1.t_code = dtrain2.t_code AND dtrain1.d_goal LIKE dtrain2.d_goal AND dtrain1.d_endstation LIKE route.S_STATION AND dtrain2.d_totalcost - dtrain1.d_totalcost > 0 AND dtrain1.d_endstation LIKE :aa AND dtrain2.d_endstation LIKE :bb" +
                    " ORDER BY dtrain1.D_STARTTIME";


                    oracleCommand2.Parameters[0].Value = d_start;
                    oracleCommand2.Parameters[1].Value = d_end;
                    oracleCommand2.Parameters[2].Value = d_time;

                    OracleDataReader rdr = oracleCommand2.ExecuteReader();

                    DataTable dt = new DataTable();
                    dt.Load(rdr);
                    dataGridView1.DataSource = dt;
                }
            }
        }
        int d_cellindex, d_rowindex;

        private void checkSeat()
        {

            if (checkBox1.Enabled == true)
            {
                if (checkBox1.Checked == true)
                {
                    seats[0, 0] = true;
                }

            }
            if (checkBox2.Enabled == true)
            {
                if (checkBox2.Checked == true)
                {
                    seats[0, 1] = true;
                }
            }
            if (checkBox3.Enabled == true)
            {
                if (checkBox3.Checked == true)
                {
                    seats[0, 2] = true;
                }
            }

            if (checkBox4.Enabled == true)
            {
                if (checkBox4.Checked == true)
                {
                    seats[0, 3] = true;
                }
            }
            if (checkBox5.Enabled == true)
            {
                if (checkBox5.Checked == true)
                {
                    seats[1, 0] = true;

                }
            }
            if (checkBox6.Enabled == true)
            {
                if (checkBox6.Checked == true)
                {
                    seats[1, 1] = true;

                }
            }
            if (checkBox7.Enabled == true)
            {
                if (checkBox7.Checked == true)
                {
                    seats[1, 2] = true;

                }
            }
            if (checkBox8.Enabled == true)
            {
                if (checkBox8.Checked == true)
                {
                    seats[1, 3] = true;
                }
            }
        }
        String value;
        String Cost;
        private void filterSeat()
        {
            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 4; j++)
                {
                    if (seats[i, j] == true)
                    {
                        value += (i + 1) + "호차(" + (j + 1) + ") ";
                    }
                }

        }
        String tempvalue1;
        String tempvalue2;
        bool check = false;
        private void button2_Click(object sender, EventArgs e)
        {
            checkSeat();
            filterSeat();
            DialogResult result = MessageBox.Show("출발일시: " + d_time +
                            "\n출발역, 도착역: " + d_start + " - " + d_end + "(" + d_goal + ")" +
                            "\n열차번호: " + trainCode +
                            "\n선택좌석: " + value +
                            "\n요금: " + Cost, "동의", MessageBoxButtons.YesNoCancel);

            if (result == DialogResult.Yes)
            {
                char sp = ' ';
                string[] spstring = value.Split(sp);

                for (int i = 0; i < spstring.Length; i++)
                {
                    if (spstring[i].Equals("")) continue;

                    tempvalue1 = spstring[i].Substring(0, 3);
                    tempvalue2 = spstring[i].Substring(4, 1);
                    //MessageBox.Show(tempvalue1 + "|" + tempvalue2);

                    oracleCommand4.CommandText = "SELECT * FROM A_STATIONS ORDER BY DECODE(S_STATION, '서울', 1, '천안', 2, '대전', 3, '구미', 4, '대구', 5, '부산', 6)";
                    OracleDataReader rdr = oracleCommand4.ExecuteReader();
                    while (rdr.Read())
                    {
                        if (rdr[0].ToString().Equals(d_start))
                            check = true;
                        if (check == true)
                        {
                            String x = rdr[0].ToString();
                            if (x.ToString().Equals(d_end))
                            {
                                check = false;

                                continue;
                            }
                            else
                            {
                                oracleCommand3.CommandText = "UPDATE A_SEATS SET T_BOOL = :ee WHERE T_CODE = :aa AND T_ROOM LIKE :bb AND T_SEAT LIKE :cc AND T_STATION LIKE :dd";
                                oracleCommand3.Parameters[0].Value = trainCode;
                                oracleCommand3.Parameters[1].Value = tempvalue1;
                                oracleCommand3.Parameters[2].Value = tempvalue2;
                                oracleCommand3.Parameters[3].Value = x;
                                oracleCommand3.Parameters[4].Value = 1.ToString();

                                int number = oracleCommand3.ExecuteNonQuery();
                            }
                        }

                    }

                        oracleCommand5.CommandText = "INSERT INTO A_BOOKING (C_ID, B_DATE, T_CODE, T_ROOM, T_SEAT, D_GOAL, D_STARTTIME, D_ENDTIME, D_STARTSTATION, D_ENDSTATION, R_COST)"
                                + " VALUES (:ID, :DATES, :CODE, :ROOM, :SEAT, :GOAL, :STARTTIME, :ENDTIME, :STARTSTATION, :ENDSTATION, :COST)";
                        oracleCommand5.Parameters["ID"].Value = int.Parse(FormLogin.C_ID);
                        oracleCommand5.Parameters["DATES"].Value = DateTime.Now;
                        oracleCommand5.Parameters["CODE"].Value = trainCode;
                        oracleCommand5.Parameters["ROOM"].Value = tempvalue1;
                        oracleCommand5.Parameters["SEAT"].Value = tempvalue2;
                        oracleCommand5.Parameters["GOAL"].Value = Convert.ToString(dataGridView1.Rows[d_rowindex].Cells["운행방향"].Value);
                        oracleCommand5.Parameters["STARTTIME"].Value = Convert.ToString(dataGridView1.Rows[d_rowindex].Cells["출발시간"].Value);
                        oracleCommand5.Parameters["ENDTIME"].Value = Convert.ToString(dataGridView1.Rows[d_rowindex].Cells["도착시간"].Value);
                        oracleCommand5.Parameters["STARTSTATION"].Value = Convert.ToString(dataGridView1.Rows[d_rowindex].Cells["출발역"].Value);
                        oracleCommand5.Parameters["ENDSTATION"].Value = Convert.ToString(dataGridView1.Rows[d_rowindex].Cells["도착역"].Value);
                        oracleCommand5.Parameters["COST"].Value = Convert.ToString(dataGridView1.Rows[d_rowindex].Cells["운행비용"].Value);

                        oracleCommand5.ExecuteNonQuery();

                    value = "";
                    chekcFalse();

                }

                
            }
            else if (result == DialogResult.No)
            {
                value = "";
                chekcFalse();
            }
            else
            {
                value = "";
                chekcFalse();
            }
            value = "";
            chekcFalse();
            groupBox3.Visible = false;
        }

        bool[] checkgroup = new bool[16];

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            String tmp_goal = Convert.ToString(comboBox4.GetItemText(this.comboBox4.SelectedItem));
            if (tmp_goal.Equals("부산행"))
            {
                this.a_STATIONSTableAdapter.Fill(this.station.A_STATIONS);
                aSTATIONSBindingSource.ResetBindings(true);
                this.a_STATIONSTableAdapter1.FillByBusan(this.station_SEOULROOT1.A_STATIONS);
                aSTATIONSBindingSource1.ResetBindings(true);


            }
            else if(tmp_goal.Equals("서울행"))
                {
                this.a_STATIONSTableAdapter.FillBySEOUL(this.station.A_STATIONS);
                aSTATIONSBindingSource.ResetBindings(true);
                this.a_STATIONSTableAdapter1.Fill(this.station_SEOULROOT1.A_STATIONS);
                aSTATIONSBindingSource1.ResetBindings(true);

            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            groupBox3.Visible = false;
            chekcFalse();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            groupBox3.Visible = false;
            chekcFalse();
        }

        private void chekcFalse()
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;
        }
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            groupBox3.Visible = true;
            check = false;
            for (int i = 0; i < 16; i++)
                checkgroup[i] = false;
            String tmp1;
            d_cellindex = e.ColumnIndex; // 클릭된 Cell의 Colum index
            d_rowindex = e.RowIndex; // 클릭된 Row의 Row index

            tmp1 = Convert.ToString(dataGridView1.Rows[d_rowindex].Cells[0].Value); // 출발역 값
            Cost = Convert.ToString(dataGridView1.Rows[d_rowindex].Cells[6].Value);
            label7.Text = trainCode = tmp1;
            label7.Text += "호차";

            //oracleCommand2
            if (d_goal.Equals("부산행"))
            { oracleCommand4.CommandText = "SELECT * FROM A_STATIONS ORDER BY DECODE(S_STATION, '서울', 1, '천안', 2, '대전', 3, '구미', 4, '대구', 5, '부산', 6)";
                OracleDataReader rdr = oracleCommand4.ExecuteReader();
                while (rdr.Read())
                {
                    if (rdr[0].ToString().Equals(d_start))
                    {
                        check = true;

                        for (int i = 0; i < 16; i++)
                            checkgroup[i] = true;
                    }
                    if (check == true)
                    {
                        String x = rdr["S_STATION"].ToString();
                        oracleCommand6.CommandText = "SELECT * FROM A_SEATS WHERE t_code = :aa AND t_station LIKE :bb";
                        oracleCommand6.Parameters[0].Value = tmp1.ToString();
                        oracleCommand6.Parameters[1].Value = x.ToString();
                        OracleDataReader rdr2 = oracleCommand6.ExecuteReader();
                        while (rdr2.Read())
                        {
                            String room = rdr2["T_ROOM"].ToString();
                            if (room.Equals("1호차"))
                            {
                                //MessageBox.Show(rdr["t_room"].ToString() + rdr["t_seat"].ToString()+"좌석상태: " + rdr["T_BOOL"].ToString());
                                int seat = int.Parse(rdr2["T_SEAT"].ToString());
                                if (rdr2["T_BOOL"].ToString().Equals("1"))
                                {
                                    switch (seat)
                                    {
                                        case 1:
                                            if (checkgroup[0] == true)
                                            {
                                                checkBox1.Enabled = checkgroup[0] = false;
                                            }
                                            break;
                                        case 2:
                                            if (checkgroup[1] == true)
                                            {
                                                checkBox2.Enabled = checkgroup[1] = false;
                                            }
                                            break;
                                        case 3:
                                            if (checkgroup[2] == true)
                                            {
                                                checkBox3.Enabled = checkgroup[2] = false;
                                            }
                                            break;
                                        case 4:
                                            if (checkgroup[3] == true)
                                            {
                                                checkBox4.Enabled = checkgroup[3] = false;
                                            }
                                            break;
                                    }
                                }
                                else
                                {
                                    switch (seat)
                                    {
                                        case 1:
                                            if (checkgroup[0] == true)
                                            {
                                                checkBox1.Enabled = true;
                                            }
                                            break;
                                        case 2:
                                            if (checkgroup[1] == true)
                                            {
                                                checkBox2.Enabled = true;
                                            }
                                            break;
                                        case 3:
                                            if (checkgroup[2] == true)
                                            {
                                                checkBox3.Enabled = true;
                                            }
                                            break;
                                        case 4:
                                            if (checkgroup[3] == true)
                                            {
                                                checkBox4.Enabled = true;
                                            }
                                            break;
                                    }
                                }

                            }

                            else if (room.Equals("2호차"))
                            {
                                //MessageBox.Show(rdr["t_room"].ToString() + rdr["t_seat"].ToString()+"좌석상태: " + rdr["T_BOOL"].ToString());
                                int seat = int.Parse(rdr2["T_SEAT"].ToString());
                                if (rdr2["T_BOOL"].ToString().Equals("1"))
                                {
                                    switch (seat)
                                    {
                                        case 1:
                                            if (checkgroup[4] == true)
                                            {
                                                checkBox5.Enabled = checkgroup[4] = false;
                                            }
                                            break;
                                        case 2:
                                            if (checkgroup[5] == true)
                                            {
                                                checkBox6.Enabled = checkgroup[5] = false;
                                            }
                                            break;
                                        case 3:
                                            if (checkgroup[6] == true)
                                            {
                                                checkBox7.Enabled = checkgroup[6] = false;
                                            }
                                            break;
                                        case 4:
                                            if (checkgroup[7] == true)
                                            {
                                                checkBox8.Enabled = checkgroup[7] = false;
                                            }
                                            break;
                                    }
                                }
                                else
                                {
                                    switch (seat)
                                    {
                                        case 1:
                                            if (checkgroup[4] == true)
                                            {
                                                checkBox5.Enabled = true;
                                            }
                                            break;
                                        case 2:
                                            if (checkgroup[5] == true)
                                            {
                                                checkBox6.Enabled = true;
                                            }
                                            break;
                                        case 3:
                                            if (checkgroup[6] == true)
                                            {
                                                checkBox7.Enabled = true;
                                            }
                                            break;
                                        case 4:
                                            if (checkgroup[7] == true)
                                            {
                                                checkBox8.Enabled = true;
                                            }
                                            break;
                                    }
                                }

                            }
                        }

                        if (x.ToString().Equals(d_end))
                        {
                            check = false;
                            for (int i = 0; i < 16; i++)
                                checkgroup[i] = true;
                        }
                    }
                }

            } else if (d_goal.Equals("서울행"))
            {
                check = false;
                oracleCommand4.CommandText = "SELECT * FROM A_STATIONS ORDER BY DECODE(S_STATION, '부산', 1, '대구', 2, '구미', 3, '대전', 4, '천안', 5, '서울', 6)";
                OracleDataReader rdr = oracleCommand4.ExecuteReader();
                while (rdr.Read())
                {
                    if (rdr[0].ToString().Equals(d_start))
                    {

                        check = true;

                        for (int i = 0; i < 16; i++)
                            checkgroup[i] = true;
                    }
                    if (check == true)
                    {

                        String x = rdr["S_STATION"].ToString();
                        oracleCommand6.CommandText = "SELECT * FROM A_SEATS WHERE t_code = :aa AND t_station LIKE :bb";
                        oracleCommand6.Parameters[0].Value = tmp1.ToString();
                        oracleCommand6.Parameters[1].Value = x.ToString();
                        OracleDataReader rdr2 = oracleCommand6.ExecuteReader();
                        while (rdr2.Read())
                        {
                            String room = rdr2["T_ROOM"].ToString();
                            if (room.Equals("1호차"))
                            {
                                //MessageBox.Show(rdr["t_room"].ToString() + rdr["t_seat"].ToString()+"좌석상태: " + rdr["T_BOOL"].ToString());
                                int seat = int.Parse(rdr2["T_SEAT"].ToString());
                                if (rdr2["T_BOOL"].ToString().Equals("1"))
                                {
                                    switch (seat)
                                    {
                                        case 1:
                                            if (checkgroup[0] == true)
                                            {
                                                checkBox1.Enabled = checkgroup[0] = false;
                                            }
                                            break;
                                        case 2:
                                            if (checkgroup[1] == true)
                                            {
                                                checkBox2.Enabled = checkgroup[1] = false;
                                            }
                                            break;
                                        case 3:
                                            if (checkgroup[2] == true)
                                            {
                                                checkBox3.Enabled = checkgroup[2] = false;
                                            }
                                            break;
                                        case 4:
                                            if (checkgroup[3] == true)
                                            {
                                                checkBox4.Enabled = checkgroup[3] = false;
                                            }
                                            break;
                                    }
                                }
                                else
                                {
                                    switch (seat)
                                    {
                                        case 1:
                                            if (checkgroup[0] == true)
                                            {
                                                checkBox1.Enabled = true;
                                            }
                                            break;
                                        case 2:
                                            if (checkgroup[1] == true)
                                            {
                                                checkBox2.Enabled = true;
                                            }
                                            break;
                                        case 3:
                                            if (checkgroup[2] == true)
                                            {
                                                checkBox3.Enabled = true;
                                            }
                                            break;
                                        case 4:
                                            if (checkgroup[3] == true)
                                            {
                                                checkBox4.Enabled = true;
                                            }
                                            break;
                                    }
                                }

                            }

                            else if (room.Equals("2호차"))
                            {
                                //MessageBox.Show(rdr["t_room"].ToString() + rdr["t_seat"].ToString()+"좌석상태: " + rdr["T_BOOL"].ToString());
                                int seat = int.Parse(rdr2["T_SEAT"].ToString());
                                if (rdr2["T_BOOL"].ToString().Equals("1"))
                                {
                                    switch (seat)
                                    {
                                        case 1:
                                            if (checkgroup[4] == true)
                                            {
                                                checkBox5.Enabled = checkgroup[4] = false;
                                            }
                                            break;
                                        case 2:
                                            if (checkgroup[5] == true)
                                            {
                                                checkBox6.Enabled = checkgroup[5] = false;
                                            }
                                            break;
                                        case 3:
                                            if (checkgroup[6] == true)
                                            {
                                                checkBox7.Enabled = checkgroup[6] = false;
                                            }
                                            break;
                                        case 4:
                                            if (checkgroup[7] == true)
                                            {
                                                checkBox8.Enabled = checkgroup[7] = false;
                                            }
                                            break;
                                    }
                                }
                                else
                                {
                                    switch (seat)
                                    {
                                        case 1:
                                            if (checkgroup[4] == true)
                                            {
                                                checkBox5.Enabled = true;
                                            }
                                            break;
                                        case 2:
                                            if (checkgroup[5] == true)
                                            {
                                                checkBox6.Enabled = true;
                                            }
                                            break;
                                        case 3:
                                            if (checkgroup[6] == true)
                                            {
                                                checkBox7.Enabled = true;
                                            }
                                            break;
                                        case 4:
                                            if (checkgroup[7] == true)
                                            {
                                                checkBox8.Enabled = true;
                                            }
                                            break;
                                    }
                                }

                            }
                        }

                        if (x.ToString().Equals(d_end))
                        {
                            check = false;
                            for (int i = 0; i < 16; i++)
                                checkgroup[i] = true;
                        }
                    }
                }

            }
        }
    }
}