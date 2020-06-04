using System;
using System.Collections.Generic;
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
    /// Логика взаимодействия для informaboutevent.xaml
    /// </summary>
    public partial class informaboutevent : Window
    {
        public informaboutevent()
        {
            InitializeComponent();
        }
        string email, pass;
        public informaboutevent(string Email, string Pass)
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
            Application.Current.Shutdown();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            RunnerMenu runnerMenu = new RunnerMenu(email, pass) ;
            runnerMenu.Show();
        }

        private void Image_MouseEnter(object sender, MouseEventArgs e)
        {
            var uriImageSource = new Uri(@"/WpfApp25;component/Photo/2.JPG", UriKind.RelativeOrAbsolute);
            Photo.Source = new BitmapImage(uriImageSource);
        }

        private void Image_MouseEnter_1(object sender, MouseEventArgs e)
        {
            var uriImageSource = new Uri(@"/WpfApp25;component/Photo/3.JPG", UriKind.RelativeOrAbsolute);
            Photo.Source = new BitmapImage(uriImageSource);
        }

        private void Image_MouseEnter_2(object sender, MouseEventArgs e)
        {
            var uriImageSource = new Uri(@"/WpfApp25;component/Photo/4.JPG", UriKind.RelativeOrAbsolute);
            Photo.Source = new BitmapImage(uriImageSource);
        }

        private void Image_MouseEnter_3(object sender, MouseEventArgs e)
        {
            var uriImageSource = new Uri(@"/WpfApp25;component/Photo/7.JPG", UriKind.RelativeOrAbsolute);
            Photo.Source = new BitmapImage(uriImageSource);

        }

        private void Image_MouseEnter_4(object sender, MouseEventArgs e)
        {
            var uriImageSource = new Uri(@"/WpfApp25;component/Photo/8.PNG", UriKind.RelativeOrAbsolute);
            Photo.Source = new BitmapImage(uriImageSource);
        }

        private void Image_MouseEnter_5(object sender, MouseEventArgs e)
        {
            var uriImageSource = new Uri(@"/WpfApp25;component/Photo/9.PNG", UriKind.RelativeOrAbsolute);
            Photo.Source = new BitmapImage(uriImageSource);
        }

        private void Image_MouseEnter_6(object sender, MouseEventArgs e)
        {
            var uriImageSource = new Uri(@"/WpfApp25;component/Photo/10.PNG", UriKind.RelativeOrAbsolute);
            Photo.Source = new BitmapImage(uriImageSource);
        }
    }
}
