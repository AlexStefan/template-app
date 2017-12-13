using CommunicationService.Core.ViewModels;
using MvvmCross.Core.ViewModels;

namespace CommunicationService.Core
{
    public class AppStart : MvxNavigatingObject, IMvxAppStart
    {
        public void Start(object hint = null)
        {
            ShowViewModel<MainViewModel>();
        }
    }
}