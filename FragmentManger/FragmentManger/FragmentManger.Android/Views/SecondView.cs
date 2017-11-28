using Android.OS;
using Android.Runtime;
using Android.Views;
using FragmentManger.Core.ViewModels;
using MvvmCross.Binding.Droid.BindingContext;
using MvvmCross.Droid.Support.V4;

namespace FragmentManger.Droid.Views
{
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