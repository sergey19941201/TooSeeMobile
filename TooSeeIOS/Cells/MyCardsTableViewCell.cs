using System;
using System.Globalization;
using CoreGraphics;
using Foundation;
using TooSeePCL;
using UIKit;

namespace TooSeeIOS.Cells
{
    public class MyCardsTableViewCell:UITableViewCell
    {
        bool _isExpanded;

        protected NSLayoutConstraint ServiceFeeLabelHeightConstraint { get; }
        protected NSLayoutConstraint ServiceFeeLabelBottomConstraint { get; }
        protected NSLayoutConstraint ContactLabelHeightConstraint { get; }
        protected NSLayoutConstraint ContactLabelBottomConstraint { get; }
        protected NSLayoutConstraint InfoLabelHeightConstraint { get; }
        protected NSLayoutConstraint InfoLabelBottomConstraint { get; }
        public UILabel AmountLabel { get; }
        public UILabel dateLabel { get; }
        public UILabel serviceFeeLabel { get; }
        public UILabel infoLabel { get; }
        public UILabel contactLabel { get; }
        public UIButton button { get; }

        protected UIImageView ExpandImageView { get; }
        public bool IsExpanded
        {
            get
            {
                return _isExpanded;
            }
            set
            {
                _isExpanded = value;

                ServiceFeeLabelHeightConstraint.Active = !_isExpanded;
                ServiceFeeLabelBottomConstraint.Constant = _isExpanded ? -50 : 0;
                ContactLabelHeightConstraint.Active = !_isExpanded;
                ContactLabelBottomConstraint.Constant = _isExpanded ? -50 : 0;
                InfoLabelHeightConstraint.Active = !_isExpanded;
                InfoLabelBottomConstraint.Constant = _isExpanded ? -16 : 0;
                float imageRotationValue = 0;
                if (_isExpanded)
                    imageRotationValue = (float)Math.PI;
                ExpandImageView.Transform = CGAffineTransform.MakeRotation(imageRotationValue);
            }
        }

