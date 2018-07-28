using Android.App;

namespace TooSeeDroid.Adapters
{
    public class MyTasksAdapter : Android.Support.V13.App.FragmentStatePagerAdapter
    {
        public MyTasksAdapter(FragmentManager fm) : base(fm)
        {

        }

        public override int Count
        {
            get
            {
                return 3;
            }
        }

        public override Fragment GetItem(int position)
        {
            return new Fragments.MyTasksFragment(position);
        }
    }
}