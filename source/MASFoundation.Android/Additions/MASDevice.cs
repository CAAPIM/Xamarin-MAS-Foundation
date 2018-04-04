using System;
using System.Threading.Tasks;

namespace Com.CA.Mas.Foundation
{
    public partial class MASDevice
    {
        
        public Task<Java.Lang.Void> DeregisterAsync() {
            var tcs = new TaskCompletionSource<Java.Lang.Void>();
            Deregister(new MASCompletion<Java.Lang.Void>(tcs));

            return tcs.Task;
        }
    }
}
