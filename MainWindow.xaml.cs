using System;
using System.Threading;
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
        //public string userwin;
        public MainWindow()
        {
            InitializeComponent();
        }
        System.Windows.Threading.DispatcherTimer dispatcherTimer = new System.Windows.Threading.DispatcherTimer();
        private void test()
        {
            dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 1);
            dispatcherTimer.Start();
        }

        private void dispatcherTimer_Tick(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        // через определенное время записываем в реестр
        public static void Count(object obj)
        {
            int x = (int)obj;
            proverka.SetExecutingBeforeKey("IS_EXECUTING_BEFORE_KEY",x.ToString());
        }
        private void GenRand_Click(object sender, RoutedEventArgs e)
        {
            int num = 0;
            // устанавливаем метод обратного вызова
            TimerCallback tm = new TimerCallback(Count);
            // создаем таймер на 4 секунды
            Timer timer = new Timer(tm, num, 0, 4000);

            Console.ReadLine();
            userreestr.Text = proverka.IsExecutingBefore("IS_EXECUTING_BEFORE_KEY","30" ).ToString();
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
           
        }

        private void UserNumber_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void RandomNumber_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
