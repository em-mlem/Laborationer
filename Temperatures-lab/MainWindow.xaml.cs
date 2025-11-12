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

            string input = txtTemp.Text.Trim().Replace('.', ',');
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

            for (int i = 0; i < _temps.Length; i++)
            {
                double t = _temps[i];
                sum += t;
                if (t < min) min = t;
                if (t > max) max = t;
            }

            double avg = Math.Round(sum / _temps.Length, 2);

            txtResult.Text = $"Medel: {avg} °C   Högsta: {max} °C   Lägsta: {min} °C";
        }

    }
}