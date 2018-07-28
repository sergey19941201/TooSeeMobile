using System;
using TooSeeIOS.NativeModels;
using TooSeePCL;
using UIKit;

namespace TooSeeIOS.ViewControllers
{
    public partial class CityChooseViewController : UIViewController
    {
        public CityChooseViewController(IntPtr handle) : base(handle)
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
            Title = TranslationHelper.GetString("CitySelection", ci);
            cityNameLabel.Text = TranslationHelper.GetString("YourCity", ci);
            cityValueLabel.Text = "std";

            cityNameLabel.Frame = new CoreGraphics.CGRect(10, marginTop, Convert.ToInt32(View.Frame.Width) / 2, 30);
            cityValueLabel.Frame = new CoreGraphics.CGRect(Convert.ToInt32(View.Frame.Width) - (Convert.ToInt32(View.Frame.Width) / 2) - 10, marginTop, Convert.ToInt32(View.Frame.Width) / 2, 30);
            cityPicker.Frame = new CoreGraphics.CGRect(0, marginTop +cityValueLabel.Frame.Height, Convert.ToInt32(View.Frame.Width), Convert.ToInt32(View.Frame.Height / 2));
            cityPicker.Select(1, 0, true);

            var pickerModel = new CityPickerModel(cityValueLabel);

            cityPicker.Model = pickerModel;
            //set selected index by default
            cityPicker.Select(2, 0, true);
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}

