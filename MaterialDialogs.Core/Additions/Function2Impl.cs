using Android.Runtime;
using Kotlin.Jvm.Functions;
using System;

namespace MaterialDialogs.Utils
{
     public class Function2Impl<T, K> : Java.Lang.Object, IFunction2 where T : class, IJavaObject where K : class, IJavaObject
        {
            private readonly Action<T, K> OnInvoked;

            public Function2Impl(Action<T, K> onInvoked)
            {
                this.OnInvoked = onInvoked;
            }

            public Java.Lang.Object Invoke(Java.Lang.Object p0, Java.Lang.Object p1)
            {
                OnInvoked?.Invoke(p0.JavaCast<T>(), p1.JavaCast<K>());
                return null;
            }
        }
}
