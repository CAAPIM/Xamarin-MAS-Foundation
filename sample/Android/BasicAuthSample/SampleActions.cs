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
        public static void StartSDK(MainActivity activity)
        {
            if (!CheckSDKAlreadyInitialized(activity))
            {
                // MAS.Start(Context context, bool shouldUseDefault);
                MAS.Start(activity, true);

                CheckSDKInitialized(activity);
            }
        }

        //
        // Start SDK with default after changing the default configuration file
        //
        public static void StartSDKChangeDefaultConfig(MainActivity activity)
        {

            if (!CheckSDKAlreadyInitialized(activity))
            {

                // Change the default Configuration
                //MAS.SetConfigurationFileName("custom.json");
                MAS.SetConfigurationFileName("msso_config_public.json");
                
                // MAS.Start(Context context, bool shouldUseDefault);
                MAS.Start(activity, true);

                CheckSDKInitialized(activity);
            }
        }

        //
        // Start SDK with a custom JSON Object
        //
        public static void StartSDKCustomJson(MainActivity activity)
        {

            if (!CheckSDKAlreadyInitialized(activity))
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

                CheckSDKInitialized(activity);
            }
        }

        //
        // Start SDK with a File URL
        //
        public static void StartSDKFileUrl(MainActivity activity)
        {

            if (!CheckSDKAlreadyInitialized(activity))
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

                CheckSDKInitialized(activity);
            }
        }

        //
        // Start SDK with an enrolment URL
        //
        public static async void StartSDKEnrolmentURL(MainActivity activity)
        {

            if (!CheckSDKAlreadyInitialized(activity))
            {
                // Get Enrolment URL
                Java.Net.URL enrolmentUrl = new Java.Net.URL(GetEnrollmentURLAsync("https://mobile-staging-xamarinautomation.l7tech.com:8443", 
                                                                                   // This client id must match the client id in your msso config
                                                                                   "65437eae-a3fb-4c9c-843c-16a876064e07"));

                // MAS.Start(Context context, URL enrolmentUrl, MASCallback callback);
                await MAS.StartAsync(activity, enrolmentUrl);
            }
        }

        //
        // Display a dialog showing if SDK Initialized
        //
        public static void CheckSDKInitialized(MainActivity activity)
        {
			if (IsMASStarted())
                activity.Alert("MAS", "CA Mobile SDK started successfully!!");
            else
                activity.Alert("MAS", "CA Mobile SDK did not start!!");
        }

        //
        // Display a dialog showing if SDK is already initialized
        //
        public static bool CheckSDKAlreadyInitialized(MainActivity activity)
        {
			bool isInitialized = IsMASStarted();
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
		// Log in button action. See MyAuthenticationListener.cs for details on MASUser.LoginAsync();
        //
		public static async Task LoginAsync(MainActivity activity)
        {
			if (IsMASStarted())
            {
    			// Check if user is already authenticated
                if (MASUser.CurrentUser != null)
                {
    				activity.Alert("MAS", "User already authenticated as " + MASUser.CurrentUser.UserName);
                }
                else
                {

    					// Used only to trigger authentication with no callback
                        try
                        {
                            var user = await MASUser.LoginAsync();

                        }
                        catch (Java.Lang.Throwable exception)
                        {
    						activity.Alert("Error", exception.ToString());
                            MAS.CancelAllRequests();
                        }

                }
			}
            else
            {
                activity.Alert("MAS", "CA Mobile SDK did not start!!");
            }
        }

        //
        // Invoke a sample protected endpoint in the Gateway and display the returned JSON in a dialog
        //
        public static async Task InvokeApiAsync(MainActivity activity)
        {         
			if (IsMASStarted())
            {
    			try
                {
                    //Use Uri.Builder() to build the Uri and pass it into a MASRequestBuilder.
                    Android.Net.Uri.Builder uriBuilder = new Android.Net.Uri.Builder();

                    //Append path
                    uriBuilder.AppendEncodedPath("protected/resource/products?operation=listProducts");

                    //Create MASRequestBuilder
                    MASRequestBuilder builder = new MASRequestBuilder(uriBuilder.Build());

                    //Add Response type
                    builder.ResponseBody(MASResponseBody.JsonBody());

                    //Invoke the API with builder
                    var response = await MAS.InvokeAsync(builder.Build());

                    JSONObject jsonObject = (JSONObject)response.Body.Content;
    				activity.Alert("Response", jsonObject.ToString(4));

                }
                catch (Java.Lang.Throwable exception)
                {
    				activity.Alert("MAS", exception.LocalizedMessage);
                }    
			}
            else
            {
                activity.Alert("MAS", "CA Mobile SDK did not start!!");
            }
        }
        
        //
        // Logs out current user
        //
		public static async Task LogoutAsync(MainActivity activity)
        {
			if (IsMASStarted())
			{
				// Check if user is already authenticated
				if (MASUser.CurrentUser != null)
				{
					try
					{
						await MASUser.CurrentUser.LogoutAsync();
						activity.Alert("MAS", "User Logout");
					}
					catch (Java.Lang.Throwable)
					{
						activity.Alert("MAS", "User Logout Failed");
					}
				}
				else
				{
					activity.Alert("MAS", "User is not authenticated");
				}
			}
			else
            {
                activity.Alert("MAS", "CA Mobile SDK did not start!!");
            }
        }

        //
        // Lock current user session with device's local authentication
        // This will block most of operations except for MASUser.CurrentUser.Logout()
        // and MASDevice.CurrentDevice().Deregister()
        //
        public static async Task LockSessionAsync(MainActivity activity)
        {
			if (IsMASStarted())
            {
				if (MASUser.CurrentUser != null)
                {
                    try
                    {
                        await MASUser.CurrentUser.LockSessionAsync();
						activity.Alert("Session Lock", "Session Locked!");
                    }
                    catch (Java.Lang.Throwable)
                    {
						activity.Alert("Session Lock", "Session Locked Failed!");
                    }
                }
                else
                {
					activity.Alert("MAS", "User is not authenticated");
                }
            }
            else
            {
                activity.Alert("MAS", "CA Mobile SDK did not start!!");
            }
        }

        //
        // Unlock current user session and unblock all of the operations through SDK
        //
        public static async Task UnLockSessionAsync(MainActivity activity)
        {
			if (IsMASStarted())
            {
				if (MASUser.CurrentUser != null)
                {
                    if (MASUser.CurrentUser.IsSessionLocked)
                    {
                        //Unlock session
                        try
                        {
                            await MASUser.CurrentUser.UnlockSessionAsync();
                        }
                        catch (MASUser.UserAuthenticationRequiredException)
                        {
							activity.ConfirmCredential();
                        }
                        catch (Java.Lang.Throwable)
                        {
							activity.Alert("Session Unlock", "Session Unlocked Failed!");

                        }
                    }
                    else
                    {
						activity.Alert("Session Unlock", "Session not locked!");
                    }
                }
                else
                {
					activity.Alert("Session Unlock", "User not authenticated");
                }
            }
            else
            {
                activity.Alert("MAS", "CA Mobile SDK did not start!!");
            }
        }

		//
        // Check if MAS is started
        //
		public static bool IsMASStarted()
		{
			return MAS.GetState(Application.Context) == MASConstants.MasStateStarted;
		}
    }
}