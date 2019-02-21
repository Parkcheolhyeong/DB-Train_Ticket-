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
    public partial class FormAdmin : Form
    {
        private DataTable tbl_station;
        private DataTable tbl_route;
        private DataTable tbl_dtrain;
        private int d_cellindex, d_rowindex; // 선택된 경로의 Gridview 위치정보 변수

        public FormAdmin()
        {
            InitializeComponent();
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            // TODO: 이 코드는 데이터를 'admin_Route.A_ROUTES' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.a_ROUTESTableAdapter.Fill(this.admin_Route.A_ROUTES);
            // TODO: 이 코드는 데이터를 'admin_Dtrain.A_DTRAINS' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.a_DTRAINSTableAdapter.Fill(this.admin_Dtrain.A_DTRAINS);
            // TODO: 이 코드는 데이터를 'admin_Dtrain1.A_DTRAINS' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            // TODO: 이 코드는 데이터를 'admin_Train.A_TRAINS' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.a_TRAINSTableAdapter.Fill(this.admin_Train.A_TRAINS);
            // TODO: 이 코드는 데이터를 'admin_Dtrain.A_DTRAINS' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.a_DTRAINSTableAdapter.Fill(this.admin_Dtrain.A_DTRAINS);
            // TODO: 이 코드는 데이터를 'admin_Route.A_ROUTES' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.a_ROUTESTableAdapter.Fill(this.admin_Route.A_ROUTES);
            // TODO: 이 코드는 데이터를 'admin_Station.A_STATIONS' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.a_STATIONSTableAdapter.Fill(this.admin_Station.A_STATIONS);
            oracleConnection1.Open();

        }

        /*
         * Admin_Station관련 Method
         */
        private void btn_sAdd_Click(object sender, EventArgs e)
        {
            DataTable stable;
            stable = admin_Station.Tables["A_STATIONS"];
            DataRow newDataRow = stable.NewRow();

            newDataRow["S_STATION"] = tbx_sName.Text;
            newDataRow["S_STOPTIME"] = tbx_sTime.Text;
            stable.Rows.Add(newDataRow);
        }

        private void btn_sDelete_Click(object sender, EventArgs e)
        {
            aSTATIONSBindingSource.RemoveCurrent();
        }

        private void txb_sUpdate_Click(object sender, EventArgs e)
        {
            a_STATIONSTableAdapter.Update(this.admin_Station.A_STATIONS);
            MessageBox.Show("저장완료");

            this.a_STATIONSTableAdapter.Fill(this.admin_Station.A_STATIONS);
            aSTATIONSBindingSource.ResetBindings(true);
        }


        /*
         * Admin_Routes관련 Method
         */
        private void dataGridView3_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            d_cellindex = e.ColumnIndex; // 클릭된 Cell의 Colum index
            d_rowindex = e.RowIndex; // 클릭된 Row의 Row index
            tbx_sStation.Text = Convert.ToString(dataGridView3.Rows[d_rowindex].Cells[0].Value); // 출발역 값
            tbx_eStation.Text = Convert.ToString(dataGridView3.Rows[d_rowindex].Cells[1].Value); // 도착역 값
        }

        String addRoute;
        private void btn_routeAdd_Click(object sender, EventArgs e)
        {
            if (tbx_interval.Text.Equals("") || tbx_cost.Text.Equals(""))
            {
                MessageBox.Show("운행시간 및 가격을 입력하세요.");
                return;
            }
            String temp_start, temp_end, temp_cost, temp_interval; // route의 Attribute 저장을 위한 변수 선언
            // ROUTE Table & Attribute Load
            tbl_route = admin_Route.Tables["A_ROUTES"];
            temp_start = Convert.ToString(dataGridView3.Rows[d_rowindex].Cells[0].Value);
            temp_end = Convert.ToString(dataGridView3.Rows[d_rowindex].Cells[1].Value);
            temp_interval = Convert.ToString(dataGridView3.Rows[d_rowindex].Cells[2].Value);
            temp_cost = Convert.ToString(dataGridView3.Rows[d_rowindex].Cells[3].Value);

            DataRowView rowView = cmb_mStation.SelectedItem as DataRowView;
            if (rowView != null)
            {
                addRoute = rowView["s_station"].ToString(); // cbx에 선택된 역정보 load
            }

            dataGridView3.Rows.RemoveAt(this.dataGridView3.CurrentCell.RowIndex); //기존 경로 삭제

            // 출발역에서 중간역
            DataRow pastRoute = tbl_route.NewRow();

            pastRoute["S_STATION"] = temp_start;
            pastRoute["S_ENDSTATION"] = addRoute;
            pastRoute["R_INTERVAL"] = temp_interval;
            pastRoute["R_COST"] = temp_cost;
            tbl_route.Rows.Add(pastRoute);

            // 중간역에서 도착역
            DataRow newRoute = tbl_route.NewRow();

            newRoute["S_STATION"] = addRoute;
            newRoute["S_ENDSTATION"] = temp_end;
            newRoute["R_INTERVAL"] = tbx_interval.Text;
            newRoute["R_COST"] = tbx_cost.Text;
            tbl_route.Rows.Add(newRoute);
        }
        class Pet
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }
        String d_startTime, d_code, d_goal;

        private void dataGridView2_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            a_DTRAINSTableAdapter.Update(this.admin_Dtrain.A_DTRAINS);
            MessageBox.Show("저장완료");

            this.a_DTRAINSTableAdapter.Fill(this.admin_Dtrain.A_DTRAINS);
            aDTRAINSBindingSource.ResetBindings(true);

            createSeat(int.Parse(d_code));

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormStatistics form = new FormStatistics();
            form.Show();
        }
        int tmp1, tmp2, result;
        private void button3_Click(object sender, EventArgs e)
        {
            result = int.Parse(tbx_sReTime.Text);
            dataGridView1.Rows[tmp2].Cells[1].Value= result;

            a_STATIONSTableAdapter.Update(this.admin_Station.A_STATIONS);            
        }

        String oldTime;
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            tmp1 = e.ColumnIndex; // 클릭된 Cell의 Colum index
            tmp2 = e.RowIndex; // 클릭된 Row의 Row index
            label15.Text = "역 이름 :";
            label15.Text += Convert.ToString(dataGridView1.Rows[tmp2].Cells[0].Value); // 출발역 값
            oldTime = Convert.ToString(dataGridView1.Rows[tmp2].Cells[1].Value); // 도착역 값
            tbx_sReTime.Text = oldTime;
        }

        private void createSeat(int t_code)
        {
            //2개의 객차 4개의 좌석
            oracleCommand2.CommandText = "INSERT INTO A_SEATS (T_CODE, T_ROOM, T_SEAT, T_STATION, T_BOOL) VALUES (:code, :room, :seat, :station, :bool)";

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    oracleCommand1.CommandText = "SELECT * FROM A_STATIONS ORDER BY DECODE(S_STATION, '부산', 1, '대구', 2, '구미', 3, '대전', 4, '천안', 5, '서울', 6)";
                    OracleDataReader rdr = oracleCommand1.ExecuteReader();

                    while (rdr.Read())
                    {
                        
                        oracleCommand2.Parameters[0].Value = t_code.ToString();
                        oracleCommand2.Parameters[1].Value = (i + 1).ToString() + "호차";
                        oracleCommand2.Parameters[2].Value = (j + 1).ToString();
                        oracleCommand2.Parameters[3].Value = rdr["s_station"].ToString();
                        oracleCommand2.Parameters[4].Value = 0;
                        oracleCommand2.ExecuteNonQuery();
                    }
                }
            }

        }

        private void btn_deserve_Click(object sender, EventArgs e)
        {
            // Dataset lod
            tbl_dtrain = admin_Dtrain.Tables["A_DTRAINS"];
            tbl_station = admin_Station.Tables["A_STATIONS"];

            String temp_interval, temp_stopTime; // cbx으로 부터 저장할 변수선언
            int total_cost = 0;
            d_startTime = Convert.ToString(cbx_startTime.GetItemText(this.cbx_startTime.SelectedItem)); // 선택된 시간 load

            // 선택된 기차번호 Load
            DataRowView rowView = cbx_traincode.SelectedItem as DataRowView;
            if (rowView != null)
            {
                d_code = rowView["T_CODE"].ToString();
            }

            // 선택된 운행방향 Load
            d_goal = Convert.ToString(cbx_trainGoal.GetItemText(this.cbx_trainGoal.SelectedItem));

            if (d_goal.Equals("부산행"))
            {
                oracleCommand1.CommandText = "SELECT * FROM A_ROUTES ORDER BY DECODE(S_STATION, '서울', 1, '천안', 2, '대전', 3, '구미', 4, '대구', 5, '부산', 6)";
                OracleDataReader rdr = oracleCommand1.ExecuteReader();


                this.a_ROUTESTableAdapter.Fill(this.admin_Route.A_ROUTES);
                tbl_route = admin_Route.Tables["A_ROUTES"];

                DataRow[] rows = tbl_route.Select(); // 운행방향 값에대한 ROUTE 값 Load
                TimeSpan ts = TimeSpan.Parse(d_startTime + ":00"); // 출발시각 값 변환
                TimeSpan tmp = TimeSpan.Parse("00:00"), tmp2;
                while (rdr.Read())
                {
                    total_cost += int.Parse(rdr["R_COST"].ToString());

                    String temp_station = rdr["S_STATION"].ToString(); // 부산행의 s_station(ROUTE) 값을 순차적으로 반환
                    
                    String temp_endstation = rdr["S_ENDSTATION"].ToString();
                    String s_query;
                    
                    DataRow newDtrain = tbl_dtrain.NewRow(); // 배차할 경로의 Row를 생성

                    temp_interval = rdr["R_interval"].ToString(); // 기존의 경로에 대한 r_interval 저장
                    s_query = "s_station LIKE '" + temp_endstation + "'";// station의 stopTIme을 불러오기위한 query
                    DataRow[] value = tbl_station.Select(s_query); // 선택된 역에대한 정차시간
              
                    for (int a = 0; a < value.Length; a++)
                    {
                        temp_stopTime = value[a]["s_stopTime"].ToString(); // 정차시간 Load
                        tmp2 = TimeSpan.Parse("00:" + temp_stopTime);// 형변환을 위한 문자열 추가

                        ts += tmp + tmp2; // 출발시간의 지속 갱신을위한 ts값을 저장
                        String temp = ts.ToString();

                        newDtrain["T_CODE"] = d_code;
                        newDtrain["D_GOAL"] = d_goal;
                        newDtrain["D_STARTTIME"] = temp.Substring(0, 5);
                        newDtrain["S_STATION"] = temp_endstation;

                        newDtrain["D_ENDSTATION"] = temp_station;
                        newDtrain["d_totalcost"] = total_cost;
                        tbl_dtrain.Rows.Add(newDtrain);
                    }
                    tmp = TimeSpan.Parse("00:" + temp_interval); // 형변환을 위한 문자열 추가

                }
                total_cost = 0;

            }
            else if (d_goal.Equals("서울행"))
            {
                oracleCommand1.CommandText = "SELECT * FROM A_ROUTES ORDER BY DECODE(S_STATION, '부산', 1, '대구', 2, '구미', 3, '대전', 4, '천안', 5, '서울', 6)";
                OracleDataReader rdr = oracleCommand1.ExecuteReader();

                this.a_ROUTESTableAdapter.Fill(this.admin_Route.A_ROUTES);
                tbl_route = admin_Route.Tables["A_ROUTES"];

                DataRow[] rows = tbl_route.Select(); // 운행방향 값에대한 ROUTE 값 Load
                TimeSpan ts = TimeSpan.Parse(d_startTime + ":00"); // 출발시각 값 변환
                TimeSpan tmp = TimeSpan.Parse("00:00"), tmp2;

                while (rdr.Read())
                {
                    total_cost += int.Parse(rdr["R_COST"].ToString());
                    String temp_station = rdr["S_STATION"].ToString(); // 부산행의 s_station(ROUTE) 값을 순차적으로 반환

                    String temp_endstation = rdr["S_ENDSTATION"].ToString();
                    String s_query;

                    DataRow newDtrain = tbl_dtrain.NewRow(); // 배차할 경로의 Row를 생성

                    temp_interval = rdr["R_interval"].ToString(); // 기존의 경로에 대한 r_interval 저장
                    s_query = "s_station LIKE '" + temp_station + "'";// station의 stopTIme을 불러오기위한 query
                    DataRow[] value = tbl_station.Select(s_query); // 선택된 역에대한 정차시간
                    for (int a = 0; a < value.Length; a++)
                    {
                        temp_stopTime = value[a]["s_stopTime"].ToString(); // 정차시간 Load
                        tmp2 = TimeSpan.Parse("00:" + temp_stopTime);// 형변환을 위한 문자열 추가

                        ts += tmp + tmp2; // 출발시간의 지속 갱신을위한 ts값을 저장
                       

                        String temp = ts.ToString();

                        newDtrain["T_CODE"] = d_code;
                        newDtrain["D_GOAL"] = d_goal;
                        newDtrain["D_STARTTIME"] = temp.Substring(0, 5);
                        newDtrain["S_STATION"] = temp_station;
                        newDtrain["D_ENDSTATION"] = temp_endstation;
                        newDtrain["d_totalcost"] = total_cost;

                        tbl_dtrain.Rows.Add(newDtrain);
                    }
                    tmp = TimeSpan.Parse("00:" + temp_interval); // 형변환을 위한 문자열 추가
                }
                total_cost = 0;

            }


            
        }
   

        private void button1_Click(object sender, EventArgs e)
        {
            a_ROUTESTableAdapter.Update(this.admin_Route.A_ROUTES);
            MessageBox.Show("저장완료");

            this.a_ROUTESTableAdapter.Fill(this.admin_Route.A_ROUTES);
            aROUTESBindingSource.ResetBindings(true);
        }
        

    }
}
