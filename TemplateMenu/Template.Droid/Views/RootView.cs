using Android.App;
using Android.OS;
using Android.Support.V4.Widget;
using Android.Views;
using Android.Widget;
using MvvmCross.Droid.Support.V7.AppCompat;
using TemplateMenu.Core.ViewModels;
using TemplateMenu.Droid.Custom;

namespace TemplateMenu.Droid.Views
{
    [Activity(Label = "Template Menu", MainLauncher = true, Theme = "@style/Theme.Main")]
    public class RootView : MvxCachingFragmentCompatActivity
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
            var imgMenu = FindViewById<ImageView>(Resource.Id.btnLeftToolbar);
            imgMenu.Click += (sender, e) => drawerLayout.OpenDrawer((int)GravityFlags.Start);

            drawerToggle = new CustomDrawerToggle(this, drawerLayout, 0, 0);
            drawerLayout.SetDrawerListener(drawerToggle);
            drawerToggle.SyncState();
            drawerLayout.CloseDrawer(drawerMenu);
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