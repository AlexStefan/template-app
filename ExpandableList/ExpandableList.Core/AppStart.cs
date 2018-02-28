using ExpandableList.Core.ViewModels;
using MvvmCross.ViewModels;
using MvvmCross.Navigation;

namespace ExpandableList.Core
{
    public class AppStart : IMvxAppStart
    {
        protected readonly IMvxNavigationService navigationService;

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