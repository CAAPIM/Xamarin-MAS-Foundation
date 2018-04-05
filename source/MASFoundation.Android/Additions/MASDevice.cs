using System;
using System.Threading.Tasks;

namespace Com.CA.Mas.Foundation
{
    public partial class MASDevice
    {
        /// <summary>
        ///Deregisters the application resources on this device. This is a two step operation.</p>
        ///It will attempt to remove the device's registered record in the cloud, and wipe the device
        ///of all credential settings. If it fails, an error is returned.

        ///A call to deregister during the same session that the device was initially registered will
        ///fail and may leave the device in a strange state.  This call should work after the
        ///initial registration and a restart of the application.

        ///A successful call to deregistration will leave the current application session
        ///without required credentials and settings. You must restart the application
        ///to re-register the application and retrieve new credentials.
      
        ///This should be considered an advanced feature. If you make this available to end users, it
        ///should not be made too easily accessible and the UI control should be marked and possibly labeled
        ///to accentuate that it will wipe settings both in the cloud and locally on the device. We
        ///recommend that you also provide an additional user confirmation UI component to make it clear to
        ///the user what will occur and allow them to cancel the operation or proceed.
        /// </summary>
        /// <returns>The async task</returns>
        public Task<Java.Lang.Void> DeregisterAsync() {
            var tcs = new TaskCompletionSource<Java.Lang.Void>();
            Deregister(new MASCompletion<Java.Lang.Void>(tcs));

            return tcs.Task;
        }
    }
}
