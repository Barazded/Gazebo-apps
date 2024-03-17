using Android.OS;
using Android.Views;
using Android.Widget;
using AndroidX.Fragment.App;
using Google.Android.Material.BottomNavigation;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

namespace News_aggregator.Droid
{
    internal class CreateShellItemRenderer : IShellItemRenderer
    {

        public Fragment Fragment => throw new NotImplementedException();

        public ShellItem ShellItem { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public event EventHandler Destroyed;

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}