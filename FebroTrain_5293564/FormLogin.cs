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
    public partial class FormLogin : Form
    {
        public static String C_ID;

        public FormLogin()
        {
            InitializeComponent();
            oracleConnection1.Open();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals("") || textBox2.Text.Equals(""))
            {
                MessageBox.Show("아이디 혹은 패스워드를 확인해주세요");
                return;
            }
            oracleCommand1.CommandText = "SELECT C_TYPE FROM A_CUSTOMERS WHERE C_ID = " + textBox1.Text + " AND C_PASSWORD = " + textBox2.Text;
            String result = Convert.ToString(oracleCommand1.ExecuteScalar());
            if (result.Equals("고객"))
            {
                C_ID = textBox1.Text;

                MessageBox.Show("고객님 안녕하세요.");
                FormCustomer form2 = new FormCustomer();
                form2.Show();
            }
            else if (result.Equals("관리자"))
            {
                MessageBox.Show("관리자님 안녕하세요.");
                FormAdmin form3 = new FormAdmin();
                form3.Show();
            }
            else
            {
                MessageBox.Show("아이디 혹은 패스워드를 관리자에게 문의하세요");
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            //pictureBox1.Image = System.Drawing.Image.FromFile("C:\trainImage");
        }
    }
}
