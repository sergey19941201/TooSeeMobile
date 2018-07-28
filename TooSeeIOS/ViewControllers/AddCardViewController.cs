using System;
using System.Drawing;
using System.Threading;
using System.Timers;
using Foundation;
using TooSeePCL;
using UIKit;

namespace TooSeeIOS.ViewControllers
{
    public partial class AddCardViewController : UIViewController
    {
        public AddCardViewController(IntPtr handle) : base(handle)
        {
        }
        NSObject keyboardShowObserver;
        NSObject keyboardHideObserver;
        RectangleF keyboardBounds;
        bool needToScroll;
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            //fires when keyboard shows
            keyboardShowObserver = NSNotificationCenter.DefaultCenter.AddObserver(UIKeyboard.WillShowNotification, (notification) =>
            {
                NSValue nsKeyboardBounds = (NSValue)notification.UserInfo.ObjectForKey(UIKeyboard.BoundsUserInfoKey);
                keyboardBounds = nsKeyboardBounds.RectangleFValue;

                if (needToScroll)
                {
                    if ((View.Frame.Height - keyboardBounds.Height - 50) < 360)
                    {
                        myScroll.ContentOffset = new CoreGraphics.CGPoint(0, keyboardBounds.Height - 100);
                    }
                }
            });
            //fires when keyboard hides
            keyboardHideObserver = NSNotificationCenter.DefaultCenter.AddObserver(UIKeyboard.WillHideNotification, (notification) =>
            {
                //centering scroll
                myScroll.ContentOffset = new CoreGraphics.CGPoint(0, 0);
            });

            var widthOfCardData = Convert.ToInt32(View.Frame.Width / 4);
            monthTF.Frame = new Rectangle(widthOfCardData / 5, 150, widthOfCardData, 29);
            yearTF.Frame = new Rectangle(widthOfCardData / 4 + widthOfCardData / 4 + widthOfCardData, 150, widthOfCardData, 29);
            cvvTF.Frame = new Rectangle(widthOfCardData * 2 + widthOfCardData / 2 + widthOfCardData / 4, 150, widthOfCardData, 29);
            monthLabel.Frame = new Rectangle(widthOfCardData / 5, 120, widthOfCardData, 29);
            yearLabel.Frame = new Rectangle(widthOfCardData / 4 + widthOfCardData / 4 + widthOfCardData, 120, widthOfCardData, 29);
            cvvLabel.Frame = new Rectangle(widthOfCardData * 2 + widthOfCardData / 2 + widthOfCardData / 4, 120, widthOfCardData, 29);

			cardNumberLabel.Frame = new Rectangle(widthOfCardData / 5, 40, Convert.ToInt32(View.Frame.Width) - ((widthOfCardData / 5) * 2), 29);
            cardNumberTF.Frame = new Rectangle(widthOfCardData / 5, 70, Convert.ToInt32(View.Frame.Width) - ((widthOfCardData / 5) * 2), 29);

            nameTF.Frame = new Rectangle(widthOfCardData / 5, 250, Convert.ToInt32(View.Frame.Width) / 2 - ((widthOfCardData / 5) * 2), 29);
            surnameTF.Frame = new Rectangle((widthOfCardData / 5) * 3 + Convert.ToInt32(nameTF.Frame.Width), 250, Convert.ToInt32(View.Frame.Width) / 2 - ((widthOfCardData / 5) * 2), 29);
            nameLabel.Frame = new Rectangle(widthOfCardData / 5, 220, Convert.ToInt32(View.Frame.Width) / 2 - ((widthOfCardData / 5) * 2), 29);
            surnameLabel.Frame = new Rectangle((widthOfCardData / 5) * 3 + Convert.ToInt32(nameTF.Frame.Width), 220, Convert.ToInt32(View.Frame.Width) / 2 - ((widthOfCardData / 5) * 2), 29);
            indexTF.Frame = new Rectangle(widthOfCardData / 5, 320, Convert.ToInt32(View.Frame.Width) / 2 - ((widthOfCardData / 5) * 2), 29);
            countryTF.Frame = new Rectangle((widthOfCardData / 5) * 3 + Convert.ToInt32(nameTF.Frame.Width), 320, Convert.ToInt32(View.Frame.Width) / 2 - ((widthOfCardData / 5) * 2), 29);
            indexLabel.Frame = new Rectangle(widthOfCardData / 5, 290, Convert.ToInt32(View.Frame.Width) / 2 - ((widthOfCardData / 5) * 2), 29);
            countryLabel.Frame = new Rectangle((widthOfCardData / 5) * 3 + Convert.ToInt32(nameTF.Frame.Width), 290, Convert.ToInt32(View.Frame.Width) / 2 - ((widthOfCardData / 5) * 2), 29);
            addCardBn.Frame = new Rectangle(widthOfCardData / 5, 360, Convert.ToInt32(View.Frame.Width) - (widthOfCardData / 5) * 2, 50);
			addCardBn.BackgroundColor = UIColor.FromRGB(74, 167, 91);
			addCardBn.Layer.CornerRadius = 15;
			nameTF.BackgroundColor = UIColor.FromRGB(237, 243, 250);
			cardNumberTF.BackgroundColor = UIColor.FromRGB(237, 243, 250);
			surnameTF.BackgroundColor = UIColor.FromRGB(237, 243, 250);
			indexTF.BackgroundColor = UIColor.FromRGB(237, 243, 250);
			countryTF.BackgroundColor = UIColor.FromRGB(237, 243, 250);
			monthTF.BackgroundColor = UIColor.FromRGB(237, 243, 250);
			yearTF.BackgroundColor = UIColor.FromRGB(237, 243, 250);
			cvvTF.BackgroundColor = UIColor.FromRGB(237, 243, 250);

