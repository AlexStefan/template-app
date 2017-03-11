﻿using MvvmCross.iOS.Views.Presenters;
using UIKit;

namespace Template.Touch
{
	public class SidebarPresenter : MvxIosViewPresenter
	{
		public SidebarPresenter(IUIApplicationDelegate applicationDelegate, UIWindow window)
			: base(applicationDelegate, window)
		{
		}

		protected override UINavigationController CreateNavigationController(UIViewController viewController)
		{
			return base.CreateNavigationController(viewController);
		}
	}
}