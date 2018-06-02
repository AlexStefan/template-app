using System;
using Android.App;
using Android.Runtime;
using Internationalization.Core;
using MvvmCross.Droid.Support.V7.AppCompat;

namespace Internationalization.Droid
{
	[Application]
    public class MainApplication : MvxAppCompatApplication<Setup, App>
    {
        public MainApplication()
        {
        }

        public MainApplication(IntPtr javaReference, JniHandleOwnership transfer)
            : base(javaReference, transfer)
        {
        }
    }
}