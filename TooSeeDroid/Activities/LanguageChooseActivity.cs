using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.App;
using Android.Support.V4.App;
using Android.Support.V4.Widget;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;
using TooSeePCL;
using TooSeeDroid.Adapters;

namespace TooSeeDroid.Activities
{
    [Activity(Label = "LanguageChooseActivity", Theme = "@style/Theme.AppCompat.Light.NoActionBar")]
    public class LanguageChooseActivity : AppCompatActivity
    {
        RecyclerView recyclerView;
        TextView CurrencyTV;
        private RecyclerView.LayoutManager layoutManager;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.CurrencyCityLanguage);

            CurrencyTV = FindViewById<TextView>(Resource.Id.CurrencyTV);
            recyclerView = FindViewById<RecyclerView>(Resource.Id.recyclerView);
            var ci = NativeClasses.GetCurrentCulture.GetCurrentCultureInfo();
            CurrencyTV.Text = TranslationHelper.GetString("LanguageSelection", ci);

            layoutManager = new LinearLayoutManager(this, LinearLayoutManager.Vertical, false);

            recyclerView.SetLayoutManager(layoutManager);

            var languageList = new List<string>();
            languageList.Add("Русский");
            languageList.Add("English");
            languageList.Add("Italiano");
            languageList.Add("Украинский");
            languageList.Add("Deutsch");

            var languageAdapter = new CurrencyCityLanguageAdapter(languageList, this);
            recyclerView.SetAdapter(languageAdapter);
        }
    }
}
