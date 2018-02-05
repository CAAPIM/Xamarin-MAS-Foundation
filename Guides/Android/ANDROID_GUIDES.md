
## Android Mobile SDK for Xamarin

If you want to get started with our sample app or add the SDK to an existing Android app, you are in the right place.

## Prerequisites

- [General Requirements](http://mas.ca.com/aka Common)
- Android 8.1.0 for new apps, and 4.4 and later to use the sample app                                     
 
## Quick Start with Sample App

The **BasicAuthSample** sample app for Android lets you test the following with a CA Mobile API Gateway:

- Log in
- Log out
- Invoke a protected API 

The sample app was created using Visual Studio Community 2017 build 7.3.3. 

**Video version of the steps below**: 
  
[Android](https://vimeo.com/252969575)<br>
Password: **MASFoundation**</br>

1. Verify that you have a CA Mobile API Gateway and an app configuration file (`msso_config.json`).  
2. Open a terminal window in a directory of your choice and copy and past the following: **git clone https://github.com/CAAPIM/Xamarin-MAS-Foundation.git**.  
Verify that you have "Android" and "iOS" directories in both "sample" and "source" directories.
3. In Visual Studio, select File/Open.
4. Select the `BasicAuthSample.csproj` project file under `Xamarin-MAS-Foundation/sample/iOS/BasicAuthSample` or `Xamarin-MAS-Foundation/sample/Android/BasicAuthSample` folder and click **Open**. 
5. Navigate to the folder containing your `msso_config.json` app configuration file, select it, and click **Copy the file to the directory**.
6. Select **Build/Rebuild All**; Verify that you get "Build successful" confirmation.
7. Deploy and install the application on an emulator.
8. In your emulator, launch the **BasicAuthSample** app.  
You should get the confirmation: **MAS SDK started successfully**.

Now you can **login**, **logout**, and **invoke** a protected API. 

## Login: User Authentication and Authorization

**Library**: MASFoundation
**Description**: Authenticate and authorize 

### Client Credential Flow (Default)

Client credential is used when user permission to access data is not required. For example, an app that requests access to an API. In the SDK, the app requests an access token by sending its credentials (client ID and client secret) to the CA Mobile API Gateway. If the app credentials are valid, the MAG returns an access token to the app.

```C#
void StartWithDefaultConfiguration(bool shouldUseDefault, [NullAllowed] MASCompletionErrorBlock completion);
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
