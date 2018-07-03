using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Support.V7.Widget;
using com.refractored.fab;

namespace Deal.Droid
{
    [Activity(Label = "Deal", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : AppCompatActivity
    {
        // RecyclerView instance that displays the deal
        RecyclerView mRecyclerView;

        // Layout manager that lays out each card in the RecyclerView:
        RecyclerView.LayoutManager mLayoutManager;

        // Adapter that accesses the data set (a photo album):
        DealAdapter mAdapter;

        // Photo album that is managed by the adapter:
        DealCollection mDeals;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            
            // Instantiate
            mDeals = new DealCollection();
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our RecyclerView layout:
            mRecyclerView = FindViewById<RecyclerView>(Resource.Id.recyclerView);


            var fab = FindViewById<FloatingActionButton>(Resource.Id.fab);
            fab.AttachToRecyclerView(mRecyclerView);



            // Use the built-in linear layout manager:
            mLayoutManager = new LinearLayoutManager(this);
            // Plug the layout manager into the RecyclerView:
            mRecyclerView.SetLayoutManager(mLayoutManager);

            //............................................................
            // Adapter Setup:

            // Create an adapter for the RecyclerView, and pass it the
            // data set (the photo album) to manage:
            mAdapter = new DealAdapter(mDeals);

          
            // Plug the adapter into the RecyclerView:
            mRecyclerView.SetAdapter(mAdapter);

        }

    }


}

