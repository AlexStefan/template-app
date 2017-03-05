using Android.OS;
using Android.Runtime;
using Android.Views;
using TemplateMenu.Core.ViewModels;
using MvvmCross.Droid.Shared.Attributes;
using MvvmCross.Binding.Droid.BindingContext;
using MvvmCross.Droid.Support.V4;

namespace TemplateMenu.Droid.Views
{
    [MvxFragment(typeof(MainViewModel), Resource.Id.ContentFrame, true)]
    [Register("SecondView")]
    public class SecondView : MvxFragment<SecondViewModel>
    {
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var ignored = base.OnCreateView(inflater, container, savedInstanceState);
            var view = this.BindingInflate(Resource.Layout.SecondView, null);
            return view;
        }
    }
}