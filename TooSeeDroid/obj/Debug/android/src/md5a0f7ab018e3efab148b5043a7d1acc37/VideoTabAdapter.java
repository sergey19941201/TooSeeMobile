package md5a0f7ab018e3efab148b5043a7d1acc37;


public class VideoTabAdapter
	extends android.support.v13.app.FragmentStatePagerAdapter
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_getCount:()I:GetGetCountHandler\n" +
			"n_getItem:(I)Landroid/app/Fragment;:GetGetItem_IHandler\n" +
			"";
		mono.android.Runtime.register ("TooSeeDroid.Adapters.VideoTabAdapter, TooSeeDroid", VideoTabAdapter.class, __md_methods);
	}


	public VideoTabAdapter (android.app.FragmentManager p0)
	{
		super (p0);
		if (getClass () == VideoTabAdapter.class)
			mono.android.TypeManager.Activate ("TooSeeDroid.Adapters.VideoTabAdapter, TooSeeDroid", "Android.App.FragmentManager, Mono.Android", this, new java.lang.Object[] { p0 });
	}


	public int getCount ()
	{
		return n_getCount ();
	}

	private native int n_getCount ();


	public android.app.Fragment getItem (int p0)
	{
		return n_getItem (p0);
	}

	private native android.app.Fragment n_getItem (int p0);

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
