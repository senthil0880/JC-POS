using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewPOS
{
    public partial class PayForm : Form
    {
        
        public PayForm()
        {
            InitializeComponent();
        }
        private Dictionary<string, string> _transactionInfo;
        private decimal amountToPay;
        private decimal justChange;
        public decimal AmountToPay
        {
            get { return amountToPay; }
            set
            {
                amountToPay = value;
                txtAmountToPay.Text = String.Format("{0:c}", amountToPay);
                int roundUp = (int)amountToPay;
                roundUp++;
                string jcText = "Round up\n"+String.Format("{0:c}", roundUp);
                buttonRoundUp.Text = jcText;
                buttonOK.Text = "Pay Actual\n" + String.Format("{0:c}", amountToPay);
                justChange = roundUp;
            }
        }
        public Dictionary<string, string> transactionInfo
        {
            get { return _transactionInfo; }
            set
            {
                _transactionInfo = value;
            }
        }
        private void buttonRoundUp_Click(object sender, EventArgs e)
        {
            
            this.completePayment();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            justChange = amountToPay; 
            this.completePayment();
        }

        private void completePayment()
        {
            try
            {
                if (txtPaymentAmount.Text == "")
                {
                    MessageBox.Show("Fill out the given amount");
                    return;
                }
                decimal total = 0;
                decimal _paidAmount = decimal.Parse(txtPaymentAmount.Text);
                total = _paidAmount - justChange;
                //MessageBox.Show("Change to give: " + String.Format("{0:c}", -total));

                if (justChange != amountToPay)
                {
                    using (var ctx = new JCTransactionContext())
                    {
                        JCTransaction newTransaction = new JCTransaction()
                        {
                            transDate = DateTime.Now,
                            retailerID = _transactionInfo["retailerID"],
                            transactionID = _transactionInfo["transactionID"],
                            roundupAmount = justChange - amountToPay
                        };
                        ctx.JCTransactions.Add(newTransaction);
                        ctx.SaveChanges();
                    }
                }
                this.Close();

            }
            catch
            { }
        }

    }
    
}
