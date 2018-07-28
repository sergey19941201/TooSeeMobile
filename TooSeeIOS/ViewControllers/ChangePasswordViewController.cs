using System;
using System.Drawing;
using Foundation;
using TooSeePCL;
using UIKit;

namespace TooSeeIOS.ViewControllers
{
    public partial class ChangePasswordViewController : UIViewController
    {
		NSObject keyboardShowObserver;
        NSObject keyboardHideObserver;
        RectangleF keyboardBounds;
        bool needToScroll;
		public ChangePasswordViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
			//fires when keyboard shows
			int marginTop = 5;
            var deviceModel = Xamarin.iOS.DeviceHardware.Model;

            keyboardShowObserver = NSNotificationCenter.DefaultCenter.AddObserver(UIKeyboard.WillShowNotification, (notification) =>
            {
                NSValue nsKeyboardBounds = (NSValue)notification.UserInfo.ObjectForKey(UIKeyboard.BoundsUserInfoKey);
                keyboardBounds = nsKeyboardBounds.RectangleFValue;

				if (deviceModel.Contains("e 4") || deviceModel.Contains("e 5"))
                {
                    scrollView.ContentOffset = new CoreGraphics.CGPoint(0, keyboardBounds.Height - 200);
                }
				scrollView.ContentSize = new CoreGraphics.CGSize(View.Frame.Width, View.Frame.Height + 100);
            });
            //fires when keyboard hides
            keyboardHideObserver = NSNotificationCenter.DefaultCenter.AddObserver(UIKeyboard.WillHideNotification, (notification) =>
            {
                //centering scroll
				scrollView.ContentOffset = new CoreGraphics.CGPoint(0, 0);
            });



            if (deviceModel.Contains("X"))
                marginTop = 25;

            var ci = NativeClasses.GetCurrentCulture.GetCurrentCultureInfo();
			Title = TranslationHelper.GetString("ChangePassword", ci);
			oldPasswordLabel.Text = TranslationHelper.GetString("OldPassword", ci);
			newPasswordLabel.Text = TranslationHelper.GetString("NewPassword", ci);
			repeatPasswordLabel.Text = TranslationHelper.GetString("RepeatPassword", ci);
			changeBn.SetTitle(TranslationHelper.GetString("Change", ci), UIControlState.Normal);
			oldPasswordTF.BackgroundColor = UIColor.FromRGB(237, 243, 250);
			newPasswordTF.BackgroundColor = UIColor.FromRGB(237, 243, 250);
			repeatPasswordTF.BackgroundColor = UIColor.FromRGB(237, 243, 250);

            scrollView.Frame = new Rectangle(0, 0, Convert.ToInt32(View.Frame.Width), Convert.ToInt32(View.Frame.Height));
			oldPasswordLabel.Frame = new Rectangle(Convert.ToInt32(View.Frame.Width) / 20, marginTop, Convert.ToInt32(View.Frame.Width) - (Convert.ToInt32(View.Frame.Width) / 20) * 2, 29);
			oldPasswordTF.Frame = new Rectangle(Convert.ToInt32(View.Frame.Width) / 20, marginTop + (Convert.ToInt32(oldPasswordLabel.Frame.Height)), Convert.ToInt32(View.Frame.Width) - (Convert.ToInt32(View.Frame.Width) / 20) * 2, (Convert.ToInt32(View.Frame.Height) / 15));
			newPasswordLabel.Frame = new Rectangle(Convert.ToInt32(View.Frame.Width) / 20, marginTop + (Convert.ToInt32(View.Frame.Height))/20+(Convert.ToInt32(oldPasswordLabel.Frame.Height))+(Convert.ToInt32(oldPasswordTF.Frame.Height)), Convert.ToInt32(View.Frame.Width) - (Convert.ToInt32(View.Frame.Width) / 20) * 2, 29);
			newPasswordTF.Frame = new Rectangle(Convert.ToInt32(View.Frame.Width) / 20, marginTop +((Convert.ToInt32(View.Frame.Height))/20)*2+(Convert.ToInt32(oldPasswordLabel.Frame.Height))+(Convert.ToInt32(oldPasswordTF.Frame.Height)), Convert.ToInt32(View.Frame.Width) - (Convert.ToInt32(View.Frame.Width) / 20) * 2, (Convert.ToInt32(View.Frame.Height)) / 15);
			repeatPasswordLabel.Frame = new Rectangle(Convert.ToInt32(View.Frame.Width) / 20, marginTop + ((Convert.ToInt32(View.Frame.Height)) / 20) * 2 + (Convert.ToInt32(oldPasswordLabel.Frame.Height))*2 + (Convert.ToInt32(oldPasswordTF.Frame.Height))*2, Convert.ToInt32(View.Frame.Width) - (Convert.ToInt32(View.Frame.Width) / 20) * 2, 29);
			repeatPasswordTF.Frame = new Rectangle(Convert.ToInt32(View.Frame.Width) / 20,marginTop +((Convert.ToInt32(View.Frame.Height))/20)*3+(Convert.ToInt32(oldPasswordLabel.Frame.Height))*2+(Convert.ToInt32(oldPasswordTF.Frame.Height))*2, Convert.ToInt32(View.Frame.Width) - (Convert.ToInt32(View.Frame.Width) / 20) * 2, (Convert.ToInt32(View.Frame.Height)) / 15);
			changeBn.Frame = new Rectangle(Convert.ToInt32(View.Frame.Width) / 20, marginTop +((Convert.ToInt32(View.Frame.Height))/18)*3+(Convert.ToInt32(oldPasswordLabel.Frame.Height))*2+(Convert.ToInt32(oldPasswordTF.Frame.Height))*3, Convert.ToInt32(View.Frame.Width) - (Convert.ToInt32(View.Frame.Width) / 20) * 2, (Convert.ToInt32(View.Frame.Height)) / 15);
			oldPasswordTF.Layer.CornerRadius = 5;
            newPasswordTF.Layer.CornerRadius = 5;
			repeatPasswordTF.Layer.CornerRadius = 5;
			oldPasswordLabel.TextColor = UIColor.FromRGB(13, 34, 58);
			newPasswordLabel.TextColor = UIColor.FromRGB(13, 34, 58);
			repeatPasswordLabel.TextColor = UIColor.FromRGB(13, 34, 58);
            changeBn.BackgroundColor = UIColor.FromRGB(74, 167, 91);
            changeBn.Layer.CornerRadius = 15;
			oldPasswordTF.SecureTextEntry = true;
			newPasswordTF.SecureTextEntry = true;
			repeatPasswordTF.SecureTextEntry = true;
			oldPasswordTF.Layer.BorderColor = UIColor.White.CGColor;
			oldPasswordTF.Layer.BorderWidth = 1f;
			newPasswordTF.Layer.BorderColor = UIColor.White.CGColor;
			newPasswordTF.Layer.BorderWidth = 1f;
			repeatPasswordTF.Layer.BorderColor = UIColor.White.CGColor;
			repeatPasswordTF.Layer.BorderWidth = 1f;

        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}

