using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TaxiManagementAssignment
{
    public class RankManager
    {
        private Dictionary<int, Rank> ranks;
        public RankManager() 
        {
           ranks = new Dictionary<int, Rank>();
           InitializeRanks();
        }
        public Rank FindRank(int rankId) 
        {
            if (!ranks.ContainsKey(rankId)) 
            {
                return null;
            }
            return ranks[rankId];
        }
        private void InitializeRanks() 
        {
            ranks.Add(1, new Rank(1, 5));
            ranks.Add(2, new Rank(2,2));
            ranks.Add(3, new Rank(3,4));
        }

        public bool AddTaxiToRank(Taxi t, int rankId)
        {
            if (t == null)
            {
                throw new ArgumentNullException("");
            }
            if (!string.IsNullOrEmpty(t.GetDestination()))
            {
                Console.WriteLine($"Taxi {t.GetNumber()} already has a destination");
                return false;
            }
            foreach (var existingRank in ranks.Values)
            {
                var existingTaxis = existingRank.GetTaxis();
                bool taxiAlreadyAssigned = existingTaxis.Contains(t);
                if (taxiAlreadyAssigned) 
                {
                    Console.WriteLine($"Taxi {t.Number} is already assigned to Rank {existingRank.Id}");
                    return false;
                }
            }
            //Check if the target rank exist in the dictionary
            if (ranks.ContainsKey(rankId))
            {
                //get the target rank
                Rank targetRank = ranks[rankId];
                bool taxiAdded = targetRank.AddTaxi(t);
                return taxiAdded;
            }
            else
            {
                Console.WriteLine($"Rank {rankId} does not exist");
                return false;
            }
        }

        public Taxi FrontTaxiInRankTakesFare(int rankId, string destination, double aggredPrice)
        {
            bool rankExists = ranks.ContainsKey(rankId);
            
            if (rankExists)
            {
                // Get targetRank from dictionary
                Rank targetRank = ranks[rankId];
                //Get the list of taxis in targetRank
                List<Taxi> taxisInRank = targetRank.GetTaxis();
                //check if there are taxis in rank
                bool rankIsEmpty = taxisInRank.Count == 0;

                if (rankIsEmpty)
                {
                    Console.WriteLine($"Rank {rankId} is empty.");
                    return null;
                }
                else
                {
                    Taxi frontTaxi = targetRank.FrontTaxiTakesFare(destination, aggredPrice);
                    return frontTaxi;
                }
            }
            else
            {
                Console.WriteLine($"Rank {rankId} does not exist");
                return null;
            }

        }
    }
}
