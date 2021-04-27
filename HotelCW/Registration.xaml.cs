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

namespace HotelCW
{
    /// <summary>
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {
        Hotel myHotel;
        User currentClient;
        public Registration()
        {
            InitializeComponent();
            myHotel = new Hotel();
        }
        public Registration(User _client) 
        {
            InitializeComponent();
            myHotel = new Hotel();
            currentClient = _client;
        }

        private void logoutBtn_Click(object sender, RoutedEventArgs e)

        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }

        private void btnCheck_Click(object sender, RoutedEventArgs e)
        {
            
            RoomRegistration roomRegistration = new RoomRegistration();
            roomRegistration.Show();
        }
    }
}
