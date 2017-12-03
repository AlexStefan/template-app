using Android.App;
using Android.OS;
using MvvmCross.Droid.Support.V7.AppCompat;
using FragmentManger.Core.ViewModels;

namespace FragmentManger.Droid.Views
{
    [Activity(Label = "About")]
    public class AboutView : MvxAppCompatActivity<AboutViewModel>
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.AboutView);
        }
    }
}