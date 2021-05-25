using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Data.Entity;
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
        
        public RoomRegistration()
        {
            InitializeComponent();
            LoadRoomsFromDb();
        }
        private void LoadRoomsFromDb() 
        {

            List<Room> rooms = new List<Room>();
            using (var context = new MyDbContext())
            {
                foreach (var r in context.Rooms)
                {
                    if (r.Status == "Свободно")
                    {
                        rooms.Add(r);
                    }
                }
            }
            foreach (var room in rooms)
            {
                string str = "Номер: " + room.Number + ", Цена за ночь: " + room.Price.ToString() + "$, " + room.Type;
                listOfFreeRooms.Items.Add(str);
            }
        }
        public RoomRegistration(User _currentClient)  
        {
            InitializeComponent();
            LoadRoomsFromDb();
            clientEnd = _currentClient;
            this.DataContext = _currentClient;
        }

        private void goBackBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void bookBtn_Click(object sender, RoutedEventArgs e)
        {
            
            using (var context = new MyDbContext())
            {
                try
                {
                    if (clientEnd.Name != clientNameTxt.Text || clientEnd.LastName != clientSecondNameTxt.Text)
                    {
                        clientNameTxt.Clear();
                        clientSecondNameTxt.Clear();
                        clientPhoneTxt.Clear();
                        clientNumberOfRoomTxt.Clear();
                        clientEmailTxt.Clear();
                        MessageBox.Show("Одно или несколько полей не заполнены или \nзаполнены неправильно.", "Неверный ввод", MessageBoxButton.OK, MessageBoxImage.Warning);
                        return;
                    }
                    else if(clientEnd.Name == clientNameTxt.Text && clientEnd.LastName == clientSecondNameTxt.Text)
                    {
                        foreach (User client in context.Users)
                        {
                            if (clientNameTxt.Text == client.Name && clientSecondNameTxt.Text == client.LastName)
                            {
                                client.Email = clientEmailTxt.Text;
                                clientEnd.Email = clientEmailTxt.Text;

                                client.PhoneNumber = clientPhoneTxt.Text;
                                clientEnd.PhoneNumber = clientPhoneTxt.Text;
                                int check = 0;

                                foreach (Room room in context.Rooms)
                                {
                                    
                                    if (clientNumberOfRoomTxt.Text == room.Number)
                                    {
                                        client.RoomId = room.Id;
                                        clientEnd.RoomId = room.Id;

                                       
                                        client.userRoom = room;
                                        clientEnd.userRoom = room;

                                        room.Users.Add(client);
                                        room.Status = "Занято";
                                    }
                                    else if (clientNumberOfRoomTxt.Text != room.Number)
                                    {
                                        check++;
                                    }
                                    
                                    context.Entry(room).State = EntityState.Modified;
                                }
                                if (check == context.Rooms.Count())
                                {
                                    MessageBox.Show($"Не существует номера {clientNumberOfRoomTxt.Text} \nлибо он уже занят.", "Внимание!", MessageBoxButton.OK, MessageBoxImage.Warning);
                                    return;
                                }
                                client.ServicePrice += client.Adults * client.userRoom.Price * client.DaysInHotel;
                                clientEnd.ServicePrice = client.ServicePrice;

                                //sending email
                                client.userRoom.roomAdmin.SendEmailToClient(client);

                                context.Entry(client).State = EntityState.Modified;
                            }
                            
                        }
                    }
                    context.SaveChanges();
                }
                catch (Exception ex) 
                {
                    MessageBox.Show("Ошибка. Вы уже сняли номер. \nПроверьте вашу электронную почту.");
                    return;
                }


                    string str;
                    str = "Имя: " + clientEnd.Name +
                        "\nФамилия: " + clientEnd.LastName +
                        "\nНомер телефона: " + clientEnd.PhoneNumber +
                        "\nЭлектронная почта: " + clientEnd.Email +
                        "\nДети до 3 лет: " + clientEnd.ChildsUnderThree.ToString() +
                        "\nВзрослые: " + clientEnd.Adults.ToString() +
                        "\nДни в отеле: " + clientEnd.DaysInHotel.ToString() +
                        "\nНомер: " + clientEnd.userRoom.Number +
                        "\nЦена за ночь: " + clientEnd.userRoom.Price.ToString() +
                        "\nЦена к оплате: " + clientEnd.ServicePrice.ToString();
                MessageBox.Show(str, "Ваша бронь", MessageBoxButton.OK, MessageBoxImage.Information);
            }
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
            //RoomID.Text = clientNumberOfRoomTxt.Text;
        }
    }
}
