
## iOS Guides MASFoundation for Xamarin

**MASFoundation** is the core MAS framework that handles the communication and authentication layer. Quickly build secure Xamarin apps using these built-in features:
 
- Authenticate with:
  - Device registration
  - User login and registered app
  - Fingerprint session lock
  - Single Sign-On
- Securely access protected APIs that are configured with OAuth 2.0

## Support and Prerequisites

- [Requirements for CA Mobile API Gateway](https://github.com/CAAPIM/Xamarin-MAS-Foundation/blob/DocEdits/Guides/COMMON_GUIDES.md)
- iOS 11.0 for new apps written in C#   

## Create an App: Choose a Method

|| Create your app using...                 | Benefits                                 |
| ---------------------------------------- | ---------------------------------------- |
| [Quick start with sample app](#quick-start-with-sample-app) | <ul><li>Use a sample app to securely log in, log out, and invoke a protected API on a CA Mobile API Gateway.<li>Ideal for exploring the methods, or building a real app.</li></ul> |
| [Create app scratch](#create-app-from-scratch-or-integrate-an-existing-app-into-the-mobile-sdk) | <ul><li>Create a Xamarin app from scratch for maximum control, or to integrate an existing Xamarin app. <li>Download a dynamic-link library. (.dll)</li></ul> |                                  

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

## Create App from Scratch or Integrate an Existing App into the Mobile SDK

If you have a new or existing Xamarin app that you want to integrate into the Mobile SDK, or simply want to have full control over app set up, these steps are for you.

::: alert info
**Note**: You cannot use an existing iOS Mobile SDK app. You must start from scratch using c#.
::: 

### Step 1: Set up Project in Visual Studio

1. Verify that you have a CA Mobile API Gateway and an app configuration file (`msso_config.json`). 
2. Open a terminal window in a directory of your choice and copy and past the following: **git clone https://github.com/CAAPIM/Xamarin-MAS-Foundation.git**     
Verify that you have both "Android" and "iOS" source directories. 
3. Open your app in Visual Studio.
4. Right-click the **References** folder and select **Edit References**. 
6. Select the **.Net Assembly** tab, and click the **Browse** button.
7. Go to: Xamarin-MAS-Foundation/lib/<your platform dll> and click Open and OK.
8. Go to the folder containing your `msso_config.json` app configuration file, select it, and click **Copy the file to the directory**.
10. Select **Build/Rebuild All**.  
Verify that you get "Build successful" confirmation.

## Step 2: Start the SDK 

After your project is properly configured, you must start the SDK to establish a secure connection with the backend services. The startup process includes: initialize necessary services for the SDK library and network services, and load the configuration. Ideally, SDK startup should be processed before app startup (during the splash/loading screen of your app). We recommended that you process any communication with the backend services upon successful completion of the startup method. Otherwise, the secure communication is not guaranteed and may fail.

The method that starts the SDK is **MAS.start**. You can put MAS.start anywhere in your app, but we suggest that you call this method as soon as possible (first screen of your app). This ensures that the SDK is ready to handle all security and communication with the MAG server.

### Start with standard method

This method starts the SDK with the currently-active configuration. A currently-active configuration is: 1) the last successfully used configuration, 2) the default JSON configuration file (i.e. msso_config.json in your app bundle) or 3) the custom JSON configuration file defined in [MAS setConfigurationFileName:].<br>
**Recommended for**: Most environments, including production.</br>

```//
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
 
```

###  Start with default configuration

This method starts the SDK with the currently-active configuration, or the default configuration (depending on the parameter). If you specify the YES parameter, this overwrites the currently-active configuration with the default configuration (if two configurations are different.). If you pass the NO parameter, this behaves the same as [MAS start:];. If the SDK is already started, this method: stops the SDK, then restarts it with the custom JSON object.<br>
**Recommended for**: Development environments where configurations change often.</br>

