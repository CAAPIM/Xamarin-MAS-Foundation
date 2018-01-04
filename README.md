MASFoundation is the core Xamarin framework of the iOS and Android Mobile SDKs, which is part of CA Mobile API Gateway. MASFoundation handles the communication and authentication layer of the iOS Mobile SDK, making it easy for developers to establish a secure connection (TLS, Mutual SSL) to any CA Mobile API Gateway (MAG).

## Get Started

To start to work with MAS for Xamarin.iOS/Xamarin.Android, you have to add the Mobile SDK DLLs to your Visual Studio project. Note that you must download the files from the `lib` folder in this repository before continue. For complete MAS functionality, install all of the MAS libraries as shown.

1. Open your project in Visual Studio.
2. With the project open in Visual Studio, right-click on the **References** folder in the Solution Pad and select `Edit References...`.
3. Select **.Net Assemblies** and click on **Browse** button to locate the dowloaded DLLs.
4. Mark the MASFoundation dll and click on **OK** to add it to the project.


## Quick Start with Sample App

### Pre-requisites

You need to have access to CA Mobile API Gateway server in order to test this sample app and obtain a msso_config file for your app. For more information, please check this [link][prerequisites].

### Open the sample in Visual Studio

1. Download the sample project from the `sample` folder in this repository.
2. Open the project with Visual studio by opening /sample/**[platform]**/BasicAuthSample/BasicAuthSample.csproj.
3. Add the MASFoundation.**[platform]**.dll into the project.
4. Right-click on the project folder in the Solution Pad and select `File->Add Files...`
5. Locate the msso_config.json file and click on **Open**. Select the option, `Copy the file to the directory`.
6. Build and Run the project.

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
