using Foundation;
using Internationalization.Core;
using MvvmCross;
using MvvmCross.Base;
using MvvmCross.Platform.Ios.Core;
using MvvmCross.Platform.Ios.Presenters;
using MvvmCross.Plugin.Json;
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
            app.RegisterTextProvider(NSLocale.CurrentLocale.LanguageCode);
            return app;
        }

		protected override void InitializeFirstChance()
		{
            Mvx.RegisterSingleton<IMvxJsonConverter>(new MvxJsonConverter());
            base.InitializeFirstChance();
		}
	}
}