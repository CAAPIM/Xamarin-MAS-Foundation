    using System.Threading.Tasks;

    namespace Com.CA.Mas.Foundation
    {
        public partial class MAS
        {
            /// <summary>
            /// Request method for an HTTP POST, PUT, DELETE, GET call to the Gateway.
            /// </summary>
            /// <returns>The async task which include the IMASResponse object</returns>
            /// <param name="request">The request to send</param>
            public static Task<IMASResponse> InvokeAsync(IMASRequest request) {
                var tcs = new TaskCompletionSource<IMASResponse>();
                    Invoke(request, new MASCompletion<IMASResponse>(tcs));

                return tcs.Task;
            }

        /// <summary>
        /// Request to upload multipart form-data.
        /// </summary>
        /// <returns>The async task which include the IMASResponse object</returns>
        /// <param name="request">The request to send</param>
        /// /// <param name="multipart">The request to send</param>
        /// /// <param name="progressListener">The request to send</param>
        public static Task<IMASResponse> PostMultiPartFormAsync(IMASRequest request, MultiPart multipart, IMASProgressListener progressListener)
            {
                var tcs = new TaskCompletionSource<IMASResponse>();
                PostMultiPartForm(request, multipart, progressListener, new MASCompletion<IMASResponse>(tcs));

                return tcs.Task;
            }

        /// <summary>
        /// Starts the lifecycle of the MAS processes with given JSON configuration enrolment URL or null.
        /// This method will overwrite JSON configuration(if they are different) that was stored in keychain when configuration file path or enrolment URL is provided.
        /// When URL is recognized as null, this method will initialize SDK by using last used JSON configuration that is stored,
        ///or load JSON configuration from defined default configuration file name.
        /// Enrolment URL is an URL from gateway containing some of credentials required to establish secure connection.
        /// The gateway must be configured to generate and handle enrolment process with client side SDK.
        /// The enrolment URL can be retrieved in many ways which has to be configured properly along with the gateway in regards of the enrolment process.
        /// MASFoundation SDK does not request, or retrieve the enrolment URL by itself..
        /// </summary>
        /// <returns>The async.</returns>
        /// <param name="context">Context.</param>
        /// <param name="url">The enrollment URL If the enrollment url is null, MAS.Start(Context) will be used to start the
        ///             lilifecycle of the MAS processes.

        public static Task<Java.Lang.Void> StartAsync(Android.Content.Context context, Java.Net.URL url)
            {
                var tcs = new TaskCompletionSource<Java.Lang.Void>();
                Start(context, url, new MASCompletion<Java.Lang.Void>(tcs));

                return tcs.Task;
            }

            /// <summary>
            /// Retrieves a boolean indicating if the gateway is currently reachable or not.
            /// </summary>
            /// <returns>True if the gateway is reaachable else return false.</returns>
            public static Task<Java.Lang.Boolean> GatewayIsReachableAsync()
            {
                var tcs = new TaskCompletionSource<Java.Lang.Boolean>();
                GatewayIsReachable(new MASCompletion<Java.Lang.Boolean>(tcs));

                return tcs.Task;
            }



        }
    }
