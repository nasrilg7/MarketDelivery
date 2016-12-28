using Android.App;
using Android.Widget;
using Android.OS;

namespace MarketDelivery
{
    [Activity(Label = "MarketDelivery", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            //Test1
            // Set our view from the "main" layout resource
            // SetContentView (Resource.Layout.Main);
        }
    }
}

