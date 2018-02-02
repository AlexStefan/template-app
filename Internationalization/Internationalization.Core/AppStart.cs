using MvvmCross.Core.ViewModels;
using Internationalization.Core.ViewModels;

namespace Internationalization.Core
{
    public class AppStart : MvxNavigatingObject, IMvxAppStart
    {
        public void Start(object hint = null)
        {
            ShowViewModel<MainViewModel>();
        }
    }
}