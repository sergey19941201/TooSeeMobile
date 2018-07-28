// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace TooSeeIOS.ViewControllers
{
    [Register ("AllTasksViewController")]
    partial class AllTasksViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton favoritesBn { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView layoutFiveButtonsView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton messageBn { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton notificationBn { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton playBn { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIScrollView scrollView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton settingsBn { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (favoritesBn != null) {
                favoritesBn.Dispose ();
                favoritesBn = null;
            }

            if (layoutFiveButtonsView != null) {
                layoutFiveButtonsView.Dispose ();
                layoutFiveButtonsView = null;
            }

            if (messageBn != null) {
                messageBn.Dispose ();
                messageBn = null;
            }

            if (notificationBn != null) {
                notificationBn.Dispose ();
                notificationBn = null;
            }

            if (playBn != null) {
                playBn.Dispose ();
                playBn = null;
            }

            if (scrollView != null) {
                scrollView.Dispose ();
                scrollView = null;
            }

            if (settingsBn != null) {
                settingsBn.Dispose ();
                settingsBn = null;
            }
        }
    }
}