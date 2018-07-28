using CoreGraphics;
using Foundation;
using System;
using System.Collections.Generic;
using System.Linq;
using TooSeeIOS.NativeClasses;
using TooSeePCL;
using UIKit;

namespace TooSeeIOS
{
    public class Data
    {
        public Data()
        {
        }

        public static List<Data> SampleData()
        {
            var newDataList = new List<Data>();
            newDataList.Add(new Data(25, "765.08", "18 Oct 2018", "Maria Ellis", "Invoice for -3:00 @ $27.00/hr"));
            newDataList.Add(new Data(12, "876.50", "15 Dec 2018", "Bruce Willis", "Invoice for -9:00 @ $29.00/hr"));
            newDataList.Add(new Data(34, "997.89", "08 Sep 2018", "Jason Statham", "Invoice for -11:00 @ $21.00/hr"));
            newDataList.Add(new Data(45, "465.08", "28 Jan 2018", "Mike Zambidis", "Invoice for -17:00 @ $25.00/hr"));

            return newDataList;
        }

        public Data(int newId = 0, string amount = "Temporary Amount", string date = "Temporary Date", string contact = "Temporary Contact", string info = "Temporary Info")
        {
            Id = newId;
            Amount = amount;
            Date = date;
            Contact = contact;
            Info = info;
        }

        public int Id { get; set; }
        public string Amount { get; set; }
        public string Date { get; set; }
        public string Contact { get; set; }
        public string Info { get; set; }
    }
    public partial class WalletViewController : UITableViewController
    {
        public WalletViewController (IntPtr handle) : base (handle)
        {
        }
		UILabel TotalAmount;
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            var source = new WalletTableViewSource<int, int>(TableView);
			var ci = NativeClasses.GetCurrentCulture.GetCurrentCultureInfo();
			Title = TranslationHelper.GetString("Wallet", ci);
			var navBar = NavigationController.NavigationBar;
			TotalAmount = new UILabel {Text="$ 2103"};
			TotalAmount.Frame = new CGRect(navBar.Bounds.Width-80, 0, 150, navBar.Bounds.Height);
			navBar.AddSubview(TotalAmount);
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
    }
}