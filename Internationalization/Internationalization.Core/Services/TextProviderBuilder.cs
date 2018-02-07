using MvvmCross.Platform.IoC;
using MvvmCross.Plugins.JsonLocalization;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Internationalization.Core.Services
{
    public class TextProviderBuilder
        : MvxTextProviderBuilder
    {
        public TextProviderBuilder()
            : base(Constants.GeneralNamespace, Constants.RootFolderForResources)
        {
        }

        protected override IDictionary<string, string> ResourceFiles
        {
            get
            {
                var dictionary = this.GetType()
                    .GetTypeInfo()
                    .Assembly
                    .CreatableTypes()
                    .ToDictionary(t => t.Name, t => t.Name);

                return dictionary;
            }
        }
    }
}