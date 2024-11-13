using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiManagementAssignment
{
    public class DropTransaction : Transaction
    {
        private bool priceWasPaid;

        public bool PriceWasPaid
        {
            get { return priceWasPaid; }
            set { priceWasPaid = value; }
        }

        public DropTransaction(DateTime transactionDatetime, int taxiNum, bool priceWasPaid) :
            base(transactionDatetime, taxiNum)
        {
            TransactionType = "Drop fare";
            PriceWasPaid = priceWasPaid;
        }

        public override string ToString()
        {
            if (PriceWasPaid)
            {
                return $"{TransactionDatetime:dd/MM/yyyy HH:mm} Drop fare - Taxi {TaxiNum}, price was paid";
            }
            else
            {
                return $"{TransactionDatetime:dd/MM/yyyy HH:mm} Drop fare - Taxi {TaxiNum}, price was not paid";
            }
        }
    }
}
