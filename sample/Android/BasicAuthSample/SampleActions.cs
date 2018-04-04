// Copyright (c) 2018 CA. All rights reserved.
// This software is provided under the terms of CA’s Pre-Release Agreement.
// See the LICENSE [https://github.com/CAAPIM/Xamarin-MAS-Foundation/blob/LICENSE.md] file for details. 
// This software is for evaluation purposes only and currently not supported by CA.

using System.IO;
using System.Net;
using System.Threading.Tasks;
using Android.App;
using Com.CA.Mas.Foundation;
using Org.Json;

namespace BasicAuthSample
{
    public class SampleActions
    {

        //
        // Set Grant Flow to Client Credentials
        //
        public static void SetGrantFlowToClientCredential(MainActivity activity)
        {
            // MAS.SetGrantFlow(int type)
            MAS.SetGrantFlow(MASConstants.MasGrantFlowClientCredentials);
            activity.Alert("MAS", "Grant flow set to Client Credentials Flow!");
        }

        //
        // Set Grant Flow to Password
        //
        public static void SetGrantFlowToPassword(MainActivity activity)
        {
            // MAS.SetGrantFlow(int type)
            MAS.SetGrantFlow(MASConstants.MasGrantFlowPassword);
            activity.Alert("MAS", "Grant flow set to Password Flow!");
        }


        //
        // The following methods demonstrates the various ways to start the Mobile SDK
        //

        //
        // Start the SDK with default configuration
        //
        public static void startSDK(MainActivity activity)
        {
            if (!checkSDKAlreadyInitialized(activity))
            {
                // MAS.Start(Context context, bool shouldUseDefault);
                MAS.Start(activity, true);

                checkSDKInitialized(activity);
            }
        }
        //
        // Start SDK with default after changing the default configuration file
        //
        public static void startSDKChangeDefaultConfig(MainActivity activity)
        {

            if (!checkSDKAlreadyInitialized(activity))
            {

                // Change the default Configuration
                //MAS.SetConfigurationFileName("custom.json");
                MAS.SetConfigurationFileName("msso_config_public.json");

                // MAS.Start(Context context, bool shouldUseDefault);
                MAS.Start(activity, true);

                checkSDKInitialized(activity);
            }
        }

        //
        // Start SDK with a custom JSON Object
        //
        public static void startSDKCustomJson(MainActivity activity)
        {

            if (!checkSDKAlreadyInitialized(activity))
            {
                //Reads existing msso config file and saves as a JSONObject
                string mssoString = "";
                Stream inputStream = Application.Context.Assets.Open("msso_config.json");
                using (StreamReader reader = new StreamReader(inputStream))
                {
                    mssoString = reader.ReadToEnd();
                }
                JSONObject mssoJson = new JSONObject(mssoString);

                // MAS.Start(Context context, JSONObject mssoJSON);
                MAS.Start(activity, mssoJson);

                checkSDKInitialized(activity);
            }
        }

        //
        // Start SDK with a File URL
        //
        public static void startSDKFileUrl(MainActivity activity)
        {

            if (!checkSDKAlreadyInitialized(activity))
            {
                //Reads existing msso config and saves as a JSONObject
                string mssoString = "";
                Stream inputStream = Application.Context.Assets.Open("msso_config.json");
                using (StreamReader reader = new StreamReader(inputStream))
                {
                    mssoString = reader.ReadToEnd();
                }
                JSONObject mssoJson = new JSONObject(mssoString);

                //Saves JSONObject as a new json file in file directory
                var path = Path.Combine(Application.Context.FilesDir.Path, "test.json");
                var fs = new FileStream(path, System.IO.FileMode.Create);
                var outputWriter = new Java.IO.OutputStreamWriter(fs);
                outputWriter.Write(mssoString);
                outputWriter.Close();

                // MAS.Start(Context context, URL fileUrl);
                MAS.Start(activity, new Java.Net.URL("file:" + path));

                checkSDKInitialized(activity);
            }
        }

        //
        // Start SDK with an enrolment URL
        //
        public static void startSDKEnrolmentURL(MainActivity activity)
        {

            if (!checkSDKAlreadyInitialized(activity))
            {
                // Get Enrolment URL
                Java.Net.URL enrolmentUrl = new Java.Net.URL(GetEnrollmentURLAsync("https://mobile-staging-xamarinautomation.l7tech.com:8443", 
                                                                                   // This client id must match the client id in your msso config
                                                                                   "65437eae-a3fb-4c9c-843c-16a876064e07"));

                // MAS.Start(Context context, URL enrolmentUrl, MASCallback callback);
                MAS.Start(activity, enrolmentUrl, new StartWithEnrollmentCallback(activity));
            }
        }

