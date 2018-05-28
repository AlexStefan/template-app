using Internationalization.Core;
using MvvmCross;
using MvvmCross.Base;
using MvvmCross.IoC;
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
        }
	}
}