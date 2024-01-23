using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ATM_C__Project
{
    public partial class WithdrawalForm : Form
    {
        public WithdrawalForm()
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
            BalanceLbl.Text = dt.Rows[0][0].ToString();
            Balence = Convert.ToInt32(dt.Rows[0][0].ToString());
            conn.Close();

        }
        int NewBalance;

        private void btnWithdraw_Click(object sender, EventArgs e)
        {

            if (wdantLB.Text == "")

            {
                MessageBox.Show("Enter the withdraw amount");


            }
            else if (Convert.ToInt32(wdantLB.Text) <=0)
            {
                MessageBox.Show("Enter the withdraw amount bigger than zero");

            }
            else if(Convert.ToInt32(wdantLB.Text) > Balence)

            {

                MessageBox.Show("You don't have enough balance");
            }
            else
            {

                try
                {

                    NewBalance =  Balence- Convert.ToInt32(wdantLB.Text);

                    try
                    {
                        conn.Open();
                        String query = "Update AccountTBL set Balance=" + NewBalance + "where AccNum='" + Mainpage.AccNumber  + "';";
                        //string query = "UPDATE AccountTBL SET Balance = Balance + @DepoAmt WHERE AccNum = @AccNum";

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
                catch(Exception Ex)
                {



                    MessageBox.Show(Ex.Message);
                }




            }
        }

       
        private void lblAvailableBalance_Click(object sender, EventArgs e)
        {
        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void WithdrawalForm_Load(object sender, EventArgs e)
        {
            getbalance();

        }
    }
}
