using Android.App;
using Android.Content;
using Com.CA.Mas.Foundation;
using Java.Lang;

namespace BasicAuthSample
{
    public class UnlockCallback : MASSessionUnlockCallback
    {
        private MainActivity activity;
        public UnlockCallback(MainActivity activity)
        {
            this.activity = activity;
        }

        public override void OnError(Throwable e)
        {
            //Handle error
            activity.Alert("Session Unlock", "Session Unlocked Failed!");
        }

        public override void OnSuccess(Java.Lang.Object result)
        {
            activity.Alert("Session Unlock", "Session Unlocked!");
        }

        public override void OnUserAuthenticationRequired()
        {
            KeyguardManager keyguardManager = (KeyguardManager)Application.Context.GetSystemService(Context.KeyguardService);
            Intent intent = keyguardManager.CreateConfirmDeviceCredentialIntent("Session Unlock", "Provide PIN or FingerPrint to unlock session.");
            activity.StartActivityForResult(intent, 1);
        }
    }
}
