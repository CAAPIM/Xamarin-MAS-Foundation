

## CA Mobile API Gateway for Xamarin

The Mobile SDK for Xamarin provides simple and secure access to the services of the CA Mobile API Gateway (MAG). 

### Features

The Mobile SDK for Xaramin includes **MASFoundation** -- the core framework that handles the communication and authentication layer. With MASFoundation you can quickly build secure iOS and Android apps using these built-in features:
 
- Authenticate and authorize
  - Device registration
  - User login and client credentials
  - Fingerprint session lock
  - Single Sign-On
- Securely access protected APIs with OAuth 2.0 protocol


## Support and Prerequisites


### Supported Versions 

If you have existing apps that you want to extend in Xamarin, here's what we support:

- Android 8.1.0 apps
  [Prerequisites](http://mas.ca.com/docs/android)

- iOS 11.0 apps
  [Prerequisites](http://mas.ca.com/docs/ios)


### Prerequisites

#### If you have not purchased CA Mobile API Gateway

[Start a trial using docker image](https://www.ca.com/us/developers/mas/get-started.html?returnURL=%2Fcontent%2Fcacom%2Fen_us%2Fdevelopers%2Fmas.html%3Fintcmp%3Dheadernav). The docker image includes MAG, OAuth Toolkit, and the Mobile App services. This allows you to test the Mobile SDK with the MAG backend server.

If you are not using the docker image, here are the requirements for the server:

   - CA API Gateway 9.3 
   - CA Mobile API Gateway 4.1 
   - OTK 4.2

#### If you have purchased the product, get started!

**If you have an Administrator...**
Easy. Just tell your Admin which Mobile SDK libraries that you need for your app. Then, ask your Admin for the app configuration file (called msso_config.json), which handle communication between the Mobile SDK and MAGs. (You'll add it to your project in later steps.)

**If you ARE the Administrator...**

Complete these tasks: 
- Install and configure the [CA Mobile API Gateway (MAG)](https://docops.ca.com/mag) server and [OAuth Toolkit](https://docops.ca.com/otk)
- [Prepare devices and apps for developers](https://docops.ca.com/mag)
- [Export MAG Configuration from OAuth Manager](https://docops.ca.com/mag)


**Sample msso_config.json file**

This a valid msso_config.json file that was exported from a MAG.

```json
{
    "server":
    {
        "hostname": "gatewayhostname.example.com",
        "port": 8443,
        "prefix": "",
        "server_certs":
        [
            [
                "-----BEGIN CERTIFICATE-----","MIIDADCCAeigAwIBAgIIW3j/9QFwgk8wDQYJKoZIhvcNAQEMBQAwHjEcMBoGA1UEAxMTbWF0LWRl","=","-----END CERTIFICATE-----"
            ]
        ]
    },
    
    "mag":
    {
        "system_endpoints":
        {
            "device_register_endpoint_path": "/connect/device/register",
            "device_remove_endpoint_path": "/connect/device/remove",
            "client_credential_init_endpoint_path": "/connect/client/initialize"
        },
        
        "oauth_protected_endpoints":
        {
            "enterprise_browser_endpoint_path": "/connect/enterprise/browser",
            "device_list_endpoint_path": "/connect/device/list"
        },
        
        "mobile_sdk":
        {
            "sso_enabled": true,
            "location_enabled": true,
            "location_provider": "network",
            "msisdn_enabled": true,
            "enable_public_key_pinning": false,
            "trusted_public_pki":false,
            "trusted_cert_pinned_public_key_hashes" :[],
            "client_cert_rsa_keybits": 1024
        },
        
        "ble":
        {
            "msso_ble_service_uuid":"980c2f36-bde3-11e4-8dfc-aa07a5b089db",
            "msso_ble_characteristic_uuid":"980c34cc-bde3-11r6-8dfc-aa07a5b093db",
            "msso_ble_rssi": -35
        }
    },
    
    "oauth":
    {
        "client":
        {
            "organization": "Example Organization Inc.",
            "description": "Example App",
            "client_name": "ExampleApp",
            "client_type": "confidential",
            "registered_by": "ExampleUser",
            "client_ids":
            [
                {
                    "client_id": "819455f6-9a7e-4ee0-b159-f85b25758112",
                    "client_secret":"",
                    "scope": "openid msso phone profile address email",
                    "redirect_uri": "https://ios.ssosdk.ca.com/ios",
                    "environment": "iOS",
                    "status": "ENABLED",
                    "registered_by": "ExampleUser"
                }
            ]
        },
        
        "system_endpoints":
        {
            "authorization_endpoint_path": "/auth/oauth/v2/authorize",
            "token_endpoint_path": "/auth/oauth/v2/token",
            "token_revocation_endpoint_path": "/auth/oauth/v2/token/revoke",
            "usersession_logout_endpoint_path": "/connect/session/logout",
            "usersession_status_endpoint_path": "/connect/session/status"
        },
        
        "oauth_protected_endpoints":
        {
            "userinfo_endpoint_path": "/openid/connect/v1/userinfo"
        }
    },

    "custom":
    {
        "oauth_demo_protected_api_endpoint_path":"/oauth/v2/protectedapi/foo",
        "mag_demo_products_endpoint_path":"/protected/resource/products"
    }
}

```

                                                 

 
## Quick Start with Sample App

The **BasicAuthSample** sample app lets you test the following with a CA Mobile API Gateway:

- Log in
- Log out
- Invoke a protected API 

The sample app was created using Visual Studio Community 2017 build 7.3.3. It is compatible with Android 4.4 and above, and iOS 9 and above.

**Video version of the steps below**: 
  
- [Android](https://vimeo.com/252969575)
- [iOS](https://vimeo.com/252970911) 

Password: **MASFoundation**

1. Verify that you have a CA Mobile API Gateway and an app configuration file (`msso_config.json`).  
2. Open a terminal window in a directory of your choice and copy and past the following: **git clone https://github.com/CAAPIM/Xamarin-MAS-Foundation.git**.  
Verify that you have "Android" and "iOS" directories in both "sample" and "source" directories.
3. In Visual Studio, select File/Open.
4. Select the `BasicAuthSample.csproj` project file under `Xamarin-MAS-Foundation/sample/iOS/BasicAuthSample` or `Xamarin-MAS-Foundation/sample/Android/BasicAuthSample` folder and click **Open**. 
5. Right-click the **References** folder and select **Edit References**. 
6. Select the **.Net Assembly** tab, and click the **Browse** button.
7. Go to the `Xamarin-MAS-Foundation/lib/` folder, highlight the `MASFoundation.<platform>.dll` file, click **Open**, and then **OK**.
8. Right-click the `Assets` folder for Android, or the `BasicAuthSample` folder for iOS, and select **Add Files**.
9. Navigate to the folder containing your `msso_config.json` app configuration file, select it, and click **Copy the file to the directory**.
10. Select **Build/Rebuild All**; Verify that you get "Build successful" confirmation.
11. Deploy and install the application on an emulator.
12. In your emulator, launch the **BasicAuthSample** app.  
You should get the confirmation: **MAS SDK started successfully**.

Now you can **login**, **logout**, and **invoke** a protected API. 

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
