using System;
using System.Collections.Generic;
using System.Linq;
using Foundation;
using TooSeeIOS.Cells;
using UIKit;

namespace TooSeeIOS.NativeClasses
{
    public class WalletTableViewSource<TGroup, TItem> : UITableViewSource
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

        public WalletTableViewSource(UITableView tableView)
        {
            TableView = tableView;
            var cellType = typeof(WalletTableViewCell);
            CellIdentifier = cellType.Name;
            TableView.RegisterClassForCellReuse(cellType, CellIdentifier);
            _expandedRows = new Dictionary<NSIndexPath, string>();
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            var cell = tableView.DequeueReusableCell(CellIdentifier, indexPath) as WalletTableViewCell;

            cell.Bind(Items.ElementAt(indexPath.Section).ElementAt(indexPath.Row));

            cell.IsExpanded = _expandedRows.ContainsKey(indexPath);
            cell.TextLabel.TextColor = UIColor.Green;
            return cell;
        }

        public override void RowSelected(UITableView tableView, NSIndexPath indexPath)
        {
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
