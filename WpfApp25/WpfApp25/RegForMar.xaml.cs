using System.Data.SQLite;
using System.Windows;
using System.Windows.Input;

namespace WpfApp25
{
    public partial class RegForMar : Window
    {
        public int Sum { get; set; }
        const int FullAmount = 145;
        const int HalfAmount = 75;
        const int ShortAmount = 20;
        const int OptionBAmount = 20;
        const int OptionCAmount = 45;
        public RegForMar()
        {
            InitializeComponent();
            SmallMar.IsChecked = true;
            VersionA.IsChecked = true;
        }
       public string email, pass;
        public RegForMar(string Email, string Pass)
        {
            InitializeComponent();
            email = Email;
            pass = Pass;
        }
        private void TextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Application.Current.Shutdown();
        }
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            
            if (e.LeftButton==MouseButtonState.Pressed)
            {
                this.DragMove();
            }
        }
        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            RunnerMenu runnerMenu = new RunnerMenu(email,pass);
            runnerMenu.Show();
        }
        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            RunnerMenu runnerMenu = new RunnerMenu(email,pass);
            runnerMenu.Show();
        }
        private void VersionB_Checked(object sender, RoutedEventArgs e)
        {
            if (VersionB.IsChecked == true)
            {
                Sum += OptionBAmount;
                Price.Text = "$" + Sum.ToString();
            }
        }
        private void VersionB_Unchecked(object sender, RoutedEventArgs e)
        {
            if (VersionB.IsChecked == false)
            {
                Sum -= OptionBAmount;
                Price.Text = "$" + Sum.ToString();
            }
        }
        private void VersionC_Checked(object sender, RoutedEventArgs e)
        {
            if (VersionC.IsChecked == true)
            {
                Sum += OptionCAmount;
                Price.Text = "$" + Sum.ToString();
            }
        }
        private void VersionC_Unchecked(object sender, RoutedEventArgs e)
        {
            if (VersionC.IsChecked == false)
            {
                Sum -= OptionCAmount;
                Price.Text = "$" + Sum.ToString();
            }
        }
        private void FullMar_Checked(object sender, RoutedEventArgs e)
        {
            if (FullMar.IsChecked == true)
            {
                Sum += FullAmount;
                Price.Text = "$" + Sum.ToString();
            }
        }
        private void FullMar_Unchecked(object sender, RoutedEventArgs e)
        {
            if (FullMar.IsChecked == false)
            {
                Sum -= FullAmount;
                Price.Text = "$" + Sum.ToString();
            }
        }
        private void HalfMar_Checked(object sender, RoutedEventArgs e)
        {
            if (HalfMar.IsChecked == true)
            {
                Sum += HalfAmount;
                Price.Text = "$" + Sum.ToString();
            }
        }
        private void HalfMar_Unchecked(object sender, RoutedEventArgs e)
        {
            if (HalfMar.IsChecked == false)
            {
                Sum -= HalfAmount;
                Price.Text = "$" + Sum.ToString();
            }
        }
        private void SmallMar_Checked(object sender, RoutedEventArgs e)
        {
            if (SmallMar.IsChecked == true)
            {
                Sum += ShortAmount;
                Price.Text = "$" + Sum.ToString();
            }
        }
        private void SmallMar_Unchecked(object sender, RoutedEventArgs e)
        {
            if (SmallMar.IsChecked == false)
            {
                Sum -= ShortAmount;
                Price.Text = "$" + Sum.ToString();
            }
        }
        private void RegButton_Click(object sender, RoutedEventArgs e)
        {
            string dist = "";
            string ver = "";
            if (SmallMar.IsChecked==true)
            {
                dist = SmallMar.Content.ToString();
            }
            if (HalfMar.IsChecked == true)
            {
                dist = HalfMar.Content.ToString();
            }
            if (FullMar.IsChecked == true)
            {
                dist = FullMar.Content.ToString();
            }
            if (VersionA.IsChecked == true)
            {
                ver = V1.Text;
            }
            if (VersionB.IsChecked == true)
            {
                ver = V2.Text;
            }
            if (VersionC.IsChecked == true)
            {
                ver = V3.Text;
            }
            string connctString = "DataSource=Table.db; Version=3";
            SQLiteCommand command;
            SQLiteConnection connection = new SQLiteConnection(connctString);
            connection = new SQLiteConnection(connctString);
            connection.Open();
            string query = $"INSERT INTO [Event] (Distan,Ver, Sum) VALUES( '{dist}', '{ver}'," +
                $" '{Sum.ToString()}')";
            command = new SQLiteCommand(query, connection);
            command.ExecuteNonQuery();
            this.Hide();
            Print print = new Print(email, pass, dist, ver, Sum.ToString()); 
            print.Show();
        }
    }
}
