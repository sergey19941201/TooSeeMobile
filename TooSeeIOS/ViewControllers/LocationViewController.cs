using System;
using System.Drawing;
using TooSeePCL;
using UIKit;

namespace TooSeeIOS.ViewControllers
{
    public partial class LocationViewController : UIViewController
    {
		public LocationViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
			var ci = NativeClasses.GetCurrentCulture.GetCurrentCultureInfo();
			Title = TranslationHelper.GetString("Location", ci);
			int marginTop = 15;
            var deviceModel = Xamarin.iOS.DeviceHardware.Model;
			if (deviceModel.Contains("X"))
                marginTop = 35;         

            autoDetectLabel.Text = TranslationHelper.GetString("AutoDetect", ci);
			countryLabel.Text = TranslationHelper.GetString("Country", ci);
			cityLabel.Text = TranslationHelper.GetString("City", ci);
			countryValueLabel.Text = "Россия";
            cityValueLabel.Text = "Москва";

			scrollView.Frame = new Rectangle(0, 0, Convert.ToInt32(View.Frame.Width), Convert.ToInt32(View.Frame.Height));
			autoDetectLabel.Frame = new Rectangle(Convert.ToInt32(View.Frame.Width) / 20, marginTop, Convert.ToInt32(View.Frame.Width) - (Convert.ToInt32(View.Frame.Width) / 20) * 2, 29);
            autoDetectSwitch.Frame = new Rectangle(Convert.ToInt32(View.Frame.Width) - ((Convert.ToInt32(View.Frame.Width) / 20) + Convert.ToInt32(autoDetectSwitch.Frame.Width)), marginTop, Convert.ToInt32(autoDetectSwitch.Frame.Width), 29);
			divider1.Frame = new Rectangle(0, marginTop + Convert.ToInt32(autoDetectLabel.Frame.Height)+10, Convert.ToInt32(View.Frame.Width), 1);
			countryLabel.Frame = new Rectangle(Convert.ToInt32(View.Frame.Width) / 20, marginTop + Convert.ToInt32(autoDetectLabel.Frame.Height) + 20 + 1, Convert.ToInt32(View.Frame.Width) - (Convert.ToInt32(View.Frame.Width) / 20) * 2, 29);
			countryValueLabel.Frame = new Rectangle(Convert.ToInt32(View.Frame.Width) - ((Convert.ToInt32(View.Frame.Width) / 10) + Convert.ToInt32(countryValueLabel.Frame.Width)), marginTop+Convert.ToInt32(autoDetectLabel.Frame.Height) + 20 + 1, Convert.ToInt32(View.Frame.Width) - (Convert.ToInt32(View.Frame.Width) / 20) * 2, 29);
			divider2.Frame = new Rectangle(0, marginTop + Convert.ToInt32(autoDetectLabel.Frame.Height)+Convert.ToInt32(countryLabel.Frame.Height) + 30 + 2, Convert.ToInt32(View.Frame.Width), 1);
			cityLabel.Frame = new Rectangle(Convert.ToInt32(View.Frame.Width) / 20, marginTop + Convert.ToInt32(autoDetectLabel.Frame.Height) + Convert.ToInt32(countryLabel.Frame.Height) + 40 + 3, Convert.ToInt32(View.Frame.Width) - (Convert.ToInt32(View.Frame.Width) / 20) * 2, 29);
			cityValueLabel.Frame = new Rectangle(Convert.ToInt32(View.Frame.Width) - ((Convert.ToInt32(View.Frame.Width) / 10) + Convert.ToInt32(cityValueLabel.Frame.Width)), marginTop + Convert.ToInt32(autoDetectLabel.Frame.Height) + Convert.ToInt32(countryLabel.Frame.Height) + 40 + 3, Convert.ToInt32(View.Frame.Width) - (Convert.ToInt32(View.Frame.Width) / 20) * 2, 29);
			divider3.Frame = new Rectangle(0, marginTop + Convert.ToInt32(autoDetectLabel.Frame.Height) + Convert.ToInt32(countryLabel.Frame.Height)*2 + 50 + 3, Convert.ToInt32(View.Frame.Width), 1);

			countryValueLabel.TextColor = UIColor.FromRGB(147, 146, 152);
			cityValueLabel.TextColor = UIColor.FromRGB(147, 146, 152);
			/*divider1.BackgroundColor = UIColor.FromRGB(147, 146, 152);
			divider2.BackgroundColor = UIColor.FromRGB(147, 146, 152);
			divider3.BackgroundColor = UIColor.FromRGB(147, 146, 152);*/

			//DIVIDERS ARE SILVER COLOR HERE (CHOOSE IN STORYBOARD SILVER PENCIL)
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}

