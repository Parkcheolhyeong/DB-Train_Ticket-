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
    public partial class FormRefund : Form
    {
        private int d_cellindex;
        private int d_rowindex;
        private String id, room, seat;
        private String code, start, end, goal, startTime, endTime, startStation, endStation;
        private bool check = false;
        private DateTime dt;

        public FormRefund()
        {
            InitializeComponent();
        }

        private void FormRefund_Load(object sender, EventArgs e)
        {
            // TODO: 이 코드는 데이터를 'cUSTOM_BOOKING.A_BOOKING' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.a_BOOKINGTableAdapter.Fill(this.cUSTOM_BOOKING.A_BOOKING);
            // TODO: 이 코드는 데이터를 'cUSTOM_BOOKING.A_BOOKING' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.a_BOOKINGTableAdapter.Fill(this.cUSTOM_BOOKING.A_BOOKING);
            oracleConnection1.Open();

        }
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            d_cellindex = e.ColumnIndex; // 클릭된 Cell의 Colum index
            d_rowindex = e.RowIndex; // 클릭된 Row의 Row index

            id = Convert.ToString(dataGridView1.Rows[d_rowindex].Cells[0].Value);
            dt = Convert.ToDateTime(dataGridView1.Rows[d_rowindex].Cells[1].Value);
            code = Convert.ToString(dataGridView1.Rows[d_rowindex].Cells[2].Value);
            room = Convert.ToString(dataGridView1.Rows[d_rowindex].Cells[3].Value);
            seat = Convert.ToString(dataGridView1.Rows[d_rowindex].Cells[4].Value);
            goal = Convert.ToString(dataGridView1.Rows[d_rowindex].Cells[5].Value);
            startTime = Convert.ToString(dataGridView1.Rows[d_rowindex].Cells[6].Value);
            endTime = Convert.ToString(dataGridView1.Rows[d_rowindex].Cells[7].Value);
            startStation = Convert.ToString(dataGridView1.Rows[d_rowindex].Cells[8].Value);
            endStation = Convert.ToString(dataGridView1.Rows[d_rowindex].Cells[9].Value);


        }
        private void button2_Click(object sender, EventArgs e)
        {
            //C_ID B_DATE T_CODE T_ROOM T_SEAT D_GOAL D_STARTTIME D_ENDTIME
            //C_ID = :id AND B_DATE = :dates AND T_CODE = :code AND T_ROOM LIKE :room AND T_SEAT LIKE seat AND D_GOAL LIKE :goal AND d_starttime LIKE :starttime AND d_endtime LIKE :endtIme";
            oracleCommand1.CommandText = "DELETE FROM A_BOOKING WHERE C_ID = :id AND B_DATE = :dates AND T_CODE = :code AND T_ROOM LIKE :room AND T_SEAT LIKE :seat AND D_GOAL LIKE :goal AND D_STARTTIME LIKE :starttime AND D_ENDTIME LIKE :endtime AND D_STARTSTATION LIKE :startstation AND D_ENDSTATION LIKE :endstation"; // AND (T_ROOM LIKE '2호차') AND(T_SEAT LIKE '4')";

            oracleCommand1.Parameters["id"].Value = Convert.ToString(id);
            oracleCommand1.Parameters["dates"].Value = Convert.ToDateTime(dt);
            oracleCommand1.Parameters["code"].Value = Convert.ToString(code);
            oracleCommand1.Parameters["room"].Value = Convert.ToString(room);
            oracleCommand1.Parameters["seat"].Value = Convert.ToString(seat);
            oracleCommand1.Parameters["goal"].Value = Convert.ToString(goal);
            oracleCommand1.Parameters["starttime"].Value = Convert.ToString(startTime);
            oracleCommand1.Parameters["endtime"].Value = Convert.ToString(endTime);
            oracleCommand1.Parameters["startstation"].Value = Convert.ToString(startStation);
            oracleCommand1.Parameters["endstation"].Value = Convert.ToString(endStation);
            


            oracleCommand1.ExecuteNonQuery();

            this.a_BOOKINGTableAdapter.Fill(this.cUSTOM_BOOKING.A_BOOKING);
            aBOOKINGBindingSource.ResetBindings(true);
            MessageBox.Show("성공");
            check = false;

            oracleCommand3.CommandText = "SELECT * FROM A_STATIONS ORDER BY DECODE(S_STATION, '서울', 1, '천안', 2, '대전', 3, '구미', 4, '대구', 5, '부산', 6)";
            OracleDataReader rdr = oracleCommand3.ExecuteReader();
            while (rdr.Read())
            {
                if (rdr[0].ToString().Equals(startStation))
                    check = true;

                if (check == true)
                {
                    String x = rdr[0].ToString();
                    if (x.ToString().Equals(endStation))
                    {
                        check = false;

                        continue;
                    } else 
                    {
                        
                        oracleCommand2.CommandText = "UPDATE A_SEATS SET T_BOOL = :ee WHERE T_CODE = :aa AND T_ROOM LIKE :bb AND T_SEAT LIKE :cc AND T_STATION LIKE :dd";
                        oracleCommand2.Parameters[0].Value = code;
                        oracleCommand2.Parameters[1].Value = room;
                        oracleCommand2.Parameters[2].Value = seat;
                        oracleCommand2.Parameters[3].Value = x;
                        oracleCommand2.Parameters[4].Value = 0.ToString();
                        int number = oracleCommand2.ExecuteNonQuery();

                        this.a_BOOKINGTableAdapter.Fill(this.cUSTOM_BOOKING.A_BOOKING);
                        aBOOKINGBindingSource.ResetBindings(true);
                    }
                }

            }
            
        }

    }
}
