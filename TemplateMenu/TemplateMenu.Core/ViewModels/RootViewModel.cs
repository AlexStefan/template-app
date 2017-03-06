using MvvmCross.Core.ViewModels;
using System.Threading.Tasks;
using System.Windows.Input;

namespace TemplateMenu.Core.ViewModels
{
    public class RootViewModel : MvxViewModel
    {
        private MvxCommand mainScreenCommand;
        public ICommand MainScreenCommand
        {
            get
            {
                mainScreenCommand = mainScreenCommand ?? new MvxCommand(async () => await ShowMainScreen());
                return mainScreenCommand;
            }
        }

        private async Task ShowMainScreen()
        {
            ShowViewModel<MainViewModel>();
        }

        private MvxCommand secondScreenCommand;
        public ICommand SecondScreenCommand
        {
            get
            {
                secondScreenCommand = secondScreenCommand ?? new MvxCommand(async () => await ShowSecondScreen());
                return secondScreenCommand;
            }
        }

        private async Task ShowSecondScreen()
        {
            ShowViewModel<SecondViewModel>();
        }
    }
}