using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FebroTrain_5293564
{
    public partial class FormCustomer : Form
    {
        public FormCustomer()
        {
            InitializeComponent();
        }

        private void FormCustomer_Load(object sender, EventArgs e)
        {
            // TODO: 이 코드는 데이터를 'rOUTE_Busan.A_ROUTES' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.a_ROUTESTableAdapter.FillByBusan(this.rOUTE_Busan.A_ROUTES);
            // TODO: 이 코드는 데이터를 'rOUTE_Busan1.A_ROUTES' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            // TODO: 이 코드는 데이터를 'rOUTE_Busan.A_ROUTES' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            radioButton1.Checked = true;
            filterExecute();
            // TODO: 이 코드는 데이터를 'station.A_STATIONS' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            // TODO: 이 코드는 데이터를 'timeTable.TIMETABLE' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.tIMETABLETableAdapter.Fill(this.timeTable.TIMETABLE);
            comboBox2.SelectedIndex = 0;
        }

        String filterValue1;    // 운행방향에 대한 filter
        String filterValue2;    // 경로역에 대한 filter
        String filterValue3;    // 출발시간에 대한 filter
        String values;
        
        void filterExecute()
        {

            if (comboBox1.Enabled == true && comboBox2.Enabled == false)
                tIMETABLEBindingSource.Filter = "(" + filterValue1 + ")" + " AND " + "(" + filterValue2 + ")";
            else if (comboBox1.Enabled == false && comboBox2.Enabled == true)
                tIMETABLEBindingSource.Filter = "(" + filterValue1 + ")" + " AND " + "(" + filterValue3 + ")";
            else if (comboBox1.Enabled == true && comboBox2.Enabled == true)
                tIMETABLEBindingSource.Filter = "(" + filterValue1 + ")" + " AND " + "(" + filterValue2 + ")" + " AND " + "(" + filterValue3 + ")";
            else
                tIMETABLEBindingSource.Filter = "(" + filterValue1 + ")";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            filterValue1 = "D_GOAL = " + "'" + radioButton1.Text + "'";
            filterExecute();
            
    
                this.a_ROUTESTableAdapter.FillBySeoul(this.rOUTE_Busan.A_ROUTES);
                aROUTESBindingSource.ResetBindings(true);
            



        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            filterValue1 = "D_GOAL = " + "'" + radioButton2.Text + "'";
            filterExecute();

                this.a_ROUTESTableAdapter.FillByBusan(this.rOUTE_Busan.A_ROUTES);
                aROUTESBindingSource.ResetBindings(true);
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                comboBox1.Enabled = true;

                DataRowView rowView = comboBox1.SelectedItem as DataRowView;
                if (rowView != null)
                {
                    values = rowView["s_station"].ToString();
                }
                filterValue2 = "S_STATION = '" + values + "'";
                filterExecute();
            }
            else
            {
                comboBox1.Enabled = false;
                filterExecute();
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                comboBox2.Enabled = true;

                values = Convert.ToString(comboBox2.GetItemText(this.comboBox2.SelectedItem));

                DateTime dt = Convert.ToDateTime(values);

                values = dt.ToString("HH:mm");

                filterValue3 = "D_STARTTIME >= '" + values + "'";

                filterExecute();
            }
            else
            {
                comboBox2.Enabled = false;
                filterExecute();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormDeserve form = new FormDeserve();
            form.Show();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            values = Convert.ToString(comboBox2.GetItemText(this.comboBox2.SelectedItem));
            DateTime dt = Convert.ToDateTime(values);
            values = dt.ToString("HH:mm");
            filterValue3 = "D_STARTTIME >= '" + values + "'";

            filterExecute();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormRefund custom = new FormRefund();
            custom.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView rowView = comboBox1.SelectedItem as DataRowView;
            if (rowView != null)
            {
                values = rowView["s_station"].ToString();
            }
            filterValue2 = "S_STATION = '" + values + "'";
            filterExecute();
        }
    }
}
