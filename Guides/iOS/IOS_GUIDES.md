
## iOS Guides MASFoundation for Xamarin

The libraries in the Xamarin SDK include:

**MASFoundation** is the core MAS framework that handles the communication and authentication layer. With MASFoundation you can quickly build secure Xamarin apps using these built-in features:
 
- Authenticate with:
  - Device registration
  - User login and client credentials
  - Fingerprint session lock
  - Single Sign-On
- Securely access protected APIs that are configured with OAuth 2.0

## Prerequisites

- [General Requirements](https://github.com/CAAPIM/Xamarin-MAS-Foundation/blob/DocEdits/Guides/COMMON_GUIDES.md)
- iOS 11.0 for new apps, and TBD and later to run the Sample App                                     
 
## Quick Start with Sample App

The **BasicAuthSample** sample app for iOS lets you test the following with a CA Mobile API Gateway. The app was created using Visual Studio Community 2017 build 7.3.3. 

-- Define authentication flow 
- Start the SDK 
- Log in
- Access a protected API 
- Log out

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
8. Now you can **login**, **logout**, and **invoke** a protected API. 

## Start the SDK With Your Own App

[graphic]

### Access an API

**Scenario**: Upon opening your mobile bank app, you want to show your users a few bank services. Because there is no sensitive data, user permission (login) is not required. Under the covers, the Mobile SDK requests access to the API using client ID and client secret for the registered app. If the app credentials are valid, the MAG returns an access token. In OAuth, this flow is called **client credential** and it is the default flow of the Mobile SDK. In a nutshell, client credentials authenticates access to an API. 

### Client Credential

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

### Authenticate user with password 

**Scenario 2**: You created a specialized mobile app that just checks bank account balances. In this case, you want users to log in immediately. Under the covers, the Mobile SDK requests an access token from the MAG. If the username and password are valid, the MAG authenticates and grants access.

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
 
### Authenticate user with password for single sign-on 

**Scenario 3**: You are designing a chat app with the single sign-on feature. If a user has not signed into an app for days/hours, you want your app to ensure that a login screen is redisplayed. The following method is a listener that sits on the MAG. When tokens have expired for the API, the MAG returns an error, triggering the SDK to display the login screen for user reauthentication. In OAuth, this is called **implicit grant** flow. 

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

### Get current user

This method gets all of the properties of the currently authenticaticated user.

```
//
// Returns the currently authenticated user or null if there is no authenticated user.
//
MASUser currentUser = MASUser.CurrentUser;
```

### Log out authenticated user

```
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


## Access APIs

```
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
