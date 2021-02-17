using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Kotlin.Jvm.Functions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Utils
{
    public class Function1Impl<T> : Java.Lang.Object, IFunction1 where T : class, IJavaObject
    {
        private readonly Action<T> OnInvoked;

        public Function1Impl(Action<T> onInvoked)
        {
            this.OnInvoked = onInvoked;
        }

        public Java.Lang.Object Invoke(Java.Lang.Object p0)
        {
            OnInvoked?.Invoke(p0.JavaCast<T>());
            return null;
        }
    }
}