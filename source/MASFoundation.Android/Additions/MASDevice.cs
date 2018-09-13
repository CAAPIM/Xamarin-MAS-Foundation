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

        /// <summary>
        /// Create or update a new attribute for the current device,
        /// throw MASDeviceAttributeOverflowException when exceed maximum attribute allowed.
        /// </summary>
        /// <param name="attr">Key of the attribute to be associated with the device.</param>
        /// <param name="value">Value of the attribute to be associated with the device.</param>
        /// <returns>The async task</returns>
        public Task<Java.Lang.Void> AddAttributeAsync(string name, string value)
        {
            var tcs = new TaskCompletionSource<Java.Lang.Void>();
            AddAttribute(name, value, new MASCompletion<Java.Lang.Void>(tcs));

            return tcs.Task;
        }

        /// <summary>
        /// Get attribute by name, return empty JSONObject if no attribute is found.
        /// </summary>
        /// <param name="attr">Key of the attribute to be retrieved with the device.</param>
        /// <returns>The async task</returns>
        public Task<Org.Json.JSONObject> GetAttributeAsync(string name)
        {
            var tcs = new TaskCompletionSource<Org.Json.JSONObject> ();
            GetAttribute(name, new MASCompletion<Org.Json.JSONObject> (tcs));

            return tcs.Task;
        }

        /// <summary>
        /// Get all attributes, return empty JSONArray if no attributes found.
        /// </summary>
        /// <returns>The async task</returns>
        public Task<Org.Json.JSONArray> GetAttributesAsync()
        {
            var tcs = new TaskCompletionSource<Org.Json.JSONArray>();
            GetAttributes(new MASCompletion<Org.Json.JSONArray>(tcs));

            return tcs.Task;
        }

        /// <summary>
        /// Remove attribute by name, succeed even device attribute does not exists
        /// </summary>
        /// <param name="attr">Key of the attribute to be removed for the current device</param>
        /// <returns>The async task</returns>
        public Task<Java.Lang.Void> RemoveAttributeAsync(string name)
        {
            var tcs = new TaskCompletionSource<Java.Lang.Void>();
            RemoveAttribute(name, new MASCompletion<Java.Lang.Void>(tcs));

            return tcs.Task;
        }

        /// <summary>
        /// Remove all attributes for the current device
        /// </summary>
        /// <returns>The async task</returns>
        public Task<Java.Lang.Void> RemoveAllAttributesAsync()
        {
            var tcs = new TaskCompletionSource<Java.Lang.Void>();
            RemoveAllAttributes(new MASCompletion<Java.Lang.Void>(tcs));

            return tcs.Task;
        }
    }
}
