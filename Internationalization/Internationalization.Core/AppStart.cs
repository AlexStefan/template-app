using Internationalization.Core.ViewModels;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;

namespace Internationalization.Core
{
    public class AppStart : IMvxAppStart
    {
        private readonly IMvxNavigationService navigationService;

        public AppStart(IMvxNavigationService navigationService)
        {
            this.navigationService = navigationService;
        }

        public void Start(object hint = null)
        {
            navigationService.Navigate<MainViewModel>();
        }
    }
}