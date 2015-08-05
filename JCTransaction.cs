using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewPOS
{
    public class JCTransaction
    {
        public JCTransaction()
        {

        }

        public int ID { set; get; }
        public DateTime transDate { set; get; }
        public string retailerID { set; get; }
        public string transactionID { set; get; }
        public decimal roundupAmount { set; get; }
    }
}
