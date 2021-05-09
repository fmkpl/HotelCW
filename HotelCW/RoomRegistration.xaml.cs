using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
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

            if (clientEnd.userRoom == null)
            {
                MessageBox.Show("Номер занят или не существует.");
                return;
            }


            clientEnd.ServicePrice += (clientEnd.Adults * clientEnd.userRoom.Price /** (clientEnd.selectedDateTo.Day - clientEnd.selectedDateFrom.Day)*/);
            
            
            string str;
            str = "Name: " + clientEnd.Name +
                "\nLast name: " + clientEnd.LastName +
                "\nPhone: " + clientEnd.PhoneNumber +
                "\nEmail: " + clientEnd.Email +
                "\nCholdren under 3: " + clientEnd.ChildsUnderThree.ToString() +
                "\nAdults: " + clientEnd.Adults.ToString() +
                //"\nDate from: " + clientEnd.selectedDateFrom.ToString() +
                //"\nDate to: " + clientEnd.selectedDateTo.ToString()+
                "\nNumber of room: "+clientEnd.userRoom.Number+
                "\nRoom price: "+clientEnd.userRoom.Price.ToString()+
                "\nTotal price: " + clientEnd.ServicePrice.ToString();
            MessageBox.Show(str);

            try
            {
                SmtpClient smtp = new SmtpClient("smtp.yandex.ru", 25);
                smtp.Credentials = new NetworkCredential("efimberg22@gmail.com", "LLW-XNG-Nny-3Gw");
                smtp.EnableSsl = true;
    
                MailMessage m = new MailMessage();
                m.From = new MailAddress("efimberg22@gmail.com");
                m.To.Add(new MailAddress(clientEnd.Email));
                m.SubjectEncoding = Encoding.UTF8;
                m.BodyEncoding = Encoding.UTF8;
                m.Subject = "Room registration";
                m.Body = "Your room registration is done!";
            
                smtp.Send(m);
                Console.WriteLine("Message sent successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message} Error! Message sent failure.");
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
            RoomID.Text = clientNumberOfRoomTxt.Text;
        }
    }
}
