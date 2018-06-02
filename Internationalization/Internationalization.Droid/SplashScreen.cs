using Android.App;
using Android.Content.PM;
using MvvmCross.Platforms.Android.Presenters.Attributes;
using MvvmCross.Platforms.Android.Views;

namespace Internationalization.Droid
{
	[MvxActivityPresentation]
    [Activity(
        MainLauncher = true,
        NoHistory = true,
        ScreenOrientation = ScreenOrientation.Portrait)]
    public class SplashScreen : MvxSplashScreenActivity
    {
		public SplashScreen()
            : base(Resource.Layout.SplashScreen)
        {
        }
    }
}