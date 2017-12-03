using Android.App;
using Android.OS;
using Android.Widget;
using FragmentManger.Core.ViewModels;
using MvvmCross.Droid.Support.V7.AppCompat;
using Android.Support.V4.Widget;
using FragmentManger.Droid.Custom;
using Android.Support.Design.Widget;
using Android.Support.V4.View;
using static Android.Support.Design.Widget.BottomNavigationView;
using Android.Views;
using MvvmCross.Droid.Support.V4;
using System.Collections.Generic;

namespace FragmentManger.Droid.Views
{
    [Activity(Label = "Template Menu", MainLauncher = true)]
    public class RootView : MvxAppCompatActivity<RootViewModel>, IOnNavigationItemSelectedListener
    {
        private DrawerLayout drawerLayout;
        private LinearLayout drawerMenu;
        private CustomDrawerToggle drawerToggle;
        private ViewPager viewPager;
        private string[] tabTitles = new[] { "Tab 1", "Tab 2"};

        public new RootViewModel ViewModel
        {
            get { return (RootViewModel)base.ViewModel; }
            set { base.ViewModel = value; }
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.RootView);

            Init();
            SetMenu();
        }

        private void Init()
        {
            drawerLayout = FindViewById<DrawerLayout>(Resource.Id.DrawerLayout);
            drawerMenu = FindViewById<LinearLayout>(Resource.Id.LeftMenu);

            var Toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            if (Toolbar != null)
                SetActionBar(Toolbar);

            drawerToggle = new CustomDrawerToggle(this, drawerLayout, 0, 0);
            drawerLayout.AddDrawerListener(drawerToggle);
            drawerToggle.SyncState();
            drawerLayout.CloseDrawer(drawerMenu);

            var bottomNavigation = FindViewById<BottomNavigationView>(Resource.Id.bottom_navigation);

            var fragments = new List<MvxViewPagerFragmentInfo>()
            {
                new MvxViewPagerFragmentInfo("First", typeof(FirstView), new FirstViewModel()),
                new MvxViewPagerFragmentInfo("Second", typeof(SecondView), new SecondViewModel())
            };

            var adapter = new MvxCachingFragmentStatePagerAdapter(this, SupportFragmentManager, fragments);
            viewPager = FindViewById<ViewPager>(Resource.Id.viewPager);
            viewPager.Adapter = adapter;

            bottomNavigation.SetOnNavigationItemSelectedListener(this);
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
            }
            return true;
        }

        private void SetMenu()
        {
            var home = drawerLayout.FindViewById<LinearLayout>(Resource.Id.lytHome);
            home.Click += (sender, e) => {
                ViewModel.SecondScreenCommand.Execute(null);
                drawerLayout.CloseDrawer(drawerMenu);
            };

            var second = drawerLayout.FindViewById<LinearLayout>(Resource.Id.lytSecondView);
            second.Click += (sender, e) => {
                ViewModel.SecondScreenCommand.Execute(null);
                drawerLayout.CloseDrawer(drawerMenu);
            };
        }
    }
}