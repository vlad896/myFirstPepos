using System.Windows;
using System.Windows.Input;
namespace WpfApp25
{
    public partial class Contacts : Window
    {
        public Contacts()
        {
            InitializeComponent();
        }
        string email, pass;
        public Contacts(string Email, string Pass)
        {
            InitializeComponent();
            email = Email;
            pass = Pass;
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
            this.Close();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            RunnerMenu runnerMenu = new RunnerMenu(email,pass);
            runnerMenu.Show();
        }
    }
}
