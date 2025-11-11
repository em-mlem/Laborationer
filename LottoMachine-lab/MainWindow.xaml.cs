using System.Windows;
using System.Windows.Controls;

namespace LottoMachine_lab
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly Random _random = new Random();

        private const int NumbersPerRow = 7;
        private const int MinNumber = 1;
        private const int MaxNumber = 35;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnCheckClick(object sender, RoutedEventArgs e)
        {
            TextBox[] boxes = { txt1, txt2, txt3, txt4, txt5, txt6, txt7 };

            int[] userRow = new int[NumbersPerRow];
            int[] drawRow = new int[NumbersPerRow];

            for(int i = 0; i < NumbersPerRow; i++)
            {
                string text = boxes[i].Text.Trim();

                int value;
                if(!int.TryParse(text, out value))
                {
                    txtMatches.Text = "Alla rutor måste innehålla heltal.";
                    return;
                }

                if(value<MinNumber||value>MaxNumber)
                {
                    txtMatches.Text = "Alla tal måste vara mellan 1 och 35.";
                    return;  
                }

                for(int j = 0; j < i; j++)
                {
                    if (userRow[j] == value)
                    {
                        txtMatches.Text = "Du får inte skriva samma tal flera gånger";
                        return;
                    }
                }
               
                userRow[i] = value;

            }

            for(int i = 0; i < NumbersPerRow; i++)
            {
                int randomNumber;
                bool alreadyExists;

                do
                {
                    randomNumber = _random.Next(MinNumber, MaxNumber + 1);
                    alreadyExists = false;

                    for (int j = 0; j < i; j++)
                    {
                        if (drawRow[j] == randomNumber)
                        {
                            alreadyExists = true;
                            break;
                        }
                    }
                }
                while (alreadyExists);

                drawRow[i] = randomNumber;
            }

            Array.Sort(userRow);
            Array.Sort(drawRow);

            int matches = 0;
            for (int i = 0; i < NumbersPerRow; i++)
            {
                for (int j = 0; j < NumbersPerRow; j++)
                {
                    if (userRow[i] == drawRow[j])
                    {
                        matches++;
                        break;
                    }
                }

            }

            string userText = "Din rad: ";
            for (int i = 0; i < NumbersPerRow; i++)
            {
                userText += userRow[i];
                if (i < NumbersPerRow - 1)
                {
                    userText += ", ";
                }
            }

            string drawText = "Vinnarrad: ";
            for (int i = 0; i < NumbersPerRow; i++)
            {
                drawText += drawRow[i];
                if (i < NumbersPerRow - 1)
                {
                    drawText += ", ";
                }
            }
            txtUserRow.Text = userText;
            txtDrawRow.Text = drawText;
            txtMatches.Text = $"Du fick {matches} rätt.";
        }

        private void OnSimulateClick(object sender, RoutedEventArgs e)
        {
            TextBox[] boxes = { txt1, txt2, txt3, txt4, txt5, txt6, txt7 };
            int[] userRow = new int[NumbersPerRow];

            for (int i = 0; i < NumbersPerRow; i++)
            {
                string text = boxes[i].Text.Trim();

                int value;
                if (!int.TryParse(text, out value))
                {
                    txtMatches.Text = "Alla rutor måste innehålla heltal.";
                    return;
                }

                if (value < MinNumber || value > MaxNumber)
                {
                    txtMatches.Text = $"Alla tal måste vara mellan {MinNumber} och {MaxNumber}.";
                    return;
                }

                for (int j = 0; j < i; j++)
                {
                    if (userRow[j] == value)
                    {
                        txtMatches.Text = "Du får inte skriva samma tal flera gånger.";
                        return;
                    }
                }

                userRow[i] = value;
            }

            Array.Sort(userRow);

            long attempts = 0;
            int[] drawRow = new int[NumbersPerRow];
            bool gotSeven;

            do
            {
                attempts++;

                for (int i = 0; i < NumbersPerRow; i++)
                {
                    int randomNumber;
                    bool alreadyExists;

                    do
                    {
                        randomNumber = _random.Next(MinNumber, MaxNumber + 1);
                        alreadyExists = false;

                        for (int j = 0; j < i; j++)
                        {
                            if (drawRow[j] == randomNumber)
                            {
                                alreadyExists = true;
                                break;
                            }
                        }
                    } while (alreadyExists);

                    drawRow[i] = randomNumber;
                }

                Array.Sort(drawRow);

                gotSeven = true;
                for (int i = 0; i < NumbersPerRow; i++)
                {
                    if (userRow[i] != drawRow[i])
                    {
                        gotSeven = false;
                        break;
                    }
                }
            }
            while (!gotSeven);

            string userText = "Din rad: ";
            for (int i = 0; i < NumbersPerRow; i++)
            {
                userText += userRow[i];
                if (i < NumbersPerRow - 1)
                {
                    userText += ", ";
                }
            }

            string drawText = "Vinnarrad: ";
            for (int i = 0; i < NumbersPerRow; i++)
            {
                drawText += drawRow[i];
                if (i < NumbersPerRow - 1)
                {
                    drawText += ", ";
                }
            }

            double weeksExact = attempts / 2.0;
            long weeks = (long)Math.Ceiling(weeksExact);

            double yearsExact = weeks / 52.0;
            long years = (long)Math.Ceiling(yearsExact);

            txtUserRow.Text = userText;
            txtDrawRow.Text = drawText;
            txtMatches.Text =
                $"Efter {attempts:N0} dragningar fick du 7 rätt.\n" +
                $"Det motsvarar cirka {years:N0} år.";
        }

        private void OnClearClick(object sender, RoutedEventArgs e)
        {
            TextBox[] boxes = { txt1, txt2, txt3, txt4, txt5, txt6, txt7 };
            foreach (TextBox box in boxes)
            {
                box.Clear();
            }
            txtUserRow.Text = "Din rad:";
            txtDrawRow.Text = "Vinnarrad:";
            txtMatches.Text = string.Empty;
        }
    }
}