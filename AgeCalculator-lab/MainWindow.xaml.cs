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

            if (year < 26)
            { age = 2025 - 2000 - year;
                lblResult.Content = $"Du är {age} år gammal"; ;
            }
            if (year > 25 && year <100)
            { age = 2025 - 1900 - year;
                lblResult.Content = $"Du är {age} år gammal"; ;
            }
            if (year >100)
            { age = 2025 - year;
                if (age > 120)
                { lblResult.Content = "Ursäkta, enligt våra beräkningar borde du vara död."; }
                else
                { lblResult.Content = $"Du är {age} år gammal"; }
            }
            

        }
    }
}