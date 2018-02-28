using Android.Content;
using ExpandableList.Core;
using MvvmCross.Platform.Android.Core;
using MvvmCross.ViewModels;

namespace ExpandableList.Droid
{
    public class Setup : MvxAndroidSetup
    {
        public Setup(Context applicationContext) : base(applicationContext)
        {
        }

        protected override IMvxApplication CreateApp()
        {
            return new App();
        }
    }
}