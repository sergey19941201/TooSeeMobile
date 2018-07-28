using Android.App;
using Android.Graphics;
using Android.OS;
using Android.Support.V4.View;
using Android.Support.V7.App;
using Android.Widget;
using System.ComponentModel;
using TooSeePCL;

namespace TooSeeDroid.Activities
{
    [Activity(Label = "MyTasksTabbedActivity", Theme = "@style/Theme.AppCompat.Light.NoActionBar")]
    public class MyTasksTabbedActivity : AppCompatActivity, INotifyPropertyChanged
    {
        Button allTasksBn, favouritesBn, myTasksBn;
        TextView TasksTV;
        LinearLayout allTasksLL, favouritesLL, myTasksLL;
        Adapters.MyTasksAdapter adapter;
        ViewPager pager;

        string propertyName;
        public static int currentItem;
        public event PropertyChangedEventHandler PropertyChanged;

        public MyTasksTabbedActivity()
        {
        }

        public MyTasksTabbedActivity(string value)
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
                allTasksLL.SetBackgroundColor(Color.ParseColor("#4aa75b"));
                favouritesLL.SetBackgroundColor(Color.ParseColor("#ffffff"));
                myTasksLL.SetBackgroundColor(Color.ParseColor("#ffffff"));
            }
            else if (currentItem == 1)
            {
                allTasksLL.SetBackgroundColor(Color.ParseColor("#ffffff"));
                favouritesLL.SetBackgroundColor(Color.ParseColor("#4aa75b"));
                myTasksLL.SetBackgroundColor(Color.ParseColor("#ffffff"));
            }
            else if (currentItem == 2)
            {
                allTasksLL.SetBackgroundColor(Color.ParseColor("#ffffff"));
                favouritesLL.SetBackgroundColor(Color.ParseColor("#ffffff"));
                myTasksLL.SetBackgroundColor(Color.ParseColor("#4aa75b"));
            }
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.MyTasksTabbed);

            var ci = NativeClasses.GetCurrentCulture.GetCurrentCultureInfo();
            allTasksBn = FindViewById<Button>(Resource.Id.allTasksBn);
            favouritesBn = FindViewById<Button>(Resource.Id.favouritesBn);
            myTasksBn = FindViewById<Button>(Resource.Id.myTasksBn);
            TasksTV = FindViewById<TextView>(Resource.Id.TasksTV);
            allTasksLL = FindViewById<LinearLayout>(Resource.Id.allTasksLL);
            favouritesLL = FindViewById<LinearLayout>(Resource.Id.favouritesLL);
            myTasksLL = FindViewById<LinearLayout>(Resource.Id.myTasksLL);

            TasksTV.Text = TranslationHelper.GetString("Tasks", ci);
            allTasksBn.Text = TranslationHelper.GetString("AllTasks", ci);
            favouritesBn.Text = TranslationHelper.GetString("Favorites", ci);
            myTasksBn.Text = TranslationHelper.GetString("MyTasks", ci);
            adapter = new Adapters.MyTasksAdapter(this.FragmentManager);
            pager = FindViewById<ViewPager>(Resource.Id.pager);
            pager.Adapter = adapter;

            pager.PageSelected += (vpsender, ee) =>
            {
                currentItem = pager.CurrentItem;
                IndexViewPager = pager.CurrentItem.ToString();
            };

            allTasksBn.Click += (s, e) =>
            {
                pager.SetCurrentItem(0, true);
            };

            favouritesBn.Click += (s, e) =>
            {
                pager.SetCurrentItem(1, true);
            };

            myTasksBn.Click += (s, e) =>
            {
                pager.SetCurrentItem(2, true);
            };
        }
    }
}