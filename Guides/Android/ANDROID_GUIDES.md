
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

```
<?xml version="1.0" encoding="utf-8"?>
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


#### Start with standard method

```c#
// Start the SDK
MAS.Start(Context context, true);

```

This method starts the SDK with the currently-active configuration. A currently-active configuration is:
1. The last successfully used configuration.
2. The default JSON configuration file (i.e. msso_config.json under the *assets* directory).
3. The custom JSON configuration file defined in `MAS.setConfigurationFileName`.
**Recommended for**: Most environments, including production.

#### Start with default configuration

```c#
MAS.Start(Context context, boolean shouldUseDefault);
```

This method starts the SDK with the currently-active configuration, or the default configuration (depending on the parameter value). If you specify the **true** parameter, this overwrites the currently-active configuration with the default configuration (if two configurations are different.). If you pass the **false** parameter, this behaves the same as `MAS.start(Context context)`. If the SDK is already initialized, this method stops the SDK, then restarts it with the custom JSON object.
**Recommended for**: Development environments where configurations change often.

#### Start with custom JSON

```c#
//Your custom JSON object.
JSONObject jsonObject = new JSONObject("{...}");

//Initializing the SDK with custom JSON object.
MAS.Start(Context context, jsonObject);
```

This method starts the SDK with the custom JSON object in jsonObject. This method overwrites the currently-active configuration with the custom JSON object, and stores it as the active configuration. If the SDK is already initialized, this method stops the SDK, then restarts it with the custom JSON object.
**Recommended for**: Using multiple MAG servers so that you can dynamically change the configuration during runtime. Note that the backend servers must have a version of the product that supports dynamic client configuration.

#### Start with file URL

```c#
Path path = new Path.Combine(Application.Context.FilesDir.Path, "test.json");

//Initializing the SDK with file URL of JSON configuration
MAS.Start(Context context, new Java.Net.URL("file:" + path));
```

This method starts the SDK with the custom JSON configuration file. The custom file can be defined as a URL which indicates the path of the custom file. This method overwrites the currently-active configuration with the custom JSON file, and stores it as the active configuration. If the SDK is already initialized, this method stops the SDK, then restarts it with the custom JSON file. The SDK accepts the URL only with a __file__ protocol. If an internet URL is provided, the initialization method will fail.
**Recommended for**: Using multiple MAG servers that so you can dynamically change the configuration during runtime. Note: The backend servers must have a version of the product that supports dynamic client configuration.

#### Start with enrollment URL

```c#
MAS.Start(Context context, URL enrolmentUrl, new MASCallback callback);
```

This method dynamically initializes the SDK without having the the msso_config.json within the app bundle. This lets you dynamically update the msso_config.json file without having to reinstall the app when the file is updated. As a developer, you can easily switch between MAGs.

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

### Geolocation

**Description**: Access to protected APIs can be based on the physical location of the application user. The application passes the physical location information to the MAG in the http header of an access request. Within the http header, location is expressed using either the latitude/longitude coordinates of the host device or the phone number associated with the device.

The MAG extracts the location, validates the data, then returns it to the application with a success or error message.

**To enable**: The following permission are required:

For MSISDN:

```xml
<uses-permission android:name="android.permission.READ_PHONE_STATE"/>
```
For Location:

To allow an app to access an approximate location derived from network location sources such as cell towers and Wi-Fi:

```xml
<uses-permission android:name="android.permission.ACCESS_COARSE_LOCATION"/>
```

To allow an app to access a precise location from location sources such as GPS, cell towers, and Wi-Fi:

```xml
<uses-permission android:name="android.permission.ACCESS_FINE_LOCATION"/>
```

**Dependencies**: Your MAG Admin must customize policies to enable and configure geolocation, and customize the msso_config.json configuration file for MSISDN.

#### Coding Runtime Permissions
For runtime permissions, the application displays a dialog to the user requesting permission when needed. The user can decide whether or not to grant access.

##### MSISDN Permission
The following code requests access to the device phone number which is required by the geolocation service.

```c#
if (Build.VERSION.SdkInt >= BuildVersionCodes.M)
{
    if (CheckSelfPermission(Manifest.Permission.ReadSms)
            != Android.Content.PM.Permission.Granted)
    {
        RequestPermissions(new string[] { Manifest.Permission.ReadSms }, 0);
    }
}

