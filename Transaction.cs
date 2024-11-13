using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TaxiManagementAssignment
{
    public class Transaction
    {
        private DateTime transactiondatetime;

        private string transactionType;

        private int taxiNum;
        public DateTime TransactionDatetime
        {
            get { return transactiondatetime; }
            set { transactiondatetime = value; }
        }
        public int TaxiNum

        {
            get { return taxiNum; } 
            set { taxiNum = value; }
        }

        public string TransactionType
        {
            get { return transactionType;}
            set { transactionType = value; }
        }
        public Transaction(DateTime transactionDatetime, int taxiNum)
        {
            TransactionDatetime = transactionDatetime;
            TaxiNum = taxiNum;
        }
    }

}
