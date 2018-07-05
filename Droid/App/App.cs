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
using Deal.ViewModel;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Threading;
using GalaSoft.MvvmLight.Views;

namespace Deal.Droid.App
{
    public static class App
    {
        private static ViewModelLocator locator;

        public static ViewModelLocator Locator
        {
            get
            {
                if (locator == null)
                {
            
                    //DispatcherHelper.Initialize();
                    //var nav = new NavigationService();
                    //SimpleIoc.Default.Register<INavigationService>(() => nav);
                    //nav.Configure(ViewModelLocator.DetailPageKey, typeof(DetailDeal));
                    locator = new ViewModelLocator();
                }

                return locator;
            }
        }
    }
}
