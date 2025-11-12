using System.Globalization;
using System.Windows;

namespace Temperatures_lab
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly double[] _temps = new double[7];
        private int _count = 0;
        private readonly string[] _days = { "måndag", "tisdag", "onsdag", "torsdag", "fredag", "lördag", "söndag" };

        public MainWindow()
        {
            InitializeComponent();
            txtResult.Text = "Ange veckans temperaturer och klicka på 'Lägg till'.";
        }


        private void OnAddClick(object sender, RoutedEventArgs e)
        {
            if (_count >= _temps.Length)
            {
                txtResult.Text = "Alla temperaturer är redan inmatade.";
                return;
            }

            string input = (txtTemp.Text ?? string.Empty).Trim().Replace('.', ',');
            double temp = double.Parse(input, CultureInfo.CurrentCulture);

            _temps[_count] = temp;
            _count++;

            lstTemps.Items.Add($"{temp} °C");

            if (_count < _temps.Length)
            {
                txtResult.Text = "Temperaturen har lagts till.";
            }
            else
            {
                txtResult.Text = "Alla temperaturer är nu inmatade. Klicka på 'Beräkna statistik'.";
            }

            txtTemp.Clear();
            txtTemp.Focus();
        }

        private void OnCalcClick(object sender, RoutedEventArgs e)
        {
            if (_count < _temps.Length)
            {
                txtResult.Text = "Fyll i alla temperaturer först.";
                return;
            }

            double sum = 0;
            double min = _temps[0];
            double max = _temps[0];
            int minIndex = 0;
            int maxIndex = 0;

            for (int i = 0; i < _temps.Length; i++)
            {
                double t = _temps[i];
                sum += t;

                if (t < min) { min = t; minIndex = i; }
                if (t > max) { max = t; maxIndex = i; }
            }

            double avg = Math.Round(sum / _temps.Length, 2);

            lstTemps.Items.Clear();
            for (int i = 0; i < _temps.Length; i++)
            {
                string day = _days[i];
                day = char.ToUpper(day[0]) + day.Substring(1);
                lstTemps.Items.Add($"{day}: {_temps[i]} °C");
            }

            string maxDay = char.ToUpper(_days[maxIndex][0]) + _days[maxIndex].Substring(1);
            string minDay = char.ToUpper(_days[minIndex][0]) + _days[minIndex].Substring(1);

            txtResult.Text = $"Medel: {avg} °C   Högsta: {max} °C ({maxDay})   Lägsta: {min} °C ({minDay})";
        }

    }
}

//källor
// https://learn.microsoft.com/en-us/dotnet/api/system.char.toupper?view=net-9.0
// https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/arrays#accessing-array-elements
// https://learn.microsoft.com/en-us/dotnet/api/system.double.parse?view=net-9.0