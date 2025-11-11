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
            string formula = txtHydrogen.Text.Trim();
            int hydrogenCount = 0;

            for (int i = 0; i < formula.Length; i++)
            {
                char c = formula[i];

                if (c == 'H')
                {
                    int count = 1;

                    if(i + 1 < formula.Length && char.IsDigit(formula[i+1]))
                    {
                        string numberText = "";
                        int j = i + 1;

                        while(j < formula.Length && char.IsDigit(formula[j]))
                        {
                            numberText += formula[j];
                            j++;
                        }

                        if (int.TryParse(numberText, out int number))
                        {
                            count = number;
                        }
                        i = j - 1;
                    }
                    hydrogenCount += count;
                }
            }
            
            MessageBox.Show($"Formeln {formula} innehåller {hydrogenCount} väteatomer (H).");
        }
    }
}
//källor
//https://learn.microsoft.com/en-us/dotnet/api/system.math.floor
// https://www.codecademy.com/resources/docs/c-sharp/loops