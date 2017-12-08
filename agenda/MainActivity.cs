using Android.App;
using Android.Widget;
using Android.Views;
using Android.OS;
using Android.Support.V7.App;

namespace Agenda
{
    [Activity(Label = "agenda", MainLauncher = true,
        Theme = "@style/Theme.AppCompat.Light.NoActionBar")]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            var email = FindViewById<TextView>(Resource.Id.email);
            var pass = FindViewById<TextView>(Resource.Id.password);
            var btnlogin = FindViewById<Button>(Resource.Id.btn_login);

            btnlogin += delegate
            {
                Toast.MakeText(this, string.Format("email:{0} Password:{1}", email.Text, pass.Text), ToastLength.Short).Show();
            }

        }
    }
}

