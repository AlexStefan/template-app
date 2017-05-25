using MvvmCross.Core.ViewModels;
using TemplateSettings.Core.Helpers;

namespace TemplateSettings.Core.ViewModels
{
    public class MainViewModel : MvxViewModel
    {
        public string GeneralSetting
        {
            get 
            {
                return Settings.GeneralSettings;    
            }
            set
            {
				if (Settings.GeneralSettings == value)
					return;

				Settings.GeneralSettings = value;
            }
        }
    }
}