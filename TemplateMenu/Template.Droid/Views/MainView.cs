using Android.App;
using Android.OS;

namespace TemplateMenu.Droid.Views
{
    [Activity(Label = "MainView", MainLauncher = true)]
    public class MainView : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.MainView);
        }
    }
}