``` 
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

## Login: User Authentication 

**Library**: MASFoundation<br>
**Description**: Authentication methods to use with the MAG and backend services.</br>

### No user authentication, default SDK flow

**What**: No user authentication, just access an API. <br>
**Scenario**: Upon opening your mobile bank app, you want to show your users a few bank services. Because there is no sensitive data, user login is not required. Under the covers, the Mobile SDK requests access to the API using client ID and client secret for the registered app. If the app credentials are valid, the MAG returns an access token. In OAuth, this flow is called **client credential** and it is the default flow of the Mobile SDK. In a nutshell, client credentials authenticates access to an API.</br>

Use the following flow to set the default login flow to no user authentication.

```c#
//  Set grantFlow to Client Credentials
MAS.GrantFlow = MASGrantFlow.ClientCredentials;

```

### Authenticate user with password, make default flow

**What**: Always start with login screen.<br>
**Scenario**: You created a mobile bank app that checks bank account balances. In this case, you want users to always log in because the data is sensitive. Under the covers, the Mobile SDK requests an access token from the MAG. If the username and password are valid, the MAG authenticates and grants access.</br>

Use the following method to change the default login flow to password.

```c#
//  Set grantFlow to Password
MAS.GrantFlow = MASGrantFlow.Password;
```

### Authentication user with password method

```c#
//
//  Log in with username and password
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


### Authenticate user with password, event-based

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

#### Get current authenticated user

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
**Scenario**: You are creating an app that requires fingerprint recognition, or you just want to provide it as an alternative login method to a PIN and password.<br>
**Description**: The Mobile SDK supports fingerprint authentication only on the local device. That is, the user's fingerprint is compared against the image that is stored in the secure area on the chipset. If the unique characteristics of the fingerprints match, the user is authenticated, and the phone is unlocked.</br> 

The Mobile SDK supports using fingerprint session lock with device screen lock with passcode. Because the app user can use one, both, or no locking method at all, you need to handle all of these scenarios. If the device is configured without any lock method, the Mobile SDK returns an error that device lock security is missing.

::: alert info
**Note**: Multiple fingerprints can be stored on the device, including the user and people who the user trusts. If you store multiple fingerprints on the device, all users can access the app and any API call. If you implement fingerprint with Single Sign-On enabled, all apps using SSO require a fingerprint match to unlock.
:::

::: alert info
**Note**: Fingerprint session lock is locking the currently authenticated session by using `id_token` granted through user authentication. If Mobile SDK, or server side does not return the `id_token` on successful authentication, Mobile SDK will not be able to lock the session.
:::

::: alert danger 
**Important!** Currently, the Mobile SDK does not support fingerprint using multi-factor authentication, which is often mandated in government and enterprises (FIDO protocol). Specifically, the Mobile SDK does not match the device's fingerprint against an image that is stored on a secure server, and where the original fingerprint was scanned using a third-party fingerprint scanner. If you use the local device authentication using fingerprints, understand the inherent security limitations for this feature that are documented by your device vendor.
:::

**Supported**: iOS 9+ device enable with fingerprint and/or passcode

#### Lock user session

```c#
//
//	Lock the currently authenticated user with fingerprint local authentication.
//	This will prevent Mobile SDK to consume API, and will return an error saying
//	"User session is currently locked" on the response of API request.
//
//	If the local authentication is not registered and/or available, Mobile SDK will return an error
//
MASUser.CurrentUser.LockSessionWithCompletion(completion: (completed, error) => {
    
    if (completed)
    {
    	//	session lock successful
    }
    else {
    	// an error occurred while locking the session
    }
});
```

#### Verify locked user session

```c#
if (MASUser.CurrentUser.IsSessionLocked)
{
	//	currently authenticated user's session is locked
}
else if (MASUser.CurrentUser.IsAuthenticated) {
	// currently authenticated user's session is not locked
}
```

#### Unlock user session

