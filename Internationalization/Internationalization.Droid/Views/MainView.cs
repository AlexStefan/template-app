using Android.App;
using Android.OS;
using Internationalization.Core.ViewModels;
using MvvmCross.Droid.Support.V7.AppCompat;
using MvvmCross.Platforms.Android.Presenters.Attributes;

namespace Internationalization.Droid.Views
{
	[MvxActivityPresentation]
    [Activity(Label = "MainView")]
	public class MainView : MvxAppCompatActivity<MainViewModel>
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
			SetContentView(Resource.Layout.MainView);
        }
    }
}