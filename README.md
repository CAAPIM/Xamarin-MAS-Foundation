MASFoundation is the core Xamarin framework of the iOS and Android Mobile SDKs, which is part of CA Mobile API Gateway. MASFoundation handles the communication and authentication layer of the iOS Mobile SDK, making it easy for developers to establish a secure connection (TLS, Mutual SSL) to any CA Mobile API Gateway (MAG).

## Prerequisites

Visual Studio is installed.

## Get Started

You can create a project from scratch, or use the sample project with sample app (easiest and quickest).

### Build Binding DLLs

This method lets you view the Mobile SDK methods. You'll need a CA Mobile API Gateway if you want to create a secure working app.

1. In the Xamarin-MAS-Foundation repo, select **Clone or download**, click **Download ZIP**, and unzip the file.
2. Open your solution in Visual Studio.
3. In the Solution Pad, right-click the project and select, Add, Add Existing Project.
3. From your Downloads folder, select Xamarin-MAS-Foundation/source/**[platform]**/MASFoundation/MASFoundation.csproj, and click **Open**.
4. Include **[Platform]** library to the project
5. For Android, right click on Jars folder and select **add files**, add the aar file to the Jars directory
6. Rebuild the project
7. The dll file can be found under  Xamarin-MAS-Foundation/source/**[platform]**/MASFoundation/bin/Debug

### Xamarin Sample Project With Sample App

The sample project and app is the easiest way to create a secure working app that uses the power of the Mobile SDK. It requires a CA Mobile API Gateway (MAG) and an app configuration file (msso_config.json). If you haven't purchased the product yet, you can download the trial version of the MAG. For help, see [Prerequisites][prerequisites].

1. In the MASFoundation repo, select **Clone or download**, click **Download ZIP**, and unzip the file. 
2. Open the project in Visual Studio:  File, Open, .zip /sample/**[platform]**/BasicAuthSample/BasicAuthSample.csproj.
3. In the Solution Pad, right-click the Project folder, and select **Edit References...**
4. Click the folder, .Net Assemblies and click the Browse button (lower right corner), and locate the DLLs. 
5. Add the MASFoundation.**[platform]**.dll to the project.
6. In the Solution Pad, right-click the **project folder** and select **File, Add Files...**.
7. Find the msso_config.json file and click **Open**. Select the option, `Copy the file to the directory`.
8. Build and Run the project.

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