        public MyCardsTableViewCell(IntPtr handle) : base(handle)
        {
            var deviceModel = Xamarin.iOS.DeviceHardware.Model;

            int dataWidthConstraint, expandingValueForImage;
            if (deviceModel.Contains("e 5") || deviceModel.Contains("SE "))
            {
                dataWidthConstraint = 140;
                expandingValueForImage = -33;
            }
            else if (!deviceModel.Contains("e 6S P") && !deviceModel.Contains("e 6 P") && (deviceModel.Contains("e 6 ") || deviceModel.Contains("e 6S ")))
            {
                dataWidthConstraint = 90;
                expandingValueForImage = 20;
            }
            else if (deviceModel.Contains("6 Plus") || deviceModel.Contains("6S Plus") || deviceModel.Contains("6s Plus") || deviceModel.Contains("7 Plus") || deviceModel.Contains("8 Plus"))
            {
                dataWidthConstraint = 50;
                expandingValueForImage = 60;
            }
            else if (deviceModel.Contains("7 ") && !deviceModel.Contains("7 P"))
            {
                dataWidthConstraint = 90;
                expandingValueForImage = 20;
            }
            else if (deviceModel.Contains("8 ") && !deviceModel.Contains("8 P"))
            {
                dataWidthConstraint = 90;
                expandingValueForImage = 20;
            }
            else if (deviceModel.Contains("X "))
            {
                dataWidthConstraint = 90;
                expandingValueForImage = 20;
            }
            else
            {
                dataWidthConstraint = 90;
                expandingValueForImage = 0;
            }
            AmountLabel = new UILabel
            {
                TranslatesAutoresizingMaskIntoConstraints = false,
                Lines = 0,
                LineBreakMode = UILineBreakMode.WordWrap
            };

            dateLabel = new UILabel
            {
                TranslatesAutoresizingMaskIntoConstraints = false,
                Lines = 0,
                LineBreakMode = UILineBreakMode.WordWrap,
                TextColor = UIColor.FromRGB(115, 115, 115)
            };

            serviceFeeLabel = new UILabel
            {
                TranslatesAutoresizingMaskIntoConstraints = false,
                Lines = 0,
                LineBreakMode = UILineBreakMode.WordWrap,
                TextColor = UIColor.FromRGB(115, 115, 115)
            };

            infoLabel = new UILabel
            {
                TranslatesAutoresizingMaskIntoConstraints = false,
                Lines = 0,
                LineBreakMode = UILineBreakMode.WordWrap,
                TextColor = UIColor.Black
            };

            contactLabel = new UILabel
            {
                TranslatesAutoresizingMaskIntoConstraints = false,
                Lines = 0,
                LineBreakMode = UILineBreakMode.WordWrap,
                TextColor = UIColor.Black,
                Font = UIFont.FromName("Helvetica-Bold", 16f)
            };

            ExpandImageView = new UIImageView
            {
                Image = UIImage.FromBundle("expand.png"),
            };

            button = new UIButton
            {
                BackgroundColor = UIColor.Blue,
                Frame= new System.Drawing.Rectangle( 6, 10, 20, 20),
            };
            /*button.TouchUpInside+=(s,e)=>
            {
                Console.WriteLine("dfjdfjjdfdfdjdfjdf");
            };*/
            ExpandImageView.Frame = new CoreGraphics.CGRect(ContentView.Frame.Width + expandingValueForImage, ContentView.Frame.Height / 2, 20, 11);
            ContentView.AddSubviews(AmountLabel, button, infoLabel, dateLabel, contactLabel, ExpandImageView);
            ContentView.AddConstraints(new[]
            {
                AmountLabel.TopAnchor.ConstraintEqualTo(ContentView.TopAnchor, 16),
                AmountLabel.BottomAnchor.ConstraintEqualTo(button.TopAnchor, -16),
                AmountLabel.LeadingAnchor.ConstraintEqualTo(ContentView.LeadingAnchor, 16),
                contactLabel.LeadingAnchor.ConstraintEqualTo(ContentView.LeadingAnchor, 16),
                contactLabel.TrailingAnchor.ConstraintEqualTo(ContentView.TrailingAnchor, -16),
                ServiceFeeLabelBottomConstraint = button.BottomAnchor.ConstraintEqualTo(ContentView.BottomAnchor),
                ServiceFeeLabelHeightConstraint = button.HeightAnchor.ConstraintEqualTo(0),
                infoLabel.LeadingAnchor.ConstraintEqualTo(ContentView.LeadingAnchor, 16),
                infoLabel.TrailingAnchor.ConstraintEqualTo(ContentView.TrailingAnchor, -16),
                dateLabel.TopAnchor.ConstraintEqualTo(ContentView.TopAnchor, 16),
                dateLabel.LeadingAnchor.ConstraintEqualTo(ContentView.LeadingAnchor, ContentView.Frame.Width-dateLabel.Frame.Width-dataWidthConstraint),
                dateLabel.TrailingAnchor.ConstraintEqualTo(ContentView.TrailingAnchor, 16),
                InfoLabelBottomConstraint = infoLabel.BottomAnchor.ConstraintEqualTo(ContentView.BottomAnchor),
                InfoLabelHeightConstraint = infoLabel.HeightAnchor.ConstraintEqualTo(0),
                button.LeadingAnchor.ConstraintEqualTo(ContentView.LeadingAnchor, ContentView.Frame.Width-dateLabel.Frame.Width-dataWidthConstraint),
                button.TrailingAnchor.ConstraintEqualTo(ContentView.TrailingAnchor, -16),
                ContactLabelBottomConstraint = contactLabel.BottomAnchor.ConstraintEqualTo(ContentView.BottomAnchor),
                ContactLabelHeightConstraint = contactLabel.HeightAnchor.ConstraintEqualTo(0),
                /*ExpandImageView.TopAnchor.ConstraintEqualTo(ContentView.TopAnchor, 16),
                ExpandImageView.LeadingAnchor.ConstraintEqualTo(ContentView.LeadingAnchor, ContentView.Frame.Width-dateLabel.Frame.Width-dataWidthConstraint),
                ExpandImageView.TrailingAnchor.ConstraintEqualTo(ContentView.TrailingAnchor, 16),*/
            });
        }

        public void Bind(object item)
        {
            var ci = NativeClasses.GetCurrentCulture.GetCurrentCultureInfo();

            var index = Data.SampleData().FindIndex(x => x.Id == Convert.ToInt32(item));
            AmountLabel.Text = "$ " + Data.SampleData()[index].Amount;
            dateLabel.Text = Data.SampleData()[index].Date;
            serviceFeeLabel.Text = TranslationHelper.GetString("ServiceFee", ci);
            infoLabel.Text = Data.SampleData()[index].Info;
            contactLabel.Text = Data.SampleData()[index].Contact;
            if (Convert.ToDouble(Data.SampleData()[index].Amount, (CultureInfo.InvariantCulture)) > 800)
                AmountLabel.TextColor = UIColor.Green;
            else
                AmountLabel.TextColor = UIColor.Red;
        }
    }
}
