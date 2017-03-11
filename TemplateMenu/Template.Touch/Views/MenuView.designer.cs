// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace Template.Touch
{
    [Register ("MenuView")]
    partial class MenuView
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lbFirst { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lbSecond { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (lbFirst != null) {
                lbFirst.Dispose ();
                lbFirst = null;
            }

            if (lbSecond != null) {
                lbSecond.Dispose ();
                lbSecond = null;
            }
        }
    }
}