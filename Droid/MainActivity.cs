using Android.App;
using Android.Widget;
using Android.OS;

namespace Deal.Droid
{
    [Activity(Label = "Deal", MainLauncher = true, Icon = "@mipmap/icon",Theme = "@android:style/Theme.Material.Light.DarkActionBar")]
    public class MainActivity : Activity
    {
     

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

         
        }
    }
}

