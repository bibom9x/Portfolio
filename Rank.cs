using System;
using System.Collections.Generic;

namespace TaxiManagementAssignment
{
    public class Rank
    {
        private int id;
        private int numberOfTaxiSpace;
        private List<Taxi> taxiSpace;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public int NumberOfTaxiSpace
        {
            get { return numberOfTaxiSpace; }
            set { numberOfTaxiSpace = value; }
        }

        public Rank(int rankID, int numberOfTaxiSpace)
        {
            Id = rankID;
            NumberOfTaxiSpace = numberOfTaxiSpace;
            taxiSpace = new List<Taxi>();
        }

        public bool AddTaxi(Taxi t)
        {
            if (t == null)
            {
                throw new Exception("Taxi cannot be null");
            }
            if (taxiSpace.Count >= NumberOfTaxiSpace)
            {
                return false;
            }
            t.Rank = this;
            taxiSpace.Add(t);
            return true;
        }

        public Taxi FrontTaxiTakesFare(string destination, double agreedPrice)
        {
            if (taxiSpace.Count == 0)
            {
                return null;
            }
            Taxi frontTaxi = taxiSpace[0];
            taxiSpace.RemoveAt(0);
            frontTaxi.AddFare(destination, agreedPrice);
            return frontTaxi;
        }

        public List<Taxi> GetTaxis()
        {
            return new List<Taxi>(taxiSpace);
        }
    }
}
