using Foundation;
using System;
using System.Drawing;
using TooSeePCL;
using UIKit;

namespace TooSeeIOS
{
    public partial class UploadVideoViewController : UIViewController
    {
		//UIToolbar toolbar;
		NSObject keyboardShowObserver;
        NSObject keyboardHideObserver;
        RectangleF keyboardBounds;
        //bool needToScroll;
        public UploadVideoViewController (IntPtr handle) : base (handle)
        {
        }
		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			int marginTop = 80;
			var deviceModel = Xamarin.iOS.DeviceHardware.Model;

            if (deviceModel.Contains("X"))
               marginTop = 100;

			var ci = NativeClasses.GetCurrentCulture.GetCurrentCultureInfo();
			Title = TranslationHelper.GetString("UploadVideo", ci);
            videoNameLabel.Text = TranslationHelper.GetString("VideoName", ci);
			DescriptionLabel.Text = TranslationHelper.GetString("Description", ci);
			nextBn.SetTitle(TranslationHelper.GetString("Next", ci), UIControlState.Normal);
			VideoNameTV.BackgroundColor = UIColor.FromRGB(237, 243, 250);
			DescriptionTV.BackgroundColor = UIColor.FromRGB(237, 243, 250);

			scrollView.Frame= new Rectangle(0, 0, Convert.ToInt32(View.Frame.Width), Convert.ToInt32(View.Frame.Height));
			videoNameLabel.Frame = new Rectangle(Convert.ToInt32(View.Frame.Width) /20, marginTop, Convert.ToInt32(View.Frame.Width) - (Convert.ToInt32(View.Frame.Width) / 20) * 2, 29);
			VideoNameTV.Frame = new Rectangle(Convert.ToInt32(View.Frame.Width) / 20, marginTop+Convert.ToInt32(videoNameLabel.Frame.Height)+9, Convert.ToInt32(View.Frame.Width) - (Convert.ToInt32(View.Frame.Width) / 20)*2, 29);
			DescriptionLabel.Frame = new Rectangle(Convert.ToInt32(View.Frame.Width) / 20, marginTop + Convert.ToInt32(videoNameLabel.Frame.Height) + 9+ Convert.ToInt32(VideoNameTV.Frame.Height)+30, Convert.ToInt32(View.Frame.Width) - (Convert.ToInt32(View.Frame.Width) / 20) * 2, 29);
			DescriptionTV.Frame = new Rectangle(Convert.ToInt32(View.Frame.Width) / 20, marginTop + Convert.ToInt32(videoNameLabel.Frame.Height) + 9 + Convert.ToInt32(VideoNameTV.Frame.Height) + 30+Convert.ToInt32(DescriptionLabel.Frame.Height)+9, Convert.ToInt32(View.Frame.Width) - (Convert.ToInt32(View.Frame.Width) / 20) * 2, 90);
			nextBn.Frame = new Rectangle(Convert.ToInt32(View.Frame.Width) / 20, marginTop + Convert.ToInt32(videoNameLabel.Frame.Height) + 9 + Convert.ToInt32(VideoNameTV.Frame.Height) + 30 + Convert.ToInt32(DescriptionLabel.Frame.Height) + 9+Convert.ToInt32(DescriptionTV.Frame.Height)+20, Convert.ToInt32(View.Frame.Width) - (Convert.ToInt32(View.Frame.Width) / 20) * 2, 50);
			VideoNameTV.Layer.CornerRadius = 5;
			DescriptionTV.Layer.CornerRadius = 5;
			videoNameLabel.TextColor = UIColor.FromRGB(13, 34, 58);
			DescriptionLabel.TextColor = UIColor.FromRGB(13, 34, 58);
			nextBn.BackgroundColor = UIColor.FromRGB(74, 167, 91);
			nextBn.Layer.CornerRadius = 15;

			//fires when keyboard shows
            keyboardShowObserver = NSNotificationCenter.DefaultCenter.AddObserver(UIKeyboard.WillShowNotification, (notification) =>
            {
                NSValue nsKeyboardBounds = (NSValue)notification.UserInfo.ObjectForKey(UIKeyboard.BoundsUserInfoKey);
                keyboardBounds = nsKeyboardBounds.RectangleFValue;

				if (deviceModel.Contains("e 4")||deviceModel.Contains("e 5"))
                    {
					      scrollView.ContentOffset = new CoreGraphics.CGPoint(0, keyboardBounds.Height-200);
					      scrollView.ContentSize = new CoreGraphics.CGSize(View.Frame.Width, View.Frame.Height+100);
                    }
            });
            //fires when keyboard hides
            keyboardHideObserver = NSNotificationCenter.DefaultCenter.AddObserver(UIKeyboard.WillHideNotification, (notification) =>
            {
                //centering scroll
                scrollView.ContentOffset = new CoreGraphics.CGPoint(0, 0);
            });
        }
    }
}