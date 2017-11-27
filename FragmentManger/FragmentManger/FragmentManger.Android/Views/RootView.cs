using Android.App;
using Android.OS;
using Android.Widget;
using FragmentManger.Core.ViewModels;
using MvvmCross.Droid.Support.V7.AppCompat;
using Android.Support.V4.Widget;
using FragmentManger.Droid.Custom;

namespace FragmentManger.Droid.Views
{
    [Activity(Label = "Template Menu", MainLauncher = true)]
    public class RootView : MvxAppCompatActivity<RootViewModel>
    {
        private DrawerLayout drawerLayout;
        private LinearLayout drawerMenu;
        private CustomDrawerToggle drawerToggle;

        public new RootViewModel ViewModel
        {
            get { return (RootViewModel)base.ViewModel; }
            set { base.ViewModel = value; }
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.NavigationDrawer);

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

            ViewModel.MainScreenCommand.Execute(null);
        }

        private void SetMenu()
        {
            var home = drawerLayout.FindViewById<LinearLayout>(Resource.Id.lytHome);
            home.Click += (sender, e) => {
                ViewModel.MainScreenCommand.Execute(null);
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