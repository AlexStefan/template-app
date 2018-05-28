using Internationalization.Core;
using Internationalization.Core.Helpers;
using Internationalization.Touch.Helpers;
using MvvmCross;
using MvvmCross.Base;
using MvvmCross.Platforms.Ios.Core;
using MvvmCross.Plugin.Json;

namespace Internationalization.Touch
{
	public class Setup : MvxIosSetup<App>
    {      
		protected override void InitializeFirstChance()
        {
            base.InitializeFirstChance();
            
            Mvx.RegisterType<IMvxJsonConverter, MvxJsonConverter>();
			Mvx.RegisterType<IAppInfo, AppInfo>();
        }
	}
}