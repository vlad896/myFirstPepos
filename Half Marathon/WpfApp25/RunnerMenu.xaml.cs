using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows;
using System.Timers;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.ComponentModel;
using System.Data.SQLite;

namespace WpfApp25
{
    /// <summary>
    /// Логика взаимодействия для RunnerMenu.xaml
    /// </summary>
    public partial class RunnerMenu : Window, INotifyPropertyChanged
    {
        public string Times
        {
            get
            {
                DateTime dt1 = DateTime.Now;
                DateTime dt2 = DateTime.Parse("2020-09-13 9:00");

                TimeSpan timeSpan = dt2 - dt1;
                return string.Format("{0} дн {1} ч {2} минут {3} сек до старта марафона", timeSpan.Days, timeSpan.Hours, timeSpan.Minutes, timeSpan.Seconds);
            }
        }
        public RunnerMenu()
        {
            InitializeComponent();
            this.DataContext = this;
        }
        string email, pass;
        public RunnerMenu(string Email, string Password)
        {
            InitializeComponent();
            this.DataContext = this;
            email = Email;
            pass = Password;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void PropertyChange(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }


        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton==MouseButtonState.Pressed)
            {
                this.DragMove();
            }
        }

        private void TextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Application.Current.Shutdown();

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            System.Timers.Timer timer = new System.Timers.Timer();
            timer.Interval = 100;
            timer.Elapsed += Timer_Elapsed;
            timer.Start();
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            PropertyChange("Times");
        }

        private void RegButton_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            RegForMar regForMar = new RegForMar(email, pass);
            regForMar.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Remove remove = new Remove(email,pass);
            remove.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Contacts contacts = new Contacts(email, pass);
            contacts.Show();
        }

        private void Infaboutevent_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            informaboutevent informaboutevent = new informaboutevent(email, pass);
            informaboutevent.Show();
        }

        private void SponsorsButton_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Sponsors sponsors = new Sponsors(email, pass);
            sponsors.Show();
        }

        private void MyResult_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Марафон ещё не начался", "Information!!!", MessageBoxButton.OK,MessageBoxImage.Information);
        }

        private void BMR_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            BMR button = new BMR(email, pass);
            button.Show();
        }

        private void BMI_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            BMI button = new BMI(email, pass);
            button.Show();
        }

        private void Log_outButton_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
        }
    }
}
