using Android.App;
using Android.Support.V4.Widget;
using Android.Support.V7.App;
using Android.Views;

namespace TemplateMenu.Droid.Custom
{
    [Activity(Label = "CustomDrawerToggle")]
    public class CustomDrawerToggle : ActionBarDrawerToggle
    {
        private Activity host;
        private int openedResource;
        private int closedResource;

        public CustomDrawerToggle(Activity host, DrawerLayout drawerLayout, int openedResource, int closedResource)
            : base(host, drawerLayout, openedResource, closedResource)
        {
            this.host = host;
            this.openedResource = openedResource;
            this.closedResource = closedResource;
        }

        public override void OnDrawerClosed(View drawerView)
        {
            host.InvalidateOptionsMenu();
        }

        public override void OnDrawerOpened(View drawerView)
        {
            host.InvalidateOptionsMenu();
        }
    }
}