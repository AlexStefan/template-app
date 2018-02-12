using MvvmCross.Plugins.JsonLocalization;
using System.Collections.Generic;

namespace Internationalization.Core.Services
{
    public class TextProviderBuilder : MvxTextProviderBuilder
    {
        public TextProviderBuilder()
            : base(Constants.GeneralNamespace, Constants.RootFolderForResources)
        {
        }

        protected override IDictionary<string, string> ResourceFiles
        {
            get
            {
                return new Dictionary<string, string> { { "strings", "strings" } };
            }
        }
    }
}