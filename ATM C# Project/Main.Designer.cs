namespace ATM_C__Project
{
    partial class Mainpage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Withdraw = new System.Windows.Forms.Button();
            this.Deposite = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Balance = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label2 = new System.Windows.Forms.Label();
            this.AccNumlbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 100);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(695, 58);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select your transaction please";
            // 
            // Withdraw
            // 
            this.Withdraw.Location = new System.Drawing.Point(145, 161);
            this.Withdraw.Name = "Withdraw";
            this.Withdraw.Size = new System.Drawing.Size(144, 69);
            this.Withdraw.TabIndex = 3;
            this.Withdraw.Text = "Withdraw";
            this.Withdraw.UseVisualStyleBackColor = true;
            this.Withdraw.Click += new System.EventHandler(this.button3_Click);
            // 
            // Deposite
            // 
            this.Deposite.Location = new System.Drawing.Point(145, 265);
            this.Deposite.Name = "Deposite";
            this.Deposite.Size = new System.Drawing.Size(144, 69);
            this.Deposite.TabIndex = 4;
            this.Deposite.Text = "Deposit";
            this.Deposite.UseVisualStyleBackColor = true;
            this.Deposite.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(145, 368);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 69);
            this.button2.TabIndex = 5;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Balance
            // 
            this.Balance.Location = new System.Drawing.Point(532, 161);
            this.Balance.Name = "Balance";
            this.Balance.Size = new System.Drawing.Size(144, 69);
            this.Balance.TabIndex = 6;
            this.Balance.Text = "Check Balance";
            this.Balance.UseVisualStyleBackColor = true;
            this.Balance.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(532, 265);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(144, 69);
            this.button5.TabIndex = 7;
            this.button5.Text = "Fast Cash";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(532, 368);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(144, 69);
            this.button6.TabIndex = 8;
            this.button6.Text = "Change PIN CODE";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "label2";
            // 
            // AccNumlbl
            // 
            this.AccNumlbl.AutoSize = true;
            this.AccNumlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccNumlbl.Location = new System.Drawing.Point(238, 112);
            this.AccNumlbl.Name = "AccNumlbl";
            this.AccNumlbl.Size = new System.Drawing.Size(258, 37);
            this.AccNumlbl.TabIndex = 10;
            this.AccNumlbl.Text = "Account Number";
            // 
            // Mainpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AccNumlbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.Balance);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Deposite);
            this.Controls.Add(this.Withdraw);
            this.Controls.Add(this.panel1);
            this.Name = "Mainpage";
            this.Text = "Mainpage";
            this.Load += new System.EventHandler(this.Mainpage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Withdraw;
        private System.Windows.Forms.Button Deposite;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Balance;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label AccNumlbl;
    }
}