        //
        // Display a dialog showing if SDK Initialized
        //
        public static void checkSDKInitialized(MainActivity activity)
        {
            if (MAS.GetState(Application.Context) == MASConstants.MasStateStarted)
                activity.Alert("MAS", "CA Mobile SDK started successfully!!");
            else
                activity.Alert("MAS", "CA Mobile SDK did not start!!");
        }

        //
        // Display a dialog showing if SDK is already initialized
        //
        public static bool checkSDKAlreadyInitialized(MainActivity activity)
        {
            bool isInitialized = MAS.GetState(Application.Context) == MASConstants.MasStateStarted;
            if (isInitialized)
            {
                activity.Alert("MAS", "CA Mobile SDK has already been started.");
            }
            return isInitialized;
        }

        //
        // Retrieve the Enrollment URL from the Gateway
        //
        public static string GetEnrollmentURLAsync(string gatewayUrl, string clientId)
        {
            ServicePointManager.ServerCertificateValidationCallback +=
            (sender, cert, chain, sslPolicyErrors) =>
            {
                if (cert != null) System.Diagnostics.Debug.WriteLine(cert);
                return true;
            };
            string thisUri = gatewayUrl + "/connect/device/enrollment";
            string postData = "username=admin&sub=administrator&client_id=" + clientId;

            string responseString = "";

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(thisUri);
            request.ContentType = "application/x-www-form-urlencoded";
            request.Method = "POST";

            byte[] data = System.Text.Encoding.ASCII.GetBytes(postData);
            request.ContentLength = data.Length;
            Stream requestStream = request.GetRequestStream();
            requestStream.Write(data, 0, data.Length);
            requestStream.Close();

            //request

            HttpWebResponse myResp = (HttpWebResponse)request.GetResponse();

            using (var response = request.GetResponse())
            {
                using (var reader = new StreamReader(response.GetResponseStream()))
                {
                    responseString = reader.ReadToEnd();
                }
            }
            return responseString;
        }

        //
        // Log in button action. See MyAuthenticationListener.cs for details on MASUser.Login();
        //
        public static void login(MainActivity activity)
        {
            // Check if user is already authenticated
            if (MASUser.CurrentUser != null)
            {
                activity.Alert("MAS", "User already authenticated as " + MASUser.CurrentUser.UserName);
            }
            else
            {
                // Used only to trigger authentication with no callback
                MASUser.Login(null);
            }
        }

        //
        // Invoke a sample protected endpoint in the Gateway and display the returned JSON in a dialog
        //
        public static async Task<IMASResponse> InvokeApi()
        {

            MAS.Debug();

            //Use Uri.Builder() to build the Uri and pass it into a MASRequestBuilder.
            Android.Net.Uri.Builder uriBuilder = new Android.Net.Uri.Builder();

            //Append path
            uriBuilder.AppendEncodedPath("protected/resource/products?operation=listProducts");

            //Create MASRequestBuilder
            MASRequestBuilder builder = new MASRequestBuilder(uriBuilder.Build());

            //Add Response type
            builder.ResponseBody(MASResponseBody.JsonBody());

            //Invoke the API with builder
            return await MAS.Invoke(builder.Build());
        }

        //
        // Logs out current user
        //
        public static void logout(MainActivity activity)
        {
            // Check if user is already authenticated
            if (MASUser.CurrentUser != null)
            {
                MASUser.CurrentUser.Logout(null);

                activity.Alert("MAS", "User logged out");
            }
            else
            {
                activity.Alert("MAS", "User is not authenticated");
            }
        }

        //
        // Lock current user session with device's local authentication
        // This will block most of operations except for MASUser.CurrentUser.Logout()
        // and MASDevice.CurrentDevice().Deregister()
        //
        public static void lockSession(MainActivity activity)
        {
            //Check that a user is logged in
            if (MASUser.CurrentUser != null)
            {
                //Lock session
                MASUser.CurrentUser.LockSession(new LockSessionCallback(activity));
            }
            else
            {
                activity.Alert("MAS", "User is not authenticated");
            }
        }

        //
        // Unlock current user session and unblock all of the operations through SDK
        //
        public static void unLockSession(MainActivity activity)
        {
            if (MASUser.CurrentUser != null)
            {
                if (MASUser.CurrentUser.IsSessionLocked)
                {
                    //Unlock session
                    MASUser.CurrentUser.UnlockSession(new UnlockCallback(activity));
                }
                else
                {
                    activity.Alert("MAS", "Session not locked!");
                }
            }
            else
            {
                activity.Alert("MAS", "User not authenticated");
            }
        }

        //
        //  Deregister the device is an advanced feature available available in MASDevice. 
        //  It will remove the device's registered record in the Gateway and then clear all credentials
        //
        public static void deregister(MainActivity activity)
        {
            MASDevice.CurrentDevice.Deregister(new DeregisterCallback(activity));
        }
    }
}
