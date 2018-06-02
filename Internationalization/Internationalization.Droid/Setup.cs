using Internationalization.Core;
using Internationalization.Core.Helpers;
using Internationalization.Droid.Helpers;
using MvvmCross;
using MvvmCross.Base;
using MvvmCross.Droid.Support.V7.AppCompat;
using MvvmCross.Plugin.Json;

namespace Internationalization.Droid
{
	public class Setup : MvxAppCompatSetup<App>
	{
        protected override void InitializeFirstChance()
        {
            base.InitializeFirstChance();

            Mvx.RegisterType<IMvxJsonConverter, MvxJsonConverter>();
            Mvx.RegisterType<IAppInfo, AppInfo>();
        }
    }
}