            nameTF.EditingDidBegin += (sender, e) =>
            {
                needToScroll = true;
                if ((View.Frame.Height - keyboardBounds.Height - 50) < 360)
                {
                    myScroll.ContentOffset = new CoreGraphics.CGPoint(0, keyboardBounds.Height - 100);
                }
            };
            surnameTF.EditingDidBegin += (sender, e) =>
            {
                needToScroll = true;
                if ((View.Frame.Height - keyboardBounds.Height - 50) < 360)
                {
                    myScroll.ContentOffset = new CoreGraphics.CGPoint(0, keyboardBounds.Height - 100);
                }
            };
            indexTF.EditingDidBegin += (sender, e) =>
            {
                needToScroll = true;
                if ((View.Frame.Height - keyboardBounds.Height - 50) < 360)
                {
                    myScroll.ContentOffset = new CoreGraphics.CGPoint(0, keyboardBounds.Height - 100);
                }
            };
            countryTF.EditingDidBegin += (sender, e) =>
            {
                needToScroll = true;
                if ((View.Frame.Height - keyboardBounds.Height - 50) < 360)
                {
                    myScroll.ContentOffset = new CoreGraphics.CGPoint(0, keyboardBounds.Height - 100);
                }
            };
            cardNumberTF.EditingDidBegin += (sender, e) =>
            {
                needToScroll = false;
				myScroll.ContentOffset = new CoreGraphics.CGPoint(0, 0);
            };
            monthTF.EditingDidBegin += (s, e) =>
            {
                needToScroll = false;
				myScroll.ContentOffset = new CoreGraphics.CGPoint(0, 0);
            };
            yearTF.EditingDidBegin += (s, e) =>
            {
                needToScroll = false;
				myScroll.ContentOffset = new CoreGraphics.CGPoint(0, 0);
            };
            cvvTF.EditingDidBegin += (s, e) =>
            {
                needToScroll = false;
				myScroll.ContentOffset = new CoreGraphics.CGPoint(0, 0);
            };

            //button to hide keyboard
            addCardBn.TouchUpInside += (s, e) =>
            {
                View.EndEditing(true);
                //myScroll.ContentOffset = new CoreGraphics.CGPoint(0, 0);
            };

			var ci = NativeClasses.GetCurrentCulture.GetCurrentCultureInfo();
			Title = TranslationHelper.GetString("AddCard", ci);
			cardNumberLabel.Text = TranslationHelper.GetString("CardNumber", ci);
			monthLabel.Text = TranslationHelper.GetString("Month", ci);
			yearLabel.Text = TranslationHelper.GetString("Year", ci);
			cvvLabel.Text = TranslationHelper.GetString("CVV", ci);
			nameLabel.Text = TranslationHelper.GetString("Name", ci);
			indexLabel.Text = TranslationHelper.GetString("Index", ci);
			surnameLabel.Text = TranslationHelper.GetString("Surname", ci);
			countryLabel.Text = TranslationHelper.GetString("Country", ci);
			addCardBn.SetTitle(TranslationHelper.GetString("AddCard", ci), UIControlState.Normal);
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}

