using Deal;
using System;
using Android.Support.V7.Widget;
using Android.Views;
using Deal.Droid.Adapter;
using Deal.Droid;
using Android.Graphics;
using Android.Content.Res;

public class DealAdapter : RecyclerView.Adapter
{
    // Event handler for item clicks:
    public event EventHandler<int> ItemClick;

    // Underlying data set
    public DealCollection mDealCollection;

    // Load the adapter with the data set
    public DealAdapter(DealCollection dealCollection)
    {
        mDealCollection = dealCollection;
    }



    // Fill in the contents of the photo card (invoked by the layout manager):
    public override void
        OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
    {
        DealAdapterViewHolder vh = holder as DealAdapterViewHolder;
        Resources res = Android.App.Application.Context.Resources;
        // Set the ImageView and TextView in this ViewHolder's CardView 
        // from this position in the photo album:
        int id = (int)typeof(Resource.Drawable).GetField(mDealCollection.mDeals[position].ImageUrl).GetValue(null);
        // Converting Drawable Resource to Bitmap
        var myImage = BitmapFactory.DecodeResource(res, id);
        vh.Image.SetImageBitmap(myImage);
        vh.Caption.Text = mDealCollection.mDeals[position].Caption;
    }

    // Return the number of photos available in the photo album:
    public override int ItemCount
    {
        get { return mDealCollection.DealsCount; }
    }

    // Raise an event when the item-click takes place:
    void OnClick(int position)
    {
        ItemClick?.Invoke(this, position);
    }

    public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
    {
        // Inflate the CardView for the photo:
        View itemView = LayoutInflater.From(parent.Context).
                    Inflate(Resource.Layout.DealView, parent, false);

        // Create a ViewHolder to find and hold these view references, and 
        // register OnClick with the view holder:
        DealAdapterViewHolder vh = new DealAdapterViewHolder(itemView, OnClick);
        return vh;
    }



}