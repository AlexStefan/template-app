using Internationalization.Core.Helpers;
using Java.Util;

namespace Internationalization.Droid.Helpers
{
	public class AppInfo : IAppInfo
    {      
		public string CurrentLanguage => Locale.Default.Language;
	}
}