using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using MaterialDialogs.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AFollestad.MaterialDialogs
{

    public partial class MaterialDialog
    {
        public MaterialDialog(Context windowContext): this(windowContext, DEFAULT_BEHAVIOR)
        {
            
        }

        public MaterialDialog Title( string title)
        {
            return Title(null, title);
        }

        public MaterialDialog Message(string message)
        {
            return Message(null, message, null);
        }
        
        public MaterialDialog PositiveButton(string text, Action<MaterialDialog> dialog)
        {
            return PositiveButton(null, text, new Function1Impl<MaterialDialog>(dialog));
        }
        public MaterialDialog NegativeButton(string text, Action<MaterialDialog> dialog)
        {
            return NegativeButton(null, text, new Function1Impl<MaterialDialog>(dialog));
        }

        public MaterialDialog PositiveButton(string text)
        {
            return PositiveButton(null, text, null);
        }
        public MaterialDialog NegativeButton(string text)
        {
            return NegativeButton(null, text, null);
        }


        public string MessageText
        {
            get => null;
            set => View.ContentLayout.SetMessage(this, null, value, BodyFont, null);
        }
    }
}