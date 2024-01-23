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
    public partial class Mainpage : Form
    {
        public Mainpage()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            WithdrawalForm withdrawForm = new WithdrawalForm();
            withdrawForm.ShowDialog();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            DepositForm depositForm = new DepositForm();
            depositForm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Balanceform balanceForm = new Balanceform();
            balanceForm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Fastcashform fastcashform = new Fastcashform();
            fastcashform.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ChangePinform changePinform = new ChangePinform();
                changePinform.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Loginpage loginpage = new Loginpage(); 
            loginpage.ShowDialog();
            
        }
        public static string AccNumber;

        private void Mainpage_Load(object sender, EventArgs e)
        {
            AccNumlbl.Text = "Acount Number:" + Loginpage.AccNumber;

            AccNumber= Loginpage.AccNumber;

        }
    }
    }

