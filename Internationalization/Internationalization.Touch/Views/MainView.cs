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

            // Release any cached data, images, etc that aren't in use.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            //this.CreateBinding(lbHello).To((MainViewModel vm) => vm.).Apply();
            this.CreateBinding(lbDynamic).To((MainViewModel vm) => vm.DynamicText).Apply();
            this.BindLanguage(lbHello, "Strings", "Hello");
            //this.BindLanguage(lbDynamic, "Strings", ViewModel.DynamicText);
            // Perform any additional setup after loading the view, typically from a nib.
        }
    }
}