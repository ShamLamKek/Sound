using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android.Media;
using System;

namespace Sound
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        MediaPlayer player;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.activity_main);
           
               
                player = MediaPlayer.Create(this, Resource.Raw.audio);
               
                Button button = FindViewById<Button>(Resource.Id.button1);
                button.Click += (sender, e) =>
                {
                    player.Start();
                };
                Button button2 = FindViewById<Button>(Resource.Id.button2);
                button2.Click += (sender, e) =>
                {
                    player.Pause();
                };
                Button button3 = FindViewById<Button>(Resource.Id.button3);
                button3.Click += (sender, e) =>
                {
                    player.Stop();
                };
             

        }


     }
 }

