using MvvmCross.iOS.Views;

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

            // Perform any additional setup after loading the view, typically from a nib.
        }
    }
}