```c#
//
//	Unlock the currently locked user session.
//
MASUser.CurrentUser.UnlockSessionWithCompletion(completion: (completed, error) => {
    
    if (completed)
    {
    	//	session unlock successful
    }
    else {
    	// an error occurred while unlocking the session
    }
}); 


//
//	Unlock the currently locked user session with customizable description text which will appear on device's local authentication screen.
//
MASUser.CurrentUser.UnlockSessionWithUserOperationPromptMessage("DESCRIPTION TEXT", completion: (completed, error) => { 
     ....       
});
```

#### Remove user session lock

```
//
//	Removes currently locked user's session, and also removes all credentials.
//	It will work like logging out the user locally.
//
MASUser.CurrentUser.RemoveSessionLock();
```

### Single Sign-On (SSO)

**Library**: MASFoundation<br>
**Scenario**: You are developing two bank apps that you want to work seamlessly together. You want to share credentials between the apps to reduce the number of times the user has to log in.<br> 
**Description:** Single Sign-On is a session and user authentication process that allows a user to enter a single username and password to access multiple apps. 

The Mobile SDK uses the following standards for a secure an SSO implementation:
- An OAuth access token is granted for each application
- An OpenID Connect user token is granted for user verification of the SSO session
- PKI provisioning for certificate‐based validation of device

There are no SDK methods. Simply get your Admin to configure the MAG for Single Sign-On, and enable the feature in your app using the following steps. The mobile apps must be using the same MAG.</br>  

1. In Visual Studio, enable your app by selecting the main project, the `Entitlements.plist`, check the Enable Keychain checkbox under Keychain section. 
2. Add two groups:
- One for your app in the first slot
- A shared keychain group identifier to enable single sign-on

::: alert info
**Note:** The prefix of the group identifier must match the prefix of the bundle identifier of the app. Also, all apps that share the keychain must have their bundle identifiers match this prefix. The suffix should be 'singleSignOn'
:::

The shared keychain group identifier that you specify in both apps must be the same and use the same prefix as the participating apps, for example: `com.ca.singleSignOn`. The following screenshot shows an example in one of the apps:

![Shared Keychain Setting](images/shared-keychain-screenshot.png)

That's it! The MASFoundation library detects your shared keychain group settings (if set) and responds accordingly. 


## Access APIs

This section provides methods to call APIs. 

### Sent HTTP Requests to APIs

If you have custom endpoints installed on the MAG, you can make direct and secure HTTPS calls to them using the following methods. 

#### Build request with MASRequestBuilder

The MASRequestBuilder constructs the MASRequest object with options that can be modified for the request. This lets you customize and programmatically build a request and call the MAS.invoke method after MASRequest is built.

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

MASRequest also provides static methods to construct the request directly with MASRequestBuilder in the parameter of the block.

##### Get method

This method makes HTTP GET calls to an endpoint. Parameters are encoded into the endpoint URL as query parameters.

```c#
//
//	Construct MASRequest with static method
//
MASRequest request = MASRequest.GetFrom((requestBuilder) => {
	//
	//	Define request builder's properties within block
	//
   requestBuilder.EndPoint = "/protected/resource/products";
   requestBuilder.SetQueryParameter("operation", "listProducts");
   requestBuilder.RequestType = MASRequestResponseType.WwwFormUrlEncoded;
   requestBuilder.ResponseType = MASRequestResponseType.Json;
});

//
//	Use the request object to invoke an API
//
MAS.Invoke(request, completion: (responseInfo, error) => {});
```

##### Delete method

This method makes HTTP DELETE calls to an endpoint. Parameters are encoded into the endpoint URL as query parameters.

```c#
//
//	Construct MASRequest with static method
//
MASRequest request = MASRequest.DeleteFrom((requestBuilder) => {
	//
	//	Define request builder's properties within block
	//
   requestBuilder.EndPoint = "/protected/resource/products";
   requestBuilder.SetQueryParameter("operation", "listProducts");
   requestBuilder.RequestType = MASRequestResponseType.WwwFormUrlEncoded;
   requestBuilder.ResponseType = MASRequestResponseType.Json;
});

//
//	Use the request object to invoke an API
//
MAS.Invoke(request, completion: (responseInfo, error) => {});
```

