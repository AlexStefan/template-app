using System;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Support.V4.View;
using Android.Views;
using FragmentManger.Core.ViewModels;
using MvvmCross.Binding.Droid.BindingContext;
using MvvmCross.Droid.Support.V4;
using MvvmCross.Droid.Views.Attributes;
using static Android.Support.Design.Widget.BottomNavigationView;

namespace FragmentManger.Droid.Views
{
    [MvxFragmentPresentation(typeof(RootViewModel), Resource.Id.ContentFrame, true)]
    [Register("MainView")]
    public class MainView : MvxFragment<MainViewModel>, IOnNavigationItemSelectedListener
    {
        private ViewPager viewPager;

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var ignored = base.OnCreateView(inflater, container, savedInstanceState);
            var view = this.BindingInflate(Resource.Layout.MainView, container, false);

            var bottomNavigation = view.FindViewById<BottomNavigationView>(Resource.Id.bottom_navigation);

            var titles = CharSequence.ArrayFromStringArray(new[] { "Time", "Stopwatch", "About" });
            var fragments = new Android.Support.V4.App.Fragment[]
            {
                new SecondView(),
                new SecondView(),
                new SecondView()
            };

            var adapter = new TestAdapter(this.Activity.SupportFragmentManager, fragments, titles);
            viewPager = view.FindViewById<ViewPager>(Resource.Id.viewPager);
            viewPager.Adapter = adapter;

            bottomNavigation.SetOnNavigationItemSelectedListener(this);

            return view;
        }

        public bool OnNavigationItemSelected(IMenuItem item)
        {
            switch (item.ItemId)
            {
                case Resource.Id.menu_home:
                    viewPager.CurrentItem = 0;
                    break;
                case Resource.Id.menu_audio:
                    viewPager.CurrentItem = 1;
                    break;
                case Resource.Id.menu_video:
                    viewPager.CurrentItem = 2;
                    break;
            }
            return true;
        }
    }
}