using System.Data.SQLite;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Input;

namespace WpfApp25
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        static string connctString = "DataSource=Table.db; Version=3";
        SQLiteCommand command;
        SQLiteConnection connection = new SQLiteConnection(connctString);
        SQLiteDataReader reader;
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                this.DragMove();
            }
        }
        private void TextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Application.Current.Shutdown();
        }
        private void PackIconMaterial_MouseDown(object sender, MouseButtonEventArgs e)
        {
            text.Text = pass.Password;
            text.Visibility = Visibility.Visible ^ pass.Visibility;
            pass.Visibility = Visibility.Hidden ^ text.Visibility;
        }
        private void TextBlock_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            this.Hide();
            Register redister = new Register();
            redister.Show();
        }
        private void TextBlock_MouseDown_2(object sender, MouseButtonEventArgs e)
        {
            this.Hide();
            Register register = new Register();
            register.Show();
        }
        private void RegButton_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Register register = new Register();
            register.Show();
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Hide();
            WinWelcom winWelcom = new WinWelcom();
            winWelcom.Show();
        }
        private void ButtonLogin_Click(object sender, RoutedEventArgs e)
        {
            string Email = EmailTextbox.Text;
            string Pass = pass.Password;
            if (Email == "Admin" && Pass == "Admin")
            {
                this.Hide();
                Run_Admin run = new Run_Admin();
                run.Show();
            }
            else
            {
                
                string query = $"SELECT * FROM [Tablues] WHERE Email='{Email}' AND Password='{Pass}' ";
                command = new SQLiteCommand(query, connection);
                connection.Open();
                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    MessageBox.Show("Операция завершина успешно");
                    reader.Close();
                    this.Hide();
                    RunnerMenu runnerMenu = new RunnerMenu(Email,Pass);
                    runnerMenu.Show();
                }
                else
                {
                    MessageBox.Show("Error");
                    connection.Close();
                    return;
                }
                connection.Close();
            }
        }
    }
}
