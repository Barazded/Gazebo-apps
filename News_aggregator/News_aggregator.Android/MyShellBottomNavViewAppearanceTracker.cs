using Google.Android.Material.BottomNavigation;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;

namespace News_aggregator.Droid
{
    public class MyShellBottomNavViewAppearanceTracker : IShellBottomNavViewAppearanceTracker
    {
        public void Dispose() { }

        public void ResetAppearance(BottomNavigationView bottomView) { }

        public void SetAppearance(BottomNavigationView bottomView, IShellAppearanceElement appearance)
        {
            //bottomView.SetBackgroundResource(Resource.Drawable.bottombackground);
        }
    }
}