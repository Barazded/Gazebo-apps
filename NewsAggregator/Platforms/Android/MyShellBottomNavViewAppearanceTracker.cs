using Google.Android.Material.BottomNavigation;
using Android.Widget;
using Android.Text.Style;
using Android.Graphics;
using Microsoft.Maui.Controls.Platform.Compatibility;
using Microsoft.Maui.Platform;
using Microsoft.Maui.Controls.Compatibility.Platform.Android;

namespace NewsAggregator
{
    public class MyShellBottomNavViewAppearanceTracker : IShellBottomNavViewAppearanceTracker
    {
        public void Dispose() { }

        public void ResetAppearance(BottomNavigationView bottomView) { }


        public void SetAppearance(BottomNavigationView bottomView, IShellAppearanceElement appearance)
        {
            List<int> drawables = new()
            {
                Resource.Drawable.settingsicon,
                Resource.Drawable.communityicon,
                Resource.Drawable.lentaicon,
            };
            StyleSpan boldSpan = new StyleSpan(TypefaceStyle.Bold);
            //
            for (int i = 0; i < 3; i++)
            {
                var element = bottomView.Menu.GetItem(i);
                if (element.IsChecked)
                {
                    element.SetIcon(drawables[i]);
                    Android.Text.SpannableString spanString = new Android.Text.SpannableString(element.ToString());
                    spanString.SetSpan(new ForegroundColorSpan(Android.Graphics.Color.ParseColor("#306AFF")), 0, spanString.Length(), 0);
                    element.Icon.SetColorFilter(Android.Graphics.Color.ParseColor("#306AFF"), PorterDuff.Mode.SrcIn);
                    spanString.SetSpan(boldSpan, 0, spanString.Length(), 0);
                    element.SetTitle(spanString);
                    element.SetIcon(drawables[i]);
                }
                else
                {
                    element.SetIcon(drawables[i]);
                    Android.Text.SpannableString spanString = new Android.Text.SpannableString(element.ToString());
                    spanString.SetSpan(new ForegroundColorSpan(Android.Graphics.Color.ParseColor("#9C9C9C")), 0, spanString.Length(), 0);
                    element.Icon.SetColorFilter(Android.Graphics.Color.ParseColor("#9C9C9C"), PorterDuff.Mode.SrcIn);
                    spanString.SetSpan(boldSpan, 0, spanString.Length(), 0);
                    element.SetTitle(spanString);
                    element.SetIcon(drawables[i]);
                }
            }
            //
            var currentContentPage = (Shell.Current.CurrentPage as ContentPage);
            if (currentContentPage == null)
            {
                return;
            }

            if (currentContentPage.Content != null && currentContentPage.Content.BackgroundColor != Colors.Transparent) //Xamarin.Forms.Color.Transparent)
            {
                try
                {
                    (bottomView.Parent as LinearLayout)?.SetBackgroundColor(currentContentPage.Content.BackgroundColor.ToAndroid());
                }
                catch 
                { 
                   
                }
            }
            else
            {
                (bottomView.Parent as LinearLayout)?.SetBackgroundColor(currentContentPage.BackgroundColor.ToAndroid());
                //(bottomView.Parent as LinearLayout)?.SetBackgroundColor(currentContentPage.BackgroundColor.ToPlatform());
            }
            bottomView.SetBackgroundResource(Resource.Drawable.bottombackground);
            bottomView.SetPadding(20, 20, 20, 0);
        }
    }
}