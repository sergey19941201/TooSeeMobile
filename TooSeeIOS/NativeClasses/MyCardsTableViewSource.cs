using System;
using System.Collections.Generic;
using System.Linq;
using Foundation;
using TooSeeIOS.Cells;
using TooSeeIOS.ViewControllers;
using UIKit;

namespace TooSeeIOS.NativeClasses
{
    public class MyCardsTableViewSource<TGroup, TItem> : UITableViewSource
    {
        private IDictionary<NSIndexPath, string> _expandedRows;

        private NSIndexPath _indexPathOfSelectedRow;

        private IEnumerable<IGrouping<TGroup, TItem>> _items;

        public IEnumerable<IGrouping<TGroup, TItem>> Items
        {
            get
            {
                return _items;
            }
            set
            {
                _items = value;

                TableView.ReloadData();
            }
        }

        protected string CellIdentifier
        {
            get;
        }

        protected string HeaderIdentifier
        {
            get;
        }

        protected UITableView TableView
        {
            get;
        }
        UIViewController owner;
        public MyCardsTableViewSource(UITableView tableView, UIViewController owner)
        {
            TableView = tableView;
            var cellType = typeof(MyCardsTableViewCell);
            CellIdentifier = cellType.Name;
            TableView.RegisterClassForCellReuse(cellType, CellIdentifier);
            _expandedRows = new Dictionary<NSIndexPath, string>();

            this.owner = owner;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            var cell = tableView.DequeueReusableCell(CellIdentifier, indexPath) as MyCardsTableViewCell;

            cell.Bind(Items.ElementAt(indexPath.Section).ElementAt(indexPath.Row));

            cell.IsExpanded = _expandedRows.ContainsKey(indexPath);
            cell.TextLabel.TextColor = UIColor.Green;
            cell.button.TouchUpInside+=delegate 
            {
                cell.button.BackgroundColor = UIColor.Brown;
                cell.AmountLabel.Text = "clicked ";
                cell.dateLabel.Text = "dsds";
                UIStoryboard board = UIStoryboard.FromName("Main", null);
                //UIViewController controller = board.InstantiateViewController("AddCardViewController") as UIViewController;

                //AddCardViewController ctrl2 = board.InstantiateViewController("AddCardViewController") as AddCardViewController;
            };
            return cell;
        }

        public override void RowSelected(UITableView tableView, NSIndexPath indexPath)
        {
            var window = UIApplication.SharedApplication.KeyWindow;
            var vc = window.RootViewController;
            while (vc.PresentedViewController != null)
            {
                vc = vc.PresentedViewController;
            }
            //var myTarget = AllVideosTabViewController;
            //myTarget.email = locations[indexPath.Row].shopname + "";
            //vc.PresentViewController(myTarget, true, null);
            UIStoryboard board = UIStoryboard.FromName("Main", null);
            //UIViewController controller = board.InstantiateViewController("AddCardViewController") as UIViewController;

            AddCardViewController ctrl2 = board.InstantiateViewController("AddCardViewController") as AddCardViewController;;


            if (_expandedRows.ContainsKey(indexPath))
            {
                _expandedRows.Remove(indexPath);
            }
            else
            {
                _expandedRows.Add(indexPath, string.Empty);
            }

            _indexPathOfSelectedRow = indexPath;

            TableView.ReloadRows(new[] { indexPath }, UITableViewRowAnimation.Fade);
        }

        public override void WillDisplay(UITableView tableView, UITableViewCell cell, NSIndexPath indexPath)
        {

            if (_indexPathOfSelectedRow == indexPath)
            {
                _indexPathOfSelectedRow = null;
            }
        }

        public override nint NumberOfSections(UITableView tableView) => Items?.Count() ?? 0;

        public override nint RowsInSection(UITableView tableview, nint section) => Items?.ElementAt((int)section).Count() ?? 0;
    }
}
