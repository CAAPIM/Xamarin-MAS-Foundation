using System;
using System.Threading.Tasks;

namespace Com.CA.Mas.Foundation
{
    public class MASCompletion<T> : MASCallback where T : class
    {
        private readonly TaskCompletionSource<T> _tcs;

        public MASCompletion(TaskCompletionSource<T> tcs)
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
