using Android.App;
using Android.OS;
using MvvmCross.Droid.Views;

namespace Internationalization.Droid.Views
{
    [Activity(Label = "MainView", MainLauncher = true)]
    public class MainView : MvxActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.MainView);
        }
    }
}