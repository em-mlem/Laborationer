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
            Random rnd = new Random();
            int dice1 = rnd.Next(1, 7);
            int dice2 = rnd.Next(1, 7);
            int dice3 = rnd.Next(1, 7);
            int dice4 = rnd.Next(1, 7);
            int dice5 = rnd.Next(1, 7);
            diceOne.Text = dice1.ToString();
            diceTwo.Text = dice2.ToString();
            diceThree.Text = dice3.ToString();
            diceFour.Text = dice4.ToString();
            diceFive.Text = dice5.ToString();

        }

        private void OnOnesClick(object sender, RoutedEventArgs e)
        {
            int[] dice = { Int32.Parse(diceOne.Text), Int32.Parse(diceTwo.Text), Int32.Parse(diceThree.Text), Int32.Parse(diceFour.Text), Int32.Parse(diceFive.Text) };
            int ones = 0;
            for (int i = 0; i < dice.Length; i++)
            {
                if (dice[i] == 1)
                {
                    ones += 1;
                }
            }
            txtOnes.Text = ones.ToString();

        }

        private void OnTwosClick(object sender, RoutedEventArgs e)
        {
            int[] dice = { Int32.Parse(diceOne.Text), Int32.Parse(diceTwo.Text), Int32.Parse(diceThree.Text), Int32.Parse(diceFour.Text), Int32.Parse(diceFive.Text) };
            int twos = 0;
            for (int i = 0; i < dice.Length; i++)
            {
                if (dice[i] == 2)
                {
                    twos += 2;
                }
            }
            txtTwos.Text = twos.ToString();
        }

        private void OnThreesClick(object sender, RoutedEventArgs e)
        {
            int[] dice = { Int32.Parse(diceOne.Text), Int32.Parse(diceTwo.Text), Int32.Parse(diceThree.Text), Int32.Parse(diceFour.Text), Int32.Parse(diceFive.Text) };
            int threes = 0;
            for (int i = 0; i < dice.Length; i++)
            {
                if (dice[i] == 3)
                {
                    threes += 3;
                }
            }
            txtThrees.Text = threes.ToString();
        }

        private void OnFoursClick(object sender, RoutedEventArgs e)
        {
            int[] dice = { Int32.Parse(diceOne.Text), Int32.Parse(diceTwo.Text), Int32.Parse(diceThree.Text), Int32.Parse(diceFour.Text), Int32.Parse(diceFive.Text) };
            int fours = 0;
            for (int i = 0; i < dice.Length; i++)
            {
                if (dice[i] == 4)
                {
                    fours += 4;
                }
            }
            txtFours.Text = fours.ToString();
        }

        private void OnFivesClick(object sender, RoutedEventArgs e)
        {
            int[] dice = { Int32.Parse(diceOne.Text), Int32.Parse(diceTwo.Text), Int32.Parse(diceThree.Text), Int32.Parse(diceFour.Text), Int32.Parse(diceFive.Text) };
            int fives = 0;
            for (int i = 0; i < dice.Length; i++)
            {
                if (dice[i] == 5)
                {
                    fives += 5;
                }
            }
            txtFives.Text = fives.ToString();
        }

        private void OnSixesClick(object sender, RoutedEventArgs e)
        {
            int[] dice = { Int32.Parse(diceOne.Text), Int32.Parse(diceTwo.Text), Int32.Parse(diceThree.Text), Int32.Parse(diceFour.Text), Int32.Parse(diceFive.Text) };
            int sixes = 0;
            for (int i = 0; i < dice.Length; i++)
            {
                if (dice[i] == 6)
                {
                    sixes += 6;
                }
            }
            txtSixes.Text = sixes.ToString();
        }
    }
}