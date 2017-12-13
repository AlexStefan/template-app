using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;
using System;

namespace CommunicationService.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            Mvx.ConstructAndRegisterSingleton<IMvxAppStart, AppStart>();
            RegisterAppStart(Mvx.Resolve<IMvxAppStart>());
        }
    }
}