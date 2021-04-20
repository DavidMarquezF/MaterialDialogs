using AFollestad.MaterialDialogs;
using AFollestad.MaterialDialogs.Color;
using Android.Runtime;
using Android.Text;
using Java.Lang;
using Kotlin.Jvm.Functions;
using MaterialDialogs.Utils;
using System;

namespace AFollestad.MaterialDialogs.Color
{
    public static class DialogColorChooserExt
    {
        const int[][] DEFAULT_SUB_COLORS = null;
        const Integer DEFAULT_INITIAL_SELECTION = null;
        const bool DEFAULT_WAIT_FOR_POSITIVE_BUTTON = true;
        const bool DEFAULT_ALLOW_CUSTOM_ARGB = false;
        const bool DEFAULT_SHOW_ALPHA_SELECTOR = false;
        const bool DEFAULT_CHANGE_ACTION_BUTTONS_COLOR = false;
        const IFunction2 DEFAULT_SELECTION_CALLBACK = null;
       

        public static MaterialDialog ColorChooser(this MaterialDialog dialog, int[] colors, Action<MaterialDialog, Integer> callback,bool waitForPositiveButton = DEFAULT_WAIT_FOR_POSITIVE_BUTTON, bool allowCustomArgb=DEFAULT_ALLOW_CUSTOM_ARGB, bool allowAlphaSelector= DEFAULT_SHOW_ALPHA_SELECTOR, bool changeActionButtonColor= DEFAULT_CHANGE_ACTION_BUTTONS_COLOR)
        {
            return DialogColorChooserExtKt.ColorChooser (dialog, colors, DEFAULT_SUB_COLORS, DEFAULT_INITIAL_SELECTION, waitForPositiveButton, allowCustomArgb, allowAlphaSelector, changeActionButtonColor, new Function2Impl<MaterialDialog, Integer>(callback));
        }

        public static MaterialDialog ColorChooser(this MaterialDialog dialog, int[] colors, int[][] subcolors, Action<MaterialDialog, Integer> callback, bool waitForPositiveButton = DEFAULT_WAIT_FOR_POSITIVE_BUTTON, bool allowCustomArgb = DEFAULT_ALLOW_CUSTOM_ARGB, bool allowAlphaSelector = DEFAULT_SHOW_ALPHA_SELECTOR, bool changeActionButtonColor = DEFAULT_CHANGE_ACTION_BUTTONS_COLOR)
        {
            return DialogColorChooserExtKt.ColorChooser(dialog, colors, subcolors, DEFAULT_INITIAL_SELECTION, waitForPositiveButton, allowCustomArgb, allowAlphaSelector, changeActionButtonColor, new Function2Impl<MaterialDialog, Integer>(callback));
        }

        public static MaterialDialog ColorChooser(this MaterialDialog dialog, int[] colors, int initialSelection, Action<MaterialDialog, Integer> callback, bool waitForPositiveButton = DEFAULT_WAIT_FOR_POSITIVE_BUTTON, bool allowCustomArgb = DEFAULT_ALLOW_CUSTOM_ARGB, bool allowAlphaSelector = DEFAULT_SHOW_ALPHA_SELECTOR, bool changeActionButtonColor = DEFAULT_CHANGE_ACTION_BUTTONS_COLOR)
        {
            return DialogColorChooserExtKt.ColorChooser(dialog, colors, DEFAULT_SUB_COLORS, new Integer(initialSelection), waitForPositiveButton, allowCustomArgb, allowAlphaSelector, changeActionButtonColor, new Function2Impl<MaterialDialog, Integer>(callback));
        }

        public static MaterialDialog ColorChooser(this MaterialDialog dialog, int[] colors, int[][] subcolors, int initialSelection, Action<MaterialDialog, Integer> callback, bool waitForPositiveButton = DEFAULT_WAIT_FOR_POSITIVE_BUTTON, bool allowCustomArgb = DEFAULT_ALLOW_CUSTOM_ARGB, bool allowAlphaSelector = DEFAULT_SHOW_ALPHA_SELECTOR, bool changeActionButtonColor = DEFAULT_CHANGE_ACTION_BUTTONS_COLOR)
        {
            return DialogColorChooserExtKt.ColorChooser(dialog, colors, subcolors, new Integer(initialSelection), waitForPositiveButton, allowCustomArgb, allowAlphaSelector, changeActionButtonColor, new Function2Impl<MaterialDialog, Integer>(callback));
        }


    }
}