```
##### Location Permission
The following code requests access to the location information. The  <uses-permission android:name="android.permission.ACCESS_FINE_LOCATION"/> permission is set in the manifest file.

```c#
if (Build.VERSION.SdkInt >= BuildVersionCodes.M)
{
    if (CheckSelfPermission(Manifest.Permission.AccessFineLocation)
            != Android.Content.PM.Permission.Granted)
    {
        RequestPermissions(new string[] { Manifest.Permission.AccessFineLocation }, 0);
    }
}

```

##### Error Handling

This error occurs if the client fails to provide the geolocation header required by the server.

```c#
public class GeolocationCallback : MASCallback
{
    public override void OnSuccess(Java.Lang.Object result)
    {
        // Handle Success
    }
    public override void OnError(Throwable e)
    {
        if (e.Cause is LocationRequiredException) {
            // Handle Error
        }
    }
}
```

This error occurs when the location sent from the client is not authorized to access the protected endpoint on the MAG.

```c#
public class GeolocationCallback : MASCallback
{
    public override void OnSuccess(Java.Lang.Object result)
    {
        // Handle Success
    }
    public override void OnError(Throwable e)
    {
        if (e.Cause is LocationInvalidException) {
            // Handle Error
        }
    }
}
```

This error occurs if the MAG requires an MSISDN value in the header, and the client fails to supply one.

```c#
public class MsisdnCallback : MASCallback
{
    public override void OnSuccess(Java.Lang.Object result)
    {
        // Handle Success
    }
    public override void OnError(Throwable e)
    {
        if (e.Cause is MobileNumberRequiredException) {
            // Handle Error
        }
    }
}
```


This error occurs if the MSISDN value sent from the client is unauthorized to access the protected endpoint on the MAG.

```c#
public class MsisdnCallback : MASCallback
{
    public override void OnSuccess(Java.Lang.Object result)
    {
        // Handle Success
    }
    public override void OnError(Throwable e)
    {
        if (e.Cause is MobileNumberInvalidException) {
            // Handle Error
        }
    }
}
```


## Debug the SDK

### Enable Debug Before App is Running

  Run the following command in a terminal window:
```c#
adb shell setprop log.tag.MAS VERBOSE
```
**Note:** Whenever you restart the device or emulator, you must rerun the command to enable debug.

### Enable Debug During Runtime

```c#
// Enable debug mode
MAS.Debug();
```

### Configure app for network monitoring

If your application needs monitoring, here's how to hook up your application into monitoring the network call:

```c#
MAS.SetConnectionListener(new MASConnectionListener());

private class MASConnectionListener : Java.Lang.Object,  IMASConnectionListener
{
    public void OnConnected(HttpURLConnection connection)
    {
        // On connection connected
    }

    public void OnObtained(HttpURLConnection connection)
    {
        // On connection obtained
    }
}
```

**Note:** You should not dump sensitive information to Production.

#### Conveniences

To determine if the network connection to the MAG is currently reachable:

```c#
MAS.GatewayIsReachable(new GatewayIsReachableCallback());

private class GatewayIsReachableCallback : MASCallback
{
    public override void OnError(Throwable p0)
    {
        // Handle error
        Console.WriteLine(p0);
    }

