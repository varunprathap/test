
using Android.Animation;
using Android.App;
using Android.Content;
using Android.Content.Res;
using Android.Graphics;
using Android.OS;
using Android.Transitions;
using Android.Views;
using Android.Views.Animations;
using Android.Widget;
using CommonServiceLocator;
using Deal.Droid.Adapter;
using GalaSoft.MvvmLight.Views;
using Java.Interop;
using static Android.Resource;

namespace Deal.Droid
{
    [Activity(Label = "DetailDeal")]
    public class DetailDeal : ActivityBase
    {
       

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.DealDetail);
            var param = Nav.GetAndRemoveParameter<DetailItem>(Intent);
            Resources res = Android.App.Application.Context.Resources;
            int id = (int)typeof(Resource.Drawable).GetField(param.mDeal.ImageUrl).GetValue(null);
            ImageView imageView = (ImageView)FindViewById(Resource.Id.photo);
            imageView.TransitionName = Intent.GetStringExtra(MainActivity.EXTRA_DEAL);
            var myImage = BitmapFactory.DecodeResource(res, id);
            imageView.SetImageBitmap(myImage);
            Window.EnterTransition.AddListener(new DetailsTransitionAdapter(this));
        }

        public NavigationService Nav
        {
            get
            {
                return (NavigationService)ServiceLocator.Current
                    .GetInstance<INavigationService>();
            }
        }

       

        [Export("ShowStar")]
        public void ShowStar(View view)
        {
            ToggleInformationView(view);
        }

        public void ToggleInformationView(View view)
        {
          
        }
        public class DetailsTransitionAdapter : TransitionAdapter
        {
            public DetailDeal da;

            public DetailsTransitionAdapter(DetailDeal details)
            {
                da = details;
            }

            public override void OnTransitionEnd(Android.Transitions.Transition transition)
            {
                var hero = da.FindViewById<ImageView>(Resource.Id.photo);
                ObjectAnimator color = ObjectAnimator.OfArgb(hero.Drawable, "tint",
                                           da.Resources.GetColor(Resource.Color.photo_tint), 0);
                color.Start();

                //da.FindViewById(Resource.Id.info).Animate().Alpha(1.0f);
                da.FindViewById(Resource.Id.star).Animate().Alpha(1.0f);
                da.Window.EnterTransition.RemoveListener(this);
            }


        }




    }


  
}