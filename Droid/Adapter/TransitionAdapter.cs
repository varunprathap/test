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
using Android.Transitions;

namespace Deal.Droid.Adapter
{
    public class TransitionAdapter : Java.Lang.Object, Transition.ITransitionListener
    {
        public virtual void OnTransitionStart(Transition transition)
        {
        }

        public virtual void OnTransitionEnd(Transition transition)
        {
        }

        public virtual void OnTransitionCancel(Transition transition)
        {
        }

        public virtual void OnTransitionPause(Transition transition)
        {
        }

        public virtual void OnTransitionResume(Transition transition)
        {
        }
    }
}