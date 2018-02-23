
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

## Create an App: Choose a Method

| Create your app using...                 | Benefits                                 |
| ---------------------------------------- | ---------------------------------------- |
| [Sample app](#quick-start-with-sample-app) | <ul><li>Use a sample app with features to securely log in, log out, and invoke a protected API on a CA Mobile API Gateway.<li>Ideal for exploring the methods, or building a real app.</li></ul> |
| [No sample app, from scratch](#create-app-from-scratch-or-integrate-an-existing-app-into-the-mobile-sdk) | <ul><li>Create a Xamarin app from scratch (or integrate an existing Xamarin app) for maximum project set up control. Just download the dynamic-link library (.dll) and add your app configuration file.</li></ul> |                             
 
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
4. Open the `Assets` folder and add your `msso_config.json` app configuration file.
5. Select **Build, Build All**, and verify "Build successful".
6. Deploy and install the application on an emulator.
7. In your emulator, launch the **BasicAuthSample** app.  
You should get the confirmation: **MAS SDK started successfully**.  
If you get an error, the most likely cause is an invalid app configuration file. See your Admin for help.
8. Now you can **log in**, **log out**, and **access a protected API**. 

[TBD - Will we improve sample or use slick demo by Microsoft consultant?]
[Sample app improvements: spelling errors Log in/Log out, human error messages, human text for grant flows, sample app should be something useful and interesting for enterprise.]

## Create App from Scratch or Integrate an Existing App into the Mobile SDK

If you have an existing Xamarin app that you want to integrate into the Mobile SDK, or simply want full control to set up a new app, these steps are for you.

::: alert info
**Note**: You cannot use an existing Android Mobile SDK app. You must redo the app using c#.
::: 

### Step 1: Set Up Project in Visual Studio 

1. Verify that you have a CA Mobile API Gateway and an app configuration file (`msso_config.json`). 
2. Open a terminal window in a directory of your choice and copy and paste the following: **git clone https://github.com/CAAPIM/Xamarin-MAS-Foundation.git**     
Verify that you have both "Android" and "iOS" source directories. 
3. Open your app in Visual Studio.
4. Right-click the **References** folder and select **Edit References**. 
5. Select the **.Net Assembly** tab, and click the **Browse** button.
6. Go to: `Xamarin-MAS-Foundation/lib` directory, select the `MASFoundation.Android.dll` file, click Open and then OK.
7. Select the `Assets` folder and add your `msso_config.json` app configuration file.  
If you have multiple MAGs, you will have more than one file.

::: alert danger
**Important**: The msso_config.json file must use a valid JSON format with the required data. If the file is not found, you'll get an error message and your app will not run. Do not change any of the contents without assistance from your Admin; if you remove or alter required values, your app may not be able to connect or interact with the MAG.
:::

::: alert note
**Note**: You can rename the msso_config.json configuration file. Just make sure that you use the .json extension, and you change the name before you start the library processes. 
:::

8. In the manifests folder, open the file, `AndroidManifest.xml`.  
Before the application definition, add the permission, **android.permission.INTERNET** so your app can access the internet. For example: 

```<?xml version="1.0" encoding="utf-8"?>
<manifest xmlns:android="http://schemas.android.com/apk/res/android" android:versionCode="1" android:versionName="1.0" package="com.companyname.BabsTestApp">
    <uses-permission android:name="android.permission.INTERNET" />
    <uses-sdk android:minSdkVersion="15" />
    <application android:label="BabsTestApp">
    </application>
</manifest>
```
9. Select **Build/Rebuild All**.  
Verify that you get "Build successful" confirmation.

That's it! You can now start building out your app.

### Step 2: Start the SDK 

After your project is properly configured, you must start the SDK to establish a secure connection with the backend services. The method that starts the SDK is **MAS.start**. Note the following:

- You can put MAS.Start anywhere in your app
- MAS.Start should be processed before app startup (during the splash/loading screen of your app). 
- We recommended that you process any communication with the backend services after successful completion of the startup method, or the secure communication is not guaranteed and may fail.

```c#
// Start the SDK
MAS.Start(Application.Context, true);

```

#### Start with standard method

This method starts the SDK with the currently-active configuration. A currently-active configuration is: 
1. The last successfully used configuration. 
2. The default JSON configuration file (i.e. msso_config.json under the *assets* directory).
3. The custom JSON configuration file defined in `MAS.setConfigurationFileName`.
**Recommended for**: Most environments, including production.

```c#

```

#### Start with default configuration

This method starts the SDK with the currently-active configuration, or the default configuration (depending on the parameter value). If you specify the **true** parameter, this overwrites the currently-active configuration with the default configuration (if two configurations are different.). If you pass the **false** parameter, this behaves the same as `MAS.start(Context context)`. If the SDK is already initialized, this method stops the SDK, then restarts it with the custom JSON object.
**Recommended for**: Development environments where configurations change often.

```c#

```

#### Start with custom JSON

This method starts the SDK with the custom JSON object in jsonObject. This method overwrites the currently-active configuration with the custom JSON object, and stores it as the active configuration. If the SDK is already initialized, this method stops the SDK, then restarts it with the custom JSON object.
**Recommended for**: Using multiple MAG servers so that you can dynamically change the configuration during runtime. Note that the backend servers must have a version of the product that supports dynamic client configuration. 

```c#

```

#### Start with file URL

This method starts the SDK with the custom JSON configuration file. The custom file can be defined as a URL which indicates the path of the custom file. This method overwrites the currently-active configuration with the custom JSON file, and stores it as the active configuration. If the SDK is already initialized, this method stops the SDK, then restarts it with the custom JSON file. The SDK accepts the URL only with a __file__ protocol. If an internet URL is provided, the initialization method will fail.
**Recommended for**: Using multiple MAG servers that so you can dynamically change the configuration during runtime. Note: The backend servers must have a version of the product that supports dynamic client configuration. 

```c#

```
 
#### Start with enrollment URL

This method dynamically initializes the SDK without having the the msso_config.json within the app bundle. This lets you dynamically update the msso_config.json file without having to reinstall the app when the file is updated. As a developer, you can easily switch between MAGs.

```c#

```

The Mobile SDK retrieves the `msso_config.json` configuration using an enrollment URL to a target MAG server. You can provide enrollment URL to the Mobile SDK through app linking with an application's custom URL scheme, or any other method. After the Mobile SDK retrieves the enrollment URL, it makes a request to the enrollment URL to download the msso_cconfig.json file, and then puts in the storage.

The enrollment URL is a customizable endpoint that contains the following data: publicKeyHash for SSL pinning (required by the Mobile SDK), and a signed JWT to secure session data. For example:

`https://mobile-staging-sandbox.l7tech.com:8443/connect/device/config?sessionData=eyJ0eXAiOiJKV1QiLCJhbGciOiJSUzI1NiJ9[…….]HMuAtMeG-MrA&subjectKeyHash=kqWXaaCtYDm2Xbmd0VdL-hDF8szTTuNRe6Dk_EY9-64%3D`

The enrollment URL can be in the following format:
  - URL: the enrollment URL from the MAG server. SDK validates subjectKeyHash
  - Null: SDK initializes with default or currently-active config

This initialization method overwrites the currently-active configuration with the configuration received using the enrollment URL, and stores it as the active configuration. If the SDK is already started, this method: stops the SDK, then restarts it with the configuration retrieved via the enrollment URL.

**About Implementation**

As stated, the enrollment URL must be generated from the MAG server and passed to Mobile SDK using a mutually-agreed upon process. The URL can be generated and passed in several ways, for example:

* A system administrator can request an enrollment URL from the MAG server and distribute it to the end user using SMS or email. The app can handle the enrollment URL through app linking with a custom URL scheme and the SDK is initialized.
* The application layer can handle the request for the enrollment URL from the MAG server. The app can perform user authentication without going through the SDK.

Whatever method you choose for the enrollment URL, customizations are required in the Mobile SDK and on the MAG server. Depending on your implementation and workflow, you may need to reauthenticate users multiple times to create a secure solution.

**To get started**:

- Talk with your Admin and determine 1) your enrollment URL process 2) the user authentication workflows.
- For the POST request (to request the enrollment URL), see the SDK Reference section.
- When implementing your app, use `MAS.getState(Context)` to check the Mobile SDK status during the enrollment process to ensure success.
- For security reasons, the enrollment URL can only be used once (as expected for a one-time password). 