    public override void OnSuccess(Java.Lang.Object result)
    {
        // GatewayIsReachable success result
        Console.WriteLine(result);
    }
}
```

#### Rename the msso_config.json file

You can rename the msso_config.json configuration file, as long as you use the .json extension, and you change the filename before you start the library processes.

```c#
MAS.SetConfigurationFileName("custom_msso.json");
```


#### Stop and reset the device

To stop all processes in the library:

```c#
MAS.Stop();
```

#### Reset all app, device, and user credentials

To reset all application, device, and user credentials in memory, or in the local and shared group keychains, use the following method:

```c#
MASDevice.CurrentDevice.ResetLocally();
```

::: alert info
**Note:** We recommend that you add a warning UI component to indicate to the user exactly what they are doing, with a confirmation before proceeding with this action.
:::

::: alert info
**Note:** This only resets the credentials on the device. To reset and deregister the device record on the MAG, call `MASDevice.CurrentDevice.Deregister()`.
:::

#### Handle errors
Extract more information from the `onError` callback:

```c#
OnError(Throwable t)
{
    if (t.Cause is TargetApiException) {
        TargetApiException exception = (TargetApiException)t.Cause;
        Console.WriteLine("Response Message: {0}", exception.Response.ResponseMessage); // Server resposne message
        Console.WriteLine("Response Body: {0}", exception.Response.Body.Content.ToString()); // Server response content
        Console.WriteLine("Response Code: {0}", exception.Response.ResponseCode);// Server response http code
    }
}
```

## Troubleshoot Your App

### Issues Between Your App and the MAG Server

This section describes some of the issues that can occur between your app and the MAG server.

#### msso_config.json file

The msso_config.json file is how the Mobile SDK communicates with the MAG server. It contains OAuth scope values that provide permissions to operations and access to resources for your app. If the file has missing or incorrect scopes, this can cause errors.

**Scope help for Admins:**

- [Create a Client App for the Mobile SDK](https://docops.ca.com/mag)
- [Manage Permissions With Scopes](https://docops.ca.com/mag)  

#### Apps and Backend Policies

[Mobile Policies](https://docops.ca.com/mag
[Error Codes](https://docops.ca.com/mag)

### SDK Exceptions

**MAGException**

MAGException is the base exception class for MAG. It is thrown when an error occurs while processing the endpoint request.

```
com.ca.mas.core.error.MAGException
```

| SubClasses of MAGException               | Notes                                    |
| ---------------------------------------- | ---------------------------------------- |
| ClientCredentialsException               | An error occurred while initializing the dynamic client id and client credentials. |
| DeviceRegistrationAwaitingActivationException | Device is registered but is awaiting approval and activation by an administrator. |
| MSISDNRequiredException                  | Missing phone number.                    |
| LocationInvalidException                 | Unknown location.                        |
| OAuthException                           | An error occurred while processing the OAuth Request. |
| LocationRequiredException                | Missing location.                        |
| RegistrationException                    | And error occurred while processing the device registration. |
| MSISDNInvalidException                   | Invalid phone number.                    |


**MAGServerException**
```
com.ca.mas.core.error.MAGServerException
```

MAGServerException is the base exception class for MAG Server endpoint errors. These errors are related to registering the client, registering the device, and authenticating the user. An errorCode attribute in the exception maps to the **x-ca-err** code.

The following Subclasses provide more details.

| Subclass                         | Serialized Form                   | Notes                                    |
| -------------------------------- | --------------------------------- | ---------------------------------------- |
| ClientCredentialsServerException | com.ca.mas.core.clientcredentials | Occurs when initializing the dynamic client id and client credentials. |
| OAuthServerException             | com.ca.mas.core.oauth             | Occurs while accessing the OAuth endpoint. |
| RegistrationServerException      | com.ca.mas.core.registration      | Occurs when accessing the register endpoint. |
| AuthenticationException          | com.ca.mas.core.auth              | Occurs when accessing the MAG Server register or token endpoint. |      |

To capture the result of an AuthenticationException when the user enters the wrong password:

```c#
MASUser.Login("username", "password".ToCharArray(), new LoginCallback());

private class LoginCallback : MASCallback
{
    public override void OnError(Throwable e) {
        if (e.Cause is AuthenticationException) {
            // Invalid username or password
        }
        else {
            // Handle other failure
            MAS.CancelAllRequests();
        }
    }

    public override void OnSuccess(Java.Lang.Object user) {
        // Successful login
    }
}
```

**MASException**
```
com.ca.mas.foundation.MASException
```

MASException represents a general error from the Mobile SDK. The MASException is provided to the `MASCallback#OnError` interface.

