using Android.App;
using Android.Widget;
using Android.OS;
using Com.CA.Mas.Foundation;

namespace BasicAuthSample
{
    [Activity(Label = "BasicAuthSample", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our UI controls from the loaded layout
            Button loginButton = FindViewById<Button>(Resource.Id.login);
            loginButton.Click += (sender, e) =>
            {
                login();
            };

            Button logoutButton = FindViewById<Button>(Resource.Id.logout);
            logoutButton.Click += (sender, e) =>
            {
                logout();
            };

            Button invokeApiButton = FindViewById<Button>(Resource.Id.invokeApi);
            invokeApiButton.Click += (sender, e) =>
            {
                invokeApi();
            };

            // MAS - start
            MAS.Start(Application.Context, true);

            if (MAS.GetState(Application.Context) == MASConstants.MasStateStarted)
                Alert("MAS", "MAS SDK started successfully!!");
            else
                Alert("MAS", "MAS SDK NOT started!!");
        }

        public void login()
        {
            // Check if user is already authenticated
            if (MASUser.CurrentUser != null && MASUser.CurrentUser.IsAuthenticated)
            {
                Alert("MAS", "User already authenticated as " + MASUser.CurrentUser.UserName);
            }

            MASUser.Login("admin", "7layer", null);

        }

        public void logout()
        {
            // Check if user is already authenticated
            if (MASUser.CurrentUser != null && MASUser.CurrentUser.IsAuthenticated)
            {
                MASUser.CurrentUser.Logout(null);

                Alert("MAS", "User logged out.");
            }
            else
            {
                Alert("MAS", "User is not authenticated.");
            }    


        }


        public void invokeApi()
        {
            
        }

        public void Alert(string Title, string Message)
        {
            AlertDialog.Builder dialog = new AlertDialog.Builder(this);  
            AlertDialog alert = dialog.Create();  
            alert.SetTitle(Title);  
            alert.SetMessage(Message);  
            alert.SetButton("OK", (c, ev) =>  
            {  
            // Ok button click 
            });  
            alert.Show(); 
        }





    }
}

