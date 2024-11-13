using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TaxiManagementWPF
{
    public partial class InputDialog : Window
    {
        public string Answer { get; private set; }

        public InputDialog(string question, string title)
        {
            InitializeComponent();
            Title = title;
            PromptTextBlock.Text = question;
        }

        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            Answer = InputTextBox.Text;
            DialogResult = true;
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }
    }
}
