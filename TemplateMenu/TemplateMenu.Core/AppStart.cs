using MvvmCross.Core.ViewModels;
using TemplateMenu.Core.ViewModels;

namespace TemplateMenu.Core
{
    public class AppStart : MvxNavigatingObject, IMvxAppStart
    {
        public void Start(object hint = null)
        {
			ShowViewModel<RootViewModel>();
        }
    }
}