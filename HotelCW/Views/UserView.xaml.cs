using HotelCW.DBPatterns;
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
                        if (x[0] == u.Name && x[1] == u.LastName && txtPassword.Password.Trim().GetHashCode().ToString() == u.Password)
                        {
                            Registration registration = new Registration(u);
                            registration.ShowDialog();
                            //MessageBox.Show($"Добро пожаловать в отель 'Diamond Plaza', {u.Name} {u.LastName}!");
                            
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
                        MessageBox.Show("Неверный ввод. \nПопробуйте зайти еще раз или зарегистрируйтесь.", "Внимание!", MessageBoxButton.OK, MessageBoxImage.Warning);
                        txtUsername.Clear();
                        txtPassword.Clear();
                        
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}. Ошибка.", "Упс", MessageBoxButton.OK, MessageBoxImage.Error);
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
            try
            {
                string[] x = txtUsername.Text.Split();
                User newUser = new User()
                {
                    Name = x[0],
                    LastName = x[1],
                    Password = txtPassword.Password.Trim().GetHashCode().ToString(),
                    RoomId = null
                };


                using (var context = new MyDbContext())
                {
                    foreach (User user in context.Users)
                    {
                        if (newUser.Name == user.Name && newUser.LastName == user.LastName && newUser.Password == user.Password) 
                        {
                            MessageBox.Show("Такой аккаунт уже существует.", "Внимание", MessageBoxButton.OK, MessageBoxImage.Warning);
                            return;
                        }
                    }

                    UserRepository userRepository = new UserRepository(context);
                    userRepository.Create(newUser);
                    userRepository.Save();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Здесь должны быть ваши имя и фамилия.", "Внимание!", MessageBoxButton.OK, MessageBoxImage.Warning);
            } 
        }

        private void GithubLink_Click(object sender, RoutedEventArgs e)
        {
            Process.Start("https://github.com/fmkpl");
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            var parent = Window.GetWindow(this);
            parent.Close();
        }
    }
}
