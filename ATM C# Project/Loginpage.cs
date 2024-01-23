using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ATM_C__Project
{
    public partial class Loginpage : Form
    {
        public Loginpage()
        {
            InitializeComponent();
        }

        public static string AccNumber;

        SqlConnection conn = new SqlConnection("Data Source=IMALKAWI;Initial Catalog=ATM_project;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlDataAdapter login = new SqlDataAdapter("SELECT * FROM AccountTBL WHERE AccNum='" + AccNum.Text + "' and AccPin=" + Pin.Text + "", conn);
            DataTable dt = new DataTable();
            login.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                AccNumber = AccNum.Text;
                Mainpage mainpage = new Mainpage();
                mainpage.Show();
                this.Hide();
                conn.Close();
            }
            else
            {
                MessageBox.Show("The Card Number or Password you entered is incorrect");
            }
            conn.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            


        }
    }
}