```c#
MAS.Invoke(request, new InvokeAPICallback());

private class InvokeAPICallback : MASCallback
{
    public override void OnSuccess(Java.Lang.Object result) {
        // Handle successful invocation
    }

    public override void OnError(Throwable t) {
        MASException exception = (MASException) t.Cause;
        Console.WriteLine("Root cause: {0}", exception.RootCause); // retrieve the root cause of the exception

    }
}
```

**Reserved x-ca-err Error Codes:**

- **xxxx990 Access Token Expired**
  Although the access_token is accepted by the MAG server, the application server considers the token expired. This can occur when the MAG server and the application server are not synchronized. In this case the Access Token is expired, the token is removed from the keychain and the process flow repeated, this time without an access token. With no access token, a refresh token is issued.
- **xxxx991 Access Token Not Granted**
  The API requires a SCOPE value that the request does not contain.
- **xxxx992 No Access Token**
  The access_token was not included in the request, or the same access_token was included more than once in the same request. Not testable from client SDK.
- **xxxx993 Token is disabled**
  The associated client is disabled.
- **xxxx000 Unknown**
  Not testable from the client SDK.

**TargetAPIException**

The TargetAPIException is used to capture errors originating from the application. The error is thrown when the target application API returns an http status code that is not within the range 200 - 299. These errors are primarily defined by the application developer.

To receive the response from the API, use the request: `Com.CA.Mas.Core.Error.TargetApiException#Response`

The following code shows how to capture the result of the request with TargetApiException interface:

```c#
MAS.Invoke(request, new InvokeAPICallback());

private class InvokeAPICallback : MASCallback
{
    OnError(Throwable t)
    {
        if (t.Cause is TargetApiException) {
            TargetApiException exception = (TargetApiException)t.Cause;

            if(exception.Response.ResponseCode == 404) {
                // Do something
            }
            Console.WriteLine("Response Headers: {0}", exception.Response.Headers); // Server resposne headers
            Console.WriteLine("Response Message: {0}", exception.Response.ResponseMessage); // Server resposne message
            Console.WriteLine("Response Body: {0}", exception.Response.Body.Content); // Server response content
            Console.WriteLine("Response Code: {0}", exception.Response.ResponseCode);// Server response http code
        }
    }
    .....
}
```


### Reset the App

During app testing (or other administrative/devops use cases), you may need to reset the app and clean up the local cache on the device. Conditions that can lead to resetting the app include:
- You get a 'Device Unknown' error message
- The device record has been removed on the MAG
- You get an error message that the device is already registered

Use the following method to deregister the device and remove the record on MAG. Note that all apps associated with the device are deregistered.

### Deregister a device

You can programmatically deregister a device to:

- Revoke access to a device identified as risky
- Use the device again for test runs
- Troubleshoot an app if there is a "device already registered" error

Deregistration removes the device record from MAG. Use this feature with caution because it may not be easy for end users to use if you make it publicly available. We suggest a warning UI component or similar to indicate to the user exactly what they are doing, with a confirmation before proceeding with this action.

:::alert info **Note**: You must restart your app to get new registration of the app, device and user authentication. :::


```c#
MASDevice.CurrentDevice.Deregister(new DeregisterCallback());

// Deregister Callback
public class DeregisterCallback : MASCallback
{
  public override void OnSuccess(Java.Lang.Object result)
  {
      // The device is successfully deregistered
  }
  public override void OnError(Throwable e)
  {
      // Handle the error
  }
}

```

### SSL Pinning Validation Failed

