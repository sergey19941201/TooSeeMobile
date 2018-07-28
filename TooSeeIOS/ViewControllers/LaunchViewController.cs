using CoreGraphics;
using Foundation;
using System;
using System.Drawing;
using TooSeePCL;
using UIKit;

namespace TooSeeIOS
{
    public partial class LaunchViewController : UIViewController
    {
        public LaunchViewController (IntPtr handle) : base (handle)
        {
        }
        /*UIScrollView scrollView;
        UIImageView imageView;
        UIButton uiButton;*/
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            //newTasksScrollView.ContentSize = new CGSize(newTasksView.Frame.Width, newTasksScrollView.Frame.Height);
            //popularVideosScrollView.ContentSize = new CGSize(popularVideosView.Frame.Width, popularVideosScrollView.Frame.Height);
            //popularCitiesScrollView.ContentSize = new CGSize(popularCitiesView.Frame.Width, popularCitiesScrollView.Frame.Height);
           
            ////verticalScrollView.Frame = new RectangleF(0, float.Parse((upperView.Frame.Height + 63).ToString()) + 63, float.Parse(this.View.Bounds.Width.ToString()), 492);
            //verticalScrollView.ContentSize = new CGSize(View.Frame.Width, mainUIView.Frame.Height);
            //mainUIView.Frame = new RectangleF(0, 0, float.Parse(this.View.Bounds.Width.ToString()), 492);
            /*activityIndicatorIV.AnimationImages = new UIImage[]
            {
                UIImage.FromBundle ("frame1.png"),
                UIImage.FromBundle ("frame2.png"),
                UIImage.FromBundle ("frame3.png"),
                UIImage.FromBundle ("frame4.png"),
                UIImage.FromBundle ("frame5.png"),
                UIImage.FromBundle ("frame6.png"),
                UIImage.FromBundle ("frame7.png"),
                UIImage.FromBundle ("frame8.png")
            };
            activityIndicatorIV.AnimationRepeatCount = 0;
            activityIndicatorIV.AnimationDuration = .5;
            activityIndicatorIV.StartAnimating();


            //calling realm methods for training
            string result;
            RealmMethods realmMethods = new RealmMethods();
            result = realmMethods.realmPractice("Oscar");
            //calling realm methods for training ENDED
            */
			var ci = NativeClasses.GetCurrentCulture.GetCurrentCultureInfo();
            //Hello is key declared in PCL in AppReources.resx and AppResources.ru.resx
            //var hello = TranslationHelper.GetString("Hello", ci);
            //SearchBn.SetTitle(TranslationHelper.GetString("Search", ci),UIControlState.Normal);
            newTasksLabel.Text = TranslationHelper.GetString("NewTasks", ci);
            popularVideosLabel.Text = TranslationHelper.GetString("PopularVideos", ci);
            popularCitiesLabel.Text = TranslationHelper.GetString("PopularCities", ci);

            newTasksLabel.Frame = new System.Drawing.Rectangle(0, 8, int.Parse((mainView.Frame.Width).ToString()), 20);
            popularVideosLabel.Frame = new System.Drawing.Rectangle(0, 145, int.Parse((mainView.Frame.Width).ToString()), 20);
            popularCitiesLabel.Frame = new System.Drawing.Rectangle(0, 279, int.Parse((mainView.Frame.Width).ToString()), 20);

            greenscroll.Frame = new System.Drawing.Rectangle(0, 36, int.Parse((mainView.Frame.Width).ToString()), 100);
            orangescroll.Frame = new System.Drawing.Rectangle(0, 172, int.Parse((mainView.Frame.Width).ToString()), 100);
            pinkscroll.Frame = new System.Drawing.Rectangle(0, 307, int.Parse((mainView.Frame.Width).ToString()), 100);

            scrollView.ContentSize = new CoreGraphics.CGSize(mainView.Frame.Width, 420);
            greenscroll.ContentSize = new CoreGraphics.CGSize(1500, 100);
            orangescroll.ContentSize = new CoreGraphics.CGSize(1500, 100);
            pinkscroll.ContentSize = new CoreGraphics.CGSize(1500, 100);
        }
        
    }
}