### Update Scopes for the Client App

When new scopes are added to the API, a new master client key must also be generated on the MAG. To update scopes for a client app:

Use the new msso_config.json by calling one of the following MAS.start interfaces (described in the previous section):
   - Start with default configuration (with true for shouldUseDefault)
   - Start with custom JSON
   - Start with file URL
   - Start with enrollment URL

## Login: Authentication and Authorization

**Library**: MASFoundation<br>
**Description**: Authentication methods to use with the MAG and backend services.</br>

### Authenticate user with password, default SDK flow

**What**: Always start with login screen.<br>
**Scenario**: You created a mobile bank app that checks bank account balances. In this case, you want users to always log in because the data is sensitive. Under the covers, the Mobile SDK requests an access token from the MAG. If the username and password are valid, the MAG authenticates and grants access.</br>

Use the `MAS.SetGrantFlow` method to set the default flow to user authentication with password.

```c#
// Set Grant Flow to Password
MAS.SetGrantFlow(MASConstants.MasGrantFlowPassword);
```

### No user authentication 

**What**: No user authentication, just access an API. <br>
**Scenario**: Upon opening your mobile bank app, you want to show your users a few bank services. Because there is no sensitive data, user login is not required. Under the covers, the Mobile SDK requests access to the API using client ID and client secret for the registered app. If the app credentials are valid, the MAG returns an access token. In OAuth, this flow is called **client credential** and it is the default flow of the Mobile SDK. In a nutshell, client credentials authenticates access to an API.</br>

Use the `MAS.SetGrantFlow` method to set the default flow to no user authentication.

```c#
// Set Grant Flow to Client Credentials
MAS.SetGrantFlow(MASConstants.MasGrantFlowClientCredentials);
```

### Authenticate user with password method

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

### Authenticate user with password, event-based

**What**: Event-based user authentication<br>
**Scenario**: You are designing a chat app with single sign-on. If a user has not signed into the app for days (or other rules-based logic), you want your app to ensure that a login screen is redisplayed. The following method is a listener that sits on the MAG. When tokens have expired for the API, the MAG returns an error, triggering the SDK to display the login screen for user reauthentication.</br>

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

