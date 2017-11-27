using System.Collections.Generic;
using Android.Content;
using MvvmCross.Droid.Platform;
using System.Reflection;
using MvvmCross.Core.ViewModels;
using FragmentManger.Core;
using MvvmCross.Droid.Views;
using MvvmCross.Droid.Support.V7.AppCompat;

namespace FragmentManger.Droid
{
    public class Setup : MvxAndroidSetup
    {
        protected override IEnumerable<Assembly> AndroidViewAssemblies => new List<Assembly>(base.AndroidViewAssemblies)
        {
            typeof(Android.Support.V7.Widget.Toolbar).Assembly,
            typeof(Android.Support.V4.Widget.DrawerLayout).Assembly,
            typeof(Android.Support.V4.View.ViewPager).Assembly
        };

        public Setup(Context applicationContext) : base(applicationContext)
        {
        }

        protected override IMvxApplication CreateApp()
        {
            return new App();
        }
        protected override IMvxAndroidViewPresenter CreateViewPresenter()
        {
            return new MvxAppCompatViewPresenter(this.AndroidViewAssemblies);
        }
    }
}