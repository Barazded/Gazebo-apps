using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;
using News_aggregator.Droid;
using Android.Content;
using News_aggregator;

[assembly: ExportRenderer(typeof(Shell), typeof(MyShellRenderer))]
namespace News_aggregator.Droid
{
    class MyShellRenderer : ShellRenderer
    {
        public MyShellRenderer(Context context) : base(context)
        {
        }

        protected override IShellBottomNavViewAppearanceTracker CreateBottomNavViewAppearanceTracker(ShellItem shellItem)
        {
            return new MyShellBottomNavViewAppearanceTracker();
        }
    }
}