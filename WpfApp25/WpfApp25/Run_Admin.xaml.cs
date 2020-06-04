using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
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
    /// Логика взаимодействия для Run_Admin.xaml
    /// </summary>
    public partial class Run_Admin : Window
    {
        
        private ObservableCollection<ToDoModel> _todoData = new ObservableCollection<ToDoModel>();
        static string connctString = "DataSource=Table.db; Version=3";
        SQLiteCommand command;
        SQLiteConnection connection = new SQLiteConnection(connctString);
        SQLiteDataReader reader;
        public Run_Admin()
        {
            InitializeComponent();
        }
        public void ReadToBD()
        {
            dataGrid.ItemsSource = null;
            string query;
            connection = new SQLiteConnection(connctString);
            connection.Open();
            query = "SELECT * FROM [Tablues]";
            command = new SQLiteCommand(query, connection);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                _todoData.Add(new ToDoModel() { ID = Convert.ToInt32(reader[0]), Email = reader[1].ToString(), Pass = reader[2].ToString(), Cpass = reader[2].ToString(), Name = reader[3].ToString(), Surname = reader[4].ToString(), BD = reader[5].ToString(), Country = reader[6].ToString(), Sex = reader[7].ToString() });
            }
            dataGrid.ItemsSource = _todoData;
            _todoData.CollectionChanged += _todoData_CollectionChanged;
            reader.Close();
        }

        private void _todoData_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {

        }

        public void CountUsers()
        {
            string query = "select COUNT(Id) from Tablues";
            command = new SQLiteCommand(query, connection);
            connection.Open();
            reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    CountsUsers.Text = reader[0].ToString();
                }
                reader.Close();
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
        }
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            CountUsers();
            ReadToBD();
        }

        private void dataGrid_Sorting(object sender, DataGridSortingEventArgs e)
        {

        }

        private void ADD_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            RegisterAdmin register = new RegisterAdmin();
            register.Show();
        }

        private void Refresh_Click(object sender, RoutedEventArgs e)
        {
            dataGrid.Items.Refresh();
        }

        private void Del_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            DELLAdmin removeAdmin = new DELLAdmin(_todoData[dataGrid.SelectedIndex].ID);
            removeAdmin.Show();
        }

        private void Remove_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            RemoveAdmin removeAdmin = new RemoveAdmin(_todoData[dataGrid.SelectedIndex].ID);
            removeAdmin.Show();
        }

        private void Remove_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
