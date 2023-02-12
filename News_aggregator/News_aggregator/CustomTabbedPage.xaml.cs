using News_aggregator.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace News_aggregator
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CustomTabbedPage : TabbedPage
    {
        public CustomTabbedPage ()
        {
            InitializeComponent();
        }
    }
}