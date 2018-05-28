using MvvmCross;
using MvvmCross.ViewModels;

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