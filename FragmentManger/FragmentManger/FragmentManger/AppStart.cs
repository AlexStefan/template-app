using FragmentManger.Core.ViewModels;
using MvvmCross.Core.ViewModels;

namespace FragmentManger.Core
{
    public class AppStart : MvxNavigatingObject, IMvxAppStart
    {
        public void Start(object hint = null)
        {
            ShowViewModel<RootViewModel>();
        }
    }
}