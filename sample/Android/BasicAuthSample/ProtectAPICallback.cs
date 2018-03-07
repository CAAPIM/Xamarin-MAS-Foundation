// Copyright (c) 2018 CA. All rights reserved.
// This software is provided under the terms of CA’s Pre-Release Agreement.
// See the LICENSE [https://github.com/CAAPIM/Xamarin-MAS-Foundation/blob/LICENSE.md] file for details. 
// This software is for evaluation purposes only and currently not supported by CA.

using System;
using Android.OS;
using Com.CA.Mas.Foundation;
using Java.Lang;
using Org.Json;

namespace BasicAuthSample
{
    public class ProtectAPICallback : MASCallback
    {
        private MainActivity activity;
        public ProtectAPICallback(MainActivity activity)
        {
            this.activity = activity;
        }

        public override Handler Handler
        {
            //run the callback on main thread
            get
            {
                return new Handler(Looper.MainLooper);
            }
        }

        public override void OnError(Throwable e)
        {
            //Handle error
            activity.Alert("Access API", e.ToString());
            Console.WriteLine(e);
        }

        public override void OnSuccess(Java.Lang.Object result)
        {
            IMASResponse response = (IMASResponse)result;
            JSONObject jsonObject = (JSONObject)response.Body.Content;
            activity.Alert("Result", jsonObject.ToString(4));
        }
    }
}
