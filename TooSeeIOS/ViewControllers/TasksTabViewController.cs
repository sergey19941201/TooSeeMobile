using System;
using TooSeePCL;
using UIKit;

namespace TooSeeIOS.ViewControllers
{
	public partial class TasksTabViewController : UITabBarController
    {
		public TasksTabViewController(IntPtr handle) : base(handle)
        {
			var ci = NativeClasses.GetCurrentCulture.GetCurrentCultureInfo();
			Title = TranslationHelper.GetString("Tasks", ci);
            foreach (var uiTabBarItem in TabBar.Items)
            {
				if (uiTabBarItem.Title == "AllTasks")
                {
					uiTabBarItem.Title = TranslationHelper.GetString("AllTasks", ci);
                }
				else if (uiTabBarItem.Title == "Favorites")
                {
					uiTabBarItem.Title = TranslationHelper.GetString("Favorites", ci);
                }
				else if (uiTabBarItem.Title == "MyTasks")
                {
					uiTabBarItem.Title = TranslationHelper.GetString("MyTasks", ci);
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

