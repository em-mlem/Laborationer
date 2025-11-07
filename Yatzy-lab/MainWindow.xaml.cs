using System.Diagnostics.CodeAnalysis;
using System.Windows;

namespace Yatzy_lab
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            // "⚀⚁⚂⚃⚄⚅"
        }


        private void OnOkClick(object sender, RoutedEventArgs e)
        {
            int ones, twos, threes, fours, fives, sixes, sum, bonus;
            ones = int.Parse(txtOnes.Text);
            twos = int.Parse(txtTwos.Text);
            threes = int.Parse(txtThrees.Text);
            fours = int.Parse(txtFours.Text);
            fives = int.Parse(txtFives.Text);
            sixes = int.Parse(txtSixes.Text);
            bonus = 50;
            sum = ones + twos + threes + fours + fives + sixes;
            if (sum > 62)
            {txtBonus.Text = "50";
             sum = ones + twos + threes + fours + fives + sixes + 50;
                txtTotal.Text = sum.ToString();
                sum = Convert.ToInt32(txtTotal.Text);
            }
            if (sum < 62)
            { txtTotal.Text = sum.ToString();
                sum = Convert.ToInt32(txtTotal.Text);
            }
        }

        private void OnClearClick(object sender, RoutedEventArgs e)
        {
            

        }

        private void OnRollClick(object sender, RoutedEventArgs e)
        {
            // https://w3schools.com/c/c_random_numbers.php
        }

        private void OnOnesClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Ettor klickade");
        }

        private void OnTwosClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Tvåor klickade");
        }

        private void OnThreesClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Treor klickade");
        }

        private void OnFoursClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Fyror klickade");
        }

        private void OnFivesClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Femmor klickade");
        }

        private void OnSixesClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Sexor klickade");
        }
    }
}