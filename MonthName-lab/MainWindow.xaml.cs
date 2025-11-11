using System.Windows;

namespace MonthName_lab
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnButtonConvertClick(object sender, RoutedEventArgs e)
        {
            if (!int.TryParse(txtMonthNumber.Text, out int monthNumber))
            {
                MessageBox.Show("Fel: Du måste skriva ett heltal.");
                return;
            }

            if (monthNumber < 1 || monthNumber > 12)
            {
                MessageBox.Show("Fel: Ogiltig månad. Skriv ett tal mellan 1 och 12.");
                return;
            }

            string monthName = "";

            switch (monthNumber)
            {
                case 1: monthName = "Januari"; break;
                case 2: monthName = "Februari"; break;
                case 3: monthName = "Mars"; break;
                case 4: monthName = "April"; break;
                case 5: monthName = "Maj"; break;
                case 6: monthName = "Juni"; break;
                case 7: monthName = "Juli"; break;
                case 8: monthName = "Augusti"; break;
                case 9: monthName = "September"; break;
                case 10: monthName = "Oktober"; break;
                case 11: monthName = "November"; break;
                case 12: monthName = "December"; break;
            }

            MessageBox.Show($"Månad {monthNumber} är {monthName}.");

            txtMonthNumber.Clear();
            txtMonthNumber.Focus();

        }
    }
}