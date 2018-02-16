
## Android Mobile SDK for Xamarin

**MASFoundation** is the core MAS framework that handles the communication and authentication layer. Quickly build secure Xamarin apps using these built-in features:
 
- Authenticate with:
  - Device registration
  - User login and registered app
  - Fingerprint session lock
  - Single Sign-On
- Securely access protected APIs that are configured with OAuth 2.0

## Prerequisites

- [Requirements for CA Mobile API Gateway](https://github.com/CAAPIM/Xamarin-MAS-Foundation/blob/DocEdits/Guides/COMMON_GUIDES.md)
- Android 8.1.0 for new apps written in C#                                
 
## Quick Start with Sample App

The Android **BasicAuthSample** app:

- Lets you test the following with a CA Mobile API Gateway:  
  - Define authentication flow 
  - Start the SDK 
  - Log in
  - Access a protected API 
  - Log out
- Was created using Visual Studio Community 2017 build 7.3.3
- Requires Android 4.4 or later to run the app
   
1. Open a terminal window in a directory of your choice and clone the MAS Foundation repo: **git clone https://github.com/CAAPIM/Xamarin-MAS-Foundation.git**.  
After cloning, you will have /sample and /source directories for "Android" and "iOS".
2. In Visual Studio, select File, Open. 
3. Go to:`Xamarin-MAS-Foundation/sample/Android/BasicAuthSample`, select **BasicAuthSample.csproj**, and click **Open**. 
4. Open the Assets folder and add your `msso_config.json` app configuration file.
5. Select **Build, Build All**, and verify "Build successful".
6. Deploy and install the application on an emulator.
7. In your emulator, launch the **BasicAuthSample** app.  
You should get the confirmation: **MAS SDK started successfully**.  
If you get an error, the most likely cause is an invalid app configuration file. See your Admin for help.
8. Now you can **log in**, **log out**, and **access a protected API**. 

[TBD - Will we improve sample or use slick demo by Microsoft consultant?]
[Sample app improvements: spelling errors Log in/Log out, human error messages, human text for grant flows, sample app should be something useful and interesting for enterprise.]

[TBD - Section here for manual get started with .dlls and dependency manager flow (NuGet)]

## Login: Authentication

### Step 1: Determine Start Method 

Before you start the SDK, you need determine the authentication flow for starting your app. You can choose:
- Start, user authentication with password (default)
<br>or</br> 
- Start, no user authentication

#### Start, user authentication with password

**What**: Always start with user login screen.<br>
**Scenario**: You created a mobile bank app that checks bank account balances. In this case, you want users to always log in because the data is sensitive.<br>
**Description**: Under the covers, the Mobile SDK requests an access token from the MAG. If the username and password are valid, the MAG authenticates and grants access. The username/password flow is the default flow. </br>

```c#
// Authenticate user with password, explicit

MASUser.Login("admin", "mysecretpassword7".ToCharArray(), loginCallback);
private class LoginCallback : MASCallback
{
    public override void OnError(Throwable e)
    {
         MAS.CancelAllRequests();
    }
 
    public override void OnSuccess(Java.Lang.Object user)
    {
        Console.WriteLine(((MASUser)user).AsJSONObject.ToString(4));
    }
}
 ```

#### Start, no user authentication

**What**: No user authentication, just access an API.<br>
**Scenario**: Upon opening your mobile bank app, you want to show your users a few bank services. Because there is no sensitive data, user login is not required.<br>
**Description**: Under the covers, the Mobile SDK requests access to the API using client ID and client secret for the registered app. If the app credentials are valid, the MAG returns an access token. In OAuth, this flow is called **client credential**. In a nutshell, client credentials authenticates access to an API.</br>

```c#
// Set Grant Flow to Client Credentials
MAS.SetGrantFlow(MASConstants.MasGrantFlowClientCredentials);
// Set Grant Flow to Password
MAS.SetGrantFlow(MASConstants.MasGrantFlowPassword);

```

### Step 2: Start the SDK 

The method that starts the SDK is **MAS.start**. You can put it anywhere in your app, but we suggest that you call this method as soon as possible (first screen of your app). This ensures that the SDK is ready to handle all security and communication with the MAG server.

Add your authentication method (from the previous step) to start the SDK.

```c#
//MAS.Start(Context context, bool shouldUseDefault);
MAS.Start(Application.Context, true);
//MAS.SetGrantFlow(int type);

//MAS.Start(Context context, bool shouldUseDefault);
MAS.Start(Application.Context, true);
//MAS.SetGrantFlow(int type);
 
// Set Grant Flow to Client Credentials
MAS.SetGrantFlow(MASConstants.MasGrantFlowClientCredentials);
// Set Grant Flow to Password
MAS.SetGrantFlow(MASConstants.MasGrantFlowPassword);

```

### More Authentication Methods

#### Authenticate user with password (event-based)

**What**: Event-based user authentication<br>
**Scenario**: You are designing a chat app with single sign-on. If a user has not signed into the app for days (or other rules-based logic), you want your app to ensure that a login screen is redisplayed.<br>
**Description**: The following method is a listener that sits on the MAG. When tokens have expired for the API, the MAG returns an error, triggering the SDK to display the login screen for user reauthentication.</br>

```c#

private class MyAuthenticationListener : Java.Lang.Object, IMASAuthenticationListener
 {
     public void OnAuthenticateRequest(Context context, long requestId, MASAuthenticationProviders providers)
     {
         MASUser.Login("admin", "mysecretpassword7".ToCharArray(), loginCallback);
     }
 
     public void OnOtpAuthenticateRequest(Context context, MASOtpAuthenticationHandler handler)
     {
         throw new NotImplementedException();
     }
 }
 private class LoginCallback : MASCallback
 {
     public override void OnError(Throwable e)
     {
         MAS.CancelAllRequests();
     }
 
     public override void OnSuccess(Java.Lang.Object user)
     {
         Console.WriteLine(((MASUser)user).AsJSONObject.ToString(4));
     }
 }
 ```

#### Get current user

This method gets all of the properties of the currently authenticaticated user.

```c#
// Returns the current authenticated user or null if there is no authenticated user.

MASUser.CurrentUser
```

#### Log out authenticated user

```c#
// Log out currently authenticated user

MASUser.CurrentUser.Logout(new LogoutCallback("Logout"));
private class LogoutCallback : MASCallback
{
    public override void OnError(Throwable e)
    {
        //Logout failed
    }
 
    public override void OnSuccess(Java.Lang.Object obj)
    {
        //Success Logout
    }
}
 ```


### Fingerprint Sessions Lock

**Library**: MASFoundation<br>
**Scenario**: You are creating an app that requires fingerprint recognition, or you just want to provide it as an alternative login method to Pattern/PIN/Password.<br>
**Description**: The Mobile SDK supports fingerprint authentication only on the local device. That is, the user's fingerprint is compared against the image that is stored in the secure area on the chipset. If the unique characteristics of the fingerprints match, the user is authenticated, and the phone is unlocked.</br> 

The Mobile SDK supports using fingerprint session lock with device screen lock with Pattern/PIN/Password. Because the app user can use one, both, or no locking method at all, you need to handle all of these scenarios. If the device is configured without any lock method, the Mobile SDK returns an error that device lock security is missing.

::: alert info
**Note**: Multiple fingerprints can be stored on the device, including the owner and people who the owner trusts. If you store multiple fingerprints on the device, all users can access the app and any API call. If you implement fingerprint with Single Sign-On enabled, all apps using SSO require a fingerprint match to unlock.
:::

::: alert danger 
**Important!** Currently, the Mobile SDK does not support fingerprint using multi-factor authentication, which is often mandated in government and enterprises (FIDO protocol). Specifically, the Mobile SDK does not match the device's fingerprint against an image that is stored on a secure server, and where the original fingerprint was scanned using a third-party fingerprint scanner. If you use the local device authentication using fingerprints, understand the inherent security limitations for this feature that are documented by your device vendor.
:::

**Supported**: Android M, 6.0+ [API level 22+] only with fingerprint device

#### Lock user session

```c#
//Lock User Session
MASUser.CurrentUser.LockSession(new SessionLockCallback());
private class SessionLockCallback : MASCallback
{
    public override void OnError(Throwable e)
    {
        //lock session failed
    }
 
    public override void OnSuccess(Java.Lang.Object obj)
    {
        //lock session success
    }
```

#### Verify locked user session

```c#
//Verify that the user session is locked.
MASUser.CurrentUser.IsSessionLocked
```

#### Unlock user session

```c#
//Unlock User Session
MASUser.CurrentUser.UnlockSession(new UnlockCallback());
private class UnlockCallback : MASSessionUnlockCallback
{
    public override void OnError(Throwable e)
    {
        //Unlock session failed
    }
    public override void OnSuccess(Java.Lang.Object result)
    {
        //Unlock session success
    }
    public override void OnUserAuthenticationRequired()
    {
        KeyguardManager keyguardManager = (KeyguardManager)Application.Context.GetSystemService(Context.KeyguardService);
        Intent intent = keyguardManager.CreateConfirmDeviceCredentialIntent("Title","key");
        activity.StartActivityForResult(intent, 1);
    }
}
protected override void OnActivityResult(int requestCode, Result resultCode, Intent data)
{
    if (requestCode == 1)
    {
        // Credentials entered successfully!
        if (resultCode == Result.Ok)
        {
            //Call unlock again after activity result.
            MASUser.CurrentUser.UnlockSession(new UnlockCallback(this));
        }
    }
}
```

#### Remove user session lock

```c#
//Remove Locked User Session
MASUser.CurrentUser.RemoveSessionLock(new RemoveLockCallback());
private class RemoveLockCallback : MASCallback
{
    public override void OnError(Throwable e)
    {
        //remove lock failed
    }
 
    public override void OnSuccess(Java.Lang.Object obj)
    {
        //remove lock  success
    }
}
```

### Single Sign-On (SSO)

**Library**: MASFoundation<br>
**Scenario**: You are developing two bank apps that you want to work seamlessly together. You want to share credentials between the apps to reduce the number of times the user has to log in.<br> 
**Description:** Single Sign-On is a session and user authentication process that allows a user to enter a single username and password to access multiple apps. 

The Mobile SDK uses the following standards for a secure an SSO implementation:
- An OAuth access token is granted for each application
- An OpenID Connect user token is granted for user verification of the SSO session
- PKI provisioning for certificate‐based validation of device

There are no SDK methods. Simply get your Admin to configure the MAG for Single Sign-On, and enable the feature in your app using the following steps. The mobile apps must be using the same MAG. </br>  

1. In Android studio, open the AndroidManifest.xml, and add: android:sharedUserId
2. Sign your apps with the same signature.

::: alert info
The shared keychain group identifier that you specify in both apps must be the same and use the same prefix as the participating apps, for example, 'com.ca.{some shared group name}'. 
:::

The following shows an AndroidManifest.xml example in one of the apps:   

```xml
<manifest xmlns:android="http://schemas.android.com/apk/res/android"
    package="com.ca.mas.sample.singlesignonsample"
    android:sharedUserId="com.ca.mas.sample.singlesignonsample.shared"
    android:sharedUserLabel="@string/sharedUserLabel">

```

That's it! The MASFoundation library detects your shared keychain group settings (if set) and responds accordingly. 

## Access APIs

This section provides methods to call APIs. 

### Send HTTP Requests to APIs

If you have custom endpoints installed on the MAG, you can make direct and secure HTTPS calls to them using the following methods. 

#### Endpoint

The endpoint passed to these methods should be a relative path. For example, if your full URL is `https://somegatewayhost:port/some/endpoint`, you should only pass the `/some/endpoint` segment. The Mobile SDK should already be setup for network connection to the base URL `https://somegatewayhost:port`

Use Uri.Builder() to build the `Uri` and pass it into a `MASRequestBuilder`.

```c#
// Use Uri.Builder() to build the Uri and pass it into a MASRequestBuilder.

Android.Net.Uri.Builder uriBuilder = new Android.Net.Uri.Builder();
uriBuilder.AppendEncodedPath("protected/resource/products?operation=listProducts");
```

#### Create MASRequestBuilder

```c#
// Create MASRequestBuilder

MASRequestBuilder builder = new MASRequestBuilder(uriBuilder.Build());
```

#### Parameters

Parameters are encoded according to various standards defined by the HTTP verb type.

```c#
// Add Query Parameter

uriBuilder.AppendQueryParameter("key","value");
```

#### Headers

Add headers only if they are needed to customize a call. The Mobile SDK adds any necessary security credentials.

```c#
// Add Header

builder.Header("test", "test");
```

#### Response type

Based on the response content type, the SDK handles data to Object conversion; for example, with content type application/json, the SDK converts the body content to a JSONObject and returns it to the caller. The SDK predefined string, bytes, and JSONObject data type conversion.

```c#
// The response Type
// This is optional if the response content type is **application/json**
builder.ResponseBody(MASResponseBody.JsonBody());

// This is optional if the response content type is **text/plain**
builder.ResponseBody(MASResponseBody.StringBody());

// Response as raw data without data to object conversion
// This is optional if the response content type is neither **application/json** or **text/plain**
builder.ResponseBody(MASResponseBody.ByteArrayBody());
```

#### Custom response

```c#
// Sample implementation of a custom response class

private class JSONArrayResponse : MASResponseBody
{
    public override Java.Lang.Object Content
    {
        get
        {
            JSONObject jObject = (JSONObject) base.Content;
            JSONArray jArray = jObject.GetJSONArray("products");
            return jArray;
        }
    }
}
 
// Sample usage of the custom response class
MASRequestBuilder builder = new MASRequestBuilder(uriBuilder.Build());
    builder.ResponseBody(new JSONArrayResponse());
```

#### Callback 

The `MASCallback` defined in *MAS* returns a `IMASResponse`. Within the `IMASResponse`, you can access the HTTP response and body content:

```c#
// The Callback
// The MASCallback defined in MAS returns a IMASResponse.
// Within the IMASResponse, you can access the http response and the body content:

IMASResponse response = (IMASResponse)result;
int responseCode = response.ResponseCode;
string responseMessage = response.ResponseMessage;
System.Collections.Generic.IDictionary<string, System.Collections.Generic.IList<string>> headers = response.Headers
JSONObject jsonObject = (JSONObject)response.Body.Content;

```

#### Make HTTP request

```c#
// This method makes HTTP GET calls to an endpoint.

builder.Get();

```

#### Cancel HTTP request

```c#
// This method cancels the HTTP request.

long id = MAS.Invoke(builder.Build(), new ProtectAPICallback());
MAS.CancelRequest(id);
MAS.CancelAllRequests();
```

#### Example: Invoke an API with HTTP Get with IMASResponse in JSON

```c#
// An example to invoke an API with Http Get and response with JSON:

Android.Net.Uri.Builder uriBuilder = new Android.Net.Uri.Builder();
uriBuilder.AppendEncodedPath("protected/resource/products?operation=listProducts");
MASRequestBuilder builder = new MASRequestBuilder(uriBuilder.Build());
MAS.Invoke(builder.Build(), new ProtectAPICallback());
private class ProtectAPICallback : MASCallback
{
    public override void OnError(Throwable p0)
    {
        //handle error
    }
    public override void OnSuccess(Java.Lang.Object result)
    {
        IMASResponse response = (IMASResponse)result;
        JSONObject jsonObject = (JSONObject)response.Body.Content;   
    }
}
```

#### MASRequest static methods

##### Get method

```c#
//Get
MASRequestBuilder builder = new MASRequestBuilder(uriBuilder.Build());
builder.Get();
IMASRequest getRequest = builder.Build();
```

##### Delete 

```c#
//Delete
MASRequestBuilder builder = new MASRequestBuilder(uriBuilder.Build());
builder.Delete(null);
IMASRequest deleteRequest = builder.Build();
```

##### Post

```c#
//Post
MASRequestBuilder builder = new MASRequestBuilder(uriBuilder.Build());
builder.Post(MASRequestBody.JsonBody(new JSONObject()));
IMASRequest postRequest = builder.Build();
```

##### Put

```c#
//Put
MASRequestBuilder builder = new MASRequestBuilder(uriBuilder.Build());
builder.Put(MASRequestBody.JsonBody(new JSONObject()));
IMASRequest putRequest = builder.Build();
```

#### MASRequest body

Predefined MASRequestBody objects. 

##### Post a JSON object

```c#
//Post a JSON Object
MASRequestBuilder builder = new MASRequestBuilder(uriBuilder.Build());
builder.Post(MASRequestBody.JsonBody(new JSONObject()));
IMASRequest postRequest = builder.Build();
```

##### Post a string

```c#
//Post a String
MASRequestBuilder builder = new MASRequestBuilder(uriBuilder.Build());
builder.Post("Test string here");
IMASRequest postRequest = builder.Build();
```

##### Post byte[]

```c#
//Post a byte[]
MASRequestBuilder builder = new MASRequestBuilder(uriBuilder.Build());
builder.Post(MASRequestBody.JsonBody(System.Text.Encoding.ASCII.GetBytes("Test byte array here")));
IMASRequest postRequest = builder.Build();
```

##### Post a form

```c#
//Post a form
Pair pair1 = new Pair("var1", "val1");
Pair pair2 = new Pair("var2", "val2");
List<Pair> form = new List<Pair>();
form.Add(pair1);
form.Add(pair2);
 
MASRequestBuilder builder = new MASRequestBuilder(uriBuilder.Build());
builder.Post(form);
IMASRequest postRequest = builder.Build();
```


## Pre-release Agreement

Copyright (c) 2018 CA. All rights reserved.
This software is provided under the terms of CA’s Pre-Release Agreement. See the [AGREEMENT][agreement-link] file for details. This software is for evaluation purposes only and currently not supported by CA.

 [mag]: https://docops.ca.com/mag
 [mas.ca.com]: http://mas.ca.com/
 [docs]: http://mas.ca.com/docs/
 [StackOverflow]: http://stackoverflow.com/questions/tagged/massdk
 [download]: https://github.com/CAAPIM/iOS-MAS-Foundation/archive/master.zip
 [contributing]: /CONTRIBUTING
 [license-link]: /LICENSE
 [prerequisites]: http://mas.ca.com/docs/ios/1.6.00/guides/#prerequisites
 [agreement-link]: /CA-Beta-Pre-Release-Agreement

