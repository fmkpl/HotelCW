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
    /// Логика взаимодействия для AdminView.xaml
    /// </summary>
    public partial class AdminView : UserControl
    {   
        public AdminView()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int check = 0;
                using (var context = new MyDbContext())
                {
                    foreach (Admin a in context.Admins)
                    {
                        if (txtAdminName.Text == a.AdminName && Admin.HashAdminPassword(txtPassword.Password) == a.AdminPassword && txtControlWord.Password == a.AdminControlword)
                        {
                            MessageBox.Show($"You're welcome, {a.AdminName}!");
                            Admin currentAdmin = new Admin()
                            {
                                AdminName = a.AdminName,
                                AdminPassword = a.AdminPassword,
                                AdminControlword=a.AdminControlword
                            };


                            AdminControl adminControl = new AdminControl(currentAdmin);
                            adminControl.Show();
                            var parent = Window.GetWindow(this);
                            parent.WindowState = WindowState.Minimized;
                            
                            
                            txtAdminName.Clear();
                            txtPassword.Clear();
                            txtControlWord.Clear();
                        }
                        else if (txtAdminName.Text != a.AdminName || txtPassword.Password != a.AdminPassword || txtControlWord.Password != a.AdminControlword)
                        {
                            check++;
                        }
                    }

                    if (check == context.Admins.Count())
                    {
                        MessageBox.Show("Invalid input. \nTry log in again or try to register.", "Warning!", MessageBoxButton.OK, MessageBoxImage.Warning);
                        txtAdminName.Clear();
                        txtPassword.Clear();
                        txtControlWord.Clear();
                    }
                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show($"{ex.Message}. Error.", "Oops", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private void TxtPassword_OnKeyUp(object sender, KeyEventArgs e)
        {
            
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
            Admin newAdmin = new Admin();
            newAdmin.AdminName = txtAdminName.Text;
            newAdmin.AdminPassword = Admin.HashAdminPassword(txtPassword.Password);
            newAdmin.AdminControlword = txtControlWord.Password;
            using(var context = new MyDbContext()) 
            {
                context.Admins.Add(newAdmin);
                context.SaveChanges();
            }
        }

        private void txtControlword_OnKeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key != System.Windows.Input.Key.Enter) return;

            e.Handled = true;
            btnSubmit_Click(sender, e);
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
