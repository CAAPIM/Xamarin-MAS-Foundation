
## iOS Guides MASFoundation for Xamarin

If you want to get started with our sample app or add the SDK to an existing iOS app, you are in the right place.

## Prerequisites

- [General Requirements](http://mas.ca.com/TBD)
- iOS 11.0 for new apps, and 4.4 and TBD and later to use the Sample App                                     
 
## Quick Start with Sample App

The **BasicAuthSample** sample app for iOS lets you test the following with a CA Mobile API Gateway:

- Log in
- Log out
- Invoke a protected API 

The sample app was created using Visual Studio Community 2017 build 7.3.3. 

**Video version of the steps below**: 
  
[iOS](https://vimeo.com/252969575)<br>
Password: **MASFoundation**</br>

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

## Login: User Authentication and Authorization

**Library**: MASFoundation
**Description**: Authorize and Authenticate




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
