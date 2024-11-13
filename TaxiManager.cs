using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiManagementAssignment
{
    public class TaxiManager
    {
        private readonly SortedDictionary<int, Taxi> taxis;
        public TaxiManager()
        {
            taxis = new SortedDictionary<int, Taxi>();
        }
        public SortedDictionary<int, Taxi> GetAllTaxis()
        {
            return taxis;
        }
        public Taxi FindTaxi(int taxiNum)
        {
            if (!taxis.ContainsKey(taxiNum))
            {
                return null;
            }
            else
            {
                return taxis[taxiNum];
            }
        }
        public Taxi CreateTaxi(int taxiNum)
        {
            if (taxis.ContainsKey(taxiNum)) 
            { 
                return taxis[taxiNum]; 
            }
            Taxi newTaxi = new Taxi(taxiNum);
            taxis.Add(taxiNum, newTaxi);
            return newTaxi;
        }
    }
}
