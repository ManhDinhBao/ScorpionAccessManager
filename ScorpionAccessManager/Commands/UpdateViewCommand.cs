using ScorpionAccessManager.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ScorpionAccessManager.Command
{
    public class UpdateViewCommand : ICommand
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
            switch (parameter.ToString())
            {
                case "Card":
                    viewModel.SelectedViewModel = new CardViewModel();
                    break;
                case "CardHolder":
                    viewModel.SelectedViewModel = new CardHolderViewModel();
                    break;
                case "Device":
                    viewModel.SelectedViewModel = new DeviceViewModel();
                    break;
                case "Door":
                    viewModel.SelectedViewModel = new DoorViewModel();
                    break;
                case "Schedule":
                    viewModel.SelectedViewModel = new ScheduleViewModel();
                    break;
                case "Right":
                    viewModel.SelectedViewModel = new RightViewModel();
                    break;
            }

        }
    }
}
