using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM_C__Project
{
    public partial class Fastcashform : Form
    {
        public Fastcashform()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=IMALKAWI;Initial Catalog=ATM_project;Integrated Security=True");
        int Balence;
        private void getbalance()
        {
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Balance from AccountTBL where AccNum='" + Mainpage.AccNumber + "'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            BalanceLbl.Text = "Your Balance:" + dt.Rows[0][0].ToString();
            Balence = Convert.ToInt32(dt.Rows[0][0].ToString());
            conn.Close();

        }
        private void Fastcashform_Load(object sender, EventArgs e)
        {
            getbalance();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Balence < 100)
            {

                MessageBox.Show("Your Balance is less than 100");

            }
            else
            {
                int NewBalance = Balence - 100;

                try
                {
                    conn.Open();
                    String query = "Update AccountTBL set Balance=" + NewBalance + "where AccNum='" + Mainpage.AccNumber + "';";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Success Withdraw");

                    conn.Close();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Balence < 200)
            {

                MessageBox.Show("Your Balance is less than 200");

            }
            else
            {
                int NewBalance = Balence - 200;

                try
                {
                    conn.Open();
                    String query = "Update AccountTBL set Balance=" + NewBalance + "where AccNum='" + Mainpage.AccNumber + "';";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Success Withdraw");

                    conn.Close();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Balence < 400)
            {

                MessageBox.Show("Your Balance is less than 400");

            }
            else
            {
                int NewBalance = Balence - 400;

                try
                {
                    conn.Open();
                    String query = "Update AccountTBL set Balance=" + NewBalance + "where AccNum='" + Mainpage.AccNumber + "';";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Success Withdraw");

                    conn.Close();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Balence < 600)
            {

                MessageBox.Show("Your Balance is less than 600");

            }
            else
            {
                int NewBalance = Balence - 600;

                try
                {
                    conn.Open();
                    String query = "Update AccountTBL set Balance=" + NewBalance + "where AccNum='" + Mainpage.AccNumber + "';";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Success Withdraw");

                    conn.Close();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (Balence < 800)
            {

                MessageBox.Show("Your Balance is less than 800");

            }
            else
            {
                int NewBalance = Balence - 800;

                try
                {
                    conn.Open();
                    String query = "Update AccountTBL set Balance=" + NewBalance + "where AccNum='" + Mainpage.AccNumber + "';";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Success Withdraw");

                    conn.Close();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (Balence < 1000)
            {

                MessageBox.Show("Your Balance is less than 1000");

            }
            else
            {
                int NewBalance = Balence - 1000;

                try
                {
                    conn.Open();
                    String query = "Update AccountTBL set Balance=" + NewBalance + "where AccNum='" + Mainpage.AccNumber + "';";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Success Withdraw");

                    conn.Close();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
    }
}