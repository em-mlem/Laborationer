using System.Windows;
using System.Windows.Controls;

namespace LottoMachine_lab
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

        private void OnCheckClick(object sender, RoutedEventArgs e)
        {
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