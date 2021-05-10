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
        }

        public AdminControl(Admin _currentAdmin) 
        {
            InitializeComponent();
            LoadDataFromDb();
            currentAdmin = _currentAdmin;
        }

        public void LoadDataFromDb() 
        {
            List<Room> rooms = new List<Room>();
            using (var context = new MyDbContext())
            {
                foreach (var r in context.Rooms)
                {
                    rooms.Add(r);
                }
            }
            foreach (var room in rooms)
            {
                clientsDataGrid.Items.Add(room);
            }
        }

        private void addRoom_Click(object sender, RoutedEventArgs e)
        {
            try 
            {
                using(var context = new MyDbContext()) 
                {
                    Room newRoomToAdd = new Room()
                    {
                        Number = numberOfNewRoom.Text,
                        Price = Convert.ToInt32(priceOfNewRoom.Text),
                        Type=typeOfNewRoom.Text
                    };
                    foreach(Admin admin in context.Admins) 
                    {
                        if (admin.AdminName == currentAdmin.AdminName &&
                            admin.AdminPassword == currentAdmin.AdminPassword &&
                            admin.AdminPassword == currentAdmin.AdminPassword) 
                        {
                            newRoomToAdd.AdminId = admin.Id;
                            admin.Rooms.Add(newRoomToAdd);
                        }
                    }
                    context.Rooms.Add(newRoomToAdd);
                    clientsDataGrid.Items.Add(newRoomToAdd);
                    context.SaveChanges();
                }
                
            }
            catch(Exception ex) 
            {
                MessageBox.Show($"{ex.Message}. Error.");
            }
        }

        private void deleteRoom_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                using (var context = new MyDbContext())
                {
                    foreach (var room in context.Rooms) 
                    {
                        if (numberOfNewRoomToDelete.Text == room.Number) 
                        {
                            foreach (var admin in context.Admins)
                            {
                                admin.Rooms.Remove(room);
                            }
                            context.Entry(room).State = EntityState.Deleted;
                        }
                    }
                    context.SaveChanges();
                }
                clientsDataGrid.Items.RemoveAt(clientsDataGrid.Items.Count - 1);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}. Error.");
            }
        }
    }
}
