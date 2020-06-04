using System.Data.SQLite;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Input;
namespace WpfApp25
{

    public partial class Remove : Window
    {
        public Remove()
        {
            InitializeComponent();
        }
        string email, pass;
        public Remove(string Email, string Passwordt)
        {
            InitializeComponent();
            email = Email;
            pass = Passwordt;
            EmailTextbox.Text = email;
            Password.Password = pass;
            Cpass.Password = pass;
        }
        static string connctString = "DataSource=Table.db; Version=3";
        SQLiteCommand command;
        SQLiteConnection connection = new SQLiteConnection(connctString);
        SQLiteDataReader reader;
        private void TextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Application.Current.Shutdown();
        }
        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            RunnerMenu runnerMenu = new RunnerMenu(email, pass);
            runnerMenu.Show();
        }
        private void RegButton_Click(object sender, RoutedEventArgs e)
        {
            string Email = EmailTextbox.Text;
            string Pass = Password.Password;
            if (Email == "" || Pass == "" || Cpass.Password == "" || NameTextBox.Text == "" || SurTextBox.Text == "" || TextBoxTime.Text == "" || CountryCombo.Text == "")
            {
                MessageBox.Show("Поля для заполнения не должны быть пустыми");
                return;
            }
            string cond = @"(\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*)";
            if (!Regex.IsMatch(Email, cond))
            {
                MessageBox.Show("Введите корректно email");
                return;
            }
            if (Pass.Length < 8)
            {
                MessageBox.Show("Пароль должен быть не менее 8 символов");
                return;
            }
            if (Cpass.Password != Pass)
            {
                MessageBox.Show("Пароли должны совпадать", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (FemaleRadio.IsChecked == false && MaleRadio.IsChecked == false)
            {
                MessageBox.Show("Выберите свой гендер");
                return;
            }
            string gender = "";
            if (FemaleRadio.IsChecked == true)
            {
                gender = TextFMale.Text;
            }
            if (MaleRadio.IsChecked == true)
            {
                gender = TextMale.Text;
            }
            string query = $"UPDATE [Tablues] SET " +
                $"Email='{EmailTextbox.Text}', " +
                $"Password= '{Password.Password}', " +
                $"Name='{NameTextBox.Text}', " +
                $"Surname='{SurTextBox.Text}', " +
                $"BD='{TextBoxTime.Text}', " +
                $"Country='{CountryCombo.Text}', " +
                $"Sex='{gender}' "+
                $"WHERE Id='{IDLable.Text}'";
            command = new SQLiteCommand(query, connection);
            reader.Close();
            command.ExecuteNonQuery();
            MessageBox.Show("Операция прошла успешно \n Для большей безопасности Вам нужно ещё раз авторизоваться","",MessageBoxButton.OK,MessageBoxImage.Information);
            this.Hide();
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
        }
        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            RunnerMenu runnerMenu = new RunnerMenu(email, pass);
            runnerMenu.Show();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            string query = $"SELECT * FROM [Tablues] WHERE Email='{email}' AND Password= '{pass}'";
            command = new SQLiteCommand(query,connection);
            connection.Open();
            reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    IDLable.Text = reader[0].ToString();
                    EmailTextbox.Text = reader[1].ToString();
                    Password.Password = reader[2].ToString();
                    Cpass.Password = reader[2].ToString();
                    NameTextBox.Text = reader[3].ToString();
                    SurTextBox.Text = reader[4].ToString();
                    TextBoxTime.Text = reader[5].ToString();
                    CountryCombo.Text = reader[6].ToString();
                }
            reader.Close();
            }
            reader.Close();
            
        }
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                this.DragMove();
            }
        }
    }
}
