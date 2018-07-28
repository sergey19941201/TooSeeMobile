using System;
using TooSeeIOS.NativeModels;
using TooSeePCL;
using UIKit;


namespace TooSeeIOS.ViewControllers
{
    public partial class LanguageViewController : UIViewController
    {
        public LanguageViewController(IntPtr handle) : base(handle)
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
            Title = TranslationHelper.GetString("LanguageSelection", ci);
            languageNameLabel.Text = TranslationHelper.GetString("YourLanguage", ci);
            languageValueLabel.Text = "std";

            languageNameLabel.Frame = new CoreGraphics.CGRect(10, marginTop, Convert.ToInt32(View.Frame.Width) / 2, 30);
            languageValueLabel.Frame = new CoreGraphics.CGRect(Convert.ToInt32(View.Frame.Width) - (Convert.ToInt32(View.Frame.Width) / 2) - 10, marginTop, Convert.ToInt32(View.Frame.Width) / 2, 30);
            languagePicker.Frame = new CoreGraphics.CGRect(0, marginTop + languageValueLabel.Frame.Height, Convert.ToInt32(View.Frame.Width), Convert.ToInt32(View.Frame.Height / 2));
            languagePicker.Select(1, 0, true);

            var pickerModel = new LanguagePickerModel(languageValueLabel);

            languagePicker.Model = pickerModel;
            //set selected index by default
            languagePicker.Select(2, 0, true);
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}

