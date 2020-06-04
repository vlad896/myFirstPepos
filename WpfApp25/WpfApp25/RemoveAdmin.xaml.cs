using System;
using System.Collections.Generic;
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
    /// Логика взаимодействия для RemoveAdmin.xaml
    /// </summary>
    public partial class RemoveAdmin : Window
    {
        public RemoveAdmin()
        {
            InitializeComponent();
        }
        int id;
        public RemoveAdmin(int ID)
        {
            InitializeComponent();
            id = ID;
            TextID.Text = id.ToString();
        }
        static string connctString = "DataSource=Table.db; Version=3";
        SQLiteCommand command;
        SQLiteConnection connection = new SQLiteConnection(connctString);
        SQLiteDataReader reader;
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
                $"Sex='{gender}' " +
                $"WHERE Id='{IDLable.Text}'";
            command = new SQLiteCommand(query, connection);
            reader.Close();
            command.ExecuteNonQuery();
            this.Hide();
            Run_Admin mainWindow = new Run_Admin();
            mainWindow.Show();
        }
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                this.DragMove();
            }
        }

        private void TextBlock_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Run_Admin runnerMenu = new Run_Admin();
            runnerMenu.Show();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            string query = $"SELECT * FROM [Tablues] WHERE Id='{id}'";
            command = new SQLiteCommand(query, connection);
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
    }
}
