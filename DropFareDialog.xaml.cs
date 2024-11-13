using System.Windows;

namespace TaxiManagementWPF
{
    public partial class DropFareDialog : Window
    {
        public int TaxiNumber { get; private set; }
        public bool PriceWasPaid { get; private set; }

        public DropFareDialog()
        {
            InitializeComponent();
        }

        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(TaxiNumberTextBox.Text, out int taxiNum))
            {
                TaxiNumber = taxiNum;

                if (PricePaidCheckBox.IsChecked == true)
                {
                    PriceWasPaid = true;
                }
                else if (PricePaidCheckBox.IsChecked == null)
                {
                    PriceWasPaid = false;
                }

                DialogResult = true;
                Close();
            }
            else
            {
                MessageBox.Show("Invalid input. Please enter a valid taxi number.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }
    }
}
