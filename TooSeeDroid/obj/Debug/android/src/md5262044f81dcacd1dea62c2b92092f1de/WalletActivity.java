package md5262044f81dcacd1dea62c2b92092f1de;


public class WalletActivity
	extends android.app.Activity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("TooSeeDroid.Activities.WalletActivity, TooSeeDroid", WalletActivity.class, __md_methods);
	}


	public WalletActivity ()
	{
		super ();
		if (getClass () == WalletActivity.class)
			mono.android.TypeManager.Activate ("TooSeeDroid.Activities.WalletActivity, TooSeeDroid", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);

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
