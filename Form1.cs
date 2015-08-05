using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Printing;

namespace NewPOS
{
    public partial class Form1 : Form
    {
      
        public Form1()
        {
            InitializeComponent();
            transactionCounter = 1;
        }

        private decimal total;
        private int transactionCounter;

        public decimal Total
        {
            get { return total; }
            set
            {
                total = value;
                totalText.Text = String.Format("{0:c}", total);
            }
        }

        public string label1Text
        {
            get
            {
                return this.label1.Text;
            }
            set
            {
                this.label1.Text = value;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
        }

        //private void btnPay_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (Total == 0)
        //        {
        //            MessageBox.Show("Nothing to pay!");
        //            return;
        //        }

        //    }
        //    catch { }
        //}

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("Milk");

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void payButton_Click(object sender, EventArgs e)
        {
            PayForm f1 = new PayForm();
            f1.AmountToPay = 97.5M;
            Dictionary<string, string> transInfo = new Dictionary<string, string>();
            transInfo.Add("retailerID", "RTA01V0100001");
            string _transIDTemp = "ASC01XY0000" + transactionCounter.ToString();
            transInfo.Add("transactionID", _transIDTemp);
            f1.transactionInfo = transInfo;
            f1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            transactionCounter++;
            this.transID.Text = "ASC01XY0000" +  transactionCounter.ToString();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
