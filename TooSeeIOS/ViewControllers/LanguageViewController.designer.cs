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
    [Register ("LanguageViewController")]
    partial class LanguageViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel languageNameLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIPickerView languagePicker { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel languageValueLabel { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (languageNameLabel != null) {
                languageNameLabel.Dispose ();
                languageNameLabel = null;
            }

            if (languagePicker != null) {
                languagePicker.Dispose ();
                languagePicker = null;
            }

            if (languageValueLabel != null) {
                languageValueLabel.Dispose ();
                languageValueLabel = null;
            }
        }
    }
}