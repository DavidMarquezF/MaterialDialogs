using AFollestad.MaterialDialogs;
using Android.Runtime;
using Android.Text;
using Java.Lang;
using Kotlin.Jvm.Functions;
using MaterialDialogs.Utils;
using System;

namespace AFollestad.MaterialDialogs.Input
{
    public static class DialogInputExt
    {
        /*
        static IntPtr class_ref = JNIEnv.FindClass("com/afollestad/materialdialogs/input/DialogInputExt");

        static IntPtr id_input;

        public static unsafe MaterialDialog Input(this MaterialDialog dialog)
        {
            try
            {
                if (id_input == IntPtr.Zero)
                    id_input = JNIEnv.GetStaticMethodID(class_ref,
                           "input", "(Lcom/afollestad/materialdialogs/MaterialDialog;Ljava/lang/String;Ljava/lang/Integer;Ljava/lang/CharSequence;Ljava/lang/Integer;ILjava/lang/Integer;ZZLkotlin/jvm/functions/Function2;)Lcom/afollestad/materialdialogs/MaterialDialog;");

                JValue[] __args = new JValue[] {
                    new JValue(JNIEnv.ToJniHandle(dialog))
                };

                return Java.Lang.Object.GetObject<Java.Lang.Runtime>(
           JNIEnv.CallStaticObjectMethod(class_ref, id_input, __args),
           JniHandleOwnership.TransferLocalRef).JavaCast<MaterialDialog>();
            }
            finally
            {
            }
        }*/

        const string DEFAULT_HINT = null;
        const Java.Lang.Integer DEFAULT_HINT_RES = null;
        const ICharSequence DEFAULT_PREFILL = null;
        const Java.Lang.Integer DEFAULT_PREFILL_RES = null;
        const InputTypes DEFAULT_INPUT_TYPE = InputTypes.ClassText;
        const Java.Lang.Integer DEFAULT_MAX_LENGTH = null;
        const bool DEFAULT_WAIT_FOR_POSITIVE_BUTTON = true;
        const bool DEFAULT_ALLOW_EMPTY = false;
        const IFunction2 DEFAULT_INPUT_CALLBACK = null;

        public static MaterialDialog Input(this MaterialDialog dialog, Action<MaterialDialog, ICharSequence> callback)
        {
            return DialogInputExtKt.Input(dialog, DEFAULT_HINT, DEFAULT_HINT_RES, DEFAULT_PREFILL, DEFAULT_PREFILL_RES, (int)DEFAULT_INPUT_TYPE, DEFAULT_MAX_LENGTH, DEFAULT_WAIT_FOR_POSITIVE_BUTTON, DEFAULT_ALLOW_EMPTY, new Function2Impl<MaterialDialog, ICharSequence>(callback));
        }

        public static MaterialDialog Input(this MaterialDialog dialog, string value, Action<MaterialDialog, ICharSequence> callback)
        {
            return DialogInputExtKt.Input(dialog, DEFAULT_HINT, DEFAULT_HINT_RES, value, DEFAULT_PREFILL_RES, (int)DEFAULT_INPUT_TYPE, DEFAULT_MAX_LENGTH, DEFAULT_WAIT_FOR_POSITIVE_BUTTON, DEFAULT_ALLOW_EMPTY, new Function2Impl<MaterialDialog, ICharSequence>(callback));
        }

        public static MaterialDialog Input(this MaterialDialog dialog, string value, InputTypes inputType, Action<MaterialDialog, ICharSequence> callback)
        {
            return DialogInputExtKt.Input(dialog, DEFAULT_HINT, DEFAULT_HINT_RES, value, DEFAULT_PREFILL_RES, (int)inputType, DEFAULT_MAX_LENGTH, DEFAULT_WAIT_FOR_POSITIVE_BUTTON, DEFAULT_ALLOW_EMPTY, new Function2Impl<MaterialDialog, ICharSequence>(callback));
        }


    }
}