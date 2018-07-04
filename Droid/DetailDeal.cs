
using Android.App;
using Android.Content;
using Android.Content.Res;
using Android.Graphics;
using Android.OS;
using Android.Widget;

namespace Deal.Droid
{
    [Activity(Label = "DetailDeal")]
    public class DetailDeal : Activity
    {
       

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.DealDetail);
            var local = Intent.GetStringExtra(MainActivity.EXTRA_DEAL);
            Resources res = Android.App.Application.Context.Resources;
            int id = (int)typeof(Resource.Drawable).GetField(local).GetValue(null);
            ImageView imageView = (ImageView)FindViewById(Resource.Id.photo);
            imageView.TransitionName = Intent.GetStringExtra(MainActivity.EXTRA_DEAL);
            var myImage = BitmapFactory.DecodeResource(res, id);
            imageView.SetImageBitmap(myImage);
        }
    }
}