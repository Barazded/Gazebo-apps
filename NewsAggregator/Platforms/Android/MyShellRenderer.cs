using Android.Content;
using Microsoft.Maui.Controls.Handlers.Compatibility;
using Microsoft.Maui.Controls.Platform.Compatibility;
using NewsAggregator;

//[assembly: ExportRenderer(typeof(Shell), typeof(MyShellRenderer))]
namespace NewsAggregator
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