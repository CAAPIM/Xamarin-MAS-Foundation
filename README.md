
The Mobile SDK provide simple and secure access to the services of the CA Mobile API Gateway (MAG). MASFoundation is the core framework which handles the communication and authentication layer, making it easy for Xamarin developers to establish a secure connection.

With MASFoundation for Xamarin you will be able to quickly build secure iOS and Android apps by leveraging our built-in capabilities to:
- Authenticate users
- Securely access to protected APIs with oAuth 2.0 protocol

This framework is for **evaluation purposes only** and currently not supported by CA.

## Get Started

These instructions are for **both iOS and Android developers**. If Visual Studio is installed, you are ready to go. 

### Quick Start with Sample App

The MASFoundation implementation for use with Xamarin "BasicAuthSample" app lets you test the following with a CA Mobile API Gateway:

- Login
- Logout
- Invoke a protected API 

Video version of the steps below: 
Password: **MASFoundation**
  
- [Android](https://vimeo.com/252969575)
- [iOS](https://vimeo.com/252970911) 

1. Verify that you have a CA Mobile API Gateway and an app configuration file (`msso_config.json`).  
If you haven't purchased the product yet, you can download the trial version of the MAG. For help, see [Prerequisites][prerequisites].
2. Open a terminal window in a directory of your choice and copy and past the following: **git clone https://github.com/CAAPIM/Xamarin-MAS-Foundation.git**     
Verify that you have "Android" and "iOS" directories both in "sample" and "source" directories.
4. In Visual Studio, select File/Open.
5. Select the `BasicAuthSample.csproj` project file under `Xamarin-MAS-Foundation/sample/iOS/BasicAuthSample` or `Xamarin-MAS-Foundation/sample/Android/BasicAuthSample` folder and click **Open**. 
6. Right-click the **References** folder and select **Edit References**. 
7. Select the **.Net Assembly** tab, and click the **Browse** button.
8. Go to the `Xamarin-MAS-Foundation/lib/` folder, highlight the `MASFoundation.<platform>.dll` file, click **Open**, and then **OK**.
9. Right-click the `Assets` folder for Android, or the `BasicAuthSample` folder for iOS, and select **Add Files**.
10. Navigate to the folder containing your `msso_config.json` app configuration file, select it, and click **Copy the file to the directory**.
11. Select **Build/Rebuild All**; Verify that you get "Build successful" confirmation.
12. Deploy and install the application on an emulator.
13. In your emulator launch the **BasicAuthSample** app.

You should get the confirmation: **MAS SDK started successfully**.

Now you can **login**, **logout**, and **invoke** a protected API. 
 
## Communication

- *Have general questions or need help?*, use [Stack Overflow][StackOverflow]. (Tag 'massdk')
- *Find a bug?*, open an issue with the steps to reproduce it.
- *Request a feature or have an idea?*, open an issue.

## How You Can Contribute

Contributions are welcome and much appreciated. To learn more, see the [Contribution Guidelines][contributing].

## Documentation

For more documentation and API references for Mobile SDK iOS and Android, go to our [main website][docs]

## Pre-release Agreement

Copyright (c) 2018 CA. All rights reserved.
This software is provided under the terms of CA’s Pre-Release Agreement. See the [AGREEMENT][agreement-link] file for details. This software is for evaluation purposes only and currently not supported by CA.

 [mag]: https://docops.ca.com/mag
 [mas.ca.com]: http://mas.ca.com/
 [docs]: http://mas.ca.com/docs/
 [StackOverflow]: http://stackoverflow.com/questions/tagged/massdk
 [download]: https://github.com/CAAPIM/iOS-MAS-Foundation/archive/master.zip
 [contributing]: https://github.com/CAAPIM/iOS-MAS-Foundation/blob/develop/CONTRIBUTING.md
 [license-link]: /LICENSE
 [prerequisites]: http://mas.ca.com/docs/ios/1.6.00/guides/#prerequisites
 [agreement-link]: https://github.com/CAAPIM/Xamarin-MAS-Foundation/raw/LicenseEdits/CA%20Beta%20%20Pre-Release%20Agreement.docx
