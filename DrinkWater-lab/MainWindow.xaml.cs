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
                int roundedLiters = (int)Math.Floor(liters);

                MessageBox.Show($"Du bör dricka {roundedLiters} liter vatten.");
            }
            else
            {
                MessageBox.Show("Felaktig inmatning. Skriv in ett giltigt tal för antal timmar.");
            }
        }
    }
}
//källor
//https://learn.microsoft.com/en-us/dotnet/api/system.math.floor