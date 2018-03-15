using Internationalization.Core.ViewModels;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Platform.Ios.Views;

namespace Internationalization.Touch.Views
{
    public partial class MainView : MvxViewController<MainViewModel>
    {
        public MainView() : base("MainView", null)
        {
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            this.CreateBinding(lbDynamic).To((MainViewModel vm) => vm.DynamicText).Apply();
            this.BindLanguage(lbHello, "Hello");
        }
    }
}