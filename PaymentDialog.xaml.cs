using System.Windows;

namespace TaxiManagementWPF
{
    public partial class PaymentDialog : Window
    {
        public bool PriceWasPaid { get; private set; }

        public PaymentDialog()
        {
            InitializeComponent();
        }

        private void YesButton_Click(object sender, RoutedEventArgs e)
        {
            PriceWasPaid = true;
            DialogResult = true;
            Close();
        }

        private void NoButton_Click(object sender, RoutedEventArgs e)
        {
            PriceWasPaid = false;
            DialogResult = true;
            Close();
        }
    }
}
