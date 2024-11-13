using System.Windows;

namespace TaxiManagementWPF
{
    public partial class JoinRankDialog : Window
    {
        public int TaxiNumber { get; private set; }
        public int RankId { get; private set; }

        public JoinRankDialog()
        {
            InitializeComponent();
        }

        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(TaxiNumberTextBox.Text, out int taxiNum) && int.TryParse(RankIdTextBox.Text, out int rankId))
            {
                TaxiNumber = taxiNum;
                RankId = rankId;
                DialogResult = true;
                Close();
            }
            else
            {
                MessageBox.Show("Invalid input. Please enter valid numbers.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }
    }
}
