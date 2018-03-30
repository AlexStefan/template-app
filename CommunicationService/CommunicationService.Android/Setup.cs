using CommunicationService.Core;
using MvvmCross.Platforms.Android.Core;
using MvvmCross.ViewModels;

namespace CommunicationService.Droid
{
    public class Setup : MvxAndroidSetup
    {
        public Setup() : base()
        {
        }

        protected override IMvxApplication CreateApp()
        {
            return new App();
        }
    }
}