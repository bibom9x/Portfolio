using System;

namespace TaxiManagementAssignment
{
    public class Taxi
    {
        private double currentFare;
        private int number;
        private string destination;
        private string location;
        private double totalMoneyPaid;
        private Rank rank = null;

        public int Number
        {
            get { return number; }
            set { number = value; }
        }

        public double CurrentFare
        {
            get { return currentFare; }
            set { currentFare = value; }
        }

        public string Destination
        {
            get { return destination; }
            set { destination = value; }
        }

        public string Location
        {
            get { return location; }
            set { location = value; }
        }

        public static string ON_ROAD { get; } = "on the road";
        public static string IN_RANK { get; } = "in rank";

        public double TotalMoneyPaid
        {
            get { return totalMoneyPaid; }
            set { totalMoneyPaid = value; }
        }

        public Rank Rank
        {
            get { return rank; }
            set
            {
                if (value == null)
                {
                    throw new Exception("Rank cannot be null");
                }
                if (!string.IsNullOrEmpty(Destination))
                {
                    throw new Exception("Cannot join rank if fare has not been dropped");
                }
                rank = value;
                Location = IN_RANK;
            }
        }

        public Taxi(int num)
        {
            Number = num;
            CurrentFare = 0;
            Destination = string.Empty;
            Location = ON_ROAD;
            TotalMoneyPaid = 0;
        }

        public void AddFare(string destination, double agreedPrice)
        {
            Destination = destination;
            CurrentFare = agreedPrice;
            Location = ON_ROAD;
            rank = null;
        }

        public void DropFare(bool priceWasPaid)
        {
            if (priceWasPaid)
            {
                TotalMoneyPaid += CurrentFare;
                Destination = string.Empty;
                Location = ON_ROAD;
                CurrentFare = 0;
            }
            else
            {

            }
            Location = ON_ROAD;
        }
        public string GetDestination()
        {
            return Destination;
        }
        public int GetNumber()
        {
            return Number;
        }

        public double GetCurrentFare()
        {
            return CurrentFare;
        }

        public string GetLocation()
        {
            return Location;
        }

        public Rank GetRank()
        {
            return rank;
        }

        public double GetTotalMoneyPaid()
        {
            return TotalMoneyPaid;
        }

        public void SetRank(Rank r)
        {
            rank = r;
        }

    }
}