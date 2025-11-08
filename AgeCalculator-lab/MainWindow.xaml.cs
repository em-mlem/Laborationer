using System.Windows;

namespace AgeCalculator_lab
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //https://learn.microsoft.com/en-us/dotnet/api/system.char.isdigit?view=net-9.0

        public MainWindow()
        {
            InitializeComponent();
        }

        private bool IsValidNumber(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return false;

            foreach (char c in input)
            {
                if (!char.IsDigit(c))
                    return false;
            }

            return true;
        }

        private void OnCalculateClick(object sender, RoutedEventArgs e)
        {
            string input = txtAge.Text;

            if (!IsValidNumber(input))
            {
                MessageBox.Show("Du måste ange ett giltigt årtal (endast siffror).");
                return;
            }

            int year, age, year2000, year1900;
            year = int.Parse(txtAge.Text); 

            if (year < 26)
            { age = 2025 - 2000 - year;
                lblResult.Content = $"Du är {age} år gammal";
                year2000 = year + 2000;
                txtAge.Text = year2000.ToString();
            }
            if (year > 25 && year <100)
            { age = 2025 - 1900 - year;
                lblResult.Content = $"Du är {age} år gammal";
                year1900 = year + 1900;
                txtAge.Text = year1900.ToString();
            }
            if (year >99)
            { age = 2025 - year;
                if (age > 120)
                { lblResult.Content = "Ursäkta, enligt våra beräkningar borde du vara död."; }
                else
                { lblResult.Content = $"Du är {age} år gammal"; }
            }
            

        }
    }
}