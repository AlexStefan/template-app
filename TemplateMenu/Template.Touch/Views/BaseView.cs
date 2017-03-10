using System;
using MvvmCross.Core.ViewModels;
using MvvmCross.iOS.Views;
using SidebarNavigation;
using TemplateMenu.Core;
using UIKit;

namespace Template.Touch
{
	public partial class BaseView : MvxViewController
	{
		public BaseViewModel RootViewModel
		{
			get { return (BaseViewModel)ViewModel; }
			set { ViewModel = value; }
		}

		public BaseView() : base("BaseView", null)
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			if (ViewModel == null)
				return;

			var size = NavigationController.View.Frame;
			size.Width = UIScreen.MainScreen.Bounds.Width;
			size.Height = UIScreen.MainScreen.Bounds.Height;
			View.Frame = size;

			var app = UIApplication.SharedApplication.Delegate as AppDelegate;
			app.SidebarController = new SidebarController(this, CreateViewFor(RootViewModel.Home, false), CreateViewFor(RootViewModel.Menu, true));
			app.SidebarController.MenuWidth = 220;
			app.SidebarController.ReopenOnRotate = false;
			app.SidebarController.MenuLocation = MenuLocations.Left;

			NavigationItem.BackBarButtonItem = new UIBarButtonItem("", UIBarButtonItemStyle.Plain, null);
		}

		public override void ViewWillAppear(bool animated)
		{
			base.ViewWillAppear(animated);
			NavigationController.SetNavigationBarHidden(true, true);
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