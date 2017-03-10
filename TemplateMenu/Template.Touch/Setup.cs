using MvvmCross.Core.ViewModels;
using MvvmCross.iOS.Platform;
using MvvmCross.iOS.Views.Presenters;
using TemplateMenu.Core;
using UIKit;

namespace Template.Touch
{
    public class Setup : MvxIosSetup
    {
		private readonly MvxApplicationDelegate appDelegate;
		private readonly UIWindow window;

		public Setup(MvxApplicationDelegate applicationDelegate, UIWindow window)
			: base(applicationDelegate, window)
		{
			appDelegate = applicationDelegate;
			this.window = window;
		}

        protected override IMvxApplication CreateApp()
        {
            return new App();
        }

        protected override IMvxIosViewPresenter CreatePresenter()
		{
			return new SidebarPresenter(appDelegate, window);
		}
    }
}