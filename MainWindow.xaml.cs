using System.Threading;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace shambalaWpfWorkReestr_11_11_2023
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        userTimer timer = new userTimer();
        //public string userwin;
        public MainWindow()
        { 
            InitializeComponent();
            userTimer.TimeUser();
        }

        private void GenRand_Click(object sender, RoutedEventArgs e)
        {
            userreestr.Text = proverka.IsExecutingBefore("IS_EXECUTING_BEFORE_KEY","yes" ).ToString();
            randomNumbers randomNumbers = new randomNumbers();
            RandomNumber.Text = randomNumbers.getRand(10).ToString();
            if (UserNumber.Text == RandomNumber.Text)
            {
                userwin.Text = "вы выиграли";
                userwin.Background = Brushes.Red;
            }
            else
            {
                userwin.Text = "вы проиграли";
                userwin.Background = Brushes.Violet;
            }
            
        }

        private void NewGame_Click(object sender, RoutedEventArgs e)
        {
            proverka.SetExecutingBeforeKey("IS_EXECUTING_BEFORE_KEY", "yes");
        }

        private void UserNumber_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void RandomNumber_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
