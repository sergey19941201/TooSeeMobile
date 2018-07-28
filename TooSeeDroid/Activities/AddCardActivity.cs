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
using TooSeePCL;

namespace TooSeeDroid.Activities
{
    [Activity(Label = "AddCardActivity", Theme = "@android:style/Theme.Black.NoTitleBar")]
    public class AddCardActivity : Activity
    {
        TextView addCardTV, cardNumberTV, monthTV, yearTV, cvvTV, nameTV, indexTV, surnameTV, countryTV;
        EditText cardNumberET, monthET, yearET, cvvET, nameET, indexET, surnameET, countryET;
        Button addCardBn;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.AddCard);

            var ci = NativeClasses.GetCurrentCulture.GetCurrentCultureInfo();

            addCardTV = FindViewById<TextView>(Resource.Id.addCardTV);
            cardNumberTV = FindViewById<TextView>(Resource.Id.cardNumberTV);
            monthTV = FindViewById<TextView>(Resource.Id.monthTV);
            yearTV = FindViewById<TextView>(Resource.Id.yearTV);
            cvvTV = FindViewById<TextView>(Resource.Id.cvvTV);
            nameTV = FindViewById<TextView>(Resource.Id.nameTV);
            indexTV = FindViewById<TextView>(Resource.Id.indexTV);
            surnameTV = FindViewById<TextView>(Resource.Id.surnameTV);
            countryTV = FindViewById<TextView>(Resource.Id.countryTV);
            cardNumberET = FindViewById<EditText>(Resource.Id.cardNumberET);
            monthET = FindViewById<EditText>(Resource.Id.monthET);
            yearET = FindViewById<EditText>(Resource.Id.yearET);
            cvvET = FindViewById<EditText>(Resource.Id.cvvET);
            nameET = FindViewById<EditText>(Resource.Id.nameET);
            indexET = FindViewById<EditText>(Resource.Id.indexET);
            surnameET = FindViewById<EditText>(Resource.Id.surnameET);
            countryET = FindViewById<EditText>(Resource.Id.countryET);
            addCardBn = FindViewById<Button>(Resource.Id.addCardBn);

            addCardTV.Text = TranslationHelper.GetString("AddCard", ci);
            cardNumberTV.Text = TranslationHelper.GetString("CardNumber", ci);
            monthTV.Text = TranslationHelper.GetString("Month", ci);
            yearTV.Text = TranslationHelper.GetString("Year", ci);
            cvvTV.Text = TranslationHelper.GetString("CVV", ci);
            nameTV.Text = TranslationHelper.GetString("Name", ci);
            indexTV.Text = TranslationHelper.GetString("Index", ci);
            surnameTV.Text = TranslationHelper.GetString("Surname", ci);
            countryTV.Text = TranslationHelper.GetString("Country", ci);
            addCardBn.Text = TranslationHelper.GetString("AddCard", ci);
        }
    }
}