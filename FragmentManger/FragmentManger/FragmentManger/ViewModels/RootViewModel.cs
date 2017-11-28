using MvvmCross.Core.Navigation;
using MvvmCross.Core.ViewModels;
using System.Threading.Tasks;
using System.Windows.Input;

namespace FragmentManger.Core.ViewModels
{
    public class RootViewModel : MvxViewModel
    {
        private readonly IMvxNavigationService navigationService;

        private MenuViewModel menu;
        public MenuViewModel Menu
        {
            get { return menu; }
            set
            {
                menu = value;
                RaisePropertyChanged(() => Menu);
            }
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
            await navigationService.Navigate<SecondViewModel>();
        }

        public RootViewModel(IMvxNavigationService navigationService)
        {
            this.navigationService = navigationService;
            Menu = new MenuViewModel();
        }
    }
}