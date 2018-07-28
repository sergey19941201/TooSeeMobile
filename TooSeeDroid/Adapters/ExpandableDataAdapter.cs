using System;
using System.Collections.Generic;
using Android.App;
using Android.Graphics;
using Android.Views;
using Android.Widget;
using TooSeePCL;

namespace TooSeeDroid.Adapters
{
    public class Data
    {
        public Data()
        {
        }

        public static List<Data> SampleData()
        {
            var newDataList = new List<Data>();
            newDataList.Add(new Data("1", "$ 765.08", "18 Oct 2018", "Maria Ellis", "Invoice for -3:00 @ $27.00/hr"));
            newDataList.Add(new Data("2", "$ 876.50", "15 Dec 2018", "Bruce Willis", "Invoice for -9:00 @ $29.00/hr"));
            newDataList.Add(new Data("3", "$ 997.89", "08 Sep 2018", "Jason Statham", "Invoice for -11:00 @ $21.00/hr"));
            newDataList.Add(new Data("4", "$ 465.08", "28 Jan 2018", "Mike Zambidis", "Invoice for -17:00 @ $25.00/hr"));

            return newDataList;
        }

        public Data(string newId = "Temporary Id", string amount = "Temporary Amount", string date = "Temporary Date", string contact = "Temporary Contact", string info = "Temporary Info")
        {
            Id = newId;
            Amount = amount;
            Date = date;
            Contact = contact;
            Info = info;
        }

        public string Id { get; set; }
        public string Amount { get; set; }
        public string Date { get; set; }
        public string Contact { get; set; }
        public string Info { get; set; }
    }

    public class DataAdapter : BaseAdapter<Data>
    {
        readonly Activity context;

        public DataAdapter(Activity newContext, List<Data> newData) : base()
        {
            context = newContext;
            DataList = newData;
        }

        public List<Data> DataList { get; set; }

        public override int Count {get{return DataList.Count;}}

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            View newView = convertView; // re-use an existing view, if one is available
            if (newView == null) // otherwise create a new one
                newView = context.LayoutInflater.Inflate(Resource.Layout.WalletDataListItem, null);
            return newView;
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override Data this[int index]
        {
            get
            {
                return DataList[index];
            }
        }
    }
    
    public class ExpandableDataAdapter : BaseExpandableListAdapter
    {
        readonly Activity Context;
        public ExpandableDataAdapter(Activity newContext, List<Data> newList) : base()
        {
            Context = newContext;
            DataList = newList;
        }

        protected List<Data> DataList { get; set; }

        public override View GetGroupView(int groupPosition, bool isExpanded, View convertView, ViewGroup parent)
        {
            View header = convertView;
            if (header == null)
            {
                header = Context.LayoutInflater.Inflate(Resource.Layout.WalletExpandableListGroup, null);
            }
            header.FindViewById<TextView>(Resource.Id.DataHeaderTV).SetTextColor(Color.Rgb(0,193,26));
            header.FindViewById<TextView>(Resource.Id.DataHeaderTV).Text = DataList[groupPosition].Amount;
            header.FindViewById<TextView>(Resource.Id.headerDateTV).Text = DataList[groupPosition].Date;
            return header;
        }

        public override View GetChildView(int groupPosition, int childPosition, bool isLastChild, View convertView, ViewGroup parent)
        {
            View row = convertView;
            if (row == null)
            {
                row = Context.LayoutInflater.Inflate(Resource.Layout.WalletDataListItem, null);
            }
            var ci = NativeClasses.GetCurrentCulture.GetCurrentCultureInfo();
            row.FindViewById<TextView>(Resource.Id.ServiceFeeTV).Text = TranslationHelper.GetString("ServiceFee", ci);
            row.FindViewById<TextView>(Resource.Id.invoiceTV).Text = DataList[groupPosition].Info;
            row.FindViewById<TextView>(Resource.Id.NameOfContactTV).Text = DataList[groupPosition].Contact;

            return row;
        }

        public override int GetChildrenCount(int groupPosition)
        {
            return 1;
        }

        public override int GroupCount
        {
            get
            {
                return DataList.Capacity;
            }
        }

        #region implemented abstract members of BaseExpandableListAdapter

        public override Java.Lang.Object GetChild(int groupPosition, int childPosition)
        {
            throw new NotImplementedException();
        }

        public override long GetChildId(int groupPosition, int childPosition)
        {
            return childPosition;
        }

        public override Java.Lang.Object GetGroup(int groupPosition)
        {
            throw new NotImplementedException();
        }

        public override long GetGroupId(int groupPosition)
        {
            return groupPosition;
        }

        public override bool IsChildSelectable(int groupPosition, int childPosition)
        {
            return false;
        }

        public override bool HasStableIds
        {
            get
            {
                return true;
            }
        }

        #endregion
    }
}
