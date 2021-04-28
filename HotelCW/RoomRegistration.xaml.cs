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
    /// Логика взаимодействия для RoomRegistration.xaml
    /// </summary>
    public partial class RoomRegistration : Window
    {
        public User clientEnd;
        public Hotel hotel;
        public RoomRegistration()
        {
            InitializeComponent();
        }
        public RoomRegistration(User _currentClient, Hotel _myHotel)  
        {
            InitializeComponent();
            clientEnd = _currentClient;
            hotel = _myHotel;
            foreach (Room room in _myHotel.listOfRooms) 
            {
                freeRooms.Text += room.Number + ", ";
            }
            RoomCost.Text = clientEnd.ServicePrice.ToString();
            
        }

        private void goBackBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void bookBtn_Click(object sender, RoutedEventArgs e)
        {
            if (clientNameTxt.Text != clientEnd.Name || clientSecondNameTxt.Text != clientEnd.LastName) 
            {
                clientNameTxt.Clear();
                clientSecondNameTxt.Clear();
                clientPhoneTxt.Clear();
                clientNumberOfRoomTxt.Clear();
                clientEmailTxt.Clear();
                MessageBox.Show("Одно или несколько полей не заполнены или \nзаполнены неправильно.","Invalid input",MessageBoxButton.OK,MessageBoxImage.Warning);
                return;
            }
            clientEnd.Email = clientEmailTxt.Text;
            clientEnd.PhoneNumber = clientPhoneTxt.Text;
            foreach (Room room in hotel.listOfRooms)
            {
                if (clientNumberOfRoomTxt.Text == room.Number) 
                {
                    clientEnd.userRoom = room;
                }
            }
            hotel.listOfRooms.Remove(clientEnd.userRoom);
            
            clientEnd.ServicePrice += (clientEnd.Adults*clientEnd.userRoom.Price);
            string str;
            str = "Name: " + clientEnd.Name +
                "\nLast name: " + clientEnd.LastName +
                "\nPhone: " + clientEnd.PhoneNumber +
                "\nEmail: " + clientEnd.Email +
                "\nCholdren under 3: " + clientEnd.ChildsUnderThree.ToString() +
                "\nAdults: " + clientEnd.Adults.ToString() +
                "\nDate from: " + clientEnd.selectedDateFrom.ToString() +
                "\nDate to: " + clientEnd.selectedDateTo.ToString()+
                "\nNumber of room: "+clientEnd.userRoom.Number+
                "\nRoom price: "+clientEnd.userRoom.Price.ToString()+
                "\nTotal price: " + clientEnd.ServicePrice.ToString();
            MessageBox.Show(str);
            this.Close();
        }

        private void clientNameTxt_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void clientSecondNameTxt_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void clientPhoneTxt_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void clientEmailTxt_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void clientNumberOfRoomTxt_TextChanged(object sender, TextChangedEventArgs e)
        {
            RoomID.Text = clientNumberOfRoomTxt.Text;
        }
    }
}
