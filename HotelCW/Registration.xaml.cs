using System;
using System.Collections.Generic;
using System.Data.Entity;
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
        public DateTime? SelectedDayFrom { get; set; }
        public DateTime? SelectedDayTo { get; set; }

        User currentClient;

        public Registration()
        {
            InitializeComponent();
        }
        public Registration(User _client) 
        {
            InitializeComponent();
            currentClient = _client;
            welcome.Content = "Welcome, " + currentClient.Name + " " + currentClient.LastName + "!";
        }

        private void logoutBtn_Click(object sender, RoutedEventArgs e)

        {
            this.Close();
        }

        private void btnCheck_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                using (var context = new MyDbContext())
                {
                    foreach(User user in context.Users) 
                    {
                        if (user.Name == currentClient.Name && user.LastName == currentClient.LastName) 
                        {
                            if (user.RoomId != null) 
                            {
                                string str = $"You already booked a room. You room is {currentClient.userRoom.Number}.";
                                MessageBox.Show(str, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                                return;
                            }

                            user.Adults = adultsCombobox.SelectedIndex + 1;
                            user.ChildsUnderThree = childrenCombobox.SelectedIndex + 1;

                            user.ServicePrice = 0;
                            if (wakeUp.IsChecked == true)
                            {
                                user.ServicePrice += (1 * currentClient.Adults);
                            }
                            if (fridge.IsChecked == true)
                            {
                                user.ServicePrice += 1;
                            }
                            if (safe.IsChecked == true)
                            {
                                user.ServicePrice += 1;
                            }
                            if (childBed.IsChecked == true)
                            {
                                user.ServicePrice += (1 * user.ChildsUnderThree);
                            }
                            if (coffeeMachine.IsChecked == true)
                            {
                                user.ServicePrice += 2;
                            }
                            if (breakfastToBed.IsChecked == true)
                            {
                                user.ServicePrice += (3 * user.Adults);
                            }

                            SelectedDayFrom = fromCalendar.SelectedDate;
                            SelectedDayTo = toCalendar.SelectedDate;

                            user.DaysInHotel = SelectedDayTo.Value.Day - SelectedDayFrom.Value.Day;

                            context.Entry(user).State = EntityState.Modified;

                            RoomRegistration roomRegistration = new RoomRegistration();
                            roomRegistration.Show();
                        }
                    }
                    context.SaveChanges();
                    /*if ()
                    {
                        MessageBox.Show("Hotel is full. Sorry(", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                        return;
                    }*/

                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Данные введены неверно либо не полностью.");
                return;
            }
        }
    }
}
