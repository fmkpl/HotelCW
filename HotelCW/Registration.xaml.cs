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
        public DateTime SelectedDayFrom { get; set; }
        public DateTime SelectedDayTo { get; set; }

        Hotel myHotel;
        User currentClient;
        public Registration()
        {
            InitializeComponent();
            myHotel = new Hotel();
            welcome.Content += (currentClient.Name + currentClient.LastName);
        }
        public Registration(User _client, Hotel _hotel) 
        {
            InitializeComponent();
            myHotel = _hotel;
            currentClient = _client;
            welcome.Content = "Welcome, " + currentClient.Name + " " + currentClient.LastName + "!";
        }

        private void logoutBtn_Click(object sender, RoutedEventArgs e)

        {
            /*MainWindow main = new MainWindow();
            main.Show();*/
            this.Close();
        }

        private void btnCheck_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (currentClient.userRoom != null)
                {
                    string str = $"You already booked a room. You room is {currentClient.userRoom.Number}.";
                    MessageBox.Show(str, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
                /*currentClient.userRoom = myHotel.listOfRooms[0];
                myHotel.listOfRooms.RemoveAt(0);*/
                if (myHotel.listOfRooms.Count == 0)
                {
                    MessageBox.Show("Hotel is full. Sorry(", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
                //currentClient.selectedDateFrom = (System.DateTime)fromCalendar.SelectedDate;
                //currentClient.selectedDateTo = (System.DateTime)toCalendar.SelectedDate;
                currentClient.Adults = adultsCombobox.SelectedIndex + 1;
                currentClient.ChildsUnderThree = childrenCombobox.SelectedIndex + 1;

                currentClient.ServicePrice = 0;
                if (wakeUp.IsChecked == true)
                {
                    currentClient.ServicePrice += (1 * currentClient.Adults);
                }
                if (fridge.IsChecked == true)
                {
                    currentClient.ServicePrice += 1;
                }
                if (safe.IsChecked == true)
                {
                    currentClient.ServicePrice += 1;
                }
                if (childBed.IsChecked == true)
                {
                    currentClient.ServicePrice += (1 * currentClient.ChildsUnderThree);
                }
                if (coffeeMachine.IsChecked == true)
                {
                    currentClient.ServicePrice += 2;
                }
                if (breakfastToBed.IsChecked == true)
                {
                    currentClient.ServicePrice += (3 * currentClient.Adults);
                }
                RoomRegistration roomRegistration = new RoomRegistration(currentClient, myHotel);
                roomRegistration.Show();
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Данные введены неверно либо не полностью.");
                return;
            }
        }
    }
}
