using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Support.V7.Widget;
namespace Deal.Droid.Adapter
{

    public class DealAdapterViewHolder : RecyclerView.ViewHolder
    {
        public ImageView Image { get; private set; }
        public TextView Caption { get; private set; }

        // Get references to the views defined in the CardView layout.
        public DealAdapterViewHolder(View itemView, Action<int,ImageView> listener)
            : base(itemView)
        {
            // Locate and cache view references:
            Image = itemView.FindViewById<ImageView>(Resource.Id.imageView);
            Caption = itemView.FindViewById<TextView>(Resource.Id.textView);
            // Detect user clicks on the item view and report which item
            // was clicked (by layout position) to the listener:
            itemView.Click += (sender, e) => listener(base.LayoutPosition,Image);
        }
    }
}