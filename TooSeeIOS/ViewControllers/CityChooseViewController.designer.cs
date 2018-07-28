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
    [Register ("CityChooseViewController")]
    partial class CityChooseViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel cityNameLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIPickerView cityPicker { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel cityValueLabel { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (cityNameLabel != null) {
                cityNameLabel.Dispose ();
                cityNameLabel = null;
            }

            if (cityPicker != null) {
                cityPicker.Dispose ();
                cityPicker = null;
            }

            if (cityValueLabel != null) {
                cityValueLabel.Dispose ();
                cityValueLabel = null;
            }
        }
    }
}