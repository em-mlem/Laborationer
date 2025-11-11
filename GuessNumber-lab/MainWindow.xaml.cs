using System.Windows;

namespace GuessNumber_lab
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly Random _random = new Random();
        private int _secretNumber;
        private int _attempts;

        public MainWindow()
        {
            InitializeComponent();
            StartNewGame();
        }

        private void StartNewGame()
        {
            _secretNumber = _random.Next(1, 101);
            _attempts = 0;

            txtGuess.Clear();
        }
        private void OnNewClick(object sender, RoutedEventArgs e)
        {
            StartNewGame();
        }

        private void OnGuessClick(object sender, RoutedEventArgs e)
        {
            if (!int.TryParse(txtGuess.Text, out int guess))
            {
                MessageBox.Show("Skriv ett giltigt heltal.");
                txtGuess.Clear();
                return;
            }

            if (guess < 1 || guess > 100)
            {
                MessageBox.Show("Talet måste vara mellan 1 och 100.");
                txtGuess.Clear();
                return;
            }

            _attempts++;
            int diff = Math.Abs(guess - _secretNumber);
            if (diff == 0)
            {
                MessageBox.Show($"Du gissade rätt efter {_attempts} försök! Det hemliga talet var {_secretNumber}.");
            }
            else
            {
                if (diff > 20)
                {
                    MessageBox.Show("Du är långt ifrån");
                }
                else
                {
                    MessageBox.Show("Du är nära!");
                }
            }
            txtGuess.Clear();
        }
    }
}
// Källor
// https://learn.microsoft.com/en-us/dotnet/api/system.random?view=net-9.0
// https://learn.microsoft.com/en-us/dotnet/api/system.random.next?view=net-9.0
// https://learn.microsoft.com/en-us/dotnet/api/system.math.abs?view=net-9.0