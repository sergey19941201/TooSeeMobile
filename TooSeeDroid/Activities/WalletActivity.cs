
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using TooSeeDroid.Adapters;
using TooSeePCL;

namespace TooSeeDroid.Activities
{
    [Activity(Label = "WalletActivity", Theme = "@style/Theme.AppCompat.Light.NoActionBar")]
    public class WalletActivity : Activity
    {
        TextView walletTV, totalTV;
        ExpandableListView explistView;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Wallet);

            explistView = FindViewById<ExpandableListView>(Resource.Id.myExpandableListview);
            walletTV = FindViewById<TextView>(Resource.Id.walletTV);
            totalTV = FindViewById<TextView>(Resource.Id.totalTV);
            explistView.SetAdapter(new ExpandableDataAdapter(this, Data.SampleData()));
            var ci = NativeClasses.GetCurrentCulture.GetCurrentCultureInfo();
            walletTV.Text = TranslationHelper.GetString("Wallet", ci);
            totalTV.Text = "$ 898909";
        }
    }
}
