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
    public partial class ChangePinform : Form
    {
        public ChangePinform()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=IMALKAWI;Initial Catalog=ATM_project;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {

            if (Pin1Tb.Text == "" || Pin2Tb.Text == "")
            {
                MessageBox.Show("Enter and confirm the new Pin");

            }

            else if(Pin2Tb.Text != Pin1Tb.Text)
            {

                MessageBox.Show("Enter and same pin code in the two boxes");


            }
            else
            {
                //NewBalance = Oldbalnce + Convert.ToInt32(DepoAmtb.Text);

                try
                {
                    conn.Open();
                    String query = "Update AccountTBL set AccPin=" + Pin1Tb.Text + "where AccNum='" + Mainpage.AccNumber + "';";            
                   

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Pin code Successfully changed");

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

