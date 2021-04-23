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

namespace HotelCW
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            if (txtUsername.Text=="1" && txtPassword.Password=="1")
            {
                ListOfHotels listOfHotels = new ListOfHotels();
                listOfHotels.Show();
                this.Close();
            }
            else 
            {
                txtPassword.Clear();
                txtUsername.Clear();
                MessageBox.Show("Invalid input. Try again.");
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
    }
}
