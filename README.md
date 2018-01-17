
## About Xamarin MASFoundation

Xamarin MASFoundation is the core framework of the iOS and Android Mobile SDKs, which is part of CA Mobile API Gateway. MASFoundation handles the communication and authentication layer of the Mobile SDK, making it easy for developers to establish a secure connection (TLS, Mutual SSL) to any CA Mobile API Gateway (MAG).


## Get Started

These instructions are for both iOS and Android developers. All you need to get started is:

- Visual Studio installed
- If you are using the Xamarin sample app, you'll need a CA Mobile API Gateway and an app configuration file (msso_config.json).  
If you haven't purchased the product yet, you can download the trial version of the MAG. For help, see [Prerequisites][prerequisites].

### Step 1: Generate the Xamarin DLL

1. In the Xamarin-MAS-Foundation repo, select **Clone or download** and click the icon to highlight the github URL.
2. Open a terminal window and enter: git clone <github URL>.  
After cloning, you should have /source directory with .aar files.
3. In Visual Studio, open your project.
4. Open MASFoundation.csproj. 
5. Open MASFoundation and right-lick the Jars folder and select: **Add**, **Add New Files**.
6. Open your project folder. 
7. Highlight **mas-foundation-release.aar** and click the Open button.
8. Select **Copy the file to the directory**, and click OK.  
The .aar is added to the Jars folder.
9. To verify the packages are added, open **Transforms folder, metadata.xml**.  
Scroll down under Java Bindings Metadata to see the added packages ("@name='com.ca.mas.core")
10. Select Reference folder and select **Build All**.  
Verify there are no errors.
11. To verify the dll, open the terminal and navigate to: **source,** **<platform>,** **MASFoundation,** **bin,** **Debug**.  
You should see **MASFoundation.dll**. 

### Step 2: Get Xamarin Sample App and 

The sample project with sample app is the easiest way to test basic authentication with a CA Mobile API Gateway (MAG). The Xamarin sample app lets you:

- Login
- Logout
- Invoke a protected API 

1. In the Xamarin-MAS-Foundation repo, select **Clone or download** button and click the icon to highlight the github URL.
2. Open a terminal window, and in a directory of your choice, enter: git clone <github URL>   
3. Verify the clone her: **Xamarin-MAS-Foundation**, **sample/**
3. In Visual Studio, open your project.
4. In your download directory folder, go to: Xamarin-MAS-Foundation, /sample, <platform>, BasicAuthSample/, highlight **BasicAuthSample.csproj** and click Open. 
5. Open the **BasicAuthSample** folder, and go to: Resources/, and open MainActivity.cs.  
You should see the basic sample app for your platform.
6. Open the **References** folder, and right-click to select **Edit References**. 
7. Click the **.Net Assembly** tab, and click the **Browse** button (bottom right).
8. Go to **Downloads** folder, highlight **MASFoundation.dll**, click **Open**, and click **OK**. 
9. Right-click the **Assets** folder, and select **Add Files**.
10. Navigate to the folder with your app configuration file (msso_config.json), and select **Copy the file to the directory**  
Verify that the msso_config.json file is in the Assets folder. 
11. Highlight the MainActivity.cs file and select, **Rebuild All**.  
Verify that you get "Build successful" confirmation.
12. In your platform emulator, open BasicAuthSample app.  
If the msso_config.json file is valid, you should get the confirmation: **MAS SDK started successfully**.
13. Now you can login, logout, and invoke a protected API.  
 
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
