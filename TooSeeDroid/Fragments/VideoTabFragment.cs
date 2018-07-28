using Android.App;
using Android.OS;
using Android.Views;
using Android.Widget;

namespace TooSeeDroid.Fragments
{
    public class VideoTabFragment : Fragment
    {
        int position;
        public VideoTabFragment(int position)
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
            return view;
        }
    }
}
