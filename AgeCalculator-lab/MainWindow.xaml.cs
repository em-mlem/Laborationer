using System.Windows;

namespace AgeCalculator_lab
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

        private void OnCalculateClick(object sender, RoutedEventArgs e)
        {
            int year, age;
            year = int.Parse(txtAge.Text);
            age = 2025 - year;
            string message = $"Du är {age} år gammal";

            lblResult.Content = message;

        }
    }
}