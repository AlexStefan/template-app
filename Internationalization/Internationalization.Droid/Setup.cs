using Android.Content;
using Internationalization.Core;
using Java.Util;
using MvvmCross.Platform.Android.Core;
using MvvmCross.ViewModels;

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