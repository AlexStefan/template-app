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
            //It seems that the language code keeps en for some unkown reason. Workaround for the moment with using the country code.
            app.RegisterTextProvider(NSLocale.CurrentLocale.CountryCode.ToLower());
            return app;
        }

		protected override void InitializeFirstChance()
		{
            Mvx.RegisterSingleton<IMvxJsonConverter>(new MvxJsonConverter());
            base.InitializeFirstChance();
		}
	}
}