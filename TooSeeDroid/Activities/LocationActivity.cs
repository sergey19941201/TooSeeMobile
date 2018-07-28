using Android.App;
using Android.OS;
using Android.Widget;
using TooSeePCL;

namespace TooSeeDroid.Activities
{
    [Activity(Label = "LocationActivity", Theme = "@style/Theme.AppCompat.Light.NoActionBar")]
    public class LocationActivity : Activity
    {
        TextView locationTV, autoDetectTV, countryTV, cityTV, countryValueTV, cityValueTV;
        Switch autoDetectSw;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Location);

            locationTV = FindViewById<TextView>(Resource.Id.locationTV);
            autoDetectTV = FindViewById<TextView>(Resource.Id.autoDetectTV);
            countryTV = FindViewById<TextView>(Resource.Id.countryTV);
            cityTV = FindViewById<TextView>(Resource.Id.cityTV);
            countryValueTV = FindViewById<TextView>(Resource.Id.countryValueTV);
            cityValueTV = FindViewById<TextView>(Resource.Id.cityValueTV);
            autoDetectSw = FindViewById<Switch>(Resource.Id.autoDetectSw);
            var ci = NativeClasses.GetCurrentCulture.GetCurrentCultureInfo();
            locationTV.Text = TranslationHelper.GetString("Location", ci);
            autoDetectTV.Text = TranslationHelper.GetString("AutoDetect", ci);
            countryTV.Text = TranslationHelper.GetString("Country", ci);
            cityTV.Text = TranslationHelper.GetString("City", ci);
            countryValueTV.Text = "Россия";
            cityValueTV.Text = "Москва";
        }
    }
}