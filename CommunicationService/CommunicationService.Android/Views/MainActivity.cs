using Android.App;
using Android.OS;
using CommunicationService.Core.ViewModels;
using MvvmCross.Droid.Support.V7.AppCompat;

namespace CommunicationService.Droid.Views
{
	[Activity (Label = "CommunicationService.Android", MainLauncher = true, Icon = "@drawable/icon", Theme = "@style/Theme.AppCompat.Light.DarkActionBar")]
	public class MainActivity : MvxAppCompatActivity<MainViewModel>
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);
		}
	}
}