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
    [Register ("CurrencyViewController")]
    partial class CurrencyViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel currencyNameLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIPickerView currencyPicker { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel currencyValueLabel { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (currencyNameLabel != null) {
                currencyNameLabel.Dispose ();
                currencyNameLabel = null;
            }

            if (currencyPicker != null) {
                currencyPicker.Dispose ();
                currencyPicker = null;
            }

            if (currencyValueLabel != null) {
                currencyValueLabel.Dispose ();
                currencyValueLabel = null;
            }
        }
    }
}