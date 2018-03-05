using MvvmCross.Localization;
using MvvmCross.Plugin.JsonLocalization;
using MvvmCross.ViewModels;

namespace Internationalization.Core.ViewModels
{
    public class MainViewModel : MvxViewModel
    {
        private readonly IMvxTextProviderBuilder builder;

        public MainViewModel(IMvxTextProviderBuilder builder)
        {
            this.builder = builder;
        }

        public string DynamicText
        {
            get
            {
                return TextSource.GetText("DynamicValue");
            }
        }

        public IMvxLanguageBinder TextSource
        {
            get 
            {
                return new MvxLanguageBinder(Constants.GeneralNamespace, "strings");
            }
        }
    }
}