using HotelCW.DBPatterns;
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
    /// Логика взаимодействия для AdminControl.xaml
    /// </summary>
    public partial class AdminControl : Window
    {
        Admin currentAdmin;
        public AdminControl()
        {
            InitializeComponent();
            LoadDataFromDb();
            LoadAllAboutUsersFromDB();
        }

        public AdminControl(Admin _currentAdmin) 
        {
            InitializeComponent();
            LoadDataFromDb();
            LoadAllAboutUsersFromDB();
            currentAdmin = _currentAdmin;
            enjWorkTxt.Text += (" " + currentAdmin.AdminName + "!");
        }

        public void UpdateDataGrid() 
        {
            clientsDataGrid.Items.Clear();
            moreAboutClients.Items.Clear();
            using(var context = new MyDbContext()) 
            {
                foreach(Room room in context.Rooms)
                {
                    clientsDataGrid.Items.Add(room);
                }
                foreach (User user in context.Users)
                {
                    moreAboutClients.Items.Add(user);
                }
            }
        }

        public void LoadDataFromDb() 
        {
            List<Room> rooms = new List<Room>();
            using (var context = new MyDbContext())
            {
                foreach (var r in context.Rooms)
                {
                    if (r.Users.Count == 0)
                    {
                        r.Status = "Free";
                    }
                    else if (r.Users.Count != 0)
                    {
                        r.Status = "Reserved";
                    }
                    context.Entry(r).State = EntityState.Modified;
                }
                context.SaveChanges();
                rooms.AddRange(context.Rooms);
            }
            foreach (var room in rooms)
            {
                clientsDataGrid.Items.Add(room);
            }
        }

        public void LoadAllAboutUsersFromDB() 
        {
            List<User> usersList = new List<User>();
            using (var context = new MyDbContext())
            {
                usersList.AddRange(context.Users);
            }
            foreach (var user in usersList)
            {
                moreAboutClients.Items.Add(user);
            }
        }

        private void addRoom_Click(object sender, RoutedEventArgs e)
        {
            try 
            {
                using(var context = new MyDbContext()) 
                {
                    RoomRepository roomRepository = new RoomRepository(context);
                    Room newRoomToAdd = new Room()
                    {
                        Number = numberOfNewRoom.Text,
                        Price = Convert.ToInt32(priceOfNewRoom.Text),
                        Type=typeOfNewRoom.Text,
                        Status="Free"
                    };
                    foreach(Admin admin in context.Admins) 
                    {
                        foreach(Room room in admin.Rooms) 
                        {
                            if (numberOfNewRoom.Text == room.Number) 
                            {
                                numberOfNewRoom.Clear();
                                priceOfNewRoom.Clear();
                                MessageBox.Show("This room is already in hotel.", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                                return;
                            }
                        }
                        if (admin.AdminName == currentAdmin.AdminName &&
                            admin.AdminPassword == currentAdmin.AdminPassword &&
                            admin.AdminPassword == currentAdmin.AdminPassword)
                        { 
                            newRoomToAdd.AdminId = admin.Id;
                            newRoomToAdd.roomAdmin = admin;
                            admin.Rooms.Add(newRoomToAdd);
                        }
                    }
                    roomRepository.Create(newRoomToAdd);
                    clientsDataGrid.Items.Add(newRoomToAdd);
                    context.SaveChanges();
                }
                numberOfNewRoom.Clear();
                priceOfNewRoom.Clear();
                
                
            }
            catch(Exception ex) 
            {
                MessageBox.Show($"{ex.Message}. Error.");
            }
        }

        private void deleteRoom_Click(object sender, RoutedEventArgs e)
        {
            List<Room> rooms = new List<Room>();
            try
            {
                using (var context = new MyDbContext())
                {
                    RoomRepository roomRepository = new RoomRepository(context);
                    foreach (Room room in context.Rooms)
                    {
                        if (room.Number == numberOfNewRoomToDelete.Text)
                        {
                            room.roomAdmin.Rooms.Remove(room);
                            foreach(var user in room.Users) 
                            {
                                user.userRoom.roomAdmin.SendEmailAboutEviction(user);
                                user.RoomId = null;
                                user.Adults = null;
                                user.ChildsUnderThree = null;
                                user.ServicePrice = null;
                                user.PhoneNumber = null;
                                user.Email = null;
                                user.DaysInHotel = null;
                                user.userRoom = null;
                            }
                            context.Entry(room).State = EntityState.Deleted;
                            
                        }
                        else 
                        {
                             
                        }

                    }
                    context.SaveChanges();

                    foreach (var r in context.Rooms)
                    {
                        rooms.Add(r);
                    }
                }
                clientsDataGrid.Items.Clear();
                foreach (var room in rooms)
                {
                    clientsDataGrid.Items.Add(room);
                }
                numberOfNewRoomToDelete.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}. Error.");
            }
        }

        private void updateTable_Click(object sender, RoutedEventArgs e)
        {
            UpdateDataGrid();
        }

        private void exitAdmin_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
