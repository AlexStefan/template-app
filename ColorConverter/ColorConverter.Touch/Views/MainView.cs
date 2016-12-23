using MvvmCross.Binding.BindingContext;
using MvvmCross.iOS.Views;
using ColorConverter.Core.ViewModels;
using UIKit;

namespace ColorConverter.Touch.Views
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

            var button = new UIButton();
            button.Frame = new CoreGraphics.CGRect(50, 150, 150, 150);
            button.SetTitle("Test", UIControlState.Normal);
            button.TitleLabel.TextColor = UIColor.Black;
            button.BackgroundColor = UIColor.Red;
            View.AddSubview(button);

            var set = this.CreateBindingSet<MainView, MainViewModel>();
            set.Bind(button).For(field => field.BackgroundColor).To(vm => vm.BackgroundColor).WithConversion("NativeColor");
            set.Apply();
            // Perform any additional setup after loading the view, typically from a nib.
        }
    }
}