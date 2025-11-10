using System.Windows;

namespace AverageLength_lab
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

        private void OnValidateClick(object sender, RoutedEventArgs e)
        {
            var analyzer = new SentenceAnalyzer();

            string sentence = txtSentence.Text;
            analyzer.CalculateAverageWordLength(sentence);

            double average = analyzer.AverageWordLength;

            if (analyzer.Words == 0)
            {
                MessageBox.Show("Det finns ingen text att analysera.");
            }

            if(average >= 3.5 && average <= 4.4)
            {
                MessageBox.Show($"Medellängd: {average}. Du är en sann medelmåtta!");
            }

            else if (average < 3.5)
            {
                MessageBox.Show($"Medellängd: {average}. Dina ord är för korta.");
            }

            else
            {
                MessageBox.Show($"Medellängd: {average}. Dina ord är för långa.");
            }
        }
    }
}

//källor
// https://learn.microsoft.com/en-us/dotnet/api/system.char.isletter?view=net-9.0
// https://learn.microsoft.com/en-us/dotnet/api/system.math.round?view=net-9.0
// https://www.w3resource.com/csharp-exercises/conditional-statement/index.php