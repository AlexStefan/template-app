using Android.OS;
using Android.Runtime;
using Android.Views;
using MvvmCross.Binding.Droid.BindingContext;
using MvvmCross.Droid.Shared.Attributes;
using MvvmCross.Droid.Support.V4;
using TemplateMenu.Core.ViewModels;

namespace TemplateMenu.Droid.Views
{
    [MvxFragment(typeof(RootViewModel), Resource.Id.ContentFrame, true)]
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