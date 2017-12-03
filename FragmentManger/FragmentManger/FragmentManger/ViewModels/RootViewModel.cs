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

        private MvxCommand aboutScreenCommand;
        public ICommand AboutScreenCommand
        {
            get
            {
                aboutScreenCommand = aboutScreenCommand ?? new MvxCommand(async () => await ShowAboutScreen());
                return aboutScreenCommand;
            }
        }

        private async Task ShowAboutScreen()
        {
            await navigationService.Navigate<AboutViewModel>();
        }

        public RootViewModel(IMvxNavigationService navigationService)
        {
            this.navigationService = navigationService;
            Menu = new MenuViewModel();
        }
    }
}