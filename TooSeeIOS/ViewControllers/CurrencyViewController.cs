using System;
using System.Collections.Generic;
using TooSeePCL;
using UIKit;

namespace TooSeeIOS.ViewControllers
{
    public partial class CurrencyViewController : UIViewController
    {
        public CurrencyViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            int marginTop = 80;
            var deviceModel = Xamarin.iOS.DeviceHardware.Model;

            if (deviceModel.Contains("X"))
                marginTop = 100;
            // Perform any additional setup after loading the view, typically from a nib.
            var ci = NativeClasses.GetCurrentCulture.GetCurrentCultureInfo();
            Title = TranslationHelper.GetString("CurrencySelection", ci);
            currencyNameLabel.Text = TranslationHelper.GetString("YourCurrency", ci);
            currencyValueLabel.Text = "std";

            currencyNameLabel.Frame= new CoreGraphics.CGRect(10, marginTop, Convert.ToInt32(View.Frame.Width)/2, 30);
            currencyValueLabel.Frame = new CoreGraphics.CGRect(Convert.ToInt32(View.Frame.Width)-(Convert.ToInt32(View.Frame.Width) / 4)-10, marginTop, Convert.ToInt32(View.Frame.Width)/4, 30);
            currencyPicker.Frame = new CoreGraphics.CGRect(0, marginTop+currencyValueLabel.Frame.Height, Convert.ToInt32(View.Frame.Width), Convert.ToInt32(View.Frame.Height/2));
            currencyPicker.Select(1, 0, true);

            var pickerModel = new CurrencyPickerModel(currencyValueLabel);

            currencyPicker.Model = pickerModel;
            //set selected index by default
            currencyPicker.Select(2,0, true);
        }


        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}

