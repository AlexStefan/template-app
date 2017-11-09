using ExpandableList.Core.ViewModels;
using MvvmCross.Core.ViewModels;

namespace ExpandableList.Core
{
    public class AppStart : MvxNavigatingObject, IMvxAppStart
    {
        public void Start(object hint = null)
        {
            ShowViewModel<MainViewModel>();
        }
    }
}