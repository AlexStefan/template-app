using MvvmCross.Core.ViewModels;
using System.Threading.Tasks;
using System.Windows.Input;

namespace TemplateMenu.Core.ViewModels
{
    public class MainViewModel : MvxViewModel
    {
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