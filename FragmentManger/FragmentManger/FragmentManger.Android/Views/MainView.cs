using Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Support.V4.View;
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

            var tabLayout = view.FindViewById<TabLayout>(Resource.Id.tabLayout);

            var titles = CharSequence.ArrayFromStringArray(new[] { "Time", "Stopwatch", "About" });
            var fragments = new Android.Support.V4.App.Fragment[]
            {
                new SecondView(),
                new SecondView(),
                new SecondView()
            };

            var adapter = new TestAdapter(this.Activity.SupportFragmentManager, fragments, titles);
            var viewPager = view.FindViewById<ViewPager>(Resource.Id.viewPager);
            viewPager.Adapter = adapter;

            tabLayout.SetupWithViewPager(viewPager);

            tabLayout.GetTabAt(0).SetIcon(Resource.Drawable.ic_menu_white_24dp);
            tabLayout.GetTabAt(1).SetIcon(Resource.Drawable.ic_home_white_24dp);
            tabLayout.GetTabAt(2).SetIcon(Resource.Drawable.ic_settings_white_24dp);

            return view;
        }
    }
}