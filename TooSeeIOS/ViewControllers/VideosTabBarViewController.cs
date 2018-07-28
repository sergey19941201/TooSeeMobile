using System;
using TooSeePCL;
using UIKit;

namespace TooSeeIOS.ViewControllers
{
    public partial class VideosTabBarViewController : UITabBarController
    {
        public VideosTabBarViewController(IntPtr handle) : base(handle)
        {
            var ci = NativeClasses.GetCurrentCulture.GetCurrentCultureInfo();
            Title = TranslationHelper.GetString("Video", ci);
            foreach (var uiTabBarItem in TabBar.Items)
            {
                if(uiTabBarItem.Title=="allVideosItem")
                {
                    uiTabBarItem.Title = TranslationHelper.GetString("AllVideos", ci);
                }
                else if(uiTabBarItem.Title == "myVideosItem")
                {
                    uiTabBarItem.Title = TranslationHelper.GetString("MyVideos", ci);
                }
            }
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}

