using System.IO;
using Foundation;
using Internationalization.Core;
using MvvmCross.Platform.Ios.Core;
using MvvmCross.Platform.Ios.Presenters;
using MvvmCross.ViewModels;

namespace Internationalization.Touch
{
    public class Setup : MvxIosSetup
    {
        public Setup(MvxApplicationDelegate appDelegate, IMvxIosViewPresenter presenter)
            : base(appDelegate, presenter)
        {
        }

        protected override IMvxApplication CreateApp()
        {
            var app = new App();
            var fileStream = File.Open("Strings/en/strings.json", FileMode.Open, FileAccess.Read, FileShare.ReadWrite);

            app.RegisterTextProvider(NSLocale.CurrentLocale.LanguageCode);
            return app;
        }
    }
}