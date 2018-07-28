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

namespace TooSeeIOS
{
    [Register ("LaunchViewController")]
    partial class LaunchViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIScrollView greenscroll { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView mainView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel newTasksLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIScrollView orangescroll { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIScrollView pinkscroll { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel popularCitiesLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel popularVideosLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIScrollView scrollView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel TitleTV { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView upperView { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (greenscroll != null) {
                greenscroll.Dispose ();
                greenscroll = null;
            }

            if (mainView != null) {
                mainView.Dispose ();
                mainView = null;
            }

            if (newTasksLabel != null) {
                newTasksLabel.Dispose ();
                newTasksLabel = null;
            }

            if (orangescroll != null) {
                orangescroll.Dispose ();
                orangescroll = null;
            }

            if (pinkscroll != null) {
                pinkscroll.Dispose ();
                pinkscroll = null;
            }

            if (popularCitiesLabel != null) {
                popularCitiesLabel.Dispose ();
                popularCitiesLabel = null;
            }

            if (popularVideosLabel != null) {
                popularVideosLabel.Dispose ();
                popularVideosLabel = null;
            }

            if (scrollView != null) {
                scrollView.Dispose ();
                scrollView = null;
            }

            if (TitleTV != null) {
                TitleTV.Dispose ();
                TitleTV = null;
            }

            if (upperView != null) {
                upperView.Dispose ();
                upperView = null;
            }
        }
    }
}