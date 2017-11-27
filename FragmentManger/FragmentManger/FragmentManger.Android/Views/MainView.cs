using Android.OS;
using Android.Runtime;
using Android.Views;
using FragmentManger.Core.ViewModels;
using MvvmCross.Binding.Droid.BindingContext;
using MvvmCross.Droid.Support.V4;
using MvvmCross.Droid.Views.Attributes;

namespace FragmentManger.Droid.Views
{
    [MvxFragmentPresentation(typeof(RootViewModel), Resource.Id.ContentFrame, true)]
    [Register("MainView")]
    public class MainView : MvxFragment<MainViewModel>
    {
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var ignored = base.OnCreateView(inflater, container, savedInstanceState);
            var view = this.BindingInflate(Resource.Layout.MainView, container, false);
            return view;
        }
    }
}