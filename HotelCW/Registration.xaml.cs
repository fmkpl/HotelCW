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
using HotelCW.DBPatterns;

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
            welcome.Content = "Мы рады вам, " + currentClient.Name + " " + currentClient.LastName + "!";
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
                        if (room.Status == "Занято")
                        {
                            check++;
                        }
                    }
                    if (check == context.Rooms.Count())
                    {
                        MessageBox.Show($"Все номера в отеле забронированы. Наши извинения.\nИли вы забыли, что забронировали номер.\nПроверьте свою электронную почту.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
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
                                string str = $"Вы уже забронировали номер. Ваш номер {currentClient.userRoom.Number}.";
                                MessageBox.Show(str, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
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

                            //date validation

                            if (fromCalendar.SelectedDate < DateTime.Now.Date || toCalendar.SelectedDate < DateTime.Now.Date)
                            {
                                MessageBox.Show("Проверьте начальную и конечную дату.", "Внимание", MessageBoxButton.OK, MessageBoxImage.Warning);
                                return;
                            }

                            SelectedDayFrom = fromCalendar.SelectedDate;
                            SelectedDayTo = toCalendar.SelectedDate;

                            user.DaysInHotel = SelectedDayTo.Value.Day - SelectedDayFrom.Value.Day;

                            if (user.DaysInHotel <= 0) 
                            {
                                MessageBox.Show("Проверьте начальную и конечную дату.", "Внимание", MessageBoxButton.OK, MessageBoxImage.Warning);
                                return;
                            }

                            //end of date validation

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
                MessageBox.Show($"Вы уже забронировали номер.");
                return;
            }
        }

        private void sendReview_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (commentBody.Text.Length < 5)
                {
                    resultOfSending.Text = "Пустое поле.";
                    resultOfSending.Background = Brushes.Red;
                    resultOfSending.FontSize = 20;
                    resultOfSending.Foreground = Brushes.WhiteSmoke;
                    resultOfSending.Width = 400;
                    resultOfSending.HorizontalAlignment = HorizontalAlignment.Left;
                    resultOfSending.Margin = commentBody.Margin;
                    resultOfSending.Padding = sendReview.Padding;
                    commentBody.Clear();
                    return;
                }
                else
                {
                    if (resultOfSending.Background == Brushes.Green) 
                    {
                        commentBody.Clear();
                        MessageBox.Show("Вы уже отправили отзыв.", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
                        return;
                    }
                    using (var context = new MyDbContext())
                    {
                        CommentRepository commentRepository = new CommentRepository(context);
                        Comment comment = new Comment()
                        {
                            UserMain = currentClient,
                            Body = commentBody.Text
                        };
                        commentRepository.Create(comment);
                        context.SaveChanges();
                    }
                    commentBody.Clear();
                    resultOfSending.Text = "Спасибо за ваш отзыв! Он очень важен для нас.";
                    resultOfSending.Background = Brushes.Green;
                    resultOfSending.FontSize = 20;
                    resultOfSending.Foreground = Brushes.WhiteSmoke;
                    resultOfSending.Width = 400;
                    resultOfSending.HorizontalAlignment = HorizontalAlignment.Left;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
                return;
            }
        }
    }
}
