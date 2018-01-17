MASFoundation is the core Xamarin framework of the iOS and Android Mobile SDKs, which is part of CA Mobile API Gateway. MASFoundation handles the communication and authentication layer of the iOS Mobile SDK, making it easy for developers to establish a secure connection (TLS, Mutual SSL) to any CA Mobile API Gateway (MAG).

## Prerequisites

Visual Studio is installed.

## Get Started

There are two ways to get started:

- From scratch by adding .aar files with DLLs to a new or existing app.  
Good choice if you already have an app, or want to manually control set up.
- Use the Xamarin sample project with sample app 
Quick and easy way to use a sample app and verify basic authentication with a MAG server.

### From Scratch (.aar files and DLL)

1. In the Xamarin-MAS-Foundation repo, select **Clone or download** and click the icon to highlight the github URL.
2. Open a terminal window and enter: git clone <github URL>.  
After cloning, you should have /source directory with .aar files.
3. In Visual Studio, open your project.
4. Open MASFoundation.csproj. 
5. Open MASFoundation and right-lick the Jars folder and select: **Add**, **Add New Files**.
6. Open your sownload folder. 
7. Highlight **mas-foundation-release.aar** and click the Open button.
8. Select **Copy the file to the directory**, and click OK.  
The .aar is added to the Jars folder.
9. To verify the packages are added, open **Transforms folder, metadata.xml**.  
Scroll down under Java Bindings Metadata to see packages with these names: "@name='com.ca.mas.core"
10. Select Reference folder and select **Build All**.  
Verify there are no errors.
11. To verify the dll, open the terminal and navigate to: **source/**, **<platform>**, **MASFoundation/**, **bin**, **Debug**.

### Xamarin Sample Project With Sample App

The sample project with sample app is the easiest way to test basic authentication with an app. It requires a CA Mobile API Gateway (MAG) and an app configuration file (msso_config.json). If you haven't purchased the product yet, you can download the trial version of the MAG. For help, see [Prerequisites][prerequisites].

1. In the Xamarin-MAS-Foundation repo, select **Clone or download** and click the icon to highlight the github URL.
2. Open a terminal window and enter: git clone <github URL>.  
3. Navigate to: **sample/ folder**, **<platform>** 
3. In Visual Studio, open your project.
4. In your download folder, navigate to: Xamarin-MAS-Foundation, /sample, <platform>, BasicAuthSample/, and open BasicAuthSample.csproj. 
5. Open BasicAuthSample folder, and go to: Resources/, and open MainActivity.cs.  
You should see this line at the top, "using Com.CA.Mas.Foundation; 
6. right-click /References folder, and select **Edit References**. 
7. Click .Net Assembly tab, and click Open button (bottom right).
8. Go to Downloads folder, highlight MASFoundation.dll, click Open, and click OK. 
9. Right-click Assets folder, and select **Add Files**.
10. In Visual Studio, open your folder with your app configuration file (msso_config.json), and select **Copy the file to the directory**  
Verify that the msso_config.json file is in the Assets folder. 
11. Highlight the MainActivity.cs file and select, **Rebuild All**.  
 
## Communication

- *Have general questions or need help?*, use [Stack Overflow][StackOverflow]. (Tag 'massdk')
- *Find a bug?*, open an issue with the steps to reproduce it.
- *Request a feature or have an idea?*, open an issue.

## How You Can Contribute

Contributions are welcome and much appreciated. To learn more, see the [Contribution Guidelines][contributing].

## Documentation

For more documentation and API references, go to our [main website][docs]

## License

Copyright (c) 2018 CA. All rights reserved.

This software may be modified and distributed under the terms
of the MIT license. See the [LICENSE][license-link] file for details.

 [mag]: https://docops.ca.com/mag
 [mas.ca.com]: http://mas.ca.com/
 [get-started]: http://mas.ca.com/get-started/
 [docs]: http://mas.ca.com/docs/
 [blog]: http://mas.ca.com/blog/
 [videos]: https://www.ca.com/us/developers/mas/videos.html
 [StackOverflow]: http://stackoverflow.com/questions/tagged/massdk
 [download]: https://github.com/CAAPIM/iOS-MAS-Foundation/archive/master.zip
 [contributing]: https://github.com/CAAPIM/iOS-MAS-Foundation/blob/develop/CONTRIBUTING.md
 [license-link]: /LICENSE
 [prerequisites]: http://mas.ca.com/docs/ios/1.6.00/guides/#prerequisites
