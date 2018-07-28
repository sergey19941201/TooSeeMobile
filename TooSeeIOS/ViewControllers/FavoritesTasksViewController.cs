using System;

using UIKit;

namespace TooSeeIOS.ViewControllers
{
    public partial class FavoritesTasksViewController : UIViewController
    {
		public FavoritesTasksViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.

            favoritesBn.Frame = new System.Drawing.Rectangle((int.Parse(View.Frame.Width.ToString()) - 100) / 6, 10, 20, 20);
            messageBn.Frame = new System.Drawing.Rectangle(((int.Parse(View.Frame.Width.ToString()) - 100) / 6) * 2 + 20, 10, 20, 20);
            playBn.Frame = new System.Drawing.Rectangle(((int.Parse(View.Frame.Width.ToString()) - 100) / 6) * 3 + 40, 10, 20, 20);
            notificationBn.Frame = new System.Drawing.Rectangle(((int.Parse(View.Frame.Width.ToString()) - 100) / 6) * 4 + 60, 10, 20, 20);
            settingsBn.Frame = new System.Drawing.Rectangle(((int.Parse(View.Frame.Width.ToString()) - 100) / 6) * 5 + 80, 10, 20, 20);
            scrollView.Frame = new System.Drawing.Rectangle(0, int.Parse(layoutFiveButtonsView.Frame.Height.ToString()) + 53, int.Parse(View.Frame.Width.ToString()), int.Parse(View.Frame.Height.ToString()));
            scrollView.ContentSize = new CoreGraphics.CGSize(View.Frame.Width, 1100);
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}

