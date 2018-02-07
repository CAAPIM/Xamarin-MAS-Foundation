using System;
using System.Threading.Tasks;

namespace Com.CA.Mas.Foundation
{
    public partial class MAS
    {
        
        public static Task<IMASResponse> Invoke(IMASRequest request) {
            var tcs = new TaskCompletionSource<IMASResponse>();
            Invoke(request, new MASInvokeCompletion(tcs));
            return tcs.Task;
            
        }

        private class MASInvokeCompletion : MASCallback
        {
            private readonly TaskCompletionSource<IMASResponse> _tcs;

            public MASInvokeCompletion(TaskCompletionSource<IMASResponse> tcs)
            {
                _tcs = tcs;
            }

            public override void OnSuccess(Java.Lang.Object response)
            {
                _tcs.SetResult((IMASResponse)response);
            }

            public override void OnError(Java.Lang.Throwable t)
            {
                _tcs.SetException(t);
            }
        }
    }
}
