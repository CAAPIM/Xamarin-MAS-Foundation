using System;
using System.Threading.Tasks;

namespace Com.CA.Mas.Foundation
{
    public partial class MASUser
    {
        /// <summary>
        /// Performs an implicit login by calling an endpoint that requires authentication. This results
        /// in MASUser.CurrentUser being populated from the endpoint.
        /// </summary>
        /// <returns>MASUser Object</returns>
        public static Task<MASUser> LoginAsync()
        {
            var tcs = new TaskCompletionSource<MASUser>();
            Login(new MASCompletion<MASUser>(tcs));

            return tcs.Task;
        }

        /// <summary>
        /// Authenticates a user with a IMASAuthCredentials object.
        /// </summary>
        /// <returns>MASUser Object</returns>
        /// <param name="credentials">Credentials.</param>
        public static Task<MASUser> LoginAsync(IMASAuthCredentials credentials) {
            var tcs = new TaskCompletionSource<MASUser>();
            Login(credentials, new MASCompletion<MASUser>(tcs));

            return tcs.Task;
        }

        /// <summary>
        /// Authenticates a user with a username and password.
        /// </summary>
        /// <returns>MASUser Object</returns>
        /// <param name="username">Username.</param>
        /// <param name="password">Password.</param>
        public static Task<MASUser> LoginAsync(string username, char[] password)
        {
            var tcs = new TaskCompletionSource<MASUser>();
            Login(username, password, new MASCompletion<MASUser>(tcs));

            return tcs.Task;
        }

        /// <summary>
        /// Logs off an already authenticated user via an asynchronous request.
        /// </summary>
        public Task<Java.Lang.Void> LogoutAsync()
        {
            var tcs = new TaskCompletionSource<Java.Lang.Void>();
            Logout(new MASCompletion<Java.Lang.Void>(tcs));

            return tcs.Task;
        }

        /// <summary>
        /// Requesting userInfo for the MASUser object
        /// </summary>
        public Task<Java.Lang.Void> RequestUserInfoAsync()
        {
            var tcs = new TaskCompletionSource<Java.Lang.Void>();
            RequestUserInfo(new MASCompletion<Java.Lang.Void>(tcs));

            return tcs.Task;
        }

        /// <summary>
        /// Locks the current device.
       /// This will remove the access and refresh tokens, as well as the user profile.
        /// The ID token will then be moved to the fingerprint protected shared KeyStore.
        /// </summary>
        public Task<Java.Lang.Void> LockSessionAsync()
        {
            var tcs = new TaskCompletionSource<Java.Lang.Void>();
            LockSession(new MASCompletion<Java.Lang.Void>(tcs));

            return tcs.Task;
        }

        /// <summary>
        /// Triggers the Android unlock and captures the unlock result.
        /// Unlocks the ID_TOKEN from the KeyStore and places it back into the keychain,
        /// removes the locked ID_TOKEN, and then indicates if the device is unlocked.
        /// </summary>
        public Task<Java.Lang.Void> UnlockSessionAsync()
        {
            var tcs = new TaskCompletionSource<Java.Lang.Void>();
            UnlockSession(new MASSessionUnlockCompletion<Java.Lang.Void>(tcs));

            return tcs.Task;
        }
        /// <summary>
        /// Removes the secured ID token.
        /// </summary>
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
