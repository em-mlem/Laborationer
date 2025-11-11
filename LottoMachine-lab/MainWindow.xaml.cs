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

        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnCheckClick(object sender, RoutedEventArgs e)
        {
            TextBox[] boxes = { txt1, txt2, txt3, txt4, txt5, txt6, txt7 };

            int[] userRow = new int[7];
            int[] drawRow = new int[7];

            for(int i = 0; i<boxes.Length; i++)
            {
                string text = boxes[i].Text.Trim();

                int value;
                if(!int.TryParse(text, out value))
                {
                    txtMatches.Text = "Alla rutor måste innehålla heltal.";
                    return;
                }

                if(value<1||value>35)
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

            for(int i = 0; i < drawRow.Length; i++)
            {
                int randomNumber;
                bool alreadyExists;

                do
                {
                    randomNumber = _random.Next(1, 36);
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
            for (int i = 0; i < userRow.Length; i++)
            {
                for (int j = 0; j < drawRow.Length; j++)
                {
                    if (userRow[i] == drawRow[j])
                    {
                        matches++;
                        break;
                    }
                }

            }

            string userText = "Din rad: ";
            for (int i = 0; i < userRow.Length; i++)
            {
                userText += userRow[i];
                if (i < userRow.Length-1)
                {
                    userText += ", ";
                }
            }

            string drawText = "Vinnarrad: ";
            for (int i = 0; i < drawRow.Length; i++)
            {
                drawText += drawRow[i];
                if (i < drawRow.Length - 1)
                {
                    drawText += ", ";
                }
            }
            txtUserRow.Text = userText;
            txtDrawRow.Text = drawText;
            txtMatches.Text = $"Du fick {matches} rätt.";
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