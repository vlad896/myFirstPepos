using Microsoft.Win32;
using System.Data.SQLite;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
namespace WpfApp25
{
    public partial class Print : Window
    {
        static string connctString = "DataSource=Table.db; Version=3";
        SQLiteCommand command;
        SQLiteConnection connection = new SQLiteConnection(connctString);
        SQLiteDataReader reader;

        public Print()
        {
            InitializeComponent();
        }
        string email, pass;
        public Print(string Email, string Pass, string Dist, string Pocket, string Sum)
        {
            InitializeComponent();
            email = Email;
            pass = Pass;
            EmailTextbox.Text = email;
            DistaTextBox.Text = Dist;
            PoketTextBox.Text = Pocket;
            CountTextBox.Text = Sum + " $";
        }
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                this.DragMove();
            }
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            string query = $"SELECT * FROM [Tablues] WHERE Email='{email}' AND Password= '{pass}'";
            command = new SQLiteCommand(query, connection);
            connection.Open();
            reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    EmailTextbox.Text = reader[1].ToString();
                    Password.Text = reader[2].ToString();
                    NameTextBox.Text = reader[3].ToString();
                    SurTextBox.Text = reader[4].ToString();
                    BDTextBox.Text = reader[5].ToString();
                    CountryTextBox.Text = reader[6].ToString();
                }
                reader.Close();
            }
            reader.Close();
        }
        private void EmailButton_Click(object sender, RoutedEventArgs e)
        {
            MailAddress From = new MailAddress("marathon.f01@gmail.com", "Fedorvich Vlad 35ТП");
            MailAddress To = new MailAddress($"{EmailTextbox.Text}");
            MailMessage message = new MailMessage(From, To);
            message.Subject = "Half Marathon 2020";
            message.Body = $"Информация о регистрации\n" +
                        $" Email = {EmailTextbox.Text}\n" +
                        $" Пароль = {Password.Text}\n" +
                        $" Имя = {NameTextBox.Text}\n" +
                        $" Фамилия = {SurTextBox.Text}\n" +
                        $" Дата рождения = {BDTextBox.Text}\n" +
                        $" Страна = {CountryTextBox.Text}\n" +
                        $" Дистанция = {DistaTextBox.Text}\n" +
                        $" Вариат комплекта = {PoketTextBox.Text}\n" +
                        $" Итог= {CountTextBox.Text}\n ";
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
            smtpClient.Credentials = new NetworkCredential("marathon.f01@gmail.com", "vlad_6675041");
            smtpClient.EnableSsl = true;
            smtpClient.Send(message);
            MessageBox.Show("OK");
        }
        string pring = "";
        private void PrintButton_Click(object sender, RoutedEventArgs e)
        {
            PrintDialog printDlg = new PrintDialog();
            FlowDocument doc = new FlowDocument(new Paragraph(new Run(pring)));
            doc.Name = "Information_about_Half_Marathon_2020";
            IDocumentPaginatorSource idpSource = doc;
            pring = $"Информация о регистрации\n" +
                       $" Email = {EmailTextbox.Text}\n" +
                       $" Пароль = {Password.Text}\n" +
                       $" Имя = {NameTextBox.Text}\n" +
                       $" Фамилия = {SurTextBox.Text}\n" +
                       $" Дата рождения = {BDTextBox.Text}\n" +
                       $" Страна = {CountryTextBox.Text}\n" +
                       $" Дистанция = {DistaTextBox.Text}\n" +
                       $" Вариат комплекта = {PoketTextBox.Text}\n" +
                       $" Итог= {CountTextBox.Text}\n ";
            printDlg.PrintDocument(idpSource.DocumentPaginator,"Hello");
        }
        private void File_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "(*.txt)|*.txt";
            pring = $"Информация о регистрации\n" +
                       $" Email = {EmailTextbox.Text}\n" +
                       $" Пароль = {Password.Text}\n" +
                       $" Имя = {NameTextBox.Text}\n" +
                       $" Фамилия = {SurTextBox.Text}\n" +
                       $" Дата рождения = {BDTextBox.Text}\n" +
                       $" Страна = {CountryTextBox.Text}\n" +
                       $" Дистанция = {DistaTextBox.Text}\n" +
                       $" Вариат комплекта = {PoketTextBox.Text}\n" +
                       $" Итог= {CountTextBox.Text}\n ";
            if (saveFileDialog.ShowDialog()==true)
            {
                using (StreamWriter sw = new StreamWriter(saveFileDialog.OpenFile(),System.Text.Encoding.Default))
                {
                    sw.Write(pring);
                    sw.Close();
                }
            }
        }
        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            RunnerMenu runnerMenu = new RunnerMenu(email,pass);
            runnerMenu.Show();
        }
        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            RegForMar regForMar = new RegForMar();
            regForMar.Show();
        }
        private void TextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
