using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;

namespace Template.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            Mvx.ConstructAndRegisterSingleton<IMvxAppStart, AppStart>();
            var appStart = Mvx.Resolve<IMvxAppStart>();
            RegisterAppStart(appStart);
        }
    }
}