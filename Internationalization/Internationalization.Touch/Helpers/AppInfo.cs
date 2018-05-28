using Foundation;
using Internationalization.Core.Helpers;

namespace Internationalization.Touch.Helpers
{
	public class AppInfo : IAppInfo
    {
		public string CurrentLanguage => NSLocale.CurrentLocale.CountryCode.ToLower();
	}
}