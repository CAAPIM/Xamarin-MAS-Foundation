package mono.com.ca.mas.core;


public class MobileSsoListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.ca.mas.core.MobileSsoListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onAuthenticateRequest:(JLcom/ca/mas/core/service/AuthenticationProvider;)V:GetOnAuthenticateRequest_JLcom_ca_mas_core_service_AuthenticationProvider_Handler:Com.CA.Mas.Core.IMobileSsoListenerInvoker, MASFoundation\n" +
			"n_onOtpAuthenticationRequest:(Lcom/ca/mas/core/auth/otp/OtpAuthenticationHandler;)V:GetOnOtpAuthenticationRequest_Lcom_ca_mas_core_auth_otp_OtpAuthenticationHandler_Handler:Com.CA.Mas.Core.IMobileSsoListenerInvoker, MASFoundation\n" +
			"";
		mono.android.Runtime.register ("Com.CA.Mas.Core.IMobileSsoListenerImplementor, MASFoundation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", MobileSsoListenerImplementor.class, __md_methods);
	}


	public MobileSsoListenerImplementor ()
	{
		super ();
		if (getClass () == MobileSsoListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.CA.Mas.Core.IMobileSsoListenerImplementor, MASFoundation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onAuthenticateRequest (long p0, com.ca.mas.core.service.AuthenticationProvider p1)
	{
		n_onAuthenticateRequest (p0, p1);
	}

	private native void n_onAuthenticateRequest (long p0, com.ca.mas.core.service.AuthenticationProvider p1);


	public void onOtpAuthenticationRequest (com.ca.mas.core.auth.otp.OtpAuthenticationHandler p0)
	{
		n_onOtpAuthenticationRequest (p0);
	}

	private native void n_onOtpAuthenticationRequest (com.ca.mas.core.auth.otp.OtpAuthenticationHandler p0);

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
