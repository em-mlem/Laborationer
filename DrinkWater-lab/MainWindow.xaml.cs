using System.Windows;

namespace DrinkWater_lab
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

        private void OnButtonCalculateClick(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(txtHours.Text, out double hours))
            {
                double liters = hours * 0.5;
                int wholeBottles = (int)Math.Ceiling(liters);

                MessageBox.Show($"Du bör dricka {wholeBottles} flaskor vatten.");
            }
            else
            {
                MessageBox.Show("Felaktig inmatning. Skriv in ett giltigt tal för antal timmar.");
            }
        }

        private void btnAnalyze_Click(object sender, RoutedEventArgs e)
        {
            string formula = "C6H12O6H20";
            int hydrogenCount = 0;

            for (int i = 0; i < formula.Length; i++)
            {
                if (formula[i] == 'H')
                {
                    hydrogenCount++;
                }
            }

            MessageBox.Show($"Formeln {formula} innehåller {hydrogenCount} väteatomer (H).");
        }
    }
}
//källor
//https://learn.microsoft.com/en-us/dotnet/api/system.math.floor