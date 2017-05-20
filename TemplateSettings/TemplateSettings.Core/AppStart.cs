using MvvmCross.Core.ViewModels;
using TemplateSettings.Core.ViewModels;

namespace TemplateSettings.Core
{
    public class AppStart : MvxNavigatingObject, IMvxAppStart
    {
        public void Start(object hint = null)
        {
            ShowViewModel<MainViewModel>();
        }
    }
}