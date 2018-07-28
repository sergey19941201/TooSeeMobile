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
    [Register ("ChangePasswordViewController")]
    partial class ChangePasswordViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton changeBn { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel newPasswordLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField newPasswordTF { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel oldPasswordLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField oldPasswordTF { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel repeatPasswordLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField repeatPasswordTF { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIScrollView scrollView { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (changeBn != null) {
                changeBn.Dispose ();
                changeBn = null;
            }

            if (newPasswordLabel != null) {
                newPasswordLabel.Dispose ();
                newPasswordLabel = null;
            }

            if (newPasswordTF != null) {
                newPasswordTF.Dispose ();
                newPasswordTF = null;
            }

            if (oldPasswordLabel != null) {
                oldPasswordLabel.Dispose ();
                oldPasswordLabel = null;
            }

            if (oldPasswordTF != null) {
                oldPasswordTF.Dispose ();
                oldPasswordTF = null;
            }

            if (repeatPasswordLabel != null) {
                repeatPasswordLabel.Dispose ();
                repeatPasswordLabel = null;
            }

            if (repeatPasswordTF != null) {
                repeatPasswordTF.Dispose ();
                repeatPasswordTF = null;
            }

            if (scrollView != null) {
                scrollView.Dispose ();
                scrollView = null;
            }
        }
    }
}