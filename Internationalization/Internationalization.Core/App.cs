using Internationalization.Core.Helpers;
using Internationalization.Core.Services;
using Internationalization.Core.ViewModels;
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
			RegisterAppStart<MainViewModel>();
            RegisterTextProvider(Mvx.Resolve<IAppInfo>().CurrentLanguage);
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