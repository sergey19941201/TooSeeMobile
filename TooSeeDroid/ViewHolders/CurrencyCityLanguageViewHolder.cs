using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;
using System;

namespace TooSeeDroid.ViewHolders
{
    public class CurrencyCityLanguageViewHolder : RecyclerView.ViewHolder
    {
        public TextView CurrencyNameTV { get; set; }
        public ImageView selectedIV { get; set; }
        public CurrencyCityLanguageViewHolder(View itemView, Action<int> listener) : base(itemView)
        {
            CurrencyNameTV = itemView.FindViewById<TextView>(Resource.Id.CurrencyNameTV);
            selectedIV = itemView.FindViewById<ImageView>(Resource.Id.selectedIV);
            itemView.Click += (s, e) => listener(Position);
        }
    }
}