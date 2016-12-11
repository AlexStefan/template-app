using MvvmCross.Core.ViewModels;
using Template.Core.ViewModels;

namespace Template.Core
{
    public class AppStart : MvxNavigatingObject, IMvxAppStart
    {
        public void Start(object hint = null)
        {
            ShowViewModel<MainViewModel>();
        }
    }
}