using HotelCW.ViewModels;
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
            DataContext = new MainViewModel();
            
        }

        private void log_in_as_admin_Click(object sender, RoutedEventArgs e)
        {
            if (!startWindow.Children.Contains(welcome) && !startWindow.Children.Contains(exit)) 
            {
                return;
            }
            else if(startWindow.Children.Contains(welcome) && startWindow.Children.Contains(exit)) 
            {
                startWindow.Children.Remove(welcome);
                startWindow.Children.Remove(exit);
            }
            
        }

        private void log_in_as_user_Click(object sender, RoutedEventArgs e)
        {
            if (!startWindow.Children.Contains(welcome) && !startWindow.Children.Contains(exit)) 
            {
                return;
            }
            else if(startWindow.Children.Contains(welcome) && startWindow.Children.Contains(exit)) 
            {
                startWindow.Children.Remove(welcome);
                startWindow.Children.Remove(exit);
            }
            
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
