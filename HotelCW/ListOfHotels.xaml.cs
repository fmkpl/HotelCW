using System;
using System.Collections.Generic;
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
    /// Логика взаимодействия для ListOfHotels.xaml
    /// </summary>
    public partial class ListOfHotels : Window
    {
        public ListOfHotels()
        {
            InitializeComponent();
        }

        private void blr_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Label label = new Label();
            label.Content = "Belarus Hotel";
            var converter = new System.Windows.Media.BrushConverter();
            var brush = (Brush)converter.ConvertFromString("red");
            label.Background = brush;
            label.Margin = new Thickness(0, 10, 0, 0);
            hotelsColumn.Children.Add(label);
        }
    }
}
