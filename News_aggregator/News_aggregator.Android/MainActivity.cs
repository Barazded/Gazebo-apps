﻿using System;
using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.OS;
using Firebase;
using News_aggregator.Interfaces;
using Xamarin.Forms;

namespace News_aggregator.Droid
{
    [Activity(Label = "News_aggregator", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize )]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            FirebaseApp.InitializeApp(Android.App.Application.Context);
            DependencyService.Register<IFirebaseAuthentication, FirebaseAuthentication>();
            base.OnCreate(savedInstanceState);

            Window.SetStatusBarColor(color: Android.Graphics.Color.Black);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            LoadApplication(new App());
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);
            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}