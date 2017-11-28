using Android.App;
using Android.OS;
using Android.Widget;
using FragmentManger.Core.ViewModels;
using MvvmCross.Droid.Support.V7.AppCompat;
using Android.Support.V4.Widget;
using FragmentManger.Droid.Custom;
using Android.Support.Design.Widget;
using Android.Runtime;
using Android.Support.V4.View;
using static Android.Support.Design.Widget.BottomNavigationView;
using Android.Views;

namespace FragmentManger.Droid.Views
{
    [Activity(Label = "Template Menu", MainLauncher = true)]
    public class RootView : MvxAppCompatActivity<RootViewModel>, IOnNavigationItemSelectedListener
    {
        private DrawerLayout drawerLayout;
        private LinearLayout drawerMenu;
        private CustomDrawerToggle drawerToggle;
        private ViewPager viewPager;
        private string[] tabTitles = new[] { "Tab 1", "Tab 2", "Tab 3" };

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

            //var set = this.CreateBindingSet<MainView, MainViewModel>();
            //set.Bind(tabTitles).To(vm => vm.Titles);
            //set.Apply();

            var fragments = new Android.Support.V4.App.Fragment[]
            {
                new SecondView(),
                new SecondView(),
                new SecondView()
            };

            var adapter = new TestAdapter(SupportFragmentManager, fragments, CharSequence.ArrayFromStringArray(tabTitles));
            viewPager = FindViewById<ViewPager>(Resource.Id.viewPager);
            viewPager.Adapter = adapter;

            bottomNavigation.SetOnNavigationItemSelectedListener(this);

            //ViewModel.MainScreenCommand.Execute(null);
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