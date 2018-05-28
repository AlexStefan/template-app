using Foundation;
using Internationalization.Core;
using MvvmCross.Platforms.Ios.Core;
using UIKit;

namespace Internationalization.Touch
{
	[Register("AppDelegate")]
	public class AppDelegate : MvxApplicationDelegate<Setup, App>
    {
        public override UIWindow Window
        {
            get;
            set;
        }

        public override bool FinishedLaunching(UIApplication application, NSDictionary launchOptions)
        {
			var result = base.FinishedLaunching(application, launchOptions);

            //CustomizeAppearance();

            return result;
        }

		private void CustomizeAppearance()
		{
			//Window = new UIWindow(UIScreen.MainScreen.Bounds);
            Window.MakeKeyAndVisible();
		}
    }
}