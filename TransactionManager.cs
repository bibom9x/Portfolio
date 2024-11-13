using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiManagementAssignment
{
    public class TransactionManager
    {
        private readonly List<Transaction> transactions;
        public TransactionManager()
        {
            transactions = new List<Transaction>();
        }
        public List<Transaction> GetAllTransactions()
        {
            return transactions;
        }
        public void RecordJoin(int taxiNum, int rankId)
        {
            var now = DateTime.Now;
            var joinTransaction = new JoinTransaction(now, taxiNum, rankId);
            transactions.Add(joinTransaction);
        }
        
        public void RecordLeave(int rankId, Taxi t)
        {
            var now = DateTime.Now;
            var leaveTransaction = new LeaveTransaction(now, rankId, t);
            transactions.Add(leaveTransaction);
        }

        public void RecordDrop(int taxiNum, bool pricePaid)
        {
            var now = DateTime.Now;
            var dropTransaction = new DropTransaction(now, taxiNum, pricePaid);
            transactions.Add(dropTransaction);
        }
    }
}
