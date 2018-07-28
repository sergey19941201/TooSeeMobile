using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Support.V4.App;
using Android.Support.V4.View;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;
using com.refractored;
using Java.Lang;
using TooSeePCL;

namespace TooSeeDroid.Activities
{
    [Activity(Label = "AllVideosTabbedActivity", Theme = "@style/Theme.AppCompat.Light.NoActionBar")]
    public class AllVideosTabbedActivity : AppCompatActivity, INotifyPropertyChanged
    {
        Button allVideosBn, myVideosBn;
        TextView videoTV;
        LinearLayout allVideosLL, myVideosLL;
        Adapters.VideoTabAdapter adapter;
        ViewPager pager;

        string propertyName;
        public static int currentItem;
        public event PropertyChangedEventHandler PropertyChanged;

        public AllVideosTabbedActivity()
        {
        }

        public AllVideosTabbedActivity(string value)
        {
            this.propertyName = value;
        }

        public string IndexViewPager
        {
            get { return propertyName; }
            set
            {
                propertyName = value;
                OnPropertyChanged("IndexViewPager");
            }
        }
        protected void OnPropertyChanged(string propertyName)
        {
            if (currentItem == 0)
            {
                allVideosLL.SetBackgroundColor(Color.ParseColor("#4aa75b"));
                myVideosLL.SetBackgroundColor(Color.ParseColor("#ffffff"));
            }
            else
            {
                allVideosLL.SetBackgroundColor(Color.ParseColor("#ffffff"));
                myVideosLL.SetBackgroundColor(Color.ParseColor("#4aa75b"));
            }
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        protected override async void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.AllVideosTabbed);

            var ci = NativeClasses.GetCurrentCulture.GetCurrentCultureInfo();
            allVideosBn = FindViewById<Button>(Resource.Id.allVideosBn);
            myVideosBn = FindViewById<Button>(Resource.Id.myVideosBn);
            videoTV = FindViewById<TextView>(Resource.Id.videoTV);
            allVideosLL = FindViewById<LinearLayout>(Resource.Id.allVideosLL);
            myVideosLL = FindViewById<LinearLayout>(Resource.Id.myVideosLL);

            videoTV.Text = TranslationHelper.GetString("Video", ci);
            allVideosBn.Text = TranslationHelper.GetString("AllVideos", ci);
            myVideosBn.Text = TranslationHelper.GetString("MyVideos", ci);
            adapter = new Adapters.VideoTabAdapter(this.FragmentManager);
            pager = FindViewById<ViewPager>(Resource.Id.pager);
            pager.Adapter = adapter;

            pager.PageSelected += (vpsender, ee) =>
            {
                currentItem = pager.CurrentItem;
                IndexViewPager = pager.CurrentItem.ToString();
            };

            allVideosBn.Click += (s, e) =>
            {
                pager.SetCurrentItem(0, true);
            };

            myVideosBn.Click += (s, e) =>
            {
                pager.SetCurrentItem(1, true);
            };
        }
    }
}
