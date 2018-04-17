using System;
using System.Runtime.InteropServices;
using Foundation;
using ObjCRuntime;

namespace MASFoundation
{
    partial class Constants
    {
        // extern const unsigned char [] MASFoundationVersionString;
        public static NSString MASFoundationVersionString
        {
            get
            {
                IntPtr RTLD_MAIN_ONLY = Dlfcn.dlopen(null, 0);
                IntPtr ptr = Dlfcn.dlsym(RTLD_MAIN_ONLY, "MASFoundationVersionString");
                Dlfcn.dlclose (RTLD_MAIN_ONLY);
                var versionNumberString = Marshal.PtrToStringAuto(ptr);
                return (NSString)versionNumberString;
            }
        }

    }
}
