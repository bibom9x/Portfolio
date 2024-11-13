using System.Windows;

namespace TaxiManagementWPF
{
    public partial class LeaveRankDialog : Window
    {
        public int TaxiNumber { get; private set; }
        public int RankId { get; private set; }
        public string Destination { get; private set; }
        public double AgreedPrice { get; private set; }

        public LeaveRankDialog()
        {
            InitializeComponent();
        }

        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(TaxiNumberTextBox.Text, out int taxiNum) &&
                int.TryParse(RankIdTextBox.Text, out int rankId) &&
                double.TryParse(AgreedPriceTextBox.Text, out double agreedPrice))
            {
                TaxiNumber = taxiNum;
                RankId = rankId;
                Destination = DestinationTextBox.Text;
                AgreedPrice = agreedPrice;
                DialogResult = true;
                Close();
            }
            else
            {
                MessageBox.Show("Invalid input. Please enter valid numbers and destination.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }
    }
}
