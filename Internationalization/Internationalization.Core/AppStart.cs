using Internationalization.Core.ViewModels;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;

namespace Internationalization.Core
{
    public class AppStart : MvxAppStart
    {
        private readonly IMvxNavigationService navigationService;

		public AppStart(IMvxApplication application, IMvxNavigationService navigationService) : base(application)
		{
            this.navigationService = navigationService;
		}

		protected override void Startup(object hint = null)
        {
            navigationService.Navigate<MainViewModel>();
        }
    }
}