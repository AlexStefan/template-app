using MvvmCross.Core.ViewModels;
using MvvmCross.iOS.Views;
using TemplateMenu.Core.ViewModels;
using UIKit;

namespace Template.Touch
{
	public partial class MenuView : MvxViewController
	{
		public MenuView() : base("MenuView", null)
		{
			
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			lbFirst.UserInteractionEnabled = true;
			var gtrMain = new UITapGestureRecognizer(
				() =>
				{
					var app = UIApplication.SharedApplication.Delegate as AppDelegate;
					app.SidebarController.ToggleMenu();
					app.SidebarController.ChangeContentView(CreateViewFor(new MainViewModel(), false));
				});
			lbFirst.AddGestureRecognizer(gtrMain);
			lbSecond.UserInteractionEnabled = true;
			var gtrLogout = new UITapGestureRecognizer(
				() =>
				{
					var app = UIApplication.SharedApplication.Delegate as AppDelegate;
					app.SidebarController.ToggleMenu();
					app.SidebarController.ChangeContentView(CreateViewFor(new SecondViewModel(), false));
				});
			lbSecond.AddGestureRecognizer(gtrLogout);
		}

		private UIViewController CreateViewFor(IMvxViewModel viewModel, bool navBarHidden)
		{
			var controller = new UINavigationController();
			var screen = this.CreateViewControllerFor(viewModel) as UIViewController;
			controller.PushViewController(screen, false);
			controller.NavigationBarHidden = navBarHidden;
			return controller;
		}
	}
}