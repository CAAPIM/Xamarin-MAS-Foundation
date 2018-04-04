using System;
using System.Threading.Tasks;

namespace Com.CA.Mas.Foundation
{
    public partial class MAS
    {
        
        public static Task<IMASResponse> Invoke(IMASRequest request) {
            var tcs = new TaskCompletionSource<IMASResponse>();
            Invoke(request, new MASInvokeCompletion<IMASResponse>(tcs));

            return tcs.Task;
        }


        private class MASInvokeCompletion<T> : MASCallback where T: class
        {
            private readonly TaskCompletionSource<T> _tcs;

            public MASInvokeCompletion(TaskCompletionSource<T> tcs)
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
