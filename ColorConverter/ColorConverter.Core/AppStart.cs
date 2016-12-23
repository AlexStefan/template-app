using MvvmCross.Core.ViewModels;
using ColorConverter.Core.ViewModels;

namespace ColorConverter.Core
{
    public class AppStart : MvxNavigatingObject, IMvxAppStart
    {
        public void Start(object hint = null)
        {
            ShowViewModel<MainViewModel>();
        }
    }
}