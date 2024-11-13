using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiManagementAssignment
{
    public class JoinTransaction : Transaction
    {
        private int rankId;

        public int RankId
        { 
            get { return rankId; } 
            set { rankId = value; }
        }

        public JoinTransaction(DateTime transactionDatetime, int taxiNum, int rankId)
            : base(transactionDatetime, taxiNum)
        {
            TransactionType = "Join";
            RankId = rankId;
        }
        public override string ToString()
        {
            return $"{TransactionDatetime:dd/MM/yyyy HH:mm} Join      - Taxi {TaxiNum} in rank {RankId}";
        }
    }

}
