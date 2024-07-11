using Android.App;
using Android.Content.PM;
using Android.OS;
using Firebase;
using NewsAggregator.Interfaces;
//using NewsAggregator.Platforms.Android.Services;
using NewsAggregator.Services;

namespace NewsAggregator
{
    [Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true, LaunchMode = LaunchMode.SingleTop, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
    public class MainActivity : MauiAppCompatActivity
    {
        protected override void OnCreate(Bundle? savedInstanceState)
        {
            DependencyService.Register<IFirebaseAuthentication, FirebaseAuthentication>();
            base.OnCreate(savedInstanceState);
            FirebaseApp.InitializeApp(this);
            Window?.SetStatusBarColor(color: Android.Graphics.Color.Black);
        }
    }
}
