using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace AndroidMagicController
{
    [Activity(Label = "AndroidMagicController", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        int count = 1;



        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            TextView hueValue = FindViewById<TextView>(Resource.Id.hueValue);
            SeekBar hueSeekBar = FindViewById<SeekBar>(Resource.Id.hueSeekBar);

            // Get our button from the layout resource,
            // and attach an event to it
            Button button = FindViewById<Button>(Resource.Id.MyButton);

            button.Click += delegate { button.Text = string.Format("{0} clicks!", count++); };

            hueSeekBar.ProgressChanged += (object sender, SeekBar.ProgressChangedEventArgs e) =>
            {
                if (e.FromUser)
                {
                    hueValue.Text = string.Format("The value of the SeekBar is {0}", e.Progress);
                }
            };

        }
    }

}

