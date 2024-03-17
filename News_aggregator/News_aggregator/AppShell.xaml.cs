using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace News_aggregator
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AppShell : Shell
	{
		public AppShell ()
		{
			InitializeComponent ();
        }
	}
}