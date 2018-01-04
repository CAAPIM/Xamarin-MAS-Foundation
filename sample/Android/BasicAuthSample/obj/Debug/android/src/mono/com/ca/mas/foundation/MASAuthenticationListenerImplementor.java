package mono.com.ca.mas.foundation;


public class MASAuthenticationListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.ca.mas.foundation.MASAuthenticationListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onAuthenticateRequest:(Landroid/content/Context;JLcom/ca/mas/foundation/auth/MASAuthenticationProviders;)V:GetOnAuthenticateRequest_Landroid_content_Context_JLcom_ca_mas_foundation_auth_MASAuthenticationProviders_Handler:Com.CA.Mas.Foundation.IMASAuthenticationListenerInvoker, MASFoundation\n" +
			"n_onOtpAuthenticateRequest:(Landroid/content/Context;Lcom/ca/mas/foundation/MASOtpAuthenticationHandler;)V:GetOnOtpAuthenticateRequest_Landroid_content_Context_Lcom_ca_mas_foundation_MASOtpAuthenticationHandler_Handler:Com.CA.Mas.Foundation.IMASAuthenticationListenerInvoker, MASFoundation\n" +
			"";
		mono.android.Runtime.register ("Com.CA.Mas.Foundation.IMASAuthenticationListenerImplementor, MASFoundation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", MASAuthenticationListenerImplementor.class, __md_methods);
	}


	public MASAuthenticationListenerImplementor ()
	{
		super ();
		if (getClass () == MASAuthenticationListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.CA.Mas.Foundation.IMASAuthenticationListenerImplementor, MASFoundation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onAuthenticateRequest (android.content.Context p0, long p1, com.ca.mas.foundation.auth.MASAuthenticationProviders p2)
	{
		n_onAuthenticateRequest (p0, p1, p2);
	}

	private native void n_onAuthenticateRequest (android.content.Context p0, long p1, com.ca.mas.foundation.auth.MASAuthenticationProviders p2);


	public void onOtpAuthenticateRequest (android.content.Context p0, com.ca.mas.foundation.MASOtpAuthenticationHandler p1)
	{
		n_onOtpAuthenticateRequest (p0, p1);
	}

	private native void n_onOtpAuthenticateRequest (android.content.Context p0, com.ca.mas.foundation.MASOtpAuthenticationHandler p1);

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
