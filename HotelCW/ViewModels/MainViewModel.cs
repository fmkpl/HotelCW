using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelCW.Commands;
using System.Windows.Input;

namespace HotelCW.ViewModels
{
    class MainViewModel : BaseViewModel
    {
        private BaseViewModel _selectedViewModel;

        public BaseViewModel SelectedViewModel
        {
            get { return _selectedViewModel; }
            set
            {
                _selectedViewModel = value;
                OnPropertyChanged(nameof(SelectedViewModel));
            }
        }


        public ICommand UpdateViewComand { get; set; }

        public MainViewModel()
        {
            UpdateViewComand = new UpdateViewCommand(this);
        }
    }
}
