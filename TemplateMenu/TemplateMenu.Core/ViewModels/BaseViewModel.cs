using MvvmCross.Core.ViewModels;
using TemplateMenu.Core.ViewModels;

namespace TemplateMenu.Core
{
	public class BaseViewModel : MvxViewModel
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

		public BaseViewModel()
		{
			Home = new MainViewModel();
			Menu = new MenuViewModel();
		}
	}
}