using MvvmCross.Binding.BindingContext;
using MvvmCross.iOS.Views;
using TemplateSettings.Core.ViewModels;

namespace TemplateSettings.Touch.Views
{
    public partial class MainView : MvxViewController
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


            this.CreateBinding(GeneralLabel).To((MainViewModel vm) => vm.GeneralSetting).Apply();
        }
    }
}