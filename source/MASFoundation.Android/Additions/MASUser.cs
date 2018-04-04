using System;
using System.Threading.Tasks;

namespace Com.CA.Mas.Foundation
{
    public partial class MASUser
    {
        public static Task<IMASResponse> Login()
        {
            var tcs = new TaskCompletionSource<IMASResponse>();
            Login(new MASUserCompletion<IMASResponse>(tcs));

            return tcs.Task;
        }

        public static Task<IMASResponse> Login(IMASAuthCredentials credentials) {
            var tcs = new TaskCompletionSource<IMASResponse>();
            Login(credentials, new MASUserCompletion<IMASResponse>(tcs));

            return tcs.Task;
        }

        public static Task<IMASResponse> Login(string username, char[] password)
        {
            var tcs = new TaskCompletionSource<IMASResponse>();
            Login(username, password, new MASUserCompletion<IMASResponse>(tcs));

            return tcs.Task;
        }

        private class MASUserCompletion<T> : MASCallback where T: class
        {
            private readonly TaskCompletionSource<T> _tcs;

            public MASUserCompletion(TaskCompletionSource<T> tcs)
            {
                _tcs = tcs;
            }

            public override void OnSuccess(Java.Lang.Object response)
            {
                _tcs.SetResult(response as T);
            }

            public override void OnError(Java.Lang.Throwable t)
            {
                _tcs.SetException(t);
            }
        }
    }
}
