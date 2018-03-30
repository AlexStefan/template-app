using CommunicationService.Core.ViewModels;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;

namespace CommunicationService.Core
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

        public void ResetStart()
        {
            throw new System.NotImplementedException();
        }

        public bool IsStarted { get; }
    }
}