using Android.App;
using Android.Support.V7.Widget;
using Android.Views;
using System;
using System.Collections.Generic;
using TooSeeDroid.ViewHolders;

namespace TooSeeDroid.Adapters
{
    public class CurrencyCityLanguageAdapter : RecyclerView.Adapter
    {
        public event EventHandler<int> ItemClick;
        private Activity _context;
        private readonly List<string> currency;
        //set selected position by default. -1 will be no selected
        int selectedPosition = 1;

        public CurrencyCityLanguageAdapter(List<string> currency, Activity context)
        {
            this.currency = currency;
            _context = context;
        }

        public override int ItemCount
        {
            get { return currency.Count; }
        }

        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            var currencyCityLanguageViewHolder = (CurrencyCityLanguageViewHolder)holder;
            currencyCityLanguageViewHolder.CurrencyNameTV.Text = currency[position];
            if (selectedPosition == position)
                currencyCityLanguageViewHolder.selectedIV.Visibility = ViewStates.Visible;
            else
                currencyCityLanguageViewHolder.selectedIV.Visibility = ViewStates.Gone;
            currencyCityLanguageViewHolder.ItemView.Click += (sender, e) =>
            {
                selectedPosition = position;
                NotifyDataSetChanged();
            };
        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            var layout = LayoutInflater.From(parent.Context).Inflate(Resource.Layout.CurrencyCityLanguageRow, parent, false);

            return new CurrencyCityLanguageViewHolder(layout, OnItemClick);
        }
        void OnItemClick(int position)
        {
            
        }
    }
}