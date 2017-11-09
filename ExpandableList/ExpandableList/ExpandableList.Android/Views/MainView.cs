using Android.App;
using Android.OS;
using Android.Util;
using MvvmCross.Droid.Support.V7.AppCompat;
using System;

namespace ExpandableList.Droid.Views
{
    [Activity(Label = "MainView", MainLauncher = true)]
    public class MainView : MvxAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            try
            {
                base.OnCreate(savedInstanceState);
                SetContentView(Resource.Layout.MainView);
            }
            catch (Exception ex)
            {
                Log.Debug("Teeeeeeeeeeeeeeeeeeeeeeeest", ex.Message);
            }
        }
    }
}