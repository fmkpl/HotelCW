using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HotelCW.Views
{
    /// <summary>
    /// Логика взаимодействия для UserView.xaml
    /// </summary>
    public partial class UserView : UserControl
    {
        public UserView()
        {
            InitializeComponent();
        }
        
        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string[] x = txtUsername.Text.Split();

                int check = 0;
                using (var context = new MyDbContext())
                {
                    foreach (User u in context.Users)
                    {
                        if (x[0] == u.Name && x[1] == u.LastName && txtPassword.Password == u.Password)
                        {
                            MessageBox.Show($"You're welcome in our 'Hotel Diamond Plaza', {u.Name} {u.LastName}!");
                            Registration registration = new Registration(u);
                            registration.Show();
                            txtUsername.Clear();
                            txtPassword.Clear();
                        }
                        else if (x[0] != u.Name || x[1] != u.LastName || txtPassword.Password != u.Password)
                        {
                            check++;
                        }
                    }

                    if (check == context.Users.Count())
                    {
                        MessageBox.Show("Invalid input. \nTry log in again or try to register.", "Warning!", MessageBoxButton.OK, MessageBoxImage.Warning);
                        txtUsername.Clear();
                        txtPassword.Clear();
                        
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}. Error.", "Oops", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void TxtPassword_OnKeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key != System.Windows.Input.Key.Enter) return;

            e.Handled = true;
            btnSubmit_Click(sender, e);
        }

        private void VKlink_Click(object sender, RoutedEventArgs e)
        {
            Process.Start("https://vk.com/e.kopyl");
        }

        private void MetanitLink_Click(object sender, RoutedEventArgs e)
        {
            Process.Start("https://metanit.com/sharp/wpf/");
        }

        private void register_Click(object sender, RoutedEventArgs e)
        {

            string[] x = txtUsername.Text.Split();
            User newUser = new User() 
            {
                Name=x[0],
                LastName=x[1],
                Password=txtPassword.Password,
                RoomId=null
            };

            using (var context = new MyDbContext())
            {
                context.Users.Add(newUser);
                context.SaveChanges();
            }
        }
    }
}
