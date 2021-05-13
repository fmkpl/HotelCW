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
                    //check for free rooms
                    int check = 0;
                    foreach (Room room in context.Rooms)
                    {
                        if (room.Status == "Reserved")
                        {
                            check++;
                        }
                    }
                    if (check == context.Rooms.Count())
                    {
                        MessageBox.Show($"Hotel is full. Our excuses.\nOr you've already booked a hotel room.\nCheck your email.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                        return;
                    }
                    //end check


                    //filling client data
                    foreach (User user in context.Users)
                    {
                        if (user.Name == currentClient.Name && user.LastName == currentClient.LastName)
                        {
                            if (user.RoomId != null)
                            {
                                string str = $"You've already booked a hotel room. Your room number is {currentClient.userRoom.Number}.";
                                MessageBox.Show(str, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                                return;
                            }

                            user.Adults = adultsCombobox.SelectedIndex + 1;
                            user.ChildsUnderThree = childrenCombobox.SelectedIndex;

                            currentClient.Adults = user.Adults;
                            currentClient.ChildsUnderThree = user.ChildsUnderThree;

                            user.ServicePrice = 0;
                            currentClient.ServicePrice = 0;
                            if (wakeUp.IsChecked == true)
                            {
                                user.ServicePrice += (1 * user.Adults);
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

                            currentClient.ServicePrice = user.ServicePrice;
                            currentClient.DaysInHotel = user.DaysInHotel;

                            context.Entry(user).State = EntityState.Modified;

                            RoomRegistration roomRegistration = new RoomRegistration(currentClient);
                            roomRegistration.Show();
                        }
                    }
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                    MessageBox.Show($"The data entered is incorrector or incomplete. You'he already booked a hotel room.");
                    return;
            }
        }
    }
}
