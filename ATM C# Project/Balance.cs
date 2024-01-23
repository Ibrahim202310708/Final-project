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
    public partial class Balanceform : Form
    {
        public Balanceform()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=IMALKAWI;Initial Catalog=ATM_project;Integrated Security=True");
        private void getbalance()
        {
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Balance from AccountTBL where AccNum='" + Mainpage.AccNumber + "'", conn);           
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                BalanceLbl.Text = "Your Balance is:"+dt.Rows[0][0].ToString();
            }
            else
            {
                BalanceLbl.Text = "No data found";
            }
            conn.Close();

        }
        private void Balanceform_Load(object sender, EventArgs e)
        {
            AccNumberlbl.Text = "Acount Number:" + Mainpage.AccNumber;
            getbalance();

        }

        private void AccNumberlbl_Click(object sender, EventArgs e)
        {

        }

        private void BalanceLbl_Click(object sender, EventArgs e)
        {

        }
    }
}