javax.net.ssl.SSLHandshakeException: java.security.cert.CertPathValidatorException: Trust anchor for certification path not found.
This error means that the server security configuration in the MASSecurityConfiguration object for the hostname:portnumber is not valid or is missing. See [Create the MASSecurityConfiguration object](#create-the-massecurityconfiguration-object).

### General Problems

#### Authentication errors

If you get invalid token, unauthorized, or other authentication errors, it may be due to a MAG server change.  Your Admin must change a client parameter (documented in the 4.0 Release Notes) to allow more than one token per user/client (default). Without making the server changes, the Mobile SDK will not allow the same user to log in to multiple apps instances.

#### Disable PKCE

Proof Key for Code Exchange (PKCE) provides an extra layer of security for your app. It is enabled by default and works with proximity login. Your Admin does not need to enable the feature on the MAG server. In the enabled state, the Mobile SDK responds to authentication requests or not, based on the policy that is configured by your Admin using OAuth Toolkit. We recommend leaving this feature enabled. However, if you have a specific use case to disable it, go to Reference documentation and change the state: `MAS.enablePKCE(true);`

#### SDK sample app fails

**Error: MAGException: Unable to post to <url>: Trust anchor for certification path not found**

This error occurs when the sample app fails to connect to the MAG server. It is a MAG certificate configuration issue that must be resolved by your Admin. You may need an updated msso_config.json file.

#### Cannot log in due to invalid mag-identifier
This is a common issue that is caused by the following conditions:
* The registration for the client Id already exists on the MAG Manager.
* There is an application already installed with a different msso_config file.

To resolve this issue, try the following;
1. Deregister the application from the MAG Manager by issuing a deregister request.
2. Uninstall the applications from your device that have conflicting registrations.
3. Log into the MAG Manager and remove the client registration for your application.

### Device is already registered error

The MAG server secures device registration and re-registration with this simple logic: only the previously-registered user or client can perform the re-registration. This logic (which resides in policy), is perfect for production environments. However, in Mobile SDK 1.5 and earlier, this caused "device already registered" errors during app testing with multiple users and uninstalling/reinstalling the app.

In this release, the Mobile SDK generates a new device identifier after uninstall/reinstall, which reduces the likelihood that you'll get this error.

But if you get this error, follow these steps to delete unwanted registered device entries in MAG Manager. If you don't have experience with MAG Manager, work with your Admin.
1. Log into the MAG Manager. For example: `https://your_hostname/instanceModifier/mag/manager`
2. Find your registered device.    
If you don’t know the device user, enter “*” in the “Lookup values for user” field.
3. Find your device identifier by calling this method in the Mobile SDK: MASDevice.getCurrentDevice().getIdentifier().
4. Map the device identifier to the OU attribute in MAG Manager (for example: OU=08f8ce12096fcf9d1a1779e4f9dc5fe15519fa2b4ace2af904cf954cc5f5c4e5), Registered Name (DN) column.
4. Click “Delete Device” to delete the device.

::: alert info
**Note**: It's not likely, but it's possible that the policy for device registration is incorrectly configured, so check with your Admin if you continue to get "device already registered" errors. See [Configure Device Registration](https://docops.ca.com/mag)
:::

:::alert info
**Note**: If you are using the default client credential registration, multiuser mode must be enabled on the MAG server.
:::

#### Requests are failing

If you see this error: 'ERROR: Could not subscribe to the topic '/1.0/organization/CA Technologies/client/dd0ce313-0683-4fab-b35c-f538789c28d3/users/null/custom/Ha#h''

Check the server-side message topic format for unsupported characters (+ and #).

#### Could not connect to server

This issue occurs when using an emulator on an internal network or over a VPN. To fix the issue, place a reference to the server in the hosts file of your computer - not in the emulator. After that is in place, it may take some time before this mapping propagates and the host resolution takes place.

#### Registered device is invalid error

Any of the following:
- The device is already registered (mag-identifier and username match an existing registration)
- MAG server is not configured to accept registration updates
- Existing registration was found but could not be updated
- Certificate DN is already registered
- Certificate DN is too long and exceeds the maximum length

::: alert danger
**Note**: If you are using the default client credential registration, multiuser mode must be enabled on the MAG Server.
:::

### Platform Limitations During App Development

The following limitations exist only during development.

- Only Android M+ devices can act as peripheral devices.
- Only the Nexus 6 device has been tested as a peripheral device.

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
