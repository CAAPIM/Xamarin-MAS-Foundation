using System;
using System.Threading.Tasks;

namespace Com.CA.Mas.Foundation
{
    public partial class MAS
    {
        public static Task<IMASResponse> InvokeAsync(IMASRequest request) {
            var tcs = new TaskCompletionSource<IMASResponse>();
            Invoke(request, new MASCompletion<IMASResponse>(tcs));

            return tcs.Task;
        }

        public static Task<Java.Lang.Void> StartAsync(Android.Content.Context context, Java.Net.URL url)
        {
            var tcs = new TaskCompletionSource<Java.Lang.Void>();
            Start(context, url, new MASCompletion<Java.Lang.Void>(tcs));

            return tcs.Task;
        }

        public static Task<Java.Lang.Boolean> GatewayIsReachableAsync()
        {
            var tcs = new TaskCompletionSource<Java.Lang.Boolean>();
            GatewayIsReachable(new MASCompletion<Java.Lang.Boolean>(tcs));

            return tcs.Task;
        }



    }
}
