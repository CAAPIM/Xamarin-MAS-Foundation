
## Android Mobile SDK for Xamarin

The libraries in the Xamarin SDK include:

**MASFoundation** -- the core MAS framework that handles the communication and authentication layer. With MASFoundation you can quickly build secure Xamarin apps using these built-in features:
 
- Authenticate and authorize with:
  - Device registration
  - User login and client credentials
  - Fingerprint session lock
  - Single Sign-On
- Securely access protected APIs that are configured with OAuth 2.0

## Prerequisites

- [Requirements for CA Mobile API Gateway](http://mas.ca.com/aka Common)
- Android 8.1.0 for new apps written in C#
- Android 4.4 and later to use the sample app                                     
 
## Quick Start with Sample App

The Android **BasicAuthSample** sample app lets you test the following with a CA Mobile API Gateway. The app was created using Visual Studio Community 2017 build 7.3.3. 

- Log in
- Log out
- Invoke a protected API 
   
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
8. Now you can **login**, **logout**, and **invoke** a protected API. 

## Login: Authentication and Authorization

**Library**: MASFoundation
**Description**: Authenticate and authorize 

### Start the SDK and set default login flow

```c#
//MAS.Start(Context context, bool shouldUseDefault);
MAS.Start(Application.Context, true);
//MAS.SetGrantFlow(int type);
```

**Example**: 

```c#
// Set Grant Flow to Client Credentials
MAS.SetGrantFlow(MASConstants.MasGrantFlowClientCredentials);
// Set Grant Flow to Password
MAS.SetGrantFlow(MASConstants.MasGrantFlowPassword);
```

#### Login: client credential

Use the client credential method when user permission is not required to access data. For example, an app that requests access to an API. In the SDK, the app requests an access token by sending its credentials (client ID and client secret) to the CA Mobile API Gateway. If the app credentials are valid, the MAG returns an access token to the app.

```
// Set Grant Flow to Client Credentials
MAS.SetGrantFlow(MASConstants.MasGrantFlowClientCredentials);
```

#### Login: username and password

```c#
MASUser.Login("admin", "7layer".ToCharArray(), loginCallback);
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
 
#### Login: user authentication

```c#
private class MyAuthenticationListener : Java.Lang.Object, IMASAuthenticationListener
 {
     public void OnAuthenticateRequest(Context context, long requestId, MASAuthenticationProviders providers)
     {
         MASUser.Login("admin", "7layer".ToCharArray(), loginCallback);
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

##### Get currently authenticated user

```c#
// Returns the current authenticated user or null if there is no authenticated user.
MASUser.CurrentUser
```

#### Logout

```MASUser.CurrentUser.Logout(new LogoutCallback("Logout"));
private class LoginCallback : MASCallback
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

## Access APIs

This section provides methods to call APIs. 

### Send HTTP Requests to APIs

If you have custom endpoints installed on the MAG, you can make direct and secure HTTPS calls to them using the following methods. 

#### Endpoint

The endpoint passed to these methods should be a relative path. For example, if your full URL is `https://somegatewayhost:port/some/endpoint`, you should only pass the `/some/endpoint` segment. The Mobile SDK should already be setup for network connection to the base URL `https://somegatewayhost:port`

Use Uri.Builder() to build the `Uri` and pass it into a `MASRequestBuilder`.

```
//Use Uri.Builder() to build the Uri and pass it into a MASRequestBuilder.
Android.Net.Uri.Builder uriBuilder = new Android.Net.Uri.Builder();
uriBuilder.AppendEncodedPath("protected/resource/products?operation=listProducts");
```

#### Create MASRequestBuilder

```
//Create MASRequestBuilder
MASRequestBuilder builder = new MASRequestBuilder(uriBuilder.Build());
```

#### Parameters

Parameters are encoded according to various standards defined by the HTTP verb type.

```
//Add Query Parameter
uriBuilder.AppendQueryParameter("key","value");
```
#### Headers

Add headers only if they are neede to customize a call. The Mobile SDK adds any necessary security credentials.

```
//Add Header
builder.Header("test", "test");
```

#### Response type

Based on the response content type, the SDK handles data to Object conversion; for example, with content type application/json, the SDK converts the body content to a JSONObject and returns it to the caller. The SDK predefined string, bytes, and JSONObject data type conversion.

```
//The response Type
//This is optional if the response content type is **application/json**
builder.ResponseBody(MASResponseBody.JsonBody());
//This is optional if the response content type is **text/plain**
builder.ResponseBody(MASResponseBody.StringBody());
//Response as raw data without data to object conversion
//This is optional if the response content type is neither **application/json** or **text/plain**
builder.ResponseBody(MASResponseBody.ByteArrayBody());
```

#### Callback 

The `MASCallback` defined in *MAS* returns a `IMASResponse`. Within the `IMASResponse`, you can access the HTTP response and body content:

```
//The Callback
//The MASCallback defined in MAS returns a IMASResponse.
//Within the IMASResponse, you can access the http response and the body content:
IMASResponse response = (IMASResponse)result;
int responseCode = response.ResponseCode;
string responseMessage = response.ResponseMessage;
System.Collections.Generic.IDictionary<string, System.Collections.Generic.IList<string>> headers = response.Headers
JSONObject jsonObject = (JSONObject)response.Body.Content;

```

#### Make HTTP request

```
//This method makes HTTP GET calls to an endpoint.
builder.Get();

```

#### Cancel HTTP request

```
//This method cancels the HTTP request.
long id = MAS.Invoke(builder.Build(), new ProtectAPICallback());
MAS.CancelRequest(id);
MAS.CancelAllRequests();
```

#### Example: Invoke an API with HTTP Get with IMASResponse in JSON

```
//An example to invoke an API with Http Get and response with JSON:
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
