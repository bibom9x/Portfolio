using System.Windows;
using TaxiManagementAssignment;

namespace TaxiManagementWPF
{
    public partial class MainWindow : Window
    {
        private readonly UserUI userUI;

        public MainWindow()
        {
            InitializeComponent();

            var rankManager = new RankManager();
            var taxiManager = new TaxiManager();
            var transactionManager = new TransactionManager();
            userUI = new UserUI(rankManager, taxiManager, transactionManager);
        }

        private void Introduction_Click(object sender, RoutedEventArgs e)
        {
            var introduction = MessageBox.Show("H23080577 - Software Development and Application Modelling - BUV");
        
        }
        private void JoinRankButton_Click(object sender, RoutedEventArgs e)
        {
            var joinDialog = new JoinRankDialog();
            if (joinDialog.ShowDialog() == true)
            {
                var result = userUI.TaxiJoinsRank(joinDialog.TaxiNumber, joinDialog.RankId);
                DisplayResult(result);
            }
        }

        private void LeaveRankButton_Click(object sender, RoutedEventArgs e)
        {
            var leaveDialog = new LeaveRankDialog();
            if (leaveDialog.ShowDialog() == true)
            {
                var result = userUI.TaxiLeavesRank(leaveDialog.RankId, leaveDialog.Destination, leaveDialog.AgreedPrice);
                DisplayResult(result);
            }
        }

        private void DropFareButton_Click(object sender, RoutedEventArgs e)
        {

            var dropDialog = new DropFareDialog();
            if (dropDialog.ShowDialog() == true)
            {
                var result = userUI.TaxiDropsFare(dropDialog.TaxiNumber, dropDialog.PriceWasPaid);
                DisplayResult(result);
            }
        }

        private void ViewTaxiLocationsButton_Click(object sender, RoutedEventArgs e)
        {
            var result = userUI.ViewTaxiLocations();
            DisplayResult(result);
        }

        private void ViewFinancialReportButton_Click(object sender, RoutedEventArgs e)
        {
            var result = userUI.ViewFinancialReport();
            DisplayResult(result);
        }

        private void ViewTransactionLogButton_Click(object sender, RoutedEventArgs e)
        {
            var result = userUI.ViewTransactionLog();
            DisplayResult(result);
        }

        private void DisplayResult(System.Collections.Generic.List<string> result)
        {
            OutputListBox.Items.Clear();
            foreach (var line in result)
            {
                OutputListBox.Items.Add(line);
            }
        }

        protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
        {
            base.OnClosing(e);
            var result = MessageBox.Show("Are you sure you want to exit?", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
