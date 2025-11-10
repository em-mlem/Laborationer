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
            string feedback = analyzer.GetFeedback(sentence);

            MessageBox.Show(feedback);
        }
    }
}

//källor
// https://learn.microsoft.com/en-us/dotnet/api/system.char.isletter?view=net-9.0
// https://learn.microsoft.com/en-us/dotnet/api/system.math.round?view=net-9.0