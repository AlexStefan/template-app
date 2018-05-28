using Internationalization.Core.Services;
using MvvmCross;
using MvvmCross.IoC;
using MvvmCross.Localization;
using MvvmCross.Plugin.JsonLocalization;
using MvvmCross.ViewModels;
using System;

namespace Internationalization.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes().EndingWith("Service").AsInterfaces().RegisterAsLazySingleton();
			RegisterCustomAppStart<AppStart>();
			RegisterTextProvider("en");
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