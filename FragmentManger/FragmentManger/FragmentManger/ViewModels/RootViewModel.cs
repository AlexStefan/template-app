using MvvmCross.Core.Navigation;
using MvvmCross.Core.ViewModels;
using System.Threading.Tasks;
using System.Windows.Input;

namespace FragmentManger.Core.ViewModels
{
    public class RootViewModel : MvxViewModel
    {
        private readonly IMvxNavigationService navigationService;

        private MainViewModel home;
        public MainViewModel Home
        {
            get { return home; }
            set
            {
                home = value;
                RaisePropertyChanged(() => Home);
            }
        }

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
            await navigationService.Navigate<MainViewModel>();
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
            Home = new MainViewModel();
            Menu = new MenuViewModel();
        }
    }
}