using MvvmCross.Core.ViewModels;
using System.Threading.Tasks;
using System.Windows.Input;

namespace TemplateMenu.Core.ViewModels
{
    public class RootViewModel : MvxViewModel
    {
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

		public RootViewModel()
		{
			Home = new MainViewModel();
			Menu = new MenuViewModel();
		}
    }
}