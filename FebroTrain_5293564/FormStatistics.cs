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
    public partial class FormStatistics : Form
    {
        public FormStatistics()
        {
            InitializeComponent();
            oracleConnection1.Open();

        }

        private void FormStatistics_Load(object sender, EventArgs e)
        {
            
            oracleCommand1.CommandText = "SELECT station.s_station as station, COUNT(book.B_DATE) as count FROM A_BOOKING book FULL OUTER JOIN A_STATIONS station ON book.d_endstation LIKE station.s_station GROUP BY station.s_station";
            OracleDataReader rdr = oracleCommand1.ExecuteReader();

            while(rdr.Read())
            {
                chart1.Series[0].Points.AddXY(rdr["station"], rdr["count"]);
            }
            rdr.Close();
            
            oracleCommand1.CommandText = "SELECT C_DATA, COUNT(C_DATA) AS count FROM A_CUSTOMERS GROUP BY C_DATA";
            OracleDataReader rdr2 = oracleCommand1.ExecuteReader();

            while (rdr2.Read())
            {
                chart2.Series[0].Points.AddXY(rdr2["C_DATA"], rdr2["COUNT"]);
            }
            rdr2.Close();
            oracleConnection1.Close();
            

        }
    }
}
