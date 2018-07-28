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
    [Register ("LocationViewController")]
    partial class LocationViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel autoDetectLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UISwitch autoDetectSwitch { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel cityLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel cityValueLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel countryLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel countryValueLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView divider1 { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView divider2 { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView divider3 { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIScrollView scrollView { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (autoDetectLabel != null) {
                autoDetectLabel.Dispose ();
                autoDetectLabel = null;
            }

            if (autoDetectSwitch != null) {
                autoDetectSwitch.Dispose ();
                autoDetectSwitch = null;
            }

            if (cityLabel != null) {
                cityLabel.Dispose ();
                cityLabel = null;
            }

            if (cityValueLabel != null) {
                cityValueLabel.Dispose ();
                cityValueLabel = null;
            }

            if (countryLabel != null) {
                countryLabel.Dispose ();
                countryLabel = null;
            }

            if (countryValueLabel != null) {
                countryValueLabel.Dispose ();
                countryValueLabel = null;
            }

            if (divider1 != null) {
                divider1.Dispose ();
                divider1 = null;
            }

            if (divider2 != null) {
                divider2.Dispose ();
                divider2 = null;
            }

            if (divider3 != null) {
                divider3.Dispose ();
                divider3 = null;
            }

            if (scrollView != null) {
                scrollView.Dispose ();
                scrollView = null;
            }
        }
    }
}