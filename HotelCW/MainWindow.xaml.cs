using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HotelCW
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Hotel hotel;
        List<User> clients;
        public MainWindow()
        {
            InitializeComponent();
            hotel = new Hotel();
            clients = new List<User>() { 
                new User() {Name="Efim", LastName="Kopyl", Password="1234" },
                new User() {Name="Sergei", LastName="Valko", Password="1111" },
                new User() {Name="Kazimir", LastName="Kantor", Password="2222" },
                new User() {Name="Ivan", LastName="Grishin", Password="0000" }
            };
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            int check = 0;
            foreach (User client in clients)
            {
                if (txtUsername.Text == (client.Name + " " + client.LastName) && txtPassword.Password == client.Password)
                {
                    Registration registration = new Registration(client,hotel);
                    registration.Show();
                }
                else
                {
                    check++;
                    
                }
            }
            if (check == clients.Count) 
            {
                MessageBox.Show("Wrong input or there is no account with such name. \nTry to register.", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                txtPassword.Clear();
                txtUsername.Clear();
            }
            txtPassword.Clear();
            txtUsername.Clear();
            //MessageBox.Show("Invalid input. Try again.");
        }
        private void TxtPassword_OnKeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key != System.Windows.Input.Key.Enter) return;

            e.Handled = true;
            btnSubmit_Click(sender, e);
        }

        private void VKlink_Click(object sender, RoutedEventArgs e)
        {
            Process.Start("https://vk.com/e.kopyl");
        }

        private void MetanitLink_Click(object sender, RoutedEventArgs e)
        {
            Process.Start("https://metanit.com/sharp/wpf/");
        }

        private void change_Login_Click(object sender, RoutedEventArgs e)
        {

        }

        private void register_Click(object sender, RoutedEventArgs e)
        {
            User newClient = new User();
            string[] x = txtUsername.Text.Split();
            newClient.Name = x[0];
            newClient.LastName = x[1];
            newClient.Password = txtPassword.Password;
            clients.Add(newClient);
            MessageBox.Show("Welcome to the hotel!");
            Registration registration = new Registration(newClient, hotel);
            registration.Show();
        }
    }
}
