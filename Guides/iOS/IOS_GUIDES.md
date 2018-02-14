
## iOS Guides MASFoundation for Xamarin

**MASFoundation** is the core MAS framework that handles the communication and authentication layer. Quickly build secure Xamarin apps using these built-in features:
 
- Authenticate with:
  - Device registration
  - User login and registered app
  - Fingerprint session lock
  - Single Sign-On
- Securely access protected APIs that are configured with OAuth 2.0

## Prerequisites

- [Requirements for CA Mobile API Gateway](https://github.com/CAAPIM/Xamarin-MAS-Foundation/blob/DocEdits/Guides/COMMON_GUIDES.md)
- iOS 11.0 for new apps written in C#                                     
 
## Quick Start with Sample App

The iOS **BasicAuthSample** app:

 Lets you test the following with a CA Mobile API Gateway:  
  - Define authentication flow 
  - Start the SDK 
  - Log in
  - Access a protected API 
  - Log out
- Was created using Visual Studio Community 2017 build 7.3.3
- Requires iOS 8.0 or later to run the app

1. Open a terminal window in a directory of your choice and clone the MASFoundation repo: **git clone https://github.com/CAAPIM/Xamarin-MAS-Foundation.git**.  
After cloning, you will have /sample and /source directories for "Android" and "iOS".
2. In Visual Studio, select File, Open. 
3. Go to:`Xamarin-MAS-Foundation/sample/iOS/BasicAuthSample`, select **BasicAuthSample.csproj**, and click **Open**. 
4. Open the Assets folder and add your `msso_config.json` app configuration file.
5. Select **Build, Build All**, and verify "Build successful".
6. Deploy and install the application on an emulator.
7. In your emulator, launch the **BasicAuthSample** app.  
You should get the confirmation: **MAS SDK started successfully**.  
If you get an error, the most likely cause is an invalid app configuration file. See your Admin for help.
8. Now you can **log in**, **log out**, and **access a protected API**. 

[TBD - Will we improve sample or use slick demo by Microsoft consultant?]
[Sample app improvements: spelling errors Log in/Log out, human error messages, human text for grant flows, sample app should be something useful and interesting for enterprise.]

[Section here for manual get started with .dlls and dependency manager flow (NuGet)]

## Start the SDK 

### Step 1: Determine Start Method 

Before you start the SDK, you need determine the authentication flow for starting your app. You can choose:
- Start, no user authentication (default)
<br>or</br> 
- Start, user authentication with password

#### Start, no user authentication

**What**: No user authentication, just access an API. <br>
**Scenario**: Upon opening your mobile bank app, you want to show your users a few bank services. Because there is no sensitive data, user login is not required. Under the covers, the Mobile SDK requests access to the API using client ID and client secret for the registered app. If the app credentials are valid, the MAG returns an access token. In OAuth, this flow is called **client credential** and it is the default flow of the Mobile SDK. In a nutshell, client credentials authenticates access to an API.</br>

```c#
//  Set grantFlow to Client Credentials
MAS.GrantFlow = MASGrantFlow.ClientCredentials;

```

#### Start, user authentication with password

**What**: Always start with login screen.<br>
**Scenario**: You created a mobile bank app that checks bank account balances. In this case, you want users to always log in because the data is sensitive. Under the covers, the Mobile SDK requests an access token from the MAG. If the username and password are valid, the MAG authenticates and grants access.</br>

```c#
//
//  Login with username and password
//
MASUser.LoginWithUserName("USER_NAME", "USER_PASSWORD", completion: (completed, error) => {
     
    if (error != null)
    {
        Console.WriteLine("Error: {0}", error.LocalizedDescription);
    } else {
        Console.WriteLine("Success: User login");
    }
});
```

### Step 2: Start the SDK 

The method that starts the SDK is **MAS.start**. You can put it anywhere in your app, but we suggest that you call this method as soon as possible (first screen of your app). This ensures that the SDK is ready to handle all security and communication with the MAG server.

Add your authentication method (from the previous step) to start the SDK.

```c#
//  Set grantFlow to Password
MAS.GrantFlow = MASGrantFlow.Password;
 
//  Set grantFlow to Client Credentials
MAS.GrantFlow = MASGrantFlow.ClientCredentials;
 
//
//  Initialize SDK with default or last active configuration
// 
MAS.Start(completion: (completed, error) => {
     
    if (error)
    {
        //  SDK initialized with an error
    } else {
        //  SDK initialized without an error
    }
});
 
//
//  Initialize SDK always with default configuration
//
MAS.StartWithDefaultConfiguration(true, completion: (completed, error) => {
     
    if (error)
    {
        //  SDK initialized with an error
    } else {
        //  SDK initialized without an error
    }
});
```

### More Authentication Methods

#### Authenticate user with password (event-based)

**What**: Event-based user authentication<br>
**Scenario**: You are designing a chat app with single sign-on. If a user has not signed into the app for days (or other rules-based logic), you want your app to ensure that a login screen is redisplayed. The following method is a listener that sits on the MAG. When tokens have expired for the API, the MAG returns an error, triggering the SDK to display the login screen for user reauthentication.</br>

```c#
//
//  MAS.GrantFlow must be set to MASGrantFlow.Password in order to trigger implicit login flow
//  MAS.SetUserAuthCredentials block must be set before invoking an API
// 
MAS.SetUserAuthCredentials( (authCredentialsBlock) => {
 
    //  Build MASAuthCredentialsPassword with username and password
    MASAuthCredentialsPassword passwordCredentials = MASAuthCredentialsPassword.InitWithUsername("USER_NAME", "USER_PASSWORD");
 
    //  Invoke callback block, authCredentialsBlock, with MASAuthCredentialsPassword object
    authCredentialsBlock(passwordCredentials, false, (bool completed, NSError error) =>
    {
        if (error != null)
        {
            Console.WriteLine("Error {0}", error.LocalizedDescription);
        }
        else
        {
            Console.WriteLine("Success: User login");
        }
    });
});
```

#### Get current user

This method gets all of the properties of the currently authenticaticated user.

```c#
//
// Returns the currently authenticated user or null if there is no authenticated user.
//
MASUser currentUser = MASUser.CurrentUser;
```

#### Log out authenticated user

```c#
//
//  Logout currently authenticated user
//
MASUser.CurrentUser.LogoutWithCompletion(completion: (completed, error) => {
     
    if (error != null)
    {
        Console.WriteLine("Error: {0}", error.LocalizedDescription);
    } else {
        Console.WriteLine("Success: User logout");
    }
});
```


### Fingerprint Sessions Lock

**Library**: MASFoundation<br>
**Scenario**: You are creating a door security app and you want fingerprint recognition biometrics as part of the identification process (in addition to a PIN and password).<br>
**Description**: The Mobile SDK supports fingerprint authentication only on the local device. That is, the user's fingerprint is compared against the image that is stored in the secure area on the chipset. If the unique characteristics of the fingerprints match, the user is authenticated, and the phone is unlocked.</br> 

The Mobile SDK supports using fingerprint session lock with device screen lock with passcode. Because the app user can use one, both, or no locking method at all, you need to handle all of these scenarios. If the device is configured without any lock method, the Mobile SDK returns an error that device lock security is missing.

If you have configured both fingerprint session lock and passcode, the interaction is:
- App is active
- Device prompts user for fingerprint login
- If fingerprint fails authentication TBD times, the prompts for pattern/PIN/password
- If the passcode fail authentication TBD times, the device OS locks out the user for 30 seconds.

::: alert info
**Note**: Multiple fingerprints can be stored on the device, including the user and people who the user trusts. If you store multiple fingerprints on the device, all users can access the app and any API call. If you implement fingerprint with Single Sign-On enabled, all apps using SSO require a fingerprint match to unlock.
:::

::: alert danger 
**Important!** Currently, the Mobile SDK does not support fingerprint using multi-factor authentication, which is often mandated in government and enterprises (FIDO protocol). Specifically, the Mobile SDK does not match the device's fingerprint against an image that is stored on a secure server, and where the original fingerprint was scanned using a third-party fingerprint scanner. If you use the local device authentication using fingerprints, understand the inherent security limitations for this feature that are documented by your device vendor.
:::

**Supported**: iOS 9+ device enable with fingerprint and/or passcode

#### Lock user session

```

```

#### Verify locked user session

```
```

#### Unlock user session

```
    
```

#### Remove locked user session

```
```

### Single Sign-On (SSO)

**Library**: MASFoundation<br>
**Scenario**: You are developing two bank apps that you want to work seamlessly together. You want to share credentials between the apps to reduce the number of times the user has to log in on a device.<br> 
**Description:** Single Sign-On is a session and user authentication process that allows a user to enter a single username and password to access multiple apps. 

The Mobile SDK uses the following standards for a secure an SSO implementation:
- An OAuth access token is granted for each application
- An OpenID Connect user token is granted for user verification of the SSO session
- PKI provisioning for certificate‐based validation of device

There are no SDK methods. Simply get your Admin to configure the MAG for Single Sign-On, and enable the feature in your app using the following steps. The mobile apps must be using the same MAG. </br>  

1. In Xcode, enable your app by selecting the main project, the main app target, select the Capabilities tab, enable the Key Sharing option. 
2. Add two groups:
- One for your app in the first slot
- A shared keychain group identifier to enable single sign-on

::: alert info
**Note:** The prefix of the group identifier must match the prefix of the bundle identifier of the app. Also, all apps that share the keychain must have their bundle identifiers match this prefix. The suffix should be 'singleSignOn'
:::

The shared keychain group identifier that you specify in both apps must be the same and use the same prefix as the participating apps, for example: `com.ca.singleSignOn`. The following screenshot shows an example in one of the apps:

![Shared Keychain Setting](images/shared-keychain-screenshot.jpg)

That's it! The MASFoundation library detects your shared keychain group settings (if set) and responds accordingly. 


## Access APIs

This section provides methods to call APIs. 

### Sent HTTP Requests to APIs

If you have custom endpoints installed on the MAG, you can make direct and secure HTTPS calls to them using the following methods. 

#### Build Request with MASRequestBuilder

The MASRequestBuilder lets you programatically customize a request with the MASRequest object. 

```c#
//  Create MASRequestBuilder with HTTP method 
MASRequestBuilder requestBuilder = new MASRequestBuilder("GET");

//
//  Specify an endpoint path, any parameters or headers, and request/response type
//
requestBuilder.EndPoint = "/protected/resource/products";
requestBuilder.SetQueryParameter("operation", "listProducts");
requestBuilder.RequestType = MASRequestResponseType.WwwFormUrlEncoded;
requestBuilder.ResponseType = MASRequestResponseType.Json;
 
//  Build MASRequestBuilder to convert into MASRequest object
MASRequest request = requestBuilder.Build();
 
//  Using MASRequest object, invoke API
MAS.Invoke(request, completion: (responseInfo, error) => {
    if (error != null)
    {
        //  If an error was returned
        Console.WriteLine("Error: {0}", error.LocalizedDescription);
    }
    else if (responseInfo != null)
    {
        //  If a response is returned
        string value = "No value";
        //  MAG iOS Mobile SDK's response structure in JSON
        if (responseInfo.ContainsKey(new NSString("MASResponseInfoBodyInfoKey")))
        {
            NSDictionary values = responseInfo;
            value = values[NSObject.FromObject("MASResponseInfoBodyInfoKey")].ToString();
        }
        Console.WriteLine("Success: {0}", value);
    }
});
```

#### MASRequest methods

HTTP Get method
HTTP Delete method
HTTP Post method
HTTP Put method


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
