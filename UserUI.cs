using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;


namespace TaxiManagementAssignment
{
    public class UserUI
    {
        private readonly RankManager rankManager;
        private readonly TaxiManager taxiManager;
        private readonly TransactionManager transactionManager;


        public UserUI(RankManager rkMgr, TaxiManager txMgr, TransactionManager trMgr)
        {
            rankManager = rkMgr;
            taxiManager = txMgr;
            transactionManager = trMgr;
        }

        public List<string> TaxiJoinsRank(int taxiNum, int rankId)
        {
            List<string> result = new List<string>();

            Taxi taxi = taxiManager.FindTaxi(taxiNum);

            if (taxi == null)
            {
                taxi = taxiManager.CreateTaxi(taxiNum);
            }

            if (taxi != null)
            { 
                bool AddOrNot = rankManager.AddTaxiToRank(taxi, rankId);
                if (AddOrNot) 
                {
                    transactionManager.RecordJoin(taxiNum, rankId);
                    result.Add($"Taxi {taxiNum} has joined rank {rankId}.");
                }
                else
                {
                    result.Add($"Taxi {taxiNum} has not joined rank {rankId}.");
                }
            }
            return result;
        }

        public List<string> TaxiLeavesRank(int rankId, string destination, double agreedPrice) 
        {
            List<string> result = new List<string>();

            Rank rank = rankManager.FindRank(rankId);
            if (rank != null)
            {
                Taxi taxi = rank.FrontTaxiTakesFare(destination, agreedPrice);
                if (taxi != null)
                {
                    transactionManager.RecordLeave(rankId, taxi);
                    result.Add($"Taxi {taxi.Number} has left rank {rankId} to take a fare to {destination} for £{agreedPrice}.");
                }
                else
                {
                    result.Add($"Taxi has not left rank {rankId}.");
                }
            }
            return result;
        }

public List<string> TaxiDropsFare(int taxiNum, bool pricePaid)
{
    List<string> result = new List<string>();
    
    Taxi taxi = taxiManager.FindTaxi(taxiNum);
    if (taxi != null) 
    {
        if (!string.IsNullOrEmpty(taxi.GetDestination()))
        {
            taxi.DropFare(pricePaid);
            transactionManager.RecordDrop(taxiNum, pricePaid);
            if (pricePaid)
            {
                result.Add($"Taxi {taxiNum} has dropped its fare and the price was paid.");
            }
            else
            {
                result.Add($"Taxi {taxiNum} has dropped its fare and the price was not paid.");
            }
        }
        else
        {
            result.Add($"Taxi {taxiNum} has not dropped its fare.");
        }
    }
    else
    {
        result.Add($"Taxi {taxiNum} not found.");
    }
    return result;
}

        public List<string> ViewTaxiLocations()
        {
            List<string> locations = new List<string>
    {
        "Taxi locations",
        "=============="
    };

            var taxis = taxiManager.GetAllTaxis();
            if (taxis.Count == 0)
            {
                locations.Add("No taxis");
            }
            else
            {
                foreach (var taxi in taxis.Values)
                {
                    if (taxi.Location == "on the road")
                    {
                        if (!string.IsNullOrEmpty(taxi.Destination))
                        {
                            locations.Add($"Taxi {taxi.Number} is on the road to {taxi.GetDestination()}");
                        }
                        else
                        {
                            locations.Add($"Taxi {taxi.Number} is on the road");
                        }
                    }
                    else
                    {
                        locations.Add($"Taxi {taxi.Number} is in rank {taxi.GetRank().Id}");
                    }
                }
            }
            return locations;
        }

        public List<string> ViewFinancialReport()
        {
            List<string> report = new List<string>
    {
        "Financial report",
        "================"
    };

            var taxis = taxiManager.GetAllTaxis();
            if (taxis.Count == 0)
            {
                report.Add("No taxis, so no money taken");
            }
            else
            {
                double totalMoney = 0;
                foreach (var taxi in taxis.Values)
                {
                    double moneyTaken = taxi.GetTotalMoneyPaid();
                    totalMoney += moneyTaken;
                    report.Add($"Taxi {taxi.Number}      {moneyTaken:F2}");
                }

                report.Add("           ======");
                report.Add($"Total:       {totalMoney:F2}");
                report.Add("           ======");
            }

            return report;
        }
        public List<string> ViewTransactionLog()
        {
            List<string> log = new List<string>
    {
        "Transaction report",
        "=================="
    };

            var transactions = transactionManager.GetAllTransactions();
            if (transactions.Count == 0)
            {
                log.Add("No transactions");
            }
            else
            {
                foreach (var transaction in transactions)
                {
                    log.Add(transaction.ToString());
                }
            }

            return log;
        }

    }
}
