using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace NewPOS
{
    public class JCTransactionContext:DbContext
    {
        public JCTransactionContext() :base(){

        }

        public DbSet<JCTransaction> JCTransactions { set; get; }
    }
}
