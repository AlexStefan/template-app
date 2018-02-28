using MvvmCross.IoC;
using System.ComponentModel;

namespace Internationalization.Droid
{
    public class LinkerPleaseInclude
    {
        public void Include(MvxPropertyInjector injector)
        {
            injector = new MvxPropertyInjector();
        }

        public void Include(INotifyPropertyChanged changed)
        {
            changed.PropertyChanged += (sender, e) => {
                var test = e.PropertyName;
            };
        }
    }
}