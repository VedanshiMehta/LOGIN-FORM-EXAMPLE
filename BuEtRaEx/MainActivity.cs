using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using AndroidX.AppCompat.App;
using System;

namespace BuEtRaEx
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        private Button _sbutton;
        private Button _nbutton;
        private Button _dbutton;
        private event EventHandler<int> ItemClick;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            _sbutton = FindViewById<Button>(Resource.Id.button2);
            _nbutton = FindViewById<Button>(Resource.Id.button3);
            _dbutton = FindViewById<Button>(Resource.Id.button1);

            _sbutton.Click += Sbutton;
            _nbutton.Click += Nbutton;
            _dbutton.Click += Dbutton;

            
        }

        private void Dbutton(object sender, EventArgs e)
        {
            Toast.MakeText(this, "Detele CLicked", ToastLength.Short).Show();
        }

        private void Nbutton(object sender, EventArgs e)
        {
            Toast.MakeText(this, "Next Clicked", ToastLength.Short).Show();
        }

        private void Sbutton(object sender, EventArgs e)
        {
            Toast.MakeText(this, "Save Clicked", ToastLength.Short).Show();
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}   