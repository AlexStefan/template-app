using Android.Content;
using MvvmCross.Core.ViewModels;
using MvvmCross.Droid.Platform;
using Internationalization.Core;
using Java.Util;

namespace Internationalization.Droid
{
    public class Setup : MvxAndroidSetup
    {
        public Setup(Context applicationContext) : base(applicationContext)
        {
        }

        protected override IMvxApplication CreateApp()
        {
            var app = new App();
            app.RegisterTextProvider(Locale.Default.Language);
            return app;
        }
    }
}