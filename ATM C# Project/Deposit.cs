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
    public partial class DepositForm : Form
    {
        public DepositForm()
        {
            InitializeComponent();
        }
       
        
        
        SqlConnection conn = new SqlConnection("Data Source=IMALKAWI;Initial Catalog=ATM_project;Integrated Security=True");
        string Acc = Mainpage.AccNumber;

        private void button1_Click(object sender, EventArgs e)
        {
            if(DepoAmtb.Text=="" || Convert.ToInt32( DepoAmtb.Text) <= 0)
            {
                MessageBox.Show("Enter the Amount for deposite ");

            }
            else
            {
                NewBalance= Oldbalnce+Convert.ToInt32(DepoAmtb.Text);

                try
                {
                conn.Open();
                    String query = "Update AccountTBL set Balance=" +NewBalance + "where AccNum='" + Acc + "';";
                    //string query = "UPDATE AccountTBL SET Balance = Balance + @DepoAmt WHERE AccNum = @AccNum";

                    SqlCommand cmd = new SqlCommand(query,conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Success Deposit");

                conn.Close();

                }
                catch (Exception Ex)
                { 
                MessageBox.Show(Ex.Message);
                }
            }
        }
        int Oldbalnce, NewBalance;
        private void getbalance()
        {
            try
            {
                conn.Open();
                string query = "SELECT Balance FROM AccountTBL WHERE AccNum = @AccNum";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@AccNum", Acc); // Replace 'Acc' with your actual variable

                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        sda.Fill(dt);

                        if (dt.Rows.Count > 0)
                        {
                            Oldbalnce = Convert.ToInt32(dt.Rows[0]["Balance"]);
                        }
                        else
                        {
                            // Handle the case where no record is found
                            // For example, set Oldbalnce to 0 or handle it appropriately
                            Oldbalnce = 0;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions
                MessageBox.Show("An error occurred: " + ex.Message);
                Oldbalnce = 0; // Or handle it appropriately
            }
            finally
            {
                conn.Close();
            }
        }

        private void DepositForm_Load(object sender, EventArgs e)
        {

            getbalance(); 
        }
    }
}
