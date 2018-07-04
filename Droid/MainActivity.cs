using Android.App;
using Android.Content;
using Android.OS;
using Android.Support.V7.App;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;
using com.refractored.fab;

namespace Deal.Droid
{
    [Activity(Label = "Deal", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity, IDealItemClickListener
    {

        public static string EXTRA_DEAL = "deal";
        public static string EXTRA_IMAGE_NAME = "image_name";

       // RecyclerView instance that displays the deal
       RecyclerView mRecyclerView;

        // Layout manager that lays out each card in the RecyclerView:
        RecyclerView.LayoutManager mLayoutManager;

        // Adapter that accesses the data set (a photo album):
        DealAdapter mAdapter;

        // Photo album that is managed by the adapter:
        DealCollection mDeals;

     

        public void OnDealItemClick(int pos, Deal deal, ImageView imageView)
        {
            Intent intent = new Intent(this, typeof(DetailDeal));
            intent.PutExtra(EXTRA_DEAL, deal.ImageUrl);
            intent.PutExtra(EXTRA_IMAGE_NAME, imageView.TransitionName);
            ActivityOptions options = ActivityOptions.MakeSceneTransitionAnimation(this, imageView, imageView.TransitionName);
            StartActivity(intent, options.ToBundle());
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            
            // Instantiate
            mDeals = new DealCollection();
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our RecyclerView layout:
            mRecyclerView = FindViewById<RecyclerView>(Resource.Id.recyclerView);


      



            // Use the built-in linear layout manager:
            mLayoutManager = new LinearLayoutManager(this);
            // Plug the layout manager into the RecyclerView:
            mRecyclerView.SetLayoutManager(mLayoutManager);

            //............................................................
            // Adapter Setup:

            // Create an adapter for the RecyclerView, and pass it the
            // data set (the photo album) to manage:
            mAdapter = new DealAdapter(mDeals,this);

          
            // Plug the adapter into the RecyclerView:
            mRecyclerView.SetAdapter(mAdapter);

           


        }


        void OnItemClick(object sender, int position)
        {
            // Display a toast that briefly shows the enumeration of the selected photo:
            int photoNum = position + 1;
            //Toast.MakeText(this, "This is photo number " + photoNum, ToastLength.Short).Show();


        }
         
    }


}

