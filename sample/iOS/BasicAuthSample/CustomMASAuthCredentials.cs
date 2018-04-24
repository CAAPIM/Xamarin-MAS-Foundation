using System;
using MASFoundation;

namespace BasicAuthSample
{
    public class CustomMASAuthCredentials : MASAuthCredentials
    {
        string UserName;
        string Password;
        string CustomValue;

        public static CustomMASAuthCredentials InitWithUserName(string UserName, string Password, string CustomValue)
        {
            CustomMASAuthCredentials custom = new CustomMASAuthCredentials("password", UserName, true, true);

            if(custom != null)
            {
                custom.UserName = UserName;
                custom.Password = Password;
                custom.CustomValue = CustomValue;
            }   

            return custom;

        }

        public CustomMASAuthCredentials(string credentialsType, string csrUsername, bool canRegisterDevice, bool isReusable) : base(credentialsType, csrUsername, canRegisterDevice, isReusable)
        {
            // Initialize base constructor
        }

    }
}
