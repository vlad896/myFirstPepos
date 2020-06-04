using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp25
{
    /// <summary>
    /// Логика взаимодействия для Register.xaml
    /// </summary>
    public partial class Register : Window
    {
        //static string connctString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='|DataDirectory|Database1.mdf';Integrated Security=True";
        //SqlCommand command;
        //SqlConnection connection = new SqlConnection(connctString);
        //SqlDataReader reader = null;
        public Register()
        {
            InitializeComponent();
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
            if (Cpass.Password!=Pass)
            {
                MessageBox.Show("Пароли должны совпадать","Error",MessageBoxButton.OK,MessageBoxImage.Error);
                return;
            }
            
            if (FemaleRadio.IsChecked == false && MaleRadio.IsChecked == false)
            {
                MessageBox.Show("Выберите свой гендер");
                return;
            }
            DateTime dt;
            if (DateTime.TryParse(TextBoxTime.Text, out dt))
            {

            }
            else
            {
                MessageBox.Show("Дата введена неправиьно");
                return;
            }
            string connctString = "DataSource=Table.db; Version=3";
            SQLiteCommand command;
            SQLiteConnection connection = new SQLiteConnection(connctString);
            SQLiteDataReader reader;
            string gender = "";
            if (FemaleRadio.IsChecked==true)
            {
                gender = TextFMale.Text;
            }
            if (MaleRadio.IsChecked==true)
            {
                gender = TextMale.Text;
            }
            connection = new SQLiteConnection(connctString);
            connection.Open();
            string query = $"INSERT INTO [Tablues] (Email,Password, Name , Surname, BD, Country ,Sex) VALUES( '{EmailTextbox.Text}', '{Password.Password}'," +
                $" '{NameTextBox.Text}', '{SurTextBox.Text}', '{TextBoxTime.Text}', '{CountryCombo.Text}', '{gender}')";
            command =new SQLiteCommand(query, connection);

            command.ExecuteNonQuery();

            this.Hide();
            MainWindow MainWindow = new MainWindow();
            MainWindow.Show();
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
        }
    }
}
