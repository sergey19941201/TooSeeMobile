using System;
using System.Collections.Generic;
using System.Linq;
using TooSeeIOS.NativeClasses;
using TooSeePCL;
using UIKit;

namespace TooSeeIOS.ViewControllers
{
    public partial class MyCardsViewController : UITableViewController
    {
        public MyCardsViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            var source = new MyCardsTableViewSource<int, int>(TableView,this);
            var ci = GetCurrentCulture.GetCurrentCultureInfo();
            Title = "ПОМЕНЯТЬ";
            var navBar = NavigationController.NavigationBar;
            var items = new List<int>();
            var datalist = Data.SampleData();

            for (int i = 0; i < Data.SampleData().Capacity; i++)
            {
                items.Add(datalist[i].Id);
            }

            source.Items = items.GroupBy(item => 10 * ((item + 9) / 10));

            TableView.Frame = new CoreGraphics.CGRect(0, 0, View.Frame.Width, View.Frame.Height);
            TableView.Source = source;
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}

