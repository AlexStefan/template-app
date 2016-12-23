using Android.App;
using Android.OS;
using Android.Widget;
using ColorConverter.Core.ViewModels;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Droid.Views;

namespace ColorConverter.Droid.Views
{
    [Activity(Label = "MainView", MainLauncher = true)]
    public class MainView : MvxActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.MainView);
            
            var label = FindViewById<TextView>(Resource.Id.tvText);

            var set = this.CreateBindingSet<MainView, MainViewModel>();
            set.Bind(label).For(p => p.CurrentTextColor).To(vm => vm.TextColor).WithConversion("NativeColor");
            set.Apply();
        }
    }
}