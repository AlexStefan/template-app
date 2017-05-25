// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace TemplateSettings.Touch.Views
{
    [Register ("MainView")]
    partial class MainView
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField GeneralLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.NSLayoutConstraint TestLabel { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (GeneralLabel != null) {
                GeneralLabel.Dispose ();
                GeneralLabel = null;
            }

            if (TestLabel != null) {
                TestLabel.Dispose ();
                TestLabel = null;
            }
        }
    }
}