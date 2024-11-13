using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiManagementAssignment
{
    public class LeaveTransaction : Transaction
    {
        private string destination;
        private double currentFare;
        private int rankId;

        public string Destination
        {
            get { return destination; }
            set { destination = value; }
        }

        public double CurrentFare
        {
            get { return currentFare; }
            set { currentFare = value; }
        }

        public int RankId
        {
            get { return rankId; }
            set { rankId = value; }
        }


        public LeaveTransaction(DateTime transactionDatetime, int rankId, Taxi t) :
            base(transactionDatetime, t.Number)
        {
            TransactionType = "Leave";
            Destination = t.Destination;
            CurrentFare = t.CurrentFare;
            RankId = rankId;
        }
        public override string ToString()
        {
            return $"{TransactionDatetime:dd/MM/yyyy HH:mm} Leave     - Taxi {TaxiNum} from rank {RankId} to {Destination} for £{CurrentFare}";
        }
    }

}
