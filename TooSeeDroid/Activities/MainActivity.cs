using Android.App;
using Android.Widget;
using Android.OS;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using Android.Views.Animations;
using Android.Graphics.Drawables;
using Realms;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using TooSeePCL;
using Android.Content;

namespace TooSeeDroid.Activities
{
    [Activity(Label = "TooSeeDroid", MainLauncher = true, Theme = "@android:style/Theme.Black.NoTitleBar")]
    public class MainActivity : Activity
    {
        LinearLayout loginLL;
        TextView loginTV, titleTV, newTasksTV, popularVideosTV, popularCitiesTV;
        EditText searchET;
        Button searchBn;
        AnimationDrawable animationDrawable;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            //StartActivity(typeof(LanguageChooseActivity));

            loginLL = FindViewById<LinearLayout>(Resource.Id.loginLL);
            loginTV = FindViewById<TextView>(Resource.Id.loginTV);
            titleTV = FindViewById<TextView>(Resource.Id.titleTV);
            searchET = FindViewById<EditText>(Resource.Id.searchET);
            searchBn = FindViewById<Button>(Resource.Id.searchBn);
            newTasksTV = FindViewById<TextView>(Resource.Id.newTasksTV);
            popularVideosTV = FindViewById<TextView>(Resource.Id.popularVideosTV);
            popularCitiesTV = FindViewById<TextView>(Resource.Id.popularCitiesTV);

            var ci = NativeClasses.GetCurrentCulture.GetCurrentCultureInfo();
            /*ImageView animIV = FindViewById<ImageView>(Resource.Id.animIV);
            animIV.SetBackgroundResource(Resource.Drawable.ActivityIndicator);

            animationDrawable = (AnimationDrawable)animIV.Background;
            animationDrawable.Start();
            
            //calling realm methods for training
            string result;
            RealmMethods realmMethods = new RealmMethods();
            result = realmMethods.realmPractice("Oscar");
            //calling realm methods for training ENDED*/

            //resources

            //Hello is key declared in PCL in AppReources.resx and AppResources.ru.resx
            //var d = TranslationHelper.GetString("Hello", ci);
            //Toast.MakeText(this, d.ToString(), ToastLength.Long).Show();
            //resources ended

            loginTV.Text = TranslationHelper.GetString("LogIn", ci);
            titleTV.SetTypeface(null, Android.Graphics.TypefaceStyle.Bold);
            searchBn.Text = TranslationHelper.GetString("Search", ci);
            newTasksTV.Text = TranslationHelper.GetString("NewTasks", ci);
            popularVideosTV.Text = TranslationHelper.GetString("PopularVideos", ci);
            popularCitiesTV.Text = TranslationHelper.GetString("PopularCities", ci);
            //searchET.Hin(TranslationHelper.GetString("Search", ci));

            loginLL.Click += (s, e) =>
              {
                  StartActivity(typeof(AddCardActivity));
              };

            searchBn.Click += (s, e) =>
              {
                  StartActivity(typeof(AllVideosTabbedActivity));
              };
            AppCenter.Start("5bfb03fe-7108-4406-9855-8fb0578dd540", typeof(Analytics), typeof(Crashes));
        }
    }
}

