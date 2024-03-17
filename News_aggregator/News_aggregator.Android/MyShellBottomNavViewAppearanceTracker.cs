using Google.Android.Material.BottomNavigation;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;
using Android.Widget;
using Android.Text.Style;
using System.Collections.Generic;
using Android.Graphics;

namespace News_aggregator.Droid
{
    public class MyShellBottomNavViewAppearanceTracker : IShellBottomNavViewAppearanceTracker
    {
        public void Dispose() { }

        public void ResetAppearance(BottomNavigationView bottomView) { }

        [System.Obsolete]
        public void SetAppearance(BottomNavigationView bottomView, IShellAppearanceElement appearance)
        {
            List<int> drawables = new List<int>()
            {
                Resource.Drawable.settings_icon,
                Resource.Drawable.community_icon,
                Resource.Drawable.lenta_icon,
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

            if (currentContentPage.Content != null && currentContentPage.Content.BackgroundColor != Xamarin.Forms.Color.Transparent)
            {
                (bottomView.Parent as LinearLayout)?.SetBackgroundColor(currentContentPage.Content.BackgroundColor.ToAndroid());
            }
            else
            {
                (bottomView.Parent as LinearLayout)?.SetBackgroundColor(currentContentPage.BackgroundColor.ToAndroid());
            }
            bottomView.SetBackgroundResource(Resource.Drawable.bottombackground);
            bottomView.SetPadding(20, 20, 20, 0);
        }
    }
}