##### Post method

This method makes HTTP POST calls to an endpoint. Parameters are encoded into the HTTP body.

```c#
//
//	Construct MASRequest with static method
//
MASRequest request = MASRequest.PostTo((requestBuilder) => {
	//
	//	Define request builder's properties within block
	//
   requestBuilder.EndPoint = "/protected/resource/products";
   requestBuilder.SetBodyParameter("operation", "listProducts");
   requestBuilder.RequestType = MASRequestResponseType.Json;
   requestBuilder.ResponseType = MASRequestResponseType.Json;
});

//
//	Use the request object to invoke an API
//
MAS.Invoke(request, completion: (responseInfo, error) => {});
```

##### Put method

This method makes HTTP PUT calls to an endpoint. Parameters are encoded into the HTTP body.

```c#
//
//	Construct MASRequest with static method
//
MASRequest request = MASRequest.PutTo((requestBuilder) => {
	//
	//	Define request builder's properties within block
	//
   requestBuilder.EndPoint = "/protected/resource/products";
   requestBuilder.SetBodyParameter("operation", "listProducts");
   requestBuilder.RequestType = MASRequestResponseType.Json;
   requestBuilder.ResponseType = MASRequestResponseType.Json;
});

//
//	Use the request object to invoke an API
//
MAS.Invoke(request, completion: (responseInfo, error) => {});
```

#### Simplified request methods

The Mobile SDK also provides static methods to construct and send request directly without using the `MASRequest` object.

All GET, DELETE, POST, and PUT MAS static methods also have the following set of parameters.

```c#
//
//	Default request, and response type are JSON in this method signature
//
(string endPointPath, NSDictionary parameterInfo, NSDictionary headerInfo, MASResponseInfoErrorBlock completion);

//
//	Default value for isPublic parameter is false in this method signature 
//
(string endPointPath, NSDictionary parameterInfo, NSDictionary headerInfo, MASRequestResponseType requestType, MASRequestResponseType responseType, MASResponseInfoErrorBlock completion);

(string endPointPath, NSDictionary parameterInfo, NSDictionary headerInfo, MASRequestResponseType requestType, MASRequestResponseType responseType, bool isPublic, MASResponseInfoErrorBlock completion);
```

##### Get method

```c#
NSMutableDictionary<NSString, NSString> param = new NSMutableDictionary<NSString, NSString>();
param.Add(new NSString("operation"), new NSString("listProducts"));

MAS.GetFrom(@"/protected/resource/products", param, null, MASRequestResponseType.WwwFormUrlEncoded, MASRequestResponseType.Json, completion: (responseInfo, error) =>
{
	//
	//	Handle response here
	//
});
```

##### Delete method

```c#
NSMutableDictionary<NSString, NSString> param = new NSMutableDictionary<NSString, NSString>();
param.Add(new NSString("operation"), new NSString("listProducts"));

MAS.DeleteFrom(@"/protected/resource/products", param, null, MASRequestResponseType.WwwFormUrlEncoded, MASRequestResponseType.Json, completion: (responseInfo, error) =>
{
	//
	//	Handle response here
	//
});
```

##### Post method

```c#
NSMutableDictionary<NSString, NSString> param = new NSMutableDictionary<NSString, NSString>();
param.Add(new NSString("operation"), new NSString("listProducts"));

MAS.PostTo(@"/protected/resource/products", param, null, MASRequestResponseType.Json, MASRequestResponseType.Json, completion: (responseInfo, error) =>
{
	//
	//	Handle response here
	//
});
```

##### Put method

```c#
NSMutableDictionary<NSString, NSString> param = new NSMutableDictionary<NSString, NSString>();
param.Add(new NSString("operation"), new NSString("listProducts"));

MAS.PutTo(@"/protected/resource/products", param, null, MASRequestResponseType.Json, MASRequestResponseType.Json, completion: (responseInfo, error) =>
{
	//
	//	Handle response here
	//
});
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
