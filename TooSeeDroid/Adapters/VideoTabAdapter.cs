using Android.App;

namespace TooSeeDroid.Adapters
{
    public class VideoTabAdapter : Android.Support.V13.App.FragmentStatePagerAdapter
    {
        public VideoTabAdapter(FragmentManager fm) : base(fm)
        {
            
        }

        public override int Count
        {
            get
            {
                return 2;
            }
        }

        public override Fragment GetItem(int position)
        {
            return new Fragments.VideoTabFragment(position);
        }
    }
}
