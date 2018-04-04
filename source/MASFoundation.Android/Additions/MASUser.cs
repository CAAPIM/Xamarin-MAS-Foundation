using System;
using System.Threading.Tasks;

namespace Com.CA.Mas.Foundation
{
    public partial class MASUser
    {

        public static Task<MASUser> LoginAsync()
        {
            var tcs = new TaskCompletionSource<MASUser>();
            Login(new MASCompletion<MASUser>(tcs));

            return tcs.Task;
        }

        public static Task<MASUser> LoginAsync(IMASAuthCredentials credentials) {
            var tcs = new TaskCompletionSource<MASUser>();
            Login(credentials, new MASCompletion<MASUser>(tcs));

            return tcs.Task;
        }

        public static Task<MASUser> LoginAsync(string username, char[] password)
        {
            var tcs = new TaskCompletionSource<MASUser>();
            Login(username, password, new MASCompletion<MASUser>(tcs));

            return tcs.Task;
        }

        public Task<Java.Lang.Void> LogoutAsync()
        {
            var tcs = new TaskCompletionSource<Java.Lang.Void>();
            Logout(new MASCompletion<Java.Lang.Void>(tcs));

            return tcs.Task;
        }

        public Task<Java.Lang.Void> RequestUserInfoAsync()
        {
            var tcs = new TaskCompletionSource<Java.Lang.Void>();
            RequestUserInfo(new MASCompletion<Java.Lang.Void>(tcs));

            return tcs.Task;
        }

        public Task<Java.Lang.Void> LockSessionAsync()
        {
            var tcs = new TaskCompletionSource<Java.Lang.Void>();
            LockSession(new MASCompletion<Java.Lang.Void>(tcs));

            return tcs.Task;
        }

        public Task<Java.Lang.Void> UnlockSessionAsync()
        {
            var tcs = new TaskCompletionSource<Java.Lang.Void>();
            UnlockSession(new MASSessionUnlockCompletion<Java.Lang.Void>(tcs));

            return tcs.Task;
        }

        public Task<Java.Lang.Void> RemoveSessionLockAsync()
        {
            var tcs = new TaskCompletionSource<Java.Lang.Void>();
            RemoveSessionLock(new MASSessionUnlockCompletion<Java.Lang.Void>(tcs));

            return tcs.Task;
        }

        private class MASSessionUnlockCompletion<T> : MASSessionUnlockCallback where T : class
        {
            private readonly TaskCompletionSource<T> _tcs;

            public MASSessionUnlockCompletion(TaskCompletionSource<T> tcs)
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

            public override void OnUserAuthenticationRequired() 
            {
                _tcs.SetException(new UserAuthenticationRequiredException());
            }
        }

        public class UserAuthenticationRequiredException : Exception {
            
        }

    }
}
