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
        List<User> clients;
        public MainWindow()
        {
            InitializeComponent();
            clients = new List<User>() { 
                new User() {Name="Efim", LastName="Kopyl", Password="1234" },
                new User() {Name="Sergei", LastName="Valko", Password="1111" },
                new User() {Name="Kazimir", LastName="Kantor", Password="2222" },
                new User() {Name="Ivan", LastName="Grishin", Password="0000" }
            };
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            
            foreach (User client in clients)
            {
                if (txtUsername.Text == (client.Name + " " + client.LastName) && txtPassword.Password == client.Password)
                {
                    Registration registration = new Registration(client);
                    registration.Show();
                    this.Close();
                }
                else
                {
                    txtPassword.Clear();
                    txtUsername.Clear();
                }
            }
            
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
    }
}
