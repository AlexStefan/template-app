using Internationalization.Core.Services;
using MvvmCross.Core.ViewModels;
using MvvmCross.Localization;
using MvvmCross.Platform;
using MvvmCross.Platform.IoC;
using MvvmCross.Plugins.JsonLocalization;
using System;

namespace Internationalization.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes().EndingWith("Service").AsInterfaces().RegisterAsLazySingleton();

            Mvx.ConstructAndRegisterSingleton<IMvxAppStart, AppStart>();
            var appStart = Mvx.Resolve<IMvxAppStart>();
            RegisterAppStart(appStart);
        }

        public void RegisterTextProvider(string currentLanguage)
        { 
            var builder = new TextProviderBuilder();
            Mvx.RegisterSingleton<IMvxTextProviderBuilder>(builder);
            Mvx.RegisterSingleton<IMvxTextProvider>(builder.TextProvider);
            if (Enum.IsDefined(typeof(SupportedLanguages), currentLanguage))
                builder.LoadResources(currentLanguage);
            else
                builder.LoadResources(string.Empty);
        }
    }
}