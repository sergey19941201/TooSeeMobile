using Android.App;
using Android.OS;
using Android.Views;
using Android.Widget;

namespace TooSeeDroid.Fragments
{
    public class MyTasksFragment : Fragment
    {
        int position;
        public MyTasksFragment(int position)
        {
            this.position = position;
        }
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            View view = inflater.Inflate(Resource.Layout.VideoTabFragment, container, false);
            if (this.position == 0)
                view.FindViewById<Button>(Resource.Id.framentBn).Text = this.position.ToString() + " First";
            else if (this.position == 1)
                view.FindViewById<Button>(Resource.Id.framentBn).Text = "Second " + this.position.ToString();
            else if (this.position == 2)
                view.FindViewById<Button>(Resource.Id.framentBn).Text = "Third " + this.position.ToString();
            return view;
        }
    }
}