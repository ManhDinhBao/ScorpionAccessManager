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
            Console.WriteLine("Manh");
            if (parameter.ToString() == "ucCard")
            {
                viewModel.SelectedViewModel = new CardViewModel();
            }
            else
            {
                viewModel.SelectedViewModel = new CardHolderViewModel();
            }
        }
    }
}
