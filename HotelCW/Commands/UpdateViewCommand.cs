using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using HotelCW.ViewModels;


namespace HotelCW.Commands
{
    class UpdateViewCommand : ICommand
    {
        private MainViewModel viewModel;

        public UpdateViewCommand(MainViewModel viewModel)
        {
            this.viewModel = viewModel;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if (parameter.ToString() == "User")
            {
                viewModel.SelectedViewModel = new UserViewModel();
            }
            else if (parameter.ToString() == "Admin")
            {
                viewModel.SelectedViewModel = new AdminViewModel();
            }
        }
    }
}
